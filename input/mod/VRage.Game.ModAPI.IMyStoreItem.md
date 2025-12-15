**Assembly:** VRage.Game.dll

```csharp
public interface IMyStoreItem
```

## Events

|Member|Description|
|---|---|
|[OnCancel](VRage.Game.ModAPI.IMyStoreItem@OnCancel)|When owner of store block cancels order/offer regarding this item|
|[OnTransaction](VRage.Game.ModAPI.IMyStoreItem@OnTransaction)|When player makes an transaction regarding this item int - amount sold int - amount remaining int - price of transaction long - owner of block long - buyer/seller|

## Properties

|Member|Description|
|---|---|
|[Amount](VRage.Game.ModAPI.IMyStoreItem@Amount)|The amount of the item that is available for purchase in the store|
|[Id](VRage.Game.ModAPI.IMyStoreItem@Id)|The entity id of the store item|
|[IsActive](VRage.Game.ModAPI.IMyStoreItem@IsActive)|Determines if Amount is greater than 0|
|[IsCustomStoreItem](VRage.Game.ModAPI.IMyStoreItem@IsCustomStoreItem)|Determines if the item should behave similar to how store items in Vanilla Economy Stations work (eg: doesn't require physical inventory). This is required when adding Gas / Grid items to a store.|
|[Item](VRage.Game.ModAPI.IMyStoreItem@Item)|Definition Id of the item|
|[ItemType](VRage.Game.ModAPI.IMyStoreItem@ItemType)|The type of item. eg: PhysicalItem, Grid, etc|
|[PrefabName](VRage.Game.ModAPI.IMyStoreItem@PrefabName)|The name of the Prefab Definition SubtypeId if the item is a Grid|
|[PrefabTotalPcu](VRage.Game.ModAPI.IMyStoreItem@PrefabTotalPcu)|The PCU value of a Grid item|
|[PricePerUnit](VRage.Game.ModAPI.IMyStoreItem@PricePerUnit)|The individual cost of a single item.|
|[PricePerUnitDiscount](VRage.Game.ModAPI.IMyStoreItem@PricePerUnitDiscount)|This governs the tooltip that appears when you hover your cursor over the price in the store (eg: 0.5 for 50% discount). This doesn't actually affect the price, use Amount to adjust that.|
|[RemovedAmount](VRage.Game.ModAPI.IMyStoreItem@RemovedAmount)|The amount that has been removed from the item through purchases (ie: Purchased Amount)|
|[StoreItemType](VRage.Game.ModAPI.IMyStoreItem@StoreItemType)|Defines whether the item is an Offer (store is selling to you) or an Order (store is buying from you)|

