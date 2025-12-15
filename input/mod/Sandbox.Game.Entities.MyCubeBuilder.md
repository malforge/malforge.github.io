**Assembly:** Sandbox.Game.dll

```csharp
public class MyCubeBuilder: MyBlockBuilderBase, IMyUserInputComponent, IMyFocusHolder, IMyCubeBuilder
```

## Fields

|Member|Description|
|---|---|
|[static AllPlayersColors](Sandbox.Game.Entities.MyCubeBuilder@AllPlayersColors)||
|[static Static](Sandbox.Game.Entities.MyCubeBuilder@Static)||
|[m_toolType](Sandbox.Game.Entities.MyCubeBuilder@m_toolType)||
|[MaxGridDistanceFrom](Sandbox.Game.Entities.MyCubeBuilder@MaxGridDistanceFrom)||
|[ComponentType](VRage.Game.Components.MySessionComponentBase@ComponentType)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[DebugName](VRage.Game.Components.MySessionComponentBase@DebugName)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Priority](VRage.Game.Components.MySessionComponentBase@Priority)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|

## Events

|Member|Description|
|---|---|
|[OnActivated](Sandbox.Game.Entities.MyCubeBuilder@OnActivated)||
|[OnBlockAdded](Sandbox.Game.Entities.MyCubeBuilder@OnBlockAdded)||
|[OnBlockSizeChanged](Sandbox.Game.Entities.MyCubeBuilder@OnBlockSizeChanged)||
|[OnBlockVariantChanged](Sandbox.Game.Entities.MyCubeBuilder@OnBlockVariantChanged)||
|[OnDeactivated](Sandbox.Game.Entities.MyCubeBuilder@OnDeactivated)||
|[OnSymmetrySetupModeChanged](Sandbox.Game.Entities.MyCubeBuilder@OnSymmetrySetupModeChanged)||
|[OnToolTypeChanged](Sandbox.Game.Entities.MyCubeBuilder@OnToolTypeChanged)||

## Properties

