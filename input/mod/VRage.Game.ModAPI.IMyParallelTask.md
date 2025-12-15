**Assembly:** VRage.Game.dll

```csharp
public interface IMyParallelTask
```

Mod API interface allowing you to run async tasks

## Properties

|Member|Description|
|---|---|
|[DefaultOptions](VRage.Game.ModAPI.IMyParallelTask@DefaultOptions)|Default WorkOptions. DetachFromParent = false, MaximumThreads = 1|

## Methods

|Member|Description|
|---|---|
|[Do(IWork, IWork)](VRage.Game.ModAPI.IMyParallelTask@Do)|Executes the given work items potentially in parallel with each other. This method will block until all work is completed.|
|[Do(IWork[])](VRage.Game.ModAPI.IMyParallelTask@Do)|Executes the given work items potentially in parallel with each other. This method will block until all work is completed.|
|[Do(Action, Action)](VRage.Game.ModAPI.IMyParallelTask@Do)|Executes the given work items potentially in parallel with each other. This method will block until all work is completed.|
|[Do(Action[])](VRage.Game.ModAPI.IMyParallelTask@Do)|Executes the given work items potentially in parallel with each other. This method will block until all work is completed.|
|[For(int, int, Action<int>)](VRage.Game.ModAPI.IMyParallelTask@For)|Executes a for loop, where each iteration can potentially occur in parallel with others.|
|[For(int, int, Action<int>, int)](VRage.Game.ModAPI.IMyParallelTask@For)|Executes a for loop, where each iteration can potentially occur in parallel with others.|
|[ForEach<T>(IEnumerable<T>, Action<T>)](VRage.Game.ModAPI.IMyParallelTask@ForEach{T})||
|[Sleep(int)](VRage.Game.ModAPI.IMyParallelTask@Sleep)|Suspends the current thread for the specified number of milliseconds.|
|[Sleep(TimeSpan)](VRage.Game.ModAPI.IMyParallelTask@Sleep)|Suspends the current thread for the specified amount of time.|
|[Start(Action, WorkOptions, Action)](VRage.Game.ModAPI.IMyParallelTask@Start)|Creates and starts a task to execute the given work.|
|[Start(Action, WorkOptions)](VRage.Game.ModAPI.IMyParallelTask@Start)|Creates and starts a task to execute the given work.|
|[Start(Action, Action)](VRage.Game.ModAPI.IMyParallelTask@Start)|Creates and starts a task to execute the given work.|
|[Start(Action)](VRage.Game.ModAPI.IMyParallelTask@Start)|Creates and starts a task to execute the given work.|
|[Start(Action<WorkData>, Action<WorkData>, WorkData)](VRage.Game.ModAPI.IMyParallelTask@Start)|Creates and schedules a task to execute the given work with the given work data.|
|[Start(IWork, Action)](VRage.Game.ModAPI.IMyParallelTask@Start)|Creates and starts a task to execute the given work.|
|[Start(IWork)](VRage.Game.ModAPI.IMyParallelTask@Start)|Creates and starts a task to execute the given work.|
|[StartBackground(IWork, Action)](VRage.Game.ModAPI.IMyParallelTask@StartBackground)|Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.|
|[StartBackground(IWork)](VRage.Game.ModAPI.IMyParallelTask@StartBackground)|Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.|
|[StartBackground(Action)](VRage.Game.ModAPI.IMyParallelTask@StartBackground)|Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.|
|[StartBackground(Action, Action)](VRage.Game.ModAPI.IMyParallelTask@StartBackground)|Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.|
|[StartBackground(Action<WorkData>, Action<WorkData>, WorkData)](VRage.Game.ModAPI.IMyParallelTask@StartBackground)|Starts a task in a secondary worker thread. Intended for long running, blocking work such as I/O.|

