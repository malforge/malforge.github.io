## Summary

```csharp
public void CreateLink(GridLinkTypeEnum type, long linkId, MyCubeGrid parent, MyCubeGrid child)
```

Creates link between parent and child. Parent is owner of constraint. LinkId must be unique only for parent, for grid it can be packed position of block which created constraint.

## Parameters

* [GridLinkTypeEnum](VRage.Game.ModAPI.GridLinkTypeEnum) type
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) linkId
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) parent
* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) child
