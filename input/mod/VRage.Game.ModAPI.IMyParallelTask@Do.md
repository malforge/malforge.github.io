## Summary

```csharp
public void Do(IWork a, IWork b)
```

Executes the given work items potentially in parallel with each other. This method will block until all work is completed.

## Parameters

* [IWork](ParallelTasks.IWork) a
* [IWork](ParallelTasks.IWork) b
## Summary

```csharp
public void Do(IWork[] work)
```

Executes the given work items potentially in parallel with each other. This method will block until all work is completed.

## Parameters

* IWork[] <sub>prohibited</sub> work
## Summary

```csharp
public void Do(Action action1, Action action2)
```

Executes the given work items potentially in parallel with each other. This method will block until all work is completed.

## Parameters

* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) action1
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action?view=netframework-4.6) action2
## Summary

```csharp
public void Do(Action[] actions)
```

Executes the given work items potentially in parallel with each other. This method will block until all work is completed.

## Parameters

* Action[] <sub>prohibited</sub> actions
