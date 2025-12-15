**Assembly:** Sandbox.Game.dll

```csharp
public class MyGridGroupsHelper: IMyGridGroups
```

## Events

|Member|Description|
|---|---|
|[OnGridGroupCreated](Sandbox.Game.Entities.MyGridGroupsHelper@OnGridGroupCreated)||
|[OnGridGroupDestroyed](Sandbox.Game.Entities.MyGridGroupsHelper@OnGridGroupDestroyed)||
|[OnGridGroupCreated](VRage.Game.ModAPI.IMyGridGroups@OnGridGroupCreated)|Called when new grid-group was created. Example 1: 1 large grid-group splitted into 2 parts. Example 2: new grid created<br /><br />_Inherited from [IMyGridGroups](VRage.Game.ModAPI.IMyGridGroups)_|
|[OnGridGroupDestroyed](VRage.Game.ModAPI.IMyGridGroups@OnGridGroupDestroyed)|Called when grid-group was destroyed. Example 1: 2 small grids-groups joined into larger one. Example 2: grid, not connected to any other grid, was destroyed<br /><br />_Inherited from [IMyGridGroups](VRage.Game.ModAPI.IMyGridGroups)_|

## Constructors

|Member|Description|
|---|---|
|[MyGridGroupsHelper()](Sandbox.Game.Entities.MyGridGroupsHelper@.ctor)||

## Methods

|Member|Description|
|---|---|
|[AddGridGroupLogic<T>(GridLinkTypeEnum, Func<IMyGridGroupData, T>)](Sandbox.Game.Entities.MyGridGroupsHelper@AddGridGroupLogic{T})||
|[FindConnection(GridLinkTypeEnum, IMyCubeGrid, Func<IMyCubeGrid, IMyCubeGrid, long, bool>)](Sandbox.Game.Entities.MyGridGroupsHelper@FindConnection)||
|[GetGridGroup(GridLinkTypeEnum, IMyCubeGrid)](Sandbox.Game.Entities.MyGridGroupsHelper@GetGridGroup)||
|[GetGridGroups<T>(GridLinkTypeEnum, T)](Sandbox.Game.Entities.MyGridGroupsHelper@GetGridGroups{T})||
|[AddGridGroupLogic<T>(GridLinkTypeEnum, Func<IMyGridGroupData, T>)](VRage.Game.ModAPI.IMyGridGroups@AddGridGroupLogic{T})|_Inherited from [IMyGridGroups](VRage.Game.ModAPI.IMyGridGroups)_|
|[FindConnection(GridLinkTypeEnum, IMyCubeGrid, Func<IMyCubeGrid, IMyCubeGrid, long, bool>)](VRage.Game.ModAPI.IMyGridGroups@FindConnection)|Dijkstra search over grid-to-grid connections until searcher is return true NOTE: pretty expensive function on large grid-groups, don't call it often.<br /><br />_Inherited from [IMyGridGroups](VRage.Game.ModAPI.IMyGridGroups)_|
|[GetGridGroup(GridLinkTypeEnum, IMyCubeGrid)](VRage.Game.ModAPI.IMyGridGroups@GetGridGroup)|Gets grid-group for provided grid<br /><br />_Inherited from [IMyGridGroups](VRage.Game.ModAPI.IMyGridGroups)_|
|[GetGridGroups<T>(GridLinkTypeEnum, T)](VRage.Game.ModAPI.IMyGridGroups@GetGridGroups{T})|_Inherited from [IMyGridGroups](VRage.Game.ModAPI.IMyGridGroups)_|
|[GetGroup(IMyCubeGrid, GridLinkTypeEnum, ICollection<IMyCubeGrid>)](VRage.Game.ModAPI.IMyGridGroups@GetGroup)|Returns all grids connected to the given grid by the specified link type. Array always contains node.<br /><br />_Inherited from [IMyGridGroups](VRage.Game.ModAPI.IMyGridGroups)_|
|[HasConnection(IMyCubeGrid, IMyCubeGrid, GridLinkTypeEnum)](VRage.Game.ModAPI.IMyGridGroups@HasConnection)|Checks if two grids are connected by the given link type.<br /><br />_Inherited from [IMyGridGroups](VRage.Game.ModAPI.IMyGridGroups)_|
|[GetGroup(IMyCubeGrid, GridLinkTypeEnum)](Sandbox.Game.Entities.MyGridGroupsHelper@GetGroup)|_**Obsolete:** Use GetGroup with passing your own collection, it is better for simulation speed_|
|[GetGroup(IMyCubeGrid, GridLinkTypeEnum, ICollection<IMyCubeGrid>)](Sandbox.Game.Entities.MyGridGroupsHelper@GetGroup)|_**Obsolete:** Use MyCubeGrid.GetConnectedGrids instead_|
|[HasConnection(IMyCubeGrid, IMyCubeGrid, GridLinkTypeEnum)](Sandbox.Game.Entities.MyGridGroupsHelper@HasConnection)|_**Obsolete:** Use MyCubeGrid.IsConnectedTo instead_|
|[GetGroup(IMyCubeGrid, GridLinkTypeEnum)](VRage.Game.ModAPI.IMyGridGroups@GetGroup)|_**Obsolete:** Use GetGroup with passing your own collection, it is better for simulation speed_<br /><br />OBSOLETE: Use GetGroup with passing your own collection, it is better for simulation speed. Returns all grids connected to the given grid by the specified link type. Array always contains node.<br /><br />_Inherited from [IMyGridGroups](VRage.Game.ModAPI.IMyGridGroups)_|

**Implements:**  
* [IMyGridGroups](VRage.Game.ModAPI.IMyGridGroups)

