**Assembly:** Sandbox.Game.dll

```csharp
public interface IMyUpdateOrchestrator
```

## Properties

|Member|Description|
|---|---|
|[StatsFilter](Sandbox.Game.Entities.IMyUpdateOrchestrator@StatsFilter)||
|[StatsViewDirFilter](Sandbox.Game.Entities.IMyUpdateOrchestrator@StatsViewDirFilter)||

## Methods

|Member|Description|
|---|---|
|[AddEntity(MyEntity)](Sandbox.Game.Entities.IMyUpdateOrchestrator@AddEntity)||
|[ClearStats()](Sandbox.Game.Entities.IMyUpdateOrchestrator@ClearStats)||
|[DebugDraw()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DebugDraw)||
|[DispatchAfterSimulation()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DispatchAfterSimulation)||
|[DispatchBeforeSimulation()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DispatchBeforeSimulation)||
|[DispatchOnceBeforeFrame()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DispatchOnceBeforeFrame)||
|[DispatchSimulate()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DispatchSimulate)||
|[DispatchUpdatingStopped()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DispatchUpdatingStopped)||
|[EntityFlagsChanged(MyEntity)](Sandbox.Game.Entities.IMyUpdateOrchestrator@EntityFlagsChanged)||
|[GetStats()](Sandbox.Game.Entities.IMyUpdateOrchestrator@GetStats)||
|[InvokeLater(Action, string)](Sandbox.Game.Entities.IMyUpdateOrchestrator@InvokeLater)|Schedule a callback to be invoked in the update thread at a later time.|
|[RemoveEntity(MyEntity, bool)](Sandbox.Game.Entities.IMyUpdateOrchestrator@RemoveEntity)||
|[Unload()](Sandbox.Game.Entities.IMyUpdateOrchestrator@Unload)||

**Inheritors:**  
* [MyParallelEntityUpdateOrchestrator](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator)

