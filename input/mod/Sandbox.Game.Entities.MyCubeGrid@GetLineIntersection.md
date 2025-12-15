## Summary

```csharp
public static bool GetLineIntersection(ref LineD line, out MyCubeGrid grid, out Vector3I position, out double distanceSquared, Func<MyCubeGrid, bool> condition)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [LineD](VRageMath.LineD) line
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) grid
* [Vector3I](VRageMath.Vector3I) position
* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) distanceSquared
* [Func<MyCubeGrid, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) condition
