**Assembly:** Sandbox.Game.dll

```csharp
public class MyWaypoint: MyEntity, IMyEntity, IMyEntity, IMyEventProxy, IMyEventOwner
```

## Fields

|Member|Description|
|---|---|
|[static AddToGamePruningStructureExtCallBack](VRage.Game.Entity.MyEntity@AddToGamePruningStructureExtCallBack)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static CreateDefaultSyncEntityExtCallback](VRage.Game.Entity.MyEntity@CreateDefaultSyncEntityExtCallback)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static CreateStandardRenderComponentsExtCallback](VRage.Game.Entity.MyEntity@CreateStandardRenderComponentsExtCallback)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static InitComponentsExtCallback](VRage.Game.Entity.MyEntity@InitComponentsExtCallback)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static MyEntitiesCreateFromObjectBuilderExtCallback](VRage.Game.Entity.MyEntity@MyEntitiesCreateFromObjectBuilderExtCallback)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static MyEntityFactoryCreateObjectBuilderExtCallback](VRage.Game.Entity.MyEntity@MyEntityFactoryCreateObjectBuilderExtCallback)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static MyProceduralWorldGeneratorTrackEntityExtCallback](VRage.Game.Entity.MyEntity@MyProceduralWorldGeneratorTrackEntityExtCallback)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static MyWeldingGroupsAddNodeExtCallback](VRage.Game.Entity.MyEntity@MyWeldingGroupsAddNodeExtCallback)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static MyWeldingGroupsGetGroupNodesExtCallback](VRage.Game.Entity.MyEntity@MyWeldingGroupsGetGroupNodesExtCallback)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static MyWeldingGroupsGroupExistsExtCallback](VRage.Game.Entity.MyEntity@MyWeldingGroupsGroupExistsExtCallback)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static MyWeldingGroupsRemoveNodeExtCallback](VRage.Game.Entity.MyEntity@MyWeldingGroupsRemoveNodeExtCallback)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static RemoveFromGamePruningStructureExtCallBack](VRage.Game.Entity.MyEntity@RemoveFromGamePruningStructureExtCallBack)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[static UpdateGamePruningStructureExtCallBack](VRage.Game.Entity.MyEntity@UpdateGamePruningStructureExtCallBack)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[DebugAsyncLoading](VRage.Game.Entity.MyEntity@DebugAsyncLoading)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[DefinitionId](VRage.Game.Entity.MyEntity@DefinitionId)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GamePruningProxyId](VRage.Game.Entity.MyEntity@GamePruningProxyId)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[InstantiateSubpartOverrideFunc](VRage.Game.Entity.MyEntity@InstantiateSubpartOverrideFunc)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsPreviewChanged](VRage.Game.Entity.MyEntity@IsPreviewChanged)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[m_positionResetFromServer](VRage.Game.Entity.MyEntity@m_positionResetFromServer)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnEntityCloseRequest](VRage.Game.Entity.MyEntity@OnEntityCloseRequest)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[PropagateSubpartRotationThroughHieerarchy](VRage.Game.Entity.MyEntity@PropagateSubpartRotationThroughHieerarchy)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ReadyForReplicationAction](VRage.Game.Entity.MyEntity@ReadyForReplicationAction)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ReplicationEnded](VRage.Game.Entity.MyEntity@ReplicationEnded)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ReplicationStarted](VRage.Game.Entity.MyEntity@ReplicationStarted)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[StaticForPruningStructure](VRage.Game.Entity.MyEntity@StaticForPruningStructure)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[TargetPruningProxyId](VRage.Game.Entity.MyEntity@TargetPruningProxyId)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[TopMostPruningProxyId](VRage.Game.Entity.MyEntity@TopMostPruningProxyId)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|

## Events

