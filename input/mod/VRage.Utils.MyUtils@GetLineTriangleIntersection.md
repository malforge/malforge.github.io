## Summary

```csharp
public static float? GetLineTriangleIntersection(ref Line line, ref MyTriangle_Vertices triangle)
```

Checks whether a ray intersects a triangleVertexes. This uses the algorithm developed by Tomas Moller and Ben Trumbore, which was published in the Journal of Graphics Tools, pitch 2, "Fast, Minimum Storage Ray-Triangle Intersection". This method is implemented using the pass-by-reference versions of the XNA math functions. Using these overloads is generally not recommended, because they make the code less readable than the normal pass-by-value versions. This method can be called very frequently in a tight inner loop, however, so in this particular case the performance benefits from passing everything by reference outweigh the loss of readability.

## Returns

[float?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

## Parameters

* [Line](VRageMath.Line) line
* [MyTriangle_Vertices](VRage.MyTriangle_Vertices) triangle
