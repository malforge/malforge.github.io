**Assembly:** VRage.Library.dll

```csharp
public struct Task
```

A struct which represents a single execution of an IWork instance.

## Fields

|Member|Description|
|---|---|
|[valid](ParallelTasks.Task@valid)||

## Properties

|Member|Description|
|---|---|
|[Exceptions](ParallelTasks.Task@Exceptions)|Gets an array containing any exceptions thrown by this task.|
|[IsComplete](ParallelTasks.Task@IsComplete)|Gets a value which indicates if this task has completed.|
|[Item](ParallelTasks.Task@Item)||

## Methods

|Member|Description|
|---|---|
|[Execute()](ParallelTasks.Task@Execute)||
|[Wait(bool)](ParallelTasks.Task@Wait)||
|[WaitOrExecute(bool)](ParallelTasks.Task@WaitOrExecute)|Waits for the task to complete.|

