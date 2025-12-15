**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyTerminalControlProperty<TValue>: IMyTerminalControl, IMyTerminalValueControl<TValue>, ITerminalProperty
```

## Properties

|Member|Description|
|---|---|
|[Enabled](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Enabled)|Allows you to set if the control is enabled<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[Id](Sandbox.ModAPI.Interfaces.ITerminalProperty@Id)|Property Id (value name)<br /><br />_Inherited from [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)_|
|[Id](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Id)|Identifier of control<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[SupportsMultipleBlocks](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@SupportsMultipleBlocks)|Allows you to set if the control is visible when the block is selected as a group<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[TypeName](Sandbox.ModAPI.Interfaces.ITerminalProperty@TypeName)|Property type (bool - [bool](https://docs.microsoft.com/en-us/dotnet/api/system.boolean?view=netframework-4.6) , float - [float](https://docs.microsoft.com/en-us/dotnet/api/system.single?view=netframework-4.6) , color - [Color](VRageMath.Color) )<br /><br />_Inherited from [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)_|
|[Visible](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@Visible)|Allows you to set if the control is visible<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|

## Methods

|Member|Description|
|---|---|
|[RedrawControl()](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@RedrawControl)|Recreates the control GUI. This allows you to update the Title of some controls.<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|
|[UpdateVisual()](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl@UpdateVisual)|This updates a control that is currently displayed, allowing you to refresh it's state<br /><br />_Inherited from [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)_|

**Implements:**  
* [IMyTerminalControl](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalControl)  
* [IMyTerminalValueControl<TValue>](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalValueControl{TValue})  
* [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)

