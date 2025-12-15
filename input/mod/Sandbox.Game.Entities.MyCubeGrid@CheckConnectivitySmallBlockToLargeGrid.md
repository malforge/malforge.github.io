## Summary

```csharp
public static bool CheckConnectivitySmallBlockToLargeGrid(MyCubeGrid grid, MyCubeBlockDefinition def, ref Quaternion rotation, ref Vector3I addNormal)
```

Performs check whether small cube block given by its definition, rotation can be connected to large grid. Function checks whether a mount point on placed block exists in opposite direction than addNomal.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True when small block can be connected, otherwise false.

## Parameters

* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) grid
* [MyCubeBlockDefinition](Sandbox.Definitions.MyCubeBlockDefinition) def
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector3I](VRageMath.Vector3I) addNormal
