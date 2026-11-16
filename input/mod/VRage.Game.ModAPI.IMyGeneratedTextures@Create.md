## Summary

```csharp
public IMyGeneratedTexture Create(string nameHint, Vector2I size, MyGeneratedTextureFormat format)
```

Creates an empty texture the caller owns. Dispose it when you are done — nothing else will, and neither the block nor the surface you drew it on going away releases it. Anything still alive when the world unloads is released then.

## Returns

[IMyGeneratedTexture](VRage.Game.ModAPI.IMyGeneratedTexture)

The new texture, orifsizeis out of range or the session has reached its budget for mod textures. A reason is written to the log either way.

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) nameHint
* [Vector2I](VRageMath.Vector2I) size
* [MyGeneratedTextureFormat](VRage.Game.ModAPI.MyGeneratedTextureFormat) format
