## Summary

```csharp
public static bool DX12DebugLayer
```

D3D12 debug layer (DX12 backend bring-up). Costs real frame time — validation runs on every API call and every stored message is marshalled out in`DrainDebugMessages`— so turn it off when measuring frame time and back on when bringing up a new pass family. Must be set before device creation to have any effect.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

