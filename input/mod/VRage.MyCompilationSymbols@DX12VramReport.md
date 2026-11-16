## Summary

```csharp
public static bool DX12VramReport
```

Diagnostic: log the per-second VRAM breakdown (file textures, buffer pools, unaccounted). Off by default because each line walks every registered texture and pool on the render thread and adds ~350 lines per five minutes of log. Peaks, the sampler thread and the over-budget warning stay on regardless.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

