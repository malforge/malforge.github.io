**Assembly:** Sandbox.Common.dll

```csharp
public enum MyScreenSpaceLayer
```

Selects at which point of the frame screen-space text and sprites are composited, which decides what they end up on top of.

## Fields

|Member|Description|
|---|---|
|AboveEverything|Above everything, including open screens and tooltips.|
|AboveHud|Above the game HUD but below open screens such as the terminal. A layer decides ordering only, so this still draws while the HUD itself is hidden.|
|BelowHud|Above the 3D scene but below the game HUD. Cheapest option, as nothing needs to be buffered.|

