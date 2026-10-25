## Summary

```csharp
public Action<MyCubeGrid, MyCubeGrid> event OnGridMerge
```

Called, when 2 grids are merged with merge block. First grid - grid that will stay, second - will be merged into first, and deleted. Called for both grids

## Returns

[Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6)&lt;[MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid), [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid)&gt;

