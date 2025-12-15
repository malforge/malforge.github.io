## Summary

```csharp
public static bool TestBlockPlacementAreaVanilla(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, ref Vector3D translationObsolete, ref Quaternion rotation, ref Vector3 halfExtentsObsolete, ref BoundingBoxD localAabb, out MyCubeGrid touchingGrid, ulong placingPlayer, MyEntity ignoredEntity, bool ignoreFracturedPieces, bool testVoxel, bool isProjected, bool forceCheck)
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
