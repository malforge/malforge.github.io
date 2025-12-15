## Summary

```csharp
public bool BreakLink(GridLinkTypeEnum type, long linkId, MyCubeGrid parent, MyCubeGrid child)
```

Breaks link between parent and child, you can set child to null to find it by linkId. Returns true when link was removed, returns false when link was not found.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [GridLinkTypeEnum](VRage.Game.ModAPI.GridLinkTypeEnum) type
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) linkId
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) parent
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) child
