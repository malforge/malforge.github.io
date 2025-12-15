## Summary

```csharp
public bool DrainAll { get; set; }
```

Determines whether the sorter should drain any inventories connected to it and push them to the other side - as long as the items passes the filtering as defined by the filter list ( [GetFilterList(List<MyInventoryItemFilter>)](Sandbox.ModAPI.Ingame.IMyConveyorSorter@GetFilterList) ) and [Mode](Sandbox.ModAPI.Ingame.IMyConveyorSorter@Mode) .

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

