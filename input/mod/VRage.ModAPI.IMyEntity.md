**Assembly:** VRage.Game.dll

```csharp
public interface IMyEntity: IMyEntity
```

## Events

|Member|Description|
|---|---|
|[OnClose](VRage.ModAPI.IMyEntity@OnClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .|
|[OnClosing](VRage.ModAPI.IMyEntity@OnClosing)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .|
|[OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .|
|[OnPhysicsChanged](VRage.ModAPI.IMyEntity@OnPhysicsChanged)|Called when havok rigid body physics are changed: inited, closed, modified.|

## Properties

|Member|Description|
|---|---|
|[CastShadows](VRage.ModAPI.IMyEntity@CastShadows)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows) |
|[DebugAsyncLoading](VRage.ModAPI.IMyEntity@DebugAsyncLoading)|Used for internal usage. Modders should not use it. Will be eventually removed|
|[DisplayName](VRage.ModAPI.IMyEntity@DisplayName)|Gets or sets user friendly name of entity|
|[EntityId](VRage.ModAPI.IMyEntity@EntityId)|Uniq id of entity.|
|[FastCastShadowResolve](VRage.ModAPI.IMyEntity@FastCastShadowResolve)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows) |
|[Flags](VRage.ModAPI.IMyEntity@Flags)|Gets or set some behavior of entity. [EntityFlags](VRage.ModAPI.EntityFlags) |
|[GameLogic](VRage.ModAPI.IMyEntity@GameLogic)|Gets or sets game logic for object. If there is more than 1 game logic attached it should be wrapped into.|
|[Hierarchy](VRage.ModAPI.IMyEntity@Hierarchy)|Gets or sets Hierarchy component|
|[InScene](VRage.ModAPI.IMyEntity@InScene)|Gets or set if grid is InScene. Objects that are not in scene are not updated and drawn.|
|[InvalidateOnMove](VRage.ModAPI.IMyEntity@InvalidateOnMove)|Gets if entity is invalidated on move When visual look of entity depends on position - then InvalidateOnMove should be true|
|[IsVolumetric](VRage.ModAPI.IMyEntity@IsVolumetric)|Always returns false|
|[LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB)|Gets or sets local axis aligned bounding box. Same as [LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB) |
|[LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr)|Gets local axis aligned bounding box. Same as [LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB) |
|[LocalMatrix](VRage.ModAPI.IMyEntity@LocalMatrix)|Gets or sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix|
|[LocalVolume](VRage.ModAPI.IMyEntity@LocalVolume)|Gets or sets local volume. Same as [LocalVolume](VRage.Game.Components.MyPositionComponentBase@LocalVolume) |
|[LocalVolumeOffset](VRage.ModAPI.IMyEntity@LocalVolumeOffset)|Gets or sets local volume offset. Same as [LocalVolumeOffset](VRage.Game.Components.MyPositionComponentBase@LocalVolumeOffset) |
|[MarkedForClose](VRage.ModAPI.IMyEntity@MarkedForClose)|Checked if [Close()](VRage.ModAPI.IMyEntity@Close) was called|
|[MaxGlassDistSq](VRage.ModAPI.IMyEntity@MaxGlassDistSq)|Not used in game anymore|
|[Model](VRage.ModAPI.IMyEntity@Model)|Gets model of block|
|[ModelCollision](VRage.ModAPI.IMyEntity@ModelCollision)|Gets collision model of block|
|[Name](VRage.ModAPI.IMyEntity@Name)|Uniq name of entity. Can be used to find entity by name|
|[NearFlag](VRage.ModAPI.IMyEntity@NearFlag)|Gets or sets flag [Near](VRage.ModAPI.EntityFlags@Near) |
|[NeedsDraw](VRage.ModAPI.IMyEntity@NeedsDraw)|Gets or sets flag [NeedsDraw](VRage.ModAPI.EntityFlags@NeedsDraw) |
|[NeedsDrawFromParent](VRage.ModAPI.IMyEntity@NeedsDrawFromParent)|Gets or sets flag [NeedsDrawFromParent](VRage.ModAPI.EntityFlags@NeedsDrawFromParent) |
|[NeedsResolveCastShadow](VRage.ModAPI.IMyEntity@NeedsResolveCastShadow)|Gets or sets flag [NeedsResolveCastShadow](VRage.ModAPI.EntityFlags@NeedsResolveCastShadow) |
|[NeedsUpdate](VRage.ModAPI.IMyEntity@NeedsUpdate)|Gets or sets how often the entity should be updated.|
|[NeedsWorldMatrix](VRage.ModAPI.IMyEntity@NeedsWorldMatrix)|Gets or sets if [WorldMatrix](VRage.ModAPI.IMyEntity@WorldMatrix) should be calculated when parent WorldMatrix is changed.|
|[Parent](VRage.ModAPI.IMyEntity@Parent)|Gets parent of entity or null, if this entity doesn't have parent. Ex: character sitting in cockpit, has parent - cockpit, cockpit has parent - cube grid, connected grids also has main grid, which would be parent for other grids.|
|[PersistentFlags](VRage.ModAPI.IMyEntity@PersistentFlags)|Gets or sets persistent flags that are used in rendering.|
|[Physics](VRage.ModAPI.IMyEntity@Physics)|Gets or sets physics for object|
|[PositionComp](VRage.ModAPI.IMyEntity@PositionComp)|Gets or sets position provider logic|
|[Render](VRage.ModAPI.IMyEntity@Render)|Gets or sets render logic|
|[Save](VRage.ModAPI.IMyEntity@Save)|Gets or sets [Save](VRage.ModAPI.EntityFlags@Save) . Entity won't be saved if [Save](VRage.ModAPI.IMyEntity@Save) is false|
|[ShadowBoxLod](VRage.ModAPI.IMyEntity@ShadowBoxLod)|Gets or sets flag [ShadowBoxLod](VRage.Game.Components.MyRenderComponentBase@ShadowBoxLod) |
|[SkipIfTooSmall](VRage.ModAPI.IMyEntity@SkipIfTooSmall)|Gets or sets flag [SkipIfTooSmall](VRage.ModAPI.EntityFlags@SkipIfTooSmall) |
|[StopPhysicsActivation](VRage.ModAPI.IMyEntity@StopPhysicsActivation)||
|[Storage](VRage.ModAPI.IMyEntity@Storage)|Custom storage for mods. Shared with all mods.|
|[Synchronized](VRage.ModAPI.IMyEntity@Synchronized)|Gets or sets if the entity should be synced.|
|[SyncObject](VRage.ModAPI.IMyEntity@SyncObject)|Gets SyncObject used for synchronizing data over network with|
|[Transparent](VRage.ModAPI.IMyEntity@Transparent)|Gets or sets [Transparency](VRage.Game.Components.MyRenderComponentBase@Transparency) . When setting true entity would be 25% transparent|
|[Visible](VRage.ModAPI.IMyEntity@Visible)|Gets or sets flag [Visible](VRage.Game.Components.MyRenderComponentBase@Visible) |
|[WorldMatrix](VRage.ModAPI.IMyEntity@WorldMatrix)|Gets or sets world matrix.|
|[WorldMatrixInvScaled](VRage.ModAPI.IMyEntity@WorldMatrixInvScaled)|Get scaled, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv) , but not normalized|
|[WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)|Get normalized, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv) |
|[Closed](VRage.Game.ModAPI.Ingame.IMyEntity@Closed)|True if the block has been removed from the world.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Components](VRage.Game.ModAPI.Ingame.IMyEntity@Components)|Gets blocks component logic container<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[DisplayName](VRage.Game.ModAPI.Ingame.IMyEntity@DisplayName)|Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisplayNameText)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[EntityId](VRage.Game.ModAPI.Ingame.IMyEntity@EntityId)|Id of entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[HasInventory](VRage.Game.ModAPI.Ingame.IMyEntity@HasInventory)|Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[InventoryCount](VRage.Game.ModAPI.Ingame.IMyEntity@InventoryCount)|Returns the count of the number of inventories this entity has.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Name](VRage.Game.ModAPI.Ingame.IMyEntity@Name)|Some entities can have uniq name, and game can find them by name [TryGetEntityByName(string, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityByName)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldAABB](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABB)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldAABBHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABBHr)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.Game.ModAPI.Ingame.IMyEntity@WorldMatrix)|Gets world matrix of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldVolume](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolume)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldVolumeHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolumeHr)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[IsCCDForProjectiles](VRage.ModAPI.IMyEntity@IsCCDForProjectiles)|_**Obsolete**_|
|[LocationForHudMarker](VRage.ModAPI.IMyEntity@LocationForHudMarker)|_**Obsolete**_|

