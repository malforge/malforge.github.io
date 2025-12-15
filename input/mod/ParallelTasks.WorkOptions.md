**Assembly:** VRage.Library.dll

```csharp
public struct WorkOptions
```

A struct containing options about how an IWork instance can be executed.

## Properties

|Member|Description|
|---|---|
|[DebugName](ParallelTasks.WorkOptions@DebugName)||
|[MaximumThreads](ParallelTasks.WorkOptions@MaximumThreads)|Gets or sets the maximum number of threads which can concurrently execute this work.|
|[QueueFIFO](ParallelTasks.WorkOptions@QueueFIFO)|Gets or sets a value indicating that this work should be queued in a first in first out fashion.|
|[TaskType](ParallelTasks.WorkOptions@TaskType)||

## Methods

|Member|Description|
|---|---|
|[ToString()](ParallelTasks.WorkOptions@ToString)||
|[WithDebugInfo(TaskType, string)](ParallelTasks.WorkOptions@WithDebugInfo)||
|[WithMaxThreads(int)](ParallelTasks.WorkOptions@WithMaxThreads)||

