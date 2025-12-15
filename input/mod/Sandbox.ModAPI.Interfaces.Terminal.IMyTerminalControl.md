**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyTerminalControl
```

This is the base terminal control interface. All controls implement this.

## Properties

|Member|Description|
|---|---|
|[Enabled](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Enabled)|Allows you to set if the control is enabled|
|[Id](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Id)|Identifier of control|
|[SupportsMultipleBlocks](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@SupportsMultipleBlocks)|Allows you to set if the control is visible when the block is selected as a group|
|[Visible](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Visible)|Allows you to set if the control is visible|

## Methods

|Member|Description|
|---|---|
|[RedrawControl()](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@RedrawControl)|Recreates the control GUI. This allows you to update the Title of some controls.|
|[UpdateVisual()](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@UpdateVisual)|This updates a control that is currently displayed, allowing you to refresh it's state|

**Inheritors:**  
* [IMyTerminalControlButton](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlButton)  
* [IMyTerminalControlCheckbox](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlCheckbox)  
* [IMyTerminalControlColor](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlColor)  
* [IMyTerminalControlCombobox](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlCombobox)  
* [IMyTerminalControlLabel](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlLabel)  
* [IMyTerminalControlListbox](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlListbox)  
* [IMyTerminalControlOnOffSwitch](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlOnOffSwitch)  
* [IMyTerminalControlProperty<TValue>](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlProperty{TValue})  
* [IMyTerminalControlSeparator](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSeparator)  
* [IMyTerminalControlSlider](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSlider)  
* [IMyTerminalControlTextbox](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlTextbox)

