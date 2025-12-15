**Assembly:** VRage.Game.dll

```csharp
public interface IMyInventory: IMyInventory
```

Describes inventory interface (PB scripting interface) You can cast if MyInventory for getting more functionality

## Events

|Member|Description|
|---|---|
|[OnVolumeChanged](VRage.Game.ModAPI.IMyInventory@OnVolumeChanged)|Triggers when volume of the inventory is changed|

## Properties

|Member|Description|
|---|---|
|[CanPutItems](VRage.Game.ModAPI.IMyInventory@CanPutItems)|Gets or sets if inventory can receive items or not.|
|[Owner](VRage.Game.ModAPI.IMyInventory@Owner)|Returns entity this inventory belongs to.|
|[CanPutItems](VRage.Game.ModAPI.Ingame.IMyInventory@CanPutItems)|Gets if inventory can receive items or not.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[CurrentMass](VRage.Game.ModAPI.Ingame.IMyInventory@CurrentMass)|Returns total mass of items inside this inventory in Kg.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[CurrentVolume](VRage.Game.ModAPI.Ingame.IMyInventory@CurrentVolume)|Returns total volume of items inside this inventory in m^3.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[IsFull](VRage.Game.ModAPI.Ingame.IMyInventory@IsFull)|Determines if inventory is absolutely full.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[ItemCount](VRage.Game.ModAPI.Ingame.IMyInventory@ItemCount)|Returns number of occupied inventory slots.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[MaxVolume](VRage.Game.ModAPI.Ingame.IMyInventory@MaxVolume)|Sets maximum volume of items this inventory can contain in m^3.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[Owner](VRage.Game.ModAPI.Ingame.IMyInventory@Owner)|Returns entity this inventory belongs to.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[VolumeFillFactor](VRage.Game.ModAPI.Ingame.IMyInventory@VolumeFillFactor)|Gets the current volume fill factor of the inventory<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|

## Methods

|Member|Description|
|---|---|
|[AddItems(MyFixedPoint, MyObjectBuilder_PhysicalObject, int)](VRage.Game.ModAPI.IMyInventory@AddItems)|Adds item to inventory. Doesn't do all checks inside. Call [CanAddItemAmount(IMyInventoryItem, MyFixedPoint)](VRage.Game.ModAPI.IMyInventory@CanAddItemAmount) before this function|
|[CanAddItemAmount(IMyInventoryItem, MyFixedPoint)](VRage.Game.ModAPI.IMyInventory@CanAddItemAmount)|Gets whether item could be added into inventory, but doesn't add it Checks: - Inserting volume - Inventory can receive items - Inventory filter can|
|[Clear(bool)](VRage.Game.ModAPI.IMyInventory@Clear)|Remove all items from inventory|
|[Empty()](VRage.Game.ModAPI.IMyInventory@Empty)|Gets if inventory is empty|
|[FindItem(SerializableDefinitionId)](VRage.Game.ModAPI.IMyInventory@FindItem)|Finds first item stack, whose content matching provided id|
|[GetItemByID(uint)](VRage.Game.ModAPI.IMyInventory@GetItemByID)|Gets item by id|
|[RemoveItemAmount(IMyInventoryItem, MyFixedPoint)](VRage.Game.ModAPI.IMyInventory@RemoveItemAmount)|Remove|
|[RemoveItems(uint, MyFixedPoint?, bool, bool)](VRage.Game.ModAPI.IMyInventory@RemoveItems)|Removes item by itemId|
|[RemoveItemsAt(int, MyFixedPoint?, bool, bool)](VRage.Game.ModAPI.IMyInventory@RemoveItemsAt)|Removes items at exact inventory index|
|[RemoveItemsOfType(MyFixedPoint, MyObjectBuilder_PhysicalObject, bool)](VRage.Game.ModAPI.IMyInventory@RemoveItemsOfType)|Removes amount for specified item type from inventory|
|[RemoveItemsOfType(MyFixedPoint, SerializableDefinitionId, MyItemFlags, bool)](VRage.Game.ModAPI.IMyInventory@RemoveItemsOfType)|Removes amount for specified item type from inventory|
|[TransferItemFrom(IMyInventory, int, int?, bool?, MyFixedPoint?, bool)](VRage.Game.ModAPI.IMyInventory@TransferItemFrom)|Transfer item from one inventory to another|
|[TransferItemFrom(IMyInventory, IMyInventoryItem, MyFixedPoint)](VRage.Game.ModAPI.IMyInventory@TransferItemFrom)|Transfer item from one inventory to another|
|[TransferItemTo(IMyInventory, int, int?, bool?, MyFixedPoint?, bool)](VRage.Game.ModAPI.IMyInventory@TransferItemTo)|Transfer item from one inventory to another|
|[CanItemsBeAdded(MyFixedPoint, MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@CanItemsBeAdded)|Determines if given amount of items fits into this inventory on top of existing items.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[CanTransferItemTo(IMyInventory, MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@CanTransferItemTo)|Determines if there is working conveyor connection for item of give type to be transferred to other inventory.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[ContainItems(MyFixedPoint, MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@ContainItems)|Determines if there is at least given amount of items of given type contained inside this inventory.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[FindItem(MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@FindItem)|Tries to find an item of given type inside this inventory.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[GetAcceptedItems(List<MyItemType>, Func<MyItemType, bool>)](VRage.Game.ModAPI.Ingame.IMyInventory@GetAcceptedItems)|Returns all items this inventory accepts.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[GetItemAmount(MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItemAmount)|Sums up total amount of items of given type contained inside this inventory.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[GetItemAt(int)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItemAt)|Returns info about item at give position.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[GetItemByID(uint)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItemByID)|Returns info about item contained inside this inventory.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[GetItems(List<MyInventoryItem>, Func<MyInventoryItem, bool>)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItems)|Collects all items present inside this inventory and returns snapshot of the current inventory state.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[IsConnectedTo(IMyInventory)](VRage.Game.ModAPI.Ingame.IMyInventory@IsConnectedTo)|Checks if two inventories are connected.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[IsItemAt(int)](VRage.Game.ModAPI.Ingame.IMyInventory@IsItemAt)|Determines if there is any item on given inventory slot.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[TransferItemFrom(IMyInventory, MyInventoryItem, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemFrom)|Attempts to transfer item from one inventory to another.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[TransferItemFrom(IMyInventory, int, int?, bool?, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemFrom)|Attempts to transfer item from one inventory to another.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[TransferItemTo(IMyInventory, MyInventoryItem, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemTo)|Attempts to transfer item from one inventory to another.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[TransferItemTo(IMyInventory, int, int?, bool?, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemTo)|Attempts to transfer item from one inventory to another.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[GetItems()](VRage.Game.ModAPI.IMyInventory@GetItems)|_**Obsolete:** Use non-allocating GetItems overload_|

**Implements:**  
* [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)

**Inheritors:**  
* [MyInventory](Sandbox.Game.MyInventory)

