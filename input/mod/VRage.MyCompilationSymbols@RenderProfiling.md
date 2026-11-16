## Summary

```csharp
public static bool RenderProfiling
```

Render-only profiling. Keeps the profiler call sites of the render assemblies alive — the render thread's CPU blocks and the GPU timestamp blocks — while every game-side one stays compiled out, so DX12 can be profiled without [PerformanceProfiling](VRage.MyCompilationSymbols@PerformanceProfiling) , whose whole-game instrumentation costs a dictionary lookup and a timestamp on every block in the simulation and which the DX12 renderer has no buildable configuration for. Works because the symbol is only in the render projects' DefineConstants, and`[Conditional]`is resolved against the caller's defines.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

