## Summary

```csharp
public void CastRayParallel(ref Vector3D from, ref Vector3D to, int raycastCollisionFilter, Action<IHitInfo> callback)
```

Cast a ray and return first entity. May be called from parallel thread.

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) raycastCollisionFilter
* [Action<IHitInfo>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) callback
## Summary

```csharp
public void CastRayParallel(ref Vector3D from, ref Vector3D to, List<IHitInfo> toList, int raycastCollisionFilter, Action<List<IHitInfo>> callback)
```

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [List<IHitInfo>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) toList
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) raycastCollisionFilter
* [Action<List<IHitInfo>>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) callback
