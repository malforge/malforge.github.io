**Assembly:** Sandbox.Common.dll

```csharp
public struct MyProjectileInfo
```

Implements read-only info about existing projectile

## Properties

|Member|Description|
|---|---|
|[CachedGravity](Sandbox.ModAPI.MyProjectileInfo@CachedGravity)|Cached gravity, in position of bullet. (May be inaccurate)|
|[Index](Sandbox.ModAPI.MyProjectileInfo@Index)|Index of position in array. May be changed|
|[MaxTrajectory](Sandbox.ModAPI.MyProjectileInfo@MaxTrajectory)|Max travel distance|
|[Origin](Sandbox.ModAPI.MyProjectileInfo@Origin)|Shoot position (World coordinates)|
|[OwnerEntity](Sandbox.ModAPI.MyProjectileInfo@OwnerEntity)|Rifle, block ...|
|[OwnerEntityAbsolute](Sandbox.ModAPI.MyProjectileInfo@OwnerEntityAbsolute)|character, main ship cockpit,|
|[OwningPlayer](Sandbox.ModAPI.MyProjectileInfo@OwningPlayer)|Player SteamId or zero|
|[Position](Sandbox.ModAPI.MyProjectileInfo@Position)|World position|
|[ProjectileAmmoDefinition](Sandbox.ModAPI.MyProjectileInfo@ProjectileAmmoDefinition)|Gets Projectile Ammo Definition of type MyProjectileAmmoDefinition|
|[Velocity](Sandbox.ModAPI.MyProjectileInfo@Velocity)|Current velocity|
|[WeaponDefinition](Sandbox.ModAPI.MyProjectileInfo@WeaponDefinition)|Gets Weapon Definition of type MyWeaponDefinition|

## Constructors

|Member|Description|
|---|---|
|[MyProjectileInfo(int, Vector3D, Vector3D, Vector3D, Vector3D, float, MyDefinitionBase, MyDefinitionBase, IMyEntity, IMyEntity, ulong)](Sandbox.ModAPI.MyProjectileInfo@.ctor)||

