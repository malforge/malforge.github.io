## Summary

```csharp
public static void GetPenetrationsShapeParallel(HkShape shape, ref Vector3D translation, ref Quaternion rotation, HashSet<HkRigidBody> results, int filter, Action<HashSet<HkRigidBody>> callback)
```

## Parameters

* HkShape <sub>prohibited</sub> shape
* [Vector3D](VRageMath.Vector3D) translation
* [Quaternion](VRageMath.Quaternion) rotation
* [HashSet<HkRigidBody>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netframework-4.6) results
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) filter
* [Action<HashSet<HkRigidBody>>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) callback
