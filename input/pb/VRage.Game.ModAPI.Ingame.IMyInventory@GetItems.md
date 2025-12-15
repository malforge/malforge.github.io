## Summary

```csharp
public void GetItems(List<MyInventoryItem> items, Func<MyInventoryItem, bool> filter)
```

Collects all items present inside this inventory and returns snapshot of the current inventory state.

## Parameters

* [List<MyInventoryItem>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) items
* [Func<MyInventoryItem, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) filter
