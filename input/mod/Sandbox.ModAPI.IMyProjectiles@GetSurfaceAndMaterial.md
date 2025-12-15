## Summary

```csharp
public void GetSurfaceAndMaterial(IMyEntity entity, ref LineD line, ref Vector3D hitPosition, uint shapeKey, out MySurfaceImpactEnum surfaceImpact, out MyStringHash materialType)
```

Gets information about material and surface, that bullet hitted Arguments should be taken from [MyProjectileHitInfo](Sandbox.ModAPI.MyProjectileHitInfo) on projectile hit (subscribe on event with [AddOnHitInterceptor(int, HitInterceptor)](Sandbox.ModAPI.IMyProjectiles@AddOnHitInterceptor) ).

## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) entity
* [LineD](VRageMath.LineD) line
* [Vector3D](VRageMath.Vector3D) hitPosition
* [uint](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32?view=netframework-4.6) shapeKey
* [MySurfaceImpactEnum](Sandbox.ModAPI.MySurfaceImpactEnum) surfaceImpact
* [MyStringHash](VRage.Utils.MyStringHash) materialType
