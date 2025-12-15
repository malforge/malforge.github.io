## Summary

```csharp
public static Matrix CreateShadow(Vector3 lightDirection, Plane plane)
```

Creates a Matrix that flattens geometry into a specified Plane as if casting a shadow from a specified light source.

## Returns

[Matrix](VRageMath.Matrix)

## Parameters

* [Vector3](VRageMath.Vector3) lightDirection
* [Plane](VRageMath.Plane) plane
## Summary

```csharp
public static void CreateShadow(ref Vector3 lightDirection, ref Plane plane, out Matrix result)
```

Fills in a Matrix to flatten geometry into a specified Plane as if casting a shadow from a specified light source.

## Parameters

* [Vector3](VRageMath.Vector3) lightDirection
* [Plane](VRageMath.Plane) plane
* [Matrix](VRageMath.Matrix) result
