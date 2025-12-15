**Assembly:** Sandbox.Game.dll

```csharp
public class MyCubeGrid: MyEntity, IMyEntity, IMyEntity, IMyGridConnectivityTest, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyShootOrigin, IMyParallelUpdateable, IMyCubeGrid, IMyCubeGrid
```

Grid - small ship, large ship, station Cubes (armor, walls...) are merge and rendered by this entity Blocks (turret, thrusts...) are rendered as child entities

## Fields

|Member|Description|
|---|---|
|[static DebugUpdateHistoryDuration](Sandbox.Game.Entities.MyCubeGrid@DebugUpdateHistoryDuration)|Number of gameplay frames to keep the update history for. Defaults to 120 frames.|
|[static OnLockToolbarPosition](Sandbox.Game.Entities.MyCubeGrid@OnLockToolbarPosition)||
|[static OnUnLockToolbarPosition](Sandbox.Game.Entities.MyCubeGrid@OnUnLockToolbarPosition)||
|[static WorkPriority](Sandbox.Game.Entities.MyCubeGrid@WorkPriority)||
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
|[BeingCreatedInSplit](Sandbox.Game.Entities.MyCubeGrid@BeingCreatedInSplit)||
|[BlockCounter](Sandbox.Game.Entities.MyCubeGrid@BlockCounter)||
|[BlocksCounters](Sandbox.Game.Entities.MyCubeGrid@BlocksCounters)||
|[BlocksWaitingOnAttachUpdate](Sandbox.Game.Entities.MyCubeGrid@BlocksWaitingOnAttachUpdate)||
|[CloseGrid](Sandbox.Game.Entities.MyCubeGrid@CloseGrid)||
|[ControlledFromTurret](Sandbox.Game.Entities.MyCubeGrid@ControlledFromTurret)||
|[CreatePhysics](Sandbox.Game.Entities.MyCubeGrid@CreatePhysics)||
|[GridGeneralDamageModifier](Sandbox.Game.Entities.MyCubeGrid@GridGeneralDamageModifier)||
|[GridPresenceUpdate](Sandbox.Game.Entities.MyCubeGrid@GridPresenceUpdate)||
|[HasMechanicalTopPenindingReattach](Sandbox.Game.Entities.MyCubeGrid@HasMechanicalTopPenindingReattach)||
|[HasShipSoundEvents](Sandbox.Game.Entities.MyCubeGrid@HasShipSoundEvents)||
|[IdentityAuthorshipBlockCount](Sandbox.Game.Entities.MyCubeGrid@IdentityAuthorshipBlockCount)||
|[InternalInitFinished](Sandbox.Game.Entities.MyCubeGrid@InternalInitFinished)||
|[IsAccessibleForProgrammableBlock](Sandbox.Game.Entities.MyCubeGrid@IsAccessibleForProgrammableBlock)||
|[LastSelectedProductionBlockId](Sandbox.Game.Entities.MyCubeGrid@LastSelectedProductionBlockId)||
|[m_occupiedBlocks](Sandbox.Game.Entities.MyCubeGrid@m_occupiedBlocks)||
|[m_playedTime](Sandbox.Game.Entities.MyCubeGrid@m_playedTime)|Grid play time with player. Used by respawn ship.|
|[MainCockpit](Sandbox.Game.Entities.MyCubeGrid@MainCockpit)||
|[MainRemoteControl](Sandbox.Game.Entities.MyCubeGrid@MainRemoteControl)||
|[MassSyncProperty](Sandbox.Game.Entities.MyCubeGrid@MassSyncProperty)|This is updated only when a player is sitting in the cockpit and autopilot is enabled.|
|[NpcClaimSecondsRemaining](Sandbox.Game.Entities.MyCubeGrid@NpcClaimSecondsRemaining)||
|[NpcClaimSecondsRemainingUpdateRequestTime](Sandbox.Game.Entities.MyCubeGrid@NpcClaimSecondsRemainingUpdateRequestTime)||
|[NpcClaimSecondsRemainingUpdateTime](Sandbox.Game.Entities.MyCubeGrid@NpcClaimSecondsRemainingUpdateTime)||
|[NumberOfReactors](Sandbox.Game.Entities.MyCubeGrid@NumberOfReactors)||
|[Projector](Sandbox.Game.Entities.MyCubeGrid@Projector)||
|[XSymmetryOdd](Sandbox.Game.Entities.MyCubeGrid@XSymmetryOdd)||
|[XSymmetryPlane](Sandbox.Game.Entities.MyCubeGrid@XSymmetryPlane)||
|[YSymmetryOdd](Sandbox.Game.Entities.MyCubeGrid@YSymmetryOdd)||
|[YSymmetryPlane](Sandbox.Game.Entities.MyCubeGrid@YSymmetryPlane)||
|[ZSymmetryOdd](Sandbox.Game.Entities.MyCubeGrid@ZSymmetryOdd)||
|[ZSymmetryPlane](Sandbox.Game.Entities.MyCubeGrid@ZSymmetryPlane)||
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
|[static OnBlockAddedGlobally](Sandbox.Game.Entities.MyCubeGrid@OnBlockAddedGlobally)|Called only for single block changes|
|[static OnBlockRemovedGlobally](Sandbox.Game.Entities.MyCubeGrid@OnBlockRemovedGlobally)|Not called on grid split, or when closing grid|
|[static OnBlocksChangeFinishedGlobally](Sandbox.Game.Entities.MyCubeGrid@OnBlocksChangeFinishedGlobally)|Called on multi block changes. Both arguments may be null. First from where blocks where removed, second - where added|
|[static OnSplitGridCreated](Sandbox.Game.Entities.MyCubeGrid@OnSplitGridCreated)||
|[GridPresenceTierChanged](Sandbox.Game.Entities.MyCubeGrid@GridPresenceTierChanged)||
|[IsPoweredChanged](Sandbox.Game.Entities.MyCubeGrid@IsPoweredChanged)||
|[OnBlockAdded](Sandbox.Game.Entities.MyCubeGrid@OnBlockAdded)||
|[OnBlockClosed](Sandbox.Game.Entities.MyCubeGrid@OnBlockClosed)||
|[OnBlockIntegrityChanged](Sandbox.Game.Entities.MyCubeGrid@OnBlockIntegrityChanged)||
|[OnBlockOwnershipChanged](Sandbox.Game.Entities.MyCubeGrid@OnBlockOwnershipChanged)||
|[OnBlockRemoved](Sandbox.Game.Entities.MyCubeGrid@OnBlockRemoved)||
|[OnConnectionChangeCompleted](Sandbox.Game.Entities.MyCubeGrid@OnConnectionChangeCompleted)|Event triggered, when one of GridLinkTypeEnum connections changed. Used to determine changes in connections. Use may also need react to OnGridMerge/OnGridSplit Event different from OnConnectivityChanged. 1) It is called when all group changes 2) It is called AFTER all group changes, so GetConnectedGrids returning correct results|
|[OnConnectionChanged](Sandbox.Game.Entities.MyCubeGrid@OnConnectionChanged)|Event triggered, when one of GridLinkTypeEnum connections changed. Used to determine changes in connections. Use may also need react to OnGridMerge/OnGridSplit|
|[OnDeschedule](Sandbox.Game.Entities.MyCubeGrid@OnDeschedule)||
|[OnDynamicNPCGridOrSubgridShooting](Sandbox.Game.Entities.MyCubeGrid@OnDynamicNPCGridOrSubgridShooting)||
|[OnFatBlockAdded](Sandbox.Game.Entities.MyCubeGrid@OnFatBlockAdded)||
|[OnFatBlockClosed](Sandbox.Game.Entities.MyCubeGrid@OnFatBlockClosed)||
|[OnFatBlockRemoved](Sandbox.Game.Entities.MyCubeGrid@OnFatBlockRemoved)||
|[OnGridBlockDamaged](Sandbox.Game.Entities.MyCubeGrid@OnGridBlockDamaged)||
|[OnGridChanged](Sandbox.Game.Entities.MyCubeGrid@OnGridChanged)||
|[OnGridMarkedDirty](Sandbox.Game.Entities.MyCubeGrid@OnGridMarkedDirty)||
|[OnGridMerge](Sandbox.Game.Entities.MyCubeGrid@OnGridMerge)|Called, when 2 grids are merged with merge block. First grid - grid that will stay, second - will be merged into first, and deleted. Called for both grids|
|[OnGridSplit](Sandbox.Game.Entities.MyCubeGrid@OnGridSplit)||
|[OnHavokSystemIDChanged](Sandbox.Game.Entities.MyCubeGrid@OnHavokSystemIDChanged)||
|[OnHierarchyUpdated](Sandbox.Game.Entities.MyCubeGrid@OnHierarchyUpdated)||
|[OnMassPropertiesChanged](Sandbox.Game.Entities.MyCubeGrid@OnMassPropertiesChanged)||
|[OnMaxThrustChanged](Sandbox.Game.Entities.MyCubeGrid@OnMaxThrustChanged)|May be called from parallel thread|
|[OnMinMaxChanged](Sandbox.Game.Entities.MyCubeGrid@OnMinMaxChanged)||
|[OnNameChanged](Sandbox.Game.Entities.MyCubeGrid@OnNameChanged)||
|[OnNaturalGravityChanged](Sandbox.Game.Entities.MyCubeGrid@OnNaturalGravityChanged)||
|[OnSolarOccludedChanged](Sandbox.Game.Entities.MyCubeGrid@OnSolarOccludedChanged)||
|[OnStaticChanged](Sandbox.Game.Entities.MyCubeGrid@OnStaticChanged)||
|[OnTargetLocked](Sandbox.Game.Entities.MyCubeGrid@OnTargetLocked)||
|[OnTargetLockLost](Sandbox.Game.Entities.MyCubeGrid@OnTargetLockLost)||
|[PlayerPresenceTierChanged](Sandbox.Game.Entities.MyCubeGrid@PlayerPresenceTierChanged)||
|[SpeedChanged](Sandbox.Game.Entities.MyCubeGrid@SpeedChanged)||
|[SyncPropertyChanged](Sandbox.Game.Entities.MyCubeGrid@SyncPropertyChanged)||
|[AddedToScene](VRage.Game.Entity.MyEntity@AddedToScene)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GridPresenceTierChanged](VRage.Game.ModAPI.IMyCubeGrid@GridPresenceTierChanged)|Triggered when grid presence tier is changed<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnBlockAdded](VRage.Game.ModAPI.IMyCubeGrid@OnBlockAdded)|Called when a block is added to the grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnBlockIntegrityChanged](VRage.Game.ModAPI.IMyCubeGrid@OnBlockIntegrityChanged)|Triggered when block integrity changes (construction)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnBlockOwnershipChanged](VRage.Game.ModAPI.IMyCubeGrid@OnBlockOwnershipChanged)|Called when a block on the grid changes owner<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnBlockRemoved](VRage.Game.ModAPI.IMyCubeGrid@OnBlockRemoved)|Called when a block is removed from the grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnClose](VRage.ModAPI.IMyEntity@OnClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnClose](VRage.Game.Entity.MyEntity@OnClose)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnClosing](VRage.ModAPI.IMyEntity@OnClosing)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnClosing](VRage.Game.Entity.MyEntity@OnClosing)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnDebugDraw](VRage.Game.Entity.MyEntity@OnDebugDraw)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnGridBlockDamaged](VRage.Game.ModAPI.IMyCubeGrid@OnGridBlockDamaged)|Called when one of blocks on grid is taking damage<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnGridChanged](VRage.Game.ModAPI.IMyCubeGrid@OnGridChanged)|Called when a grid is taken control of by a player<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnGridMerge](VRage.Game.ModAPI.IMyCubeGrid@OnGridMerge)|Called, when 2 grids are merged with merge block. First grid - grid that will stay, second - will be merged into first, and deleted. Called for both grids<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnGridSplit](VRage.Game.ModAPI.IMyCubeGrid@OnGridSplit)|Triggered when grid is split<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnIsStaticChanged](VRage.Game.ModAPI.IMyCubeGrid@OnIsStaticChanged)|Triggered when grid changes to or from static (station)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnMarkForClose](VRage.Game.Entity.MyEntity@OnMarkForClose)|This event may not be invoked at all, when calling MyEntities.CloseAll, marking is bypassed<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnMaxThrustChanged](VRage.Game.ModAPI.IMyCubeGrid@OnMaxThrustChanged)|Triggered when max thrust in one of directions was changed. Maybe called from parralel thread<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnModelRefresh](VRage.Game.Entity.MyEntity@OnModelRefresh)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnNaturalGravityChanged](VRage.Game.ModAPI.IMyCubeGrid@OnNaturalGravityChanged)|Triggered when natural gravity changes around the grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnPhysicsChanged](VRage.ModAPI.IMyEntity@OnPhysicsChanged)|Called when havok rigid body physics are changed: inited, closed, modified.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnPhysicsChanged](VRage.Game.Entity.MyEntity@OnPhysicsChanged)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnPhysicsComponentChanged](VRage.Game.Entity.MyEntity@OnPhysicsComponentChanged)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnTargetLocked](VRage.Game.ModAPI.IMyCubeGrid@OnTargetLocked)|Called when grid was target locked<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnTeleported](VRage.Game.Entity.MyEntity@OnTeleported)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnUpdateOnceBeforeNextFrame](VRage.Game.Entity.MyEntity@OnUpdateOnceBeforeNextFrame)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[PlayerPresenceTierChanged](VRage.Game.ModAPI.IMyCubeGrid@PlayerPresenceTierChanged)|Triggered when player presence tier is changed<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[RemovedFromScene](VRage.Game.Entity.MyEntity@RemovedFromScene)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[SpeedChanged](VRage.Game.ModAPI.IMyCubeGrid@SpeedChanged)|Triggered when speed of the grid is changed<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnIsStaticChanged](Sandbox.Game.Entities.MyCubeGrid@OnIsStaticChanged)|_**Obsolete:** Use OnStaticChanged_|

