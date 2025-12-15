## Summary

```csharp
public Task Start(Action action, WorkOptions options, Action completionCallback)
```

Creates and starts a task to execute the given work.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the work.

## Parameters

* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) action
* [WorkOptions](ParallelTasks.WorkOptions) options
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) completionCallback
## Summary

```csharp
public Task Start(Action action, WorkOptions options)
```

Creates and starts a task to execute the given work.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the work.

## Parameters

* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) action
* [WorkOptions](ParallelTasks.WorkOptions) options
## Summary

```csharp
public Task Start(Action action, Action completionCallback)
```

Creates and starts a task to execute the given work.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the work.

## Parameters

* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) action
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) completionCallback
## Summary

```csharp
public Task Start(Action action)
```

Creates and starts a task to execute the given work.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the work.

## Parameters

* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) action
## Summary

```csharp
public Task Start(Action<WorkData> action, Action<WorkData> completionCallback, WorkData workData)
```

Creates and schedules a task to execute the given work with the given work data.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the action.

## Parameters

* [Action<WorkData>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) action
* [Action<WorkData>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) completionCallback
* [WorkData](ParallelTasks.WorkData) workData
## Summary

```csharp
public Task Start(IWork work, Action completionCallback)
```

Creates and starts a task to execute the given work.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the work.

## Parameters

* [IWork](ParallelTasks.IWork) work
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) completionCallback
## Summary

```csharp
public Task Start(IWork work)
```

Creates and starts a task to execute the given work.

## Returns

[Task](ParallelTasks.Task)

A task which represents one execution of the work.

## Parameters

* [IWork](ParallelTasks.IWork) work
