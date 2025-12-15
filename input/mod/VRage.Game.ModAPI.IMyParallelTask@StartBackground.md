## Summary

```csharp
public Task StartBackground(IWork work, Action completionCallback)
```

Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the work.

## Parameters

* [IWork](ParallelTasks.IWork) work
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) completionCallback
## Summary

```csharp
public Task StartBackground(IWork work)
```

Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the work.

## Parameters

* [IWork](ParallelTasks.IWork) work
## Summary

```csharp
public Task StartBackground(Action action)
```

Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the action.

## Parameters

* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) action
## Summary

```csharp
public Task StartBackground(Action action, Action completionCallback)
```

Starts a task in a secondary worker thread. Intended for long running, blocking, work such as I/O.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the action.

## Parameters

* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) action
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) completionCallback
## Summary

```csharp
public Task StartBackground(Action<WorkData> action, Action<WorkData> completionCallback, WorkData workData)
```

Starts a task in a secondary worker thread. Intended for long running, blocking work such as I/O.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the action.

## Parameters

* [Action<WorkData>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) action
* [Action<WorkData>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) completionCallback
* [WorkData](ParallelTasks.WorkData) workData
