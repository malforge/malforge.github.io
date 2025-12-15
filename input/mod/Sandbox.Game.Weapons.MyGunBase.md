**Assembly:** Sandbox.Game.dll

```csharp
public class MyGunBase: MyDeviceBase
```

## Fields

|Member|Description|
|---|---|
|[static AMMO_PER_SHOOT](Sandbox.Game.Weapons.MyGunBase@AMMO_PER_SHOOT)||
|[static DUMMY_KEY_HOLDING](Sandbox.Game.Weapons.MyGunBase@DUMMY_KEY_HOLDING)||
|[static DUMMY_KEY_MISSILE](Sandbox.Game.Weapons.MyGunBase@DUMMY_KEY_MISSILE)||
|[static DUMMY_KEY_PROJECTILE](Sandbox.Game.Weapons.MyGunBase@DUMMY_KEY_PROJECTILE)||
|[ActiveLoopEffects](Sandbox.Game.Weapons.MyGunBase@ActiveLoopEffects)||
|[m_holdingDummyMatrix](Sandbox.Game.Weapons.MyGunBase@m_holdingDummyMatrix)||

## Events

|Member|Description|
|---|---|
|[OnAmmoAmountChanged](Sandbox.Game.Weapons.MyGunBase@OnAmmoAmountChanged)||

## Properties

