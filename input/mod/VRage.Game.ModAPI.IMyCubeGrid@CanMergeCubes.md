## Summary

```csharp
public bool CanMergeCubes(IMyCubeGrid gridToMerge, Vector3I gridOffset)
```

Determines if merge between grids is possible with given offset

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True whether grids could be merged

## Parameters

* [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid) gridToMerge
* [Vector3I](VRageMath.Vector3I) gridOffset
## Remarks

Can be extremely slow on large grids, that can't be merged

