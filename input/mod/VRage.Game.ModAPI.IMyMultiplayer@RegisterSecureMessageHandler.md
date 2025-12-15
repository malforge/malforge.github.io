## Summary

```csharp
public void RegisterSecureMessageHandler(ushort id, Action<ushort, Byte[], ulong, bool> messageHandler)
```

Allows you do reliable checks WHO have sent message to you. Action - HandlerId, Package, Player SteamID or 0 for Dedicated server, Sent message comes from server

## Parameters

* [ushort](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16?view=netframework-4.6) id
* [Action<ushort, Byte[], ulong, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-4?view=netframework-4.6) messageHandler
