## Summary

```csharp
public static bool DX12GpuValidation
```

D3D12 GPU-based validation. Instruments the shaders, so out-of-bounds descriptor-table reads, uninitialised descriptors and wrong resource states are named in the log instead of surfacing as a bare`DXGI_ERROR_DEVICE_HUNG`. Drastically slower — turn on only to diagnose a GPU fault, and expect the slowdown itself to change frame timings. Requires [DX12DebugLayer](VRage.MyCompilationSymbols@DX12DebugLayer) ; must be set before device creation.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

