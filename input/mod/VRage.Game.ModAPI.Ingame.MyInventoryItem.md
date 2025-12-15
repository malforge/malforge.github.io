**Assembly:** VRage.Game.dll

```csharp
public struct MyInventoryItem: IComparable<MyInventoryItem>, IEquatable<MyInventoryItem>
```

Snapshot of inventory item at the moment of query. Not updated afterwards!

## Fields

|Member|Description|
|---|---|
|[Amount](VRage.Game.ModAPI.Ingame.MyInventoryItem@Amount)|Amount of stacked items. Kg or count, based on item type.|
|[ItemId](VRage.Game.ModAPI.Ingame.MyInventoryItem@ItemId)|Id of item, unique within a single inventory.|
|[Type](VRage.Game.ModAPI.Ingame.MyInventoryItem@Type)|Type of inventory item.|

## Constructors

|Member|Description|
|---|---|
|[MyInventoryItem(MyItemType, uint, MyFixedPoint)](VRage.Game.ModAPI.Ingame.MyInventoryItem@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CompareTo(MyInventoryItem)](VRage.Game.ModAPI.Ingame.MyInventoryItem@CompareTo)||
|[Equals(MyInventoryItem)](VRage.Game.ModAPI.Ingame.MyInventoryItem@Equals)||
|[Equals(object)](VRage.Game.ModAPI.Ingame.MyInventoryItem@Equals)||
|[GetHashCode()](VRage.Game.ModAPI.Ingame.MyInventoryItem@GetHashCode)||
|[ToString()](VRage.Game.ModAPI.Ingame.MyInventoryItem@ToString)||

**Implements:**  
* [IComparable<MyInventoryItem>](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netframework-4.6)  
* [IEquatable<MyInventoryItem>](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

