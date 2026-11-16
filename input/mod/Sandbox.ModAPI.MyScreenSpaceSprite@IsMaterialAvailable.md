## Summary

```csharp
public static bool IsMaterialAvailable(MyStringId material)
```

Whether an id resolves to a texture usable here, through any of the sources this class accepts. Render-target and atlas-packed materials are rejected even though billboards accept them.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [MyStringId](VRage.Utils.MyStringId) material
