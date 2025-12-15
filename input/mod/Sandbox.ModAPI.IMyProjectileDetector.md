**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyProjectileDetector
```

Describes projectile that have custom logic on handling bullets (mods interface)

## Properties

|Member|Description|
|---|---|
|[DetectorAABB](Sandbox.ModAPI.IMyProjectileDetector@DetectorAABB)|Gets AABB of the detector|
|[HitEntity](Sandbox.ModAPI.IMyProjectileDetector@HitEntity)|Gets entity which was hit for this detector. It's not used for any logic with data, just for reporting to projectile system, which entity was hit by the projectile.|
|[IsDetectorEnabled](Sandbox.ModAPI.IMyProjectileDetector@IsDetectorEnabled)|Gets if detector is enabled|

## Methods

|Member|Description|
|---|---|
|[GetDetectorIntersectionWithLine(ref LineD, out Vector3D?)](Sandbox.ModAPI.IMyProjectileDetector@GetDetectorIntersectionWithLine)|Gets intersection between line and detector|

**Inheritors:**  
* [MySafeZone](Sandbox.Game.Entities.MySafeZone)

