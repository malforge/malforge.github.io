## Summary

```csharp
public static void Transform(Vector3[] sourceArray, ref Quaternion rotation, Vector3[] destinationArray)
```

Transforms a source array of Vector3s by a specified Quaternion rotation and writes the results to an existing destination array.

## Parameters

* [Vector3[]](VRageMath.Vector3[]) sourceArray
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector3[]](VRageMath.Vector3[]) destinationArray
## Summary

```csharp
public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector3[] destinationArray, int destinationIndex, int length)
```

Applies a specified Quaternion rotation to a specified range of an array of Vector3s and writes the results into a specified range of a destination array.

## Parameters

* [Vector3[]](VRageMath.Vector3[]) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector3[]](VRageMath.Vector3[]) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
## Summary

```csharp
public static Vector3 Transform(Vector3 position, Matrix matrix)
```

Transforms a 3D vector by the given matrix.

## Returns

[Vector3](VRageMath.Vector3)

## Parameters

* [Vector3](VRageMath.Vector3) position
* [Matrix](VRageMath.Matrix) matrix
## Summary

```csharp
public static Vector3D Transform(Vector3 position, MatrixD matrix)
```

Transforms a 3D vector by the given matrix.

## Returns

[Vector3D](VRageMath.Vector3D)

## Parameters

* [Vector3](VRageMath.Vector3) position
* [MatrixD](VRageMath.MatrixD) matrix
## Summary

```csharp
public static Vector3 Transform(Vector3 position, ref Matrix matrix)
```

## Returns

[Vector3](VRageMath.Vector3)

## Parameters

* [Vector3](VRageMath.Vector3) position
* [Matrix](VRageMath.Matrix) matrix
## Summary

```csharp
public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector3 result)
```

Transforms a Vector3 by the given Matrix.

## Parameters

* [Vector3](VRageMath.Vector3) position
* [Matrix](VRageMath.Matrix) matrix
* [Vector3](VRageMath.Vector3) result
## Summary

```csharp
public static void Transform(ref Vector3 position, ref MatrixI matrix, out Vector3 result)
```

## Parameters

* [Vector3](VRageMath.Vector3) position
* [MatrixI](VRageMath.MatrixI) matrix
* [Vector3](VRageMath.Vector3) result
## Summary

```csharp
public static Vector3 Transform(Vector3 value, Quaternion rotation)
```

Transforms a Vector3 by a specified Quaternion rotation.

## Returns

[Vector3](VRageMath.Vector3)

## Parameters

* [Vector3](VRageMath.Vector3) value
* [Quaternion](VRageMath.Quaternion) rotation
## Summary

```csharp
public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector3 result)
```

Transforms a Vector3 by a specified Quaternion rotation.

## Parameters

* [Vector3](VRageMath.Vector3) value
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector3](VRageMath.Vector3) result
## Summary

```csharp
public static void Transform(Vector3[] sourceArray, ref Matrix matrix, Vector3[] destinationArray)
```

Transforms a source array of Vector3s by a specified Matrix and writes the results to an existing destination array.

## Parameters

* [Vector3[]](VRageMath.Vector3[]) sourceArray
* [Matrix](VRageMath.Matrix) matrix
* [Vector3[]](VRageMath.Vector3[]) destinationArray
## Summary

```csharp
public static void Transform(Vector3[] sourceArray, int sourceIndex, ref Matrix matrix, Vector3[] destinationArray, int destinationIndex, int length)
```

Applies a specified transform Matrix to a specified range of an array of Vector3s and writes the results into a specified range of a destination array.

## Parameters

* [Vector3[]](VRageMath.Vector3[]) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Matrix](VRageMath.Matrix) matrix
* [Vector3[]](VRageMath.Vector3[]) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