## Methods

|Member|Description|
|---|---|
|[BeforeSave()](VRage.ModAPI.IMyEntity@BeforeSave)|Called before method GetObjectBuilder, when saving sector|
|[Close()](VRage.ModAPI.IMyEntity@Close)|This method marks this entity for close which means, that Close will be called after all entities are updated|
|[DebugDraw()](VRage.ModAPI.IMyEntity@DebugDraw)|Calls debug draw of entity|
|[DebugDrawInvalidTriangles()](VRage.ModAPI.IMyEntity@DebugDrawInvalidTriangles)|Calls special debug draw, that highlighting invalid triangles in model|
|[Delete()](VRage.ModAPI.IMyEntity@Delete)|Performs real cleaning of entity. Should be called by game. Modders should prefer [Close()](VRage.ModAPI.IMyEntity@Close) method.|
|[DoOverlapSphereTest(float, Vector3D)](VRage.ModAPI.IMyEntity@DoOverlapSphereTest)|Checks if intersects Works only with [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase) |
|[EnableColorMaskForSubparts(bool)](VRage.ModAPI.IMyEntity@EnableColorMaskForSubparts)|Allows subparts have different color than their parent|
|[GetChildren(List<IMyEntity>, Func<IMyEntity, bool>)](VRage.ModAPI.IMyEntity@GetChildren)|Gets children of entity. Child - entity, who's [Parent](VRage.ModAPI.IMyEntity@Parent) is this entity|
|[GetDiffuseColor()](VRage.ModAPI.IMyEntity@GetDiffuseColor)|Gets render diffuse color|
|[GetDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndBoundingSphere)|Distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. (in meters)|
|[GetDistanceBetweenCameraAndPosition()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndPosition)|Distance from camera to position of entity.|
|[GetFriendlyName()](VRage.ModAPI.IMyEntity@GetFriendlyName)|Not used. Actually not a friendly name|
|[GetIntersectionWithAABB(ref BoundingBoxD)](VRage.ModAPI.IMyEntity@GetIntersectionWithAABB)|Return true if object intersects specified bounding box.|
|[GetIntersectionWithLine(ref LineD, out MyIntersectionResultLineTriangleEx?, IntersectionFlags)](VRage.ModAPI.IMyEntity@GetIntersectionWithLine)|Get intersection of model with provided line|
|[GetIntersectionWithLineAndBoundingSphere(ref LineD, float)](VRage.ModAPI.IMyEntity@GetIntersectionWithLineAndBoundingSphere)|Calculates intersection of line with any bounding sphere in this model instance. Center of the bounding sphere will be returned. It takes boundingSphereRadiusMultiplier argument which serves for extending the influence (radius) for interaction with line.|
|[GetIntersectionWithSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntity@GetIntersectionWithSphere)|Return true if object intersects specified sphere.|
|[GetInventory()](VRage.ModAPI.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.|
|[GetInventory(int)](VRage.ModAPI.IMyEntity@GetInventory)|Search for inventory component with matching index.|
|[GetLargestDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetLargestDistanceBetweenCameraAndBoundingSphere)|Largest distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. It's actually distance between camera and opposite side of the sphere|
|[GetObjectBuilder(bool)](VRage.ModAPI.IMyEntity@GetObjectBuilder)|Returns object builder - object representing block state, and allows restore it. Used in game save, or syncing over network.|
|[GetSmallestDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetSmallestDistanceBetweenCameraAndBoundingSphere)|Smallest distance between camera and bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere.|
|[GetSubpart(string)](VRage.ModAPI.IMyEntity@GetSubpart)|Gets subpart by subpart name|
|[GetTopMostParent(Type)](VRage.ModAPI.IMyEntity@GetTopMostParent)|Gets top most [Parent](VRage.ModAPI.IMyEntity@Parent) of specified type. Top most is entity that doesn't have parent (of specified type)|
|[GetTrianglesIntersectingSphere(ref BoundingSphere, Vector3?, float?, List<MyTriangle_Vertex_Normals>, int)](VRage.ModAPI.IMyEntity@GetTrianglesIntersectingSphere)|Return list of triangles intersecting specified sphere. Angle between every triangleVertexes normal vector and 'referenceNormalVector' is calculated, and if more than 'maxAngle', we ignore such triangleVertexes. Triangles are returned in 'retTriangles', and this list must be preallocated! IMPORTANT: Sphere must be in model space, so don't transform it!|
|[GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix)|Get normalized, inverted world matrix. Same as [GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv) |
|[GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv)|Get normalized, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv) |
|[IsVisible()](VRage.ModAPI.IMyEntity@IsVisible)|Gets or result of function [IsVisible()](VRage.Game.Components.MyRenderComponentBase@IsVisible) . Function inside check for [IsVisible(IMyEntity)](VRage.ModAPI.IMyEntities@IsVisible) |
|[OnAddedToScene(object)](VRage.ModAPI.IMyEntity@OnAddedToScene)|Adds entity to scene: init updates, render physics|
|[OnRemovedFromScene(object)](VRage.ModAPI.IMyEntity@OnRemovedFromScene)|Remove entity and it's children from scene: stops updates and render, deactivates physics. Usually called when entity deleted|
|[SetColorMaskForSubparts(Vector3)](VRage.ModAPI.IMyEntity@SetColorMaskForSubparts)|Sets subparts custom col|
|[SetEmissiveParts(string, Color, float)](VRage.ModAPI.IMyEntity@SetEmissiveParts)|Sets the emissive value of a specific emissive material on entity.|
|[SetEmissivePartsForSubparts(string, Color, float)](VRage.ModAPI.IMyEntity@SetEmissivePartsForSubparts)|Sets the emissive value of a specific emissive material on all entity subparts.|
|[SetLocalMatrix(Matrix, object)](VRage.ModAPI.IMyEntity@SetLocalMatrix)|Sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix|
|[SetPosition(Vector3D)](VRage.ModAPI.IMyEntity@SetPosition)|Set WorldMatrix's [Translation](VRageMath.MatrixD@Translation) . Moves entity.|
|[SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|Sets subparts custom skinning. Copy values from [TextureChanges](VRage.Game.Components.MyRenderComponentBase@TextureChanges) , then change needed keys. You can retrieve values for exact skin with following code:```csharp<br />MyDefinitionManager.Static.GetAssetModifierDefinitionForRender(skinId);<br /><br />```|
|[SetWorldMatrix(MatrixD, object)](VRage.ModAPI.IMyEntity@SetWorldMatrix)|Sets world matrix of entity.|
|[Teleport(MatrixD, object, bool)](VRage.ModAPI.IMyEntity@Teleport)|When moving entity over large distances or when entity has children, using this method preferred over [SetPosition(Vector3D)](VRage.ModAPI.IMyEntity@SetPosition) |
|[TryGetSubpart(string, out MyEntitySubpart)](VRage.ModAPI.IMyEntity@TryGetSubpart)|Gets subpart by subpart name|
|[UpdateGamePruningStructure()](VRage.ModAPI.IMyEntity@UpdateGamePruningStructure)|Update position of entity in MyGamePruningStructure. Calls:```csharp<br />MyGamePruningStructure.Move(this)<br /><br />```|
|[GetInventory()](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetInventory(int)](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Search for inventory component with maching index.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetPosition()](VRage.Game.ModAPI.Ingame.IMyEntity@GetPosition)|Gets position in world coordinates<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[AddToGamePruningStructure()](VRage.ModAPI.IMyEntity@AddToGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._|
|[RemoveFromGamePruningStructure()](VRage.ModAPI.IMyEntity@RemoveFromGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._|
|[SetTextureChangesForSubparts(Dictionary<string, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|_**Obsolete**_<br /><br />This calling is obsolete, use another version.|

**Implements:**  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)

**Inheritors:**  
* [IMyAdvancedDoor](Sandbox.ModAPI.IMyAdvancedDoor)  
* [IMyAirtightDoorBase](Sandbox.ModAPI.IMyAirtightDoorBase)  
* [IMyAirtightHangarDoor](Sandbox.ModAPI.IMyAirtightHangarDoor)  
* [IMyAirtightSlideDoor](Sandbox.ModAPI.IMyAirtightSlideDoor)  
* [IMyAirVent](SpaceEngineers.Game.ModAPI.IMyAirVent)  
* [IMyAngleGrinder](Sandbox.ModAPI.Weapons.IMyAngleGrinder)  
* [IMyArtificialMassBlock](SpaceEngineers.Game.ModAPI.IMyArtificialMassBlock)  
* [IMyAssembler](Sandbox.ModAPI.IMyAssembler)  
* [IMyAttachableTopBlock](Sandbox.ModAPI.IMyAttachableTopBlock)  
* [IMyAutomaticRifleGun](Sandbox.ModAPI.Weapons.IMyAutomaticRifleGun)  
* [IMyBasicMissionBlock](Sandbox.ModAPI.IMyBasicMissionBlock)  
* [IMyBatteryBlock](Sandbox.ModAPI.IMyBatteryBlock)  
* [IMyBeacon](Sandbox.ModAPI.IMyBeacon)  
* [IMyBlockPlacerBase](Sandbox.ModAPI.Weapons.IMyBlockPlacerBase)  
* [IMyBroadcastController](SpaceEngineers.Game.ModAPI.IMyBroadcastController)  
* [IMyButtonPanel](SpaceEngineers.Game.ModAPI.IMyButtonPanel)  
* [IMyCameraBlock](Sandbox.ModAPI.IMyCameraBlock)  
* [IMyCargoContainer](Sandbox.ModAPI.IMyCargoContainer)  
* [IMyCharacter](VRage.Game.ModAPI.IMyCharacter)  
* [IMyCockpit](Sandbox.ModAPI.IMyCockpit)  
* [IMyCollector](Sandbox.ModAPI.IMyCollector)  
* [IMyControlPanel](SpaceEngineers.Game.ModAPI.IMyControlPanel)  
* [IMyConveyor](Sandbox.ModAPI.IMyConveyor)  
* [IMyConveyorSorter](Sandbox.ModAPI.IMyConveyorSorter)  
* [IMyConveyorTube](Sandbox.ModAPI.IMyConveyorTube)  
* [IMyCryoChamber](Sandbox.ModAPI.IMyCryoChamber)  
* [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)  
* [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid)  
* [IMyDecoy](Sandbox.ModAPI.IMyDecoy)  
* [IMyDefensiveCombatBlock](Sandbox.ModAPI.IMyDefensiveCombatBlock)  
* [IMyDoor](Sandbox.ModAPI.IMyDoor)  
* [IMyEmotionControllerBlock](Sandbox.ModAPI.IMyEmotionControllerBlock)  
* [IMyEngineerToolBase](Sandbox.ModAPI.Weapons.IMyEngineerToolBase)  
* [IMyEventControllerBlock](Sandbox.ModAPI.IMyEventControllerBlock)  
* [IMyExhaustBlock](Sandbox.ModAPI.IMyExhaustBlock)  
* [IMyExtendedPistonBase](Sandbox.ModAPI.IMyExtendedPistonBase)  
* [IMyFlightMovementBlock](Sandbox.ModAPI.IMyFlightMovementBlock)  
* [IMyFloatingObject](VRage.Game.ModAPI.IMyFloatingObject)  
* [IMyFunctionalBlock](Sandbox.ModAPI.IMyFunctionalBlock)  
* [IMyGasGenerator](Sandbox.ModAPI.IMyGasGenerator)  
* [IMyGasTank](Sandbox.ModAPI.IMyGasTank)  
* [IMyGravityGenerator](SpaceEngineers.Game.ModAPI.IMyGravityGenerator)  
* [IMyGravityGeneratorBase](SpaceEngineers.Game.ModAPI.IMyGravityGeneratorBase)  
* [IMyGravityGeneratorSphere](SpaceEngineers.Game.ModAPI.IMyGravityGeneratorSphere)  
* [IMyGyro](Sandbox.ModAPI.IMyGyro)  
* [IMyHandDrill](Sandbox.ModAPI.Weapons.IMyHandDrill)  
* [IMyHeatVent](SpaceEngineers.Game.ModAPI.IMyHeatVent)  
* [IMyInteriorLight](SpaceEngineers.Game.ModAPI.IMyInteriorLight)  
* [IMyInventoryBag](Sandbox.ModAPI.IMyInventoryBag)  
* [IMyJumpDrive](Sandbox.ModAPI.IMyJumpDrive)  
* [IMyLandingGear](SpaceEngineers.Game.ModAPI.IMyLandingGear)  
* [IMyLargeConveyorTurretBase](SpaceEngineers.Game.ModAPI.IMyLargeConveyorTurretBase)  
* [IMyLargeGatlingTurret](SpaceEngineers.Game.ModAPI.IMyLargeGatlingTurret)  
* [IMyLargeInteriorTurret](SpaceEngineers.Game.ModAPI.IMyLargeInteriorTurret)  
* [IMyLargeMissileTurret](SpaceEngineers.Game.ModAPI.IMyLargeMissileTurret)  
* [IMyLargeTurretBase](Sandbox.ModAPI.IMyLargeTurretBase)  
* [IMyLaserAntenna](Sandbox.ModAPI.IMyLaserAntenna)  
* [IMyLightingBlock](Sandbox.ModAPI.IMyLightingBlock)  
* [IMyMechanicalConnectionBlock](Sandbox.ModAPI.IMyMechanicalConnectionBlock)  
* [IMyMedicalRoom](SpaceEngineers.Game.ModAPI.IMyMedicalRoom)  
* [IMyMeteor](Sandbox.ModAPI.IMyMeteor)  
* [IMyMissile](Sandbox.ModAPI.IMyMissile)  
* [IMyMotorAdvancedRotor](Sandbox.ModAPI.IMyMotorAdvancedRotor)  
* [IMyMotorAdvancedStator](Sandbox.ModAPI.IMyMotorAdvancedStator)  
* [IMyMotorBase](Sandbox.ModAPI.IMyMotorBase)  
* [IMyMotorRotor](Sandbox.ModAPI.IMyMotorRotor)  
* [IMyMotorStator](Sandbox.ModAPI.IMyMotorStator)  
* [IMyMotorSuspension](Sandbox.ModAPI.IMyMotorSuspension)  
* [IMyOffensiveCombatBlock](Sandbox.ModAPI.IMyOffensiveCombatBlock)  
* [IMyOreDetector](Sandbox.ModAPI.IMyOreDetector)  
* [IMyOxygenFarm](SpaceEngineers.Game.ModAPI.IMyOxygenFarm)  
* [IMyParachute](SpaceEngineers.Game.ModAPI.IMyParachute)  
* [IMyParallelUpdateable](Sandbox.Game.Entities.IMyParallelUpdateable)  
* [IMyPassage](Sandbox.ModAPI.IMyPassage)  
* [IMyPathRecorderBlock](Sandbox.ModAPI.IMyPathRecorderBlock)  
* [IMyPistonBase](Sandbox.ModAPI.IMyPistonBase)  
* [IMyPistonTop](Sandbox.ModAPI.IMyPistonTop)  
* [IMyPowerProducer](Sandbox.ModAPI.IMyPowerProducer)  
* [IMyProductionBlock](Sandbox.ModAPI.IMyProductionBlock)  
* [IMyProgrammableBlock](Sandbox.ModAPI.IMyProgrammableBlock)  
* [IMyProjector](Sandbox.ModAPI.IMyProjector)  
* [IMyRadioAntenna](Sandbox.ModAPI.IMyRadioAntenna)  
* [IMyReactor](Sandbox.ModAPI.IMyReactor)  
* [IMyRefinery](Sandbox.ModAPI.IMyRefinery)  
* [IMyReflectorLight](Sandbox.ModAPI.IMyReflectorLight)  
* [IMyRemoteControl](Sandbox.ModAPI.IMyRemoteControl)  
* [IMySafeZoneBlock](SpaceEngineers.Game.ModAPI.IMySafeZoneBlock)  
* [IMySearchlight](Sandbox.ModAPI.IMySearchlight)  
* [IMySensorBlock](Sandbox.ModAPI.IMySensorBlock)  
* [IMyShipConnector](Sandbox.ModAPI.IMyShipConnector)  
* [IMyShipController](Sandbox.ModAPI.IMyShipController)  
* [IMyShipDrill](Sandbox.ModAPI.IMyShipDrill)  
* [IMyShipGrinder](Sandbox.ModAPI.IMyShipGrinder)  
* [IMyShipMergeBlock](SpaceEngineers.Game.ModAPI.IMyShipMergeBlock)  
* [IMyShipToolBase](Sandbox.ModAPI.IMyShipToolBase)  
* [IMyShipWelder](Sandbox.ModAPI.IMyShipWelder)  
* [IMySmallGatlingGun](Sandbox.ModAPI.IMySmallGatlingGun)  
* [IMySmallMissileLauncher](Sandbox.ModAPI.IMySmallMissileLauncher)  
* [IMySmallMissileLauncherReload](Sandbox.ModAPI.IMySmallMissileLauncherReload)  
* [IMySolarPanel](SpaceEngineers.Game.ModAPI.IMySolarPanel)  
* [IMySoundBlock](SpaceEngineers.Game.ModAPI.IMySoundBlock)  
* [IMySpaceBall](SpaceEngineers.Game.ModAPI.IMySpaceBall)  
* [IMyStoreBlock](Sandbox.ModAPI.IMyStoreBlock)  
* [IMyTargetDummyBlock](Sandbox.ModAPI.IMyTargetDummyBlock)  
* [IMyTargetLockingCapableEntity](Sandbox.Game.EntityComponents.IMyTargetLockingCapableEntity)  
* [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)  
* [IMyTextPanel](Sandbox.ModAPI.IMyTextPanel)  
* [IMyThrust](Sandbox.ModAPI.IMyThrust)  
* [IMyTimerBlock](SpaceEngineers.Game.ModAPI.IMyTimerBlock)  
* [IMyTransponder](SpaceEngineers.Game.ModAPI.IMyTransponder)  
* [IMyTurretControlBlock](SpaceEngineers.Game.ModAPI.IMyTurretControlBlock)  
* [IMyUpgradableBlock](Sandbox.ModAPI.IMyUpgradableBlock)  
* [IMyUpgradeModule](Sandbox.ModAPI.IMyUpgradeModule)  
* [IMyUserControllableGun](Sandbox.ModAPI.IMyUserControllableGun)  
* [IMyVendingMachine](Sandbox.ModAPI.IMyVendingMachine)  
* [IMyVirtualMass](SpaceEngineers.Game.ModAPI.IMyVirtualMass)  
* [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase)  
* [IMyVoxelMap](VRage.Game.ModAPI.IMyVoxelMap)  
* [IMyWarhead](Sandbox.ModAPI.IMyWarhead)  
* [IMyWelder](Sandbox.ModAPI.Weapons.IMyWelder)  
* [IMyWheel](Sandbox.ModAPI.IMyWheel)  
* [IMyWindTurbine](Sandbox.ModAPI.IMyWindTurbine)  
* [MyAdvancedDoor](Sandbox.Game.Entities.MyAdvancedDoor)  
* [MyAirtightDoorGeneric](Sandbox.Game.Entities.MyAirtightDoorGeneric)  
* [MyAirtightHangarDoor](Sandbox.Game.Entities.MyAirtightHangarDoor)  
* [MyAirtightSlideDoor](Sandbox.Game.Entities.MyAirtightSlideDoor)  
* [MyAmmoBase](Sandbox.Game.Weapons.MyAmmoBase)  
* [MyBatteryBlock](Sandbox.Game.Entities.MyBatteryBlock)  
* [MyCameraBlock](Sandbox.Game.Entities.MyCameraBlock)  
* [MyCargoContainer](Sandbox.Game.Entities.MyCargoContainer)  
* [MyCargoContainerInventoryBagEntity](Sandbox.Game.Entities.MyCargoContainerInventoryBagEntity)  
* [MyCockpit](Sandbox.Game.Entities.MyCockpit)  
* [MyConveyor](Sandbox.Game.Entities.MyConveyor)  
* [MyConveyorConnector](Sandbox.Game.Entities.MyConveyorConnector)  
* [MyConveyorSorter](Sandbox.Game.Entities.MyConveyorSorter)  
* [MyCubeBlock](Sandbox.Game.Entities.MyCubeBlock)  
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid)  
* [MyCustomRenderEntitySubpart<TCustomRenderComponent>](Sandbox.Game.Entities.MyCustomRenderEntitySubpart{TCustomRenderComponent})  
* [MyDoor](Sandbox.Game.Entities.MyDoor)  
* [MyDoorBase](Sandbox.Game.Entities.MyDoorBase)  
* [MyEmissiveBlock](Sandbox.Game.Entities.MyEmissiveBlock)  
* [MyEntity](VRage.Game.Entity.MyEntity)  
* [MyEntitySubpart](VRage.Game.Entity.MyEntitySubpart)  
* [MyEnvironmentSector](Sandbox.Game.WorldEnvironment.MyEnvironmentSector)  
* [MyFloatingObject](Sandbox.Game.Entities.MyFloatingObject)  
* [MyForageableEntity](Sandbox.Game.Entities.MyForageableEntity)  
* [MyFueledPowerProducer](Sandbox.Game.Entities.MyFueledPowerProducer)  
* [MyGyro](Sandbox.Game.Entities.MyGyro)  
* [MyHandToolBase](Sandbox.Game.Entities.MyHandToolBase)  
* [MyInventoryBagEntity](Sandbox.Game.Entities.MyInventoryBagEntity)  
* [MyJumpDrive](Sandbox.Game.Entities.MyJumpDrive)  
* [MyKitchen](Sandbox.Game.Entities.MyKitchen)  
* [MyMeteor](Sandbox.Game.Entities.MyMeteor)  
* [MyModifiableEntity](Sandbox.Game.Entities.MyModifiableEntity)  
* [MyPlanet](Sandbox.Game.Entities.MyPlanet)  
* [MyPlanter](Sandbox.Game.Entities.MyPlanter)  
* [MyReactor](Sandbox.Game.Entities.MyReactor)  
* [MyReflectorLight](Sandbox.Game.Entities.MyReflectorLight)  
* [MyRemoteControl](Sandbox.Game.Entities.MyRemoteControl)  
* [MySafeZone](Sandbox.Game.Entities.MySafeZone)  
* [MyShipController](Sandbox.Game.Entities.MyShipController)  
* [MySkinnedEntity](Sandbox.Game.Entities.MySkinnedEntity)  
* [MyThrust](Sandbox.Game.Entities.MyThrust)  
* [MyVoxelBase](Sandbox.Game.Entities.MyVoxelBase)  
* [MyVoxelMap](Sandbox.Game.Entities.MyVoxelMap)  
* [MyWaypoint](Sandbox.Game.Entities.MyWaypoint)  
* [PropellerSubpart](Sandbox.Game.Components.MyRenderComponentThrust+PropellerSubpart)

