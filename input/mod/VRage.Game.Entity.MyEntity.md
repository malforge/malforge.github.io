**Assembly:** VRage.Game.dll

```csharp
public class MyEntity: IMyEntity, IMyEntity
```

Implements entity features for ModAPI interface

## Fields

|Member|Description|
|---|---|
|[static AddToGamePruningStructureExtCallBack](VRage.Game.Entity.MyEntity@AddToGamePruningStructureExtCallBack)||
|[static CreateDefaultSyncEntityExtCallback](VRage.Game.Entity.MyEntity@CreateDefaultSyncEntityExtCallback)||
|[static CreateStandardRenderComponentsExtCallback](VRage.Game.Entity.MyEntity@CreateStandardRenderComponentsExtCallback)||
|[static InitComponentsExtCallback](VRage.Game.Entity.MyEntity@InitComponentsExtCallback)||
|[static MyEntitiesCreateFromObjectBuilderExtCallback](VRage.Game.Entity.MyEntity@MyEntitiesCreateFromObjectBuilderExtCallback)||
|[static MyEntityFactoryCreateObjectBuilderExtCallback](VRage.Game.Entity.MyEntity@MyEntityFactoryCreateObjectBuilderExtCallback)||
|[static MyProceduralWorldGeneratorTrackEntityExtCallback](VRage.Game.Entity.MyEntity@MyProceduralWorldGeneratorTrackEntityExtCallback)||
|[static MyWeldingGroupsAddNodeExtCallback](VRage.Game.Entity.MyEntity@MyWeldingGroupsAddNodeExtCallback)||
|[static MyWeldingGroupsGetGroupNodesExtCallback](VRage.Game.Entity.MyEntity@MyWeldingGroupsGetGroupNodesExtCallback)||
|[static MyWeldingGroupsGroupExistsExtCallback](VRage.Game.Entity.MyEntity@MyWeldingGroupsGroupExistsExtCallback)||
|[static MyWeldingGroupsRemoveNodeExtCallback](VRage.Game.Entity.MyEntity@MyWeldingGroupsRemoveNodeExtCallback)||
|[static RemoveFromGamePruningStructureExtCallBack](VRage.Game.Entity.MyEntity@RemoveFromGamePruningStructureExtCallBack)||
|[static UpdateGamePruningStructureExtCallBack](VRage.Game.Entity.MyEntity@UpdateGamePruningStructureExtCallBack)||
|[DebugAsyncLoading](VRage.Game.Entity.MyEntity@DebugAsyncLoading)||
|[DefinitionId](VRage.Game.Entity.MyEntity@DefinitionId)||
|[GamePruningProxyId](VRage.Game.Entity.MyEntity@GamePruningProxyId)||
|[InstantiateSubpartOverrideFunc](VRage.Game.Entity.MyEntity@InstantiateSubpartOverrideFunc)||
|[IsPreviewChanged](VRage.Game.Entity.MyEntity@IsPreviewChanged)||
|[m_positionResetFromServer](VRage.Game.Entity.MyEntity@m_positionResetFromServer)||
|[OnEntityCloseRequest](VRage.Game.Entity.MyEntity@OnEntityCloseRequest)||
|[PropagateSubpartRotationThroughHieerarchy](VRage.Game.Entity.MyEntity@PropagateSubpartRotationThroughHieerarchy)||
|[ReadyForReplicationAction](VRage.Game.Entity.MyEntity@ReadyForReplicationAction)||
|[ReplicationEnded](VRage.Game.Entity.MyEntity@ReplicationEnded)||
|[ReplicationStarted](VRage.Game.Entity.MyEntity@ReplicationStarted)||
|[StaticForPruningStructure](VRage.Game.Entity.MyEntity@StaticForPruningStructure)||
|[TargetPruningProxyId](VRage.Game.Entity.MyEntity@TargetPruningProxyId)||
|[TopMostPruningProxyId](VRage.Game.Entity.MyEntity@TopMostPruningProxyId)||

## Events

