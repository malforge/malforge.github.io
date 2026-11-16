## Summary

```csharp
public static bool DX12DetectDirectDiscardMaps
```

Diagnostic: report a buffer`WriteDiscard`-mapped more than once in a frame on the path where discard renaming does not apply, where the second map overwrites what the draws recorded after the first still read. The only detector for that corruption — [DX12DetectCrossFrameWrites](VRage.MyCompilationSymbols@DX12DetectCrossFrameWrites) sees the cross-frame race instead. Turn it off when profiling/release: the tally takes a backend-wide lock on every such map, and the recording threads map in parallel.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

