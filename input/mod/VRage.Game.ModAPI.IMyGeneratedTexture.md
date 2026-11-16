**Assembly:** VRage.Game.dll

```csharp
public interface IMyGeneratedTexture: IDisposable
```

A texture whose pixels a mod writes itself, created through [Create(string, Vector2I, MyGeneratedTextureFormat)](VRage.Game.ModAPI.IMyGeneratedTextures@Create) . Give [Name](VRage.Game.ModAPI.IMyGeneratedTexture@Name) anywhere the game takes a texture path — an LCD sprite of type`VRage.Game.GUI.TextPanel.SpriteType.TEXTURE`, for instance — and the renderer resolves it to this texture.Content that is already an image, such as a rendered map or a decoded video frame, costs one upload here against one textured quad per pixel if it were encoded as sprites for the panel to draw back into pixels.

## Properties

|Member|Description|
|---|---|
|[ByteCount](VRage.Game.ModAPI.IMyGeneratedTexture@ByteCount)|Length of the buffer [BeginUpdate()](VRage.Game.ModAPI.IMyGeneratedTexture@BeginUpdate) hands out —`Size.X * Size.Y * 4`.|
|[Format](VRage.Game.ModAPI.IMyGeneratedTexture@Format)|Pixel format, fixed for the lifetime of the texture.|
|[IsValid](VRage.Game.ModAPI.IMyGeneratedTexture@IsValid)|True until [Dispose()](https://docs.microsoft.com/en-us/dotnet/api/system.idisposable.dispose?view=netframework-4.6) is called, after which every method here does nothing.|
|[MaterialId](VRage.Game.ModAPI.IMyGeneratedTexture@MaterialId)| [Name](VRage.Game.ModAPI.IMyGeneratedTexture@Name) as the id`Sandbox.ModAPI.MyScreenSpaceSprite`takes, interned once here rather than per call —`MyStringId.GetOrCompute`never releases what it interns, and every texture gets a name of its own. [NullOrEmpty](VRage.Utils.MyStringId@NullOrEmpty) once the texture has been disposed.|
|[Name](VRage.Game.ModAPI.IMyGeneratedTexture@Name)|Unique name of this texture, assigned at creation. Pass it wherever a texture path is expected. Empty once the texture has been disposed.|
|[Size](VRage.Game.ModAPI.IMyGeneratedTexture@Size)|Pixel dimensions, fixed for the lifetime of the texture.|

## Methods

|Member|Description|
|---|---|
|[BeginUpdate()](VRage.Game.ModAPI.IMyGeneratedTexture@BeginUpdate)|Borrows a [ByteCount](VRage.Game.ModAPI.IMyGeneratedTexture@ByteCount) -byte buffer to write the next image into. Fill it, then hand it to [EndUpdate(Byte[])](VRage.Game.ModAPI.IMyGeneratedTexture@EndUpdate) ; do not keep it afterwards, and do not assume it still holds what you last wrote — the same few buffers are cycled as the renderer finishes with them.Pixel order is top-down, tightly packed, four bytes per pixel as R, G, B, A.<br /><br />Colour channels must be premultiplied by alpha: the sprite pass treats these as premultiplied, so straight alpha reads too bright wherever the image is translucent. Fully opaque and fully transparent pixels are the same under both conventions.|
|[EndUpdate(Byte[])](VRage.Game.ModAPI.IMyGeneratedTexture@EndUpdate)|Hands the filled buffer to the renderer, which replaces the whole image with it and rebuilds the mip chain. The buffer belongs to the renderer from here on — write to it again and you will see a torn image.|

**Implements:**  
* [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable?view=netframework-4.6)

