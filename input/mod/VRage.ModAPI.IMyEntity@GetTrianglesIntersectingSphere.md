## Summary

```csharp
public void GetTrianglesIntersectingSphere(ref BoundingSphere sphere, Vector3? referenceNormalVector, float? maxAngle, List<MyTriangle_Vertex_Normals> retTriangles, int maxNeighbourTriangles)
```

Return list of triangles intersecting specified sphere. Angle between every triangleVertexes normal vector and 'referenceNormalVector' is calculated, and if more than 'maxAngle', we ignore such triangleVertexes. Triangles are returned in 'retTriangles', and this list must be preallocated! IMPORTANT: Sphere must be in model space, so don't transform it!

## Parameters

* [BoundingSphere](VRageMath.BoundingSphere) sphere
* [Vector3?](VRageMath.Vector3) referenceNormalVector
* [float?](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) maxAngle
* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[MyTriangle_Vertex_Normals](VRage.Utils.MyTriangle_Vertex_Normals)&gt; retTriangles
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) maxNeighbourTriangles
