## Summary

```csharp
public bool CastLongRay(Vector3D from, Vector3D to, out IHitInfo hitInfo, bool any)
```

Finds closest or any object on the path of the ray from->to. Uses Storage for voxels for faster search but only good for long rays (more or less more than 50m). Use it only in such cases.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

true if hit, false if no hit

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [IHitInfo](VRage.Game.ModAPI.IHitInfo) hitInfo
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) any
