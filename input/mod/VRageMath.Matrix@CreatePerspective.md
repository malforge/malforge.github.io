## Summary

```csharp
public static Matrix CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance)
```

Builds a perspective projection matrix and returns the result by value.

## Returns

[Matrix](VRageMath.Matrix)

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) width
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) height
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) nearPlaneDistance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) farPlaneDistance
## Summary

```csharp
public static void CreatePerspective(float width, float height, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
```

Builds a perspective projection matrix and returns the result by reference.

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) width
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) height
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) nearPlaneDistance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) farPlaneDistance
* [Matrix](VRageMath.Matrix) result
