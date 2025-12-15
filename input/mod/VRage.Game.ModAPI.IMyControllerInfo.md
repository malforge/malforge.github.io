**Assembly:** VRage.Game.dll

```csharp
public interface IMyControllerInfo
```

Describes interface that provides information about current control state for controllable entities such as turret, cockpit, character ...

## Events

|Member|Description|
|---|---|
|[ControlAcquired](VRage.Game.ModAPI.IMyControllerInfo@ControlAcquired)|Called when the entity gains a controller|
|[ControlReleased](VRage.Game.ModAPI.IMyControllerInfo@ControlReleased)|Called when the entity loses a controller|

## Properties

|Member|Description|
|---|---|
|[Controller](VRage.Game.ModAPI.IMyControllerInfo@Controller)|Gets the controller for the entity|
|[ControllingIdentityId](VRage.Game.ModAPI.IMyControllerInfo@ControllingIdentityId)|Gets the controlling entity id (eg. IMyPlayer.IdentityId)|

## Methods

|Member|Description|
|---|---|
|[IsLocallyControlled()](VRage.Game.ModAPI.IMyControllerInfo@IsLocallyControlled)|Returns true if the local player is controlling the entity|
|[IsLocallyHumanControlled()](VRage.Game.ModAPI.IMyControllerInfo@IsLocallyHumanControlled)|Returns true if the local human player is controlling the entity|
|[IsRemotelyControlled()](VRage.Game.ModAPI.IMyControllerInfo@IsRemotelyControlled)|Returns true if the entity is remotely controlled|