|Member|Description|
|---|---|
|[static BuildComponent](Sandbox.Game.Entities.MyCubeBuilder@BuildComponent)||
|[static BuildingMode](Sandbox.Game.Entities.MyCubeBuilder@BuildingMode)||
|[static CameraControllerSpectator](Sandbox.Game.Entities.MyBlockBuilderBase@CameraControllerSpectator)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[static CubeBuilderDefinition](Sandbox.Game.Entities.MyBlockBuilderBase@CubeBuilderDefinition)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[static IntersectionDirection](Sandbox.Game.Entities.MyBlockBuilderBase@IntersectionDirection)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[static IntersectionDistance](Sandbox.Game.Entities.MyBlockBuilderBase@IntersectionDistance)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[static IntersectionStart](Sandbox.Game.Entities.MyBlockBuilderBase@IntersectionStart)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[static PlacementProvider](Sandbox.Game.Entities.MyBlockBuilderBase@PlacementProvider)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[static SpectatorIsBuilding](Sandbox.Game.Entities.MyBlockBuilderBase@SpectatorIsBuilding)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[AlignToDefault](Sandbox.Game.Entities.MyCubeBuilder@AlignToDefault)||
|[BlockCreationIsActivated](Sandbox.Game.Entities.MyCubeBuilder@BlockCreationIsActivated)||
|[CubeBuilderState](Sandbox.Game.Entities.MyCubeBuilder@CubeBuilderState)||
|[CubePlacementMode](Sandbox.Game.Entities.MyCubeBuilder@CubePlacementMode)||
|[CurrentBlockDefinition](Sandbox.Game.Entities.MyCubeBuilder@CurrentBlockDefinition)||
|[Dependencies](Sandbox.Game.Entities.MyCubeBuilder@Dependencies)||
|[DynamicMode](Sandbox.Game.Entities.MyCubeBuilder@DynamicMode)||
|[FreezeGizmo](Sandbox.Game.Entities.MyCubeBuilder@FreezeGizmo)||
|[IsActivated](Sandbox.Game.Entities.MyCubeBuilder@IsActivated)||
|[IsBuildMode](Sandbox.Game.Entities.MyCubeBuilder@IsBuildMode)||
|[IsCubeSizeModesAvailable](Sandbox.Game.Entities.MyCubeBuilder@IsCubeSizeModesAvailable)||
|[PlacingSmallGridOnLargeStatic](Sandbox.Game.Entities.MyCubeBuilder@PlacingSmallGridOnLargeStatic)||
|[RotationAxis](Sandbox.Game.Entities.MyCubeBuilder@RotationAxis)||
|[ShowRemoveGizmo](Sandbox.Game.Entities.MyCubeBuilder@ShowRemoveGizmo)||
|[ToolbarBlockDefinition](Sandbox.Game.Entities.MyCubeBuilder@ToolbarBlockDefinition)|Current block definition for toolbar.|
|[ToolType](Sandbox.Game.Entities.MyCubeBuilder@ToolType)||
|[UseSymmetry](Sandbox.Game.Entities.MyCubeBuilder@UseSymmetry)||
|[UseTransparency](Sandbox.Game.Entities.MyCubeBuilder@UseTransparency)||
|[BlockCreationIsActivated](VRage.Game.ModAPI.IMyCubeBuilder@BlockCreationIsActivated)|Returns state of building mode<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|
|[CurrentBlockDefinition](Sandbox.Game.Entities.MyBlockBuilderBase@CurrentBlockDefinition)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[Definition](VRage.Game.Components.MySessionComponentBase@Definition)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Dependencies](VRage.Game.Components.MySessionComponentBase@Dependencies)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[FreePlacementTarget](Sandbox.Game.Entities.MyBlockBuilderBase@FreePlacementTarget)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[FreezeGizmo](VRage.Game.ModAPI.IMyCubeBuilder@FreezeGizmo)|Freezes the built object preview in current position<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|
|[HitInfo](Sandbox.Game.Entities.MyBlockBuilderBase@HitInfo)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[Initialized](VRage.Game.Components.MySessionComponentBase@Initialized)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[IsActivated](VRage.Game.ModAPI.IMyCubeBuilder@IsActivated)|Gets whether there block creation is activated<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|
|[IsActivated](Sandbox.Game.Entities.MyBlockBuilderBase@IsActivated)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[IsRequiredByGame](VRage.Game.Components.MySessionComponentBase@IsRequiredByGame)|Indicates whether a session component should be used in current configuration. Example: MyDestructionData component returns true only when game uses Havok Destruction<br /><br />_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[IsServerOnly](VRage.Game.Components.MySessionComponentBase@IsServerOnly)|Is server only is used for client request of the world. if the component is server only, it's not sent to the client on world request.<br /><br />_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Loaded](VRage.Game.Components.MySessionComponentBase@Loaded)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[ModContext](VRage.Game.Components.MySessionComponentBase@ModContext)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[ObjectBuilderType](VRage.Game.Components.MySessionComponentBase@ObjectBuilderType)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Session](VRage.Game.Components.MySessionComponentBase@Session)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[ShowRemoveGizmo](VRage.Game.ModAPI.IMyCubeBuilder@ShowRemoveGizmo)|Shows the delete area preview<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|
|[UpdateOnPause](VRage.Game.Components.MySessionComponentBase@UpdateOnPause)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UpdateOrder](VRage.Game.Components.MySessionComponentBase@UpdateOrder)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UseSymmetry](VRage.Game.ModAPI.IMyCubeBuilder@UseSymmetry)|Enables symmetry block placing<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|
|[UseTransparency](VRage.Game.ModAPI.IMyCubeBuilder@UseTransparency)|Gets or sets whether projected block should be 25% transparent<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|

## Constructors

|Member|Description|
|---|---|
|[MyCubeBuilder()](Sandbox.Game.Entities.MyCubeBuilder@.ctor)||
|[MySessionComponentBase()](VRage.Game.Components.MySessionComponentBase@.ctor)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|

## Methods

