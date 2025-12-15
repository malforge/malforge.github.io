## Summary

```csharp
public List<IMyCubeGrid> GetGroup(IMyCubeGrid node, GridLinkTypeEnum type)
```

OBSOLETE: Use GetGroup with passing your own collection, it is better for simulation speed. Returns all grids connected to the given grid by the specified link type. Array always contains node.

## Returns

[List<IMyCubeGrid>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)

New list of connected grids

## Parameters

* [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid) node
* [GridLinkTypeEnum](VRage.Game.ModAPI.GridLinkTypeEnum) type
## Summary

```csharp
public void GetGroup(IMyCubeGrid node, GridLinkTypeEnum type, ICollection<IMyCubeGrid> collection)
```

Returns all grids connected to the given grid by the specified link type. Array always contains node.

## Parameters

* [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid) node
* [GridLinkTypeEnum](VRage.Game.ModAPI.GridLinkTypeEnum) type
* [ICollection<IMyCubeGrid>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=netframework-4.6) collection
