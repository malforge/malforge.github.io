## Summary

```csharp
public static Matrix CreateBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 cameraUpVector, Vector3? cameraForwardVector)
```

Creates a spherical billboard that rotates around a specified object position.

## Returns

[Matrix](VRageMath.Matrix)

## Parameters

* [Vector3](VRageMath.Vector3) objectPosition
* [Vector3](VRageMath.Vector3) cameraPosition
* [Vector3](VRageMath.Vector3) cameraUpVector
* [Vector3?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) cameraForwardVector
## Summary

```csharp
public static void CreateBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 cameraUpVector, Vector3? cameraForwardVector, out Matrix result)
```

Creates a spherical billboard that rotates around a specified object position.

## Parameters

* [Vector3](VRageMath.Vector3) objectPosition
* [Vector3](VRageMath.Vector3) cameraPosition
* [Vector3](VRageMath.Vector3) cameraUpVector
* [Vector3?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) cameraForwardVector
* [Matrix](VRageMath.Matrix) result
