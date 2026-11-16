## Summary

```csharp
public static void DrawPixels(string font, string text, Vector2 pixelPosition, float scale, Color color, MyGuiDrawAlignEnum align, float maxWidth, MyScreenSpaceLayer layer)
```

Pixel-positioned counterpart of [Draw(string, string, Vector2, float, Color, MyGuiDrawAlignEnum, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceText@Draw) . Sizes still scale with the player's UI Scale setting, so this is not a way to get pixel-exact output at every UI scale.

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) font
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) text
* [Vector2](VRageMath.Vector2) pixelPosition
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) scale
* [Color](VRageMath.Color) color
* [MyGuiDrawAlignEnum](VRage.Utils.MyGuiDrawAlignEnum) align
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) maxWidth
* [MyScreenSpaceLayer](Sandbox.ModAPI.MyScreenSpaceLayer) layer
