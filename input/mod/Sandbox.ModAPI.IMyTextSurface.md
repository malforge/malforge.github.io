**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyTextSurface: IMyTextSurface
```

Describes one of block LCDs where you can write text or draw things (mods interface)

## Properties

|Member|Description|
|---|---|
|[Alignment](Sandbox.ModAPI.Ingame.IMyTextSurface@Alignment)|How should the text be aligned<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[BackgroundAlpha](Sandbox.ModAPI.Ingame.IMyTextSurface@BackgroundAlpha)|Value for offscreen texture alpha channel - for PBR material it is metalness (should be 0) - for transparent texture it is opacity<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[BackgroundColor](Sandbox.ModAPI.Ingame.IMyTextSurface@BackgroundColor)|Gets or sets background color<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[ChangeInterval](Sandbox.ModAPI.Ingame.IMyTextSurface@ChangeInterval)|Gets or sets the change interval for selected textures<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[ContentType](Sandbox.ModAPI.Ingame.IMyTextSurface@ContentType)|Type of content to be displayed on the screen.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[CurrentlyShownImage](Sandbox.ModAPI.Ingame.IMyTextSurface@CurrentlyShownImage)|Gets image that is currently shown on the screen. Returns NULL if there are no images selected OR the screen is in text mode.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[DisplayName](Sandbox.ModAPI.Ingame.IMyTextSurface@DisplayName)|Get localized name of this surface.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[Font](Sandbox.ModAPI.Ingame.IMyTextSurface@Font)|Gets or sets the font<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[FontColor](Sandbox.ModAPI.Ingame.IMyTextSurface@FontColor)|Gets or sets font color<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[FontSize](Sandbox.ModAPI.Ingame.IMyTextSurface@FontSize)|Gets or sets font size<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[Name](Sandbox.ModAPI.Ingame.IMyTextSurface@Name)|Gets identifier name of this surface.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[PreserveAspectRatio](Sandbox.ModAPI.Ingame.IMyTextSurface@PreserveAspectRatio)|Gets or sets preserve aspect ratio of images.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[Script](Sandbox.ModAPI.Ingame.IMyTextSurface@Script)|Currently running script<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[ScriptBackgroundColor](Sandbox.ModAPI.Ingame.IMyTextSurface@ScriptBackgroundColor)|Gets or sets background color used for scripts.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[ScriptForegroundColor](Sandbox.ModAPI.Ingame.IMyTextSurface@ScriptForegroundColor)|Gets or sets foreground color used for scripts.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[SurfaceSize](Sandbox.ModAPI.Ingame.IMyTextSurface@SurfaceSize)|Gets size of the drawing surface.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[TextPadding](Sandbox.ModAPI.Ingame.IMyTextSurface@TextPadding)|Gets or sets text padding from all sides of the panel.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[TextureSize](Sandbox.ModAPI.Ingame.IMyTextSurface@TextureSize)|Gets size of the texture the drawing surface is rendered to.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|

## Methods

|Member|Description|
|---|---|
|[AddImagesToSelection(List<string>, bool)](Sandbox.ModAPI.Ingame.IMyTextSurface@AddImagesToSelection)|Adds image to list of shown images. You can get image ids by [GetSelectedImages(List<string>)](Sandbox.ModAPI.Ingame.IMyTextSurface@GetSelectedImages)<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[AddImageToSelection(string, bool)](Sandbox.ModAPI.Ingame.IMyTextSurface@AddImageToSelection)|Adds image to list of shown images. You can get image ids by [GetSelectedImages(List<string>)](Sandbox.ModAPI.Ingame.IMyTextSurface@GetSelectedImages)<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[ClearImagesFromSelection()](Sandbox.ModAPI.Ingame.IMyTextSurface@ClearImagesFromSelection)|Removes images from shown images.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[DrawFrame()](Sandbox.ModAPI.Ingame.IMyTextSurface@DrawFrame)|Creates a new draw frame where you can add sprites to be rendered.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[GetFonts(List<string>)](Sandbox.ModAPI.Ingame.IMyTextSurface@GetFonts)|Gets a list of available fonts<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[GetScripts(List<string>)](Sandbox.ModAPI.Ingame.IMyTextSurface@GetScripts)|Gets a list of available scripts<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[GetSelectedImages(List<string>)](Sandbox.ModAPI.Ingame.IMyTextSurface@GetSelectedImages)|Outputs the selected image ids to the specified list. NOTE: List is not cleared internally.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[GetSprites(List<string>)](Sandbox.ModAPI.Ingame.IMyTextSurface@GetSprites)|Gets a list of available sprites<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[GetText()](Sandbox.ModAPI.Ingame.IMyTextSurface@GetText)|Gets current text that is written on surface. Allocates memory (StringBuilder.ToString())! This method doesn't allocate memory [ReadText(StringBuilder, bool)](Sandbox.ModAPI.Ingame.IMyTextSurface@ReadText)<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[MeasureStringInPixels(StringBuilder, string, float)](Sandbox.ModAPI.Ingame.IMyTextSurface@MeasureStringInPixels)|Calculates how many pixels a string of a given font and scale will take up.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[ReadText(StringBuilder, bool)](Sandbox.ModAPI.Ingame.IMyTextSurface@ReadText)|Gets current text that is written on surface.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[RemoveImageFromSelection(string, bool)](Sandbox.ModAPI.Ingame.IMyTextSurface@RemoveImageFromSelection)|Removes image from shown images.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[RemoveImagesFromSelection(List<string>, bool)](Sandbox.ModAPI.Ingame.IMyTextSurface@RemoveImagesFromSelection)|Removes images from shown images.<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[WriteText(string, bool)](Sandbox.ModAPI.Ingame.IMyTextSurface@WriteText)|Writes text to surface. If somebody opened LCD text in popup dialog, text can no longer be added to the surface. Resulting text must is capped with 100000 symbols<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|
|[WriteText(StringBuilder, bool)](Sandbox.ModAPI.Ingame.IMyTextSurface@WriteText)|Writes text to surface. If somebody opened LCD text in popup dialog, text can no longer be added to the surface. Resulting text must is capped with 100000 symbols<br /><br />_Inherited from [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)_|

**Implements:**  
* [IMyTextSurface](Sandbox.ModAPI.Ingame.IMyTextSurface)

**Inheritors:**  
* [IMyTextPanel](Sandbox.ModAPI.IMyTextPanel)

