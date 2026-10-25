## Summary

```csharp
public List<KeyValuePair<long, IMyCubeGrid>> FindConnection(GridLinkTypeEnum linking, IMyCubeGrid from, Func<IMyCubeGrid, IMyCubeGrid, long, bool> searcher)
```

## Returns

[List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[KeyValuePair](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=netframework-4.6)&lt;[long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6), [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)&gt;&gt;

## Parameters

* [GridLinkTypeEnum](VRage.Game.ModAPI.GridLinkTypeEnum) linking
* [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid) from
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4?view=netframework-4.6)&lt;[IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid), [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid), [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6), [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt; searcher
