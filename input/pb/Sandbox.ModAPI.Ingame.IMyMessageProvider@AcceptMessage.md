## Summary

```csharp
public MyIGCMessage AcceptMessage()
```

Accepts first message from pending message queue for this message provider. Messages are guaranteed to be dequeued and returned by this method in order they arrived.

## Returns

[MyIGCMessage](Sandbox.ModAPI.Ingame.MyIGCMessage)

First message from pending message queue, default( [MyIGCMessage](Sandbox.ModAPI.Ingame.MyIGCMessage) ) if there are no messages pending to be accepted.

