## Summary

```csharp
public static bool TestPlacementAreaCube(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, Vector3I min, Vector3I max, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, ulong placingPlayer, MyEntity ignoredEntity, bool ignoreFracturedPieces, bool isProjected, bool forceCheck)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) targetGrid
* [MyGridPlacementSettings](VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings) settings
* [Vector3I](VRageMath.Vector3I) min
* [Vector3I](VRageMath.Vector3I) max
* [MyBlockOrientation](VRageMath.MyBlockOrientation) blockOrientation
* [MyCubeBlockDefinition](Sandbox.Definitions.MyCubeBlockDefinition) blockDefinition
* [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6) placingPlayer
* [MyEntity](VRage.Game.Entity.MyEntity) ignoredEntity
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) ignoreFracturedPieces
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) isProjected
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) forceCheck
## Summary

```csharp
public static bool TestPlacementAreaCube(MyCubeGrid targetGrid, ref MyGridPlacementSettings settings, Vector3I min, Vector3I max, MyBlockOrientation blockOrientation, MyCubeBlockDefinition blockDefinition, out MyCubeGrid touchingGrid, ulong placingPlayer, MyEntity ignoredEntity, bool ignoreFracturedPieces, bool isProjected, bool forceCheck, bool wheelsAsCylinders)
```

Test cube block placement area in grid.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) targetGrid
* [MyGridPlacementSettings](VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings) settings
* [Vector3I](VRageMath.Vector3I) min
* [Vector3I](VRageMath.Vector3I) max
* [MyBlockOrientation](VRageMath.MyBlockOrientation) blockOrientation
* [MyCubeBlockDefinition](Sandbox.Definitions.MyCubeBlockDefinition) blockDefinition
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) touchingGrid
* [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6) placingPlayer
* [MyEntity](VRage.Game.Entity.MyEntity) ignoredEntity
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) ignoreFracturedPieces
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) isProjected
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) forceCheck
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) wheelsAsCylinders
