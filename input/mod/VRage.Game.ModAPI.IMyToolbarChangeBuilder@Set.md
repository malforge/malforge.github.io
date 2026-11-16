## Summary

```csharp
public IMyToolbarChangeBuilder Set(int index, MyToolbarItemInfo item)
```

Places an item in a slot, replacing whatever is there. This is what [TryGetItem(int, out MyToolbarItemInfo)](VRage.Game.ModAPI.IMyToolbarSlots@TryGetItem) returns, so a slot read from one toolbar can be placed in another as it stands. Any arguments the action takes are dropped; use the Set overload in Sandbox.ModAPI to carry them.

## Returns

[IMyToolbarChangeBuilder](VRage.Game.ModAPI.IMyToolbarChangeBuilder)

This builder, or a rejected builder when the item names a definition that is not loaded.

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) index
* [MyToolbarItemInfo](VRage.Game.ModAPI.MyToolbarItemInfo) item
