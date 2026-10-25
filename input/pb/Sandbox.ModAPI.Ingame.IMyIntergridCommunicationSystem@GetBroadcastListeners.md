## Summary

```csharp
public void GetBroadcastListeners(List<IMyBroadcastListener> broadcastListeners, Func<IMyBroadcastListener, bool> collect)
```

Retrieves list of all active broadcast listeners and listeners with pending messages, registered by current programmable block. Returned list is snapshot of current state and is not updated by future operations.

## Parameters

* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[IMyBroadcastListener](Sandbox.ModAPI.Ingame.IMyBroadcastListener)&gt; broadcastListeners
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;[IMyBroadcastListener](Sandbox.ModAPI.Ingame.IMyBroadcastListener), [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt; collect
