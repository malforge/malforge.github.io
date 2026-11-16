## Summary

```csharp
public static void DrawPivoted(MyStringId material, Rectangle destination, Rectangle? source, Color color, float rotation, Vector2 pivotPixels, MyScreenSpaceLayer layer)
```

Draws a sprite rotating about an arbitrary pivot rather than its own centre, which is what gauge needles, swinging bars and radial fills need. The pivot may lie outside the destination rectangle.

## Parameters

* [MyStringId](VRage.Utils.MyStringId) material
* [Rectangle](VRageMath.Rectangle) destination
* [Rectangle?](VRageMath.Rectangle) source
* [Color](VRageMath.Color) color
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) rotation
* [Vector2](VRageMath.Vector2) pivotPixels
* [MyScreenSpaceLayer](Sandbox.ModAPI.MyScreenSpaceLayer) layer
