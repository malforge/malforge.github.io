## Summary

```csharp
public static void RayCastStaticCells(Vector3D worldStart, Vector3D worldEnd, List<Vector3I> outHitPositions, float gridSize, Vector3I? gridSizeInflate, bool havokWorld)
```

Obtains positions of static grid cells regardless of whether these cells are taken up by blocks or not. Usefull when placing block on voxel.

## Parameters

* [Vector3D](VRageMath.Vector3D) worldStart
* [Vector3D](VRageMath.Vector3D) worldEnd
* [List<Vector3I>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) outHitPositions
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) gridSize
* [Vector3I?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) gridSizeInflate
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) havokWorld
