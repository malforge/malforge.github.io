## Summary

```csharp
public static bool GpuMarkers
```

GPU debug markers: a BeginEvent/EndEvent region around every RHI profiling block, so a PIX/Nsight/RenderDoc capture reads as named passes instead of a flat draw list. Separate from [PerformanceProfiling](VRage.MyCompilationSymbols@PerformanceProfiling) because that also collects timestamps and is only reachable in a RELEASE_PROFILE build, which the DX12 renderer has no buildable configuration for.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

