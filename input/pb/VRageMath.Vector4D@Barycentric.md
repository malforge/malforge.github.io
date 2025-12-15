## Summary

```csharp
public static Vector4D Barycentric(Vector4D value1, Vector4D value2, Vector4D value3, double amount1, double amount2)
```

Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in barycentric (areal) coordinates relative to a 4D triangle.

## Returns

[Vector4D](VRageMath.Vector4D)

## Parameters

* [Vector4D](VRageMath.Vector4D) value1
* [Vector4D](VRageMath.Vector4D) value2
* [Vector4D](VRageMath.Vector4D) value3
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount1
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount2
## Summary

```csharp
public static void Barycentric(ref Vector4D value1, ref Vector4D value2, ref Vector4D value3, double amount1, double amount2, out Vector4D result)
```

Returns a Vector4 containing the 4D Cartesian coordinates of a point specified in Barycentric (areal) coordinates relative to a 4D triangle.

## Parameters

* [Vector4D](VRageMath.Vector4D) value1
* [Vector4D](VRageMath.Vector4D) value2
* [Vector4D](VRageMath.Vector4D) value3
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount1
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) amount2
* [Vector4D](VRageMath.Vector4D) result
