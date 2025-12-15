**Assembly:** Sandbox.Common.dll

```csharp
public interface ITerminalAction
```

Describes terminal action interface

## Properties

|Member|Description|
|---|---|
|[Icon](Sandbox.ModAPI.Interfaces.ITerminalAction@Icon)|Gets the icon of the action|
|[Id](Sandbox.ModAPI.Interfaces.ITerminalAction@Id)|Gets the id of the action|
|[Name](Sandbox.ModAPI.Interfaces.ITerminalAction@Name)|Gets the name of the action|

## Methods

|Member|Description|
|---|---|
|[Apply(IMyCubeBlock)](Sandbox.ModAPI.Interfaces.ITerminalAction@Apply)|Applies action on the block|
|[Apply(IMyCubeBlock, ListReader<TerminalActionParameter>)](Sandbox.ModAPI.Interfaces.ITerminalAction@Apply)|Applies action on the block with specific action parameters|
|[IsEnabled(IMyCubeBlock)](Sandbox.ModAPI.Interfaces.ITerminalAction@IsEnabled)|Checks if action is enabled for specific block|
|[WriteValue(IMyCubeBlock, StringBuilder)](Sandbox.ModAPI.Interfaces.ITerminalAction@WriteValue)|Writes value for the action|

