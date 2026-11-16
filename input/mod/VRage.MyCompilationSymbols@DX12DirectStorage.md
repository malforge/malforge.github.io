## Summary

```csharp
public static bool DX12DirectStorage
```

DirectStorage file-to-GPU texture uploads. Cleared by the`-nodirectstorage`command line switch, which also keeps`dstorage.dll`from being loaded at all — the escape hatch for when the runtime itself is suspect. Must be set before device creation to stop the uploader from being created; flipping it later only steers subsequent loads back onto the CPU path.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

