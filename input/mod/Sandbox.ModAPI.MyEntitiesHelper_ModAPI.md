**Assembly:** Sandbox.Game.dll

```csharp
public class MyEntitiesHelper_ModAPI: IMyEntities
```

## Events

|Member|Description|
|---|---|
|[OnCloseAll](VRage.ModAPI.IMyEntities@OnCloseAll)|Called when session unloads, before grids are closed<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[OnEntityAdd](VRage.ModAPI.IMyEntities@OnEntityAdd)|Called when [AddEntity(IMyEntity, bool)](VRage.ModAPI.IMyEntities@AddEntity) called on entity<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[OnEntityNameSet](VRage.ModAPI.IMyEntities@OnEntityNameSet)|Called when entity gets [Name](VRage.ModAPI.IMyEntity@Name) . First string - old name, Second - new name<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[OnEntityRemove](VRage.ModAPI.IMyEntities@OnEntityRemove)|Called when [RemoveEntity(IMyEntity)](VRage.ModAPI.IMyEntities@RemoveEntity) called on entity<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|

## Constructors

|Member|Description|
|---|---|
|[MyEntitiesHelper_ModAPI()](Sandbox.ModAPI.MyEntitiesHelper_ModAPI@.ctor)||

## Methods

|Member|Description|
|---|---|
|[AddEntity(IMyEntity, bool)](VRage.ModAPI.IMyEntities@AddEntity)|Registers entity<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[CreateFromObjectBuilder(MyObjectBuilder_EntityBase)](VRage.ModAPI.IMyEntities@CreateFromObjectBuilder)|Create entity from object builder<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[CreateFromObjectBuilderAndAdd(MyObjectBuilder_EntityBase)](VRage.ModAPI.IMyEntities@CreateFromObjectBuilderAndAdd)|Create entity from object builder, and then call [AddEntity(IMyEntity, bool)](VRage.ModAPI.IMyEntities@AddEntity)<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[CreateFromObjectBuilderNoinit(MyObjectBuilder_EntityBase)](VRage.ModAPI.IMyEntities@CreateFromObjectBuilderNoinit)|Create new entity from objectBuilder, but doesn't call<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[CreateFromObjectBuilderParallel(MyObjectBuilder_EntityBase, bool, Action<IMyEntity>)](VRage.ModAPI.IMyEntities@CreateFromObjectBuilderParallel)|Creates and asynchronously initializes and entity.<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[EnableEntityBoundingBoxDraw(IMyEntity, bool, Vector4?, float, Vector3?)](VRage.ModAPI.IMyEntities@EnableEntityBoundingBoxDraw)|Draw bounding box around entity<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[EntityExists(string)](VRage.ModAPI.IMyEntities@EntityExists)|Returns if entity with provided name exists<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[EntityExists(long)](VRage.ModAPI.IMyEntities@EntityExists)|Returns if entity with provided name exists<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[EntityExists(long?)](VRage.ModAPI.IMyEntities@EntityExists)|Returns if entity with provided name exists<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[Exist(IMyEntity)](VRage.ModAPI.IMyEntities@Exist)|Checks if entity is registered entity<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[FindFreePlace(Vector3D, float, int, int, float)](VRage.ModAPI.IMyEntities@FindFreePlace)|Use to find place that doesn't have any voxels, grids, or physical bodies. If original position can't fill check sphere, new position in some distance is picked. Distance grows each testsPerDistance attempts. Maximum distance from BasePos that can be used is calculated by formula: maxTestCount / testsPerDistance * radius * stepSize<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetElementsInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetElementsInBox)|Returns list of entities that intersects with BoundingBox. This function will return CubeBlocks. This function works slower than [GetTopMostEntitiesInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInBox)<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetEntities(HashSet<IMyEntity>, Func<IMyEntity, bool>)](VRage.ModAPI.IMyEntities@GetEntities)|Get all entities matching condition<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetEntitiesInAABB(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetEntitiesInAABB)|Returns list of entities that intersects with BoundingBox. This function will return CubeBlocks. This function works slower than [GetTopMostEntitiesInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInBox)<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetEntitiesInSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetEntitiesInSphere)|Returns list of entities that intersects with sphere. This function will return CubeBlocks. This function works slower than [GetTopMostEntitiesInSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInSphere)<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetEntity(Func<IMyEntity, bool>)](VRage.ModAPI.IMyEntities@GetEntity)|Get first entity that matching condition<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetEntityById(long)](VRage.ModAPI.IMyEntities@GetEntityById)|Returns entity with provided entityId<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetEntityById(long?)](VRage.ModAPI.IMyEntities@GetEntityById)|Returns entity with provided entityId<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetEntityByName(string)](VRage.ModAPI.IMyEntities@GetEntityByName)|Returns entity with provided name<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetInflatedPlayerBoundingBox(ref BoundingBoxD, float)](VRage.ModAPI.IMyEntities@GetInflatedPlayerBoundingBox)|Making playerBox include all connected players<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetIntersectionWithSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetIntersectionWithSphere)|Returns first found (not closest) entity that intersects with sphere<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity)](VRage.ModAPI.IMyEntities@GetIntersectionWithSphere)|Returns first found (not closest) entity that intersects with sphere<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity, bool, bool, bool, bool, bool)](VRage.ModAPI.IMyEntities@GetIntersectionWithSphere)|Returns first found (not closest) entity that intersects with sphere<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity, bool, bool)](VRage.ModAPI.IMyEntities@GetIntersectionWithSphere)|Returns list of entities that intersects with sphere<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetTopMostEntitiesInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInBox)|Returns list of `TopMost` entities that intersects with bounding box. This function won't return CubeBlocks. Use [GetElementsInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetElementsInBox) to retrieve CubeBlocks also.<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetTopMostEntitiesInSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInSphere)|Returns list of `TopMost` entities that intersects with sphere. This function won't return CubeBlocks. Use [GetEntitiesInSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetEntitiesInSphere) to retrieve CubeBlocks also.<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[IsInsideVoxel(Vector3D, Vector3D, out Vector3D)](VRage.ModAPI.IMyEntities@IsInsideVoxel)|Return true if line between pos and hintPosition doesn't intersect any voxel, or intersects it even number of times Does inside physical ray casting inside<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[IsInsideWorld(Vector3D)](VRage.ModAPI.IMyEntities@IsInsideWorld)|Returns true if distance from 0,0,0 to provided position is less than [WorldHalfExtent()](VRage.ModAPI.IMyEntities@WorldHalfExtent)<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[IsNameExists(IMyEntity, string)](VRage.ModAPI.IMyEntities@IsNameExists)|Checks if registered name belongs to this entity<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[IsRaycastBlocked(Vector3D, Vector3D)](VRage.ModAPI.IMyEntities@IsRaycastBlocked)|Returns true if raycast hits anything (with raycast layer=0)<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[IsSpherePenetrating(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@IsSpherePenetrating)|Checks if sphere hits any `HkRigidBody`<sub>prohibited</sub><br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[IsTypeHidden(Type)](VRage.ModAPI.IMyEntities@IsTypeHidden)|Gets whether entities that inherit type is visible or not. Example:```csharp<br />IsTypeHidden(typeof (IMyCubeGrid))<br /><br />```<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[IsVisible(IMyEntity)](VRage.ModAPI.IMyEntities@IsVisible)|Gets whether entity is visible or not because of [SetTypeHidden(Type, bool)](VRage.ModAPI.IMyEntities@SetTypeHidden)<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[IsWorldLimited()](VRage.ModAPI.IMyEntities@IsWorldLimited)|Return whether world has limited size in kilometers<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[MarkForClose(IMyEntity)](VRage.ModAPI.IMyEntities@MarkForClose)|Mark entity as closed. Soon it would be deleted. Doesn't call [Close()](VRage.ModAPI.IMyEntity@Close)<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[RegisterForDraw(IMyEntity)](VRage.ModAPI.IMyEntities@RegisterForDraw)|Make entity receive PrepareForDraw and sending to it's Render Draw call<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[RegisterForUpdate(IMyEntity)](VRage.ModAPI.IMyEntities@RegisterForUpdate)|Make entity receive UpdateBeforeSimulation, UpdateBefore10Simulation, UpdateBefore100Simulation, UpdateAfterSimulation, UpdateAfter10Simulation, UpdateAfter100Simulation, Simulate, UpdateBeforeNextFrame depending on it's [NeedsUpdate](VRage.ModAPI.IMyEntity@NeedsUpdate) flags. Physics are still simulated<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[RemapObjectBuilder(MyObjectBuilder_EntityBase)](VRage.ModAPI.IMyEntities@RemapObjectBuilder)|Remaps this entity's [EntityId](VRage.ModAPI.IMyEntity@EntityId) and [Name](VRage.ModAPI.IMyEntity@Name) to a new values.<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[RemapObjectBuilderCollection(IEnumerable<MyObjectBuilder_EntityBase>)](VRage.ModAPI.IMyEntities@RemapObjectBuilderCollection)|Remaps this entity's [EntityId](VRage.ModAPI.IMyEntity@EntityId) and [Name](VRage.ModAPI.IMyEntity@Name) to a new values.<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[RemoveEntity(IMyEntity)](VRage.ModAPI.IMyEntities@RemoveEntity)|Unregisters entity<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[RemoveFromClosedEntities(IMyEntity)](VRage.ModAPI.IMyEntities@RemoveFromClosedEntities)|Remove entity from lists of closed entities<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[RemoveName(IMyEntity)](VRage.ModAPI.IMyEntities@RemoveName)|Removes registered name from entity.<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[SetEntityName(IMyEntity, bool)](VRage.ModAPI.IMyEntities@SetEntityName)|Apply [Name](VRage.ModAPI.IMyEntity@Name) for entity<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[SetTypeHidden(Type, bool)](VRage.ModAPI.IMyEntities@SetTypeHidden)|Entities that inherit that type would be visible/invisible.<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[TryGetEntityById(long, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityById)|Returns entity with provided id<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[TryGetEntityById(long?, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityById)|Returns entity with provided id<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[TryGetEntityByName(string, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityByName)|Returns entity with provided name<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[UnhideAllTypes()](VRage.ModAPI.IMyEntities@UnhideAllTypes)|Revert all changes to default. Make all entities visible, that were hidden because of [SetTypeHidden(Type, bool)](VRage.ModAPI.IMyEntities@SetTypeHidden)<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[UnregisterForDraw(IMyEntity)](VRage.ModAPI.IMyEntities@UnregisterForDraw)|Unregistering entity from PrepareForDraw events and it Render from Draw calls. Entity may still be rendered<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[UnregisterForUpdate(IMyEntity, bool)](VRage.ModAPI.IMyEntities@UnregisterForUpdate)|Unregistering entity from following updates: UpdateBeforeSimulation, UpdateBefore10Simulation, UpdateBefore100Simulation, UpdateAfterSimulation, UpdateAfter10Simulation, UpdateAfter100Simulation, Simulate, UpdateBeforeNextFrame Physics are still simulated<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[WorldHalfExtent()](VRage.ModAPI.IMyEntities@WorldHalfExtent)|Returns shortest distance (i.e. axis-aligned) to the world border from the world center. Will be 0 if world is borderless<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[WorldSafeHalfExtent()](VRage.ModAPI.IMyEntities@WorldSafeHalfExtent)|Returns shortest distance (i.e. axis-aligned) to the world border from the world center, minus 600m to make spawning somewhat safer. Will be 0 if world is borderless<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[GetInflatedPlayerBoundingBox(ref BoundingBox, float)](VRage.ModAPI.IMyEntities@GetInflatedPlayerBoundingBox)|_**Obsolete**_<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|
|[IsInsideVoxel(Vector3, Vector3, out Vector3)](VRage.ModAPI.IMyEntities@IsInsideVoxel)|_**Obsolete**_<br /><br />_Inherited from [IMyEntities](VRage.ModAPI.IMyEntities)_|

**Implements:**  
* [IMyEntities](VRage.ModAPI.IMyEntities)

