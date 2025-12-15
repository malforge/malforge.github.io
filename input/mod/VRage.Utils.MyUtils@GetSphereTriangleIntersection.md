## Summary

```csharp
public static Vector3? GetSphereTriangleIntersection(ref BoundingSphere sphere, ref Plane trianglePlane, ref MyTriangle_Vertices triangle)
```

Method returns intersection point between sphere and triangle (which is defined by vertexes and plane). If no intersection found, method returns null. See below how intersection point can be calculated, because it's not so easy - for example sphere vs. triangle will hardly generate just intersection point... more like intersection area or something.

## Returns

[Vector3?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

## Parameters

* [BoundingSphere](VRageMath.BoundingSphere) sphere
* [Plane](VRageMath.Plane) trianglePlane
* [MyTriangle_Vertices](VRage.MyTriangle_Vertices) triangle
