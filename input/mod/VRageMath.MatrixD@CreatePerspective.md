## Summary

```csharp
public static MatrixD CreatePerspective(double width, double height, double nearPlaneDistance, double farPlaneDistance)
```

Builds a perspective projection matrix and returns the result by value.

## Returns

[MatrixD](VRageMath.MatrixD)

## Parameters

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) width
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) height
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) nearPlaneDistance
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) farPlaneDistance
## Summary

```csharp
public static void CreatePerspective(double width, double height, double nearPlaneDistance, double farPlaneDistance, out MatrixD result)
```

Builds a perspective projection matrix and returns the result by reference.

## Parameters

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) width
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) height
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) nearPlaneDistance
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) farPlaneDistance
* [MatrixD](VRageMath.MatrixD) result
