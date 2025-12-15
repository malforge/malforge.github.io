## Summary

```csharp
public static float Dot(Vector2 value1, Vector2 value2)
```

Calculates the dot product of two vectors. If the two vectors are unit vectors, the dot product returns a floating point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

## Returns

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

## Parameters

* [Vector2](VRageMath.Vector2) value1
* [Vector2](VRageMath.Vector2) value2
## Summary

```csharp
public static void Dot(ref Vector2 value1, ref Vector2 value2, out float result)
```

Calculates the dot product of two vectors and writes the result to a user-specified variable. If the two vectors are unit vectors, the dot product returns a floating point value between -1 and 1 that can be used to determine some properties of the angle between two vectors. For example, it can show whether the vectors are orthogonal, parallel, or have an acute or obtuse angle between them.

## Parameters

* [Vector2](VRageMath.Vector2) value1
* [Vector2](VRageMath.Vector2) value2
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) result
