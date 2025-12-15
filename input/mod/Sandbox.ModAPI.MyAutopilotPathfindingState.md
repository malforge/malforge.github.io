**Assembly:** Sandbox.Common.dll

```csharp
public enum MyAutopilotPathfindingState
```

Describes state of autopilot pathfinding

## Fields

|Member|Description|
|---|---|
|NotUsed|Pathfinding was not used|
|OctreeGenerating|Octree for the grid does not exist and has to be generated|
|PathFound|Path of the pathfinding graph was found|
|PathNotFound|Path of the pathfinding graph was not found|
|VertexFound|Vertex of the pathfinding graph was found|
|VertexNotFound|Vertex of the pathfinding graph was not found|

