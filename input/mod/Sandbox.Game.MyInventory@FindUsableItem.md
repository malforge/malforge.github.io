## Summary

```csharp
public MyPhysicalInventoryItem? FindUsableItem(MyDefinitionId contentId)
```

This will try to find the first item that can be use. This means, if durability is enabled on items, it will look for first item with durability HP > 0, if this is disabled, this will behave the same as FindItem method

## Returns

[MyPhysicalInventoryItem?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

item that has durability > 0 if found

## Parameters

* [MyDefinitionId](VRage.Game.MyDefinitionId) contentId
