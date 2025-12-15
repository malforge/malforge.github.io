## Summary

```csharp
public virtual MyInventoryBase IterateInventory(int searchIndex, int currentIndex)
```

Search for inventory having given search index. Aggregate inventory: Iterates through aggregate inventory until simple inventory with matching index is found. Simple inventory: Returns itself if currentIndex == searchIndex. Usage: searchIndex = index of inventory being searched, leave currentIndex = 0.

## Returns

[MyInventoryBase](VRage.Game.Entity.MyInventoryBase)

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) searchIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) currentIndex
