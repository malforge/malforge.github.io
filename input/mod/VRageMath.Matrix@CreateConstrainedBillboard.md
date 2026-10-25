## Summary

```csharp
public static Matrix CreateConstrainedBillboard(Vector3 objectPosition, Vector3 cameraPosition, Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector)
```

Creates a cylindrical billboard that rotates around a specified axis.

## Returns

[Matrix](VRageMath.Matrix)

## Parameters

* [Vector3](VRageMath.Vector3) objectPosition
* [Vector3](VRageMath.Vector3) cameraPosition
* [Vector3](VRageMath.Vector3) rotateAxis
* [Vector3?](VRageMath.Vector3) cameraForwardVector
* [Vector3?](VRageMath.Vector3) objectForwardVector
## Summary

```csharp
public static void CreateConstrainedBillboard(ref Vector3 objectPosition, ref Vector3 cameraPosition, ref Vector3 rotateAxis, Vector3? cameraForwardVector, Vector3? objectForwardVector, out Matrix result)
```

Creates a cylindrical billboard that rotates around a specified axis.

## Parameters

* [Vector3](VRageMath.Vector3) objectPosition
* [Vector3](VRageMath.Vector3) cameraPosition
* [Vector3](VRageMath.Vector3) rotateAxis
* [Vector3?](VRageMath.Vector3) cameraForwardVector
* [Vector3?](VRageMath.Vector3) objectForwardVector
* [Matrix](VRageMath.Matrix) result
