## Summary

```csharp
public static void InitBoxPhysics(this IMyEntity entity, MyStringHash materialType, Vector3 center, Vector3 size, float mass, float linearDamping, float angularDamping, ushort collisionLayer, RigidBodyFlag rbFlag)
```

## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) entity
* [MyStringHash](VRage.Utils.MyStringHash) materialType
* [Vector3](VRageMath.Vector3) center
* [Vector3](VRageMath.Vector3) size
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) mass
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) linearDamping
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) angularDamping
* [ushort](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16?view=netframework-4.6) collisionLayer
* [RigidBodyFlag](VRage.Game.Components.RigidBodyFlag) rbFlag
## Summary

```csharp
public static void InitBoxPhysics(this IMyEntity entity, MyStringHash materialType, MyModel model, float mass, float angularDamping, ushort collisionLayer, RigidBodyFlag rbFlag)
```

## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) entity
* [MyStringHash](VRage.Utils.MyStringHash) materialType
* MyModel <sub>prohibited</sub> model
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) mass
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) angularDamping
* [ushort](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16?view=netframework-4.6) collisionLayer
* [RigidBodyFlag](VRage.Game.Components.RigidBodyFlag) rbFlag
