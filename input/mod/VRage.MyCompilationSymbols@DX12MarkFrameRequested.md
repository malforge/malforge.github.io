## Summary

```csharp
public static bool DX12MarkFrameRequested
```

One-shot request (Ctrl+Shift+M) to stamp the render log with the current frame number and per-frame counters, so a visually-spotted artifact can be located in continuously-running traces. Set from the game thread, cleared by the render thread when it services it.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

