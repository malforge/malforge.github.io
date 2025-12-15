## Summary

```csharp
public bool TransferItemFrom(IMyInventory sourceInventory, int sourceItemIndex, int? targetItemIndex, bool? stackIfPossible, MyFixedPoint? amount, bool checkConnection)
```

Transfer item from one inventory to another

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if checkConnection is false, or inventories are connected with correct conveyor

## Parameters

* [IMyInventory](VRage.Game.ModAPI.IMyInventory) sourceInventory
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceItemIndex
* [int?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) targetItemIndex
* [bool?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) stackIfPossible
* [MyFixedPoint?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) amount
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) checkConnection
## Summary

```csharp
public bool TransferItemFrom(IMyInventory sourceInventory, IMyInventoryItem item, MyFixedPoint amount)
```

Transfer item from one inventory to another

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if two inventories are connected

## Parameters

* [IMyInventory](VRage.Game.ModAPI.IMyInventory) sourceInventory
* [IMyInventoryItem](VRage.Game.ModAPI.IMyInventoryItem) item
* [MyFixedPoint](VRage.MyFixedPoint) amount
## Remarks

Items could be transferred only through conveyors

