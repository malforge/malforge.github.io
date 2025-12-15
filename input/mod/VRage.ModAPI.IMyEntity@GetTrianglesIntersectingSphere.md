## Summary

```csharp
public void GetTrianglesIntersectingSphere(ref BoundingSphere sphere, Vector3? referenceNormalVector, float? maxAngle, List<MyTriangle_Vertex_Normals> retTriangles, int maxNeighbourTriangles)
```

Return list of triangles intersecting specified sphere. Angle between every triangleVertexes normal vector and 'referenceNormalVector' is calculated, and if more than 'maxAngle', we ignore such triangleVertexes. Triangles are returned in 'retTriangles', and this list must be preallocated! IMPORTANT: Sphere must be in model space, so don't transform it!

## Parameters

* [BoundingSphere](VRageMath.BoundingSphere) sphere
* [Vector3?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) referenceNormalVector
* [float?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) maxAngle
* [List<MyTriangle_Vertex_Normals>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) retTriangles
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) maxNeighbourTriangles
