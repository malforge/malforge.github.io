## Summary

```csharp
public static Vector3? GetEdgeSphereCollision(ref Vector3 sphereCenter, float sphereRadius, ref MyTriangle_Vertices triangle)
```

Returns intersection point between sphere and its edges. But only if there is intersection between sphere and one of the edges. If sphere intersects somewhere inside the triangle, this method will not detect it.

## Returns

[Vector3?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

## Parameters

* [Vector3](VRageMath.Vector3) sphereCenter
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) sphereRadius
* [MyTriangle_Vertices](VRage.MyTriangle_Vertices) triangle
