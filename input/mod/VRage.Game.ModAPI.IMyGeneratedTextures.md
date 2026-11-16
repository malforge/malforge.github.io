**Assembly:** VRage.Game.dll

```csharp
public interface IMyGeneratedTextures
```

Creates textures a mod fills with its own pixels. Reached through`MyAPIGateway.GeneratedTextures`.

## Properties

|Member|Description|
|---|---|
|[IsSupported](VRage.Game.ModAPI.IMyGeneratedTextures@IsSupported)|False where there is no renderer to upload to — a dedicated server. Textures still create and update there, they simply go nowhere, so check this before spending anything on producing the pixels.|
|[MaxTextureSide](VRage.Game.ModAPI.IMyGeneratedTextures@MaxTextureSide)|Largest allowed value for either side of a texture.|

## Methods

|Member|Description|
|---|---|
|[Create(string, Vector2I, MyGeneratedTextureFormat)](VRage.Game.ModAPI.IMyGeneratedTextures@Create)|Creates an empty texture the caller owns. Dispose it when you are done — nothing else will, and neither the block nor the surface you drew it on going away releases it. Anything still alive when the world unloads is released then.|

