## Summary

```csharp
public void GetAllIdentites(List<IMyIdentity> identities, Func<IMyIdentity, bool> collect)
```

Get all registered identities: players that at least once visited server, bots, and online players

## Parameters

* [List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[IMyIdentity](VRage.Game.ModAPI.IMyIdentity)&gt; identities
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;[IMyIdentity](VRage.Game.ModAPI.IMyIdentity), [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt; collect
