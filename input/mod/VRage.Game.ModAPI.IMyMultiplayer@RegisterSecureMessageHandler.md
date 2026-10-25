## Summary

```csharp
public void RegisterSecureMessageHandler(ushort id, Action<ushort, Byte[], ulong, bool> messageHandler)
```

Allows you do reliable checks WHO have sent message to you. Action - HandlerId, Package, Player SteamID or 0 for Dedicated server, Sent message comes from server

## Parameters

* [ushort](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16?view=netframework-4.6) id
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-4?view=netframework-4.6)&lt;[ushort](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16?view=netframework-4.6), [byte[]](https://docs.microsoft.com/en-us/dotnet/api/System.Byte?view=netframework-4.6), [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6), [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt; messageHandler
