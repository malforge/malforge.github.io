**Assembly:** VRage.Game.dll

```csharp
public interface IMyGunObject<T>
```

## Properties

|Member|Description|
|---|---|
|[BackkickForcePerSecond](VRage.Game.ModAPI.IMyGunObject{T}@BackkickForcePerSecond)||
|[DefinitionId](VRage.Game.ModAPI.IMyGunObject{T}@DefinitionId)||
|[EnabledInWorldRules](VRage.Game.ModAPI.IMyGunObject{T}@EnabledInWorldRules)||
|[GunBase](VRage.Game.ModAPI.IMyGunObject{T}@GunBase)||
|[IsShooting](VRage.Game.ModAPI.IMyGunObject{T}@IsShooting)||
|[IsSkinnable](VRage.Game.ModAPI.IMyGunObject{T}@IsSkinnable)||
|[IsTargetLockingCapable](VRage.Game.ModAPI.IMyGunObject{T}@IsTargetLockingCapable)||
|[MaximumShotLength](VRage.Game.ModAPI.IMyGunObject{T}@MaximumShotLength)||
|[NeedsShootDirectionWhileAiming](VRage.Game.ModAPI.IMyGunObject{T}@NeedsShootDirectionWhileAiming)||
|[ShakeAmount](VRage.Game.ModAPI.IMyGunObject{T}@ShakeAmount)||
|[ShootDirectionUpdateTime](VRage.Game.ModAPI.IMyGunObject{T}@ShootDirectionUpdateTime)||

## Methods

|Member|Description|
|---|---|
|[BeginFailReaction(MyShootActionEnum, MyGunStatusEnum)](VRage.Game.ModAPI.IMyGunObject{T}@BeginFailReaction)||
|[BeginFailReactionLocal(MyShootActionEnum, MyGunStatusEnum)](VRage.Game.ModAPI.IMyGunObject{T}@BeginFailReactionLocal)||
|[BeginShoot(MyShootActionEnum)](VRage.Game.ModAPI.IMyGunObject{T}@BeginShoot)||
|[CanShoot(MyShootActionEnum, long, out MyGunStatusEnum)](VRage.Game.ModAPI.IMyGunObject{T}@CanShoot)||
|[DirectionToTarget(Vector3D)](VRage.Game.ModAPI.IMyGunObject{T}@DirectionToTarget)||
|[DrawHud(IMyCameraController, long)](VRage.Game.ModAPI.IMyGunObject{T}@DrawHud)||
|[DrawHud(IMyCameraController, long, bool)](VRage.Game.ModAPI.IMyGunObject{T}@DrawHud)||
|[EndShoot(MyShootActionEnum)](VRage.Game.ModAPI.IMyGunObject{T}@EndShoot)||
|[GetAmmunitionAmount()](VRage.Game.ModAPI.IMyGunObject{T}@GetAmmunitionAmount)||
|[GetMagazineAmount()](VRage.Game.ModAPI.IMyGunObject{T}@GetMagazineAmount)||
|[GetMuzzlePosition()](VRage.Game.ModAPI.IMyGunObject{T}@GetMuzzlePosition)||
|[GetShootDirection()](VRage.Game.ModAPI.IMyGunObject{T}@GetShootDirection)||
|[GetTotalAmmunitionAmount()](VRage.Game.ModAPI.IMyGunObject{T}@GetTotalAmmunitionAmount)||
|[IsToolbarUsable()](VRage.Game.ModAPI.IMyGunObject{T}@IsToolbarUsable)||
|[OnControlAcquired(IMyCharacter)](VRage.Game.ModAPI.IMyGunObject{T}@OnControlAcquired)||
|[OnControlReleased()](VRage.Game.ModAPI.IMyGunObject{T}@OnControlReleased)||
|[Shoot(MyShootActionEnum, Vector3, Vector3D?, string)](VRage.Game.ModAPI.IMyGunObject{T}@Shoot)||
|[ShootFailReactionLocal(MyShootActionEnum, MyGunStatusEnum)](VRage.Game.ModAPI.IMyGunObject{T}@ShootFailReactionLocal)||
|[SupressShootAnimation()](VRage.Game.ModAPI.IMyGunObject{T}@SupressShootAnimation)||
|[UpdateSoundEmitter()](VRage.Game.ModAPI.IMyGunObject{T}@UpdateSoundEmitter)||

