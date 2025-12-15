## Summary

```csharp
public Vector3D? RandomToUniformPointInSphereWithInnerCutout(double ranX, double ranY, double ranZ, double cutoutRadius)
```

Similar to RandomToUniformPointInSphere(...) but excludes points within distance of cutoutRadius from center. (Results are randomly distributed in the shape that remains from sphere that had another sphere cut out from center. )

## Returns

[Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6)



## Parameters

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) ranX
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) ranY
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) ranZ
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) cutoutRadius
