## Summary

```csharp
public float AgentHeight
```

This and AgentRadius/AgentMaxClimb are discretized at navmesh build: height & climb against MyRecastOptions.cellHeight, radius against MyPlatformGameSettings.NAVMESH_CELL_SIZE. SBC values are snapped to the Steam grid: the number is what Recast uses on Steam, and on console (coarser cellSize) it rounds up to the next cell count.

## Returns

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

