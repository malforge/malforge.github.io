**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyTerminalControlLabel: IMyTerminalControl
```

This is a simple label control.

## Properties

|Member|Description|
|---|---|
|[Label](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlLabel@Label)|The text on the label|
|[Enabled](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Enabled)|Allows you to set if the control is enabled<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[Id](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Id)|Identifier of control<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[SupportsMultipleBlocks](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@SupportsMultipleBlocks)|Allows you to set if the control is visible when the block is selected as a group<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[Visible](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Visible)|Allows you to set if the control is visible<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|

## Methods

|Member|Description|
|---|---|
|[RedrawControl()](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@RedrawControl)|Recreates the control GUI. This allows you to update the Title of some controls.<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[UpdateVisual()](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@UpdateVisual)|This updates a control that is currently displayed, allowing you to refresh it's state<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|

**Implements:**  
* [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)

