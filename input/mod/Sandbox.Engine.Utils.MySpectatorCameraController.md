**Assembly:** Sandbox.Game.dll

```csharp
public class MySpectatorCameraController: MySpectator, IMyCameraController
```

## Fields

|Member|Description|
|---|---|
|[static DEFAULT_SPECTATOR_ANGULAR_SPEED](VRage.MySpectator@DEFAULT_SPECTATOR_ANGULAR_SPEED)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[static DEFAULT_SPECTATOR_LINEAR_SPEED](VRage.MySpectator@DEFAULT_SPECTATOR_LINEAR_SPEED)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[static MAX_SPECTATOR_ANGULAR_SPEED](VRage.MySpectator@MAX_SPECTATOR_ANGULAR_SPEED)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[static MAX_SPECTATOR_LINEAR_SPEED](VRage.MySpectator@MAX_SPECTATOR_LINEAR_SPEED)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[static MIN_SPECTATOR_ANGULAR_SPEED](VRage.MySpectator@MIN_SPECTATOR_ANGULAR_SPEED)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[static MIN_SPECTATOR_LINEAR_SPEED](VRage.MySpectator@MIN_SPECTATOR_LINEAR_SPEED)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[static Static](VRage.MySpectator@Static)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[ThirdPersonCameraDelta](VRage.MySpectator@ThirdPersonCameraDelta)|_Inherited from [MySpectator](VRage.MySpectator)_|

## Events

|Member|Description|
|---|---|
|[OnModeChanged](VRage.MySpectator@OnModeChanged)|_Inherited from [MySpectator](VRage.MySpectator)_|

## Properties

|Member|Description|
|---|---|
|[AllowCubeBuilding](VRage.Game.ModAPI.Interfaces.IMyCameraController@AllowCubeBuilding)|Gets if player block building enabled<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[EnableFirstPersonView](VRage.Game.ModAPI.Interfaces.IMyCameraController@EnableFirstPersonView)|Gets or set if player can use first person view<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[Entity](VRage.Game.ModAPI.Interfaces.IMyCameraController@Entity)|Gets Entity to which it is attached<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[ForceFirstPersonCamera](VRage.Game.ModAPI.Interfaces.IMyCameraController@ForceFirstPersonCamera)|Gets or sets if player can use only first person view<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[ForceFirstPersonCamera](VRage.MySpectator@ForceFirstPersonCamera)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[Initialized](VRage.MySpectator@Initialized)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[IsInFirstPersonView](VRage.Game.ModAPI.Interfaces.IMyCameraController@IsInFirstPersonView)|Gets or sets if the current camera view is first person.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[IsInFirstPersonView](VRage.MySpectator@IsInFirstPersonView)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[Orientation](VRage.MySpectator@Orientation)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[Position](VRage.MySpectator@Position)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[SpectatorCameraMovement](VRage.MySpectator@SpectatorCameraMovement)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[SpeedModeAngular](VRage.MySpectator@SpeedModeAngular)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[SpeedModeLinear](VRage.MySpectator@SpeedModeLinear)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[Target](VRage.MySpectator@Target)|_Inherited from [MySpectator](VRage.MySpectator)_|

## Constructors

|Member|Description|
|---|---|
|[MySpectator()](VRage.MySpectator@.ctor)|_Inherited from [MySpectator](VRage.MySpectator)_|

## Methods

|Member|Description|
|---|---|
|[ControlCamera(MyCamera)](VRage.Game.ModAPI.Interfaces.IMyCameraController@ControlCamera)|Change camera properties now. Communication: from controller to camera.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[GetOverridingFocusMatrix()](VRage.Game.ModAPI.Interfaces.IMyCameraController@GetOverridingFocusMatrix)|Transformation that should be used for target selection while focusing<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[GetViewMatrix()](VRage.MySpectator@GetViewMatrix)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[HandlePickUp()](VRage.Game.ModAPI.Interfaces.IMyCameraController@HandlePickUp)|Does nothing.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[HandleUse()](VRage.Game.ModAPI.Interfaces.IMyCameraController@HandleUse)|Used to send "use" commands to camera controller<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[MoveAndRotate(Vector3, Vector2, float)](VRage.MySpectator@MoveAndRotate)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[MoveAndRotateStopped()](VRage.MySpectator@MoveAndRotateStopped)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[OnAssumeControl(IMyCameraController)](VRage.Game.ModAPI.Interfaces.IMyCameraController@OnAssumeControl)|Called when it is setted as new main camera controller<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[OnReleaseControl(IMyCameraController)](VRage.Game.ModAPI.Interfaces.IMyCameraController@OnReleaseControl)|Called when new camera controller setted, and this was main camera controller<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[Reset()](VRage.MySpectator@Reset)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[Rotate(Vector2, float)](VRage.Game.ModAPI.Interfaces.IMyCameraController@Rotate)|Rotate camera controller.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[Rotate(Vector2, float)](VRage.MySpectator@Rotate)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[RotateStopped()](VRage.Game.ModAPI.Interfaces.IMyCameraController@RotateStopped)|Rotation of camera controller stopped.<br /><br />_Inherited from [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)_|
|[RotateStopped()](VRage.MySpectator@RotateStopped)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[SetTarget(Vector3D, Vector3D?)](VRage.MySpectator@SetTarget)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[SetViewMatrix(MatrixD)](VRage.MySpectator@SetViewMatrix)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[Update()](VRage.MySpectator@Update)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[UpdateCameraPosition(Vector2)](VRage.MySpectator@UpdateCameraPosition)|_Inherited from [MySpectator](VRage.MySpectator)_|
|[UpdateOrientation()](VRage.MySpectator@UpdateOrientation)|_Inherited from [MySpectator](VRage.MySpectator)_|

**Inheritance:**   [MySpectator](VRage.MySpectator)

**Implements:**  
* [IMyCameraController](VRage.Game.ModAPI.Interfaces.IMyCameraController)

