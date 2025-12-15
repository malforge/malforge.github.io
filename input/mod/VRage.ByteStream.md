**Assembly:** VRage.Library.dll

```csharp
public class ByteStream: Stream, IDisposable
```

## Fields

|Member|Description|
|---|---|
|[Expandable](VRage.ByteStream@Expandable)||
|[Resetable](VRage.ByteStream@Resetable)||

## Properties

|Member|Description|
|---|---|
|[CanRead](VRage.ByteStream@CanRead)||
|[CanSeek](VRage.ByteStream@CanSeek)||
|[CanWrite](VRage.ByteStream@CanWrite)||
|[Data](VRage.ByteStream@Data)||
|[Length](VRage.ByteStream@Length)||
|[Position](VRage.ByteStream@Position)||

## Constructors

|Member|Description|
|---|---|
|[ByteStream(int, bool)](VRage.ByteStream@.ctor)||
|[ByteStream()](VRage.ByteStream@.ctor)||
|[ByteStream(Byte[], int)](VRage.ByteStream@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CheckCapacity(long)](VRage.ByteStream@CheckCapacity)||
|[EnsureCapacity(long)](VRage.ByteStream@EnsureCapacity)||
|[Flush()](VRage.ByteStream@Flush)||
|[Read(Byte[], int, int)](VRage.ByteStream@Read)|Original C# implementation|
|[ReadByte()](VRage.ByteStream@ReadByte)||
|[ReadUShort()](VRage.ByteStream@ReadUShort)||
|[Reset(Byte[], int)](VRage.ByteStream@Reset)||
|[Seek(long, SeekOrigin)](VRage.ByteStream@Seek)||
|[SetLength(long)](VRage.ByteStream@SetLength)||
|[Write(Byte[], int, int)](VRage.ByteStream@Write)|Original C# implementation|
|[WriteByte(byte)](VRage.ByteStream@WriteByte)||
|[WriteUShort(ushort)](VRage.ByteStream@WriteUShort)||

**Inheritance:**   [Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream?view=netframework-4.6)

**Implements:**  
* [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable?view=netframework-4.6)

