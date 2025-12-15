## Summary

```csharp
public bool CanAddItemAmount(IMyInventoryItem item, MyFixedPoint amount)
```

Gets whether item could be added into inventory, but doesn't add it Checks: - Inserting volume - Inventory can receive items - Inventory filter can

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if item can be added

## Parameters

* [IMyInventoryItem](VRage.Game.ModAPI.IMyInventoryItem) item
* [MyFixedPoint](VRage.MyFixedPoint) amount
