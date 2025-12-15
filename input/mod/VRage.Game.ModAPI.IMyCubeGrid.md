**Assembly:** VRage.Game.dll

```csharp
public interface IMyCubeGrid: IMyEntity, IMyEntity, IMyCubeGrid
```

Declares grid interface. (mods interface) Grid - an entity that consist of [IMySlimBlock](VRage.Game.ModAPI.IMySlimBlock) . Blocks like rotor, piston, hinge, motor suspension, on their creation creates top part, that belongs to another grid. Player created ships, can consist of many grids.

## Events

|Member|Description|
|---|---|
|[GridPresenceTierChanged](VRage.Game.ModAPI.IMyCubeGrid@GridPresenceTierChanged)|Triggered when grid presence tier is changed|
|[OnBlockAdded](VRage.Game.ModAPI.IMyCubeGrid@OnBlockAdded)|Called when a block is added to the grid|
|[OnBlockIntegrityChanged](VRage.Game.ModAPI.IMyCubeGrid@OnBlockIntegrityChanged)|Triggered when block integrity changes (construction)|
|[OnBlockOwnershipChanged](VRage.Game.ModAPI.IMyCubeGrid@OnBlockOwnershipChanged)|Called when a block on the grid changes owner|
|[OnBlockRemoved](VRage.Game.ModAPI.IMyCubeGrid@OnBlockRemoved)|Called when a block is removed from the grid|
|[OnGridBlockDamaged](VRage.Game.ModAPI.IMyCubeGrid@OnGridBlockDamaged)|Called when one of blocks on grid is taking damage|
|[OnGridChanged](VRage.Game.ModAPI.IMyCubeGrid@OnGridChanged)|Called when a grid is taken control of by a player|
|[OnGridMerge](VRage.Game.ModAPI.IMyCubeGrid@OnGridMerge)|Called, when 2 grids are merged with merge block. First grid - grid that will stay, second - will be merged into first, and deleted. Called for both grids|
|[OnGridSplit](VRage.Game.ModAPI.IMyCubeGrid@OnGridSplit)|Triggered when grid is split|
|[OnIsStaticChanged](VRage.Game.ModAPI.IMyCubeGrid@OnIsStaticChanged)|Triggered when grid changes to or from static (station)|
|[OnMaxThrustChanged](VRage.Game.ModAPI.IMyCubeGrid@OnMaxThrustChanged)|Triggered when max thrust in one of directions was changed. Maybe called from parralel thread|
|[OnNaturalGravityChanged](VRage.Game.ModAPI.IMyCubeGrid@OnNaturalGravityChanged)|Triggered when natural gravity changes around the grid|
|[OnTargetLocked](VRage.Game.ModAPI.IMyCubeGrid@OnTargetLocked)|Called when grid was target locked|
|[PlayerPresenceTierChanged](VRage.Game.ModAPI.IMyCubeGrid@PlayerPresenceTierChanged)|Triggered when player presence tier is changed|
|[SpeedChanged](VRage.Game.ModAPI.IMyCubeGrid@SpeedChanged)|Triggered when speed of the grid is changed|
|[OnClose](VRage.ModAPI.IMyEntity@OnClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnClosing](VRage.ModAPI.IMyEntity@OnClosing)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnPhysicsChanged](VRage.ModAPI.IMyEntity@OnPhysicsChanged)|Called when havok rigid body physics are changed: inited, closed, modified.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

## Properties

