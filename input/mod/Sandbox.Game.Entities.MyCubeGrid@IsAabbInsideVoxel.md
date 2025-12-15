## Summary

```csharp
public static bool IsAabbInsideVoxel(MatrixD worldMatrix, BoundingBoxD localAabb, MyGridPlacementSettings settings)
```

Checks if aabb is in voxel. If settings provided it will return false if penetration settings allow for it.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



## Parameters

* [MatrixD](VRageMath.MatrixD) worldMatrix
* [BoundingBoxD](VRageMath.BoundingBoxD) localAabb
* [MyGridPlacementSettings](VRage.Game.ObjectBuilders.Definitions.SessionComponents.MyGridPlacementSettings) settings
