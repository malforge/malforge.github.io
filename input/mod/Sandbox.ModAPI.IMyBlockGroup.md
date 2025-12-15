**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyBlockGroup: IMyBlockGroup
```

Describes terminal block group (mods interface)

## Properties

|Member|Description|
|---|---|
|[Name](Sandbox.ModAPI.Ingame.IMyBlockGroup@Name)|Gets name of terminal blocks group<br /><br />_Inherited from [IMyBlockGroup](Sandbox.ModAPI.Ingame.IMyBlockGroup)_|

## Methods

|Member|Description|
|---|---|
|[GetBlocks(List<IMyTerminalBlock>, Func<IMyTerminalBlock, bool>)](Sandbox.ModAPI.IMyBlockGroup@GetBlocks)|Get terminal blocks which assigned to this group|
|[GetBlocksOfType<T>(List<IMyTerminalBlock>, Func<IMyTerminalBlock, bool>)](Sandbox.ModAPI.IMyBlockGroup@GetBlocksOfType{T})||
|[GetBlocks(List<IMyTerminalBlock>, Func<IMyTerminalBlock, bool>)](Sandbox.ModAPI.Ingame.IMyBlockGroup@GetBlocks)|Get terminal blocks which assigned to this group<br /><br />_Inherited from [IMyBlockGroup](Sandbox.ModAPI.Ingame.IMyBlockGroup)_|
|[GetBlocksOfType<T>(List<IMyTerminalBlock>, Func<IMyTerminalBlock, bool>)](Sandbox.ModAPI.Ingame.IMyBlockGroup@GetBlocksOfType{T})|_Inherited from [IMyBlockGroup](Sandbox.ModAPI.Ingame.IMyBlockGroup)_|
|[GetBlocksOfType<T>(List<T>, Func<T, bool>)](Sandbox.ModAPI.Ingame.IMyBlockGroup@GetBlocksOfType{T})|_Inherited from [IMyBlockGroup](Sandbox.ModAPI.Ingame.IMyBlockGroup)_|

**Implements:**  
* [IMyBlockGroup](Sandbox.ModAPI.Ingame.IMyBlockGroup)

