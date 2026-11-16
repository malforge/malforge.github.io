**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyPathfindingSessionComponent
```

Describes pathfinding session component

## Methods

|Member|Description|
|---|---|
|[FindAvoidPath(IMyEntity, Vector3D, Vector3D, float, out MyAutopilotPathfindingState)](Sandbox.ModAPI.IMyPathfindingSessionComponent@FindAvoidPath)|Finds the path between start and end position|
|[FindAvoidPath(IMyEntity, Vector3D, Vector3D, float, out MyAutopilotPathfindingState, bool)](Sandbox.ModAPI.IMyPathfindingSessionComponent@FindAvoidPath)|As [FindAvoidPath(IMyEntity, Vector3D, Vector3D, float, out MyAutopilotPathfindingState)](Sandbox.ModAPI.IMyPathfindingSessionComponent@FindAvoidPath) , but withsnapToRoutableVertexan endpoint that resolves to an unusable vertex (disabled, reserved, or edge-less) may snap to the nearest usable vertex in the surrounding cells. Meant for character flight, whose endpoints routinely sit in cells solidified by thin blocks; ship collision avoidance keeps the strict resolution.|

