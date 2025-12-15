## Summary

```csharp
public List<MyCubeGrid> GetConnectedGrids(GridLinkTypeEnum type, List<MyCubeGrid> list)
```

Get all grids connected to this grid

## Returns

[List<MyCubeGrid>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)



## Parameters

* [GridLinkTypeEnum](VRage.Game.ModAPI.GridLinkTypeEnum) type
* [List<MyCubeGrid>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) list
## Summary

```csharp
public void GetConnectedGrids(GridLinkTypeEnum type, Action<MyCubeGrid> action)
```

Iterate over all grids connected to this grid

## Parameters

* [GridLinkTypeEnum](VRage.Game.ModAPI.GridLinkTypeEnum) type
* [Action<MyCubeGrid>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) action
