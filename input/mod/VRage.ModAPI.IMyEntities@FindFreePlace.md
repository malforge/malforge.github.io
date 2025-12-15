## Summary

```csharp
public Vector3D? FindFreePlace(Vector3D basePos, float radius, int maxTestCount, int testsPerDistance, float stepSize)
```

Use to find place that doesn't have any voxels, grids, or physical bodies. If original position can't fill check sphere, new position in some distance is picked. Distance grows each testsPerDistance attempts. Maximum distance from BasePos that can be used is calculated by formula: maxTestCount / testsPerDistance * radius * stepSize

## Returns

[Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

Position that can doesn't have voxels, grids and other HkBodies in provided radius

## Parameters

* [Vector3D](VRageMath.Vector3D) basePos
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) radius
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) maxTestCount
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) testsPerDistance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) stepSize
