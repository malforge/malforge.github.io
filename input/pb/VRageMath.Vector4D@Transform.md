## Summary

```csharp
public static Vector4D Transform(Vector2 position, MatrixD matrix)
```

Transforms a Vector2 by the given Matrix.

## Returns

[Vector4D](VRageMath.Vector4D)

## Parameters

* [Vector2](VRageMath.Vector2) position
* [MatrixD](VRageMath.MatrixD) matrix
## Summary

```csharp
public static void Transform(ref Vector2 position, ref MatrixD matrix, out Vector4D result)
```

Transforms a Vector2 by the given Matrix.

## Parameters

* [Vector2](VRageMath.Vector2) position
* [MatrixD](VRageMath.MatrixD) matrix
* [Vector4D](VRageMath.Vector4D) result
## Summary

```csharp
public static Vector4D Transform(Vector3D position, MatrixD matrix)
```

Transforms a Vector3 by the given Matrix.

## Returns

[Vector4D](VRageMath.Vector4D)

## Parameters

* [Vector3D](VRageMath.Vector3D) position
* [MatrixD](VRageMath.MatrixD) matrix
## Summary

```csharp
public static void Transform(ref Vector3D position, ref MatrixD matrix, out Vector4D result)
```

Transforms a Vector3 by the given Matrix.

## Parameters

* [Vector3D](VRageMath.Vector3D) position
* [MatrixD](VRageMath.MatrixD) matrix
* [Vector4D](VRageMath.Vector4D) result
## Summary

```csharp
public static Vector4D Transform(Vector4D vector, MatrixD matrix)
```

Transforms a Vector4 by the specified Matrix.

## Returns

[Vector4D](VRageMath.Vector4D)

## Parameters

* [Vector4D](VRageMath.Vector4D) vector
* [MatrixD](VRageMath.MatrixD) matrix
## Summary

```csharp
public static void Transform(ref Vector4D vector, ref MatrixD matrix, out Vector4D result)
```

Transforms a Vector4 by the given Matrix.

## Parameters

* [Vector4D](VRageMath.Vector4D) vector
* [MatrixD](VRageMath.MatrixD) matrix
* [Vector4D](VRageMath.Vector4D) result
## Summary

```csharp
public static Vector4D Transform(Vector2 value, Quaternion rotation)
```

Transforms a Vector2 by a specified Quaternion into a Vector4.

## Returns

[Vector4D](VRageMath.Vector4D)

## Parameters

* [Vector2](VRageMath.Vector2) value
* [Quaternion](VRageMath.Quaternion) rotation
## Summary

```csharp
public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector4D result)
```

Transforms a Vector2 by a specified Quaternion into a Vector4.

## Parameters

* [Vector2](VRageMath.Vector2) value
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector4D](VRageMath.Vector4D) result
## Summary

```csharp
public static Vector4D Transform(Vector3D value, Quaternion rotation)
```

Transforms a Vector3 by a specified Quaternion into a Vector4.

## Returns

[Vector4D](VRageMath.Vector4D)

## Parameters

* [Vector3D](VRageMath.Vector3D) value
* [Quaternion](VRageMath.Quaternion) rotation
## Summary

```csharp
public static void Transform(ref Vector3D value, ref Quaternion rotation, out Vector4D result)
```

Transforms a Vector3 by a specified Quaternion into a Vector4.

## Parameters

* [Vector3D](VRageMath.Vector3D) value
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector4D](VRageMath.Vector4D) result
## Summary

```csharp
public static Vector4D Transform(Vector4D value, Quaternion rotation)
```

Transforms a Vector4 by a specified Quaternion.

## Returns

[Vector4D](VRageMath.Vector4D)

## Parameters

* [Vector4D](VRageMath.Vector4D) value
* [Quaternion](VRageMath.Quaternion) rotation
## Summary

```csharp
public static void Transform(ref Vector4D value, ref Quaternion rotation, out Vector4D result)
```

Transforms a Vector4 by a specified Quaternion.

## Parameters

* [Vector4D](VRageMath.Vector4D) value
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector4D](VRageMath.Vector4D) result
## Summary

```csharp
public static void Transform(Vector4D[] sourceArray, ref MatrixD matrix, Vector4D[] destinationArray)
```

Transforms an array of Vector4s by a specified Matrix.

## Parameters

* [Vector4D[]](VRageMath.Vector4D[]) sourceArray
* [MatrixD](VRageMath.MatrixD) matrix
* [Vector4D[]](VRageMath.Vector4D[]) destinationArray
## Summary

```csharp
public static void Transform(Vector4D[] sourceArray, int sourceIndex, ref MatrixD matrix, Vector4D[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector4s by a specified Matrix into a specified range in a destination array.

## Parameters

* [Vector4D[]](VRageMath.Vector4D[]) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [MatrixD](VRageMath.MatrixD) matrix
* [Vector4D[]](VRageMath.Vector4D[]) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
## Summary

```csharp
public static void Transform(Vector4D[] sourceArray, ref Quaternion rotation, Vector4D[] destinationArray)
```

Transforms an array of Vector4s by a specified Quaternion.

## Parameters

* [Vector4D[]](VRageMath.Vector4D[]) sourceArray
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector4D[]](VRageMath.Vector4D[]) destinationArray
## Summary

```csharp
public static void Transform(Vector4D[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector4D[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector4s by a specified Quaternion into a specified range in a destination array.

## Parameters

* [Vector4D[]](VRageMath.Vector4D[]) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector4D[]](VRageMath.Vector4D[]) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
