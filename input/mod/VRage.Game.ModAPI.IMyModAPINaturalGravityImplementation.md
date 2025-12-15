**Assembly:** VRage.Game.dll

```csharp
public interface IMyModAPINaturalGravityImplementation
```

Describes ModAPI implementation for natural gravity provider (any form, not only sphere)

## Methods

|Member|Description|
|---|---|
|[DoesTrajectoryIntersectNaturalGravity(RayD, double)](VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation@DoesTrajectoryIntersectNaturalGravity)|Checks if the specified trajectory intersects any natural gravity wells.|
|[GetGravityLimit()](VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation@GetGravityLimit)|Gets distance between Position of gravity provider, and it's most distant point|
|[GetGravityMultiplier(Vector3D)](VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation@GetGravityMultiplier)|Get gravity scalar|
|[GetProxyAABB(out BoundingBoxD)](VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation@GetProxyAABB)|Get bounding box around gravity provider|
|[GetWorldGravity(Vector3D)](VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation@GetWorldGravity)|Gets gravity vector|
|[GetWorldGravityNormalized(Vector3D)](VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation@GetWorldGravityNormalized)|Gets gravity vector (normalized)|
|[IsPositionInRange(Vector3D)](VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation@IsPositionInRange)|Tests if the specified point is within the gravity of this entity.|
|[OnPositionChanged(Vector3D)](VRage.Game.ModAPI.IMyModAPINaturalGravityImplementation@OnPositionChanged)|Called when position of gravity provider is changed|

