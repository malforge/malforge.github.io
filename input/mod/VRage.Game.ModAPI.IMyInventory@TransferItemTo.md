## Summary

```csharp
public bool TransferItemTo(IMyInventory dst, int sourceItemIndex, int? targetItemIndex, bool? stackIfPossible, MyFixedPoint? amount, bool checkConnection)
```

Transfer item from one inventory to another

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if checkConnection is false, or inventories are connected with correct conveyor

## Parameters

* [IMyInventory](VRage.Game.ModAPI.IMyInventory) dst
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceItemIndex
* [int?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) targetItemIndex
* [bool?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) stackIfPossible
* [MyFixedPoint?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) amount
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) checkConnection