|Member|Description|
|---|---|
|[AddedToScene](VRage.Game.Entity.MyEntity@AddedToScene)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnClose](VRage.ModAPI.IMyEntity@OnClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnClose](VRage.Game.Entity.MyEntity@OnClose)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnClosing](VRage.ModAPI.IMyEntity@OnClosing)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnClosing](VRage.Game.Entity.MyEntity@OnClosing)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnDebugDraw](VRage.Game.Entity.MyEntity@OnDebugDraw)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnMarkForClose](VRage.Game.Entity.MyEntity@OnMarkForClose)|This event may not be invoked at all, when calling MyEntities.CloseAll, marking is bypassed<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnModelRefresh](VRage.Game.Entity.MyEntity@OnModelRefresh)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnPhysicsChanged](VRage.ModAPI.IMyEntity@OnPhysicsChanged)|Called when havok rigid body physics are changed: inited, closed, modified.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnPhysicsChanged](VRage.Game.Entity.MyEntity@OnPhysicsChanged)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnPhysicsComponentChanged](VRage.Game.Entity.MyEntity@OnPhysicsComponentChanged)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnTeleported](VRage.Game.Entity.MyEntity@OnTeleported)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnUpdateOnceBeforeNextFrame](VRage.Game.Entity.MyEntity@OnUpdateOnceBeforeNextFrame)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[RemovedFromScene](VRage.Game.Entity.MyEntity@RemovedFromScene)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|

## Properties

