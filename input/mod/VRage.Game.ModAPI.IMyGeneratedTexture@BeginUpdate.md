## Summary

```csharp
public Byte[] BeginUpdate()
```

Borrows a [ByteCount](VRage.Game.ModAPI.IMyGeneratedTexture@ByteCount) -byte buffer to write the next image into. Fill it, then hand it to [EndUpdate(Byte[])](VRage.Game.ModAPI.IMyGeneratedTexture@EndUpdate) ; do not keep it afterwards, and do not assume it still holds what you last wrote — the same few buffers are cycled as the renderer finishes with them.Pixel order is top-down, tightly packed, four bytes per pixel as R, G, B, A.  
  
Colour channels must be premultiplied by alpha: the sprite pass treats these as premultiplied, so straight alpha reads too bright wherever the image is translucent. Fully opaque and fully transparent pixels are the same under both conventions.

## Returns

[byte[]](https://docs.microsoft.com/en-us/dotnet/api/System.Byte?view=netframework-4.6)

A writable buffer, orif the texture has been disposed.