|Member|Description|
|---|---|
|[BackkickForcePerSecond](Sandbox.Game.Weapons.MyGunBase@BackkickForcePerSecond)||
|[CurrentAmmo](Sandbox.Game.Weapons.MyGunBase@CurrentAmmo)||
|[CurrentAmmoDefinition](Sandbox.Game.Weapons.MyGunBase@CurrentAmmoDefinition)||
|[CurrentAmmoMagazineDefinition](Sandbox.Game.Weapons.MyGunBase@CurrentAmmoMagazineDefinition)||
|[CurrentAmmoMagazineId](Sandbox.Game.Weapons.MyGunBase@CurrentAmmoMagazineId)||
|[CurrentMagazines](Sandbox.Game.Weapons.MyGunBase@CurrentMagazines)||
|[DeviateAngle](Sandbox.Game.Weapons.MyGunBase@DeviateAngle)||
|[DeviateAngleWhileAiming](Sandbox.Game.Weapons.MyGunBase@DeviateAngleWhileAiming)||
|[HasAmmoMagazines](Sandbox.Game.Weapons.MyGunBase@HasAmmoMagazines)||
|[HasDummies](Sandbox.Game.Weapons.MyGunBase@HasDummies)||
|[HasIronSightsActive](Sandbox.Game.Weapons.MyGunBase@HasIronSightsActive)||
|[HasMissileAmmoDefined](Sandbox.Game.Weapons.MyGunBase@HasMissileAmmoDefined)||
|[HasProjectileAmmoDefined](Sandbox.Game.Weapons.MyGunBase@HasProjectileAmmoDefined)||
|[IsAmmoMissile](Sandbox.Game.Weapons.MyGunBase@IsAmmoMissile)||
|[IsAmmoProjectile](Sandbox.Game.Weapons.MyGunBase@IsAmmoProjectile)||
|[IsUserControllableGunBlock](Sandbox.Game.Weapons.MyGunBase@IsUserControllableGunBlock)||
|[LastShootTime](Sandbox.Game.Weapons.MyGunBase@LastShootTime)||
|[MechanicalDamage](Sandbox.Game.Weapons.MyGunBase@MechanicalDamage)||
|[MuzzleFlashLifeSpan](Sandbox.Game.Weapons.MyGunBase@MuzzleFlashLifeSpan)||
|[NoAmmoSound](Sandbox.Game.Weapons.MyGunBase@NoAmmoSound)||
|[PreShotSound](Sandbox.Game.Weapons.MyGunBase@PreShotSound)||
|[ReleaseTimeAfterFire](Sandbox.Game.Weapons.MyGunBase@ReleaseTimeAfterFire)||
|[ReloadSound](Sandbox.Game.Weapons.MyGunBase@ReloadSound)||
|[ReloadTime](Sandbox.Game.Weapons.MyGunBase@ReloadTime)||
|[SecondarySound](Sandbox.Game.Weapons.MyGunBase@SecondarySound)||
|[ShootIntervalInMiliseconds](Sandbox.Game.Weapons.MyGunBase@ShootIntervalInMiliseconds)||
|[ShootIntervalModifier](Sandbox.Game.Weapons.MyGunBase@ShootIntervalModifier)||
|[ShootSound](Sandbox.Game.Weapons.MyGunBase@ShootSound)||
|[ShotsInBurst](Sandbox.Game.Weapons.MyGunBase@ShotsInBurst)||
|[SupportReloading](Sandbox.Game.Weapons.MyGunBase@SupportReloading)||
|[UseDefaultMuzzleFlash](Sandbox.Game.Weapons.MyGunBase@UseDefaultMuzzleFlash)||
|[User](Sandbox.Game.Weapons.MyGunBase@User)||
|[WeaponDefinition](Sandbox.Game.Weapons.MyGunBase@WeaponDefinition)||
|[WeaponProperties](Sandbox.Game.Weapons.MyGunBase@WeaponProperties)||
|[WorldMatrix](Sandbox.Game.Weapons.MyGunBase@WorldMatrix)||
|[InventoryItemId](VRage.Game.ModAPI.MyDeviceBase@InventoryItemId)|Reference to the inventory item that this device originated from. Can be used to update the inventory item (when ammo changes etc...)<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyGunBase()](Sandbox.Game.Weapons.MyGunBase@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static GetMissileInitialSpeed(Vector3, Vector3, float, float)](Sandbox.Game.Weapons.MyGunBase@GetMissileInitialSpeed)||
|[AddMuzzleMatrix(MyAmmoType, Matrix, string)](Sandbox.Game.Weapons.MyGunBase@AddMuzzleMatrix)||
|[CanSwitchAmmoMagazine()](Sandbox.Game.Weapons.MyGunBase@CanSwitchAmmoMagazine)||
|[ConsumeAmmo()](Sandbox.Game.Weapons.MyGunBase@ConsumeAmmo)||
|[ConsumeMagazine()](Sandbox.Game.Weapons.MyGunBase@ConsumeMagazine)||
|[CreateAmmoInventoryConstraints(string)](Sandbox.Game.Weapons.MyGunBase@CreateAmmoInventoryConstraints)||
|[CreateEffects(WeaponEffectAction, uint?, bool)](Sandbox.Game.Weapons.MyGunBase@CreateEffects)||
|[DummiesPerType(MyAmmoType)](Sandbox.Game.Weapons.MyGunBase@DummiesPerType)||
|[EmptyMagazine()](Sandbox.Game.Weapons.MyGunBase@EmptyMagazine)||
|[GetAmmoMagazinesClient()](Sandbox.Game.Weapons.MyGunBase@GetAmmoMagazinesClient)||
|[GetAmmunitionAmount()](Sandbox.Game.Weapons.MyGunBase@GetAmmunitionAmount)||
|[GetCurrentDummyName()](Sandbox.Game.Weapons.MyGunBase@GetCurrentDummyName)||
|[GetDeviatedVector(float, Vector3)](Sandbox.Game.Weapons.MyGunBase@GetDeviatedVector)||
|[GetInventoryAmmoMagazinesCount()](Sandbox.Game.Weapons.MyGunBase@GetInventoryAmmoMagazinesCount)||
|[GetMagazineAmount()](Sandbox.Game.Weapons.MyGunBase@GetMagazineAmount)||
|[GetMuzzleLocalMatrix()](Sandbox.Game.Weapons.MyGunBase@GetMuzzleLocalMatrix)||
|[GetMuzzleLocalPosition()](Sandbox.Game.Weapons.MyGunBase@GetMuzzleLocalPosition)||
|[GetMuzzleWorldMatrix()](Sandbox.Game.Weapons.MyGunBase@GetMuzzleWorldMatrix)||
|[GetMuzzleWorldPosition()](Sandbox.Game.Weapons.MyGunBase@GetMuzzleWorldPosition)||
|[GetObjectBuilder()](Sandbox.Game.Weapons.MyGunBase@GetObjectBuilder)||
|[GetTotalAmmunitionAmount()](Sandbox.Game.Weapons.MyGunBase@GetTotalAmmunitionAmount)||
|[HasActiveEffects()](Sandbox.Game.Weapons.MyGunBase@HasActiveEffects)||
|[HasEnoughAmmunition()](Sandbox.Game.Weapons.MyGunBase@HasEnoughAmmunition)||
|[HasEnoughMagazines()](Sandbox.Game.Weapons.MyGunBase@HasEnoughMagazines)||
|[Init(MyObjectBuilder_GunBase, MyCubeBlockDefinition, IMyGunBaseUser)](Sandbox.Game.Weapons.MyGunBase@Init)||
|[Init(MyObjectBuilder_GunBase, MyDefinitionId, IMyGunBaseUser)](Sandbox.Game.Weapons.MyGunBase@Init)||
|[InitAmmoFromObjectBuilder(MyObjectBuilder_GunBase, bool)](Sandbox.Game.Weapons.MyGunBase@InitAmmoFromObjectBuilder)||
|[IsAmmoFull()](Sandbox.Game.Weapons.MyGunBase@IsAmmoFull)||
|[IsAmmoMagazineCompatible(MyDefinitionId)](Sandbox.Game.Weapons.MyGunBase@IsAmmoMagazineCompatible)||
|[LoadDummies(Dictionary<string, MyModelDummy>, Dictionary<int, string>)](Sandbox.Game.Weapons.MyGunBase@LoadDummies)||
|[MoveToNextMuzzle(MyAmmoType)](Sandbox.Game.Weapons.MyGunBase@MoveToNextMuzzle)||
|[RefreshAmmunitionAmount(bool)](Sandbox.Game.Weapons.MyGunBase@RefreshAmmunitionAmount)||
|[RemoveAllEffects()](Sandbox.Game.Weapons.MyGunBase@RemoveAllEffects)||
|[RemoveOldEffects(WeaponEffectAction)](Sandbox.Game.Weapons.MyGunBase@RemoveOldEffects)||
|[SetCurrentAmmo(int, bool)](Sandbox.Game.Weapons.MyGunBase@SetCurrentAmmo)||
|[Shoot(Vector3, MyEntity, MyLargeBarrelBase)](Sandbox.Game.Weapons.MyGunBase@Shoot)||
|[Shoot(Vector3, MyEntity, uint?)](Sandbox.Game.Weapons.MyGunBase@Shoot)||
|[Shoot(Vector3, Vector3D, MyEntity, uint?)](Sandbox.Game.Weapons.MyGunBase@Shoot)||
|[Shoot(Vector3D, Vector3, Vector3, MyEntity, uint?, bool)](Sandbox.Game.Weapons.MyGunBase@Shoot)||
|[ShootWithOffset(Vector3, Vector3, float, MyEntity, uint?, bool)](Sandbox.Game.Weapons.MyGunBase@ShootWithOffset)|This function changes default shooting position (muzzle flash) with an offset. (allow us to shoot at close objects)|
|[StartPreShotSound(MyEntity3DSoundEmitter, bool)](Sandbox.Game.Weapons.MyGunBase@StartPreShotSound)||
|[StartShootSound(MyEntity3DSoundEmitter, bool)](Sandbox.Game.Weapons.MyGunBase@StartShootSound)||
|[StopShoot()](Sandbox.Game.Weapons.MyGunBase@StopShoot)||
|[SwitchAmmoMagazine(MyDefinitionId)](Sandbox.Game.Weapons.MyGunBase@SwitchAmmoMagazine)||
|[SwitchAmmoMagazineToFirstAvailable()](Sandbox.Game.Weapons.MyGunBase@SwitchAmmoMagazineToFirstAvailable)||
|[SwitchAmmoMagazineToNextAvailable()](Sandbox.Game.Weapons.MyGunBase@SwitchAmmoMagazineToNextAvailable)||
|[SwitchToNextAmmoMagazine()](Sandbox.Game.Weapons.MyGunBase@SwitchToNextAmmoMagazine)||
|[TrySubscribeToEntityEvents(MyEntity)](Sandbox.Game.Weapons.MyGunBase@TrySubscribeToEntityEvents)||
|[UpdateEffectPositions()](Sandbox.Game.Weapons.MyGunBase@UpdateEffectPositions)||
|[UpdateEffects()](Sandbox.Game.Weapons.MyGunBase@UpdateEffects)||
|[CanSwitchAmmoMagazine()](VRage.Game.ModAPI.MyDeviceBase@CanSwitchAmmoMagazine)|Determines whether this device can switch ammo<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|
|[GetMuzzleLocalPosition()](VRage.Game.ModAPI.MyDeviceBase@GetMuzzleLocalPosition)|Gets the muzzle local position<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|
|[GetMuzzleWorldPosition()](VRage.Game.ModAPI.MyDeviceBase@GetMuzzleWorldPosition)|Gets the muzzle world position<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|
|[Init(MyObjectBuilder_DeviceBase)](VRage.Game.ModAPI.MyDeviceBase@Init)|Initialization of the device<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|
|[SwitchAmmoMagazineToNextAvailable()](VRage.Game.ModAPI.MyDeviceBase@SwitchAmmoMagazineToNextAvailable)|Switches to the next available ammo magazine<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|
|[SwitchToNextAmmoMagazine()](VRage.Game.ModAPI.MyDeviceBase@SwitchToNextAmmoMagazine)|Switches to the next ammo magazine<br /><br />_Inherited from [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)_|

**Inheritance:**   [MyDeviceBase](VRage.Game.ModAPI.MyDeviceBase)

