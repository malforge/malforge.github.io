**Assembly:** VRage.Game.dll

```csharp
public interface IMySpectatorTools
```

ModAPI interface giving access to spector control

## Properties

|Member|Description|
|---|---|
|[TrackedSlots](VRage.Game.ModAPI.IMySpectatorTools@TrackedSlots)|Get tracked entities|

## Methods

|Member|Description|
|---|---|
|[ClearTrackedSlot(int)](VRage.Game.ModAPI.IMySpectatorTools@ClearTrackedSlot)|Removes tracking entity at slot|
|[GetMode()](VRage.Game.ModAPI.IMySpectatorTools@GetMode)|Gets current camera work|
|[GetTarget()](VRage.Game.ModAPI.IMySpectatorTools@GetTarget)|Gets current tracked entity|
|[LockHitEntity()](VRage.Game.ModAPI.IMySpectatorTools@LockHitEntity)|Lock entity that you look at|
|[NextPlayer()](VRage.Game.ModAPI.IMySpectatorTools@NextPlayer)|Switching camera to next player|
|[PreviousPlayer()](VRage.Game.ModAPI.IMySpectatorTools@PreviousPlayer)|Switching camera to previous player|
|[SaveTrackedSlot(int)](VRage.Game.ModAPI.IMySpectatorTools@SaveTrackedSlot)|Save current camera and track settings at slot|
|[SelectTrackedSlot(int)](VRage.Game.ModAPI.IMySpectatorTools@SelectTrackedSlot)|Switch to selected|
|[SetMode(MyCameraMode)](VRage.Game.ModAPI.IMySpectatorTools@SetMode)|Set camera work mode|
|[SetTarget(IMyEntity)](VRage.Game.ModAPI.IMySpectatorTools@SetTarget)|Set tracked target|

