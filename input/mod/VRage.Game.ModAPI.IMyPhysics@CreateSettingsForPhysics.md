## Summary

```csharp
public PhysicsSettings CreateSettingsForPhysics(IMyEntity entity, MatrixD worldMatrix, Vector3 localCenter, float linearDamping, float angularDamping, ushort collisionLayer, RigidBodyFlag rigidBodyFlags, bool isPhantom, ModAPIMass? mass)
```

Used for create physics with collisions

## Returns

[PhysicsSettings](VRage.ModAPI.PhysicsSettings)

## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) entity
* [MatrixD](VRageMath.MatrixD) worldMatrix
* [Vector3](VRageMath.Vector3) localCenter
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) linearDamping
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) angularDamping
* [ushort](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16?view=netframework-4.6) collisionLayer
* [RigidBodyFlag](VRage.Game.Components.RigidBodyFlag) rigidBodyFlags
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) isPhantom
* [ModAPIMass?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) mass
