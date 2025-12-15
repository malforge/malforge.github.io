## Summary

```csharp
public static bool IsShapePenetrating(HkShape shape, ref Vector3D position, ref Quaternion rotation, int filter, MyEntity ignoreEnt, bool allowSafezones)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* HkShape <sub>prohibited</sub> shape
* [Vector3D](VRageMath.Vector3D) position
* [Quaternion](VRageMath.Quaternion) rotation
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) filter
* [MyEntity](VRage.Game.Entity.MyEntity) ignoreEnt
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) allowSafezones
## Summary

```csharp
public static bool IsShapePenetrating(HkShape shape, ref Vector3D position, ref Quaternion rotation, Func<IMyEntity, bool> entityFilter, int filter, bool allowSafezones)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* HkShape <sub>prohibited</sub> shape
* [Vector3D](VRageMath.Vector3D) position
* [Quaternion](VRageMath.Quaternion) rotation
* [Func<IMyEntity, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) entityFilter
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) filter
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) allowSafezones
