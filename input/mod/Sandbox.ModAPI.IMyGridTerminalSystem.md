**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyGridTerminalSystem: IMyGridTerminalSystem
```

Describes grid terminal system interface

## Events

|Member|Description|
|---|---|
|[GroupAdded](Sandbox.ModAPI.IMyGridTerminalSystem@GroupAdded)|Called when new block group was added. Warning, on grid disconnects, you would need to unsubscribe and subscribe to new TerminalSystem|
|[GroupRemoved](Sandbox.ModAPI.IMyGridTerminalSystem@GroupRemoved)|Called when new block group was removed. Warning, on grid disconnects, you would need to unsubscribe and subscribe to new TerminalSystem|

## Methods

|Member|Description|
|---|---|
|[GetBlockGroups(List<IMyBlockGroup>)](Sandbox.ModAPI.IMyGridTerminalSystem@GetBlockGroups)|Fills the provided list with the block groups reachable by this grid terminal system.|
|[GetBlockGroupWithName(string)](Sandbox.ModAPI.IMyGridTerminalSystem@GetBlockGroupWithName)|Returns the first block group found with the given name. Will return`null`if no block group with that name can be found.|
|[GetBlocks(List<IMyTerminalBlock>)](Sandbox.ModAPI.IMyGridTerminalSystem@GetBlocks)|Fills the provided list with all the blocks reachable by this grid terminal system. This means all blocks on the same grid, or connected via rotors, pistons or connectors.|
|[GetBlocksOfType<T>(List<IMyTerminalBlock>, Func<IMyTerminalBlock, bool>)](Sandbox.ModAPI.IMyGridTerminalSystem@GetBlocksOfType{T})||
|[GetBlockWithName(string)](Sandbox.ModAPI.IMyGridTerminalSystem@GetBlockWithName)|Returns the first block found with the given name.|
|[SearchBlocksOfName(string, List<IMyTerminalBlock>, Func<IMyTerminalBlock, bool>)](Sandbox.ModAPI.IMyGridTerminalSystem@SearchBlocksOfName)|Fills the provided list with the blocks reachable by this grid terminal system. This means all blocks on the same grid, or connected via rotors, pistons or connectors.|
|[CanAccess(IMyTerminalBlock, MyTerminalAccessScope)](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem@CanAccess)|Checks if the grid terminal system can still access the given [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock) . A block is no longer accessible if it's destroyed, detached, it's ownership has changed or is otherwise disconnected from this grid terminal system.<br /><br />_Inherited from [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)_|
|[CanAccess(IMyCubeGrid, MyTerminalAccessScope)](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem@CanAccess)|Checks if the grid terminal system can still access the given [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid) . A grid is no longer accessible if it's destroyed, detached, it's ownership has changed or is otherwise disconnected from this grid terminal system.<br /><br />_Inherited from [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)_|
|[GetBlockGroups(List<IMyBlockGroup>, Func<IMyBlockGroup, bool>)](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem@GetBlockGroups)|Fills the provided list with the block groups reachable by this grid terminal system.<br /><br />_Inherited from [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)_|
|[GetBlockGroupWithName(string)](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem@GetBlockGroupWithName)|Returns the first block group found with the given name. Will return`null`if no block group with that name can be found.<br /><br />_Inherited from [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)_|
|[GetBlocks(List<IMyTerminalBlock>)](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem@GetBlocks)|Fills the provided list with all the blocks reachable by this grid terminal system. This means all blocks on the same grid, or connected via rotors, pistons or connectors.<br /><br />_Inherited from [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)_|
|[GetBlocksOfType<T>(List<IMyTerminalBlock>, Func<IMyTerminalBlock, bool>)](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem@GetBlocksOfType{T})|_Inherited from [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)_|
|[GetBlocksOfType<T>(List<T>, Func<T, bool>)](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem@GetBlocksOfType{T})|_Inherited from [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)_|
|[GetBlockWithId(long)](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem@GetBlockWithId)|Attempts to retrieve the block with the given entity ID.<br /><br />_Inherited from [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)_|
|[GetBlockWithName(string)](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem@GetBlockWithName)|Returns the first block found with the given name.<br /><br />_Inherited from [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)_|
|[SearchBlocksOfName(string, List<IMyTerminalBlock>, Func<IMyTerminalBlock, bool>)](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem@SearchBlocksOfName)|Fills the provided list with the blocks reachable by this grid terminal system. This means all blocks on the same grid, or connected via rotors, pistons or connectors.<br /><br />_Inherited from [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)_|

**Implements:**  
* [IMyGridTerminalSystem](Sandbox.ModAPI.Ingame.IMyGridTerminalSystem)