|Member|Description|
|---|---|
|[AddedToScene](VRage.Game.Entity.MyEntity@AddedToScene)||
|[OnClose](VRage.Game.Entity.MyEntity@OnClose)||
|[OnClosing](VRage.Game.Entity.MyEntity@OnClosing)||
|[OnDebugDraw](VRage.Game.Entity.MyEntity@OnDebugDraw)||
|[OnMarkForClose](VRage.Game.Entity.MyEntity@OnMarkForClose)|This event may not be invoked at all, when calling MyEntities.CloseAll, marking is bypassed|
|[OnModelRefresh](VRage.Game.Entity.MyEntity@OnModelRefresh)||
|[OnPhysicsChanged](VRage.Game.Entity.MyEntity@OnPhysicsChanged)||
|[OnPhysicsComponentChanged](VRage.Game.Entity.MyEntity@OnPhysicsComponentChanged)||
|[OnTeleported](VRage.Game.Entity.MyEntity@OnTeleported)||
|[OnUpdateOnceBeforeNextFrame](VRage.Game.Entity.MyEntity@OnUpdateOnceBeforeNextFrame)||
|[RemovedFromScene](VRage.Game.Entity.MyEntity@RemovedFromScene)||
|[OnClose](VRage.ModAPI.IMyEntity@OnClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnClosing](VRage.ModAPI.IMyEntity@OnClosing)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnPhysicsChanged](VRage.ModAPI.IMyEntity@OnPhysicsChanged)|Called when havok rigid body physics are changed: inited, closed, modified.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

## Properties