|Member|Description|
|---|---|
|[BigOwners](VRage.Game.ModAPI.IMyCubeGrid@BigOwners)|List of players with majority of blocks on grid|
|[ControlSystem](VRage.Game.ModAPI.IMyCubeGrid@ControlSystem)|Gets grid-group control system|
|[ConveyorSystem](VRage.Game.ModAPI.IMyCubeGrid@ConveyorSystem)|Gets grid-group conveyor system|
|[CustomName](VRage.Game.ModAPI.IMyCubeGrid@CustomName)|Display name of the grid (as seen in Info terminal tab)|
|[GasSystem](VRage.Game.ModAPI.IMyCubeGrid@GasSystem)|Gets grid-group gas system|
|[GridPresenceTier](VRage.Game.ModAPI.IMyCubeGrid@GridPresenceTier)|Gets grid presence tier|
|[IsBlockTrasferInProgress](VRage.Game.ModAPI.IMyCubeGrid@IsBlockTrasferInProgress)|Gets whether the move block transfer from one grid to another is in progress. This happens during the split operation.|
|[IsNpcSpawnedGrid](VRage.Game.ModAPI.IMyCubeGrid@IsNpcSpawnedGrid)|Gets if this grid is NPC spawned grid by the system (cargo ship, encounter, etc)|
|[IsRespawnGrid](VRage.Game.ModAPI.IMyCubeGrid@IsRespawnGrid)|Gets or sets if this grid is a respawn grid (can be cleaned up automatically when player leaves)|
|[IsStatic](VRage.Game.ModAPI.IMyCubeGrid@IsStatic)|Gets or sets if the grid is static (station)|
|[JumpSystem](VRage.Game.ModAPI.IMyCubeGrid@JumpSystem)|Gets grid-group jump system|
|[NaturalGravity](VRage.Game.ModAPI.IMyCubeGrid@NaturalGravity)|Gets natural gravity around the grid|
|[PlayerPresenceTier](VRage.Game.ModAPI.IMyCubeGrid@PlayerPresenceTier)|Gets player presence tier|
|[ResourceDistributor](VRage.Game.ModAPI.IMyCubeGrid@ResourceDistributor)|Gets grid-group resource distributor|
|[RvoAgentId](VRage.Game.ModAPI.IMyCubeGrid@RvoAgentId)|Gets RVO Agent ID used for collision avoidance algorithm|
|[SmallOwners](VRage.Game.ModAPI.IMyCubeGrid@SmallOwners)|List of players with any blocks on grid|
|[WeaponSystem](VRage.Game.ModAPI.IMyCubeGrid@WeaponSystem)|Gets grid-group weapon system|
|[XSymmetryOdd](VRage.Game.ModAPI.IMyCubeGrid@XSymmetryOdd)|Gets or sets if the symmetry plane is offset from the block center|
|[XSymmetryPlane](VRage.Game.ModAPI.IMyCubeGrid@XSymmetryPlane)|Gets or sets X-Axis build symmetry plane|
|[YSymmetryOdd](VRage.Game.ModAPI.IMyCubeGrid@YSymmetryOdd)|Gets or sets if the symmetry plane is offset from the block center|
|[YSymmetryPlane](VRage.Game.ModAPI.IMyCubeGrid@YSymmetryPlane)|Gets or sets Y-Axis build symmetry plane|
|[ZSymmetryOdd](VRage.Game.ModAPI.IMyCubeGrid@ZSymmetryOdd)|Gets or sets if the symmetry plane is offset from the block center|
|[ZSymmetryPlane](VRage.Game.ModAPI.IMyCubeGrid@ZSymmetryPlane)|Gets or sets Z-Axis build symmetry plane|
|[CastShadows](VRage.ModAPI.IMyEntity@CastShadows)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Closed](VRage.Game.ModAPI.Ingame.IMyEntity@Closed)|True if the block has been removed from the world.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Components](VRage.Game.ModAPI.Ingame.IMyEntity@Components)|Gets blocks component logic container<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[CustomName](VRage.Game.ModAPI.Ingame.IMyCubeGrid@CustomName)|Getter and setter for display name of the grid (as seen in Info terminal tab)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[DebugAsyncLoading](VRage.ModAPI.IMyEntity@DebugAsyncLoading)|Used for internal usage. Modders should not use it. Will be eventually removed<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DisplayName](VRage.Game.ModAPI.Ingame.IMyEntity@DisplayName)|Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisplayNameText)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[DisplayName](VRage.ModAPI.IMyEntity@DisplayName)|Gets or sets user friendly name of entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[EntityId](VRage.Game.ModAPI.Ingame.IMyEntity@EntityId)|Id of entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[EntityId](VRage.ModAPI.IMyEntity@EntityId)|Uniq id of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[FastCastShadowResolve](VRage.ModAPI.IMyEntity@FastCastShadowResolve)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Flags](VRage.ModAPI.IMyEntity@Flags)|Gets or set some behavior of entity. [EntityFlags](VRage.ModAPI.EntityFlags)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GameLogic](VRage.ModAPI.IMyEntity@GameLogic)|Gets or sets game logic for object. If there is more than 1 game logic attached it should be wrapped into.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GridSize](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GridSize)|Getter of grid size in meters<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[GridSizeEnum](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GridSizeEnum)|Getter for grid size enum<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[HasInventory](VRage.Game.ModAPI.Ingame.IMyEntity@HasInventory)|Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Hierarchy](VRage.ModAPI.IMyEntity@Hierarchy)|Gets or sets Hierarchy component<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InScene](VRage.ModAPI.IMyEntity@InScene)|Gets or set if grid is InScene. Objects that are not in scene are not updated and drawn.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InvalidateOnMove](VRage.ModAPI.IMyEntity@InvalidateOnMove)|Gets if entity is invalidated on move When visual look of entity depends on position - then InvalidateOnMove should be true<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InventoryCount](VRage.Game.ModAPI.Ingame.IMyEntity@InventoryCount)|Returns the count of the number of inventories this entity has.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[IsStatic](VRage.Game.ModAPI.Ingame.IMyCubeGrid@IsStatic)|Determines if the grid is static (unmoveable)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[IsVolumetric](VRage.ModAPI.IMyEntity@IsVolumetric)|Always returns false<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LinearVelocity](VRage.Game.ModAPI.Ingame.IMyCubeGrid@LinearVelocity)|Gets linear velocity of the grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB)|Gets or sets local axis aligned bounding box. Same as [LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr)|Gets local axis aligned bounding box. Same as [LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalMatrix](VRage.ModAPI.IMyEntity@LocalMatrix)|Gets or sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolume](VRage.ModAPI.IMyEntity@LocalVolume)|Gets or sets local volume. Same as [LocalVolume](VRage.Game.Components.MyPositionComponentBase@LocalVolume)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolumeOffset](VRage.ModAPI.IMyEntity@LocalVolumeOffset)|Gets or sets local volume offset. Same as [LocalVolumeOffset](VRage.Game.Components.MyPositionComponentBase@LocalVolumeOffset)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MarkedForClose](VRage.ModAPI.IMyEntity@MarkedForClose)|Checked if [Close()](VRage.ModAPI.IMyEntity@Close) was called<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Max](VRage.Game.ModAPI.Ingame.IMyCubeGrid@Max)|Maximum coordinates of blocks in grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[MaxGlassDistSq](VRage.ModAPI.IMyEntity@MaxGlassDistSq)|Not used in game anymore<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Min](VRage.Game.ModAPI.Ingame.IMyCubeGrid@Min)|Minimum coordinates of blocks in grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[Model](VRage.ModAPI.IMyEntity@Model)|Gets model of block<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ModelCollision](VRage.ModAPI.IMyEntity@ModelCollision)|Gets collision model of block<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Name](VRage.Game.ModAPI.Ingame.IMyEntity@Name)|Some entities can have uniq name, and game can find them by name [TryGetEntityByName(string, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityByName)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Name](VRage.ModAPI.IMyEntity@Name)|Uniq name of entity. Can be used to find entity by name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NearFlag](VRage.ModAPI.IMyEntity@NearFlag)|Gets or sets flag [Near](VRage.ModAPI.EntityFlags@Near)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsDraw](VRage.ModAPI.IMyEntity@NeedsDraw)|Gets or sets flag [NeedsDraw](VRage.ModAPI.EntityFlags@NeedsDraw)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsDrawFromParent](VRage.ModAPI.IMyEntity@NeedsDrawFromParent)|Gets or sets flag [NeedsDrawFromParent](VRage.ModAPI.EntityFlags@NeedsDrawFromParent)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsResolveCastShadow](VRage.ModAPI.IMyEntity@NeedsResolveCastShadow)|Gets or sets flag [NeedsResolveCastShadow](VRage.ModAPI.EntityFlags@NeedsResolveCastShadow)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsUpdate](VRage.ModAPI.IMyEntity@NeedsUpdate)|Gets or sets how often the entity should be updated.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsWorldMatrix](VRage.ModAPI.IMyEntity@NeedsWorldMatrix)|Gets or sets if [WorldMatrix](VRage.ModAPI.IMyEntity@WorldMatrix) should be calculated when parent WorldMatrix is changed.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Parent](VRage.ModAPI.IMyEntity@Parent)|Gets parent of entity or null, if this entity doesn't have parent. Ex: character sitting in cockpit, has parent - cockpit, cockpit has parent - cube grid, connected grids also has main grid, which would be parent for other grids.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[PersistentFlags](VRage.ModAPI.IMyEntity@PersistentFlags)|Gets or sets persistent flags that are used in rendering.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Physics](VRage.ModAPI.IMyEntity@Physics)|Gets or sets physics for object<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[PositionComp](VRage.ModAPI.IMyEntity@PositionComp)|Gets or sets position provider logic<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Render](VRage.ModAPI.IMyEntity@Render)|Gets or sets render logic<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Save](VRage.ModAPI.IMyEntity@Save)|Gets or sets [Save](VRage.ModAPI.EntityFlags@Save) . Entity won't be saved if [Save](VRage.ModAPI.IMyEntity@Save) is false<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ShadowBoxLod](VRage.ModAPI.IMyEntity@ShadowBoxLod)|Gets or sets flag [ShadowBoxLod](VRage.Game.Components.MyRenderComponentBase@ShadowBoxLod)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SkipIfTooSmall](VRage.ModAPI.IMyEntity@SkipIfTooSmall)|Gets or sets flag [SkipIfTooSmall](VRage.ModAPI.EntityFlags@SkipIfTooSmall)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Speed](VRage.Game.ModAPI.Ingame.IMyCubeGrid@Speed)|Gets speed of the grid calculated from Linear Velocity. Rounded to two decimal places.<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[StopPhysicsActivation](VRage.ModAPI.IMyEntity@StopPhysicsActivation)|_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Storage](VRage.ModAPI.IMyEntity@Storage)|Custom storage for mods. Shared with all mods.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Synchronized](VRage.ModAPI.IMyEntity@Synchronized)|Gets or sets if the entity should be synced.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SyncObject](VRage.ModAPI.IMyEntity@SyncObject)|Gets SyncObject used for synchronizing data over network with<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Transparent](VRage.ModAPI.IMyEntity@Transparent)|Gets or sets [Transparency](VRage.Game.Components.MyRenderComponentBase@Transparency) . When setting true entity would be 25% transparent<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Visible](VRage.ModAPI.IMyEntity@Visible)|Gets or sets flag [Visible](VRage.Game.Components.MyRenderComponentBase@Visible)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldAABB](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABB)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldAABBHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABBHr)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.Game.ModAPI.Ingame.IMyEntity@WorldMatrix)|Gets world matrix of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.ModAPI.IMyEntity@WorldMatrix)|Gets or sets world matrix.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldMatrixInvScaled](VRage.ModAPI.IMyEntity@WorldMatrixInvScaled)|Get scaled, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv) , but not normalized<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)|Get normalized, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldVolume](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolume)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldVolumeHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolumeHr)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[IsCCDForProjectiles](VRage.ModAPI.IMyEntity@IsCCDForProjectiles)|_**Obsolete**_<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocationForHudMarker](VRage.ModAPI.IMyEntity@LocationForHudMarker)|_**Obsolete**_<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

