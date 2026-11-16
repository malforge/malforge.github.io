**Assembly:** Sandbox.Game.dll

```csharp
public abstract class MyModScreen
```

A GUI screen owned by a mod: a real entry in the game's screen stack, so it takes focus, starves gameplay of input while it is open, fades in and out with the game's transitions, and closes on Escape.  
  
Derive from this, override the callbacks you need, and call [Open()](Sandbox.ModAPI.MyModScreen@Open) . The screen itself is empty: draw its content from `MyModScreen.OnDraw(float)`<sub>prohibited</sub> with [MyScreenSpaceText](Sandbox.ModAPI.MyScreenSpaceText) and [MyScreenSpaceSprite](Sandbox.ModAPI.MyScreenSpaceSprite) , left on the default [BelowHud](Sandbox.ModAPI.MyScreenSpaceLayer@BelowHud) layer, which composites in place inside the screen. Multiply colours by the alpha passed to `MyModScreen.OnDraw(float)`<sub>prohibited</sub> so the content fades with the screen, and hit test with [TryGetCursorPosition(out Vector2)](Sandbox.ModAPI.MyScreenSpace@TryGetCursorPosition) , whose coordinates are the ones the content was drawn at. Anything that has to stay inside a panel - a scrolling list, a progress fill - is clipped with [UsingScissorRectangle(RectangleF, MyScreenSpaceLayer)](Sandbox.ModAPI.MyScreenSpace@UsingScissorRectangle) .  
  
Because the screen carries no controls, it is a mouse and keyboard surface: a gamepad can close it but cannot point at anything, as pointing in this GUI is a matter of control focus.  
  
Everything here must be called from the update thread, and a screen never outlives its session.

## Properties

|Member|Description|
|---|---|
|[BackgroundColor](Sandbox.ModAPI.MyModScreen@BackgroundColor)|Colour of the background panel, which is drawn only together with a [Size](Sandbox.ModAPI.MyModScreen@Size) .|
|[CloseButtonEnabled](Sandbox.ModAPI.MyModScreen@CloseButtonEnabled)|Shows the game's own close button in the corner of the panel. Clicking it goes through `MyModScreen.OnCancelling()`<sub>prohibited</sub> exactly as Escape does.|
|[CloseOnEscape](Sandbox.ModAPI.MyModScreen@CloseOnEscape)|Whether Escape and the gamepad cancel button close the screen. On by default; a screen that turns it off has to offer the player some other way out.|
|[DrawMouseCursor](Sandbox.ModAPI.MyModScreen@DrawMouseCursor)|Whether the mouse cursor is drawn while this screen has focus. On by default, since a screen with nothing to point at is the unusual case.|
|[EnabledBackgroundFade](Sandbox.ModAPI.MyModScreen@EnabledBackgroundFade)|Darkens whatever is behind the screen, the way the game's own full-screen menus do.|
|[HasFocus](Sandbox.ModAPI.MyModScreen@HasFocus)|Whether this is the screen input is going to. False while another screen sits above it.|
|[IsOpen](Sandbox.ModAPI.MyModScreen@IsOpen)|Whether the screen is in the screen stack. False again as soon as `MyModScreen.OnClosed(bool)`<sub>prohibited</sub> is delivered.|
|[IsVisible](Sandbox.ModAPI.MyModScreen@IsVisible)|Whether the screen is drawn. False while it is hidden underneath a screen that hides the ones below it.|
|[Name](Sandbox.ModAPI.MyModScreen@Name)|Name given at construction, or the type name.|
|[PausesGameInSinglePlayer](Sandbox.ModAPI.MyModScreen@PausesGameInSinglePlayer)|Pauses a single-player game while the screen is open, as the main menu does. Ignored in multiplayer. Read when the screen opens, so set it before [Open()](Sandbox.ModAPI.MyModScreen@Open) .|
|[Position](Sandbox.ModAPI.MyModScreen@Position)|Normalized [0,1] position of the screen's centre. May be changed while open.|
|[Size](Sandbox.ModAPI.MyModScreen@Size)|Normalized [0,1] size of the background panel, or null for no panel. May be changed while open.|
|[SkipTransition](Sandbox.ModAPI.MyModScreen@SkipTransition)|Skips the opening and closing fades.|

## Methods

|Member|Description|
|---|---|
|[Close()](Sandbox.ModAPI.MyModScreen@Close)|Closes the screen with the usual fade out. `MyModScreen.OnClosed(bool)`<sub>prohibited</sub> arrives once the fade has finished.|
|[CloseNow()](Sandbox.ModAPI.MyModScreen@CloseNow)|Closes the screen without a fade, delivering `MyModScreen.OnClosed(bool)`<sub>prohibited</sub> before returning.|
|[Hide()](Sandbox.ModAPI.MyModScreen@Hide)|Transitions the screen out but keeps it in the stack, so [Unhide()](Sandbox.ModAPI.MyModScreen@Unhide) brings it back with its state intact.|
|[Open()](Sandbox.ModAPI.MyModScreen@Open)|Puts the screen on top of the screen stack, where it takes focus and input. Does nothing when the screen is already open, and logs and returns rather than throwing when a screen cannot be opened at all: on a dedicated server, off the update thread, with no running session, or once too many mod screens are open.|
|[Unhide()](Sandbox.ModAPI.MyModScreen@Unhide)|Brings a hidden screen back.|

