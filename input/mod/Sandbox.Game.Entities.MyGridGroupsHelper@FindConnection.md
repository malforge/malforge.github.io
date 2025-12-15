## Summary

```csharp
public List<KeyValuePair<long, IMyCubeGrid>> FindConnection(GridLinkTypeEnum linking, IMyCubeGrid from, Func<IMyCubeGrid, IMyCubeGrid, long, bool> searcher)
```

## Returns

[List<KeyValuePair<long, IMyCubeGrid>>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)

## Parameters

* [GridLinkTypeEnum](VRage.Game.ModAPI.GridLinkTypeEnum) linking
* [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid) from
* [Func<IMyCubeGrid, IMyCubeGrid, long, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4?view=netframework-4.6) searcher
