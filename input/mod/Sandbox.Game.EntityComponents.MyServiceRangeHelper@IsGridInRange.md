## Summary

```csharp
public static bool IsGridInRange(IMyEntity serviceBlock, float range, MyCubeGrid grid)
```

Whether any grid in the target's mechanical group has a world AABB within range of the service block. Group-aware to match the enumeration, which lists a group if any of its subgrids is in range.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) serviceBlock
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) range
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) grid
