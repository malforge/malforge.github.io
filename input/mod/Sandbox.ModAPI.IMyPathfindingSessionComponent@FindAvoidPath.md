## Summary

```csharp
public MyPath<MyPathVertex> FindAvoidPath(IMyEntity entity, Vector3D startPosition, Vector3D endPosition, float shipRadius, out MyAutopilotPathfindingState state)
```

Finds the path between start and end position

## Returns

MyPath&lt;MyPathVertex <sub>prohibited</sub>&gt; <sub>prohibited</sub>



## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) entity
* [Vector3D](VRageMath.Vector3D) startPosition
* [Vector3D](VRageMath.Vector3D) endPosition
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) shipRadius
* [MyAutopilotPathfindingState](Sandbox.ModAPI.MyAutopilotPathfindingState) state
## Summary

```csharp
public MyPath<MyPathVertex> FindAvoidPath(IMyEntity entity, Vector3D startPosition, Vector3D endPosition, float shipRadius, out MyAutopilotPathfindingState state, bool snapToRoutableVertex)
```

As [FindAvoidPath(IMyEntity, Vector3D, Vector3D, float, out MyAutopilotPathfindingState)](Sandbox.ModAPI.IMyPathfindingSessionComponent@FindAvoidPath) , but withsnapToRoutableVertexan endpoint that resolves to an unusable vertex (disabled, reserved, or edge-less) may snap to the nearest usable vertex in the surrounding cells. Meant for character flight, whose endpoints routinely sit in cells solidified by thin blocks; ship collision avoidance keeps the strict resolution.

## Returns

MyPath&lt;MyPathVertex <sub>prohibited</sub>&gt; <sub>prohibited</sub>

## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) entity
* [Vector3D](VRageMath.Vector3D) startPosition
* [Vector3D](VRageMath.Vector3D) endPosition
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) shipRadius
* [MyAutopilotPathfindingState](Sandbox.ModAPI.MyAutopilotPathfindingState) state
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) snapToRoutableVertex