|Member|Description|
|---|---|
|[Freeze](Sandbox.Game.Entities.MyWaypoint@Freeze)||
|[Path](Sandbox.Game.Entities.MyWaypoint@Path)||
|[Visible](Sandbox.Game.Entities.MyWaypoint@Visible)||
|[CastShadows](VRage.ModAPI.IMyEntity@CastShadows)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Closed](VRage.Game.ModAPI.Ingame.IMyEntity@Closed)|True if the block has been removed from the world.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Closed](VRage.Game.Entity.MyEntity@Closed)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Components](VRage.Game.ModAPI.Ingame.IMyEntity@Components)|Gets blocks component logic container<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Components](VRage.Game.Entity.MyEntity@Components)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[DebugAsyncLoading](VRage.ModAPI.IMyEntity@DebugAsyncLoading)|Used for internal usage. Modders should not use it. Will be eventually removed<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DebugName](VRage.Game.Entity.MyEntity@DebugName)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[DisplayName](VRage.Game.ModAPI.Ingame.IMyEntity@DisplayName)|Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisplayNameText)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[DisplayName](VRage.ModAPI.IMyEntity@DisplayName)|Gets or sets user friendly name of entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DisplayName](VRage.Game.Entity.MyEntity@DisplayName)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[DisplayNameText](VRage.Game.Entity.MyEntity@DisplayNameText)|Display Name for GUI etc. Override in descendant classes. Usually used to display in terminal or inventory controls.<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[EntityId](VRage.Game.ModAPI.Ingame.IMyEntity@EntityId)|Id of entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[EntityId](VRage.ModAPI.IMyEntity@EntityId)|Uniq id of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[EntityId](VRage.Game.Entity.MyEntity@EntityId)|Entity id, can be set by subclasses (for example when using pool...)<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[EntityStorage](VRage.Game.Entity.MyEntity@EntityStorage)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[FastCastShadowResolve](VRage.ModAPI.IMyEntity@FastCastShadowResolve)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Flags](VRage.ModAPI.IMyEntity@Flags)|Gets or set some behavior of entity. [EntityFlags](VRage.ModAPI.EntityFlags)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Flags](VRage.Game.Entity.MyEntity@Flags)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GameLogic](VRage.ModAPI.IMyEntity@GameLogic)|Gets or sets game logic for object. If there is more than 1 game logic attached it should be wrapped into.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GameLogic](VRage.Game.Entity.MyEntity@GameLogic)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[HasInventory](VRage.Game.ModAPI.Ingame.IMyEntity@HasInventory)|Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[HasInventory](VRage.Game.Entity.MyEntity@HasInventory)|Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventoryBase() != null.<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Hierarchy](VRage.ModAPI.IMyEntity@Hierarchy)|Gets or sets Hierarchy component<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Hierarchy](VRage.Game.Entity.MyEntity@Hierarchy)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[InScene](VRage.ModAPI.IMyEntity@InScene)|Gets or set if grid is InScene. Objects that are not in scene are not updated and drawn.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InScene](VRage.Game.Entity.MyEntity@InScene)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[InvalidateOnMove](VRage.ModAPI.IMyEntity@InvalidateOnMove)|Gets if entity is invalidated on move When visual look of entity depends on position - then InvalidateOnMove should be true<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InvalidateOnMove](VRage.Game.Entity.MyEntity@InvalidateOnMove)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[InventoryCount](VRage.Game.ModAPI.Ingame.IMyEntity@InventoryCount)|Returns the count of the number of inventories this entity has.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[InventoryCount](VRage.Game.Entity.MyEntity@InventoryCount)|Iterate through inventories and return their count.<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsCCDForProjectiles](VRage.Game.Entity.MyEntity@IsCCDForProjectiles)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsPreview](VRage.Game.Entity.MyEntity@IsPreview)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsReadyForReplication](VRage.Game.Entity.MyEntity@IsReadyForReplication)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsReplicated](VRage.Game.Entity.MyEntity@IsReplicated)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsTransparentForJumpDrive](VRage.Game.Entity.MyEntity@IsTransparentForJumpDrive)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsVolumetric](VRage.ModAPI.IMyEntity@IsVolumetric)|Always returns false<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[IsVolumetric](VRage.Game.Entity.MyEntity@IsVolumetric)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[LastSnapshotFlags](VRage.Game.Entity.MyEntity@LastSnapshotFlags)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB)|Gets or sets local axis aligned bounding box. Same as [LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr)|Gets local axis aligned bounding box. Same as [LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalMatrix](VRage.ModAPI.IMyEntity@LocalMatrix)|Gets or sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolume](VRage.ModAPI.IMyEntity@LocalVolume)|Gets or sets local volume. Same as [LocalVolume](VRage.Game.Components.MyPositionComponentBase@LocalVolume)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolumeOffset](VRage.ModAPI.IMyEntity@LocalVolumeOffset)|Gets or sets local volume offset. Same as [LocalVolumeOffset](VRage.Game.Components.MyPositionComponentBase@LocalVolumeOffset)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocationForHudMarker](VRage.Game.Entity.MyEntity@LocationForHudMarker)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[MarkedForClose](VRage.ModAPI.IMyEntity@MarkedForClose)|Checked if [Close()](VRage.ModAPI.IMyEntity@Close) was called<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MarkedForClose](VRage.Game.Entity.MyEntity@MarkedForClose)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[MaxGlassDistSq](VRage.ModAPI.IMyEntity@MaxGlassDistSq)|Not used in game anymore<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MaxGlassDistSq](VRage.Game.Entity.MyEntity@MaxGlassDistSq)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Model](VRage.ModAPI.IMyEntity@Model)|Gets model of block<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Model](VRage.Game.Entity.MyEntity@Model)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ModelCollision](VRage.ModAPI.IMyEntity@ModelCollision)|Gets collision model of block<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ModelCollision](VRage.Game.Entity.MyEntity@ModelCollision)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Name](VRage.Game.ModAPI.Ingame.IMyEntity@Name)|Some entities can have uniq name, and game can find them by name [TryGetEntityByName(string, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityByName)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Name](VRage.ModAPI.IMyEntity@Name)|Uniq name of entity. Can be used to find entity by name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Name](VRage.Game.Entity.MyEntity@Name)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[NearFlag](VRage.ModAPI.IMyEntity@NearFlag)|Gets or sets flag [Near](VRage.ModAPI.EntityFlags@Near)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsDraw](VRage.ModAPI.IMyEntity@NeedsDraw)|Gets or sets flag [NeedsDraw](VRage.ModAPI.EntityFlags@NeedsDraw)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsDrawFromParent](VRage.ModAPI.IMyEntity@NeedsDrawFromParent)|Gets or sets flag [NeedsDrawFromParent](VRage.ModAPI.EntityFlags@NeedsDrawFromParent)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsResolveCastShadow](VRage.ModAPI.IMyEntity@NeedsResolveCastShadow)|Gets or sets flag [NeedsResolveCastShadow](VRage.ModAPI.EntityFlags@NeedsResolveCastShadow)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsUpdate](VRage.ModAPI.IMyEntity@NeedsUpdate)|Gets or sets how often the entity should be updated.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsUpdate](VRage.Game.Entity.MyEntity@NeedsUpdate)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[NeedsWorldMatrix](VRage.ModAPI.IMyEntity@NeedsWorldMatrix)|Gets or sets if [WorldMatrix](VRage.ModAPI.IMyEntity@WorldMatrix) should be calculated when parent WorldMatrix is changed.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsWorldMatrix](VRage.Game.Entity.MyEntity@NeedsWorldMatrix)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Parent](VRage.ModAPI.IMyEntity@Parent)|Gets parent of entity or null, if this entity doesn't have parent. Ex: character sitting in cockpit, has parent - cockpit, cockpit has parent - cube grid, connected grids also has main grid, which would be parent for other grids.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Parent](VRage.Game.Entity.MyEntity@Parent)|Gets or sets the parent.<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[PersistentFlags](VRage.ModAPI.IMyEntity@PersistentFlags)|Gets or sets persistent flags that are used in rendering.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Physics](VRage.ModAPI.IMyEntity@Physics)|Gets or sets physics for object<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Physics](VRage.Game.Entity.MyEntity@Physics)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Pinned](VRage.Game.Entity.MyEntity@Pinned)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[PositionComp](VRage.ModAPI.IMyEntity@PositionComp)|Gets or sets position provider logic<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[PositionComp](VRage.Game.Entity.MyEntity@PositionComp)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Render](VRage.ModAPI.IMyEntity@Render)|Gets or sets render logic<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Render](VRage.Game.Entity.MyEntity@Render)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Save](VRage.ModAPI.IMyEntity@Save)|Gets or sets [Save](VRage.ModAPI.EntityFlags@Save) . Entity won't be saved if [Save](VRage.ModAPI.IMyEntity@Save) is false<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Save](VRage.Game.Entity.MyEntity@Save)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ShadowBoxLod](VRage.ModAPI.IMyEntity@ShadowBoxLod)|Gets or sets flag [ShadowBoxLod](VRage.Game.Components.MyRenderComponentBase@ShadowBoxLod)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SkipIfTooSmall](VRage.ModAPI.IMyEntity@SkipIfTooSmall)|Gets or sets flag [SkipIfTooSmall](VRage.ModAPI.EntityFlags@SkipIfTooSmall)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[StopPhysicsActivation](VRage.ModAPI.IMyEntity@StopPhysicsActivation)|_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[StopPhysicsActivation](VRage.Game.Entity.MyEntity@StopPhysicsActivation)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Storage](VRage.ModAPI.IMyEntity@Storage)|Custom storage for mods. Shared with all mods.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Storage](VRage.Game.Entity.MyEntity@Storage)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Subparts](VRage.Game.Entity.MyEntity@Subparts)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[SyncFlag](VRage.Game.Entity.MyEntity@SyncFlag)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Synchronized](VRage.ModAPI.IMyEntity@Synchronized)|Gets or sets if the entity should be synced.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SyncObject](VRage.ModAPI.IMyEntity@SyncObject)|Gets SyncObject used for synchronizing data over network with<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SyncObject](VRage.Game.Entity.MyEntity@SyncObject)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Transparent](VRage.ModAPI.IMyEntity@Transparent)|Gets or sets [Transparency](VRage.Game.Components.MyRenderComponentBase@Transparency) . When setting true entity would be 25% transparent<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[UpdateDuration](VRage.Game.Entity.MyEntity@UpdateDuration)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Visible](VRage.ModAPI.IMyEntity@Visible)|Gets or sets flag [Visible](VRage.Game.Components.MyRenderComponentBase@Visible)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldAABB](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABB)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldAABBHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABBHr)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.Game.ModAPI.Ingame.IMyEntity@WorldMatrix)|Gets world matrix of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.ModAPI.IMyEntity@WorldMatrix)|Gets or sets world matrix.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldMatrix](VRage.Game.Entity.MyEntity@WorldMatrix)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[WorldMatrixInvScaled](VRage.ModAPI.IMyEntity@WorldMatrixInvScaled)|Get scaled, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv) , but not normalized<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)|Get normalized, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldVolume](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolume)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldVolumeHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolumeHr)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[IsCCDForProjectiles](VRage.ModAPI.IMyEntity@IsCCDForProjectiles)|_**Obsolete**_<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocationForHudMarker](VRage.ModAPI.IMyEntity@LocationForHudMarker)|_**Obsolete**_<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

