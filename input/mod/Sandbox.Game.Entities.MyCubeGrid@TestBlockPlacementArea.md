## Summary

```csharp
public static bool TestBlockPlacementArea(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, ref Vector3D translation, ref Quaternion rotation, ref Vector3 halfExtents, ref BoundingBoxD localAabb, ulong placingPlayer, MyEntity ignoredEntity, bool isProjected, bool wheelsAsCylinders)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) targetGrid
* [MyGridPlacementSettings](VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings) settings
* [MyBlockOrientation](VRageMath.MyBlockOrientation) blockOrientation
* [MyCubeBlockDefinition](Sandbox.Definitions.MyCubeBlockDefinition) blockDefinition
* [Vector3D](VRageMath.Vector3D) translation
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector3](VRageMath.Vector3) halfExtents
* [BoundingBoxD](VRageMath.BoundingBoxD) localAabb
* [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6) placingPlayer
* [MyEntity](VRage.Game.Entity.MyEntity) ignoredEntity
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) isProjected
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) wheelsAsCylinders
## Summary

```csharp
public static bool TestBlockPlacementArea(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, ref Vector3D translationObsolete, ref Quaternion rotation, ref Vector3 halfExtentsObsolete, ref BoundingBoxD localAabb, out MyCubeGrid touchingGrid, ulong placingPlayer, MyEntity ignoredEntity, bool ignoreFracturedPieces, bool testVoxel, bool isProjected, bool forceCheck, bool wheelsAsCylinders)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) targetGrid
* [MyGridPlacementSettings](VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings) settings
* [MyBlockOrientation](VRageMath.MyBlockOrientation) blockOrientation
* [MyCubeBlockDefinition](Sandbox.Definitions.MyCubeBlockDefinition) blockDefinition
* [Vector3D](VRageMath.Vector3D) translationObsolete
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector3](VRageMath.Vector3) halfExtentsObsolete
* [BoundingBoxD](VRageMath.BoundingBoxD) localAabb
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) touchingGrid
* [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6) placingPlayer
* [MyEntity](VRage.Game.Entity.MyEntity) ignoredEntity
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) ignoreFracturedPieces
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) testVoxel
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) isProjected
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) forceCheck
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) wheelsAsCylinders
## Summary

```csharp
public static bool TestBlockPlacementArea(MyCubeBlockDefinition blockDefinition, MyBlockOrientation? blockOrientation, MatrixD worldMatrix, ref MyGridPlacementSettings settings, BoundingBoxD localAabb, bool dynamicBuildMode, MyEntity ignoredEntity, bool testVoxel)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [MyCubeBlockDefinition](Sandbox.Definitions.MyCubeBlockDefinition) blockDefinition
* [MyBlockOrientation?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) blockOrientation
* [MatrixD](VRageMath.MatrixD) worldMatrix
* [MyGridPlacementSettings](VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings) settings
* [BoundingBoxD](VRageMath.BoundingBoxD) localAabb
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) dynamicBuildMode
* [MyEntity](VRage.Game.Entity.MyEntity) ignoredEntity
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) testVoxel
