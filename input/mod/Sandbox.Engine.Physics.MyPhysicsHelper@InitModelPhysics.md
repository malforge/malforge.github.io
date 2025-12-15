## Summary

```csharp
public static bool InitModelPhysics(this IMyEntity entity, RigidBodyFlag rbFlags, int collisionLayers)
```

Initialize entity physics using the model's collision shapes.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

if new physics was initialized.otherwise.

## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) entity
* [RigidBodyFlag](VRage.Game.Components.RigidBodyFlag) rbFlags
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) collisionLayers
