**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyTerminalActionsHelper
```

API class for interactions with terminal actions and properties

## Methods

|Member|Description|
|---|---|
|[GetActions(Type, List<ITerminalAction>, Func<ITerminalAction, bool>)](Sandbox.ModAPI.IMyTerminalActionsHelper@GetActions)|Gets available [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction) for a block with specified type|
|[GetActionWithName(string, Type)](Sandbox.ModAPI.IMyTerminalActionsHelper@GetActionWithName)|Gets first available [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction) for a block with specified type and name|
|[GetProperties(Type, List<ITerminalProperty>, Func<ITerminalProperty, bool>)](Sandbox.ModAPI.IMyTerminalActionsHelper@GetProperties)|Gets all properties that belongs to specific block|
|[GetProperty(string, Type)](Sandbox.ModAPI.IMyTerminalActionsHelper@GetProperty)|Gets property by id|
|[GetTerminalSystemForGrid(IMyCubeGrid)](Sandbox.ModAPI.IMyTerminalActionsHelper@GetTerminalSystemForGrid)|Gets [IMyGridTerminalSystem](Sandbox.ModAPI.IMyGridTerminalSystem) for grid|
|[SearchActionsOfName(string, Type, List<ITerminalAction>, Func<ITerminalAction, bool>)](Sandbox.ModAPI.IMyTerminalActionsHelper@SearchActionsOfName)|Gets available [ITerminalAction](Sandbox.ModAPI.Interfaces.ITerminalAction) for a block with specified type and name|

**Inheritors:**  
* [MyTerminalControlFactoryHelper](Sandbox.ModAPI.MyTerminalControlFactoryHelper)

