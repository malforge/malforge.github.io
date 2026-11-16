**Assembly:** Sandbox.Game.dll

```csharp
public abstract sealed class MyScreenSpace
```

Converts between the two coordinate spaces used by [MyScreenSpaceText](Sandbox.ModAPI.MyScreenSpaceText) and [MyScreenSpaceSprite](Sandbox.ModAPI.MyScreenSpaceSprite) , for laying out content that mixes them, and reports the cursor position in those same coordinates for hit testing what a mod has drawn. It also clips drawing to a rectangle, which is what scrolling lists, progress fills and panels that content must not spill out of are built from.  
  
Normalized [0,1] isa fraction of the window. It is relative to the game's safe GUI rectangle, which is a centred, roughly 4:3 area, so on a wide screen normalized 0 sits well inside the left edge. Pixel coordinates are true window pixels. Computing one from the other by multiplying by the viewport size is therefore wrong; use these methods.

## Methods

|Member|Description|
|---|---|
|[static GetSafeGuiArea()](Sandbox.ModAPI.MyScreenSpace@GetSafeGuiArea)|The safe GUI rectangle in window pixels: the area normalized [0,1] maps onto.|
|[static NormalizedSizeToPixels(Vector2)](Sandbox.ModAPI.MyScreenSpace@NormalizedSizeToPixels)|Converts a normalized [0,1] size to pixels. Note X and Y scale by different amounts, because the safe GUI rectangle is not square, which is why an equal normalized X and Y is not square on screen.|
|[static NormalizedToPixels(Vector2)](Sandbox.ModAPI.MyScreenSpace@NormalizedToPixels)|Converts a normalized [0,1] position, relative to the safe GUI rectangle, to window pixels.|
|[static PixelSizeToNormalized(Vector2)](Sandbox.ModAPI.MyScreenSpace@PixelSizeToNormalized)|Converts a pixel size to normalized [0,1].|
|[static PixelsToNormalized(Vector2)](Sandbox.ModAPI.MyScreenSpace@PixelsToNormalized)|Converts a window pixel position to normalized [0,1] relative to the safe GUI rectangle. Positions outside that rectangle fall outside [0,1], which is expected rather than an error.|
|[static TryGetCursorPosition(out Vector2)](Sandbox.ModAPI.MyScreenSpace@TryGetCursorPosition)|The GUI cursor position, normalized [0,1] relative to the safe GUI rectangle. This is the same space [Draw(MyStringId, Vector2, Vector2, Color, MyGuiDrawAlignEnum, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceSprite@Draw) takes, so a hit test can compare it directly against the coordinates content was drawn at, and it is the same value the game's own controls test against.|
|[static TryGetCursorPositionPixels(out Vector2)](Sandbox.ModAPI.MyScreenSpace@TryGetCursorPositionPixels)|Pixel counterpart of [TryGetCursorPosition(out Vector2)](Sandbox.ModAPI.MyScreenSpace@TryGetCursorPosition) , for hit testing content placed with [DrawPixels(MyStringId, Rectangle, Rectangle?, Color, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceSprite@DrawPixels) .|
|[static UsingScissorRectangle(RectangleF, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpace@UsingScissorRectangle)|Clips everything drawn inside the returned scope to a normalized rectangle, so a list can scroll under a fixed frame, a bar can be filled by revealing a wider sprite, and text can run out of a panel without spilling over its edge. The game's own scrollable lists and text boxes are built the same way.|
|[static UsingScissorRectanglePixels(Rectangle, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpace@UsingScissorRectanglePixels)|Pixel counterpart of [UsingScissorRectangle(RectangleF, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpace@UsingScissorRectangle) , for clipping content placed with the pixel-positioned draw calls.|

