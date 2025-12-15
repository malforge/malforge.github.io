## Summary

```csharp
public bool IsAllowed(MyDefinitionId id)
```

Determines whether a given item type is allowed go through the sorter, depending on the filter list ( [GetFilterList(List<MyInventoryItemFilter>)](Sandbox.ModAPI.Ingame.IMyConveyorSorter@GetFilterList) ) and [Mode](Sandbox.ModAPI.Ingame.IMyConveyorSorter@Mode) .

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

Whether a given item type is allowed go through the sorter

## Parameters

* [MyDefinitionId](VRage.Game.MyDefinitionId) id
