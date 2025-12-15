## Summary

```csharp
public string RaycastDetectors(Vector3D worldFrom, Vector3D worldTo)
```

## Returns

[string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6)

## Parameters

* [Vector3D](VRageMath.Vector3D) worldFrom
* [Vector3D](VRageMath.Vector3D) worldTo
## Summary

```csharp
public virtual IMyUseObject RaycastDetectors(Vector3D worldFrom, Vector3D worldTo, out float parameter)
```

Determine whether the given ray intersects any detector. If so, returns the parametric value of the point of first intersection. PARAMATER IS NOT DISTANCE!

## Returns

[IMyUseObject](VRage.Game.Entity.UseObject.IMyUseObject)

## Parameters

* [Vector3D](VRageMath.Vector3D) worldFrom
* [Vector3D](VRageMath.Vector3D) worldTo
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) parameter
