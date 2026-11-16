## Summary

```csharp
public static Vector2 NormalizedSizeToPixels(Vector2 normalizedSize)
```

Converts a normalized [0,1] size to pixels. Note X and Y scale by different amounts, because the safe GUI rectangle is not square, which is why an equal normalized X and Y is not square on screen.

## Returns

[Vector2](VRageMath.Vector2)

## Parameters

* [Vector2](VRageMath.Vector2) normalizedSize
