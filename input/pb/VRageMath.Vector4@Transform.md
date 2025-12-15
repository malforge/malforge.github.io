## Summary

```csharp
public static Vector4 Transform(Vector2 position, Matrix matrix)
```

Transforms a Vector2 by the given Matrix.

## Returns

[Vector4](VRageMath.Vector4)

## Parameters

* [Vector2](VRageMath.Vector2) position
* [Matrix](VRageMath.Matrix) matrix
## Summary

```csharp
public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector4 result)
```

Transforms a Vector2 by the given Matrix.

## Parameters

* [Vector2](VRageMath.Vector2) position
* [Matrix](VRageMath.Matrix) matrix
* [Vector4](VRageMath.Vector4) result
## Summary

```csharp
public static Vector4 Transform(Vector3 position, Matrix matrix)
```

Transforms a Vector3 by the given Matrix.

## Returns

[Vector4](VRageMath.Vector4)

## Parameters

* [Vector3](VRageMath.Vector3) position
* [Matrix](VRageMath.Matrix) matrix
## Summary

```csharp
public static void Transform(ref Vector3 position, ref Matrix matrix, out Vector4 result)
```

Transforms a Vector3 by the given Matrix.

## Parameters

* [Vector3](VRageMath.Vector3) position
* [Matrix](VRageMath.Matrix) matrix
* [Vector4](VRageMath.Vector4) result
## Summary

```csharp
public static Vector4 Transform(Vector4 vector, Matrix matrix)
```

Transforms a Vector4 by the specified Matrix.

## Returns

[Vector4](VRageMath.Vector4)

## Parameters

* [Vector4](VRageMath.Vector4) vector
* [Matrix](VRageMath.Matrix) matrix
## Summary

```csharp
public static void Transform(ref Vector4 vector, ref Matrix matrix, out Vector4 result)
```

Transforms a Vector4 by the given Matrix.

## Parameters

* [Vector4](VRageMath.Vector4) vector
* [Matrix](VRageMath.Matrix) matrix
* [Vector4](VRageMath.Vector4) result
## Summary

```csharp
public static Vector4 Transform(Vector2 value, Quaternion rotation)
```

Transforms a Vector2 by a specified Quaternion into a Vector4.

## Returns

[Vector4](VRageMath.Vector4)

## Parameters

* [Vector2](VRageMath.Vector2) value
* [Quaternion](VRageMath.Quaternion) rotation
## Summary

```csharp
public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector4 result)
```

Transforms a Vector2 by a specified Quaternion into a Vector4.

## Parameters

* [Vector2](VRageMath.Vector2) value
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector4](VRageMath.Vector4) result
## Summary

```csharp
public static Vector4 Transform(Vector3 value, Quaternion rotation)
```

Transforms a Vector3 by a specified Quaternion into a Vector4.

## Returns

[Vector4](VRageMath.Vector4)

## Parameters

* [Vector3](VRageMath.Vector3) value
* [Quaternion](VRageMath.Quaternion) rotation
## Summary

```csharp
public static void Transform(ref Vector3 value, ref Quaternion rotation, out Vector4 result)
```

Transforms a Vector3 by a specified Quaternion into a Vector4.

## Parameters

* [Vector3](VRageMath.Vector3) value
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector4](VRageMath.Vector4) result
## Summary

```csharp
public static Vector4 Transform(Vector4 value, Quaternion rotation)
```

Transforms a Vector4 by a specified Quaternion.

## Returns

[Vector4](VRageMath.Vector4)

## Parameters

* [Vector4](VRageMath.Vector4) value
* [Quaternion](VRageMath.Quaternion) rotation
## Summary

```csharp
public static void Transform(ref Vector4 value, ref Quaternion rotation, out Vector4 result)
```

Transforms a Vector4 by a specified Quaternion.

## Parameters

* [Vector4](VRageMath.Vector4) value
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector4](VRageMath.Vector4) result
## Summary

```csharp
public static void Transform(Vector4[] sourceArray, ref Matrix matrix, Vector4[] destinationArray)
```

Transforms an array of Vector4s by a specified Matrix.

## Parameters

* [Vector4[]](VRageMath.Vector4[]) sourceArray
* [Matrix](VRageMath.Matrix) matrix
* [Vector4[]](VRageMath.Vector4[]) destinationArray
## Summary

```csharp
public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Matrix matrix, Vector4[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector4s by a specified Matrix into a specified range in a destination array.

## Parameters

* [Vector4[]](VRageMath.Vector4[]) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Matrix](VRageMath.Matrix) matrix
* [Vector4[]](VRageMath.Vector4[]) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
## Summary

```csharp
public static void Transform(Vector4[] sourceArray, ref Quaternion rotation, Vector4[] destinationArray)
```

Transforms an array of Vector4s by a specified Quaternion.

## Parameters

* [Vector4[]](VRageMath.Vector4[]) sourceArray
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector4[]](VRageMath.Vector4[]) destinationArray
## Summary

```csharp
public static void Transform(Vector4[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector4[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector4s by a specified Quaternion into a specified range in a destination array.

## Parameters

* [Vector4[]](VRageMath.Vector4[]) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector4[]](VRageMath.Vector4[]) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
