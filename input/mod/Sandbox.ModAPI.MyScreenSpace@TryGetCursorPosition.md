## Summary

```csharp
public static bool TryGetCursorPosition(out Vector2 normalizedPosition)
```

The GUI cursor position, normalized [0,1] relative to the safe GUI rectangle. This is the same space [Draw(MyStringId, Vector2, Vector2, Color, MyGuiDrawAlignEnum, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceSprite@Draw) takes, so a hit test can compare it directly against the coordinates content was drawn at, and it is the same value the game's own controls test against.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

False when there is no cursor to test against, which is the case on a dedicated server and while a gamepad is the last device used. Treat that as nothing being pointed at rather than substituting a position: any fixed value reads as a hit somewhere on screen.

## Parameters

* [Vector2](VRageMath.Vector2) normalizedPosition
