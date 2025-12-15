## Summary

```csharp
public static void CastRay(Vector3D from, Vector3D to, List<HitInfo> toList, int raycastFilterLayer)
```

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [List<HitInfo>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) toList
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) raycastFilterLayer
## Summary

```csharp
public static HitInfo? CastRay(Vector3D from, Vector3D to, int raycastFilterLayer)
```

## Returns

[HitInfo?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) raycastFilterLayer
## Summary

```csharp
public static bool CastRay(Vector3D from, Vector3D to, out HitInfo hitInfo, uint raycastCollisionFilter, bool ignoreConvexShape)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [HitInfo](Sandbox.Engine.Physics.MyPhysics+HitInfo) hitInfo
* [uint](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32?view=netframework-4.6) raycastCollisionFilter
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) ignoreConvexShape
