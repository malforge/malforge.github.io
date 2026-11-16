**Assembly:** Sandbox.Game.dll

```csharp
public abstract sealed class MyViewRotation
```

Shared handling of the terminal "View Rotation" property - a clockwise roll of the block's first person view, in 90 degree steps.

## Methods

|Member|Description|
|---|---|
|[static ApplyRoll(int, ref MatrixD)](Sandbox.Game.Entities.MyViewRotation@ApplyRoll)|Rolls a camera world matrix clockwise by the given rotation.|
|[static FillCombo(List<MyTerminalControlComboBoxItem>)](Sandbox.Game.Entities.MyViewRotation@FillCombo)|Fills the terminal combobox with the supported rotations.|
|[static RotateInput(int, Vector2)](Sandbox.Game.Entities.MyViewRotation@RotateInput)|Rotates a screen space aiming input into the axes of a mount that does not roll with the view, so the aim keeps following the direction the player pushed on screen.|
|[static Snap(int)](Sandbox.Game.Entities.MyViewRotation@Snap)|Wraps an arbitrary angle to the nearest supported rotation.|

