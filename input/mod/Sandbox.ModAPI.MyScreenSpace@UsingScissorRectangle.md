## Summary

```csharp
public static MyScissorScope UsingScissorRectangle(RectangleF normalizedRectangle, MyScreenSpaceLayer layer)
```

Clips everything drawn inside the returned scope to a normalized rectangle, so a list can scroll under a fixed frame, a bar can be filled by revealing a wider sprite, and text can run out of a panel without spilling over its edge. The game's own scrollable lists and text boxes are built the same way.

## Returns

[MyScissorScope](Sandbox.ModAPI.MyScreenSpace+MyScissorScope)

A scope to dispose once the clipped drawing is done. Always use it with`using`: a scope that is never disposed clips the rest of the frame, and is closed for you when the frame ends.

## Parameters

* [RectangleF](VRageMath.RectangleF) normalizedRectangle
* [MyScreenSpaceLayer](Sandbox.ModAPI.MyScreenSpaceLayer) layer
