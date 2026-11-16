## Summary

```csharp
public bool IsSupported { get; }
```

False where there is no renderer to upload to — a dedicated server. Textures still create and update there, they simply go nowhere, so check this before spending anything on producing the pixels.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

