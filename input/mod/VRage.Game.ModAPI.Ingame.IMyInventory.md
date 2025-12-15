**Assembly:** VRage.Game.dll

```csharp
public interface IMyInventory
```

Describes inventory interface (PB scripting interface)

## Properties

|Member|Description|
|---|---|
|[CanPutItems](VRage.Game.ModAPI.Ingame.IMyInventory@CanPutItems)|Gets if inventory can receive items or not.|
|[CurrentMass](VRage.Game.ModAPI.Ingame.IMyInventory@CurrentMass)|Returns total mass of items inside this inventory in Kg.|
|[CurrentVolume](VRage.Game.ModAPI.Ingame.IMyInventory@CurrentVolume)|Returns total volume of items inside this inventory in m^3.|
|[IsFull](VRage.Game.ModAPI.Ingame.IMyInventory@IsFull)|Determines if inventory is absolutely full.|
|[ItemCount](VRage.Game.ModAPI.Ingame.IMyInventory@ItemCount)|Returns number of occupied inventory slots.|
|[MaxVolume](VRage.Game.ModAPI.Ingame.IMyInventory@MaxVolume)|Sets maximum volume of items this inventory can contain in m^3.|
|[Owner](VRage.Game.ModAPI.Ingame.IMyInventory@Owner)|Returns entity this inventory belongs to.|
|[VolumeFillFactor](VRage.Game.ModAPI.Ingame.IMyInventory@VolumeFillFactor)|Gets the current volume fill factor of the inventory|

## Methods

|Member|Description|
|---|---|
|[CanItemsBeAdded(MyFixedPoint, MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@CanItemsBeAdded)|Determines if given amount of items fits into this inventory on top of existing items.|
|[CanTransferItemTo(IMyInventory, MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@CanTransferItemTo)|Determines if there is working conveyor connection for item of give type to be transferred to other inventory.|
|[ContainItems(MyFixedPoint, MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@ContainItems)|Determines if there is at least given amount of items of given type contained inside this inventory.|
|[FindItem(MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@FindItem)|Tries to find an item of given type inside this inventory.|
|[GetAcceptedItems(List<MyItemType>, Func<MyItemType, bool>)](VRage.Game.ModAPI.Ingame.IMyInventory@GetAcceptedItems)|Returns all items this inventory accepts.|
|[GetItemAmount(MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItemAmount)|Sums up total amount of items of given type contained inside this inventory.|
|[GetItemAt(int)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItemAt)|Returns info about item at give position.|
|[GetItemByID(uint)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItemByID)|Returns info about item contained inside this inventory.|
|[GetItems(List<MyInventoryItem>, Func<MyInventoryItem, bool>)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItems)|Collects all items present inside this inventory and returns snapshot of the current inventory state.|
|[IsConnectedTo(IMyInventory)](VRage.Game.ModAPI.Ingame.IMyInventory@IsConnectedTo)|Checks if two inventories are connected.|
|[IsItemAt(int)](VRage.Game.ModAPI.Ingame.IMyInventory@IsItemAt)|Determines if there is any item on given inventory slot.|
|[TransferItemFrom(IMyInventory, MyInventoryItem, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemFrom)|Attempts to transfer item from one inventory to another.|
|[TransferItemFrom(IMyInventory, int, int?, bool?, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemFrom)|Attempts to transfer item from one inventory to another.|
|[TransferItemTo(IMyInventory, MyInventoryItem, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemTo)|Attempts to transfer item from one inventory to another.|
|[TransferItemTo(IMyInventory, int, int?, bool?, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemTo)|Attempts to transfer item from one inventory to another.|

**Inheritors:**  
* [IMyInventory](VRage.Game.ModAPI.IMyInventory)  
* [MyInventory](Sandbox.Game.MyInventory)

