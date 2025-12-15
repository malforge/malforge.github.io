**Assembly:** Sandbox.Common.dll

```csharp
public class MyProjectileHitInfo
```

Describes information projectile about projectile hit. (mods interface) You can change values

## Fields

|Member|Description|
|---|---|
|[AddDecals](Sandbox.ModAPI.MyProjectileHitInfo@AddDecals)|When it is false, decals wont be added (default = true)|
|[AddHitIndicator](Sandbox.ModAPI.MyProjectileHitInfo@AddHitIndicator)|When it is false, player wont see hit indicator|
|[AddHitParticles](Sandbox.ModAPI.MyProjectileHitInfo@AddHitParticles)|When it is false, player wont see hit particles (default = true)|
|[AddSZNotification](Sandbox.ModAPI.MyProjectileHitInfo@AddSZNotification)|When it is false, player wont see safe zone notification (default = true)|
|[Damage](Sandbox.ModAPI.MyProjectileHitInfo@Damage)|Damage that would|
|[HitEntity](Sandbox.ModAPI.MyProjectileHitInfo@HitEntity)|Entity that was hitted by projectile|
|[HitMaterial](Sandbox.ModAPI.MyProjectileHitInfo@HitMaterial)|Material that hitted by projectile|
|[HitNormal](Sandbox.ModAPI.MyProjectileHitInfo@HitNormal)|Hit normal|
|[HitPosition](Sandbox.ModAPI.MyProjectileHitInfo@HitPosition)|World coordinates of projectile hit|
|[HitShapeKey](Sandbox.ModAPI.MyProjectileHitInfo@HitShapeKey)|Used in [GetSurfaceAndMaterial(IMyEntity, ref LineD, ref Vector3D, uint, out MySurfaceImpactEnum, out MyStringHash)](Sandbox.ModAPI.IMyProjectiles@GetSurfaceAndMaterial) |
|[HitVoxelMaterial](Sandbox.ModAPI.MyProjectileHitInfo@HitVoxelMaterial)|Voxel Material that hit by projectile|
|[Impulse](Sandbox.ModAPI.MyProjectileHitInfo@Impulse)|Impulse, that would be applied to [HitEntity](Sandbox.ModAPI.MyProjectileHitInfo@HitEntity) |
|[PlayHitSound](Sandbox.ModAPI.MyProjectileHitInfo@PlayHitSound)|When it is false, player wont hear hit sound (default = true)|
|[Velocity](Sandbox.ModAPI.MyProjectileHitInfo@Velocity)|Velocity of projectile before hit|

## Constructors

|Member|Description|
|---|---|
|[MyProjectileHitInfo()](Sandbox.ModAPI.MyProjectileHitInfo@.ctor)||

## Methods

|Member|Description|
|---|---|
|[ToString()](Sandbox.ModAPI.MyProjectileHitInfo@ToString)||

