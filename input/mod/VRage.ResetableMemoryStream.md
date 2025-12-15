**Assembly:** VRage.Library.dll

```csharp
public class ResetableMemoryStream: Stream, IDisposable
```

## Properties

|Member|Description|
|---|---|
|[CanRead](VRage.ResetableMemoryStream@CanRead)||
|[CanSeek](VRage.ResetableMemoryStream@CanSeek)||
|[CanWrite](VRage.ResetableMemoryStream@CanWrite)||
|[Length](VRage.ResetableMemoryStream@Length)||
|[Position](VRage.ResetableMemoryStream@Position)||

## Constructors

|Member|Description|
|---|---|
|[ResetableMemoryStream()](VRage.ResetableMemoryStream@.ctor)||
|[ResetableMemoryStream(Byte[], int)](VRage.ResetableMemoryStream@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Flush()](VRage.ResetableMemoryStream@Flush)||
|[GetInternalBuffer()](VRage.ResetableMemoryStream@GetInternalBuffer)||
|[Read(Byte[], int, int)](VRage.ResetableMemoryStream@Read)|Original C# implementation|
|[Reset(Byte[], int)](VRage.ResetableMemoryStream@Reset)||
|[Seek(long, SeekOrigin)](VRage.ResetableMemoryStream@Seek)||
|[SetLength(long)](VRage.ResetableMemoryStream@SetLength)||
|[Write(Byte[], int, int)](VRage.ResetableMemoryStream@Write)|Original C# implementation|

**Inheritance:**   [Stream](https://docs.microsoft.com/en-us/dotnet/api/System.IO.Stream?view=netframework-4.6)

**Implements:**  
* [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable?view=netframework-4.6)

