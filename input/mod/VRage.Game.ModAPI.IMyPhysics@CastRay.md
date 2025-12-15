## Summary

```csharp
public void CastRay(Vector3D from, Vector3D to, List<IHitInfo> toList, int raycastFilterLayer)
```

Cast a ray and returns all matching entities. Must not be called from parallel thread!!!

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [List<IHitInfo>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) toList
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) raycastFilterLayer
## Summary

```csharp
public bool CastRay(Vector3D from, Vector3D to, out IHitInfo hitInfo, int raycastFilterLayer)
```

Cast a ray and return first entity. Must not be called from parallel thread!!!

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

true if hit; false if no hit

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [IHitInfo](VRage.Game.ModAPI.IHitInfo) hitInfo
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) raycastFilterLayer
## Summary

```csharp
public bool CastRay(Vector3D from, Vector3D to, out IHitInfo hitInfo, uint raycastCollisionFilter, bool ignoreConvexShape)
```

Cast a ray and return first entity. Must not be called from parallel thread!!!

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

true if hit; false if no hit

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [IHitInfo](VRage.Game.ModAPI.IHitInfo) hitInfo
* [uint](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32?view=netframework-4.6) raycastCollisionFilter
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) ignoreConvexShape
