## Summary

```csharp
public List<MyCubeGrid> GetConnectedGrids(GridLinkTypeEnum type, List<MyCubeGrid> list)
```

Get all grids connected to this grid

## Returns

[List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid)&gt;



## Parameters

* [GridLinkTypeEnum](VRage.Game.ModAPI.GridLinkTypeEnum) type
* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid)&gt; list
## Summary

```csharp
public void GetConnectedGrids(GridLinkTypeEnum type, Action<MyCubeGrid> action)
```

Iterate over all grids connected to this grid

## Parameters

* [GridLinkTypeEnum](VRage.Game.ModAPI.GridLinkTypeEnum) type
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6)&lt;[MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid)&gt; action
