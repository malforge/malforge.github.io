## Summary

```csharp
public IMyGridTerminalSystem GetTerminalSystemForGrid(IMyCubeGrid grid)
```

Gets [IMyGridTerminalSystem](Sandbox.ModAPI.IMyGridTerminalSystem) for grid

## Returns

[IMyGridTerminalSystem](Sandbox.ModAPI.IMyGridTerminalSystem)

 [IMyGridTerminalSystem](Sandbox.ModAPI.IMyGridTerminalSystem) or null, if called too early (on MyCubeGrid.InitInternal).

## Parameters

* [IMyCubeGrid](VRage.Game.ModAPI.IMyCubeGrid) grid
## Remarks

Connected grids with [Logical](VRage.Game.ModAPI.GridLinkTypeEnum@Logical) linking has 1 same for all [IMyGridTerminalSystem](Sandbox.ModAPI.IMyGridTerminalSystem) . You can pass any grid belonging to that grid-group.

