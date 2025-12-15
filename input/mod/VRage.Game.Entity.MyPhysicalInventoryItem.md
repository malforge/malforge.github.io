**Assembly:** VRage.Game.dll

```csharp
public struct MyPhysicalInventoryItem: IMyInventoryItem, IMyInventoryItem
```

Implements physical item data

## Fields

|Member|Description|
|---|---|
|[Amount](VRage.Game.Entity.MyPhysicalInventoryItem@Amount)||
|[ItemId](VRage.Game.Entity.MyPhysicalInventoryItem@ItemId)||
|[Scale](VRage.Game.Entity.MyPhysicalInventoryItem@Scale)||

## Properties

|Member|Description|
|---|---|
|[Content](VRage.Game.Entity.MyPhysicalInventoryItem@Content)||
|[Amount](VRage.Game.ModAPI.Ingame.IMyInventoryItem@Amount)|Gets or sets amount of items<br /><br />_Inherited from [IMyInventoryItem](VRage.Game.ModAPI.Ingame.IMyInventoryItem)_|
|[Content](VRage.Game.ModAPI.Ingame.IMyInventoryItem@Content)|Gets or sets content of inventory item. Cast it to [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)<br /><br />_Inherited from [IMyInventoryItem](VRage.Game.ModAPI.Ingame.IMyInventoryItem)_|
|[ItemId](VRage.Game.ModAPI.Ingame.IMyInventoryItem@ItemId)|Item Id. Used to determine exact stack<br /><br />_Inherited from [IMyInventoryItem](VRage.Game.ModAPI.Ingame.IMyInventoryItem)_|
|[Scale](VRage.Game.ModAPI.Ingame.IMyInventoryItem@Scale)|Gets or sets scale of Floating object<br /><br />_Inherited from [IMyInventoryItem](VRage.Game.ModAPI.Ingame.IMyInventoryItem)_|

## Constructors

|Member|Description|
|---|---|
|[MyPhysicalInventoryItem(MyFixedPoint, MyObjectBuilder_PhysicalObject, float)](VRage.Game.Entity.MyPhysicalInventoryItem@.ctor)||
|[MyPhysicalInventoryItem(MyObjectBuilder_InventoryItem)](VRage.Game.Entity.MyPhysicalInventoryItem@.ctor)||

## Methods

|Member|Description|
|---|---|
|[GetObjectBuilder()](VRage.Game.Entity.MyPhysicalInventoryItem@GetObjectBuilder)||
|[ToString()](VRage.Game.Entity.MyPhysicalInventoryItem@ToString)||

**Implements:**  
* [IMyInventoryItem](VRage.Game.ModAPI.IMyInventoryItem)  
* [IMyInventoryItem](VRage.Game.ModAPI.Ingame.IMyInventoryItem)

