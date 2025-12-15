## Summary

```csharp
public static MyCubeGrid SpawnStaticGrid(MyCubeBlockDefinition blockDefinition, MyEntity builder, MatrixD worldMatrix, Vector3 color, MyStringHash skinId, SpawnFlags spawnFlags, long builtBy, Action<MyEntity> completionCallback)
```

## Returns

[MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid)

## Parameters

* [MyCubeBlockDefinition](Sandbox.Definitions.MyCubeBlockDefinition) blockDefinition
* [MyEntity](VRage.Game.Entity.MyEntity) builder
* [MatrixD](VRageMath.MatrixD) worldMatrix
* [Vector3](VRageMath.Vector3) color
* [MyStringHash](VRage.Utils.MyStringHash) skinId
* [SpawnFlags](Sandbox.Game.Entities.MyCubeBuilder+SpawnFlags) spawnFlags
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) builtBy
* [Action<MyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) completionCallback
