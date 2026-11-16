## Summary

```csharp
public float AgentHeight
```

This and AgentRadius/AgentMaxClimb are discretized at navmesh build: height & climb against MyPlatformGameSettings.NAVMESH_CELL_HEIGHT, radius against MyPlatformGameSettings.NAVMESH_CELL_SIZE. Height and radius round up to whole cells, climb rounds down and is raised to at least MyPlatformGameSettings.NAVMESH_MIN_AGENT_CLIMB.

## Returns

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

