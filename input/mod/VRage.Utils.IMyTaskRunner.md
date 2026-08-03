**Assembly:** VRage.Library.dll

```csharp
public interface IMyTaskRunner
```

Provides Task.Run()-equivalent scheduling through a custom task scheduler.

## Methods

|Member|Description|
|---|---|
|[GetScheduler()](VRage.Utils.IMyTaskRunner@GetScheduler)|Returns the underlying TaskScheduler, for use with ContinueWith and similar APIs.|
|[Run(Action)](VRage.Utils.IMyTaskRunner@Run)|Schedules an action for execution and returns a Task representing it.|
|[Run<T>(Func<T>)](VRage.Utils.IMyTaskRunner@Run{T})||
|[Run(Func<Task>)](VRage.Utils.IMyTaskRunner@Run)|Schedules an async action for execution and returns a Task representing the full async operation.|
|[Run<T>(Func<Task`1>)](VRage.Utils.IMyTaskRunner@Run{T})||

**Inheritors:**  
* [MyDefaultTaskRunner](VRage.Utils.MyDefaultTaskRunner)