## Properties

|Member|Description|
|---|---|
|[static GridCounter](Sandbox.Game.Entities.MyCubeGrid@GridCounter)||
|[static ShowAiInfo](Sandbox.Game.Entities.MyCubeGrid@ShowAiInfo)||
|[static ShowAntennaGizmos](Sandbox.Game.Entities.MyCubeGrid@ShowAntennaGizmos)||
|[static ShowCenterOfMass](Sandbox.Game.Entities.MyCubeGrid@ShowCenterOfMass)||
|[static ShowGravityGizmos](Sandbox.Game.Entities.MyCubeGrid@ShowGravityGizmos)||
|[static ShowGridPivot](Sandbox.Game.Entities.MyCubeGrid@ShowGridPivot)||
|[static ShowSenzorGizmos](Sandbox.Game.Entities.MyCubeGrid@ShowSenzorGizmos)||
|[AllowPrediction](Sandbox.Game.Entities.MyCubeGrid@AllowPrediction)||
|[BigOwners](Sandbox.Game.Entities.MyCubeGrid@BigOwners)|players that have the maximum number of functional blocks in cube grid|
|[BlocksCount](Sandbox.Game.Entities.MyCubeGrid@BlocksCount)||
|[BlocksDestructionEnabled](Sandbox.Game.Entities.MyCubeGrid@BlocksDestructionEnabled)||
|[BlocksForDraw](Sandbox.Game.Entities.MyCubeGrid@BlocksForDraw)||
|[BlocksPCU](Sandbox.Game.Entities.MyCubeGrid@BlocksPCU)||
|[ClosestParentId](Sandbox.Game.Entities.MyCubeGrid@ClosestParentId)||
|[ConveyorSystem](Sandbox.Game.Entities.MyCubeGrid@ConveyorSystem)||
|[CubeBlocks](Sandbox.Game.Entities.MyCubeGrid@CubeBlocks)||
|[DampenersEnabled](Sandbox.Game.Entities.MyCubeGrid@DampenersEnabled)||
|[Decoys](Sandbox.Game.Entities.MyCubeGrid@Decoys)||
|[DestructibleBlocks](Sandbox.Game.Entities.MyCubeGrid@DestructibleBlocks)||
|[DirtyBlocks](Sandbox.Game.Entities.MyCubeGrid@DirtyBlocks)||
|[Editable](Sandbox.Game.Entities.MyCubeGrid@Editable)||
|[EntityThrustComponent](Sandbox.Game.Entities.MyCubeGrid@EntityThrustComponent)||
|[ForceDisablePrediction](Sandbox.Game.Entities.MyCubeGrid@ForceDisablePrediction)||
|[GameLogic](Sandbox.Game.Entities.MyCubeGrid@GameLogic)||
|[GetAmmoDefinition](Sandbox.Game.Entities.MyCubeGrid@GetAmmoDefinition)||
|[GridPresenceTier](Sandbox.Game.Entities.MyCubeGrid@GridPresenceTier)||
|[GridScale](Sandbox.Game.Entities.MyCubeGrid@GridScale)||
|[GridSize](Sandbox.Game.Entities.MyCubeGrid@GridSize)||
|[GridSizeEnum](Sandbox.Game.Entities.MyCubeGrid@GridSizeEnum)||
|[GridSizeHalf](Sandbox.Game.Entities.MyCubeGrid@GridSizeHalf)||
|[GridSizeHalfVector](Sandbox.Game.Entities.MyCubeGrid@GridSizeHalfVector)||
|[GridSizeQuarter](Sandbox.Game.Entities.MyCubeGrid@GridSizeQuarter)||
|[GridSizeQuarterVector](Sandbox.Game.Entities.MyCubeGrid@GridSizeQuarterVector)||
|[GridSizeR](Sandbox.Game.Entities.MyCubeGrid@GridSizeR)|Reciprocal of gridsize|
|[GridSystems](Sandbox.Game.Entities.MyCubeGrid@GridSystems)||
|[HasCubeGridRender](Sandbox.Game.Entities.MyCubeGrid@HasCubeGridRender)||
|[HasMechanicalBlocksWaitingOnAttachUpdate](Sandbox.Game.Entities.MyCubeGrid@HasMechanicalBlocksWaitingOnAttachUpdate)||
|[Immune](Sandbox.Game.Entities.MyCubeGrid@Immune)||
|[InitFromClipboard](Sandbox.Game.Entities.MyCubeGrid@InitFromClipboard)|True if created from `MyGridClipboard`<sub>prohibited</sub> . Set earlier than IsProjected, before blocks/ec are handled|
|[Inventories](Sandbox.Game.Entities.MyCubeGrid@Inventories)||
|[IsBlockAreaChange](Sandbox.Game.Entities.MyCubeGrid@IsBlockAreaChange)||
|[IsBlockTrasferInProgress](Sandbox.Game.Entities.MyCubeGrid@IsBlockTrasferInProgress)||
|[IsClientPredicted](Sandbox.Game.Entities.MyCubeGrid@IsClientPredicted)||
|[IsClientPredictedCar](Sandbox.Game.Entities.MyCubeGrid@IsClientPredictedCar)||
|[IsClientPredictedWheel](Sandbox.Game.Entities.MyCubeGrid@IsClientPredictedWheel)||
|[IsGenerated](Sandbox.Game.Entities.MyCubeGrid@IsGenerated)|Gets or sets is generated, used for economy stations|
|[IsLargeDestroyInProgress](Sandbox.Game.Entities.MyCubeGrid@IsLargeDestroyInProgress)||
|[IsMarkedForEarlyDeactivation](Sandbox.Game.Entities.MyCubeGrid@IsMarkedForEarlyDeactivation)||
|[IsNpcSpawnedGrid](Sandbox.Game.Entities.MyCubeGrid@IsNpcSpawnedGrid)||
|[IsParked](Sandbox.Game.Entities.MyCubeGrid@IsParked)||
|[IsPowered](Sandbox.Game.Entities.MyCubeGrid@IsPowered)||
|[IsRespawnGrid](Sandbox.Game.Entities.MyCubeGrid@IsRespawnGrid)|Gets or sets indication if a grid coresponds to a respawn ship/cart.|
|[IsSmokeParticleActive](Sandbox.Game.Entities.MyCubeGrid@IsSmokeParticleActive)||
|[IsSolarOccluded](Sandbox.Game.Entities.MyCubeGrid@IsSolarOccluded)||
|[IsSplit](Sandbox.Game.Entities.MyCubeGrid@IsSplit)||
|[IsStatic](Sandbox.Game.Entities.MyCubeGrid@IsStatic)||
|[IsTransparentForJumpDrive](Sandbox.Game.Entities.MyCubeGrid@IsTransparentForJumpDrive)||
|[IsUnsupportedStation](Sandbox.Game.Entities.MyCubeGrid@IsUnsupportedStation)||
|[LastUpdates](Sandbox.Game.Entities.MyCubeGrid@LastUpdates)||
|[LinearVelocity](Sandbox.Game.Entities.MyCubeGrid@LinearVelocity)||
|[LocalCoordSystem](Sandbox.Game.Entities.MyCubeGrid@LocalCoordSystem)|Local coord system under which this cube exists. (its id)|
|[LockedByCount](Sandbox.Game.Entities.MyCubeGrid@LockedByCount)||
|[MarkedAsTrash](Sandbox.Game.Entities.MyCubeGrid@MarkedAsTrash)||
|[Mass](Sandbox.Game.Entities.MyCubeGrid@Mass)||
|[Max](Sandbox.Game.Entities.MyCubeGrid@Max)||
|[MaxShootRange](Sandbox.Game.Entities.MyCubeGrid@MaxShootRange)||
|[Min](Sandbox.Game.Entities.MyCubeGrid@Min)||
|[NaturalGravity](Sandbox.Game.Entities.MyCubeGrid@NaturalGravity)||
|[NumberOfGridColors](Sandbox.Game.Entities.MyCubeGrid@NumberOfGridColors)|Return how many colors are on grid|
|[OccupiedBlocks](Sandbox.Game.Entities.MyCubeGrid@OccupiedBlocks)||
|[Physics](Sandbox.Game.Entities.MyCubeGrid@Physics)||
|[PlayerPresenceTier](Sandbox.Game.Entities.MyCubeGrid@PlayerPresenceTier)||
|[RenderData](Sandbox.Game.Entities.MyCubeGrid@RenderData)||
|[RvoAgentId](Sandbox.Game.Entities.MyCubeGrid@RvoAgentId)||
|[ShapeCount](Sandbox.Game.Entities.MyCubeGrid@ShapeCount)||
|[ShootOrigin](Sandbox.Game.Entities.MyCubeGrid@ShootOrigin)||
|[SmallOwners](Sandbox.Game.Entities.MyCubeGrid@SmallOwners)|players that have at least one block in cube grid|
|[Speed](Sandbox.Game.Entities.MyCubeGrid@Speed)||
|[SyncType](Sandbox.Game.Entities.MyCubeGrid@SyncType)||
|[TrashHighlightCounter](Sandbox.Game.Entities.MyCubeGrid@TrashHighlightCounter)||
|[UnsafeBlocks](Sandbox.Game.Entities.MyCubeGrid@UnsafeBlocks)||
|[UpdateFlags](Sandbox.Game.Entities.MyCubeGrid@UpdateFlags)||
|[UsesTargetingList](Sandbox.Game.Entities.MyCubeGrid@UsesTargetingList)||
|[BigOwners](VRage.Game.ModAPI.IMyCubeGrid@BigOwners)|List of players with majority of blocks on grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[CastShadows](VRage.ModAPI.IMyEntity@CastShadows)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Closed](VRage.Game.ModAPI.Ingame.IMyEntity@Closed)|True if the block has been removed from the world.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Closed](VRage.Game.Entity.MyEntity@Closed)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Components](VRage.Game.ModAPI.Ingame.IMyEntity@Components)|Gets blocks component logic container<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Components](VRage.Game.Entity.MyEntity@Components)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ControlSystem](VRage.Game.ModAPI.IMyCubeGrid@ControlSystem)|Gets grid-group control system<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[ConveyorSystem](VRage.Game.ModAPI.IMyCubeGrid@ConveyorSystem)|Gets grid-group conveyor system<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[CustomName](VRage.Game.ModAPI.Ingame.IMyCubeGrid@CustomName)|Getter and setter for display name of the grid (as seen in Info terminal tab)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[CustomName](VRage.Game.ModAPI.IMyCubeGrid@CustomName)|Display name of the grid (as seen in Info terminal tab)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
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
|[GasSystem](VRage.Game.ModAPI.IMyCubeGrid@GasSystem)|Gets grid-group gas system<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[GetAmmoDefinition](Sandbox.ModAPI.IMyShootOrigin@GetAmmoDefinition)|Gets ammo definition<br /><br />_Inherited from [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)_|
|[GridPresenceTier](VRage.Game.ModAPI.IMyCubeGrid@GridPresenceTier)|Gets grid presence tier<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[GridSize](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GridSize)|Getter of grid size in meters<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[GridSizeEnum](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GridSizeEnum)|Getter for grid size enum<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
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
|[IsBlockTrasferInProgress](VRage.Game.ModAPI.IMyCubeGrid@IsBlockTrasferInProgress)|Gets whether the move block transfer from one grid to another is in progress. This happens during the split operation.<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[IsCCDForProjectiles](VRage.Game.Entity.MyEntity@IsCCDForProjectiles)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsNpcSpawnedGrid](VRage.Game.ModAPI.IMyCubeGrid@IsNpcSpawnedGrid)|Gets if this grid is NPC spawned grid by the system (cargo ship, encounter, etc)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[IsPreview](VRage.Game.Entity.MyEntity@IsPreview)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsReadyForReplication](VRage.Game.Entity.MyEntity@IsReadyForReplication)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsReplicated](VRage.Game.Entity.MyEntity@IsReplicated)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsRespawnGrid](VRage.Game.ModAPI.IMyCubeGrid@IsRespawnGrid)|Gets or sets if this grid is a respawn grid (can be cleaned up automatically when player leaves)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[IsStatic](VRage.Game.ModAPI.Ingame.IMyCubeGrid@IsStatic)|Determines if the grid is static (unmoveable)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[IsStatic](VRage.Game.ModAPI.IMyCubeGrid@IsStatic)|Gets or sets if the grid is static (station)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[IsTransparentForJumpDrive](VRage.Game.Entity.MyEntity@IsTransparentForJumpDrive)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[IsVolumetric](VRage.ModAPI.IMyEntity@IsVolumetric)|Always returns false<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[IsVolumetric](VRage.Game.Entity.MyEntity@IsVolumetric)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[JumpSystem](VRage.Game.ModAPI.IMyCubeGrid@JumpSystem)|Gets grid-group jump system<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[LastSnapshotFlags](VRage.Game.Entity.MyEntity@LastSnapshotFlags)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[LinearVelocity](VRage.Game.ModAPI.Ingame.IMyCubeGrid@LinearVelocity)|Gets linear velocity of the grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB)|Gets or sets local axis aligned bounding box. Same as [LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr)|Gets local axis aligned bounding box. Same as [LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalMatrix](VRage.ModAPI.IMyEntity@LocalMatrix)|Gets or sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolume](VRage.ModAPI.IMyEntity@LocalVolume)|Gets or sets local volume. Same as [LocalVolume](VRage.Game.Components.MyPositionComponentBase@LocalVolume)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolumeOffset](VRage.ModAPI.IMyEntity@LocalVolumeOffset)|Gets or sets local volume offset. Same as [LocalVolumeOffset](VRage.Game.Components.MyPositionComponentBase@LocalVolumeOffset)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocationForHudMarker](VRage.Game.Entity.MyEntity@LocationForHudMarker)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[MarkedForClose](VRage.ModAPI.IMyEntity@MarkedForClose)|Checked if [Close()](VRage.ModAPI.IMyEntity@Close) was called<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MarkedForClose](VRage.Game.Entity.MyEntity@MarkedForClose)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Max](VRage.Game.ModAPI.Ingame.IMyCubeGrid@Max)|Maximum coordinates of blocks in grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[MaxGlassDistSq](VRage.ModAPI.IMyEntity@MaxGlassDistSq)|Not used in game anymore<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MaxGlassDistSq](VRage.Game.Entity.MyEntity@MaxGlassDistSq)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[MaxShootRange](Sandbox.ModAPI.IMyShootOrigin@MaxShootRange)|Gets weapon max shoot range<br /><br />_Inherited from [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)_|
|[Min](VRage.Game.ModAPI.Ingame.IMyCubeGrid@Min)|Minimum coordinates of blocks in grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[Model](VRage.ModAPI.IMyEntity@Model)|Gets model of block<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Model](VRage.Game.Entity.MyEntity@Model)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ModelCollision](VRage.ModAPI.IMyEntity@ModelCollision)|Gets collision model of block<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ModelCollision](VRage.Game.Entity.MyEntity@ModelCollision)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Name](VRage.Game.ModAPI.Ingame.IMyEntity@Name)|Some entities can have uniq name, and game can find them by name [TryGetEntityByName(string, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityByName)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Name](VRage.ModAPI.IMyEntity@Name)|Uniq name of entity. Can be used to find entity by name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Name](VRage.Game.Entity.MyEntity@Name)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[NaturalGravity](VRage.Game.ModAPI.IMyCubeGrid@NaturalGravity)|Gets natural gravity around the grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
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
|[PlayerPresenceTier](VRage.Game.ModAPI.IMyCubeGrid@PlayerPresenceTier)|Gets player presence tier<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[PositionComp](VRage.ModAPI.IMyEntity@PositionComp)|Gets or sets position provider logic<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[PositionComp](VRage.Game.Entity.MyEntity@PositionComp)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Render](VRage.ModAPI.IMyEntity@Render)|Gets or sets render logic<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Render](VRage.Game.Entity.MyEntity@Render)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ResourceDistributor](VRage.Game.ModAPI.IMyCubeGrid@ResourceDistributor)|Gets grid-group resource distributor<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[RvoAgentId](VRage.Game.ModAPI.IMyCubeGrid@RvoAgentId)|Gets RVO Agent ID used for collision avoidance algorithm<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[Save](VRage.ModAPI.IMyEntity@Save)|Gets or sets [Save](VRage.ModAPI.EntityFlags@Save) . Entity won't be saved if [Save](VRage.ModAPI.IMyEntity@Save) is false<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Save](VRage.Game.Entity.MyEntity@Save)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ShadowBoxLod](VRage.ModAPI.IMyEntity@ShadowBoxLod)|Gets or sets flag [ShadowBoxLod](VRage.Game.Components.MyRenderComponentBase@ShadowBoxLod)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ShootOrigin](Sandbox.ModAPI.IMyShootOrigin@ShootOrigin)|Gets shot starting position<br /><br />_Inherited from [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)_|
|[SkipIfTooSmall](VRage.ModAPI.IMyEntity@SkipIfTooSmall)|Gets or sets flag [SkipIfTooSmall](VRage.ModAPI.EntityFlags@SkipIfTooSmall)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SmallOwners](VRage.Game.ModAPI.IMyCubeGrid@SmallOwners)|List of players with any blocks on grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[Speed](VRage.Game.ModAPI.Ingame.IMyCubeGrid@Speed)|Gets speed of the grid calculated from Linear Velocity. Rounded to two decimal places.<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
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
|[UpdateFlags](Sandbox.Game.Entities.IMyParallelUpdateable@UpdateFlags)|_Inherited from [IMyParallelUpdateable](Sandbox.Game.Entities.IMyParallelUpdateable)_|
|[Visible](VRage.ModAPI.IMyEntity@Visible)|Gets or sets flag [Visible](VRage.Game.Components.MyRenderComponentBase@Visible)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WeaponSystem](VRage.Game.ModAPI.IMyCubeGrid@WeaponSystem)|Gets grid-group weapon system<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[WorldAABB](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABB)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldAABBHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABBHr)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.Game.ModAPI.Ingame.IMyEntity@WorldMatrix)|Gets world matrix of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.ModAPI.IMyEntity@WorldMatrix)|Gets or sets world matrix.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldMatrix](VRage.Game.Entity.MyEntity@WorldMatrix)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[WorldMatrixInvScaled](VRage.ModAPI.IMyEntity@WorldMatrixInvScaled)|Get scaled, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv) , but not normalized<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)|Get normalized, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldVolume](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolume)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldVolumeHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolumeHr)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[XSymmetryOdd](VRage.Game.ModAPI.IMyCubeGrid@XSymmetryOdd)|Gets or sets if the symmetry plane is offset from the block center<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[XSymmetryPlane](VRage.Game.ModAPI.IMyCubeGrid@XSymmetryPlane)|Gets or sets X-Axis build symmetry plane<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[YSymmetryOdd](VRage.Game.ModAPI.IMyCubeGrid@YSymmetryOdd)|Gets or sets if the symmetry plane is offset from the block center<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[YSymmetryPlane](VRage.Game.ModAPI.IMyCubeGrid@YSymmetryPlane)|Gets or sets Y-Axis build symmetry plane<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[ZSymmetryOdd](VRage.Game.ModAPI.IMyCubeGrid@ZSymmetryOdd)|Gets or sets if the symmetry plane is offset from the block center<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[ZSymmetryPlane](VRage.Game.ModAPI.IMyCubeGrid@ZSymmetryPlane)|Gets or sets Z-Axis build symmetry plane<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[IsCCDForProjectiles](VRage.ModAPI.IMyEntity@IsCCDForProjectiles)|_**Obsolete**_<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocationForHudMarker](VRage.ModAPI.IMyEntity@LocationForHudMarker)|_**Obsolete**_<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

