**Assembly:** Sandbox.Game.dll

```csharp
public class MyTerminalControlFactoryHelper: IMyTerminalActionsHelper
```

## Properties

|Member|Description|
|---|---|
|[static Static](Sandbox.ModAPI.MyTerminalControlFactoryHelper@Static)||

## Constructors

|Member|Description|
|---|---|
|[MyTerminalControlFactoryHelper()](Sandbox.ModAPI.MyTerminalControlFactoryHelper@.ctor)||

## Methods

|Member|Description|
|---|---|
|[GetProperties(Type, List<ITerminalProperty>, Func<ITerminalProperty, bool>)](Sandbox.ModAPI.MyTerminalControlFactoryHelper@GetProperties)||
|[GetProperty(string, Type)](Sandbox.ModAPI.MyTerminalControlFactoryHelper@GetProperty)||
|[GetActions(Type, List<ITerminalAction>, Func<ITerminalAction, bool>)](Sandbox.ModAPI.IMyTerminalActionsHelper@GetActions)|Gets available [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction) for a block with specified type<br /><br />_Inherited from [IMyTerminalActionsHelper](Sandbox.ModAPI.IMyTerminalActionsHelper)_|
|[GetActionWithName(string, Type)](Sandbox.ModAPI.IMyTerminalActionsHelper@GetActionWithName)|Gets first available [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction) for a block with specified type and name<br /><br />_Inherited from [IMyTerminalActionsHelper](Sandbox.ModAPI.IMyTerminalActionsHelper)_|
|[GetProperties(Type, List<ITerminalProperty>, Func<ITerminalProperty, bool>)](Sandbox.ModAPI.IMyTerminalActionsHelper@GetProperties)|Gets all properties that belongs to specific block<br /><br />_Inherited from [IMyTerminalActionsHelper](Sandbox.ModAPI.IMyTerminalActionsHelper)_|
|[GetProperty(string, Type)](Sandbox.ModAPI.IMyTerminalActionsHelper@GetProperty)|Gets property by id<br /><br />_Inherited from [IMyTerminalActionsHelper](Sandbox.ModAPI.IMyTerminalActionsHelper)_|
|[GetTerminalSystemForGrid(IMyCubeGrid)](Sandbox.ModAPI.IMyTerminalActionsHelper@GetTerminalSystemForGrid)|Gets [IMyGridTerminalSystem](Sandbox.ModAPI.IMyGridTerminalSystem) for grid<br /><br />_Inherited from [IMyTerminalActionsHelper](Sandbox.ModAPI.IMyTerminalActionsHelper)_|
|[SearchActionsOfName(string, Type, List<ITerminalAction>, Func<ITerminalAction, bool>)](Sandbox.ModAPI.IMyTerminalActionsHelper@SearchActionsOfName)|Gets available [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction) for a block with specified type and name<br /><br />_Inherited from [IMyTerminalActionsHelper](Sandbox.ModAPI.IMyTerminalActionsHelper)_|

**Implements:**  
* [IMyTerminalActionsHelper](Sandbox.ModAPI.IMyTerminalActionsHelper)