|Member|Description|
|---|---|
|[Closed](VRage.Game.Entity.MyEntity@Closed)||
|[Components](VRage.Game.Entity.MyEntity@Components)||
|[DebugName](VRage.Game.Entity.MyEntity@DebugName)||
|[DisplayName](VRage.Game.Entity.MyEntity@DisplayName)||
|[DisplayNameText](VRage.Game.Entity.MyEntity@DisplayNameText)|Display Name for GUI etc. Override in descendant classes. Usually used to display in terminal or inventory controls.|
|[EntityId](VRage.Game.Entity.MyEntity@EntityId)|Entity id, can be set by subclasses (for example when using pool...)|
|[EntityStorage](VRage.Game.Entity.MyEntity@EntityStorage)||
|[Flags](VRage.Game.Entity.MyEntity@Flags)||
|[GameLogic](VRage.Game.Entity.MyEntity@GameLogic)||
|[HasInventory](VRage.Game.Entity.MyEntity@HasInventory)|Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventoryBase() != null.|
|[Hierarchy](VRage.Game.Entity.MyEntity@Hierarchy)||
|[InScene](VRage.Game.Entity.MyEntity@InScene)||
|[InvalidateOnMove](VRage.Game.Entity.MyEntity@InvalidateOnMove)||
|[InventoryCount](VRage.Game.Entity.MyEntity@InventoryCount)|Iterate through inventories and return their count.|
|[IsCCDForProjectiles](VRage.Game.Entity.MyEntity@IsCCDForProjectiles)||
|[IsPreview](VRage.Game.Entity.MyEntity@IsPreview)||
|[IsReadyForReplication](VRage.Game.Entity.MyEntity@IsReadyForReplication)||
|[IsReplicated](VRage.Game.Entity.MyEntity@IsReplicated)||
|[IsTransparentForJumpDrive](VRage.Game.Entity.MyEntity@IsTransparentForJumpDrive)||
|[IsVolumetric](VRage.Game.Entity.MyEntity@IsVolumetric)||
|[LastSnapshotFlags](VRage.Game.Entity.MyEntity@LastSnapshotFlags)||
|[LocationForHudMarker](VRage.Game.Entity.MyEntity@LocationForHudMarker)||
|[MarkedForClose](VRage.Game.Entity.MyEntity@MarkedForClose)||
|[MaxGlassDistSq](VRage.Game.Entity.MyEntity@MaxGlassDistSq)||
|[Model](VRage.Game.Entity.MyEntity@Model)||
|[ModelCollision](VRage.Game.Entity.MyEntity@ModelCollision)||
|[Name](VRage.Game.Entity.MyEntity@Name)||
|[NeedsUpdate](VRage.Game.Entity.MyEntity@NeedsUpdate)||
|[NeedsWorldMatrix](VRage.Game.Entity.MyEntity@NeedsWorldMatrix)||
|[Parent](VRage.Game.Entity.MyEntity@Parent)|Gets or sets the parent.|
|[Physics](VRage.Game.Entity.MyEntity@Physics)||
|[Pinned](VRage.Game.Entity.MyEntity@Pinned)||
|[PositionComp](VRage.Game.Entity.MyEntity@PositionComp)||
|[Render](VRage.Game.Entity.MyEntity@Render)||
|[Save](VRage.Game.Entity.MyEntity@Save)||
|[StopPhysicsActivation](VRage.Game.Entity.MyEntity@StopPhysicsActivation)||
|[Storage](VRage.Game.Entity.MyEntity@Storage)||
|[Subparts](VRage.Game.Entity.MyEntity@Subparts)||
|[SyncFlag](VRage.Game.Entity.MyEntity@SyncFlag)||
|[SyncObject](VRage.Game.Entity.MyEntity@SyncObject)||
|[UpdateDuration](VRage.Game.Entity.MyEntity@UpdateDuration)||
|[WorldMatrix](VRage.Game.Entity.MyEntity@WorldMatrix)||
|[CastShadows](VRage.ModAPI.IMyEntity@CastShadows)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Closed](VRage.Game.ModAPI.Ingame.IMyEntity@Closed)|True if the block has been removed from the world.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Components](VRage.Game.ModAPI.Ingame.IMyEntity@Components)|Gets blocks component logic container<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[DebugAsyncLoading](VRage.ModAPI.IMyEntity@DebugAsyncLoading)|Used for internal usage. Modders should not use it. Will be eventually removed<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DisplayName](VRage.Game.ModAPI.Ingame.IMyEntity@DisplayName)|Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisplayNameText)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[DisplayName](VRage.ModAPI.IMyEntity@DisplayName)|Gets or sets user friendly name of entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[EntityId](VRage.Game.ModAPI.Ingame.IMyEntity@EntityId)|Id of entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[EntityId](VRage.ModAPI.IMyEntity@EntityId)|Uniq id of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[FastCastShadowResolve](VRage.ModAPI.IMyEntity@FastCastShadowResolve)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Flags](VRage.ModAPI.IMyEntity@Flags)|Gets or set some behavior of entity. [EntityFlags](VRage.ModAPI.EntityFlags)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GameLogic](VRage.ModAPI.IMyEntity@GameLogic)|Gets or sets game logic for object. If there is more than 1 game logic attached it should be wrapped into.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[HasInventory](VRage.Game.ModAPI.Ingame.IMyEntity@HasInventory)|Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Hierarchy](VRage.ModAPI.IMyEntity@Hierarchy)|Gets or sets Hierarchy component<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InScene](VRage.ModAPI.IMyEntity@InScene)|Gets or set if grid is InScene. Objects that are not in scene are not updated and drawn.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InvalidateOnMove](VRage.ModAPI.IMyEntity@InvalidateOnMove)|Gets if entity is invalidated on move When visual look of entity depends on position - then InvalidateOnMove should be true<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InventoryCount](VRage.Game.ModAPI.Ingame.IMyEntity@InventoryCount)|Returns the count of the number of inventories this entity has.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[IsVolumetric](VRage.ModAPI.IMyEntity@IsVolumetric)|Always returns false<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB)|Gets or sets local axis aligned bounding box. Same as [LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr)|Gets local axis aligned bounding box. Same as [LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalMatrix](VRage.ModAPI.IMyEntity@LocalMatrix)|Gets or sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolume](VRage.ModAPI.IMyEntity@LocalVolume)|Gets or sets local volume. Same as [LocalVolume](VRage.Game.Components.MyPositionComponentBase@LocalVolume)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolumeOffset](VRage.ModAPI.IMyEntity@LocalVolumeOffset)|Gets or sets local volume offset. Same as [LocalVolumeOffset](VRage.Game.Components.MyPositionComponentBase@LocalVolumeOffset)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MarkedForClose](VRage.ModAPI.IMyEntity@MarkedForClose)|Checked if [Close()](VRage.ModAPI.IMyEntity@Close) was called<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MaxGlassDistSq](VRage.ModAPI.IMyEntity@MaxGlassDistSq)|Not used in game anymore<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
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

## Constructors

