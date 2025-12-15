## Summary

```csharp
public IMyInventory GetInventory()
```

Simply get the MyInventoryBase component stored in this entity.

## Returns

[IMyInventory](VRage.Game.ModAPI.IMyInventory)

Null, or first inventory

## Summary

```csharp
public IMyInventory GetInventory(int index)
```

Search for inventory component with matching index.

## Returns

[IMyInventory](VRage.Game.ModAPI.IMyInventory)

Null, or inventory at matching index

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) index
