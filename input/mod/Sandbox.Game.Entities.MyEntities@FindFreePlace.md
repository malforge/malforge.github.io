## Summary

```csharp
public static Vector3D? FindFreePlace(ref MatrixD matrix, Vector3 axis, float radius, int maxTestCount, int testsPerDistance, float stepSize, bool allowSafezones)
```

Finds free place for objects defined by position and radius. StepSize is how fast to increase radius, 0.5f means by half radius.

## Returns

[Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)



## Parameters

* [MatrixD](VRageMath.MatrixD) matrix
* [Vector3](VRageMath.Vector3) axis
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) radius
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) maxTestCount
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) testsPerDistance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) stepSize
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) allowSafezones
## Summary

```csharp
public static Vector3D? FindFreePlace(Vector3D basePos, float radius, int maxTestCount, int testsPerDistance, float stepSize, MyEntity ignoreEnt, bool allowSafezones)
```

Finds free place for objects defined by position and radius. StepSize is how fast to increase radius, 0.5f means by half radius. NOTE: Following method may have the following problems: 1) CorrectSpawnLocation() should be always followed by a second test for IsShapePenetrating() 2) First overlapping test may result in returning a colliding test sphere with a physics voxel map (case overlappedVoxelmap != null and not a planet) 3) In second overlapping test, CorrectSpawnLocation() is testing from basePos. It should probably test from currentPos cause it's the one that is modified by external cycle 4) In second overlapping test, CorrectSpawnLocation() may have found a safe position but that won't be spotted and the result will be corrupted by the external cycle

## Returns

[Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

## Parameters

* [Vector3D](VRageMath.Vector3D) basePos
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) radius
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) maxTestCount
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) testsPerDistance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) stepSize
* [MyEntity](VRage.Game.Entity.MyEntity) ignoreEnt
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) allowSafezones
