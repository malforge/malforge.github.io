## Summary

```csharp
public static bool IsLineIntersectingBoundingSphere(ref LineD line, ref BoundingSphereD boundingSphere)
```

Check intersection between line and bounding sphere We don't use BoundingSphere.Contains(Ray ...) because ray doesn't have an end, but line does, so we need to check if line really intersects the sphere.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [LineD](VRageMath.LineD) line
* [BoundingSphereD](VRageMath.BoundingSphereD) boundingSphere
