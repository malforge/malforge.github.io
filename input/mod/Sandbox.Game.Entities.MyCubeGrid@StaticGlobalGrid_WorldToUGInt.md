## Summary

```csharp
public static Vector3I StaticGlobalGrid_WorldToUGInt(Vector3D worldPos, float gridSize, bool staticGridAlignToCenter)
```

Converts world coordinate to static global grid uniform coordinate (virtual large grid in whole world which every large grid is snapped to). Grid size is already used inside calculation.

## Returns

[Vector3I](VRageMath.Vector3I)

## Parameters

* [Vector3D](VRageMath.Vector3D) worldPos
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) gridSize
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) staticGridAlignToCenter
