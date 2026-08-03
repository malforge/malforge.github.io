**Assembly:** VRage.Library.dll

```csharp
public class MyDefaultTaskRunner: IMyTaskRunner
```

An IMyTaskRunner implementation that delegates directly to Task.Run().

## Properties

|Member|Description|
|---|---|
|[static Instance](VRage.Utils.MyDefaultTaskRunner@Instance)||

## Constructors

|Member|Description|
|---|---|
|[MyDefaultTaskRunner()](VRage.Utils.MyDefaultTaskRunner@.ctor)||

## Methods

|Member|Description|
|---|---|
|[GetScheduler()](VRage.Utils.MyDefaultTaskRunner@GetScheduler)||
|[Run(Action)](VRage.Utils.MyDefaultTaskRunner@Run)||
|[Run<T>(Func<T>)](VRage.Utils.MyDefaultTaskRunner@Run{T})||
|[Run(Func<Task>)](VRage.Utils.MyDefaultTaskRunner@Run)||
|[Run<T>(Func<Task`1>)](VRage.Utils.MyDefaultTaskRunner@Run{T})||
|[GetScheduler()](VRage.Utils.IMyTaskRunner@GetScheduler)|Returns the underlying TaskScheduler, for use with ContinueWith and similar APIs.<br /><br />_Inherited from [IMyTaskRunner](VRage.Utils.IMyTaskRunner)_|
|[Run(Action)](VRage.Utils.IMyTaskRunner@Run)|Schedules an action for execution and returns a Task representing it.<br /><br />_Inherited from [IMyTaskRunner](VRage.Utils.IMyTaskRunner)_|
|[Run<T>(Func<T>)](VRage.Utils.IMyTaskRunner@Run{T})|_Inherited from [IMyTaskRunner](VRage.Utils.IMyTaskRunner)_|
|[Run(Func<Task>)](VRage.Utils.IMyTaskRunner@Run)|Schedules an async action for execution and returns a Task representing the full async operation.<br /><br />_Inherited from [IMyTaskRunner](VRage.Utils.IMyTaskRunner)_|
|[Run<T>(Func<Task`1>)](VRage.Utils.IMyTaskRunner@Run{T})|_Inherited from [IMyTaskRunner](VRage.Utils.IMyTaskRunner)_|

**Implements:**  
* [IMyTaskRunner](VRage.Utils.IMyTaskRunner)

