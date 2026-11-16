## Summary

```csharp
public static MyScissorScope UsingScissorRectanglePixels(Rectangle pixelRectangle, MyScreenSpaceLayer layer)
```

Pixel counterpart of [UsingScissorRectangle(RectangleF, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpace@UsingScissorRectangle) , for clipping content placed with the pixel-positioned draw calls.

## Returns

[MyScissorScope](Sandbox.ModAPI.MyScreenSpace+MyScissorScope)

A scope to dispose once the clipped drawing is done; see [UsingScissorRectangle(RectangleF, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpace@UsingScissorRectangle) .

## Parameters

* [Rectangle](VRageMath.Rectangle) pixelRectangle
* [MyScreenSpaceLayer](Sandbox.ModAPI.MyScreenSpaceLayer) layer
