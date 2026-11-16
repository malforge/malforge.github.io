**Assembly:** VRage.Game.dll

```csharp
public enum MyGeneratedTextureFormat
```

Pixel layout of an [IMyGeneratedTexture](VRage.Game.ModAPI.IMyGeneratedTexture) . Every format is four bytes per pixel, in R, G, B, A order.

## Fields

|Member|Description|
|---|---|
|Linear|Linear colour, sampled without an sRGB conversion. For data that happens to be shaped like an image — masks, lookup tables — rather than something meant to be looked at.|
|Srgb|sRGB colour. Matches how the game stores ordinary textures, so a colour written here shows up the same as the same colour in a texture file. This is what you want unless you know otherwise.|

