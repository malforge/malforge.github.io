## Summary

```csharp
public static HitInfo? CastLongRay(Vector3D from, Vector3D to, bool any)
```

Finds closest or any object on the path of the ray from->to. Uses Storage for voxels for faster search but only good for long rays (more or less more than 50m). Use it only in such cases.

## Returns

[HitInfo?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

Hit info.

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) any
