## Summary

```csharp
public static Vector3 TransformLargeGridHitCoordToSmallGrid(Vector3D coords, MatrixD worldMatrixNormalizedInv, float gridSize)
```

Converts large grid hit coordinates for small cubes. Allows placement of small grids to large grids. Returns coordinates of small grid (in large grid coordinates) which touches large grid in the hit position.

## Returns

[Vector3](VRageMath.Vector3)

## Parameters

* [Vector3D](VRageMath.Vector3D) coords
* [MatrixD](VRageMath.MatrixD) worldMatrixNormalizedInv
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) gridSize
