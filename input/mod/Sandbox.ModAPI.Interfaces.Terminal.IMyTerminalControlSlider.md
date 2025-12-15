**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyTerminalControlSlider: IMyTerminalControl, IMyTerminalValueControl<float>, ITerminalProperty, IMyTerminalControlTitleTooltip
```

This is a value slider. A slider can be moved by a user and a value selected.

## Properties

|Member|Description|
|---|---|
|[Writer](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSlider@Writer)|This is triggered when a slider value is modified. Appending to the string builder allows you to modify the text that is displayed along side the slider when it updates.|
|[Enabled](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Enabled)|Allows you to set if the control is enabled<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[Id](Sandbox.ModAPI.Interfaces.ITerminalProperty@Id)|Property Id (value name)<br /><br />_Inherited from [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)_|
|[Id](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Id)|Identifier of control<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[SupportsMultipleBlocks](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@SupportsMultipleBlocks)|Allows you to set if the control is visible when the block is selected as a group<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[Title](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlTitleTooltip@Title)|Allows you to get or set the Label that appears on the control<br /><br />_Inherited from [IMyTerminalControlTitleTooltip](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlTitleTooltip)_|
|[Tooltip](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlTitleTooltip@Tooltip)|Allows you to get or set the tooltip that appears when you hover over the control<br /><br />_Inherited from [IMyTerminalControlTitleTooltip](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlTitleTooltip)_|
|[TypeName](Sandbox.ModAPI.Interfaces.ITerminalProperty@TypeName)|Property type (bool - [bool](https://docs.microsoft.com/en-us/dotnet/api/system.boolean?view=netframework-4.6) , float - [float](https://docs.microsoft.com/en-us/dotnet/api/system.single?view=netframework-4.6) , color - [Color](VRageMath.Color) )<br /><br />_Inherited from [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)_|
|[Visible](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Visible)|Allows you to set if the control is visible<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|

## Methods

|Member|Description|
|---|---|
|[SetDualLogLimits(float, float, float)](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSlider@SetDualLogLimits)|Allows you to set the upper and lower limits of the slider, interpolating on a logarithmic scale at both ends|
|[SetDualLogLimits(Func<IMyTerminalBlock, float>, Func<IMyTerminalBlock, float>, float)](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSlider@SetDualLogLimits)|Allows you to set the upper and lower limits of the slider with delegates, interpolating on a logarithmic scale at both ends|
|[SetLimits(float, float)](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSlider@SetLimits)|Allows you to set the upper and lower limits of the slider|
|[SetLimits(Func<IMyTerminalBlock, float>, Func<IMyTerminalBlock, float>)](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSlider@SetLimits)|Allows you to set the upper and lower limits of the slider with delegates|
|[SetLogLimits(float, float)](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSlider@SetLogLimits)|Allows you to set the upper and lower limits of the slider, interpolating on a logarithmic scale|
|[SetLogLimits(Func<IMyTerminalBlock, float>, Func<IMyTerminalBlock, float>)](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlSlider@SetLogLimits)|Allows you to set the upper and lower limits of the slider with delegates, interpolating on a logarithmic scale|
|[RedrawControl()](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@RedrawControl)|Recreates the control GUI. This allows you to update the Title of some controls.<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[UpdateVisual()](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@UpdateVisual)|This updates a control that is currently displayed, allowing you to refresh it's state<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|

**Implements:**  
* [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)  
* [IMyTerminalControlTitleTooltip](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControlTitleTooltip)  
* [IMyTerminalValueControl<float>](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalValueControl{Single})  
* [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)

