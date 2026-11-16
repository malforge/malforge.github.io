**Assembly:** Sandbox.Game.dll

```csharp
public abstract sealed class MyScreenSpaceSprite
```

Draws textured quads in screen space through the game's sprite renderer, for backgrounds, icons, bars and gauges that accompany [MyScreenSpaceText](Sandbox.ModAPI.MyScreenSpaceText) .  
  
Immediate mode: every call draws for a single frame, so call it every frame, from a session component's [Draw()](VRage.Game.Components.MySessionComponentBase@Draw) for content over the game, or from the OnDraw of a [MyModScreen](Sandbox.ModAPI.MyModScreen) for the content of a mod's own screen, where the layer should be left at [BelowHud](Sandbox.ModAPI.MyScreenSpaceLayer@BelowHud) so it composites inside that screen. Must be called from the update thread.  
  
Textures are named by the subtype id of a transparent material declared in TransparentMaterials.sbc, the same ids used for billboards, so a mod's own textures need no extra setup beyond that definition. An id matching no such material is looked up as an LCD texture, which covers the whole set an LCD or a Programmable Block can draw, item and faction icons included, then as a GUI texture, which is what the game's own HUD and screens are built from, then as the icon of the definition named "TypeId/SubtypeId", which is what reaches block icons, and finally as the [Name](VRage.Game.ModAPI.IMyGeneratedTexture@Name) of a texture the mod is drawing into itself.

## Methods

|Member|Description|
|---|---|
|[static Draw(MyStringId, Vector2, Vector2, Color, MyGuiDrawAlignEnum, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceSprite@Draw)|Draws a sprite stretched over a normalized rectangle, rotating about its own centre.|
|[static DrawPivoted(MyStringId, Rectangle, Rectangle?, Color, float, Vector2, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceSprite@DrawPivoted)|Draws a sprite rotating about an arbitrary pivot rather than its own centre, which is what gauge needles, swinging bars and radial fills need. The pivot may lie outside the destination rectangle.|
|[static DrawPixels(MyStringId, Rectangle, Rectangle?, Color, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceSprite@DrawPixels)|Pixel-positioned counterpart of [Draw(MyStringId, Vector2, Vector2, Color, MyGuiDrawAlignEnum, float, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpaceSprite@Draw) , rotating about the destination's centre. Pass a source rectangle to take one region out of a larger texture, which is how sprite sheets are used.|
|[static GetTextureSize(MyStringId)](Sandbox.ModAPI.MyScreenSpaceSprite@GetTextureSize)|Size of the material's texture in pixels, for sizing sprites to their source art or for building source rectangles, or zero if the material is unknown. The first lookup of a texture reads its header from disk, so cache the result instead of calling this every frame.|
|[static IsMaterialAvailable(MyStringId)](Sandbox.ModAPI.MyScreenSpaceSprite@IsMaterialAvailable)|Whether an id resolves to a texture usable here, through any of the sources this class accepts. Render-target and atlas-packed materials are rejected even though billboards accept them.|

