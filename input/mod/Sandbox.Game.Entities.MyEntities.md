**Assembly:** Sandbox.Game.dll

```csharp
public abstract sealed class MyEntities
```

## Fields

|Member|Description|
|---|---|
|[static CloseAllowed](Sandbox.Game.Entities.MyEntities@CloseAllowed)||
|[static DetectorsHidden](Sandbox.Game.Entities.MyEntities@DetectorsHidden)||
|[static DetectorsSelectable](Sandbox.Game.Entities.MyEntities@DetectorsSelectable)||
|[static EntityCloseLock](Sandbox.Game.Entities.MyEntities@EntityCloseLock)||
|[static EntityMarkForCloseLock](Sandbox.Game.Entities.MyEntities@EntityMarkForCloseLock)||
|[static IgnoreMemoryLimits](Sandbox.Game.Entities.MyEntities@IgnoreMemoryLimits)||
|[static IsClosingAll](Sandbox.Game.Entities.MyEntities@IsClosingAll)||
|[static m_entityNameDictionary](Sandbox.Game.Entities.MyEntities@m_entityNameDictionary)||
|[static Orchestrator](Sandbox.Game.Entities.MyEntities@Orchestrator)||
|[static ParticleEffectsHidden](Sandbox.Game.Entities.MyEntities@ParticleEffectsHidden)||
|[static ParticleEffectsSelectable](Sandbox.Game.Entities.MyEntities@ParticleEffectsSelectable)||
|[static SafeAreasHidden](Sandbox.Game.Entities.MyEntities@SafeAreasHidden)||
|[static SafeAreasSelectable](Sandbox.Game.Entities.MyEntities@SafeAreasSelectable)||
|[static UnloadDataLock](Sandbox.Game.Entities.MyEntities@UnloadDataLock)||
|[static UpdateInProgress](Sandbox.Game.Entities.MyEntities@UpdateInProgress)||

## Events

|Member|Description|
|---|---|
|[static OnCloseAll](Sandbox.Game.Entities.MyEntities@OnCloseAll)||
|[static OnEntityAdd](Sandbox.Game.Entities.MyEntities@OnEntityAdd)||
|[static OnEntityCreate](Sandbox.Game.Entities.MyEntities@OnEntityCreate)||
|[static OnEntityDelete](Sandbox.Game.Entities.MyEntities@OnEntityDelete)||
|[static OnEntityNameSet](Sandbox.Game.Entities.MyEntities@OnEntityNameSet)||
|[static OnEntityRemove](Sandbox.Game.Entities.MyEntities@OnEntityRemove)||

## Properties

|Member|Description|
|---|---|
|[static IsAsyncUpdateInProgress](Sandbox.Game.Entities.MyEntities@IsAsyncUpdateInProgress)||
|[static IsLoaded](Sandbox.Game.Entities.MyEntities@IsLoaded)||
|[static MemoryLimitAddFailure](Sandbox.Game.Entities.MyEntities@MemoryLimitAddFailure)||

## Methods

