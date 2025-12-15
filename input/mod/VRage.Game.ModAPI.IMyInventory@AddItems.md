## Summary

```csharp
public void AddItems(MyFixedPoint amount, MyObjectBuilder_PhysicalObject objectBuilder, int index)
```

Adds item to inventory. Doesn't do all checks inside. Call [CanAddItemAmount(IMyInventoryItem, MyFixedPoint)](VRage.Game.ModAPI.IMyInventory@CanAddItemAmount) before this function

## Parameters

* [MyFixedPoint](VRage.MyFixedPoint) amount
* [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject) objectBuilder
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) index
