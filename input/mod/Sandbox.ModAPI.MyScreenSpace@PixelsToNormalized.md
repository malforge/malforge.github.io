## Summary

```csharp
public static Vector2 PixelsToNormalized(Vector2 pixelPosition)
```

Converts a window pixel position to normalized [0,1] relative to the safe GUI rectangle. Positions outside that rectangle fall outside [0,1], which is expected rather than an error.

## Returns

[Vector2](VRageMath.Vector2)

## Parameters

* [Vector2](VRageMath.Vector2) pixelPosition
