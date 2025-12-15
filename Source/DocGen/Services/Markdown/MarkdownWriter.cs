using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DocGen.Services.Markdown
{
    internal class MarkdownWriter
    {
        static readonly string[] NewLines = { "\r\n", "\n", "\r" };
        readonly Stack<ITransaction> _transaction = new Stack<ITransaction>();

        readonly TextWriter _writer;

        public MarkdownWriter(TextWriter writer)
        {
            _writer = writer;
            _transaction.Push(new RootTransaction(this));
        }

        static string SoftNewlines(string text)
        {
            return Regex.Replace(text, @" *(?:\r\n|\n|\r)", $"  {Environment.NewLine}");
        }

        static string HtmlNewlines(string text)
        {
            return Regex.Replace(text, @" *(?:\r\n|\n|\r)", "<br />");
        }

        static string TrimNewlines(string text)
        {
            var lines = text.Split(NewLines, StringSplitOptions.None).ToList();
            while (lines.Count > 0 && string.IsNullOrWhiteSpace(lines[lines.Count - 1]))
                lines.RemoveAt(lines.Count - 1);
            while (lines.Count > 0 && string.IsNullOrWhiteSpace(lines[0]))
                lines.RemoveAt(0);
            return string.Join(Environment.NewLine, lines);
        }

        void EndTransaction(ITransaction transaction)
        {
            if (_transaction.Count == 1)
                throw new InvalidOperationException("No transaction to end");
            if (_transaction.Peek() != transaction)
                throw new InvalidOperationException("Bad transaction disposal order");
            _transaction.Pop();
        }

        public Task WriteAsync(string text)
        {
            return _transaction.Peek().WriteAsync(text);
        }

        public Task WriteLineAsync(string text)
        {
            return _transaction.Peek().WriteLineAsync(text);
        }

        public Task WriteLineAsync()
        {
            return WriteLineAsync("");
        }

        readonly Stack<string> _beginStack = new Stack<string>();
        
        public Task BeginParagraphAsync()
        {
            _beginStack.Push(Environment.StackTrace);
            _transaction.Push(new ParagraphTransaction(this));
            return Task.CompletedTask;
        }

        public Task EndParagraphAsync()
        {
            try
            {
                return ((ParagraphTransaction)_transaction.Peek()).CommitAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Paragraph began at: " + _beginStack.Peek());
                throw;
            }
            finally
            {
                _beginStack.Pop();
            }
        }

        public Task BeginCodeBlockAsync()
        {
            _beginStack.Push(Environment.StackTrace);
            _transaction.Push(new CodeTransaction(this));
            return Task.CompletedTask;
        }

        public Task EndCodeBlockAsync()
        {
            try
            {
                return ((CodeTransaction)_transaction.Peek()).CommitAsync();
            }
            catch (Exception e)
            {
                Debug.WriteLine("Code block began at: " + _beginStack.Peek());
                throw;
            }
            finally
            {
                _beginStack.Pop();
            }
        }

        public Task BeginQuoteAsync()
        {
            _transaction.Push(new QuoteTransaction(this));
            return Task.CompletedTask;
        }

        public Task EndQuoteAsync()
        {
            return ((QuoteTransaction)_transaction.Peek()).CommitAsync();
        }

        public async Task WriteHeaderAsync(int type, string text)
        {
            await WriteAsync(new string('#', type));
            await WriteAsync(" ");
            await WriteLineAsync(HtmlNewlines(TrimNewlines(text)));
            await WriteLineAsync();
        }

        public async Task WriteUnorderedListItemAsync(string text)
        {
            await WriteAsync("* ");
            await WriteLineAsync(SoftNewlines(TrimNewlines(text)));
        }

        public Task BeginTableAsync(params string[] headers)
        {
            _transaction.Push(new TableTransaction(this, headers));
            return Task.CompletedTask;
        }

        public Task EndTableAsync()
        {
            return ((TableTransaction)_transaction.Peek()).CommitAsync();
        }

        public Task BeginTableCellAsync()
        {
            var table = _transaction.Peek() as TableTransaction;
            if (table == null)
                throw new InvalidOperationException("Table Cells must be within Tables");
            _transaction.Push(new TableCellTransaction(this, table));
            return Task.CompletedTask;
        }

        public Task EndTableCellAsync()
        {
            return ((TableCellTransaction)_transaction.Peek()).CommitAsync();
        }

        public Task FlushAsync()
        {
            return _writer.FlushAsync();
        }

        public async Task WriteImageLinkAsync(string description, string imageUrl)
        {
            await WriteAsync("![");
            await WriteAsync(description);
            await WriteAsync("](");
            await WriteAsync(imageUrl);
            await WriteAsync(")");
        }

        public async Task WriteLinkAsync(string description, string url)
        {
            await WriteAsync("[");
            await WriteAsync(description);
            await WriteAsync("](");
            await WriteAsync(url);
            await WriteAsync(")");
        }

        public Task WriteRulerAsync()
        {
            return WriteLineAsync("- - -");
        }

        public interface ITransaction
        {
            Task WriteAsync(string text);
            Task WriteLineAsync(string text);
            Task CommitAsync();
        }

        class RootTransaction : ITransaction
        {
            readonly MarkdownWriter _writer;

            public RootTransaction(MarkdownWriter writer)
            {
                _writer = writer;
            }

            public Task WriteAsync(string text)
            {
                return _writer._writer.WriteAsync(text);
            }

            public Task WriteLineAsync(string text)
            {
                return _writer._writer.WriteLineAsync(text);
            }

            public Task CommitAsync()
            {
                return Task.CompletedTask;
            }
        }

        class ParagraphTransaction : ITransaction
        {
            readonly StringWriter _buffer = new StringWriter();
            readonly MarkdownWriter _writer;

            public ParagraphTransaction(MarkdownWriter writer)
            {
                _writer = writer;
            }

            public Task WriteAsync(string text)
            {
                return _buffer.WriteAsync(text);
            }

            public Task WriteLineAsync(string text)
            {
                return _buffer.WriteLineAsync(text);
            }

            public async Task CommitAsync()
            {
                _writer.EndTransaction(this);
                var content = SoftNewlines(TrimNewlines(_buffer.ToString()));
                await _writer.WriteLineAsync(content);
                await _writer.WriteLineAsync();
            }
        }

        class QuoteTransaction : ITransaction
        {
            readonly StringWriter _buffer = new StringWriter();
            readonly MarkdownWriter _writer;

            public QuoteTransaction(MarkdownWriter writer)
            {
                _writer = writer;
            }

            public Task WriteAsync(string text)
            {
                return _buffer.WriteAsync(text);
            }

            public Task WriteLineAsync(string text)
            {
                return _buffer.WriteLineAsync(text);
            }

            public async Task CommitAsync()
            {
                _writer.EndTransaction(this);
                var finalLines = TrimNewlines(_buffer.ToString()).Split(NewLines, StringSplitOptions.None);
                for (var i = 0; i < finalLines.Length; i++) finalLines[i] = "> " + finalLines[i];
                await _writer.WriteLineAsync(string.Join($"  {Environment.NewLine}", finalLines));
                await _writer.WriteLineAsync();
            }
        }

        class CodeTransaction : ITransaction
        {
            readonly StringWriter _buffer = new StringWriter();
            readonly MarkdownWriter _writer;

            public CodeTransaction(MarkdownWriter writer)
            {
                _writer = writer;
            }

            public Task WriteAsync(string text)
            {
                return _buffer.WriteAsync(text);
            }

            public Task WriteLineAsync(string text)
            {
                return _buffer.WriteLineAsync(text);
            }

            public async Task CommitAsync()
            {
                _writer.EndTransaction(this);
                await _writer.WriteLineAsync("```csharp");
                var content = SoftNewlines(TrimNewlines(_buffer.ToString()));
                await _writer.WriteLineAsync(content);
                await _writer.WriteLineAsync("```");
                await _writer.WriteLineAsync();
            }
        }

        class TableTransaction : ITransaction
        {
            readonly List<string> _cells = new List<string>();
            readonly string[] _headers;
            readonly MarkdownWriter _writer;

            public TableTransaction(MarkdownWriter writer, string[] headers)
            {
                _writer = writer;
                _headers = headers;
            }

            public Task WriteAsync(string text)
            {
                throw new InvalidOperationException("Begin a cell first");
            }

            public Task WriteLineAsync(string text)
            {
                throw new InvalidOperationException("Begin a cell first");
            }

            public async Task CommitAsync()
            {
                _writer.EndTransaction(this);
                await _writer.WriteAsync("|");
                await _writer.WriteAsync(string.Join("|", _headers.Select(h => HtmlNewlines(TrimNewlines(h)))));
                await _writer.WriteLineAsync("|");
                await _writer.WriteAsync("|");
                await _writer.WriteAsync(string.Join("|", Enumerable.Range(0, _headers.Length).Select(n => "---")));
                await _writer.WriteLineAsync("|");

                var rows = (int)Math.Ceiling(_cells.Count / (double)_headers.Length);
                for (var row = 0; row < rows; row++)
                {
                    var range = _cells.Skip(row * _headers.Length).Take(_headers.Length);
                    await _writer.WriteAsync("|");
                    await _writer.WriteAsync(string.Join("|", range));
                    await _writer.WriteLineAsync("|");
                }

                await _writer.WriteLineAsync();
            }

            public void AddCell(string content)
            {
                _cells.Add(content);
            }
        }

        class TableCellTransaction : ITransaction
        {
            readonly StringWriter _buffer = new StringWriter();
            readonly TableTransaction _table;
            readonly MarkdownWriter _writer;

            public TableCellTransaction(MarkdownWriter writer, TableTransaction table)
            {
                _writer = writer;
                _table = table;
            }

            public Task WriteAsync(string text)
            {
                return _buffer.WriteAsync(text);
            }

            public Task WriteLineAsync(string text)
            {
                return _buffer.WriteLineAsync(text);
            }

            public Task CommitAsync()
            {
                _writer.EndTransaction(this);
                _table.AddCell(HtmlNewlines(TrimNewlines(_buffer.ToString())));
                return Task.CompletedTask;
            }
        }
    }
}