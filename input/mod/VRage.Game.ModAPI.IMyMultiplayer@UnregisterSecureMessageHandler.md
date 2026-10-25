## Summary

```csharp
public void UnregisterSecureMessageHandler(ushort id, Action<ushort, Byte[], ulong, bool> messageHandler)
```

Unsubscribes from incoming messages

## Parameters

* [ushort](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16?view=netframework-4.6) id
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-4?view=netframework-4.6)&lt;[ushort](https://docs.microsoft.com/en-us/dotnet/api/System.UInt16?view=netframework-4.6), [byte[]](https://docs.microsoft.com/en-us/dotnet/api/System.Byte?view=netframework-4.6), [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6), [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt; messageHandler
