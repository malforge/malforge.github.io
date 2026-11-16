**Assembly:** Sandbox.Game.dll

```csharp
public abstract sealed class MyScreenSpaceText
```

Draws text in screen space using the game's own fonts and text renderer.  
  
Immediate mode: every call draws for a single frame, so call it every frame, from a session component's [Draw()](VRage.Game.Components.MySessionComponentBase@Draw) for content over the game, or from the OnDraw of a [MyModScreen](Sandbox.ModAPI.MyModScreen) for the content of a mod's own screen, where the layer should be left at [BelowHud](Sandbox.ModAPI.MyScreenSpaceLayer@BelowHud) so it composites inside that screen. Must be called from the update thread.  
  
Fonts are named by the subtype id of a font definition, so any font declared in Fonts.sbc works, including ones added by mods. Because fonts are registered per session, always pass names rather than caching anything across worlds.

## Methods

|Member|Description|
|---|---|
|[static Draw(string, string, Vector2, float, Color, MyGuiDrawAlignEnum, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceText@Draw)|Draws a single-colour line or block of text. There is no markup: to mix colours, draw one call per colour run and advance the position using [Measure(string, string, float)](Sandbox.ModAPI.MyScreenSpaceText@Measure) .|
|[static DrawPixels(string, string, Vector2, float, Color, MyGuiDrawAlignEnum, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceText@DrawPixels)|Pixel-positioned counterpart of [Draw(string, string, Vector2, float, Color, MyGuiDrawAlignEnum, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceText@Draw) . Sizes still scale with the player's UI Scale setting, so this is not a way to get pixel-exact output at every UI scale.|
|[static GetCharsThatFit(string, StringBuilder, float, float)](Sandbox.ModAPI.MyScreenSpaceText@GetCharsThatFit)|How many leading characters fit within a normalized width, for hand-rolled clipping or wrapping.|
|[static GetLineHeight(string, float)](Sandbox.ModAPI.MyScreenSpaceText@GetLineHeight)|Height of one line of this font, in normalized units. Use it to stack rows without measuring each one.|
|[static IsFontAvailable(string)](Sandbox.ModAPI.MyScreenSpaceText@IsFontAvailable)|Whether a font of this name is loaded in the current session. Worth checking once when a mod starts rather than relying on a name that a world's mod set may not provide.|
|[static Measure(string, StringBuilder, float)](Sandbox.ModAPI.MyScreenSpaceText@Measure)|Size the text would occupy, in normalized units. Does not allocate.|
|[static Measure(string, string, float)](Sandbox.ModAPI.MyScreenSpaceText@Measure)|Size the text would occupy, in normalized units.|
|[static MeasurePixels(string, StringBuilder, float)](Sandbox.ModAPI.MyScreenSpaceText@MeasurePixels)|Size the text would occupy, in screen pixels. Does not allocate.|

