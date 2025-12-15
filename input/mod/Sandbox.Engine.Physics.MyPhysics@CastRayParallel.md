## Summary

```csharp
public static void CastRayParallel(ref Vector3D from, ref Vector3D to, int raycastFilterLayer, Action<HitInfo?> callback)
```

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) raycastFilterLayer
* [Action<HitInfo?>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) callback
## Summary

```csharp
public static void CastRayParallel(ref Vector3D from, ref Vector3D to, List<HitInfo> collector, int raycastFilterLayer, Action<List<HitInfo>> callback)
```

## Parameters

* [Vector3D](VRageMath.Vector3D) from
* [Vector3D](VRageMath.Vector3D) to
* [List<HitInfo>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) collector
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) raycastFilterLayer
* [Action<List<HitInfo>>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) callback