|Member|Description|
|---|---|
|[static Add(MyEntity, bool)](Sandbox.Game.Entities.MyEntities@Add)||
|[static AddRenderObjectToMap(uint, IMyEntity)](Sandbox.Game.Entities.MyEntities@AddRenderObjectToMap)||
|[static CallAsync(MyEntity, Action<MyEntity>)](Sandbox.Game.Entities.MyEntities@CallAsync)||
|[static CallAsync(Action)](Sandbox.Game.Entities.MyEntities@CallAsync)||
|[static Close(MyEntity)](Sandbox.Game.Entities.MyEntities@Close)||
|[static CloseAll()](Sandbox.Game.Entities.MyEntities@CloseAll)||
|[static CreateAsync(MyObjectBuilder_EntityBase, bool, Action<MyEntity>)](Sandbox.Game.Entities.MyEntities@CreateAsync)|Creates object asynchronously and adds it into scene. DoneHandler is invoked from update thread when the object is added into scene.|
|[static CreateEntity(MyDefinitionId, bool, bool, Vector3?, Vector3?, Vector3?)](Sandbox.Game.Entities.MyEntities@CreateEntity)||
|[static CreateEntityAndAdd(MyDefinitionId, bool, bool, Vector3?, Vector3?, Vector3?)](Sandbox.Game.Entities.MyEntities@CreateEntityAndAdd)|This method will try to retrieve a definition of components container of the entity and create the type of the entity.|
|[static CreateFromComponentContainerDefinitionAndAdd(MyDefinitionId, bool, bool)](Sandbox.Game.Entities.MyEntities@CreateFromComponentContainerDefinitionAndAdd)||
|[static CreateFromObjectBuilder(MyObjectBuilder_EntityBase, bool)](Sandbox.Game.Entities.MyEntities@CreateFromObjectBuilder)||
|[static CreateFromObjectBuilderAndAdd(MyObjectBuilder_EntityBase, bool)](Sandbox.Game.Entities.MyEntities@CreateFromObjectBuilderAndAdd)||
|[static CreateFromObjectBuilderNoinit(MyObjectBuilder_EntityBase)](Sandbox.Game.Entities.MyEntities@CreateFromObjectBuilderNoinit)||
|[static CreateFromObjectBuilderParallel(MyObjectBuilder_EntityBase, bool, Action<MyEntity>, MyEntity, MyEntity, Vector3D?, bool, bool)](Sandbox.Game.Entities.MyEntities@CreateFromObjectBuilderParallel)|Create and asynchronously initialize and entity.|
|[static DebugDraw()](Sandbox.Game.Entities.MyEntities@DebugDraw)||
|[static DebugDrawGridStatistics()](Sandbox.Game.Entities.MyEntities@DebugDrawGridStatistics)||
|[static DebugDrawStatistics()](Sandbox.Game.Entities.MyEntities@DebugDrawStatistics)||
|[static DeleteRememberedEntities()](Sandbox.Game.Entities.MyEntities@DeleteRememberedEntities)||
|[static Draw()](Sandbox.Game.Entities.MyEntities@Draw)||
|[static EnableEntityBoundingBoxDraw(MyEntity, bool, Vector4?, float, Vector3?, MyStringId?, bool)](Sandbox.Game.Entities.MyEntities@EnableEntityBoundingBoxDraw)||
|[static EntityExists(long)](Sandbox.Game.Entities.MyEntities@EntityExists)||
|[static EntityExists(string)](Sandbox.Game.Entities.MyEntities@EntityExists)||
|[static EntityNameExists(string)](Sandbox.Game.Entities.MyEntities@EntityNameExists)||
|[static Exist(MyEntity)](Sandbox.Game.Entities.MyEntities@Exist)|Checks if entity exists in scene already|
|[static FindFreePlace(ref MatrixD, Vector3, float, int, int, float, bool)](Sandbox.Game.Entities.MyEntities@FindFreePlace)|Finds free place for objects defined by position and radius. StepSize is how fast to increase radius, 0.5f means by half radius.|
|[static FindFreePlaceCustom(Vector3D, float, int, int, float, float, MyEntity, bool)](Sandbox.Game.Entities.MyEntities@FindFreePlaceCustom)||
|[static ForceCloseEntityOnClients(long)](Sandbox.Game.Entities.MyEntities@ForceCloseEntityOnClients)||
|[static GetElementsInBox(ref BoundingBoxD, List<MyEntity>)](Sandbox.Game.Entities.MyEntities@GetElementsInBox)||
|[static GetEntities()](Sandbox.Game.Entities.MyEntities@GetEntities)||
|[static GetEntitiesInAABB(ref BoundingBox)](Sandbox.Game.Entities.MyEntities@GetEntitiesInAABB)|Get all rigid body elements touching a bounding box. Clear() the result list after you're done with it!|
|[static GetEntitiesInAABB(ref BoundingBoxD, bool)](Sandbox.Game.Entities.MyEntities@GetEntitiesInAABB)|Returns list of entities that intersects with BoundingBox. If you are modder, you better use IMyEntities method. It is safe to use.|
|[static GetEntitiesInOBB(ref MyOrientedBoundingBoxD)](Sandbox.Game.Entities.MyEntities@GetEntitiesInOBB)|Returns list of entities that intersects with oriented bounding box. If you are modder, you better use IMyEntities method. It is safe to use.|
|[static GetEntitiesInSphere(ref BoundingSphereD)](Sandbox.Game.Entities.MyEntities@GetEntitiesInSphere)|Returns list of entities that intersects with boundingSphere. If you are modder, you better use IMyEntities method. It is safe to use.|
|[static GetEntityById(long, bool)](Sandbox.Game.Entities.MyEntities@GetEntityById)||
|[static GetEntityByIdOrDefault(long, MyEntity, bool)](Sandbox.Game.Entities.MyEntities@GetEntityByIdOrDefault)||
|[static GetEntityByIdOrDefault<T>(long, T, bool)](Sandbox.Game.Entities.MyEntities@GetEntityByIdOrDefault{T})||
|[static GetEntityByName(string)](Sandbox.Game.Entities.MyEntities@GetEntityByName)||
|[static GetEntityFromRenderObjectID(uint)](Sandbox.Game.Entities.MyEntities@GetEntityFromRenderObjectID)||
|[static GetInflatedPlayerBoundingBox(ref BoundingBoxD, float)](Sandbox.Game.Entities.MyEntities@GetInflatedPlayerBoundingBox)||
|[static GetIntersectionWithLine(ref LineD, MyEntity, MyEntity, bool, bool, bool, IntersectionFlags, float, bool, bool, bool, bool)](Sandbox.Game.Entities.MyEntities@GetIntersectionWithLine)||
|[static GetIntersectionWithSphere(ref BoundingSphereD)](Sandbox.Game.Entities.MyEntities@GetIntersectionWithSphere)||
|[static GetIntersectionWithSphere(ref BoundingSphereD, MyEntity, MyEntity)](Sandbox.Game.Entities.MyEntities@GetIntersectionWithSphere)||
|[static GetIntersectionWithSphere(ref BoundingSphereD, MyEntity, MyEntity, bool, bool, ref List<MyEntity>)](Sandbox.Game.Entities.MyEntities@GetIntersectionWithSphere)||
|[static GetIntersectionWithSphere(ref BoundingSphereD, MyEntity, MyEntity, bool, bool, bool, bool, bool)](Sandbox.Game.Entities.MyEntities@GetIntersectionWithSphere)||
|[static GetTopMostEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)](Sandbox.Game.Entities.MyEntities@GetTopMostEntitiesInBox)||
|[static GetTopMostEntitiesInSphere(ref BoundingSphereD)](Sandbox.Game.Entities.MyEntities@GetTopMostEntitiesInSphere)|Returns list of entities that intersects with oriented bounding box. If you are modder, you better use IMyEntities method. It is safe to use.|
|[static HasEntitiesToDelete()](Sandbox.Game.Entities.MyEntities@HasEntitiesToDelete)||
|[static InitAsync(MyEntity, MyObjectBuilder_EntityBase, bool, Action<MyEntity>, double, bool)](Sandbox.Game.Entities.MyEntities@InitAsync)||
|[static InitEntity(MyObjectBuilder_EntityBase, ref MyEntity, bool)](Sandbox.Game.Entities.MyEntities@InitEntity)||
|[static InvokeLater(Action, string)](Sandbox.Game.Entities.MyEntities@InvokeLater)||
|[static IsCloseAllowed()](Sandbox.Game.Entities.MyEntities@IsCloseAllowed)||
|[static IsEntityIdValid(long)](Sandbox.Game.Entities.MyEntities@IsEntityIdValid)||
|[static IsInsideVoxel(Vector3D, Vector3D, out Vector3D)](Sandbox.Game.Entities.MyEntities@IsInsideVoxel)||
|[static IsNameExists(MyEntity, string)](Sandbox.Game.Entities.MyEntities@IsNameExists)||
|[static IsRaycastBlocked(Vector3D, Vector3D)](Sandbox.Game.Entities.MyEntities@IsRaycastBlocked)||
|[static IsShapePenetrating(HkShape, ref Vector3D, ref Quaternion, int, MyEntity, bool)](Sandbox.Game.Entities.MyEntities@IsShapePenetrating)||
|[static IsShapePenetrating(HkShape, ref Vector3D, ref Quaternion, Func<IMyEntity, bool>, int, bool)](Sandbox.Game.Entities.MyEntities@IsShapePenetrating)||
|[static IsSpherePenetrating(ref BoundingSphereD, bool)](Sandbox.Game.Entities.MyEntities@IsSpherePenetrating)||
|[static IsTypeHidden(Type)](Sandbox.Game.Entities.MyEntities@IsTypeHidden)||
|[static IsUpdateInProgress()](Sandbox.Game.Entities.MyEntities@IsUpdateInProgress)||
|[static IsVisible(IMyEntity)](Sandbox.Game.Entities.MyEntities@IsVisible)||
|[static Load(List<MyObjectBuilder_EntityBase>, out MyStringId?)](Sandbox.Game.Entities.MyEntities@Load)|Returns false when not all entities were loaded|
|[static LoadData()](Sandbox.Game.Entities.MyEntities@LoadData)||
|[static MemoryLimitAddFailureReset()](Sandbox.Game.Entities.MyEntities@MemoryLimitAddFailureReset)||
|[static OverlapAllLineSegment(ref LineD, List<MyLineSegmentOverlapResult<MyEntity>>)](Sandbox.Game.Entities.MyEntities@OverlapAllLineSegment)||
|[static RaiseEntityAdd(MyEntity)](Sandbox.Game.Entities.MyEntities@RaiseEntityAdd)||
|[static RaiseEntityCreated(MyEntity)](Sandbox.Game.Entities.MyEntities@RaiseEntityCreated)||
|[static RaiseEntityRemove(MyEntity)](Sandbox.Game.Entities.MyEntities@RaiseEntityRemove)||
|[static RegisterForDraw(IMyEntity)](Sandbox.Game.Entities.MyEntities@RegisterForDraw)||
|[static RegisterForUpdate(MyEntity)](Sandbox.Game.Entities.MyEntities@RegisterForUpdate)||
|[static ReleaseWaitingAsync(byte, Dictionary<long, MatrixD>)](Sandbox.Game.Entities.MyEntities@ReleaseWaitingAsync)||
|[static RemapObjectBuilder(MyObjectBuilder_EntityBase)](Sandbox.Game.Entities.MyEntities@RemapObjectBuilder)||
|[static RemapObjectBuilderCollection(IEnumerable<MyObjectBuilder_EntityBase>)](Sandbox.Game.Entities.MyEntities@RemapObjectBuilderCollection)||
|[static Remove(MyEntity)](Sandbox.Game.Entities.MyEntities@Remove)|Removes the specified entity from scene|
|[static RemoveFromClosedEntities(MyEntity)](Sandbox.Game.Entities.MyEntities@RemoveFromClosedEntities)||
|[static RemoveName(MyEntity)](Sandbox.Game.Entities.MyEntities@RemoveName)|Remove name of entity from used names|
|[static RemoveRenderObjectFromMap(uint)](Sandbox.Game.Entities.MyEntities@RemoveRenderObjectFromMap)||
|[static SendCloseRequest(IMyEntity)](Sandbox.Game.Entities.MyEntities@SendCloseRequest)||
|[static SetEntityName(MyEntity, bool)](Sandbox.Game.Entities.MyEntities@SetEntityName)||
|[static SetTypeHidden(Type, bool)](Sandbox.Game.Entities.MyEntities@SetTypeHidden)||
|[static Simulate()](Sandbox.Game.Entities.MyEntities@Simulate)||
|[static StartAsyncUpdateBlock()](Sandbox.Game.Entities.MyEntities@StartAsyncUpdateBlock)|Start a asynchronous update block.|
|[static TestPlaceInSpace(Vector3D, float, Func<IMyEntity, bool>, bool)](Sandbox.Game.Entities.MyEntities@TestPlaceInSpace)||
|[static TestPlaceInSpace(Vector3D, float, MyEntity, bool)](Sandbox.Game.Entities.MyEntities@TestPlaceInSpace)||
|[static TryGetEntityById(long, out MyEntity, bool)](Sandbox.Game.Entities.MyEntities@TryGetEntityById)||
|[static TryGetEntityById<T>(long, out T, bool)](Sandbox.Game.Entities.MyEntities@TryGetEntityById{T})||
|[static TryGetEntityByName(string, out MyEntity)](Sandbox.Game.Entities.MyEntities@TryGetEntityByName)||
|[static TryGetEntityByName<T>(string, out T)](Sandbox.Game.Entities.MyEntities@TryGetEntityByName{T})||
|[static UnhideAllTypes()](Sandbox.Game.Entities.MyEntities@UnhideAllTypes)||
|[static UnloadData()](Sandbox.Game.Entities.MyEntities@UnloadData)||
|[static UnregisterForDraw(IMyEntity)](Sandbox.Game.Entities.MyEntities@UnregisterForDraw)||
|[static UnregisterForUpdate(MyEntity, bool)](Sandbox.Game.Entities.MyEntities@UnregisterForUpdate)||
|[static UpdateAfterSimulation()](Sandbox.Game.Entities.MyEntities@UpdateAfterSimulation)||
|[static UpdateBeforeSimulation()](Sandbox.Game.Entities.MyEntities@UpdateBeforeSimulation)||
|[static UpdateOnceBeforeFrame()](Sandbox.Game.Entities.MyEntities@UpdateOnceBeforeFrame)||
|[static UpdatingStopped()](Sandbox.Game.Entities.MyEntities@UpdatingStopped)||
|[static FindFreePlace(Vector3D, float, int, int, float, MyEntity, bool)](Sandbox.Game.Entities.MyEntities@FindFreePlace)|_**Obsolete**_<br /><br />Finds free place for objects defined by position and radius. StepSize is how fast to increase radius, 0.5f means by half radius. NOTE: Following method may have the following problems: 1) CorrectSpawnLocation() should be always followed by a second test for IsShapePenetrating() 2) First overlapping test may result in returning a colliding test sphere with a physics voxel map (case overlappedVoxelmap != null and not a planet) 3) In second overlapping test, CorrectSpawnLocation() is testing from basePos. It should probably test from currentPos cause it's the one that is modified by external cycle 4) In second overlapping test, CorrectSpawnLocation() may have found a safe position but that won't be spotted and the result will be corrupted by the external cycle|

