## Summary

```csharp
public bool MoveProxy(int proxyId, ref BoundingBoxD aabb, Vector3D displacement)
```

Move a proxy with a swepted BoundingBox. If the proxy has moved outside of its fattened BoundingBox, then the proxy is removed from the tree and re-inserted. Otherwise the function returns immediately.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

true if the proxy was re-inserted.

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) proxyId
* [BoundingBoxD](VRageMath.BoundingBoxD) aabb
* [Vector3D](VRageMath.Vector3D) displacement
