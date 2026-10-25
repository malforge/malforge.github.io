## Summary

```csharp
public void RemoveItems(uint itemId, MyFixedPoint? amount, bool sendEvent, bool spawn, MatrixD? spawnPos, Action<MyDefinitionId, MyEntity> itemSpawned, bool refreshVolumeAndMass)
```

## Parameters

* [uint](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32?view=netframework-4.6) itemId
* [MyFixedPoint?](VRage.MyFixedPoint) amount
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) sendEvent
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) spawn
* [MatrixD?](VRageMath.MatrixD) spawnPos
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6)&lt;[MyDefinitionId](VRage.Game.MyDefinitionId), [MyEntity](VRage.Game.Entity.MyEntity)&gt; itemSpawned
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) refreshVolumeAndMass
