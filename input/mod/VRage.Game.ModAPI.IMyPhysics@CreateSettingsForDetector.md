## Summary

```csharp
public PhysicsSettings CreateSettingsForDetector(IMyEntity entity, Action<IMyEntity, bool> detectorColliderCallback, MatrixD worldMatrix, Vector3 localCenter, RigidBodyFlag rigidBodyFlags, ushort collisionLayer, bool isPhantom)
```

Used to create physical detectors. They don't have physical collisions, instead they provide trigger callbacks when Entities collide with their shape

## Returns

[PhysicsSettings](VRage.ModAPI.PhysicsSettings)

## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) entity
* [Action<IMyEntity, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6) detectorColliderCallback
* [MatrixD](VRageMath.MatrixD) worldMatrix
* [Vector3](VRageMath.Vector3) localCenter
* [RigidBodyFlag](VRage.Game.Components.RigidBodyFlag) rigidBodyFlags
* [ushort](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16?view=netframework-4.6) collisionLayer
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) isPhantom
