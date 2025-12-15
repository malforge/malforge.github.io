**Assembly:** Sandbox.Game.dll

```csharp
public class MyParallelEntityUpdateOrchestrator: IMyUpdateOrchestrator
```

## Fields

|Member|Description|
|---|---|
|[static ForceSerialUpdate](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@ForceSerialUpdate)|Global switch to force serial execution.|
|[static STATS_SPLIT_CHARACTER](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@STATS_SPLIT_CHARACTER)||
|[static WorkerPriority](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@WorkerPriority)|Priority of the worker threads where work is scheduled.|

## Properties

|Member|Description|
|---|---|
|[static ParallelUpdateInProgress](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@ParallelUpdateInProgress)||
|[StatsFilter](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@StatsFilter)||
|[StatsViewDirFilter](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@StatsViewDirFilter)||
|[StatsFilter](Sandbox.Game.Entities.IMyUpdateOrchestrator@StatsFilter)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[StatsViewDirFilter](Sandbox.Game.Entities.IMyUpdateOrchestrator@StatsViewDirFilter)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|

## Constructors

|Member|Description|
|---|---|
|[MyParallelEntityUpdateOrchestrator()](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@.ctor)||

## Methods

|Member|Description|
|---|---|
|[AddEntity(MyEntity)](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@AddEntity)||
|[ClearStats()](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@ClearStats)||
|[DebugDraw()](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@DebugDraw)||
|[DispatchAfterSimulation()](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@DispatchAfterSimulation)||
|[DispatchBeforeSimulation()](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@DispatchBeforeSimulation)||
|[DispatchOnceBeforeFrame()](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@DispatchOnceBeforeFrame)||
|[DispatchSimulate()](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@DispatchSimulate)||
|[DispatchUpdatingStopped()](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@DispatchUpdatingStopped)||
|[EntityFlagsChanged(MyEntity)](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@EntityFlagsChanged)||
|[GetStats()](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@GetStats)||
|[InvokeLater(Action, string)](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@InvokeLater)||
|[ProcessInvokeLater()](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@ProcessInvokeLater)|Process all queued invoke later callbacks.|
|[RemoveEntity(MyEntity, bool)](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@RemoveEntity)||
|[Unload()](Sandbox.Game.Entities.MyParallelEntityUpdateOrchestrator@Unload)||
|[AddEntity(MyEntity)](Sandbox.Game.Entities.IMyUpdateOrchestrator@AddEntity)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[ClearStats()](Sandbox.Game.Entities.IMyUpdateOrchestrator@ClearStats)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[DebugDraw()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DebugDraw)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[DispatchAfterSimulation()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DispatchAfterSimulation)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[DispatchBeforeSimulation()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DispatchBeforeSimulation)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[DispatchOnceBeforeFrame()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DispatchOnceBeforeFrame)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[DispatchSimulate()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DispatchSimulate)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[DispatchUpdatingStopped()](Sandbox.Game.Entities.IMyUpdateOrchestrator@DispatchUpdatingStopped)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[EntityFlagsChanged(MyEntity)](Sandbox.Game.Entities.IMyUpdateOrchestrator@EntityFlagsChanged)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[GetStats()](Sandbox.Game.Entities.IMyUpdateOrchestrator@GetStats)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[InvokeLater(Action, string)](Sandbox.Game.Entities.IMyUpdateOrchestrator@InvokeLater)|Schedule a callback to be invoked in the update thread at a later time.<br /><br />_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[RemoveEntity(MyEntity, bool)](Sandbox.Game.Entities.IMyUpdateOrchestrator@RemoveEntity)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|
|[Unload()](Sandbox.Game.Entities.IMyUpdateOrchestrator@Unload)|_Inherited from [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)_|

**Implements:**  
* [IMyUpdateOrchestrator](Sandbox.Game.Entities.IMyUpdateOrchestrator)

