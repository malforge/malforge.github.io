## Summary

```csharp
public static Vector2 Transform(Vector2 position, Matrix matrix)
```

Transforms the vector (x, y, 0, 1) by the specified matrix.

## Returns

[Vector2](VRageMath.Vector2)

## Parameters

* [Vector2](VRageMath.Vector2) position
* [Matrix](VRageMath.Matrix) matrix
## Summary

```csharp
public static void Transform(ref Vector2 position, ref Matrix matrix, out Vector2 result)
```

Transforms a Vector2 by the given Matrix.

## Parameters

* [Vector2](VRageMath.Vector2) position
* [Matrix](VRageMath.Matrix) matrix
* [Vector2](VRageMath.Vector2) result
## Summary

```csharp
public static Vector2 Transform(Vector2 value, Quaternion rotation)
```

Transforms a single Vector2, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

## Returns

[Vector2](VRageMath.Vector2)

## Parameters

* [Vector2](VRageMath.Vector2) value
* [Quaternion](VRageMath.Quaternion) rotation
## Summary

```csharp
public static void Transform(ref Vector2 value, ref Quaternion rotation, out Vector2 result)
```

Transforms a Vector2, or the vector normal (x, y, 0, 0), by a specified Quaternion rotation.

## Parameters

* [Vector2](VRageMath.Vector2) value
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector2](VRageMath.Vector2) result
## Summary

```csharp
public static void Transform(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray)
```

Transforms an array of Vector2s by a specified Matrix.

## Parameters

* [Vector2[]](VRageMath.Vector2[]) sourceArray
* [Matrix](VRageMath.Matrix) matrix
* [Vector2[]](VRageMath.Vector2[]) destinationArray
## Summary

```csharp
public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector2s by a specified Matrix and places the results in a specified range in a destination array.

## Parameters

* [Vector2[]](VRageMath.Vector2[]) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Matrix](VRageMath.Matrix) matrix
* [Vector2[]](VRageMath.Vector2[]) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
## Summary

```csharp
public static void Transform(Vector2[] sourceArray, ref Quaternion rotation, Vector2[] destinationArray)
```

Transforms an array of Vector2s by a specified Quaternion.

## Parameters

* [Vector2[]](VRageMath.Vector2[]) sourceArray
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector2[]](VRageMath.Vector2[]) destinationArray
## Summary

```csharp
public static void Transform(Vector2[] sourceArray, int sourceIndex, ref Quaternion rotation, Vector2[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector2s by a specified Quaternion and places the results in a specified range in a destination array.

## Parameters

* [Vector2[]](VRageMath.Vector2[]) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Quaternion](VRageMath.Quaternion) rotation
* [Vector2[]](VRageMath.Vector2[]) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
