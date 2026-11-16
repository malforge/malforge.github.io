## Summary

```csharp
public static bool DX12DStorageSmokeTest
```

Debug-only DirectStorage interop smoke test: right after D3D12 device creation, DStorage-read one content DDS into memory and byte-compare against File.ReadAllBytes, logging [DStorage] PASSED/FAILED. Proves the whole interop layer (factory, file, queue, request struct layout, status array, fence signal) with no renderer integration. Compiled out of Release entirely.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

