**Assembly:** VRage.Game.dll

```csharp
public interface IMyGridGroups
```

ModAPI interface giving access to grid-groups

## Events

|Member|Description|
|---|---|
|[OnGridGroupCreated](VRage.Game.ModAPI.IMyGridGroups@OnGridGroupCreated)|Called when new grid-group was created. Example 1: 1 large grid-group splitted into 2 parts. Example 2: new grid created|
|[OnGridGroupDestroyed](VRage.Game.ModAPI.IMyGridGroups@OnGridGroupDestroyed)|Called when grid-group was destroyed. Example 1: 2 small grids-groups joined into larger one. Example 2: grid, not connected to any other grid, was destroyed|

## Methods

|Member|Description|
|---|---|
|[AddGridGroupLogic<T>(GridLinkTypeEnum, Func<IMyGridGroupData, T>)](VRage.Game.ModAPI.IMyGridGroups@AddGridGroupLogic{T})||
|[FindConnection(GridLinkTypeEnum, IMyCubeGrid, Func<IMyCubeGrid, IMyCubeGrid, long, bool>)](VRage.Game.ModAPI.IMyGridGroups@FindConnection)|Dijkstra search over grid-to-grid connections until searcher is return true NOTE: pretty expensive function on large grid-groups, don't call it often.|
|[GetGridGroup(GridLinkTypeEnum, IMyCubeGrid)](VRage.Game.ModAPI.IMyGridGroups@GetGridGroup)|Gets grid-group for provided grid|
|[GetGridGroups<T>(GridLinkTypeEnum, T)](VRage.Game.ModAPI.IMyGridGroups@GetGridGroups{T})||
|[GetGroup(IMyCubeGrid, GridLinkTypeEnum, ICollection<IMyCubeGrid>)](VRage.Game.ModAPI.IMyGridGroups@GetGroup)|Returns all grids connected to the given grid by the specified link type. Array always contains node.|
|[HasConnection(IMyCubeGrid, IMyCubeGrid, GridLinkTypeEnum)](VRage.Game.ModAPI.IMyGridGroups@HasConnection)|Checks if two grids are connected by the given link type.|
|[GetGroup(IMyCubeGrid, GridLinkTypeEnum)](VRage.Game.ModAPI.IMyGridGroups@GetGroup)|_**Obsolete:** Use GetGroup with passing your own collection, it is better for simulation speed_<br /><br />OBSOLETE: Use GetGroup with passing your own collection, it is better for simulation speed. Returns all grids connected to the given grid by the specified link type. Array always contains node.|

**Inheritors:**  
* [MyGridGroupsHelper](Sandbox.Game.Entities.MyGridGroupsHelper)

