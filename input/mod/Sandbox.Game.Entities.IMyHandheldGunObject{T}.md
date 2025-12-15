**Assembly:** Sandbox.Game.dll

```csharp
public interface IMyHandheldGunObject<T>: IMyGunObject<T>
```

## Properties

|Member|Description|
|---|---|
|[CurrentAmmunition](Sandbox.Game.Entities.IMyHandheldGunObject{T}@CurrentAmmunition)||
|[CurrentMagazineAmmunition](Sandbox.Game.Entities.IMyHandheldGunObject{T}@CurrentMagazineAmmunition)||
|[CurrentMagazineAmount](Sandbox.Game.Entities.IMyHandheldGunObject{T}@CurrentMagazineAmount)||
|[ForceAnimationInsteadOfIK](Sandbox.Game.Entities.IMyHandheldGunObject{T}@ForceAnimationInsteadOfIK)||
|[IsBlocking](Sandbox.Game.Entities.IMyHandheldGunObject{T}@IsBlocking)||
|[IsRecoiling](Sandbox.Game.Entities.IMyHandheldGunObject{T}@IsRecoiling)||
|[IsReloading](Sandbox.Game.Entities.IMyHandheldGunObject{T}@IsReloading)||
|[NeedsReload](Sandbox.Game.Entities.IMyHandheldGunObject{T}@NeedsReload)||
|[OwnerId](Sandbox.Game.Entities.IMyHandheldGunObject{T}@OwnerId)||
|[OwnerIdentityId](Sandbox.Game.Entities.IMyHandheldGunObject{T}@OwnerIdentityId)||
|[PhysicalItemDefinition](Sandbox.Game.Entities.IMyHandheldGunObject{T}@PhysicalItemDefinition)||
|[PhysicalObject](Sandbox.Game.Entities.IMyHandheldGunObject{T}@PhysicalObject)||
|[Reloadable](Sandbox.Game.Entities.IMyHandheldGunObject{T}@Reloadable)||

## Methods

|Member|Description|
|---|---|
|[CanDoubleClickToStick(MyShootActionEnum)](Sandbox.Game.Entities.IMyHandheldGunObject{T}@CanDoubleClickToStick)||
|[CanReload()](Sandbox.Game.Entities.IMyHandheldGunObject{T}@CanReload)||
|[DoubleClicked(MyShootActionEnum)](Sandbox.Game.Entities.IMyHandheldGunObject{T}@DoubleClicked)||
|[GetReloadDuration()](Sandbox.Game.Entities.IMyHandheldGunObject{T}@GetReloadDuration)||
|[GetShakeOnAction(MyShootActionEnum)](Sandbox.Game.Entities.IMyHandheldGunObject{T}@GetShakeOnAction)||
|[PlayReloadSound()](Sandbox.Game.Entities.IMyHandheldGunObject{T}@PlayReloadSound)||
|[Reload()](Sandbox.Game.Entities.IMyHandheldGunObject{T}@Reload)||
|[ShouldEndShootOnPause(MyShootActionEnum)](Sandbox.Game.Entities.IMyHandheldGunObject{T}@ShouldEndShootOnPause)||

**Implements:**  
* [IMyGunObject<T>](VRage.Game.ModAPI.IMyGunObject{T})

