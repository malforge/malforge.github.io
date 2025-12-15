**Assembly:** Sandbox.Game.dll

```csharp
public class MyCubeGridGroups: IMySceneComponent
```

## Fields

|Member|Description|
|---|---|
|[static Static](Sandbox.Game.Entities.MyCubeGridGroups@Static)||
|[Electrical](Sandbox.Game.Entities.MyCubeGridGroups@Electrical)||
|[Logical](Sandbox.Game.Entities.MyCubeGridGroups@Logical)||
|[Mechanical](Sandbox.Game.Entities.MyCubeGridGroups@Mechanical)||
|[NoContactDamage](Sandbox.Game.Entities.MyCubeGridGroups@NoContactDamage)||
|[Physical](Sandbox.Game.Entities.MyCubeGridGroups@Physical)||
|[PhysicalDynamic](Sandbox.Game.Entities.MyCubeGridGroups@PhysicalDynamic)||
|[SmallToLargeBlockConnections](Sandbox.Game.Entities.MyCubeGridGroups@SmallToLargeBlockConnections)||

## Events

|Member|Description|
|---|---|
|[OnGridGroupCreated](Sandbox.Game.Entities.MyCubeGridGroups@OnGridGroupCreated)||
|[OnGridGroupDestroyed](Sandbox.Game.Entities.MyCubeGridGroups@OnGridGroupDestroyed)||

## Constructors

|Member|Description|
|---|---|
|[MyCubeGridGroups()](Sandbox.Game.Entities.MyCubeGridGroups@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static AddGridGroupLogic(GridLinkTypeEnum, Func<IMyGridGroupData, MyGridGroupsDefaultEventHandler>)](Sandbox.Game.Entities.MyCubeGridGroups@AddGridGroupLogic)||
|[static FindConnection(GridLinkTypeEnum, IMyCubeGrid, Func<IMyCubeGrid, IMyCubeGrid, long, bool>)](Sandbox.Game.Entities.MyCubeGridGroups@FindConnection)|Dijkstra search over grid-to-grid connections until searcher is return true NOTE: pretty expensive function on large grid-groups, don't call it often.|
|[static GetGridGroup(GridLinkTypeEnum, MyCubeGrid)](Sandbox.Game.Entities.MyCubeGridGroups@GetGridGroup)||
|[static GetGridGroups<T>(GridLinkTypeEnum, T)](Sandbox.Game.Entities.MyCubeGridGroups@GetGridGroups{T})||
|[AddNode(GridLinkTypeEnum, MyCubeGrid)](Sandbox.Game.Entities.MyCubeGridGroups@AddNode)||
|[BreakLink(GridLinkTypeEnum, long, MyCubeGrid, MyCubeGrid)](Sandbox.Game.Entities.MyCubeGridGroups@BreakLink)|Breaks link between parent and child, you can set child to null to find it by linkId. Returns true when link was removed, returns false when link was not found.|
|[CreateLink(GridLinkTypeEnum, long, MyCubeGrid, MyCubeGrid)](Sandbox.Game.Entities.MyCubeGridGroups@CreateLink)|Creates link between parent and child. Parent is owner of constraint. LinkId must be unique only for parent, for grid it can be packed position of block which created constraint.|
|[GetGroups(GridLinkTypeEnum)](Sandbox.Game.Entities.MyCubeGridGroups@GetGroups)||
|[RemoveNode(GridLinkTypeEnum, MyCubeGrid)](Sandbox.Game.Entities.MyCubeGridGroups@RemoveNode)||
|[UpdateDynamicState(MyCubeGrid)](Sandbox.Game.Entities.MyCubeGridGroups@UpdateDynamicState)||
|[Load()](Sandbox.Game.Entities.IMySceneComponent@Load)|_Inherited from [IMySceneComponent](Sandbox.Game.Entities.IMySceneComponent)_|
|[Unload()](Sandbox.Game.Entities.IMySceneComponent@Unload)|_Inherited from [IMySceneComponent](Sandbox.Game.Entities.IMySceneComponent)_|

**Implements:**  
* [IMySceneComponent](Sandbox.Game.Entities.IMySceneComponent)