|Member|Description|
|---|---|
|[static AutogenerateMountpoints(MyModel, float)](Sandbox.Game.Entities.MyCubeBuilder@AutogenerateMountpoints)||
|[static AutogenerateMountpoints(HkShape[], float)](Sandbox.Game.Entities.MyCubeBuilder@AutogenerateMountpoints)||
|[static CalculateBlockRotation(int, int, ref MatrixD, out MatrixD, double, MyBlockDirection, MyBlockRotation)](Sandbox.Game.Entities.MyCubeBuilder@CalculateBlockRotation)||
|[static CheckValidBlockRotation(Matrix, MyBlockDirection, MyBlockRotation)](Sandbox.Game.Entities.MyCubeBuilder@CheckValidBlockRotation)||
|[static CheckValidBlocksRotation(Matrix, MyCubeGrid)](Sandbox.Game.Entities.MyCubeBuilder@CheckValidBlocksRotation)||
|[static ConvertDynamicGridBlockToStatic(ref MatrixD, MyObjectBuilder_CubeBlock)](Sandbox.Game.Entities.MyCubeBuilder@ConvertDynamicGridBlockToStatic)||
|[static ConvertGridBuilderToStatic(MyObjectBuilder_CubeGrid, MatrixD)](Sandbox.Game.Entities.MyCubeBuilder@ConvertGridBuilderToStatic)||
|[static DrawMountPoints(float, MyCubeBlockDefinition, ref MatrixD)](Sandbox.Game.Entities.MyCubeBuilder@DrawMountPoints)||
|[static DrawMountPoints(float, MyCubeBlockDefinition, MatrixD, MountPoint[])](Sandbox.Game.Entities.MyCubeBuilder@DrawMountPoints)||
|[static DrawSemiTransparentBox(MyCubeGrid, MySlimBlock, Color, bool, MyStringId?, Vector4?)](Sandbox.Game.Entities.MyCubeBuilder@DrawSemiTransparentBox)||
|[static DrawSemiTransparentBox(Vector3I, Vector3I, MyCubeGrid, Color, bool, MyStringId?, Vector4?)](Sandbox.Game.Entities.MyCubeBuilder@DrawSemiTransparentBox)||
|[static GetAllBlocksPositions(HashSet<Tuple`2>, HashSet<Vector3I>)](Sandbox.Game.Entities.MyCubeBuilder@GetAllBlocksPositions)||
|[static GetCurrentRayIntersection()](Sandbox.Game.Entities.MyCubeBuilder@GetCurrentRayIntersection)||
|[static PrepareCharacterCollisionPoints(List<Vector3D>)](Sandbox.Game.Entities.MyCubeBuilder@PrepareCharacterCollisionPoints)||
|[static RemovePlayerColors(PlayerId)](Sandbox.Game.Entities.MyCubeBuilder@RemovePlayerColors)||
|[static RemovePlayerColors_Internal(PlayerId)](Sandbox.Game.Entities.MyCubeBuilder@RemovePlayerColors_Internal)||
|[static SelectBlockToToolbar(MySlimBlock, bool)](Sandbox.Game.Entities.MyCubeBuilder@SelectBlockToToolbar)||
|[static SpawnDynamicGrid(MyCubeBlockDefinition, MyEntity, MatrixD, Vector3, MyStringHash, long, SpawnFlags, long, Action<MyEntity>)](Sandbox.Game.Entities.MyCubeBuilder@SpawnDynamicGrid)||
|[static SpawnStaticGrid(MyCubeBlockDefinition, MyEntity, MatrixD, Vector3, MyStringHash, SpawnFlags, long, Action<MyEntity>)](Sandbox.Game.Entities.MyCubeBuilder@SpawnStaticGrid)||
|[static SpawnStaticGrid_nonParalel(MyCubeBlockDefinition, MyEntity, MatrixD, Vector3, MyStringHash, SpawnFlags, long)](Sandbox.Game.Entities.MyCubeBuilder@SpawnStaticGrid_nonParalel)||
|[static TransformLargeGridHitCoordToSmallGrid(Vector3D, MatrixD, float)](Sandbox.Game.Entities.MyCubeBuilder@TransformLargeGridHitCoordToSmallGrid)|Converts large grid hit coordinates for small cubes. Allows placement of small grids to large grids. Returns coordinates of small grid (in large grid coordinates) which touches large grid in the hit position.|
|[static ComputeSteps(Vector3I, Vector3I, Vector3I, out Vector3I, out Vector3I, out int)](Sandbox.Game.Entities.MyBlockBuilderBase@ComputeSteps)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[Activate(MyDefinitionId?, bool)](Sandbox.Game.Entities.MyCubeBuilder@Activate)||
|[ActivateColorTool()](Sandbox.Game.Entities.MyCubeBuilder@ActivateColorTool)||
|[ActivateFromRadialMenu(MyDefinitionId?)](Sandbox.Game.Entities.MyCubeBuilder@ActivateFromRadialMenu)||
|[Add()](Sandbox.Game.Entities.MyCubeBuilder@Add)||
|[AddBlocksToBuildQueueOrSpawn(MyCubeBlockDefinition, ref MatrixD, Vector3I, Vector3I, Vector3I, Quaternion)](Sandbox.Game.Entities.MyCubeBuilder@AddBlocksToBuildQueueOrSpawn)||
|[AddConstruction(MyEntity)](Sandbox.Game.Entities.MyCubeBuilder@AddConstruction)||
|[AddFastBuildModels(MatrixD, ref Matrix, List<MatrixD>, List<string>, MyCubeBlockDefinition, Vector3I?, Vector3I?)](Sandbox.Game.Entities.MyCubeBuilder@AddFastBuildModels)||
|[AlignToGravity(bool)](Sandbox.Game.Entities.MyCubeBuilder@AlignToGravity)||
|[CanStartConstruction(MyEntity)](Sandbox.Game.Entities.MyCubeBuilder@CanStartConstruction)||
|[CheckGizmoRotation()](Sandbox.Game.Entities.MyCubeBuilder@CheckGizmoRotation)||
|[ColorPickerCancel()](Sandbox.Game.Entities.MyCubeBuilder@ColorPickerCancel)||
|[ColorPickerOk()](Sandbox.Game.Entities.MyCubeBuilder@ColorPickerOk)||
|[ContinueBuilding(bool)](Sandbox.Game.Entities.MyCubeBuilder@ContinueBuilding)||
|[CycleCubePlacementMode()](Sandbox.Game.Entities.MyCubeBuilder@CycleCubePlacementMode)||
|[Deactivate()](Sandbox.Game.Entities.MyCubeBuilder@Deactivate)||
|[DeactivateBlockCreation()](Sandbox.Game.Entities.MyCubeBuilder@DeactivateBlockCreation)||
|[Draw()](Sandbox.Game.Entities.MyCubeBuilder@Draw)||
|[GetAddAndRemovePositions(float, bool, out Vector3I, out Vector3?, out Vector3I, out Vector3I, out MySlimBlock, out ushort?, HashSet<Tuple`2>)](Sandbox.Game.Entities.MyCubeBuilder@GetAddAndRemovePositions)||
|[GetAddPosition(out Vector3D)](Sandbox.Game.Entities.MyCubeBuilder@GetAddPosition)||
|[GetBuildBoundingBox(float)](Sandbox.Game.Entities.MyCubeBuilder@GetBuildBoundingBox)||
|[GetNextBlockVariantDefinition()](Sandbox.Game.Entities.MyCubeBuilder@GetNextBlockVariantDefinition)||
|[HandleGameInput()](Sandbox.Game.Entities.MyCubeBuilder@HandleGameInput)||
|[InitFromDefinition(MySessionComponentDefinition)](Sandbox.Game.Entities.MyCubeBuilder@InitFromDefinition)||
|[InputLost()](Sandbox.Game.Entities.MyCubeBuilder@InputLost)||
|[IsBuildToolActive()](Sandbox.Game.Entities.MyCubeBuilder@IsBuildToolActive)||
|[IsOnlyColorToolActive()](Sandbox.Game.Entities.MyCubeBuilder@IsOnlyColorToolActive)||
|[IsSymmetrySetupMode()](Sandbox.Game.Entities.MyCubeBuilder@IsSymmetrySetupMode)||
|[LoadData()](Sandbox.Game.Entities.MyCubeBuilder@LoadData)||
|[NotifyPlacementUnable()](Sandbox.Game.Entities.MyCubeBuilder@NotifyPlacementUnable)||
|[OnClosedMessageBox(ResultEnum)](Sandbox.Game.Entities.MyCubeBuilder@OnClosedMessageBox)||
|[OnLostFocus()](Sandbox.Game.Entities.MyCubeBuilder@OnLostFocus)||
|[SetToolType(MyCubeBuilderToolType)](Sandbox.Game.Entities.MyCubeBuilder@SetToolType)||
|[StartBuilding()](Sandbox.Game.Entities.MyCubeBuilder@StartBuilding)||
|[StartStaticGridPlacement(MyCubeSize, bool)](Sandbox.Game.Entities.MyCubeBuilder@StartStaticGridPlacement)||
|[StopBuilding()](Sandbox.Game.Entities.MyCubeBuilder@StopBuilding)||
|[ToggleSymmetry()](Sandbox.Game.Entities.MyCubeBuilder@ToggleSymmetry)||
|[ToggleSymmetrySetup()](Sandbox.Game.Entities.MyCubeBuilder@ToggleSymmetrySetup)||
|[UpdateAfterSimulation()](Sandbox.Game.Entities.MyCubeBuilder@UpdateAfterSimulation)||
|[UpdateBeforeSimulation()](Sandbox.Game.Entities.MyCubeBuilder@UpdateBeforeSimulation)||
|[UpdateNotificationBlockNotAvailable(bool)](Sandbox.Game.Entities.MyCubeBuilder@UpdateNotificationBlockNotAvailable)||
|[Activate(MyDefinitionId?)](VRage.Game.ModAPI.IMyCubeBuilder@Activate)|Activates the building mode<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|
|[Activate(MyDefinitionId?, bool)](Sandbox.Game.Entities.MyBlockBuilderBase@Activate)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[AfterLoadData()](VRage.Game.Components.MySessionComponentBase@AfterLoadData)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[BeforeStart()](VRage.Game.Components.MySessionComponentBase@BeforeStart)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Deactivate()](VRage.Game.ModAPI.IMyCubeBuilder@Deactivate)|Deactivates all modes<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|
|[Deactivate()](Sandbox.Game.Entities.MyBlockBuilderBase@Deactivate)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[DeactivateBlockCreation()](VRage.Game.ModAPI.IMyCubeBuilder@DeactivateBlockCreation)|Deactivates building mode<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|
|[Draw()](VRage.Game.Components.MySessionComponentBase@Draw)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[FindClosestGrid()](VRage.Game.ModAPI.IMyCubeBuilder@FindClosestGrid)|Finds grid to build on<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|
|[FindClosestGrid()](Sandbox.Game.Entities.MyBlockBuilderBase@FindClosestGrid)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[FindClosestPlacementObject(out MyCubeGrid, out MyVoxelBase)](Sandbox.Game.Entities.MyBlockBuilderBase@FindClosestPlacementObject)|Finds closest object (grid or voxel map) for placement of blocks .<br /><br />_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[GetObjectBuilder()](VRage.Game.Components.MySessionComponentBase@GetObjectBuilder)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[HandleInput()](VRage.Game.Components.Interfaces.IMyUserInputComponent@HandleInput)|_Inherited from [IMyUserInputComponent](VRage.Game.Components.Interfaces.IMyUserInputComponent)_|
|[HandleInput()](VRage.Game.Components.MySessionComponentBase@HandleInput)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Init(MyObjectBuilder_SessionComponent)](VRage.Game.Components.MySessionComponentBase@Init)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[InitFromDefinition(MySessionComponentDefinition)](Sandbox.Game.Entities.MyBlockBuilderBase@InitFromDefinition)|_Inherited from [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)_|
|[InitFromDefinition(MySessionComponentDefinition)](VRage.Game.Components.MySessionComponentBase@InitFromDefinition)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[LoadData()](VRage.Game.Components.MySessionComponentBase@LoadData)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[SaveData()](VRage.Game.Components.MySessionComponentBase@SaveData)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[SetUpdateOrder(MyUpdateOrder)](VRage.Game.Components.MySessionComponentBase@SetUpdateOrder)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[Simulate()](VRage.Game.Components.MySessionComponentBase@Simulate)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[StartNewGridPlacement(MyCubeSize, bool)](VRage.Game.ModAPI.IMyCubeBuilder@StartNewGridPlacement)|Calls [Activate(MyDefinitionId?)](VRage.Game.ModAPI.IMyCubeBuilder@Activate) with LargeBlockArmorBlock definition and forces local player stop using weapon or tool<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|
|[ToString()](VRage.Game.Components.MySessionComponentBase@ToString)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UnloadDataConditional()](VRage.Game.Components.MySessionComponentBase@UnloadDataConditional)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UpdateAfterSimulation()](VRage.Game.Components.MySessionComponentBase@UpdateAfterSimulation)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UpdateBeforeSimulation()](VRage.Game.Components.MySessionComponentBase@UpdateBeforeSimulation)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UpdatedBeforeInit()](VRage.Game.Components.MySessionComponentBase@UpdatedBeforeInit)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[UpdatingStopped()](VRage.Game.Components.MySessionComponentBase@UpdatingStopped)|_Inherited from [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase)_|
|[AddConstruction(IMyEntity)](VRage.Game.ModAPI.IMyCubeBuilder@AddConstruction)|_**Obsolete:** Not used. Always returns false_<br /><br />_Inherited from [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)_|

**Inheritance:**   [MySessionComponentBase](VRage.Game.Components.MySessionComponentBase) ˃ [MyBlockBuilderBase](Sandbox.Game.Entities.MyBlockBuilderBase)

**Implements:**  
* [IMyCubeBuilder](VRage.Game.ModAPI.IMyCubeBuilder)  
* IMyFocusHolder <sub>prohibited</sub>  
* [IMyUserInputComponent](VRage.Game.Components.Interfaces.IMyUserInputComponent)

