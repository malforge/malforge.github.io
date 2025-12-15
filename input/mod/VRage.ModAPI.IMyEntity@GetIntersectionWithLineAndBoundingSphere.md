## Summary

```csharp
public Vector3D? GetIntersectionWithLineAndBoundingSphere(ref LineD line, float boundingSphereRadiusMultiplier)
```

Calculates intersection of line with any bounding sphere in this model instance. Center of the bounding sphere will be returned. It takes boundingSphereRadiusMultiplier argument which serves for extending the influence (radius) for interaction with line.

## Returns

[Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

Position of intersection if of line and bounding sphere

## Parameters

* [LineD](VRageMath.LineD) line
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) boundingSphereRadiusMultiplier
