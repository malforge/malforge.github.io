**Assembly:** VRage.Game.dll

```csharp
public struct MyToolbarItemInfo
```

What one toolbar slot holds. Read one with [TryGetItem(int, out MyToolbarItemInfo)](VRage.Game.ModAPI.IMyToolbarSlots@TryGetItem) and write one with [Set(int, MyToolbarItemInfo)](VRage.Game.ModAPI.IMyToolbarChangeBuilder@Set) , so a slot read from one toolbar can be placed in another as it stands.  
  
A read is a copy taken at the time it was asked for: it does not follow later edits, and changing it changes nothing. Reading costs no allocation, so a mod may read toolbars on an update path.  
  
 [Kind](VRage.Game.ModAPI.MyToolbarItemInfo@Kind) says which fields carry a value; the rest are left at their defaults. Action arguments are held apart from this, since most actions have none: read them with the GetParameters extension in Sandbox.ModAPI and write them with the matching Set.

## Fields

|Member|Description|
|---|---|
|[ActionId](VRage.Game.ModAPI.MyToolbarItemInfo@ActionId)|Id of the terminal action, as ITerminalAction.Id reports it. Set for [BlockAction](VRage.Game.ModAPI.MyToolbarItemKind@BlockAction) and [GroupAction](VRage.Game.ModAPI.MyToolbarItemKind@GroupAction) .|
|[BlockEntityId](VRage.Game.ModAPI.MyToolbarItemInfo@BlockEntityId)|Entity id of the block the action runs on, or of the block whose grid owns the group. Set for [BlockAction](VRage.Game.ModAPI.MyToolbarItemKind@BlockAction) and [GroupAction](VRage.Game.ModAPI.MyToolbarItemKind@GroupAction) . The entity need not be loaded on this machine, on either a read or a write.|
|[DefinitionId](VRage.Game.ModAPI.MyToolbarItemInfo@DefinitionId)|The definition the slot holds. Set for [Definition](VRage.Game.ModAPI.MyToolbarItemKind@Definition) .|
|[GroupName](VRage.Game.ModAPI.MyToolbarItemInfo@GroupName)|Name of the block group the action runs on, as it appears in the terminal. Set for [GroupAction](VRage.Game.ModAPI.MyToolbarItemKind@GroupAction) .|
|[Kind](VRage.Game.ModAPI.MyToolbarItemInfo@Kind)|What the slot holds.|
|[Label](VRage.Game.ModAPI.MyToolbarItemInfo@Label)|The label a player typed over the slot, or null for the action's own name. Only the action kinds carry one.|

## Methods

|Member|Description|
|---|---|
|[static BlockAction(long, string, string)](VRage.Game.ModAPI.MyToolbarItemInfo@BlockAction)|A terminal action on a single block.|
|[static Definition(MyDefinitionId)](VRage.Game.ModAPI.MyToolbarItemInfo@Definition)|A definition to place, hold or use. This is what character toolbars hold; terminal actions are not allowed on them.|
|[static GroupAction(long, string, string, string)](VRage.Game.ModAPI.MyToolbarItemInfo@GroupAction)|A terminal action on every block of a named group.|

