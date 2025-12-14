using Markdig;
using Markdig.Renderers;
using Markdig.Renderers.Html.Inlines;
using Markdig.Syntax.Inlines;

namespace MdkApiGen;

public class LinkRewriterExtension : IMarkdownExtension
{
    private readonly HashSet<string> _referencedAssets;

    public LinkRewriterExtension(HashSet<string> referencedAssets)
    {
        _referencedAssets = referencedAssets;
    }

    public void Setup(MarkdownPipelineBuilder pipeline)
    {
    }

    public void Setup(MarkdownPipeline pipeline, IMarkdownRenderer renderer)
    {
        if (renderer is HtmlRenderer htmlRenderer)
        {
            var linkRenderer = htmlRenderer.ObjectRenderers.FindExact<LinkInlineRenderer>();
            if (linkRenderer != null)
            {
                htmlRenderer.ObjectRenderers.Remove(linkRenderer);
            }
            htmlRenderer.ObjectRenderers.AddIfNotAlready(new HtmlLinkRewriter(_referencedAssets));
        }
    }
}

public class HtmlLinkRewriter : LinkInlineRenderer
{
    private readonly HashSet<string> _referencedAssets;
    private static readonly string[] ImageExtensions = { ".png", ".jpg", ".jpeg", ".gif", ".svg", ".bmp", ".webp", ".ico" };

    public HtmlLinkRewriter(HashSet<string> referencedAssets)
    {
        _referencedAssets = referencedAssets;
    }

    protected override void Write(HtmlRenderer renderer, LinkInline link)
    {
        // Track image references
        if (link.IsImage && link.Url != null && 
            !link.Url.StartsWith("http://") && 
            !link.Url.StartsWith("https://"))
        {
            var normalizedUrl = link.Url.Replace('/', Path.DirectorySeparatorChar);
            _referencedAssets.Add(normalizedUrl);
        }

        // Only rewrite links if they don't already have .html extension and aren't external or images
        if (link.Url != null && 
            !link.IsImage &&
            !link.Url.StartsWith("http://") && 
            !link.Url.StartsWith("https://") &&
            !link.Url.StartsWith("#") &&
            !link.Url.EndsWith(".html") &&
            !link.Url.EndsWith(".htm"))
        {
            link.Url += ".html";
        }

        base.Write(renderer, link);
    }
}
