## Summary

```csharp
public static bool TryGetCursorPositionPixels(out Vector2 pixelPosition)
```

Pixel counterpart of [TryGetCursorPosition(out Vector2)](Sandbox.ModAPI.MyScreenSpace@TryGetCursorPosition) , for hit testing content placed with [DrawPixels(MyStringId, Rectangle, Rectangle?, Color, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceSprite@DrawPixels) .

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

False when there is no cursor to test against; see [TryGetCursorPosition(out Vector2)](Sandbox.ModAPI.MyScreenSpace@TryGetCursorPosition) .

## Parameters

* [Vector2](VRageMath.Vector2) pixelPosition
