## Summary

```csharp
public static bool DX12DetectCrossFrameWrites
```

Diagnostic: report every CPU write to a buffer the GPU may still be reading — a write whose target was last bound by a frame the GPU has not finished. Unlike the discard-map tally this covers all write paths and reports the race actually happening rather than the buffer merely being at risk, and unlike [DX12SerializeFrames](VRage.MyCompilationSymbols@DX12SerializeFrames) it does not perturb timing, so it can catch an artifact that only appears at full speed. Never ship it on.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

