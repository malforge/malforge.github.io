## Summary

```csharp
public void RayCastCells(Vector3D worldStart, Vector3D worldEnd, List<Vector3I> outHitPositions, Vector3I? gridSizeInflate, bool havokWorld, bool clearOutHitPositions)
```

Obtains positions of grid cells regardless of whether these cells are taken up by blocks or not.

## Parameters

* [Vector3D](VRageMath.Vector3D) worldStart
* [Vector3D](VRageMath.Vector3D) worldEnd
* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[Vector3I](VRageMath.Vector3I)&gt; outHitPositions
* [Vector3I?](VRageMath.Vector3I) gridSizeInflate
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) havokWorld
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) clearOutHitPositions
