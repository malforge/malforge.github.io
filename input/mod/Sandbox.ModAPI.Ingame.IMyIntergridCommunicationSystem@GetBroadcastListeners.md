## Summary

```csharp
public void GetBroadcastListeners(List<IMyBroadcastListener> broadcastListeners, Func<IMyBroadcastListener, bool> collect)
```

Retrieves list of all active broadcast listeners and listeners with pending messages, registered by current programmable block. Returned list is snapshot of current state and is not updated by future operations.

## Parameters

* [List<IMyBroadcastListener>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) broadcastListeners
* [Func<IMyBroadcastListener, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) collect
