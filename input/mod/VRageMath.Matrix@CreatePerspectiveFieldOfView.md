## Summary

```csharp
public static Matrix CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance)
```

Builds a perspective projection matrix based on a field of view and returns by value.

## Returns

[Matrix](VRageMath.Matrix)

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) fieldOfView
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) aspectRatio
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) nearPlaneDistance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) farPlaneDistance
## Summary

```csharp
public static void CreatePerspectiveFieldOfView(float fieldOfView, float aspectRatio, float nearPlaneDistance, float farPlaneDistance, out Matrix result)
```

Builds a perspective projection matrix based on a field of view and returns by reference.

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) fieldOfView
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) aspectRatio
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) nearPlaneDistance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) farPlaneDistance
* [Matrix](VRageMath.Matrix) result
