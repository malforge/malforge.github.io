## Summary

```csharp
public void UpdateTextureFromRawData(int area, Byte[] data, Vector2I textureSize)
```

Replaces a screen area's texture with raw pixels, bypassing the sprite pipeline entirely — no [MySprite](VRage.Game.GUI.TextPanel.MySprite) list, no glyph-to-quad expansion and no offscreen render pass, just an upload. For content that is already an image (a rendered map, a decoded video frame) this is far cheaper than encoding it as sprites for [RenderSpritesToTexture(int, ListReader<MySprite>, Vector2I, Vector2, Color, byte)](Sandbox.Game.Components.MyRenderComponentScreenAreas@RenderSpritesToTexture) to draw back into pixels.datais mip 0 alone: tightly packed, top-down, RGBA one byte per channel, at leasttextureSizeworth of bytes (a larger pooled buffer is fine — the extra is ignored). The renderer rebuilds the mip chain and marks the texture ready. Unlike the sprite path there is no aspect-ratio correction, so the buffer must already be at the area's texture resolution.  
  
The area's generated texture must exist — see [CreateTexture(int, Vector2I)](Sandbox.Game.Components.MyRenderComponentScreenAreas@CreateTexture) .

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) area
* [byte[]](https://docs.microsoft.com/en-us/dotnet/api/System.Byte?view=netframework-4.6) data
* [Vector2I](VRageMath.Vector2I) textureSize