|Member|Description|
|---|---|
|[MyEntity()](VRage.Game.Entity.MyEntity@.ctor)||
|[MyEntity(bool)](VRage.Game.Entity.MyEntity@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static GetCubeBlockParent(MyEntity)](VRage.Game.Entity.MyEntity@GetCubeBlockParent)||
|[AddDebugRenderComponent(MyDebugRenderComponentBase)](VRage.Game.Entity.MyEntity@AddDebugRenderComponent)||
|[AddToGamePruningStructure()](VRage.Game.Entity.MyEntity@AddToGamePruningStructure)||
|[AfterPaste()](VRage.Game.Entity.MyEntity@AfterPaste)||
|[ApplyLastControls()](VRage.Game.Entity.MyEntity@ApplyLastControls)||
|[BeforePaste()](VRage.Game.Entity.MyEntity@BeforePaste)||
|[BeforeSave()](VRage.Game.Entity.MyEntity@BeforeSave)|Called before method GetObjectBuilder, when saving sector|
|[ClearDebugRenderComponents()](VRage.Game.Entity.MyEntity@ClearDebugRenderComponents)||
|[Close()](VRage.Game.Entity.MyEntity@Close)|This method marks this entity for close which means, that Close will be called after all entities are updated|
|[ContainsDebugRenderComponent(Type)](VRage.Game.Entity.MyEntity@ContainsDebugRenderComponent)||
|[CreateSync()](VRage.Game.Entity.MyEntity@CreateSync)||
|[DebugDraw()](VRage.Game.Entity.MyEntity@DebugDraw)||
|[DebugDrawInvalidTriangles()](VRage.Game.Entity.MyEntity@DebugDrawInvalidTriangles)||
|[DebugDrawPhysics()](VRage.Game.Entity.MyEntity@DebugDrawPhysics)|Draw physical representation of entity|
|[Delete()](VRage.Game.Entity.MyEntity@Delete)|Every object must have this method, but not every phys object must necessarily have something to cleanup|
|[DeserializeControls(BitStream, bool)](VRage.Game.Entity.MyEntity@DeserializeControls)||
|[DoOverlapSphereTest(float, Vector3D)](VRage.Game.Entity.MyEntity@DoOverlapSphereTest)||
|[GetBaseEntity()](VRage.Game.Entity.MyEntity@GetBaseEntity)||
|[GetDistanceBetweenCameraAndBoundingSphere()](VRage.Game.Entity.MyEntity@GetDistanceBetweenCameraAndBoundingSphere)||
|[GetDistanceBetweenCameraAndPosition()](VRage.Game.Entity.MyEntity@GetDistanceBetweenCameraAndPosition)||
|[GetDistanceBetweenPlayerPositionAndBoundingSphere()](VRage.Game.Entity.MyEntity@GetDistanceBetweenPlayerPositionAndBoundingSphere)||
|[GetFriendlyName()](VRage.Game.Entity.MyEntity@GetFriendlyName)||
|[GetHudParams(bool)](VRage.Game.Entity.MyEntity@GetHudParams)||
|[GetIntersectionWithAABB(ref BoundingBoxD)](VRage.Game.Entity.MyEntity@GetIntersectionWithAABB)||
|[GetIntersectionWithLine(ref LineD, out Vector3D?, bool, IntersectionFlags)](VRage.Game.Entity.MyEntity@GetIntersectionWithLine)||
|[GetIntersectionWithLine(ref LineD, out MyIntersectionResultLineTriangleEx?, IntersectionFlags)](VRage.Game.Entity.MyEntity@GetIntersectionWithLine)||
|[GetIntersectionWithLineAndBoundingSphere(ref LineD, float)](VRage.Game.Entity.MyEntity@GetIntersectionWithLineAndBoundingSphere)||
|[GetIntersectionWithSphere(ref BoundingSphereD)](VRage.Game.Entity.MyEntity@GetIntersectionWithSphere)||
|[GetInventoryBase(int)](VRage.Game.Entity.MyEntity@GetInventoryBase)|Search for inventory component with maching index.|
|[GetInventoryBase()](VRage.Game.Entity.MyEntity@GetInventoryBase)|Simply get the MyInventoryBase component stored in this entity.|
|[GetLargestDistanceBetweenCameraAndBoundingSphere()](VRage.Game.Entity.MyEntity@GetLargestDistanceBetweenCameraAndBoundingSphere)||
|[GetObjectBuilder(bool)](VRage.Game.Entity.MyEntity@GetObjectBuilder)|Gets object builder from object.|
|[GetSmallestDistanceBetweenCameraAndBoundingSphere()](VRage.Game.Entity.MyEntity@GetSmallestDistanceBetweenCameraAndBoundingSphere)||
|[GetSubpart(string)](VRage.Game.Entity.MyEntity@GetSubpart)||
|[GetTopMostParent(Type)](VRage.Game.Entity.MyEntity@GetTopMostParent)|Return top most parent of this entity|
|[GetTrianglesIntersectingSphere(ref BoundingSphere, Vector3?, float?, List<MyTriangle_Vertex_Normals>, int)](VRage.Game.Entity.MyEntity@GetTrianglesIntersectingSphere)||
|[GetViewMatrix()](VRage.Game.Entity.MyEntity@GetViewMatrix)||
|[Init(MyObjectBuilder_EntityBase)](VRage.Game.Entity.MyEntity@Init)||
|[Init(StringBuilder, string, MyEntity, float?, string)](VRage.Game.Entity.MyEntity@Init)||
|[InitComponents()](VRage.Game.Entity.MyEntity@InitComponents)||
|[InitComponentsForTesting()](VRage.Game.Entity.MyEntity@InitComponentsForTesting)||
|[OnAddedToScene(object)](VRage.Game.Entity.MyEntity@OnAddedToScene)|Called when [activated] which for entity means that was added to scene.|
|[OnRemovedFromScene(object)](VRage.Game.Entity.MyEntity@OnRemovedFromScene)||
|[OnReplicationEnded()](VRage.Game.Entity.MyEntity@OnReplicationEnded)||
|[OnReplicationStarted()](VRage.Game.Entity.MyEntity@OnReplicationStarted)||
|[Pin()](VRage.Game.Entity.MyEntity@Pin)||
|[PrepareForDraw()](VRage.Game.Entity.MyEntity@PrepareForDraw)|Method is called defacto from Update, preparation fo Draw|
|[RaisePhysicsChanged()](VRage.Game.Entity.MyEntity@RaisePhysicsChanged)||
|[RefreshModels(string, string)](VRage.Game.Entity.MyEntity@RefreshModels)||
|[RemoveDebugRenderComponent(Type)](VRage.Game.Entity.MyEntity@RemoveDebugRenderComponent)||
|[RemoveDebugRenderComponent(MyDebugRenderComponentBase)](VRage.Game.Entity.MyEntity@RemoveDebugRenderComponent)||
|[RemoveFromGamePruningStructure()](VRage.Game.Entity.MyEntity@RemoveFromGamePruningStructure)||
|[ResetControls()](VRage.Game.Entity.MyEntity@ResetControls)||
|[SerializeControls(BitStream)](VRage.Game.Entity.MyEntity@SerializeControls)||
|[SetEmissiveParts(string, Color, float)](VRage.Game.Entity.MyEntity@SetEmissiveParts)||
|[SetEmissivePartsForSubparts(string, Color, float)](VRage.Game.Entity.MyEntity@SetEmissivePartsForSubparts)||
|[SetFadeOut(bool)](VRage.Game.Entity.MyEntity@SetFadeOut)||
|[Simulate()](VRage.Game.Entity.MyEntity@Simulate)||
|[Teleport(MatrixD, object, bool)](VRage.Game.Entity.MyEntity@Teleport)||
|[ToString()](VRage.Game.Entity.MyEntity@ToString)||
|[TryGetDebugRenderComponent<T>(out T)](VRage.Game.Entity.MyEntity@TryGetDebugRenderComponent{T})||
|[TryGetSubpart(string, out MyEntitySubpart)](VRage.Game.Entity.MyEntity@TryGetSubpart)||
|[Unpin()](VRage.Game.Entity.MyEntity@Unpin)||
|[UpdateAfterSimulation()](VRage.Game.Entity.MyEntity@UpdateAfterSimulation)||
|[UpdateAfterSimulation10()](VRage.Game.Entity.MyEntity@UpdateAfterSimulation10)||
|[UpdateAfterSimulation100()](VRage.Game.Entity.MyEntity@UpdateAfterSimulation100)||
|[UpdateBeforeSimulation()](VRage.Game.Entity.MyEntity@UpdateBeforeSimulation)||
|[UpdateBeforeSimulation10()](VRage.Game.Entity.MyEntity@UpdateBeforeSimulation10)|Called each 10th frame if registered for update10|
|[UpdateBeforeSimulation100()](VRage.Game.Entity.MyEntity@UpdateBeforeSimulation100)|Called each 100th frame if registered for update100|
|[UpdateGamePruningStructure()](VRage.Game.Entity.MyEntity@UpdateGamePruningStructure)||
|[UpdateOnceBeforeFrame()](VRage.Game.Entity.MyEntity@UpdateOnceBeforeFrame)||
|[UpdateSoundContactPoint(long, Vector3, Vector3, Vector3, float)](VRage.Game.Entity.MyEntity@UpdateSoundContactPoint)||
|[UpdatingStopped()](VRage.Game.Entity.MyEntity@UpdatingStopped)||
|[BeforeSave()](VRage.ModAPI.IMyEntity@BeforeSave)|Called before method GetObjectBuilder, when saving sector<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Close()](VRage.ModAPI.IMyEntity@Close)|This method marks this entity for close which means, that Close will be called after all entities are updated<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DebugDraw()](VRage.ModAPI.IMyEntity@DebugDraw)|Calls debug draw of entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DebugDrawInvalidTriangles()](VRage.ModAPI.IMyEntity@DebugDrawInvalidTriangles)|Calls special debug draw, that highlighting invalid triangles in model<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Delete()](VRage.ModAPI.IMyEntity@Delete)|Performs real cleaning of entity. Should be called by game. Modders should prefer [Close()](VRage.ModAPI.IMyEntity@Close) method.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DoOverlapSphereTest(float, Vector3D)](VRage.ModAPI.IMyEntity@DoOverlapSphereTest)|Checks if intersects Works only with [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[EnableColorMaskForSubparts(bool)](VRage.ModAPI.IMyEntity@EnableColorMaskForSubparts)|Allows subparts have different color than their parent<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetChildren(List<IMyEntity>, Func<IMyEntity, bool>)](VRage.ModAPI.IMyEntity@GetChildren)|Gets children of entity. Child - entity, who's [Parent](VRage.ModAPI.IMyEntity@Parent) is this entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
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
|[AddToGamePruningStructure()](VRage.ModAPI.IMyEntity@AddToGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[RemoveFromGamePruningStructure()](VRage.ModAPI.IMyEntity@RemoveFromGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetTextureChangesForSubparts(Dictionary<string, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|_**Obsolete**_<br /><br />This calling is obsolete, use another version.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

**Implements:**  
* [IMyEntity](VRage.ModAPI.IMyEntity)  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)

**Inheritors:**  
* [MyAmmoBase](Sandbox.Game.Weapons.MyAmmoBase)  
* [MyCargoContainerInventoryBagEntity](Sandbox.Game.Entities.MyCargoContainerInventoryBagEntity)  
* [MyCubeBlock](Sandbox.Game.Entities.MyCubeBlock)  
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid)  
* [MyEntitySubpart](VRage.Game.Entity.MyEntitySubpart)  
* [MyEnvironmentSector](Sandbox.Game.WorldEnvironment.MyEnvironmentSector)  
* [MyFloatingObject](Sandbox.Game.Entities.MyFloatingObject)  
* [MyForageableEntity](Sandbox.Game.Entities.MyForageableEntity)  
* [MyHandToolBase](Sandbox.Game.Entities.MyHandToolBase)  
* [MyInventoryBagEntity](Sandbox.Game.Entities.MyInventoryBagEntity)  
* [MyMeteor](Sandbox.Game.Entities.MyMeteor)  
* [MyModifiableEntity](Sandbox.Game.Entities.MyModifiableEntity)  
* [MySafeZone](Sandbox.Game.Entities.MySafeZone)  
* [MySkinnedEntity](Sandbox.Game.Entities.MySkinnedEntity)  
* [MyVoxelBase](Sandbox.Game.Entities.MyVoxelBase)  
* [MyWaypoint](Sandbox.Game.Entities.MyWaypoint)

