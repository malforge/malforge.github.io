## Summary

```csharp
public MyTuple<float, float> GetVoxelContentInBoundingBox_Fast(BoundingBoxD localAabb, MatrixD worldMatrix, bool stopIfFindAtLeastOneContent, float threshold)
```

Calculates amount of volume of a bounding box in voxels.

## Returns

[MyTuple<float, float>](VRage.MyTuple{Single,Single})

Pair of floats where 1st value is Volume amount and 2nd value is ratio of Volume amount to Whole volume.

## Parameters

* [BoundingBoxD](VRageMath.BoundingBoxD) localAabb
* [MatrixD](VRageMath.MatrixD) worldMatrix
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) stopIfFindAtLeastOneContent
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) threshold
