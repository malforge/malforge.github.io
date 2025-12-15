## Summary

```csharp
public BoundingBoxD Intersect(BoundingBoxD box)
```

Returns bounding box which is intersection of this and box Result is invalid box when there's no intersection (Min > Max)

## Returns

[BoundingBoxD](VRageMath.BoundingBoxD)

## Parameters

* [BoundingBoxD](VRageMath.BoundingBoxD) box
## Summary

```csharp
public bool Intersect(ref LineD line, out LineD intersectedLine)
```



## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



## Parameters

* [LineD](VRageMath.LineD) line
* [LineD](VRageMath.LineD) intersectedLine
## Summary

```csharp
public bool Intersect(ref LineD line, out double t1, out double t2)
```



## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



## Parameters

* [LineD](VRageMath.LineD) line
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) t1
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) t2
## Summary

```csharp
public bool Intersect(ref RayD ray, out double tmin, out double tmax)
```



## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



## Parameters

* [RayD](VRageMath.RayD) ray
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) tmin
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) tmax
