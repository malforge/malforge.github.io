**Assembly:** VRage.Game.dll

```csharp
public interface IMyEntities
```

Provides API, that granting access to enitities (mods interface)

## Events

|Member|Description|
|---|---|
|[OnCloseAll](VRage.ModAPI.IMyEntities@OnCloseAll)|Called when session unloads, before grids are closed|
|[OnEntityAdd](VRage.ModAPI.IMyEntities@OnEntityAdd)|Called when [AddEntity(IMyEntity, bool)](VRage.ModAPI.IMyEntities@AddEntity) called on entity|
|[OnEntityNameSet](VRage.ModAPI.IMyEntities@OnEntityNameSet)|Called when entity gets [Name](VRage.ModAPI.IMyEntity@Name) . First string - old name, Second - new name|
|[OnEntityRemove](VRage.ModAPI.IMyEntities@OnEntityRemove)|Called when [RemoveEntity(IMyEntity)](VRage.ModAPI.IMyEntities@RemoveEntity) called on entity|

## Methods

|Member|Description|
|---|---|
|[AddEntity(IMyEntity, bool)](VRage.ModAPI.IMyEntities@AddEntity)|Registers entity|
|[CreateFromObjectBuilder(MyObjectBuilder_EntityBase)](VRage.ModAPI.IMyEntities@CreateFromObjectBuilder)|Create entity from object builder|
|[CreateFromObjectBuilderAndAdd(MyObjectBuilder_EntityBase)](VRage.ModAPI.IMyEntities@CreateFromObjectBuilderAndAdd)|Create entity from object builder, and then call [AddEntity(IMyEntity, bool)](VRage.ModAPI.IMyEntities@AddEntity) |
|[CreateFromObjectBuilderNoinit(MyObjectBuilder_EntityBase)](VRage.ModAPI.IMyEntities@CreateFromObjectBuilderNoinit)|Create new entity from objectBuilder, but doesn't call|
|[CreateFromObjectBuilderParallel(MyObjectBuilder_EntityBase, bool, Action<IMyEntity>)](VRage.ModAPI.IMyEntities@CreateFromObjectBuilderParallel)|Creates and asynchronously initializes and entity.|
|[EnableEntityBoundingBoxDraw(IMyEntity, bool, Vector4?, float, Vector3?)](VRage.ModAPI.IMyEntities@EnableEntityBoundingBoxDraw)|Draw bounding box around entity|
|[EntityExists(string)](VRage.ModAPI.IMyEntities@EntityExists)|Returns if entity with provided name exists|
|[EntityExists(long)](VRage.ModAPI.IMyEntities@EntityExists)|Returns if entity with provided name exists|
|[EntityExists(long?)](VRage.ModAPI.IMyEntities@EntityExists)|Returns if entity with provided name exists|
|[Exist(IMyEntity)](VRage.ModAPI.IMyEntities@Exist)|Checks if entity is registered entity|
|[FindFreePlace(Vector3D, float, int, int, float)](VRage.ModAPI.IMyEntities@FindFreePlace)|Use to find place that doesn't have any voxels, grids, or physical bodies. If original position can't fill check sphere, new position in some distance is picked. Distance grows each testsPerDistance attempts. Maximum distance from BasePos that can be used is calculated by formula: maxTestCount / testsPerDistance * radius * stepSize|
|[GetElementsInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetElementsInBox)|Returns list of entities that intersects with BoundingBox. This function will return CubeBlocks. This function works slower than [GetTopMostEntitiesInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInBox) |
|[GetEntities(HashSet<IMyEntity>, Func<IMyEntity, bool>)](VRage.ModAPI.IMyEntities@GetEntities)|Get all entities matching condition|
|[GetEntitiesInAABB(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetEntitiesInAABB)|Returns list of entities that intersects with BoundingBox. This function will return CubeBlocks. This function works slower than [GetTopMostEntitiesInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInBox) |
|[GetEntitiesInSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetEntitiesInSphere)|Returns list of entities that intersects with sphere. This function will return CubeBlocks. This function works slower than [GetTopMostEntitiesInSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInSphere) |
|[GetEntity(Func<IMyEntity, bool>)](VRage.ModAPI.IMyEntities@GetEntity)|Get first entity that matching condition|
|[GetEntityById(long)](VRage.ModAPI.IMyEntities@GetEntityById)|Returns entity with provided entityId|
|[GetEntityById(long?)](VRage.ModAPI.IMyEntities@GetEntityById)|Returns entity with provided entityId|
|[GetEntityByName(string)](VRage.ModAPI.IMyEntities@GetEntityByName)|Returns entity with provided name|
|[GetInflatedPlayerBoundingBox(ref BoundingBoxD, float)](VRage.ModAPI.IMyEntities@GetInflatedPlayerBoundingBox)|Making playerBox include all connected players|
|[GetIntersectionWithSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetIntersectionWithSphere)|Returns first found (not closest) entity that intersects with sphere|
|[GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity)](VRage.ModAPI.IMyEntities@GetIntersectionWithSphere)|Returns first found (not closest) entity that intersects with sphere|
|[GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity, bool, bool, bool, bool, bool)](VRage.ModAPI.IMyEntities@GetIntersectionWithSphere)|Returns first found (not closest) entity that intersects with sphere|
|[GetIntersectionWithSphere(ref BoundingSphereD, IMyEntity, IMyEntity, bool, bool)](VRage.ModAPI.IMyEntities@GetIntersectionWithSphere)|Returns list of entities that intersects with sphere|
|[GetTopMostEntitiesInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInBox)|Returns list of `TopMost` entities that intersects with bounding box. This function won't return CubeBlocks. Use [GetElementsInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetElementsInBox) to retrieve CubeBlocks also.|
|[GetTopMostEntitiesInSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInSphere)|Returns list of `TopMost` entities that intersects with sphere. This function won't return CubeBlocks. Use [GetEntitiesInSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetEntitiesInSphere) to retrieve CubeBlocks also.|
|[IsInsideVoxel(Vector3D, Vector3D, out Vector3D)](VRage.ModAPI.IMyEntities@IsInsideVoxel)|Return true if line between pos and hintPosition doesn't intersect any voxel, or intersects it even number of times Does inside physical ray casting inside|
|[IsInsideWorld(Vector3D)](VRage.ModAPI.IMyEntities@IsInsideWorld)|Returns true if distance from 0,0,0 to provided position is less than [WorldHalfExtent()](VRage.ModAPI.IMyEntities@WorldHalfExtent) |
|[IsNameExists(IMyEntity, string)](VRage.ModAPI.IMyEntities@IsNameExists)|Checks if registered name belongs to this entity|
|[IsRaycastBlocked(Vector3D, Vector3D)](VRage.ModAPI.IMyEntities@IsRaycastBlocked)|Returns true if raycast hits anything (with raycast layer=0)|
|[IsSpherePenetrating(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@IsSpherePenetrating)|Checks if sphere hits any `HkRigidBody`<sub>prohibited</sub> |
|[IsTypeHidden(Type)](VRage.ModAPI.IMyEntities@IsTypeHidden)|Gets whether entities that inherit type is visible or not. Example:```csharp<br />IsTypeHidden(typeof (IMyCubeGrid))<br /><br />```|
|[IsVisible(IMyEntity)](VRage.ModAPI.IMyEntities@IsVisible)|Gets whether entity is visible or not because of [SetTypeHidden(Type, bool)](VRage.ModAPI.IMyEntities@SetTypeHidden) |
|[IsWorldLimited()](VRage.ModAPI.IMyEntities@IsWorldLimited)|Return whether world has limited size in kilometers|
|[MarkForClose(IMyEntity)](VRage.ModAPI.IMyEntities@MarkForClose)|Mark entity as closed. Soon it would be deleted. Doesn't call [Close()](VRage.ModAPI.IMyEntity@Close) |
|[RegisterForDraw(IMyEntity)](VRage.ModAPI.IMyEntities@RegisterForDraw)|Make entity receive PrepareForDraw and sending to it's Render Draw call|
|[RegisterForUpdate(IMyEntity)](VRage.ModAPI.IMyEntities@RegisterForUpdate)|Make entity receive UpdateBeforeSimulation, UpdateBefore10Simulation, UpdateBefore100Simulation, UpdateAfterSimulation, UpdateAfter10Simulation, UpdateAfter100Simulation, Simulate, UpdateBeforeNextFrame depending on it's [NeedsUpdate](VRage.ModAPI.IMyEntity@NeedsUpdate) flags. Physics are still simulated|
|[RemapObjectBuilder(MyObjectBuilder_EntityBase)](VRage.ModAPI.IMyEntities@RemapObjectBuilder)|Remaps this entity's [EntityId](VRage.ModAPI.IMyEntity@EntityId) and [Name](VRage.ModAPI.IMyEntity@Name) to a new values.|
|[RemapObjectBuilderCollection(IEnumerable<MyObjectBuilder_EntityBase>)](VRage.ModAPI.IMyEntities@RemapObjectBuilderCollection)|Remaps this entity's [EntityId](VRage.ModAPI.IMyEntity@EntityId) and [Name](VRage.ModAPI.IMyEntity@Name) to a new values.|
|[RemoveEntity(IMyEntity)](VRage.ModAPI.IMyEntities@RemoveEntity)|Unregisters entity|
|[RemoveFromClosedEntities(IMyEntity)](VRage.ModAPI.IMyEntities@RemoveFromClosedEntities)|Remove entity from lists of closed entities|
|[RemoveName(IMyEntity)](VRage.ModAPI.IMyEntities@RemoveName)|Removes registered name from entity.|
|[SetEntityName(IMyEntity, bool)](VRage.ModAPI.IMyEntities@SetEntityName)|Apply [Name](VRage.ModAPI.IMyEntity@Name) for entity|
|[SetTypeHidden(Type, bool)](VRage.ModAPI.IMyEntities@SetTypeHidden)|Entities that inherit that type would be visible/invisible.|
|[TryGetEntityById(long, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityById)|Returns entity with provided id|
|[TryGetEntityById(long?, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityById)|Returns entity with provided id|
|[TryGetEntityByName(string, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityByName)|Returns entity with provided name|
|[UnhideAllTypes()](VRage.ModAPI.IMyEntities@UnhideAllTypes)|Revert all changes to default. Make all entities visible, that were hidden because of [SetTypeHidden(Type, bool)](VRage.ModAPI.IMyEntities@SetTypeHidden) |
|[UnregisterForDraw(IMyEntity)](VRage.ModAPI.IMyEntities@UnregisterForDraw)|Unregistering entity from PrepareForDraw events and it Render from Draw calls. Entity may still be rendered|
|[UnregisterForUpdate(IMyEntity, bool)](VRage.ModAPI.IMyEntities@UnregisterForUpdate)|Unregistering entity from following updates: UpdateBeforeSimulation, UpdateBefore10Simulation, UpdateBefore100Simulation, UpdateAfterSimulation, UpdateAfter10Simulation, UpdateAfter100Simulation, Simulate, UpdateBeforeNextFrame Physics are still simulated|
|[WorldHalfExtent()](VRage.ModAPI.IMyEntities@WorldHalfExtent)|Returns shortest distance (i.e. axis-aligned) to the world border from the world center. Will be 0 if world is borderless|
|[WorldSafeHalfExtent()](VRage.ModAPI.IMyEntities@WorldSafeHalfExtent)|Returns shortest distance (i.e. axis-aligned) to the world border from the world center, minus 600m to make spawning somewhat safer. Will be 0 if world is borderless|
|[GetInflatedPlayerBoundingBox(ref BoundingBox, float)](VRage.ModAPI.IMyEntities@GetInflatedPlayerBoundingBox)|_**Obsolete**_|
|[IsInsideVoxel(Vector3, Vector3, out Vector3)](VRage.ModAPI.IMyEntities@IsInsideVoxel)|_**Obsolete**_|

**Inheritors:**  
* [MyEntitiesHelper_ModAPI](Sandbox.ModAPI.MyEntitiesHelper_ModAPI)

