**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyTerminalAction: ITerminalAction
```

This is an interface wrapper for terminal actions that appear on a toolbar. An instance of this interface is created via MyAPIGateway.TerminalControls.CreateAction. Once created, you may modify various fields to control how the action behaves.

## Properties

|Member|Description|
|---|---|
|[Action](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction@Action)|This is the action taken when an action is performed.|
|[Enabled](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction@Enabled)|Allows you to set if this action is enabled or disabled|
|[Icon](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction@Icon)|Allows you to set the Icon of this action. It's a link to an icon texture.|
|[InvalidToolbarTypes](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction@InvalidToolbarTypes)|Allows you to set which toolbar type this action is invalid for. Adding to this means this action may not be added to that toolbar type.|
|[Name](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction@Name)|Allows you to set the name of the Action|
|[ValidForGroups](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction@ValidForGroups)|Allows you to set if this action is valid in groups|
|[Writer](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction@Writer)|This allows you to set the "Icon Text" of an action (the text that appears under the icon in the toolbar)|
|[Icon](Sandbox.ModAPI.Interfaces.ITerminalAction@Icon)|Gets the icon of the action<br /><br />_Inherited from [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction)_|
|[Id](Sandbox.ModAPI.Interfaces.ITerminalAction@Id)|Gets the id of the action<br /><br />_Inherited from [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction)_|
|[Name](Sandbox.ModAPI.Interfaces.ITerminalAction@Name)|Gets the name of the action<br /><br />_Inherited from [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction)_|

## Methods

|Member|Description|
|---|---|
|[Apply(IMyCubeBlock)](Sandbox.ModAPI.Interfaces.ITerminalAction@Apply)|Applies action on the block<br /><br />_Inherited from [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction)_|
|[Apply(IMyCubeBlock, ListReader<TerminalActionParameter>)](Sandbox.ModAPI.Interfaces.ITerminalAction@Apply)|Applies action on the block with specific action parameters<br /><br />_Inherited from [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction)_|
|[IsEnabled(IMyCubeBlock)](Sandbox.ModAPI.Interfaces.ITerminalAction@IsEnabled)|Checks if action is enabled for specific block<br /><br />_Inherited from [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction)_|
|[WriteValue(IMyCubeBlock, StringBuilder)](Sandbox.ModAPI.Interfaces.ITerminalAction@WriteValue)|Writes value for the action<br /><br />_Inherited from [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction)_|

**Implements:**  
* [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction)

