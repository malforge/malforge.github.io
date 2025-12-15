## Summary

```csharp
public static void Spawn(MyPhysicalInventoryItem item, Vector3D position, Vector3D forward, Vector3D up, MyPhysicsComponentBase motionInheritedFrom, Action<MyEntity> completionCallback)
```

## Parameters

* [MyPhysicalInventoryItem](VRage.Game.Entity.MyPhysicalInventoryItem) item
* [Vector3D](VRageMath.Vector3D) position
* [Vector3D](VRageMath.Vector3D) forward
* [Vector3D](VRageMath.Vector3D) up
* [MyPhysicsComponentBase](VRage.Game.Components.MyPhysicsComponentBase) motionInheritedFrom
* [Action<MyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) completionCallback
## Summary

```csharp
public static void Spawn(MyPhysicalInventoryItem item, MatrixD worldMatrix, MyPhysicsComponentBase motionInheritedFrom, Action<MyEntity> completionCallback)
```

## Parameters

* [MyPhysicalInventoryItem](VRage.Game.Entity.MyPhysicalInventoryItem) item
* [MatrixD](VRageMath.MatrixD) worldMatrix
* [MyPhysicsComponentBase](VRage.Game.Components.MyPhysicsComponentBase) motionInheritedFrom
* [Action<MyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) completionCallback
## Summary

```csharp
public static void Spawn(MyPhysicalInventoryItem item, BoundingSphereD sphere, MyPhysicsComponentBase motionInheritedFrom, MyVoxelMaterialDefinition voxelMaterial, Action<MyEntity> OnDone)
```

## Parameters

* [MyPhysicalInventoryItem](VRage.Game.Entity.MyPhysicalInventoryItem) item
* [BoundingSphereD](VRageMath.BoundingSphereD) sphere
* [MyPhysicsComponentBase](VRage.Game.Components.MyPhysicsComponentBase) motionInheritedFrom
* [MyVoxelMaterialDefinition](VRage.Game.MyVoxelMaterialDefinition) voxelMaterial
* [Action<MyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) OnDone
## Summary

```csharp
public static void Spawn(MyPhysicalItemDefinition itemDefinition, Vector3D translation, Vector3D forward, Vector3D up, int amount, float scale)
```

## Parameters

* [MyPhysicalItemDefinition](Sandbox.Definitions.MyPhysicalItemDefinition) itemDefinition
* [Vector3D](VRageMath.Vector3D) translation
* [Vector3D](VRageMath.Vector3D) forward
* [Vector3D](VRageMath.Vector3D) up
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) amount
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) scale
