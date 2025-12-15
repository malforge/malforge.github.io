## Summary

```csharp
public bool TransferItemTo(IMyInventory dstInventory, MyInventoryItem item, MyFixedPoint? amount)
```

Attempts to transfer item from one inventory to another.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True in case item was successfully transferred, false otherwise

## Parameters

* [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory) dstInventory
* [MyInventoryItem](VRage.Game.ModAPI.Ingame.MyInventoryItem) item
* [MyFixedPoint?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) amount
## Summary

```csharp
public bool TransferItemTo(IMyInventory dst, int sourceItemIndex, int? targetItemIndex, bool? stackIfPossible, MyFixedPoint? amount)
```

Attempts to transfer item from one inventory to another.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True in case item was successfully transferred, false otherwise

## Parameters

* [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory) dst
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceItemIndex
* [int?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) targetItemIndex
* [bool?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) stackIfPossible
* [MyFixedPoint?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) amount
