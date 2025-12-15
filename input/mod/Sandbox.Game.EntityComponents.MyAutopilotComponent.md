**Assembly:** Sandbox.Game.dll

```csharp
public class MyAutopilotComponent: MyEventProxyEntityComponent, IMyComponentBase, IMyEntityComponentBase, IMyEventProxy, IMyEventOwner
```

## Fields

|Member|Description|
|---|---|
|[AutoPilotEnabled](Sandbox.Game.EntityComponents.MyAutopilotComponent@AutoPilotEnabled)||
|[WaypointsFromPathRecorder](Sandbox.Game.EntityComponents.MyAutopilotComponent@WaypointsFromPathRecorder)||
|[SyncType](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@SyncType)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBlockReachedWaypoint](Sandbox.Game.EntityComponents.MyAutopilotComponent@OnBlockReachedWaypoint)||
|[OnCurrentWaypointChanged](Sandbox.Game.EntityComponents.MyAutopilotComponent@OnCurrentWaypointChanged)||
|[OnCurrentWaypointIndexChanged](Sandbox.Game.EntityComponents.MyAutopilotComponent@OnCurrentWaypointIndexChanged)||
|[OnMinHeightAboveTerrainChanged](Sandbox.Game.EntityComponents.MyAutopilotComponent@OnMinHeightAboveTerrainChanged)||
|[OnSpeedLimitChanged](Sandbox.Game.EntityComponents.MyAutopilotComponent@OnSpeedLimitChanged)||
|[OnWaypointReached](Sandbox.Game.EntityComponents.MyAutopilotComponent@OnWaypointReached)||
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[static Clipboard](Sandbox.Game.EntityComponents.MyAutopilotComponent@Clipboard)||
|[static DirectionNames](Sandbox.Game.EntityComponents.MyAutopilotComponent@DirectionNames)||
|[AutomaticBehaviour](Sandbox.Game.EntityComponents.MyAutopilotComponent@AutomaticBehaviour)||
|[AutoPilotControlThrust](Sandbox.Game.EntityComponents.MyAutopilotComponent@AutoPilotControlThrust)||
|[ComponentTypeDebugString](Sandbox.Game.EntityComponents.MyAutopilotComponent@ComponentTypeDebugString)||
|[CurrentDestination](Sandbox.Game.EntityComponents.MyAutopilotComponent@CurrentDestination)||
|[CurrentDirection](Sandbox.Game.EntityComponents.MyAutopilotComponent@CurrentDirection)||
|[CurrentFlightMode](Sandbox.Game.EntityComponents.MyAutopilotComponent@CurrentFlightMode)||
|[CurrentWaypoint](Sandbox.Game.EntityComponents.MyAutopilotComponent@CurrentWaypoint)||
|[CurrentWaypointIndex](Sandbox.Game.EntityComponents.MyAutopilotComponent@CurrentWaypointIndex)||
|[CurrentWaypointName](Sandbox.Game.EntityComponents.MyAutopilotComponent@CurrentWaypointName)||
|[CustomLookAtPositionInterceptor](Sandbox.Game.EntityComponents.MyAutopilotComponent@CustomLookAtPositionInterceptor)||
|[Definition](Sandbox.Game.EntityComponents.MyAutopilotComponent@Definition)||
|[FacingDirection](Sandbox.Game.EntityComponents.MyAutopilotComponent@FacingDirection)||
|[FlightMode](Sandbox.Game.EntityComponents.MyAutopilotComponent@FlightMode)||
|[ForceBehaviorUpdate](Sandbox.Game.EntityComponents.MyAutopilotComponent@ForceBehaviorUpdate)||
|[ForcedRotation](Sandbox.Game.EntityComponents.MyAutopilotComponent@ForcedRotation)||
|[HasWaypoints](Sandbox.Game.EntityComponents.MyAutopilotComponent@HasWaypoints)||
|[HeightAdjustmentWaypoint](Sandbox.Game.EntityComponents.MyAutopilotComponent@HeightAdjustmentWaypoint)||
|[IsAlignedToGravity](Sandbox.Game.EntityComponents.MyAutopilotComponent@IsAlignedToGravity)||
|[IsDockingModeEnabled](Sandbox.Game.EntityComponents.MyAutopilotComponent@IsDockingModeEnabled)||
|[IsIdle](Sandbox.Game.EntityComponents.MyAutopilotComponent@IsIdle)||
|[IsMovementPaused](Sandbox.Game.EntityComponents.MyAutopilotComponent@IsMovementPaused)||
|[IsUsingCollisionAvoidance](Sandbox.Game.EntityComponents.MyAutopilotComponent@IsUsingCollisionAvoidance)|Must be used in GUI Only|
|[IsUsingCollisionAvoidanceForLogic](Sandbox.Game.EntityComponents.MyAutopilotComponent@IsUsingCollisionAvoidanceForLogic)|Must be used in logic|
|[IsWaypointBelowMinHeight](Sandbox.Game.EntityComponents.MyAutopilotComponent@IsWaypointBelowMinHeight)||
|[IsWorkAreaReturningToStart](Sandbox.Game.EntityComponents.MyAutopilotComponent@IsWorkAreaReturningToStart)||
|[LookAtPosition](Sandbox.Game.EntityComponents.MyAutopilotComponent@LookAtPosition)||
|[MaxPitchAngle](Sandbox.Game.EntityComponents.MyAutopilotComponent@MaxPitchAngle)||
|[MaxRollAngle](Sandbox.Game.EntityComponents.MyAutopilotComponent@MaxRollAngle)||
|[MinHeightAboveTerrain](Sandbox.Game.EntityComponents.MyAutopilotComponent@MinHeightAboveTerrain)||
|[MinHeightAboveTerraingRaw](Sandbox.Game.EntityComponents.MyAutopilotComponent@MinHeightAboveTerraingRaw)||
|[MinHeightAboveTerrainUnadjusted](Sandbox.Game.EntityComponents.MyAutopilotComponent@MinHeightAboveTerrainUnadjusted)||
|[PreciseRotation](Sandbox.Game.EntityComponents.MyAutopilotComponent@PreciseRotation)||
|[ReferencePosition](Sandbox.Game.EntityComponents.MyAutopilotComponent@ReferencePosition)||
|[SelectedGpsLocations](Sandbox.Game.EntityComponents.MyAutopilotComponent@SelectedGpsLocations)||
|[SelectedWaypoints](Sandbox.Game.EntityComponents.MyAutopilotComponent@SelectedWaypoints)||
|[ShipController](Sandbox.Game.EntityComponents.MyAutopilotComponent@ShipController)||
|[SpeedLimit](Sandbox.Game.EntityComponents.MyAutopilotComponent@SpeedLimit)||
|[TargettingAimDelta](Sandbox.Game.EntityComponents.MyAutopilotComponent@TargettingAimDelta)||
|[ThrustComp](Sandbox.Game.EntityComponents.MyAutopilotComponent@ThrustComp)||
|[WaitForFreeWay](Sandbox.Game.EntityComponents.MyAutopilotComponent@WaitForFreeWay)||
|[Waypoints](Sandbox.Game.EntityComponents.MyAutopilotComponent@Waypoints)||
|[WaypointThresholdDistance](Sandbox.Game.EntityComponents.MyAutopilotComponent@WaypointThresholdDistance)||
|[WorkAreaStartForward](Sandbox.Game.EntityComponents.MyAutopilotComponent@WorkAreaStartForward)||
|[AttachSyncToEntity](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@AttachSyncToEntity)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyAutopilotComponent()](Sandbox.Game.EntityComponents.MyAutopilotComponent@.ctor)||
|[MyEventProxyEntityComponent()](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@.ctor)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|

