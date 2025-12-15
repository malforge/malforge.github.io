**Assembly:** VRage.Game.dll

```csharp
public interface IMyCameraController
```

Interface to control game camera (not block) (mods interface)

## Properties

|Member|Description|
|---|---|
|[AllowCubeBuilding](VRage.Game.ModAPI.Interfaces.IMyCameraController@AllowCubeBuilding)|Gets if player block building enabled|
|[EnableFirstPersonView](VRage.Game.ModAPI.Interfaces.IMyCameraController@EnableFirstPersonView)|Gets or set if player can use first person view|
|[Entity](VRage.Game.ModAPI.Interfaces.IMyCameraController@Entity)|Gets Entity to which it is attached|
|[ForceFirstPersonCamera](VRage.Game.ModAPI.Interfaces.IMyCameraController@ForceFirstPersonCamera)|Gets or sets if player can use only first person view|
|[IsInFirstPersonView](VRage.Game.ModAPI.Interfaces.IMyCameraController@IsInFirstPersonView)|Gets or sets if the current camera view is first person.|

## Methods

|Member|Description|
|---|---|
|[ControlCamera(MyCamera)](VRage.Game.ModAPI.Interfaces.IMyCameraController@ControlCamera)|Change camera properties now. Communication: from controller to camera.|
|[GetOverridingFocusMatrix()](VRage.Game.ModAPI.Interfaces.IMyCameraController@GetOverridingFocusMatrix)|Transformation that should be used for target selection while focusing|
|[HandlePickUp()](VRage.Game.ModAPI.Interfaces.IMyCameraController@HandlePickUp)|Does nothing.|
|[HandleUse()](VRage.Game.ModAPI.Interfaces.IMyCameraController@HandleUse)|Used to send "use" commands to camera controller|
|[OnAssumeControl(IMyCameraController)](VRage.Game.ModAPI.Interfaces.IMyCameraController@OnAssumeControl)|Called when it is setted as new main camera controller|
|[OnReleaseControl(IMyCameraController)](VRage.Game.ModAPI.Interfaces.IMyCameraController@OnReleaseControl)|Called when new camera controller setted, and this was main camera controller|
|[Rotate(Vector2, float)](VRage.Game.ModAPI.Interfaces.IMyCameraController@Rotate)|Rotate camera controller.|
|[RotateStopped()](VRage.Game.ModAPI.Interfaces.IMyCameraController@RotateStopped)|Rotation of camera controller stopped.|

**Inheritors:**  
* [IMyCameraBlock](Sandbox.ModAPI.IMyCameraBlock)  
* [IMyCharacter](VRage.Game.ModAPI.IMyCharacter)  
* [IMyCockpit](Sandbox.ModAPI.IMyCockpit)  
* [IMyCryoChamber](Sandbox.ModAPI.IMyCryoChamber)  
* [IMyLargeConveyorTurretBase](SpaceEngineers.Game.ModAPI.IMyLargeConveyorTurretBase)  
* [IMyLargeGatlingTurret](SpaceEngineers.Game.ModAPI.IMyLargeGatlingTurret)  
* [IMyLargeInteriorTurret](SpaceEngineers.Game.ModAPI.IMyLargeInteriorTurret)  
* [IMyLargeMissileTurret](SpaceEngineers.Game.ModAPI.IMyLargeMissileTurret)  
* [IMyLargeTurretBase](Sandbox.ModAPI.IMyLargeTurretBase)  
* [MyCameraBlock](Sandbox.Game.Entities.MyCameraBlock)  
* [MyCockpit](Sandbox.Game.Entities.MyCockpit)  
* [MyEntityRespawnComponentBase](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase)  
* [MySpectatorCameraController](Sandbox.Engine.Utils.MySpectatorCameraController)