## Constructors

|Member|Description|
|---|---|
|[MyCubeGrid()](Sandbox.Game.Entities.MyCubeGrid@.ctor)||
|[MyEntity()](VRage.Game.Entity.MyEntity@.ctor)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[MyEntity(bool)](VRage.Game.Entity.MyEntity@.ctor)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|

## Methods

|Member|Description|
|---|---|
|[static BreakGridGroupLink(GridLinkTypeEnum, long, MyCubeGrid, MyCubeGrid)](Sandbox.Game.Entities.MyCubeGrid@BreakGridGroupLink)||
|[static CancelPendingTransferRequestsServerSide(Guid, long, long)](Sandbox.Game.Entities.MyCubeGrid@CancelPendingTransferRequestsServerSide)||
|[static CanHavePhysics(List<MySlimBlock>, int, int)](Sandbox.Game.Entities.MyCubeGrid@CanHavePhysics)|Returns true when grid have at least one block which has physics (lights has no physics)|
|[static CanPasteGrid()](Sandbox.Game.Entities.MyCubeGrid@CanPasteGrid)||
|[static ChangeOwnersRequest(MyOwnershipShareModeEnum, Dictionary<MyCubeGrid, List<MySingleOwnershipRequest>>)](Sandbox.Game.Entities.MyCubeGrid@ChangeOwnersRequest)||
|[static ChangeShareRequest(MyOwnershipShareModeEnum, Dictionary<MyCubeGrid, List<MySingleOwnershipRequest>>)](Sandbox.Game.Entities.MyCubeGrid@ChangeShareRequest)||
|[static CheckAreaConnectivity(MyCubeGrid, ref MyBlockBuildArea, List<Vector3UByte>, HashSet<Vector3UByte>)](Sandbox.Game.Entities.MyCubeGrid@CheckAreaConnectivity)||
|[static CheckConnectivity(IMyGridConnectivityTest, MyCubeBlockDefinition, MountPoint[], ref Quaternion, ref Vector3I)](Sandbox.Game.Entities.MyCubeGrid@CheckConnectivity)||
|[static CheckConnectivitySmallBlockToLargeGrid(MyCubeGrid, MyCubeBlockDefinition, ref Quaternion, ref Vector3I)](Sandbox.Game.Entities.MyCubeGrid@CheckConnectivitySmallBlockToLargeGrid)|Performs check whether small cube block given by its definition, rotation can be connected to large grid. Function checks whether a mount point on placed block exists in opposite direction than addNomal.|
|[static CheckMergeConnectivity(MyCubeGrid, MyCubeGrid, Vector3I)](Sandbox.Game.Entities.MyCubeGrid@CheckMergeConnectivity)||
|[static CheckMountPointsForSide(MyCubeBlockDefinition, MountPoint[], ref MyBlockOrientation, ref Vector3I, ref Vector3I, MyCubeBlockDefinition, MountPoint[], ref MyBlockOrientation, ref Vector3I)](Sandbox.Game.Entities.MyCubeGrid@CheckMountPointsForSide)||
|[static CheckMountPointsForSide(List<MountPoint>, ref MyBlockOrientation, ref Vector3I, MyDefinitionId, ref Vector3I, List<MountPoint>, ref MyBlockOrientation, ref Vector3I, MyDefinitionId)](Sandbox.Game.Entities.MyCubeGrid@CheckMountPointsForSide)||
|[static CheckNeighborMountPoints(Vector3, Vector3, MountPoint, ref Vector3I, MyCubeBlockDefinition, Vector3I, MyCubeBlockDefinition, MountPoint[], MyBlockOrientation, List<MountPoint>)](Sandbox.Game.Entities.MyCubeGrid@CheckNeighborMountPoints)||
|[static CheckNeighborMountPointsForCompound(Vector3, Vector3, MountPoint, ref Vector3I, MyCubeBlockDefinition, Vector3I, MyCubeBlockDefinition, MountPoint[], MyBlockOrientation, List<MountPoint>)](Sandbox.Game.Entities.MyCubeGrid@CheckNeighborMountPointsForCompound)||
|[static ConvertPrefabsToObjs()](Sandbox.Game.Entities.MyCubeGrid@ConvertPrefabsToObjs)||
|[static CreateGridGroupLink(GridLinkTypeEnum, long, MyCubeGrid, MyCubeGrid)](Sandbox.Game.Entities.MyCubeGrid@CreateGridGroupLink)||
|[static CreateSplit(MyCubeGrid, List<MySlimBlock>, bool, long)](Sandbox.Game.Entities.MyCubeGrid@CreateSplit)||
|[static CreateSplits(MyCubeGrid, List<MySlimBlock>, List<Group>, MyTestDisconnectsReason, bool)](Sandbox.Game.Entities.MyCubeGrid@CreateSplits)||
|[static DebugFormatMethodName(MethodInfo)](Sandbox.Game.Entities.MyCubeGrid@DebugFormatMethodName)||
|[static ExportObject(MyCubeGrid, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@ExportObject)||
|[static GetArmorSkinItem(MyStringHash)](Sandbox.Game.Entities.MyCubeGrid@GetArmorSkinItem)||
|[static GetCubeParts(MyCubeBlockDefinition, Vector3I, Matrix, float, List<string>, List<MatrixD>, List<Vector3>, List<Vector4UByte>, bool)](Sandbox.Game.Entities.MyCubeGrid@GetCubeParts)||
|[static GetLineIntersection(ref LineD, out MyCubeGrid, out Vector3I, out double, Func<MyCubeGrid, bool>)](Sandbox.Game.Entities.MyCubeGrid@GetLineIntersection)||
|[static GetLineIntersectionExact(ref LineD, out MyCubeGrid, out Vector3I, out double)](Sandbox.Game.Entities.MyCubeGrid@GetLineIntersectionExact)||
|[static GetTargetEntity()](Sandbox.Game.Entities.MyCubeGrid@GetTargetEntity)|Obtain entity that player is aiming/looking at.|
|[static GetTargetGrid()](Sandbox.Game.Entities.MyCubeGrid@GetTargetGrid)|Obtain grid that player is aiming/looking at.|
|[static GridIntegerToWorld(float, Vector3I, MatrixD)](Sandbox.Game.Entities.MyCubeGrid@GridIntegerToWorld)||
|[static HandleRemovalOfOwnershipTransferRequests()](Sandbox.Game.Entities.MyCubeGrid@HandleRemovalOfOwnershipTransferRequests)||
|[static HasStandAloneBlocks(List<MySlimBlock>, int, int)](Sandbox.Game.Entities.MyCubeGrid@HasStandAloneBlocks)|Returns true when grid have at least one stand alone block|
|[static IsAabbInsideVoxel(MatrixD, BoundingBoxD, MyGridPlacementSettings)](Sandbox.Game.Entities.MyCubeGrid@IsAabbInsideVoxel)|Checks if aabb is in voxel. If settings provided it will return false if penetration settings allow for it.|
|[static IsGridInCompleteState(MyCubeGrid)](Sandbox.Game.Entities.MyCubeGrid@IsGridInCompleteState)||
|[static IsInVoxels(MySlimBlock, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@IsInVoxels)||
|[static KillAllCharacters(MyCubeGrid, bool)](Sandbox.Game.Entities.MyCubeGrid@KillAllCharacters)||
|[static OnChangeOwnersRequestConfirmation(Guid, long, bool)](Sandbox.Game.Entities.MyCubeGrid@OnChangeOwnersRequestConfirmation)||
|[static PackFiles(string, string)](Sandbox.Game.Entities.MyCubeGrid@PackFiles)||
|[static PlacePrefabsToWorld()](Sandbox.Game.Entities.MyCubeGrid@PlacePrefabsToWorld)||
|[static PlacePrefabToWorld(MyObjectBuilder_CubeGrid[], Vector3D, List<MyCubeGrid>)](Sandbox.Game.Entities.MyCubeGrid@PlacePrefabToWorld)||
|[static Players_PlayerRemoved(PlayerId)](Sandbox.Game.Entities.MyCubeGrid@Players_PlayerRemoved)||
|[static Preload()](Sandbox.Game.Entities.MyCubeGrid@Preload)||
|[static RayCastStaticCells(Vector3D, Vector3D, List<Vector3I>, float, Vector3I?, bool)](Sandbox.Game.Entities.MyCubeGrid@RayCastStaticCells)|Obtains positions of static grid cells regardless of whether these cells are taken up by blocks or not. Usefull when placing block on voxel.|
|[static RemoveSplit(MyCubeGrid, List<MySlimBlock>, int, int, bool)](Sandbox.Game.Entities.MyCubeGrid@RemoveSplit)||
|[static ResetInfoGizmos()](Sandbox.Game.Entities.MyCubeGrid@ResetInfoGizmos)||
|[static SendHudNotificationAfterPaste()](Sandbox.Game.Entities.MyCubeGrid@SendHudNotificationAfterPaste)||
|[static ShowMessageGridsRemovedWhilePasting()](Sandbox.Game.Entities.MyCubeGrid@ShowMessageGridsRemovedWhilePasting)||
|[static ShowMessageGridsRemovedWhilePastingInternal()](Sandbox.Game.Entities.MyCubeGrid@ShowMessageGridsRemovedWhilePastingInternal)||
|[static ShowPasteFailedOperation()](Sandbox.Game.Entities.MyCubeGrid@ShowPasteFailedOperation)||
|[static StartConverting(bool)](Sandbox.Game.Entities.MyCubeGrid@StartConverting)||
|[static StaticGlobalGrid_UGToWorld(Vector3D, float, bool)](Sandbox.Game.Entities.MyCubeGrid@StaticGlobalGrid_UGToWorld)|Converts static global uniform grid coordinate to world coordinate. Grid size is already used inside calculation.|
|[static StaticGlobalGrid_WorldToUG(Vector3D, float, bool)](Sandbox.Game.Entities.MyCubeGrid@StaticGlobalGrid_WorldToUG)|Converts world coordinate to static global grid uniform coordinate (virtual large grid in whole world which every large grid is snapped to). Grid size is already used inside calculation.|
|[static StaticGlobalGrid_WorldToUGInt(Vector3D, float, bool)](Sandbox.Game.Entities.MyCubeGrid@StaticGlobalGrid_WorldToUGInt)|Converts world coordinate to static global grid uniform coordinate (virtual large grid in whole world which every large grid is snapped to). Grid size is already used inside calculation.|
|[static TestBlockPlacementArea(MyCubeGrid, ref MyGridPlacementSettings, MyBlockOrientation, MyCubeBlockDefinition, ref Vector3D, ref Quaternion, ref Vector3, ref BoundingBoxD, ulong, MyEntity, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@TestBlockPlacementArea)||
|[static TestBlockPlacementArea(MyCubeGrid, ref MyGridPlacementSettings, MyBlockOrientation, MyCubeBlockDefinition, ref Vector3D, ref Quaternion, ref Vector3, ref BoundingBoxD, out MyCubeGrid, ulong, MyEntity, bool, bool, bool, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@TestBlockPlacementArea)||
|[static TestBlockPlacementArea(MyCubeBlockDefinition, MyBlockOrientation?, MatrixD, ref MyGridPlacementSettings, BoundingBoxD, bool, MyEntity, bool)](Sandbox.Game.Entities.MyCubeGrid@TestBlockPlacementArea)||
|[static TestBlockPlacementAreaVanilla(MyCubeGrid, ref MyGridPlacementSettings, MyBlockOrientation, MyCubeBlockDefinition, ref Vector3D, ref Quaternion, ref Vector3, ref BoundingBoxD, out MyCubeGrid, ulong, MyEntity, bool, bool, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@TestBlockPlacementAreaVanilla)||
|[static TestPlacementArea(MyCubeGrid, ref MyGridPlacementSettings, BoundingBoxD, bool, MyEntity)](Sandbox.Game.Entities.MyCubeGrid@TestPlacementArea)||
|[static TestPlacementArea(MyCubeGrid, bool, ref MyGridPlacementSettings, BoundingBoxD, bool, MyEntity, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@TestPlacementArea)||
|[static TestPlacementAreaCube(MyCubeGrid, ref MyGridPlacementSettings, Vector3I, Vector3I, MyBlockOrientation, MyCubeBlockDefinition, ulong, MyEntity, bool, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@TestPlacementAreaCube)||
|[static TestPlacementAreaCube(MyCubeGrid, ref MyGridPlacementSettings, Vector3I, Vector3I, MyBlockOrientation, MyCubeBlockDefinition, out MyCubeGrid, ulong, MyEntity, bool, bool, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@TestPlacementAreaCube)|Test cube block placement area in grid.|
|[static TestPlacementAreaCubeNoAABBInflate(MyCubeGrid, ref MyGridPlacementSettings, Vector3I, Vector3I, MyBlockOrientation, MyCubeBlockDefinition, out MyCubeGrid, ulong, MyEntity, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@TestPlacementAreaCubeNoAABBInflate)||
|[static TestPlacementForWheel(HkShape, Quaternion, MatrixD, HkBodyCollision, MatrixD, MyCubeBlockDefinition)](Sandbox.Game.Entities.MyCubeGrid@TestPlacementForWheel)||
|[static TestPlacementForWheelWhenPlacingWheel(MyAttachableTopBlockBase, MatrixD, Vector3D, List<HkBodyCollision>)](Sandbox.Game.Entities.MyCubeGrid@TestPlacementForWheelWhenPlacingWheel)||
|[static TestPlacementVoxelMapOverlap(MyVoxelBase, ref MyGridPlacementSettings, ref BoundingBoxD, ref MatrixD, bool)](Sandbox.Game.Entities.MyCubeGrid@TestPlacementVoxelMapOverlap)||
|[static TestVoxelPlacement(MyCubeBlockDefinition, MyGridPlacementSettings, bool, MatrixD, BoundingBoxD)](Sandbox.Game.Entities.MyCubeGrid@TestVoxelPlacement)||
|[static TransformMountPoints(List<MountPoint>, MyCubeBlockDefinition, MountPoint[], ref MyBlockOrientation)](Sandbox.Game.Entities.MyCubeGrid@TransformMountPoints)||
|[static TryPasteGrid_Implementation(MyPasteGridParameters)](Sandbox.Game.Entities.MyCubeGrid@TryPasteGrid_Implementation)||
|[static TryRayCastGrid(ref LineD, out MyCubeGrid, out Vector3D)](Sandbox.Game.Entities.MyCubeGrid@TryRayCastGrid)||
|[static GetCubeBlockParent(MyEntity)](VRage.Game.Entity.MyEntity@GetCubeBlockParent)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ActivatePhysics()](Sandbox.Game.Entities.MyCubeGrid@ActivatePhysics)||
|[AddDirtyBone(Vector3I, Vector3I)](Sandbox.Game.Entities.MyCubeGrid@AddDirtyBone)||
|[AnnounceRemoveSplit(List<MySlimBlock>)](Sandbox.Game.Entities.MyCubeGrid@AnnounceRemoveSplit)||
|[ApplyDestructionDeformation(MySlimBlock, float, MyHitInfo?, long)](Sandbox.Game.Entities.MyCubeGrid@ApplyDestructionDeformation)||
|[ApplyLastControls()](Sandbox.Game.Entities.MyCubeGrid@ApplyLastControls)||
|[BuildBlockRequestInternal(MyBlockVisuals, MyBlockLocation, MyObjectBuilder_CubeBlock, long, bool, long, ulong, bool)](Sandbox.Game.Entities.MyCubeGrid@BuildBlockRequestInternal)||
|[BuildBlocks(ref MyBlockBuildArea, long, long)](Sandbox.Game.Entities.MyCubeGrid@BuildBlocks)||
|[BuildBlocks(Vector3, MyStringHash, HashSet<MyBlockLocation>, long, long)](Sandbox.Game.Entities.MyCubeGrid@BuildBlocks)||
|[BuildBlocksClient(MyBlockVisuals, HashSet<MyBlockLocation>, long, bool, long)](Sandbox.Game.Entities.MyCubeGrid@BuildBlocksClient)||
|[BuildBlocksFailedNotify()](Sandbox.Game.Entities.MyCubeGrid@BuildBlocksFailedNotify)||
|[BuildBlockSucess(MyBlockVisuals, MyBlockLocation, MyObjectBuilder_CubeBlock, long, bool, long)](Sandbox.Game.Entities.MyCubeGrid@BuildBlockSucess)||
|[BuildGeneratedBlock(MyBlockLocation, Vector3, MyStringHash)](Sandbox.Game.Entities.MyCubeGrid@BuildGeneratedBlock)||
|[CalculateMergeTransform(MyCubeGrid, Vector3I)](Sandbox.Game.Entities.MyCubeGrid@CalculateMergeTransform)||
|[CanAddCube(Vector3I, MyBlockOrientation?, MyCubeBlockDefinition, bool)](Sandbox.Game.Entities.MyCubeGrid@CanAddCube)||
|[CanAddCubes(Vector3I, Vector3I)](Sandbox.Game.Entities.MyCubeGrid@CanAddCubes)||
|[CanBeTeleported(MyGridJumpDriveSystem, out MyJumpFailReason)](Sandbox.Game.Entities.MyCubeGrid@CanBeTeleported)||
|[CanHavePhysics()](Sandbox.Game.Entities.MyCubeGrid@CanHavePhysics)|Returns true when grid have at least one block which has physics (e.g. interior lights have no physics)|
|[CanMergeCubes(MyCubeGrid, Vector3I)](Sandbox.Game.Entities.MyCubeGrid@CanMergeCubes)||
|[CanPlaceBlock(Vector3I, Vector3I, MyBlockOrientation, MyCubeBlockDefinition, ulong, int?, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@CanPlaceBlock)||
|[CanPlaceBlock(Vector3I, Vector3I, MyBlockOrientation, MyCubeBlockDefinition, ref MyGridPlacementSettings, ulong, int?, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@CanPlaceBlock)||
|[ChangeColorAndSkin(MySlimBlock, Vector3?, MyStringHash?)](Sandbox.Game.Entities.MyCubeGrid@ChangeColorAndSkin)||
|[ChangeDisplayNameRequest(string)](Sandbox.Game.Entities.MyCubeGrid@ChangeDisplayNameRequest)||
|[ChangeGridOwner(long, MyOwnershipShareModeEnum)](Sandbox.Game.Entities.MyCubeGrid@ChangeGridOwner)||
|[ChangeGridOwnership(long, MyOwnershipShareModeEnum)](Sandbox.Game.Entities.MyCubeGrid@ChangeGridOwnership)||
|[ChangeOwner(MyCubeBlock, long, long)](Sandbox.Game.Entities.MyCubeGrid@ChangeOwner)||
|[ChangeOwnerRequest(MyCubeGrid, MyCubeBlock, long, MyOwnershipShareModeEnum)](Sandbox.Game.Entities.MyCubeGrid@ChangeOwnerRequest)||
|[ChangePowerProducerState(MyMultipleEnabledEnum, bool)](Sandbox.Game.Entities.MyCubeGrid@ChangePowerProducerState)||
|[ChangePowerProducerStateInternal(MyMultipleEnabledEnum, long, bool)](Sandbox.Game.Entities.MyCubeGrid@ChangePowerProducerStateInternal)||
|[CheckPredictionFlagScheduling()](Sandbox.Game.Entities.MyCubeGrid@CheckPredictionFlagScheduling)||
|[ClearSymmetries()](Sandbox.Game.Entities.MyCubeGrid@ClearSymmetries)||
|[ClientPredictionStaticCheck()](Sandbox.Game.Entities.MyCubeGrid@ClientPredictionStaticCheck)||
|[ColorBlocks(Vector3I, Vector3I, Vector3, bool)](Sandbox.Game.Entities.MyCubeGrid@ColorBlocks)|Color block in area. Verry slow.|
|[ColorGrid(Vector3, bool)](Sandbox.Game.Entities.MyCubeGrid@ColorGrid)||
|[ColorGridOrBlockRequestValidation()](Sandbox.Game.Entities.MyCubeGrid@ColorGridOrBlockRequestValidation)||
|[CompetetiveContainerOpened(long, int, Color)](Sandbox.Game.Entities.MyCubeGrid@CompetetiveContainerOpened)||
|[ContainerOpened(long)](Sandbox.Game.Entities.MyCubeGrid@ContainerOpened)||
|[ConvertToStatic()](Sandbox.Game.Entities.MyCubeGrid@ConvertToStatic)|Conversion to Unsupported station. For generic conversion to static use physics component. Sets up the Unsupported station state.|
|[CreateSplit_Implementation(List<Vector3I>, long)](Sandbox.Game.Entities.MyCubeGrid@CreateSplit_Implementation)||
|[CreateSplits_Implementation(List<Vector3I>, List<Group>)](Sandbox.Game.Entities.MyCubeGrid@CreateSplits_Implementation)||
|[CubeExists(Vector3I)](Sandbox.Game.Entities.MyCubeGrid@CubeExists)||
|[DepressurizeEffect(Vector3I, Vector3I)](Sandbox.Game.Entities.MyCubeGrid@DepressurizeEffect)||
|[DepressurizeEffect_Implementation(Vector3I, Vector3I)](Sandbox.Game.Entities.MyCubeGrid@DepressurizeEffect_Implementation)||
|[DeSchedule(UpdateQueue, Action)](Sandbox.Game.Entities.MyCubeGrid@DeSchedule)||
|[DeserializeControls(BitStream, bool)](Sandbox.Game.Entities.MyCubeGrid@DeserializeControls)||
|[DetectDisconnectsAfterFrame()](Sandbox.Game.Entities.MyCubeGrid@DetectDisconnectsAfterFrame)||
|[DetectMerge(MySlimBlock, MyCubeGrid, List<MyEntity>, bool)](Sandbox.Game.Entities.MyCubeGrid@DetectMerge)|Tries to merge this grid with any other grid Merges grids only when both are static Returns the merged grid (which does not necessarily have to be this grid)|
|[DismountAllCockpits()](Sandbox.Game.Entities.MyCubeGrid@DismountAllCockpits)||
|[DoDamage(float, MyHitInfo, Vector3?, long)](Sandbox.Game.Entities.MyCubeGrid@DoDamage)||
|[EnqueueDestroyedBlock(Vector3I)](Sandbox.Game.Entities.MyCubeGrid@EnqueueDestroyedBlock)||
|[EnqueueDestructionDeformationBlock(Vector3I)](Sandbox.Game.Entities.MyCubeGrid@EnqueueDestructionDeformationBlock)||
|[EnqueueRemovedBlock(Vector3I)](Sandbox.Game.Entities.MyCubeGrid@EnqueueRemovedBlock)||
|[EnqueueRemovedBlockWithId(Vector3I, ushort?)](Sandbox.Game.Entities.MyCubeGrid@EnqueueRemovedBlockWithId)|Server method, adds removed block with compound id into queue|
|[FindBlocksBuiltByID(long)](Sandbox.Game.Entities.MyCubeGrid@FindBlocksBuiltByID)|Find all blocks built by a specific player..|
|[FindBlocksBuiltByID(long, HashSet<MySlimBlock>)](Sandbox.Game.Entities.MyCubeGrid@FindBlocksBuiltByID)||
|[FixSkeleton(MySlimBlock, bool)](Sandbox.Game.Entities.MyCubeGrid@FixSkeleton)||
|[FixTargetCube(out Vector3I, Vector3)](Sandbox.Game.Entities.MyCubeGrid@FixTargetCube)|Iterate over all the neighbors of the cube and return when one of them exists.|
|[FixTargetCubeLite(out Vector3I, Vector3D)](Sandbox.Game.Entities.MyCubeGrid@FixTargetCubeLite)||
|[GetBiggestGridInGroup()](Sandbox.Game.Entities.MyCubeGrid@GetBiggestGridInGroup)|Returns biggest grid in physical group by AABB volume|
|[GetBlocks()](Sandbox.Game.Entities.MyCubeGrid@GetBlocks)||
|[GetBlocksForTool(ref BoundingSphereD, HashSet<MySlimBlock>)](Sandbox.Game.Entities.MyCubeGrid@GetBlocksForTool)||
|[GetBlocksInsideSphere(ref BoundingSphereD, HashSet<MySlimBlock>, bool)](Sandbox.Game.Entities.MyCubeGrid@GetBlocksInsideSphere)||
|[GetBlocksInsideSphereInternal(ref BoundingSphereD, HashSet<MySlimBlock>, GridQueryAccuracy, bool, HashSet<Vector3I>)](Sandbox.Game.Entities.MyCubeGrid@GetBlocksInsideSphereInternal)||
|[GetBlocksInsideSpheres(ref BoundingSphereD, ref BoundingSphereD, ref BoundingSphereD, HashSet<MySlimBlock>, HashSet<MySlimBlock>, HashSet<MySlimBlock>, bool, float, ref MatrixD)](Sandbox.Game.Entities.MyCubeGrid@GetBlocksInsideSpheres)|Optimized version where spheres are sorted from smallest to largest|
|[GetBlocksIntersectingOBB(ref BoundingBoxD, ref MatrixD, List<MySlimBlock>)](Sandbox.Game.Entities.MyCubeGrid@GetBlocksIntersectingOBB)||
|[GetClosestCorner(Vector3I, Vector3)](Sandbox.Game.Entities.MyCubeGrid@GetClosestCorner)|Returns cube corner which is closest to position|
|[GetConnectedGrids(GridLinkTypeEnum, List<MyCubeGrid>)](Sandbox.Game.Entities.MyCubeGrid@GetConnectedGrids)|Get all grids connected to this grid|
|[GetConnectedGrids(GridLinkTypeEnum, Action<MyCubeGrid>)](Sandbox.Game.Entities.MyCubeGrid@GetConnectedGrids)|Iterate over all grids connected to this grid|
|[GetCubeBlock(Vector3I)](Sandbox.Game.Entities.MyCubeGrid@GetCubeBlock)||
|[GetCurrentMass(GridLinkTypeEnum)](Sandbox.Game.Entities.MyCubeGrid@GetCurrentMass)||
|[GetCurrentMass(out float, out float, GridLinkTypeEnum)](Sandbox.Game.Entities.MyCubeGrid@GetCurrentMass)||
|[GetDebugUpdateInfo(List<DebugUpdateRecord>)](Sandbox.Game.Entities.MyCubeGrid@GetDebugUpdateInfo)||
|[GetExistingCubeForBoneDeformations(ref Vector3I, ref MyDamageInformation)](Sandbox.Game.Entities.MyCubeGrid@GetExistingCubeForBoneDeformations)||
|[GetExistingCubes(Vector3I, Vector3I, Dictionary<Vector3I, MySlimBlock>, MyDamageInformation?)](Sandbox.Game.Entities.MyCubeGrid@GetExistingCubes)||
|[GetFatBlockCount<T>()](Sandbox.Game.Entities.MyCubeGrid@GetFatBlockCount{T})||
|[GetFatBlocks()](Sandbox.Game.Entities.MyCubeGrid@GetFatBlocks)||
|[GetFatBlocks<T>()](Sandbox.Game.Entities.MyCubeGrid@GetFatBlocks{T})||
|[GetFirstBlockOfType<T>()](Sandbox.Game.Entities.MyCubeGrid@GetFirstBlockOfType{T})||
|[GetGridGroup(GridLinkTypeEnum)](Sandbox.Game.Entities.MyCubeGrid@GetGridGroup)||
|[GetIntersectionWithLine(ref LineD, out MyIntersectionResultLineTriangleEx?, IntersectionFlags)](Sandbox.Game.Entities.MyCubeGrid@GetIntersectionWithLine)||
|[GetIntersectionWithLine(ref LineD, ref MyCubeGridHitInfo, IntersectionFlags)](Sandbox.Game.Entities.MyCubeGrid@GetIntersectionWithLine)||
|[GetIntersectionWithSphere(ref BoundingSphereD)](Sandbox.Game.Entities.MyCubeGrid@GetIntersectionWithSphere)||
|[GetLineIntersectionExactAll(ref LineD, out double, out MySlimBlock)](Sandbox.Game.Entities.MyCubeGrid@GetLineIntersectionExactAll)|Returns closest line (in world space) intersection with all cubes.|
|[GetLineIntersectionExactGrid(ref LineD, ref Vector3I, ref double)](Sandbox.Game.Entities.MyCubeGrid@GetLineIntersectionExactGrid)||
|[GetLineIntersectionExactGrid(ref LineD, ref Vector3I, ref double, HitInfo?)](Sandbox.Game.Entities.MyCubeGrid@GetLineIntersectionExactGrid)||
|[GetMaxThrustInDirection(Direction)](Sandbox.Game.Entities.MyCubeGrid@GetMaxThrustInDirection)||
|[GetObjectBuilder(bool)](Sandbox.Game.Entities.MyCubeGrid@GetObjectBuilder)||
|[GetOwnerLoginTimeSeconds()](Sandbox.Game.Entities.MyCubeGrid@GetOwnerLoginTimeSeconds)||
|[GetOwnerLogoutTimeSeconds()](Sandbox.Game.Entities.MyCubeGrid@GetOwnerLogoutTimeSeconds)||
|[GetPhysicalGroupAABB()](Sandbox.Game.Entities.MyCubeGrid@GetPhysicalGroupAABB)||
|[GetShapesFromPosition(Vector3I)](Sandbox.Game.Entities.MyCubeGrid@GetShapesFromPosition)||
|[GetTargetedBlock(Vector3D)](Sandbox.Game.Entities.MyCubeGrid@GetTargetedBlock)||
|[GetTargetedBlockLite(Vector3D)](Sandbox.Game.Entities.MyCubeGrid@GetTargetedBlockLite)||
|[GridIntegerToWorld(Vector3I)](Sandbox.Game.Entities.MyCubeGrid@GridIntegerToWorld)||
|[GridIntegerToWorld(Vector3D)](Sandbox.Game.Entities.MyCubeGrid@GridIntegerToWorld)||
|[GunShooting()](Sandbox.Game.Entities.MyCubeGrid@GunShooting)||
|[HasMainCockpit()](Sandbox.Game.Entities.MyCubeGrid@HasMainCockpit)||
|[HasMainRemoteControl()](Sandbox.Game.Entities.MyCubeGrid@HasMainRemoteControl)||
|[HasStandAloneBlocks()](Sandbox.Game.Entities.MyCubeGrid@HasStandAloneBlocks)|Returns true when grid have at least one stand alone block|
|[HierarchyUpdated(MyCubeGrid)](Sandbox.Game.Entities.MyCubeGrid@HierarchyUpdated)||
|[Init(MyObjectBuilder_EntityBase)](Sandbox.Game.Entities.MyCubeGrid@Init)||
|[InvokeDepressurizeEffect(Vector3I, Vector3I)](Sandbox.Game.Entities.MyCubeGrid@InvokeDepressurizeEffect)||
|[IsConnectedTo(MyCubeGrid, GridLinkTypeEnum)](Sandbox.Game.Entities.MyCubeGrid@IsConnectedTo)|Checks if 2 grids are connected|
|[IsDirty()](Sandbox.Game.Entities.MyCubeGrid@IsDirty)||
|[IsGizmoDrawingEnabled()](Sandbox.Game.Entities.MyCubeGrid@IsGizmoDrawingEnabled)||
|[IsInSameLogicalGroupAs(IMyCubeGrid)](Sandbox.Game.Entities.MyCubeGrid@IsInSameLogicalGroupAs)||
|[IsMainCockpit(MyTerminalBlock)](Sandbox.Game.Entities.MyCubeGrid@IsMainCockpit)||
|[IsMainRemoteControl(MyTerminalBlock)](Sandbox.Game.Entities.MyCubeGrid@IsMainRemoteControl)||
|[IsRoomAtPositionAirtight(Vector3I)](Sandbox.Game.Entities.MyCubeGrid@IsRoomAtPositionAirtight)||
|[IsSameConstructAs(IMyCubeGrid)](Sandbox.Game.Entities.MyCubeGrid@IsSameConstructAs)||
|[IsTouchingAnyNeighbor(Vector3I, Vector3I)](Sandbox.Game.Entities.MyCubeGrid@IsTouchingAnyNeighbor)||
|[JumpWithWheels(bool)](Sandbox.Game.Entities.MyCubeGrid@JumpWithWheels)||
|[LocalToGridInteger(Vector3)](Sandbox.Game.Entities.MyCubeGrid@LocalToGridInteger)||
|[LogHierarchy()](Sandbox.Game.Entities.MyCubeGrid@LogHierarchy)||
|[MarkAsTrash()](Sandbox.Game.Entities.MyCubeGrid@MarkAsTrash)||
|[MechanicalConnectionBlockAttachUpdateStatusChanged(MyMechanicalConnectionBlockBase)](Sandbox.Game.Entities.MyCubeGrid@MechanicalConnectionBlockAttachUpdateStatusChanged)||
|[MergeGrid_MergeBlock(MyCubeGrid, Vector3I, bool)](Sandbox.Game.Entities.MyCubeGrid@MergeGrid_MergeBlock)|Called from MergeBlock to initialte merge of two grids|
|[ModifyGroup(MyBlockGroup)](Sandbox.Game.Entities.MyCubeGrid@ModifyGroup)||
|[MultiplyBlockSkeleton(MySlimBlock, float, bool)](Sandbox.Game.Entities.MyCubeGrid@MultiplyBlockSkeleton)||
|[OnAddedToScene(object)](Sandbox.Game.Entities.MyCubeGrid@OnAddedToScene)||
|[OnClosedMessageBox(ResultEnum)](Sandbox.Game.Entities.MyCubeGrid@OnClosedMessageBox)||
|[OnConvertedToStationRequest()](Sandbox.Game.Entities.MyCubeGrid@OnConvertedToStationRequest)||
|[OnConvertToDynamic()](Sandbox.Game.Entities.MyCubeGrid@OnConvertToDynamic)|Conversion from Unsupported station. For generic conversion to dynamic use physics component. Sets up the Unsupported station state.|
|[OnGridPresenceUpdate(bool)](Sandbox.Game.Entities.MyCubeGrid@OnGridPresenceUpdate)||
|[OnIntegrityChanged(MySlimBlock, bool)](Sandbox.Game.Entities.MyCubeGrid@OnIntegrityChanged)||
|[OnLogHierarchy()](Sandbox.Game.Entities.MyCubeGrid@OnLogHierarchy)||
|[OnRemovedFromScene(object)](Sandbox.Game.Entities.MyCubeGrid@OnRemovedFromScene)||
|[OnReplicationEnded()](Sandbox.Game.Entities.MyCubeGrid@OnReplicationEnded)||
|[OnReplicationStarted()](Sandbox.Game.Entities.MyCubeGrid@OnReplicationStarted)||
|[OnTerminalOpened()](Sandbox.Game.Entities.MyCubeGrid@OnTerminalOpened)||
|[PasteBlocksToGrid(List<MyObjectBuilder_CubeGrid>, long, bool, List<ulong>)](Sandbox.Game.Entities.MyCubeGrid@PasteBlocksToGrid)||
|[PlayParticleBroadcast(string, bool)](Sandbox.Game.Entities.MyCubeGrid@PlayParticleBroadcast)||
|[PrepareForDraw()](Sandbox.Game.Entities.MyCubeGrid@PrepareForDraw)||
|[RaiseGridChanged()](Sandbox.Game.Entities.MyCubeGrid@RaiseGridChanged)||
|[RaisePhysicsChanged()](Sandbox.Game.Entities.MyCubeGrid@RaisePhysicsChanged)||
|[RayCastBlocks(Vector3D, Vector3D)](Sandbox.Game.Entities.MyCubeGrid@RayCastBlocks)|Obtains position of first hit block.|
|[RayCastCells(Vector3D, Vector3D, List<Vector3I>, Vector3I?, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@RayCastCells)|Obtains positions of grid cells regardless of whether these cells are taken up by blocks or not.|
|[RazeBlock(Vector3I, ulong)](Sandbox.Game.Entities.MyCubeGrid@RazeBlock)|user is used only if called on server, when called from client, sender steam id will be used|
|[RazeBlocks(ref Vector3I, ref Vector3UByte, long)](Sandbox.Game.Entities.MyCubeGrid@RazeBlocks)||
|[RazeBlocks(List<Vector3I>, long, ulong)](Sandbox.Game.Entities.MyCubeGrid@RazeBlocks)|Razes blocks (unbuild) user is used only if locally invoked, if invoked from client, sender steam id is used|
|[RazeBlocksClient(List<Vector3I>)](Sandbox.Game.Entities.MyCubeGrid@RazeBlocksClient)||
|[RazeBlocksDelayed(ref Vector3I, ref Vector3UByte, long)](Sandbox.Game.Entities.MyCubeGrid@RazeBlocksDelayed)||
|[RazeBlocksRequest(List<Vector3I>, long, ulong)](Sandbox.Game.Entities.MyCubeGrid@RazeBlocksRequest)|user is used only if locally invoked, if invoked from client, sender steam id is used|
|[RazeGeneratedBlocks(List<Vector3I>)](Sandbox.Game.Entities.MyCubeGrid@RazeGeneratedBlocks)||
|[RazeGeneratedBlocks(List<MySlimBlock>)](Sandbox.Game.Entities.MyCubeGrid@RazeGeneratedBlocks)||
|[RecalculateGravity()](Sandbox.Game.Entities.MyCubeGrid@RecalculateGravity)||
|[RecalculateOwners()](Sandbox.Game.Entities.MyCubeGrid@RecalculateOwners)||
|[ReceiveHandbrakeRequestResult(HandbrakeToggleResult, string)](Sandbox.Game.Entities.MyCubeGrid@ReceiveHandbrakeRequestResult)||
|[ReceiveParkRequestResult(HandbrakeToggleResult, string)](Sandbox.Game.Entities.MyCubeGrid@ReceiveParkRequestResult)||
|[RegisterDecoy(MyDecoy)](Sandbox.Game.Entities.MyCubeGrid@RegisterDecoy)||
|[RegisterInventory(MyCubeBlock)](Sandbox.Game.Entities.MyCubeGrid@RegisterInventory)||
|[RegisterOccupiedBlock(MyCockpit)](Sandbox.Game.Entities.MyCubeGrid@RegisterOccupiedBlock)||
|[RegisterUnsafeBlock(MyCubeBlock)](Sandbox.Game.Entities.MyCubeGrid@RegisterUnsafeBlock)||
|[RemoveBlock(MySlimBlock, bool)](Sandbox.Game.Entities.MyCubeGrid@RemoveBlock)||
|[RemoveBlocksBuiltByIDs(List<long>)](Sandbox.Game.Entities.MyCubeGrid@RemoveBlocksBuiltByIDs)|Remove all blocks from the grid built by specific player|
|[RemoveBlockWithId(MySlimBlock, bool)](Sandbox.Game.Entities.MyCubeGrid@RemoveBlockWithId)||
|[RemoveBlockWithId(Vector3I, bool)](Sandbox.Game.Entities.MyCubeGrid@RemoveBlockWithId)||
|[RemoveContainerDropComponent(long)](Sandbox.Game.Entities.MyCubeGrid@RemoveContainerDropComponent)||
|[RemoveDestroyedBlock(MySlimBlock, long)](Sandbox.Game.Entities.MyCubeGrid@RemoveDestroyedBlock)|Removes destroyed block, applies damage and deformation to close blocks Won't update physics!|
|[RemoveNPCBlocks()](Sandbox.Game.Entities.MyCubeGrid@RemoveNPCBlocks)||
|[RequestConversionToShip(Action)](Sandbox.Game.Entities.MyCubeGrid@RequestConversionToShip)||
|[RequestConversionToStation()](Sandbox.Game.Entities.MyCubeGrid@RequestConversionToStation)||
|[RequestFillStockpile(Vector3I, MyInventory)](Sandbox.Game.Entities.MyCubeGrid@RequestFillStockpile)||
|[RequestJump(Vector3D, long, float, long?)](Sandbox.Game.Entities.MyCubeGrid@RequestJump)||
|[ResetBlockSkeleton(MySlimBlock, bool)](Sandbox.Game.Entities.MyCubeGrid@ResetBlockSkeleton)||
|[ResetControls()](Sandbox.Game.Entities.MyCubeGrid@ResetControls)||
|[Schedule(UpdateQueue, Action, int, bool)](Sandbox.Game.Entities.MyCubeGrid@Schedule)||
|[SendAbortJump()](Sandbox.Game.Entities.MyCubeGrid@SendAbortJump)||
|[SendGridCloseRequest()](Sandbox.Game.Entities.MyCubeGrid@SendGridCloseRequest)|Use only for cut request|
|[SendIntegrityChanged(MySlimBlock, MyIntegrityChangeEnum, long)](Sandbox.Game.Entities.MyCubeGrid@SendIntegrityChanged)||
|[SendReflectorState(MyMultipleEnabledEnum)](Sandbox.Game.Entities.MyCubeGrid@SendReflectorState)||
|[SendRemovedBlocks()](Sandbox.Game.Entities.MyCubeGrid@SendRemovedBlocks)||
|[SendRemovedBlocksWithIds()](Sandbox.Game.Entities.MyCubeGrid@SendRemovedBlocksWithIds)||
|[SendStockpileChanged(MySlimBlock, List<MyStockpileItem>)](Sandbox.Game.Entities.MyCubeGrid@SendStockpileChanged)||
|[SerializeControls(BitStream)](Sandbox.Game.Entities.MyCubeGrid@SerializeControls)||
|[SetBlockDirty(MySlimBlock)](Sandbox.Game.Entities.MyCubeGrid@SetBlockDirty)||
|[SetCubeDirty(Vector3I)](Sandbox.Game.Entities.MyCubeGrid@SetCubeDirty)||
|[SetMainCockpit(MyTerminalBlock)](Sandbox.Game.Entities.MyCubeGrid@SetMainCockpit)||
|[SetMainRemoteControl(MyTerminalBlock)](Sandbox.Game.Entities.MyCubeGrid@SetMainRemoteControl)||
|[SetSolarOcclusion(bool)](Sandbox.Game.Entities.MyCubeGrid@SetSolarOcclusion)||
|[SkinBlocks(Vector3I, Vector3I, Vector3?, MyStringHash?, bool)](Sandbox.Game.Entities.MyCubeGrid@SkinBlocks)|Skin block in area. Verry slow.|
|[SkinGrid(Vector3, MyStringHash, bool, bool, bool)](Sandbox.Game.Entities.MyCubeGrid@SkinGrid)||
|[SplitByPlane(PlaneD)](Sandbox.Game.Entities.MyCubeGrid@SplitByPlane)||
|[StartReplay()](Sandbox.Game.Entities.MyCubeGrid@StartReplay)||
|[StopReplay()](Sandbox.Game.Entities.MyCubeGrid@StopReplay)||
|[StopSmoke()](Sandbox.Game.Entities.MyCubeGrid@StopSmoke)||
|[SwitchPower()](Sandbox.Game.Entities.MyCubeGrid@SwitchPower)||
|[TargetingAddId(long)](Sandbox.Game.Entities.MyCubeGrid@TargetingAddId)||
|[TargetingCanAttackGrid(long)](Sandbox.Game.Entities.MyCubeGrid@TargetingCanAttackGrid)||
|[TargetingRemoveId(long)](Sandbox.Game.Entities.MyCubeGrid@TargetingRemoveId)||
|[TargetingSetWhitelist(bool)](Sandbox.Game.Entities.MyCubeGrid@TargetingSetWhitelist)||
|[Teleport(MatrixD, object, bool)](Sandbox.Game.Entities.MyCubeGrid@Teleport)||
|[ToggleHandbrakeRequest()](Sandbox.Game.Entities.MyCubeGrid@ToggleHandbrakeRequest)||
|[ToggleParkStateRequest()](Sandbox.Game.Entities.MyCubeGrid@ToggleParkStateRequest)||
|[ToString()](Sandbox.Game.Entities.MyCubeGrid@ToString)||
|[TransferBlockLimitsBuiltByID(long, MyBlockLimits, MyBlockLimits)](Sandbox.Game.Entities.MyCubeGrid@TransferBlockLimitsBuiltByID)||
|[TransferBlocksBuiltByID(long, long)](Sandbox.Game.Entities.MyCubeGrid@TransferBlocksBuiltByID)|Transfer all blocks built by a specific player to another player|
|[TransferBlocksBuiltByIDClient(long, long)](Sandbox.Game.Entities.MyCubeGrid@TransferBlocksBuiltByIDClient)||
|[TryGetCube(Vector3I, out MyCube)](Sandbox.Game.Entities.MyCubeGrid@TryGetCube)||
|[UnregisterDecoy(MyDecoy)](Sandbox.Game.Entities.MyCubeGrid@UnregisterDecoy)||
|[UnregisterInventory(MyCubeBlock)](Sandbox.Game.Entities.MyCubeGrid@UnregisterInventory)||
|[UnregisterOccupiedBlock(MyCockpit)](Sandbox.Game.Entities.MyCubeGrid@UnregisterOccupiedBlock)||
|[UnregisterUnsafeBlock(MyCubeBlock)](Sandbox.Game.Entities.MyCubeGrid@UnregisterUnsafeBlock)||
|[UpdateAfterSimulation()](Sandbox.Game.Entities.MyCubeGrid@UpdateAfterSimulation)||
|[UpdateAfterSimulation10()](Sandbox.Game.Entities.MyCubeGrid@UpdateAfterSimulation10)||
|[UpdateAfterSimulation100()](Sandbox.Game.Entities.MyCubeGrid@UpdateAfterSimulation100)||
|[UpdateAfterSimulationParallel()](Sandbox.Game.Entities.MyCubeGrid@UpdateAfterSimulationParallel)||
|[UpdateBeforeSimulation()](Sandbox.Game.Entities.MyCubeGrid@UpdateBeforeSimulation)||
|[UpdateBeforeSimulation10()](Sandbox.Game.Entities.MyCubeGrid@UpdateBeforeSimulation10)||
|[UpdateBeforeSimulation100()](Sandbox.Game.Entities.MyCubeGrid@UpdateBeforeSimulation100)||
|[UpdateBeforeSimulationParallel()](Sandbox.Game.Entities.MyCubeGrid@UpdateBeforeSimulationParallel)||
|[UpdateBlockNeighbours(MySlimBlock)](Sandbox.Game.Entities.MyCubeGrid@UpdateBlockNeighbours)||
|[UpdateDirty(Action, bool)](Sandbox.Game.Entities.MyCubeGrid@UpdateDirty)||
|[UpdateDirtyInternal()](Sandbox.Game.Entities.MyCubeGrid@UpdateDirtyInternal)||
|[UpdateInstanceData()](Sandbox.Game.Entities.MyCubeGrid@UpdateInstanceData)||
|[UpdateOnceBeforeFrame()](Sandbox.Game.Entities.MyCubeGrid@UpdateOnceBeforeFrame)||
|[UpdateOwnership(long, bool)](Sandbox.Game.Entities.MyCubeGrid@UpdateOwnership)||
|[UpdateParticleContactPoint(long, ref Vector3, ref Vector3, ref Vector3, float, float, ContactPointDataTypes)](Sandbox.Game.Entities.MyCubeGrid@UpdateParticleContactPoint)||
|[UpdatePredictionFlag()](Sandbox.Game.Entities.MyCubeGrid@UpdatePredictionFlag)||
|[UpdateTimeOnClients(int)](Sandbox.Game.Entities.MyCubeGrid@UpdateTimeOnClients)||
|[WillRemoveBlockSplitGrid(MySlimBlock)](Sandbox.Game.Entities.MyCubeGrid@WillRemoveBlockSplitGrid)||
|[WorldToGridInteger(Vector3D)](Sandbox.Game.Entities.MyCubeGrid@WorldToGridInteger)||
|[WorldToGridScaledLocal(Vector3D)](Sandbox.Game.Entities.MyCubeGrid@WorldToGridScaledLocal)||
|[AddBlock(MyObjectBuilder_CubeBlock, bool)](VRage.Game.ModAPI.IMyCubeGrid@AddBlock)|Add a cubeblock to the grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[AddDebugRenderComponent(MyDebugRenderComponentBase)](VRage.Game.Entity.MyEntity@AddDebugRenderComponent)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[AddToGamePruningStructure()](VRage.Game.Entity.MyEntity@AddToGamePruningStructure)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[AfterPaste()](VRage.Game.Entity.MyEntity@AfterPaste)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ApplyDeformation(float, float, float, Vector3, Vector3, MyStringHash, out int, float, float, long)](VRage.Game.ModAPI.IMyCubeGrid@ApplyDeformation)|_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[ApplyDestructionDeformation(IMySlimBlock)](VRage.Game.ModAPI.IMyCubeGrid@ApplyDestructionDeformation)|Applies random deformation to given block<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[ApplyLastControls()](VRage.Game.Entity.MyEntity@ApplyLastControls)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[BeforePaste()](VRage.Game.Entity.MyEntity@BeforePaste)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[BeforeSave()](VRage.ModAPI.IMyEntity@BeforeSave)|Called before method GetObjectBuilder, when saving sector<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[BeforeSave()](VRage.Game.Entity.MyEntity@BeforeSave)|Called before method GetObjectBuilder, when saving sector<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[CalculateMergeTransform(IMyCubeGrid, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@CalculateMergeTransform)|Transformation matrix that has to be applied to grid blocks to correctly merge it used because ie. ships can be turned 90 degrees along X axis when being merged<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[CanAddCube(Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@CanAddCube)|Tests if a cubeblock can be added at the specific location<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[CanAddCubes(Vector3I, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@CanAddCubes)|Test if the range of positions are not occupied by any blocks<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[CanMergeCubes(IMyCubeGrid, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@CanMergeCubes)|Determines if merge between grids is possible with given offset<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[ChangeGridOwnership(long, MyOwnershipShareModeEnum)](VRage.Game.ModAPI.IMyCubeGrid@ChangeGridOwnership)|Changes owner of all blocks on grid Call only on server!<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[ClearDebugRenderComponents()](VRage.Game.Entity.MyEntity@ClearDebugRenderComponents)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ClearSymmetries()](VRage.Game.ModAPI.IMyCubeGrid@ClearSymmetries)|Clears symmetry planes<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[Close()](VRage.ModAPI.IMyEntity@Close)|This method marks this entity for close which means, that Close will be called after all entities are updated<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Close()](VRage.Game.Entity.MyEntity@Close)|This method marks this entity for close which means, that Close will be called after all entities are updated<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[ColorBlocks(Vector3I, Vector3I, Vector3)](VRage.Game.ModAPI.IMyCubeGrid@ColorBlocks)|Sets given color mask to range of blocks<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[ContainsDebugRenderComponent(Type)](VRage.Game.Entity.MyEntity@ContainsDebugRenderComponent)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[CreateSync()](VRage.Game.Entity.MyEntity@CreateSync)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[CubeExists(Vector3I)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@CubeExists)|Returns true if there is any block occupying given position<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
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
|[FixTargetCube(out Vector3I, Vector3)](VRage.Game.ModAPI.IMyCubeGrid@FixTargetCube)|Clamps fractional grid position to nearest cell (prefers neighboring occupied cell before empty)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[GetBaseEntity()](VRage.Game.Entity.MyEntity@GetBaseEntity)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetBlocks(List<IMySlimBlock>, Func<IMySlimBlock, bool>)](VRage.Game.ModAPI.IMyCubeGrid@GetBlocks)|Returns blocks in grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[GetBlocksInsideSphere(ref BoundingSphereD)](VRage.Game.ModAPI.IMyCubeGrid@GetBlocksInsideSphere)|Returns blocks intersects with given sphere (world space)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[GetChildren(List<IMyEntity>, Func<IMyEntity, bool>)](VRage.ModAPI.IMyEntity@GetChildren)|Gets children of entity. Child - entity, who's [Parent](VRage.ModAPI.IMyEntity@Parent) is this entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetClosestCorner(Vector3I, Vector3)](VRage.Game.ModAPI.IMyCubeGrid@GetClosestCorner)|Gets position of closest cell corner<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[GetCubeBlock(Vector3I)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GetCubeBlock)|Get cube block at given position<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[GetCubeBlock(Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@GetCubeBlock)|Get cube block at given position<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[GetDiffuseColor()](VRage.ModAPI.IMyEntity@GetDiffuseColor)|Gets render diffuse color<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndBoundingSphere)|Distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. (in meters)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndBoundingSphere()](VRage.Game.Entity.MyEntity@GetDistanceBetweenCameraAndBoundingSphere)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetDistanceBetweenCameraAndPosition()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndPosition)|Distance from camera to position of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndPosition()](VRage.Game.Entity.MyEntity@GetDistanceBetweenCameraAndPosition)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetDistanceBetweenPlayerPositionAndBoundingSphere()](VRage.Game.Entity.MyEntity@GetDistanceBetweenPlayerPositionAndBoundingSphere)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetFatBlocks<T>()](VRage.Game.ModAPI.IMyCubeGrid@GetFatBlocks{T})|_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[GetFriendlyName()](VRage.ModAPI.IMyEntity@GetFriendlyName)|Not used. Actually not a friendly name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetFriendlyName()](VRage.Game.Entity.MyEntity@GetFriendlyName)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[GetGridGroup(GridLinkTypeEnum)](VRage.Game.ModAPI.IMyCubeGrid@GetGridGroup)|Gets grid group of grids connected by provided link type<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
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
|[GetLineIntersectionExactAll(ref LineD, out double, out IMySlimBlock)](VRage.Game.ModAPI.IMyCubeGrid@GetLineIntersectionExactAll)|Returns point of intersection with line<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[GetLineIntersectionExactGrid(ref LineD, ref Vector3I, ref double)](VRage.Game.ModAPI.IMyCubeGrid@GetLineIntersectionExactGrid)|Same as GetLineIntersectionExactAll just without intersected block<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[GetMaxThrustInDirection(Direction)](VRage.Game.ModAPI.IMyCubeGrid@GetMaxThrustInDirection)|_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
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
|[GridIntegerToWorld(Vector3I)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@GridIntegerToWorld)|Converts grid coordinates to world space<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[Init(MyObjectBuilder_EntityBase)](VRage.Game.Entity.MyEntity@Init)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Init(StringBuilder, string, MyEntity, float?, string)](VRage.Game.Entity.MyEntity@Init)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[InitComponents()](VRage.Game.Entity.MyEntity@InitComponents)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[InitComponentsForTesting()](VRage.Game.Entity.MyEntity@InitComponentsForTesting)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[InvokeDepressurizeEffect(Vector3I, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@InvokeDepressurizeEffect)|Invokes de-pressurize effect on clients<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[IsInSameLogicalGroupAs(IMyCubeGrid)](VRage.Game.ModAPI.IMyCubeGrid@IsInSameLogicalGroupAs)|Determines whether this grid is in the same logical group as the other, meaning they're connected either mechanically or via blocks like connectors. Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way.<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[IsRoomAtPositionAirtight(Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@IsRoomAtPositionAirtight)|Is room at specified position airtight<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[IsSameConstructAs(IMyCubeGrid)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@IsSameConstructAs)|Determines whether this grid is [Mechanical](VRage.Game.ModAPI.GridLinkTypeEnum@Mechanical) connected to the other. This is any grid connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.<br /><br />Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[IsSameConstructAs(IMyCubeGrid)](VRage.Game.ModAPI.IMyCubeGrid@IsSameConstructAs)|Determines whether this grid is mechanically connected to the other. This is any grid connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.<br /><br />Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[IsTouchingAnyNeighbor(Vector3I, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@IsTouchingAnyNeighbor)|Finds out if given area has any neighboring block Checking only cube sides. Example: for vectors Min (0,0,0) and Max (10,10,10), Space (1,1,1)-(9,9,9) won't be checked<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[IsVisible()](VRage.ModAPI.IMyEntity@IsVisible)|Gets or result of function [IsVisible()](VRage.Game.Components.MyRenderComponentBase@IsVisible) . Function inside check for [IsVisible(IMyEntity)](VRage.ModAPI.IMyEntities@IsVisible)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MergeGrid_MergeBlock(IMyCubeGrid, Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@MergeGrid_MergeBlock)|Merge used by merge blocks<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[OnAddedToScene(object)](VRage.ModAPI.IMyEntity@OnAddedToScene)|Adds entity to scene: init updates, render physics<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnAddedToScene(object)](VRage.Game.Entity.MyEntity@OnAddedToScene)|Called when [activated] which for entity means that was added to scene.<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnRemovedFromScene(object)](VRage.ModAPI.IMyEntity@OnRemovedFromScene)|Remove entity and it's children from scene: stops updates and render, deactivates physics. Usually called when entity deleted<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnRemovedFromScene(object)](VRage.Game.Entity.MyEntity@OnRemovedFromScene)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnReplicationEnded()](VRage.Game.Entity.MyEntity@OnReplicationEnded)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[OnReplicationStarted()](VRage.Game.Entity.MyEntity@OnReplicationStarted)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[Pin()](VRage.Game.Entity.MyEntity@Pin)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[PrepareForDraw()](VRage.Game.Entity.MyEntity@PrepareForDraw)|Method is called defacto from Update, preparation fo Draw<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[RaisePhysicsChanged()](VRage.Game.Entity.MyEntity@RaisePhysicsChanged)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[RayCastBlocks(Vector3D, Vector3D)](VRage.Game.ModAPI.IMyCubeGrid@RayCastBlocks)|Obtains first block position intersected with line.<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[RayCastCells(Vector3D, Vector3D, List<Vector3I>, Vector3I?, bool)](VRage.Game.ModAPI.IMyCubeGrid@RayCastCells)|Obtains positions of grid cellsof whether these cells are taken up by blocks or not.<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[RazeBlock(Vector3I)](VRage.Game.ModAPI.IMyCubeGrid@RazeBlock)|Remove block at given position<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[RazeBlocks(ref Vector3I, ref Vector3UByte)](VRage.Game.ModAPI.IMyCubeGrid@RazeBlocks)|Remove blocks in given area<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[RazeBlocks(List<Vector3I>)](VRage.Game.ModAPI.IMyCubeGrid@RazeBlocks)|Remove blocks at given positions<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[RefreshModels(string, string)](VRage.Game.Entity.MyEntity@RefreshModels)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[RemoveBlock(IMySlimBlock, bool)](VRage.Game.ModAPI.IMyCubeGrid@RemoveBlock)|Removes given block<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[RemoveDebugRenderComponent(Type)](VRage.Game.Entity.MyEntity@RemoveDebugRenderComponent)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[RemoveDebugRenderComponent(MyDebugRenderComponentBase)](VRage.Game.Entity.MyEntity@RemoveDebugRenderComponent)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[RemoveDestroyedBlock(IMySlimBlock)](VRage.Game.ModAPI.IMyCubeGrid@RemoveDestroyedBlock)|Removes block and deformates neighboring blocks<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
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
|[SkinBlocks(Vector3I, Vector3I, Vector3?, string)](VRage.Game.ModAPI.IMyCubeGrid@SkinBlocks)|Sets given skin to range of blocks<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[Split(List<IMySlimBlock>, bool)](VRage.Game.ModAPI.IMyCubeGrid@Split)|Split grid<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[SplitByPlane(PlaneD)](VRage.Game.ModAPI.IMyCubeGrid@SplitByPlane)|Split grid along a plane<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
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
|[UpdateAfterSimulationParallel()](Sandbox.Game.Entities.IMyParallelUpdateable@UpdateAfterSimulationParallel)|_Inherited from [IMyParallelUpdateable](Sandbox.Game.Entities.IMyParallelUpdateable)_|
|[UpdateBeforeSimulation()](VRage.Game.Entity.MyEntity@UpdateBeforeSimulation)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateBeforeSimulation10()](VRage.Game.Entity.MyEntity@UpdateBeforeSimulation10)|Called each 10th frame if registered for update10<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateBeforeSimulation100()](VRage.Game.Entity.MyEntity@UpdateBeforeSimulation100)|Called each 100th frame if registered for update100<br /><br />_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateBeforeSimulationParallel()](Sandbox.Game.Entities.IMyParallelUpdateable@UpdateBeforeSimulationParallel)|_Inherited from [IMyParallelUpdateable](Sandbox.Game.Entities.IMyParallelUpdateable)_|
|[UpdateBlockNeighbours(IMySlimBlock)](VRage.Game.ModAPI.IMyCubeGrid@UpdateBlockNeighbours)|Refreshes block neighbors (checks connections)<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[UpdateGamePruningStructure()](VRage.ModAPI.IMyEntity@UpdateGamePruningStructure)|Update position of entity in MyGamePruningStructure. Calls:```csharp<br />MyGamePruningStructure.Move(this)<br /><br />```<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[UpdateGamePruningStructure()](VRage.Game.Entity.MyEntity@UpdateGamePruningStructure)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateOnceBeforeFrame()](VRage.Game.Entity.MyEntity@UpdateOnceBeforeFrame)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdateOwnership(long, bool)](VRage.Game.ModAPI.IMyCubeGrid@UpdateOwnership)|Called when functional block lost or gained owner. Triggers, grid ownership recalculation<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[UpdateSoundContactPoint(long, Vector3, Vector3, Vector3, float)](VRage.Game.Entity.MyEntity@UpdateSoundContactPoint)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[UpdatingStopped()](VRage.Game.Entity.MyEntity@UpdatingStopped)|_Inherited from [MyEntity](VRage.Game.Entity.MyEntity)_|
|[WillRemoveBlockSplitGrid(IMySlimBlock)](VRage.Game.ModAPI.IMyCubeGrid@WillRemoveBlockSplitGrid)|Checks if removing a block will cause the grid to split<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[WorldToGridInteger(Vector3D)](VRage.Game.ModAPI.Ingame.IMyCubeGrid@WorldToGridInteger)|Converts world coordinates to grid space cell coordinates<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)_|
|[AddToGamePruningStructure()](VRage.ModAPI.IMyEntity@AddToGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnConvertToDynamic()](VRage.Game.ModAPI.IMyCubeGrid@OnConvertToDynamic)|_**Obsolete:** Use IMyCubeGrid.Static instead._<br /><br />Converts station to ship<br /><br />_Inherited from [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)_|
|[RemoveFromGamePruningStructure()](VRage.ModAPI.IMyEntity@RemoveFromGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetTextureChangesForSubparts(Dictionary<string, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|_**Obsolete**_<br /><br />This calling is obsolete, use another version.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

**Inheritance:**   [MyEntity](VRage.Game.Entity.MyEntity)

**Implements:**  
* [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)  
* [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)  
* [IMyEntity](VRage.ModAPI.IMyEntity)  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)  
* IMyGridConnectivityTest <sub>prohibited</sub>  
* [IMyParallelUpdateable](Sandbox.Game.Entities.IMyParallelUpdateable)  
* [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)  
* IMySyncedEntity <sub>prohibited</sub>

