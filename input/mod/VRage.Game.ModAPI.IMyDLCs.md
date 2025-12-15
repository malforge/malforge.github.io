**Assembly:** VRage.Game.dll

```csharp
public interface IMyDLCs
```

Describes API, that allows you get information about DLCs (mods interface)

## Events

|Member|Description|
|---|---|
|[DLCInstalled](VRage.Game.ModAPI.IMyDLCs@DLCInstalled)|Called when a new DLC is installed by a client. On the client, this only reports DLC installed on the local client.|

## Methods

|Member|Description|
|---|---|
|[ContainsRequiredDLC(MyDefinitionBase, List<ulong>)](VRage.Game.ModAPI.IMyDLCs@ContainsRequiredDLC)|Returns whether the collection contains the DLCs in this definition.|
|[GetAvailableClientDLCIds()](VRage.Game.ModAPI.IMyDLCs@GetAvailableClientDLCIds)|Returns a list of the DLCs installed on the local client.|
|[GetDLC(string)](VRage.Game.ModAPI.IMyDLCs@GetDLC)|Gets information on the requested DLC.|
|[GetDLC(uint)](VRage.Game.ModAPI.IMyDLCs@GetDLC)|Gets information on the requested DLC.|
|[GetDLCs()](VRage.Game.ModAPI.IMyDLCs@GetDLCs)|Get a list of all DLCs the game has. This will not change for the lifetime of the session and is safe to cache.|
|[GetFirstMissingDefinitionDLC(MyDefinitionBase, ulong)](VRage.Game.ModAPI.IMyDLCs@GetFirstMissingDefinitionDLC)|Get the first DLC a player is missing that a definition requires. Null if they have all.|
|[GetRequiredDLCTooltip(string)](VRage.Game.ModAPI.IMyDLCs@GetRequiredDLCTooltip)|Returns the tooltip text that is shown to the user if they don't own the DLC.|
|[GetRequiredDLCTooltip(uint)](VRage.Game.ModAPI.IMyDLCs@GetRequiredDLCTooltip)|Returns the tooltip text that is shown to the user if they don't own the DLC.|
|[HasDefinitionDLC(MyDefinitionId, ulong)](VRage.Game.ModAPI.IMyDLCs@HasDefinitionDLC)|Returns whether a player owns all DLCs required by this definition id.|
|[HasDefinitionDLC(MyDefinitionBase, ulong)](VRage.Game.ModAPI.IMyDLCs@HasDefinitionDLC)|Returns whether a player owns all DLCs required by this definition.|
|[HasDLC(string, ulong)](VRage.Game.ModAPI.IMyDLCs@HasDLC)|Return whether a player owns a DLC.|
|[HasDLC(uint, ulong)](VRage.Game.ModAPI.IMyDLCs@HasDLC)|Return whether a player owns a DLC.|
|[IsDLCSupported(string)](VRage.Game.ModAPI.IMyDLCs@IsDLCSupported)|Check if DLC is supported on this platform.|
|[TryGetDLC(uint, out IMyDLC)](VRage.Game.ModAPI.IMyDLCs@TryGetDLC)|Gets information on the requested DLC.|
|[TryGetDLC(string, out IMyDLC)](VRage.Game.ModAPI.IMyDLCs@TryGetDLC)|Gets information on the requested DLC.|

