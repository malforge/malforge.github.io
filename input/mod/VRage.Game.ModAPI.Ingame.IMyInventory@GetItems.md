## Summary

```csharp
public void GetItems(List<MyInventoryItem> items, Func<MyInventoryItem, bool> filter)
```

Collects all items present inside this inventory and returns snapshot of the current inventory state.

## Parameters

* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[MyInventoryItem](VRage.Game.ModAPI.Ingame.MyInventoryItem)&gt; items
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;[MyInventoryItem](VRage.Game.ModAPI.Ingame.MyInventoryItem), [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt; filter