## Constructors

|Member|Description|
|---|---|
|[MyWaypoint()](Sandbox.Game.Entities.MyWaypoint@.ctor)||
|[MyEntity()](VRage.Game.Entity.MyEntity@.ctor)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[MyEntity(bool)](VRage.Game.Entity.MyEntity@.ctor)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|

## Methods

|Member|Description|
|---|---|
|[static GetCubeBlockParent(MyEntity)](VRage.Game.Entity.MyEntity@GetCubeBlockParent)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetObjectBuilder(bool)](Sandbox.Game.Entities.MyWaypoint@GetObjectBuilder)||
|[Init(MyObjectBuilder_EntityBase)](Sandbox.Game.Entities.MyWaypoint@Init)||
|[AddDebugRenderComponent(MyDebugRenderComponentBase)](VRage.Game.Entity.MyEntity@AddDebugRenderComponent)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[AddToGamePruningStructure()](VRage.Game.Entity.MyEntity@AddToGamePruningStructure)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[AfterPaste()](VRage.Game.Entity.MyEntity@AfterPaste)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ApplyLastControls()](VRage.Game.Entity.MyEntity@ApplyLastControls)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[BeforePaste()](VRage.Game.Entity.MyEntity@BeforePaste)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[BeforeSave()](VRage.ModAPI.IMyEntity@BeforeSave)|Called before method GetObjectBuilder, when saving sector<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[BeforeSave()](VRage.Game.Entity.MyEntity@BeforeSave)|Called before method GetObjectBuilder, when saving sector<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ClearDebugRenderComponents()](VRage.Game.Entity.MyEntity@ClearDebugRenderComponents)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Close()](VRage.ModAPI.IMyEntity@Close)|This method marks this entity for close which means, that Close will be called after all entities are updated<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Close()](VRage.Game.Entity.MyEntity@Close)|This method marks this entity for close which means, that Close will be called after all entities are updated<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ContainsDebugRenderComponent(Type)](VRage.Game.Entity.MyEntity@ContainsDebugRenderComponent)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[CreateSync()](VRage.Game.Entity.MyEntity@CreateSync)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[DebugDraw()](VRage.ModAPI.IMyEntity@DebugDraw)|Calls debug draw of entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DebugDraw()](VRage.Game.Entity.MyEntity@DebugDraw)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[DebugDrawInvalidTriangles()](VRage.ModAPI.IMyEntity@DebugDrawInvalidTriangles)|Calls special debug draw, that highlighting invalid triangles in model<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DebugDrawInvalidTriangles()](VRage.Game.Entity.MyEntity@DebugDrawInvalidTriangles)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[DebugDrawPhysics()](VRage.Game.Entity.MyEntity@DebugDrawPhysics)|Draw physical representation of entity<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Delete()](VRage.ModAPI.IMyEntity@Delete)|Performs real cleaning of entity. Should be called by game. Modders should prefer [Close()](VRage.ModAPI.IMyEntity@Close) method.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Delete()](VRage.Game.Entity.MyEntity@Delete)|Every object must have this method, but not every phys object must necessarily have something to cleanup<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[DeserializeControls(BitStream, bool)](VRage.Game.Entity.MyEntity@DeserializeControls)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[DoOverlapSphereTest(float, Vector3D)](VRage.ModAPI.IMyEntity@DoOverlapSphereTest)|Checks if intersects Works only with [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DoOverlapSphereTest(float, Vector3D)](VRage.Game.Entity.MyEntity@DoOverlapSphereTest)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[EnableColorMaskForSubparts(bool)](VRage.ModAPI.IMyEntity@EnableColorMaskForSubparts)|Allows subparts have different color than their parent<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetBaseEntity()](VRage.Game.Entity.MyEntity@GetBaseEntity)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetChildren(List<IMyEntity>, Func<IMyEntity, bool>)](VRage.ModAPI.IMyEntity@GetChildren)|Gets children of entity. Child - entity, who's [Parent](VRage.ModAPI.IMyEntity@Parent) is this entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDiffuseColor()](VRage.ModAPI.IMyEntity@GetDiffuseColor)|Gets render diffuse color<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndBoundingSphere)|Distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. (in meters)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndBoundingSphere()](VRage.Game.Entity.MyEntity@GetDistanceBetweenCameraAndBoundingSphere)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetDistanceBetweenCameraAndPosition()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndPosition)|Distance from camera to position of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndPosition()](VRage.Game.Entity.MyEntity@GetDistanceBetweenCameraAndPosition)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetDistanceBetweenPlayerPositionAndBoundingSphere()](VRage.Game.Entity.MyEntity@GetDistanceBetweenPlayerPositionAndBoundingSphere)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetFriendlyName()](VRage.ModAPI.IMyEntity@GetFriendlyName)|Not used. Actually not a friendly name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetFriendlyName()](VRage.Game.Entity.MyEntity@GetFriendlyName)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetHudParams(bool)](VRage.Game.Entity.MyEntity@GetHudParams)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetIntersectionWithAABB(ref BoundingBoxD)](VRage.ModAPI.IMyEntity@GetIntersectionWithAABB)|Return true if object intersects specified bounding box.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithAABB(ref BoundingBoxD)](VRage.Game.Entity.MyEntity@GetIntersectionWithAABB)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetIntersectionWithLine(ref LineD, out MyIntersectionResultLineTriangleEx?, IntersectionFlags)](VRage.ModAPI.IMyEntity@GetIntersectionWithLine)|Get intersection of model with provided line<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithLine(ref LineD, out Vector3D?, bool, IntersectionFlags)](VRage.Game.Entity.MyEntity@GetIntersectionWithLine)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetIntersectionWithLine(ref LineD, out MyIntersectionResultLineTriangleEx?, IntersectionFlags)](VRage.Game.Entity.MyEntity@GetIntersectionWithLine)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetIntersectionWithLineAndBoundingSphere(ref LineD, float)](VRage.ModAPI.IMyEntity@GetIntersectionWithLineAndBoundingSphere)|Calculates intersection of line with any bounding sphere in this model instance. Center of the bounding sphere will be returned. It takes boundingSphereRadiusMultiplier argument which serves for extending the influence (radius) for interaction with line.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithLineAndBoundingSphere(ref LineD, float)](VRage.Game.Entity.MyEntity@GetIntersectionWithLineAndBoundingSphere)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetIntersectionWithSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntity@GetIntersectionWithSphere)|Return true if object intersects specified sphere.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithSphere(ref BoundingSphereD)](VRage.Game.Entity.MyEntity@GetIntersectionWithSphere)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetInventory()](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetInventory(int)](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Search for inventory component with maching index.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetInventory()](VRage.ModAPI.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetInventory(int)](VRage.ModAPI.IMyEntity@GetInventory)|Search for inventory component with matching index.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetInventoryBase(int)](VRage.Game.Entity.MyEntity@GetInventoryBase)|Search for inventory component with maching index.<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetInventoryBase()](VRage.Game.Entity.MyEntity@GetInventoryBase)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetLargestDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetLargestDistanceBetweenCameraAndBoundingSphere)|Largest distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. It's actually distance between camera and opposite side of the sphere<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetLargestDistanceBetweenCameraAndBoundingSphere()](VRage.Game.Entity.MyEntity@GetLargestDistanceBetweenCameraAndBoundingSphere)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetObjectBuilder(bool)](VRage.ModAPI.IMyEntity@GetObjectBuilder)|Returns object builder - object representing block state, and allows restore it. Used in game save, or syncing over network.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetObjectBuilder(bool)](VRage.Game.Entity.MyEntity@GetObjectBuilder)|Gets object builder from object.<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetPosition()](VRage.Game.ModAPI.Ingame.IMyEntity@GetPosition)|Gets position in world coordinates<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetSmallestDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetSmallestDistanceBetweenCameraAndBoundingSphere)|Smallest distance between camera and bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetSmallestDistanceBetweenCameraAndBoundingSphere()](VRage.Game.Entity.MyEntity@GetSmallestDistanceBetweenCameraAndBoundingSphere)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetSubpart(string)](VRage.ModAPI.IMyEntity@GetSubpart)|Gets subpart by subpart name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetSubpart(string)](VRage.Game.Entity.MyEntity@GetSubpart)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetTopMostParent(Type)](VRage.ModAPI.IMyEntity@GetTopMostParent)|Gets top most [Parent](VRage.ModAPI.IMyEntity@Parent) of specified type. Top most is entity that doesn't have parent (of specified type)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetTopMostParent(Type)](VRage.Game.Entity.MyEntity@GetTopMostParent)|Return top most parent of this entity<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetTrianglesIntersectingSphere(ref BoundingSphere, Vector3?, float?, List<MyTriangle_Vertex_Normals>, int)](VRage.ModAPI.IMyEntity@GetTrianglesIntersectingSphere)|Return list of triangles intersecting specified sphere. Angle between every triangleVertexes normal vector and 'referenceNormalVector' is calculated, and if more than 'maxAngle', we ignore such triangleVertexes. Triangles are returned in 'retTriangles', and this list must be preallocated! IMPORTANT: Sphere must be in model space, so don't transform it!<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetTrianglesIntersectingSphere(ref BoundingSphere, Vector3?, float?, List<MyTriangle_Vertex_Normals>, int)](VRage.Game.Entity.MyEntity@GetTrianglesIntersectingSphere)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix)|Get normalized, inverted world matrix. Same as [GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetViewMatrix()](VRage.Game.Entity.MyEntity@GetViewMatrix)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv)|Get normalized, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Init(MyObjectBuilder_EntityBase)](VRage.Game.Entity.MyEntity@Init)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Init(StringBuilder, string, MyEntity, float?, string)](VRage.Game.Entity.MyEntity@Init)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[InitComponents()](VRage.Game.Entity.MyEntity@InitComponents)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[InitComponentsForTesting()](VRage.Game.Entity.MyEntity@InitComponentsForTesting)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsVisible()](VRage.ModAPI.IMyEntity@IsVisible)|Gets or result of function [IsVisible()](VRage.Game.Components.MyRenderComponentBase@IsVisible) . Function inside check for [IsVisible(IMyEntity)](VRage.ModAPI.IMyEntities@IsVisible)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnAddedToScene(object)](VRage.ModAPI.IMyEntity@OnAddedToScene)|Adds entity to scene: init updates, render physics<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnAddedToScene(object)](VRage.Game.Entity.MyEntity@OnAddedToScene)|Called when [activated] which for entity means that was added to scene.<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnRemovedFromScene(object)](VRage.ModAPI.IMyEntity@OnRemovedFromScene)|Remove entity and it's children from scene: stops updates and render, deactivates physics. Usually called when entity deleted<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnRemovedFromScene(object)](VRage.Game.Entity.MyEntity@OnRemovedFromScene)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnReplicationEnded()](VRage.Game.Entity.MyEntity@OnReplicationEnded)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnReplicationStarted()](VRage.Game.Entity.MyEntity@OnReplicationStarted)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Pin()](VRage.Game.Entity.MyEntity@Pin)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[PrepareForDraw()](VRage.Game.Entity.MyEntity@PrepareForDraw)|Method is called defacto from Update, preparation fo Draw<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[RaisePhysicsChanged()](VRage.Game.Entity.MyEntity@RaisePhysicsChanged)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[RefreshModels(string, string)](VRage.Game.Entity.MyEntity@RefreshModels)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[RemoveDebugRenderComponent(Type)](VRage.Game.Entity.MyEntity@RemoveDebugRenderComponent)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[RemoveDebugRenderComponent(MyDebugRenderComponentBase)](VRage.Game.Entity.MyEntity@RemoveDebugRenderComponent)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[RemoveFromGamePruningStructure()](VRage.Game.Entity.MyEntity@RemoveFromGamePruningStructure)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ResetControls()](VRage.Game.Entity.MyEntity@ResetControls)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[SerializeControls(BitStream)](VRage.Game.Entity.MyEntity@SerializeControls)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[SetColorMaskForSubparts(Vector3)](VRage.ModAPI.IMyEntity@SetColorMaskForSubparts)|Sets subparts custom col<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetEmissiveParts(string, Color, float)](VRage.ModAPI.IMyEntity@SetEmissiveParts)|Sets the emissive value of a specific emissive material on entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetEmissiveParts(string, Color, float)](VRage.Game.Entity.MyEntity@SetEmissiveParts)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[SetEmissivePartsForSubparts(string, Color, float)](VRage.ModAPI.IMyEntity@SetEmissivePartsForSubparts)|Sets the emissive value of a specific emissive material on all entity subparts.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetEmissivePartsForSubparts(string, Color, float)](VRage.Game.Entity.MyEntity@SetEmissivePartsForSubparts)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[SetFadeOut(bool)](VRage.Game.Entity.MyEntity@SetFadeOut)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[SetLocalMatrix(Matrix, object)](VRage.ModAPI.IMyEntity@SetLocalMatrix)|Sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetPosition(Vector3D)](VRage.ModAPI.IMyEntity@SetPosition)|Set WorldMatrix's [Translation](VRageMath.MatrixD@Translation) . Moves entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|Sets subparts custom skinning. Copy values from [TextureChanges](VRage.Game.Components.MyRenderComponentBase@TextureChanges) , then change needed keys. You can retrieve values for exact skin with following code:```csharp<br />MyDefinitionManager.Static.GetAssetModifierDefinitionForRender(skinId);<br /><br />```<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetWorldMatrix(MatrixD, object)](VRage.ModAPI.IMyEntity@SetWorldMatrix)|Sets world matrix of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Simulate()](VRage.Game.Entity.MyEntity@Simulate)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Teleport(MatrixD, object, bool)](VRage.ModAPI.IMyEntity@Teleport)|When moving entity over large distances or when entity has children, using this method preferred over [SetPosition(Vector3D)](VRage.ModAPI.IMyEntity@SetPosition)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Teleport(MatrixD, object, bool)](VRage.Game.Entity.MyEntity@Teleport)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ToString()](VRage.Game.Entity.MyEntity@ToString)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[TryGetDebugRenderComponent<T>(out T)](VRage.Game.Entity.MyEntity@TryGetDebugRenderComponent{T})|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[TryGetSubpart(string, out MyEntitySubpart)](VRage.ModAPI.IMyEntity@TryGetSubpart)|Gets subpart by subpart name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[TryGetSubpart(string, out MyEntitySubpart)](VRage.Game.Entity.MyEntity@TryGetSubpart)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Unpin()](VRage.Game.Entity.MyEntity@Unpin)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateAfterSimulation()](VRage.Game.Entity.MyEntity@UpdateAfterSimulation)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateAfterSimulation10()](VRage.Game.Entity.MyEntity@UpdateAfterSimulation10)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateAfterSimulation100()](VRage.Game.Entity.MyEntity@UpdateAfterSimulation100)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateBeforeSimulation()](VRage.Game.Entity.MyEntity@UpdateBeforeSimulation)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateBeforeSimulation10()](VRage.Game.Entity.MyEntity@UpdateBeforeSimulation10)|Called each 10th frame if registered for update10<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateBeforeSimulation100()](VRage.Game.Entity.MyEntity@UpdateBeforeSimulation100)|Called each 100th frame if registered for update100<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateGamePruningStructure()](VRage.ModAPI.IMyEntity@UpdateGamePruningStructure)|Update position of entity in MyGamePruningStructure. Calls:```csharp<br />MyGamePruningStructure.Move(this)<br /><br />```<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[UpdateGamePruningStructure()](VRage.Game.Entity.MyEntity@UpdateGamePruningStructure)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateOnceBeforeFrame()](VRage.Game.Entity.MyEntity@UpdateOnceBeforeFrame)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateSoundContactPoint(long, Vector3, Vector3, Vector3, float)](VRage.Game.Entity.MyEntity@UpdateSoundContactPoint)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdatingStopped()](VRage.Game.Entity.MyEntity@UpdatingStopped)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[AddToGamePruningStructure()](VRage.ModAPI.IMyEntity@AddToGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[RemoveFromGamePruningStructure()](VRage.ModAPI.IMyEntity@RemoveFromGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetTextureChangesForSubparts(Dictionary<string, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|_**Obsolete**_<br /><br />This calling is obsolete, use another version.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

**Inheritance:**   [MyEntity](VRage.Game.Entity.MyEntity)

**Implements:**  
* [IMyEntity](VRage.ModAPI.IMyEntity)  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)

