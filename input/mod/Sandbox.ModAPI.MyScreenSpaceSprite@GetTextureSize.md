## Summary

```csharp
public static Vector2 GetTextureSize(MyStringId material)
```

Size of the material's texture in pixels, for sizing sprites to their source art or for building source rectangles, or zero if the material is unknown. The first lookup of a texture reads its header from disk, so cache the result instead of calling this every frame.

## Returns

[Vector2](VRageMath.Vector2)

## Parameters

* [MyStringId](VRage.Utils.MyStringId) material
