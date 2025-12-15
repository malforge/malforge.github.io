## Summary

```csharp
public static Vector2 TransformNormal(Vector2 normal, Matrix matrix)
```

Transforms a 2D vector normal by a matrix.

## Returns

[Vector2](VRageMath.Vector2)

## Parameters

* [Vector2](VRageMath.Vector2) normal
* [Matrix](VRageMath.Matrix) matrix
## Summary

```csharp
public static void TransformNormal(ref Vector2 normal, ref Matrix matrix, out Vector2 result)
```

Transforms a vector normal by a matrix.

## Parameters

* [Vector2](VRageMath.Vector2) normal
* [Matrix](VRageMath.Matrix) matrix
* [Vector2](VRageMath.Vector2) result
## Summary

```csharp
public static void TransformNormal(Vector2[] sourceArray, ref Matrix matrix, Vector2[] destinationArray)
```

Transforms an array of Vector2 vector normals by a specified Matrix.

## Parameters

* [Vector2[]](VRageMath.Vector2[]) sourceArray
* [Matrix](VRageMath.Matrix) matrix
* [Vector2[]](VRageMath.Vector2[]) destinationArray
## Summary

```csharp
public static void TransformNormal(Vector2[] sourceArray, int sourceIndex, ref Matrix matrix, Vector2[] destinationArray, int destinationIndex, int length)
```

Transforms a specified range in an array of Vector2 vector normals by a specified Matrix and places the results in a specified range in a destination array.

## Parameters

* [Vector2[]](VRageMath.Vector2[]) sourceArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) sourceIndex
* [Matrix](VRageMath.Matrix) matrix
* [Vector2[]](VRageMath.Vector2[]) destinationArray
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) destinationIndex
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