## Methods

|Member|Description|
|---|---|
|[static FillDirectionCombo(List<MyTerminalControlComboBoxItem>)](Sandbox.Game.EntityComponents.MyAutopilotComponent@FillDirectionCombo)||
|[static FillFlightModeCombo(List<MyTerminalControlComboBoxItem>)](Sandbox.Game.EntityComponents.MyAutopilotComponent@FillFlightModeCombo)||
|[static GetDestinationTriggerSphereScaleFactor(MyCubeSize)](Sandbox.Game.EntityComponents.MyAutopilotComponent@GetDestinationTriggerSphereScaleFactor)||
|[AddedToScene()](Sandbox.Game.EntityComponents.MyAutopilotComponent@AddedToScene)||
|[AddSelectedWaypoints()](Sandbox.Game.EntityComponents.MyAutopilotComponent@AddSelectedWaypoints)||
|[AddWaypoint(Vector3D, string, bool)](Sandbox.Game.EntityComponents.MyAutopilotComponent@AddWaypoint)||
|[AddWaypoint(MyWaypointInfo)](Sandbox.Game.EntityComponents.MyAutopilotComponent@AddWaypoint)||
|[AddWaypointBroadcast(MatrixD, long, string)](Sandbox.Game.EntityComponents.MyAutopilotComponent@AddWaypointBroadcast)||
|[AdvanceWaypoint(bool, bool)](Sandbox.Game.EntityComponents.MyAutopilotComponent@AdvanceWaypoint)||
|[AlignToMinHeight(MyAutopilotWaypoint)](Sandbox.Game.EntityComponents.MyAutopilotComponent@AlignToMinHeight)||
|[CanAddWaypoints()](Sandbox.Game.EntityComponents.MyAutopilotComponent@CanAddWaypoints)||
|[CanEnableAutoPilot()](Sandbox.Game.EntityComponents.MyAutopilotComponent@CanEnableAutoPilot)||
|[CanMoveWaypointsDown()](Sandbox.Game.EntityComponents.MyAutopilotComponent@CanMoveWaypointsDown)||
|[CanMoveWaypointsUp()](Sandbox.Game.EntityComponents.MyAutopilotComponent@CanMoveWaypointsUp)||
|[CanRemoveWaypoints()](Sandbox.Game.EntityComponents.MyAutopilotComponent@CanRemoveWaypoints)||
|[ChangeDirection(Direction)](Sandbox.Game.EntityComponents.MyAutopilotComponent@ChangeDirection)||
|[ChangeFlightMode(FlightMode, bool)](Sandbox.Game.EntityComponents.MyAutopilotComponent@ChangeFlightMode)||
|[ClearWaypoints(bool)](Sandbox.Game.EntityComponents.MyAutopilotComponent@ClearWaypoints)||
|[CopyAutopilotSetup()](Sandbox.Game.EntityComponents.MyAutopilotComponent@CopyAutopilotSetup)||
|[Deserialize(MyObjectBuilder_ComponentBase)](Sandbox.Game.EntityComponents.MyAutopilotComponent@Deserialize)||
|[FillGpsList(ICollection<Item>, ICollection<Item>)](Sandbox.Game.EntityComponents.MyAutopilotComponent@FillGpsList)||
|[FillWaypointList(ICollection<Item>, ICollection<Item>)](Sandbox.Game.EntityComponents.MyAutopilotComponent@FillWaypointList)||
|[ForceRotateRequested(QuaternionD?)](Sandbox.Game.EntityComponents.MyAutopilotComponent@ForceRotateRequested)||
|[ForceRotateToLookAtRequested(bool)](Sandbox.Game.EntityComponents.MyAutopilotComponent@ForceRotateToLookAtRequested)||
|[GetCurrentLookVector()](Sandbox.Game.EntityComponents.MyAutopilotComponent@GetCurrentLookVector)||
|[Init(MyComponentDefinitionBase)](Sandbox.Game.EntityComponents.MyAutopilotComponent@Init)||
|[InitWithObjectBuilder(MyObjectBuilder_RemoteControl)](Sandbox.Game.EntityComponents.MyAutopilotComponent@InitWithObjectBuilder)||
|[InitWithOwnObjectBuilder()](Sandbox.Game.EntityComponents.MyAutopilotComponent@InitWithOwnObjectBuilder)||
|[IsSerialized()](Sandbox.Game.EntityComponents.MyAutopilotComponent@IsSerialized)||
|[MoveSelectedWaypointsDown()](Sandbox.Game.EntityComponents.MyAutopilotComponent@MoveSelectedWaypointsDown)||
|[MoveSelectedWaypointsUp()](Sandbox.Game.EntityComponents.MyAutopilotComponent@MoveSelectedWaypointsUp)||
|[OnAddedToContainer()](Sandbox.Game.EntityComponents.MyAutopilotComponent@OnAddedToContainer)||
|[OnBeforeRemovedFromContainer()](Sandbox.Game.EntityComponents.MyAutopilotComponent@OnBeforeRemovedFromContainer)||
|[OnEvasiveManeuversChanged(int, int)](Sandbox.Game.EntityComponents.MyAutopilotComponent@OnEvasiveManeuversChanged)||
|[OnRemoveWaypoints(Int32[])](Sandbox.Game.EntityComponents.MyAutopilotComponent@OnRemoveWaypoints)||
|[PasteAutopilotSetup()](Sandbox.Game.EntityComponents.MyAutopilotComponent@PasteAutopilotSetup)||
|[RaisePropertiesChangedRemote()](Sandbox.Game.EntityComponents.MyAutopilotComponent@RaisePropertiesChangedRemote)||
|[RemoveAutoPilot()](Sandbox.Game.EntityComponents.MyAutopilotComponent@RemoveAutoPilot)||
|[RemoveSelectedWaypoints()](Sandbox.Game.EntityComponents.MyAutopilotComponent@RemoveSelectedWaypoints)||
|[RemoveWaypoint(MyAutopilotWaypoint)](Sandbox.Game.EntityComponents.MyAutopilotComponent@RemoveWaypoint)||
|[ResetShipControls()](Sandbox.Game.EntityComponents.MyAutopilotComponent@ResetShipControls)||
|[ResetWaypoint()](Sandbox.Game.EntityComponents.MyAutopilotComponent@ResetWaypoint)||
|[SelectGps(List<Item>)](Sandbox.Game.EntityComponents.MyAutopilotComponent@SelectGps)||
|[SelectWaypoint(List<Item>)](Sandbox.Game.EntityComponents.MyAutopilotComponent@SelectWaypoint)||
|[Serialize(bool)](Sandbox.Game.EntityComponents.MyAutopilotComponent@Serialize)||
|[SetAutopilot(bool)](Sandbox.Game.EntityComponents.MyAutopilotComponent@SetAutopilot)||
|[SetAutoPilotEnabled(bool)](Sandbox.Game.EntityComponents.MyAutopilotComponent@SetAutoPilotEnabled)||
|[SetCustomAdjustWaypointAboveMinHeightFunction(CustomAdjustWaypointAboveMinHeightFunction)](Sandbox.Game.EntityComponents.MyAutopilotComponent@SetCustomAdjustWaypointAboveMinHeightFunction)||
|[SetCustomMovementFunction(CustomMovementFunction)](Sandbox.Game.EntityComponents.MyAutopilotComponent@SetCustomMovementFunction)||
|[SetWaitForFreeWay(bool)](Sandbox.Game.EntityComponents.MyAutopilotComponent@SetWaitForFreeWay)||
|[SetWaypoint(MyAutopilotWaypoint)](Sandbox.Game.EntityComponents.MyAutopilotComponent@SetWaypoint)||
|[SetWaypoints(List<MyAutopilotWaypoint>, bool, bool, bool)](Sandbox.Game.EntityComponents.MyAutopilotComponent@SetWaypoints)||
|[Toolbar_ItemChanged(MyToolbar, IndexArgs, bool)](Sandbox.Game.EntityComponents.MyAutopilotComponent@Toolbar_ItemChanged)||
|[UpdateAfterSimulation10()](Sandbox.Game.EntityComponents.MyAutopilotComponent@UpdateAfterSimulation10)||
|[UpdateAutopilot()](Sandbox.Game.EntityComponents.MyAutopilotComponent@UpdateAutopilot)||
|[UpdateOnceBeforeFrame()](Sandbox.Game.EntityComponents.MyAutopilotComponent@UpdateOnceBeforeFrame)||
|[UpdateWaypointMatrix(MatrixD)](Sandbox.Game.EntityComponents.MyAutopilotComponent@UpdateWaypointMatrix)||
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@OnBeforeRemovedFromContainer)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)

