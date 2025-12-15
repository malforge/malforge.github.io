**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyProjectiles
```

Interface for controlling projectile behavior (mods interface)

## Events

|Member|Description|
|---|---|
|[OnProjectileAdded](Sandbox.ModAPI.IMyProjectiles@OnProjectileAdded)|Called when new projectile was added|
|[OnProjectileRemoving](Sandbox.ModAPI.IMyProjectiles@OnProjectileRemoving)|Called when projectile was removed|

## Methods

|Member|Description|
|---|---|
|[Add(MyDefinitionBase, MyDefinitionBase, Vector3D, Vector3, Vector3, MyEntity, MyEntity, MyEntity, MyEntity[], bool, ulong)](Sandbox.ModAPI.IMyProjectiles@Add)|Adds new projectile|
|[AddHitDetector(IMyProjectileDetector)](Sandbox.ModAPI.IMyProjectiles@AddHitDetector)|Adds projectile detector. It allows to detect projectiles flying though it, and can cause them hit it Example: Safezone, ship shields|
|[AddOnHitInterceptor(int, HitInterceptor)](Sandbox.ModAPI.IMyProjectiles@AddOnHitInterceptor)|Call function when projectile hits something|
|[GetAllProjectileCount()](Sandbox.ModAPI.IMyProjectiles@GetAllProjectileCount)|Gets amount of projectiles currently existing|
|[GetProjectile(int)](Sandbox.ModAPI.IMyProjectiles@GetProjectile)|Gets projectile info|
|[GetSurfaceAndMaterial(IMyEntity, ref LineD, ref Vector3D, uint, out MySurfaceImpactEnum, out MyStringHash)](Sandbox.ModAPI.IMyProjectiles@GetSurfaceAndMaterial)|Gets information about material and surface, that bullet hitted Arguments should be taken from [MyProjectileHitInfo](Sandbox.ModAPI.MyProjectileHitInfo) on projectile hit (subscribe on event with [AddOnHitInterceptor(int, HitInterceptor)](Sandbox.ModAPI.IMyProjectiles@AddOnHitInterceptor) ).|
|[MarkProjectileForDestroy(int)](Sandbox.ModAPI.IMyProjectiles@MarkProjectileForDestroy)|Marks projectiles for destroy, doesn't decrease projectiles count. Shifting projectiles id, on next frame|
|[RemoveHitDetector(IMyProjectileDetector)](Sandbox.ModAPI.IMyProjectiles@RemoveHitDetector)|Removes projectile detector|
|[RemoveOnHitInterceptor(HitInterceptor)](Sandbox.ModAPI.IMyProjectiles@RemoveOnHitInterceptor)|Removed function from call when projectile hits something|

