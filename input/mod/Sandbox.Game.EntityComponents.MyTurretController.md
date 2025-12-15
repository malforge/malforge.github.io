**Assembly:** Sandbox.Game.dll

```csharp
public class MyTurretController: IMyUsableEntity, IMyEventProxy, IMyEventOwner
```

## Events

|Member|Description|
|---|---|
|[OnCameraOverlayUpdate](Sandbox.Game.EntityComponents.MyTurretController@OnCameraOverlayUpdate)||
|[OnControlAcquired](Sandbox.Game.EntityComponents.MyTurretController@OnControlAcquired)||
|[OnControlReleased](Sandbox.Game.EntityComponents.MyTurretController@OnControlReleased)||
|[OnMoveAndRotationUpdate](Sandbox.Game.EntityComponents.MyTurretController@OnMoveAndRotationUpdate)||
|[OnRotationUpdate](Sandbox.Game.EntityComponents.MyTurretController@OnRotationUpdate)||

## Properties

|Member|Description|
|---|---|
|[CockpitPilot](Sandbox.Game.EntityComponents.MyTurretController@CockpitPilot)||
|[ControllerInfo](Sandbox.Game.EntityComponents.MyTurretController@ControllerInfo)||
|[IsControlled](Sandbox.Game.EntityComponents.MyTurretController@IsControlled)||
|[IsControlledByLocalPlayer](Sandbox.Game.EntityComponents.MyTurretController@IsControlledByLocalPlayer)||
|[IsPlayerControlled](Sandbox.Game.EntityComponents.MyTurretController@IsPlayerControlled)||
|[LastNetCanControl](Sandbox.Game.EntityComponents.MyTurretController@LastNetCanControl)||
|[LastNetMoveState](Sandbox.Game.EntityComponents.MyTurretController@LastNetMoveState)|Used to serialize user input.|
|[LastNetRotateShip](Sandbox.Game.EntityComponents.MyTurretController@LastNetRotateShip)||
|[Pilot](Sandbox.Game.EntityComponents.MyTurretController@Pilot)||
|[PreviousControlledEntity](Sandbox.Game.EntityComponents.MyTurretController@PreviousControlledEntity)||
|[SavedPreviousControlledEntityId](Sandbox.Game.EntityComponents.MyTurretController@SavedPreviousControlledEntityId)||

## Constructors

|Member|Description|
|---|---|
|[MyTurretController(MyCubeBlock)](Sandbox.Game.EntityComponents.MyTurretController@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CanControl()](Sandbox.Game.EntityComponents.MyTurretController@CanControl)||
|[CanUse(UseActionEnum, IMyControllableEntity)](Sandbox.Game.EntityComponents.MyTurretController@CanUse)||
|[CleanControls()](Sandbox.Game.EntityComponents.MyTurretController@CleanControls)||
|[DeserializeControls(BitStream, bool)](Sandbox.Game.EntityComponents.MyTurretController@DeserializeControls)||
|[GetFirstRadioReceiver()](Sandbox.Game.EntityComponents.MyTurretController@GetFirstRadioReceiver)||
|[GetUser()](Sandbox.Game.EntityComponents.MyTurretController@GetUser)||
|[IsInRangeAndPlayerHasAccess()](Sandbox.Game.EntityComponents.MyTurretController@IsInRangeAndPlayerHasAccess)||
|[ReleaseControls(bool)](Sandbox.Game.EntityComponents.MyTurretController@ReleaseControls)||
|[RemoveUsers(bool)](Sandbox.Game.EntityComponents.MyTurretController@RemoveUsers)||
|[RequestControl()](Sandbox.Game.EntityComponents.MyTurretController@RequestControl)||
|[RequestUseMessageImplementation(UseActionEnum, long)](Sandbox.Game.EntityComponents.MyTurretController@RequestUseMessageImplementation)||
|[SerializeControls(BitStream)](Sandbox.Game.EntityComponents.MyTurretController@SerializeControls)||
|[UpdatePlayerControllers()](Sandbox.Game.EntityComponents.MyTurretController@UpdatePlayerControllers)||
|[UseFailureCallback(UseActionEnum, long, UseActionResult)](Sandbox.Game.EntityComponents.MyTurretController@UseFailureCallback)||
|[UseSuccessCallback(UseActionEnum, long, UseActionResult)](Sandbox.Game.EntityComponents.MyTurretController@UseSuccessCallback)||

**Implements:**  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)  
* IMyUsableEntity <sub>prohibited</sub>