## Methods

|Member|Description|
|---|---|
|[AddBlock(MyObjectBuilder_CubeBlock, bool)](VRage.Game.ModAPI.IMyCubeGrid@AddBlock)|Add a cubeblock to the grid|
|[ApplyDeformation(float, float, float, Vector3, Vector3, MyStringHash, out int, float, float, long)](VRage.Game.ModAPI.IMyCubeGrid@ApplyDeformation)||
|[ApplyDestructionDeformation(IMySlimBlock)](VRage.Game.ModAPI.IMyCubeGrid@ApplyDestructionDeformation)|Applies random deformation to given block|
|[CalculateMergeTransform(IMyCubeGrid, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@CalculateMergeTransform)|Transformation matrix that has to be applied to grid blocks to correctly merge it used because ie. ships can be turned 90 degrees along X axis when being merged|
|[CanAddCube(Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@CanAddCube)|Tests if a cubeblock can be added at the specific location|
|[CanAddCubes(Vector3I, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@CanAddCubes)|Test if the range of positions are not occupied by any blocks|
|[CanMergeCubes(IMyCubeGrid, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@CanMergeCubes)|Determines if merge between grids is possible with given offset|
|[ChangeGridOwnership(long, MyOwnershipShareModeEnum)](VRage.Game.ModAPI.IMyCubeGrid@ChangeGridOwnership)|Changes owner of all blocks on grid Call only on server!|
|[ClearSymmetries()](VRage.Game.ModAPI.IMyCubeGrid@ClearSymmetries)|Clears symmetry planes|
|[ColorBlocks(Vector3I, Vector3I, Vector3)](VRage.Game.ModAPI.IMyCubeGrid@ColorBlocks)|Sets given color mask to range of blocks|
|[FixTargetCube(out Vector3I, Vector3)](VRage.Game.ModAPI.IMyCubeGrid@FixTargetCube)|Clamps fractional grid position to nearest cell (prefers neighboring occupied cell before empty)|
|[GetBlocks(List<IMySlimBlock>, Func<IMySlimBlock, bool>)](VRage.Game.ModAPI.IMyCubeGrid@GetBlocks)|Returns blocks in grid|
|[GetBlocksInsideSphere(ref BoundingSphereD)](VRage.Game.ModAPI.IMyCubeGrid@GetBlocksInsideSphere)|Returns blocks intersects with given sphere (world space)|
|[GetClosestCorner(Vector3I, Vector3)](VRage.Game.ModAPI.IMyCubeGrid@GetClosestCorner)|Gets position of closest cell corner|
|[GetCubeBlock(Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@GetCubeBlock)|Get cube block at given position|
|[GetFatBlocks<T>()](VRage.Game.ModAPI.IMyCubeGrid@GetFatBlocks{T})||
|[GetGridGroup(GridLinkTypeEnum)](VRage.Game.ModAPI.IMyCubeGrid@GetGridGroup)|Gets grid group of grids connected by provided link type|
|[GetLineIntersectionExactAll(ref LineD, out double, out IMySlimBlock)](VRage.Game.ModAPI.IMyCubeGrid@GetLineIntersectionExactAll)|Returns point of intersection with line|
|[GetLineIntersectionExactGrid(ref LineD, ref Vector3I, ref double)](VRage.Game.ModAPI.IMyCubeGrid@GetLineIntersectionExactGrid)|Same as GetLineIntersectionExactAll just without intersected block|
|[GetMaxThrustInDirection(Direction)](VRage.Game.ModAPI.IMyCubeGrid@GetMaxThrustInDirection)||
|[InvokeDepressurizeEffect(Vector3I, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@InvokeDepressurizeEffect)|Invokes de-pressurize effect on clients|
|[IsInSameLogicalGroupAs(IMyCubeGrid)](VRage.Game.ModAPI.IMyCubeGrid@IsInSameLogicalGroupAs)|Determines whether this grid is in the same logical group as the other, meaning they're connected either mechanically or via blocks like connectors. Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way.|
|[IsRoomAtPositionAirtight(Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@IsRoomAtPositionAirtight)|Is room at specified position airtight|
|[IsSameConstructAs(IMyCubeGrid)](VRage.Game.ModAPI.IMyCubeGrid@IsSameConstructAs)|Determines whether this grid is mechanically connected to the other. This is any grid connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.<br /><br />Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.|
|[IsTouchingAnyNeighbor(Vector3I, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@IsTouchingAnyNeighbor)|Finds out if given area has any neighboring block Checking only cube sides. Example: for vectors Min (0,0,0) and Max (10,10,10), Space (1,1,1)-(9,9,9) won't be checked|
|[MergeGrid_MergeBlock(IMyCubeGrid, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@MergeGrid_MergeBlock)|Merge used by merge blocks|
|[RayCastBlocks(Vector3D, Vector3D)](VRage.Game.ModAPI.IMyCubeGrid@RayCastBlocks)|Obtains first block position intersected with line.|
|[RayCastCells(Vector3D, Vector3D, List<Vector3I>, Vector3I?, bool)](VRage.Game.ModAPI.IMyCubeGrid@RayCastCells)|Obtains positions of grid cellsof whether these cells are taken up by blocks or not.|
|[RazeBlock(Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@RazeBlock)|Remove block at given position|
|[RazeBlocks(ref Vector3I, ref Vector3UByte)](VRage.Game.ModAPI.IMyCubeGrid@RazeBlocks)|Remove blocks in given area|
|[RazeBlocks(List<Vector3I>)](VRage.Game.ModAPI.IMyCubeGrid@RazeBlocks)|Remove blocks at given positions|
|[RemoveBlock(IMySlimBlock, bool)](VRage.Game.ModAPI.IMyCubeGrid@RemoveBlock)|Removes given block|
|[RemoveDestroyedBlock(IMySlimBlock)](VRage.Game.ModAPI.IMyCubeGrid@RemoveDestroyedBlock)|Removes block and deformates neighboring blocks|
|[SkinBlocks(Vector3I, Vector3I, Vector3?, string)](VRage.Game.ModAPI.IMyCubeGrid@SkinBlocks)|Sets given skin to range of blocks|
|[Split(List<IMySlimBlock>, bool)](VRage.Game.ModAPI.IMyCubeGrid@Split)|Split grid|
|[SplitByPlane(PlaneD)](VRage.Game.ModAPI.IMyCubeGrid@SplitByPlane)|Split grid along a plane|
|[UpdateBlockNeighbours(IMySlimBlock)](VRage.Game.ModAPI.IMyCubeGrid@UpdateBlockNeighbours)|Refreshes block neighbors (checks connections)|
|[UpdateOwnership(long, bool)](VRage.Game.ModAPI.IMyCubeGrid@UpdateOwnership)|Called when functional block lost or gained owner. Triggers, grid ownership recalculation|
|[WillRemoveBlockSplitGrid(IMySlimBlock)](VRage.Game.ModAPI.IMyCubeGrid@WillRemoveBlockSplitGrid)|Checks if removing a block will cause the grid to split|
|[BeforeSave()](VRage.ModAPI.IMyEntity@BeforeSave)|Called before method GetObjectBuilder, when saving sector<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Close()](VRage.ModAPI.IMyEntity@Close)|This method marks this entity for close which means, that Close will be called after all entities are updated<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[CubeExists(Vector3I)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@CubeExists)|Returns true if there is any block occupying given position<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[DebugDraw()](VRage.ModAPI.IMyEntity@DebugDraw)|Calls debug draw of entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DebugDrawInvalidTriangles()](VRage.ModAPI.IMyEntity@DebugDrawInvalidTriangles)|Calls special debug draw, that highlighting invalid triangles in model<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Delete()](VRage.ModAPI.IMyEntity@Delete)|Performs real cleaning of entity. Should be called by game. Modders should prefer [Close()](VRage.ModAPI.IMyEntity@Close) method.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DoOverlapSphereTest(float, Vector3D)](VRage.ModAPI.IMyEntity@DoOverlapSphereTest)|Checks if intersects Works only with [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[EnableColorMaskForSubparts(bool)](VRage.ModAPI.IMyEntity@EnableColorMaskForSubparts)|Allows subparts have different color than their parent<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetChildren(List<IMyEntity>, Func<IMyEntity, bool>)](VRage.ModAPI.IMyEntity@GetChildren)|Gets children of entity. Child - entity, who's [Parent](VRage.ModAPI.IMyEntity@Parent) is this entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetCubeBlock(Vector3I)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GetCubeBlock)|Get cube block at given position<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[GetDiffuseColor()](VRage.ModAPI.IMyEntity@GetDiffuseColor)|Gets render diffuse color<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndBoundingSphere)|Distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. (in meters)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndPosition()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndPosition)|Distance from camera to position of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetFriendlyName()](VRage.ModAPI.IMyEntity@GetFriendlyName)|Not used. Actually not a friendly name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithAABB(ref BoundingBoxD)](VRage.ModAPI.IMyEntity@GetIntersectionWithAABB)|Return true if object intersects specified bounding box.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithLine(ref LineD, out MyIntersectionResultLineTriangleEx?, IntersectionFlags)](VRage.ModAPI.IMyEntity@GetIntersectionWithLine)|Get intersection of model with provided line<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithLineAndBoundingSphere(ref LineD, float)](VRage.ModAPI.IMyEntity@GetIntersectionWithLineAndBoundingSphere)|Calculates intersection of line with any bounding sphere in this model instance. Center of the bounding sphere will be returned. It takes boundingSphereRadiusMultiplier argument which serves for extending the influence (radius) for interaction with line.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntity@GetIntersectionWithSphere)|Return true if object intersects specified sphere.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetInventory()](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetInventory(int)](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Search for inventory component with maching index.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetInventory()](VRage.ModAPI.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetInventory(int)](VRage.ModAPI.IMyEntity@GetInventory)|Search for inventory component with matching index.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetLargestDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetLargestDistanceBetweenCameraAndBoundingSphere)|Largest distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. It's actually distance between camera and opposite side of the sphere<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetObjectBuilder(bool)](VRage.ModAPI.IMyEntity@GetObjectBuilder)|Returns object builder - object representing block state, and allows restore it. Used in game save, or syncing over network.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetPosition()](VRage.Game.ModAPI.Ingame.IMyEntity@GetPosition)|Gets position in world coordinates<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetSmallestDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetSmallestDistanceBetweenCameraAndBoundingSphere)|Smallest distance between camera and bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetSubpart(string)](VRage.ModAPI.IMyEntity@GetSubpart)|Gets subpart by subpart name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetTopMostParent(Type)](VRage.ModAPI.IMyEntity@GetTopMostParent)|Gets top most [Parent](VRage.ModAPI.IMyEntity@Parent) of specified type. Top most is entity that doesn't have parent (of specified type)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetTrianglesIntersectingSphere(ref BoundingSphere, Vector3?, float?, List<MyTriangle_Vertex_Normals>, int)](VRage.ModAPI.IMyEntity@GetTrianglesIntersectingSphere)|Return list of triangles intersecting specified sphere. Angle between every triangleVertexes normal vector and 'referenceNormalVector' is calculated, and if more than 'maxAngle', we ignore such triangleVertexes. Triangles are returned in 'retTriangles', and this list must be preallocated! IMPORTANT: Sphere must be in model space, so don't transform it!<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix)|Get normalized, inverted world matrix. Same as [GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv)|Get normalized, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GridIntegerToWorld(Vector3I)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GridIntegerToWorld)|Converts grid coordinates to world space<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[IsSameConstructAs(IMyCubeGrid)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@IsSameConstructAs)|Determines whether this grid is [Mechanical](VRage.Game.ModAPI.GridLinkTypeEnum@Mechanical) connected to the other. This is any grid connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.<br /><br />Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[IsVisible()](VRage.ModAPI.IMyEntity@IsVisible)|Gets or result of function [IsVisible()](VRage.Game.Components.MyRenderComponentBase@IsVisible) . Function inside check for [IsVisible(IMyEntity)](VRage.ModAPI.IMyEntities@IsVisible)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnAddedToScene(object)](VRage.ModAPI.IMyEntity@OnAddedToScene)|Adds entity to scene: init updates, render physics<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnRemovedFromScene(object)](VRage.ModAPI.IMyEntity@OnRemovedFromScene)|Remove entity and it's children from scene: stops updates and render, deactivates physics. Usually called when entity deleted<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetColorMaskForSubparts(Vector3)](VRage.ModAPI.IMyEntity@SetColorMaskForSubparts)|Sets subparts custom col<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetEmissiveParts(string, Color, float)](VRage.ModAPI.IMyEntity@SetEmissiveParts)|Sets the emissive value of a specific emissive material on entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetEmissivePartsForSubparts(string, Color, float)](VRage.ModAPI.IMyEntity@SetEmissivePartsForSubparts)|Sets the emissive value of a specific emissive material on all entity subparts.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetLocalMatrix(Matrix, object)](VRage.ModAPI.IMyEntity@SetLocalMatrix)|Sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetPosition(Vector3D)](VRage.ModAPI.IMyEntity@SetPosition)|Set WorldMatrix's [Translation](VRageMath.MatrixD@Translation) . Moves entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|Sets subparts custom skinning. Copy values from [TextureChanges](VRage.Game.Components.MyRenderComponentBase@TextureChanges) , then change needed keys. You can retrieve values for exact skin with following code:```csharp<br />MyDefinitionManager.Static.GetAssetModifierDefinitionForRender(skinId);<br /><br />```<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetWorldMatrix(MatrixD, object)](VRage.ModAPI.IMyEntity@SetWorldMatrix)|Sets world matrix of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Teleport(MatrixD, object, bool)](VRage.ModAPI.IMyEntity@Teleport)|When moving entity over large distances or when entity has children, using this method preferred over [SetPosition(Vector3D)](VRage.ModAPI.IMyEntity@SetPosition)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[TryGetSubpart(string, out MyEntitySubpart)](VRage.ModAPI.IMyEntity@TryGetSubpart)|Gets subpart by subpart name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[UpdateGamePruningStructure()](VRage.ModAPI.IMyEntity@UpdateGamePruningStructure)|Update position of entity in MyGamePruningStructure. Calls:```csharp<br />MyGamePruningStructure.Move(this)<br /><br />```<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldToGridInteger(Vector3D)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@WorldToGridInteger)|Converts world coordinates to grid space cell coordinates<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[OnConvertToDynamic()](VRage.Game.ModAPI.IMyCubeGrid@OnConvertToDynamic)|_**Obsolete:** Use IMyCubeGrid.Static instead._<br /><br />Converts station to ship|
|[AddToGamePruningStructure()](VRage.ModAPI.IMyEntity@AddToGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[RemoveFromGamePruningStructure()](VRage.ModAPI.IMyEntity@RemoveFromGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetTextureChangesForSubparts(Dictionary<string, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|_**Obsolete**_<br /><br />This calling is obsolete, use another version.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

**Implements:**  
* [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)  
* [IMyEntity](VRage.ModAPI.IMyEntity)  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)

**Inheritors:**  
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid)

