## Summary

```csharp
public static void DrawPixels(MyStringId material, Rectangle destination, Rectangle? source, Color color, float rotation, MyScreenSpaceLayer layer)
```

Pixel-positioned counterpart of [Draw(MyStringId, Vector2, Vector2, Color, MyGuiDrawAlignEnum, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceSprite@Draw) , rotating about the destination's centre. Pass a source rectangle to take one region out of a larger texture, which is how sprite sheets are used.

## Parameters

* [MyStringId](VRage.Utils.MyStringId) material
* [Rectangle](VRageMath.Rectangle) destination
* [Rectangle?](VRageMath.Rectangle) source
* [Color](VRageMath.Color) color
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) rotation
* [MyScreenSpaceLayer](Sandbox.ModAPI.MyScreenSpaceLayer) layer
