## Summary

```csharp
public IMyBroadcastListener RegisterBroadcastListener(string tag)
```

Registers broadcast listener with given tag for current programmable block. In case there is already another active broadcast lister with given tag new listener is NOT registered and the already active one is returned instead.

## Returns

[IMyBroadcastListener](Sandbox.ModAPI.Ingame.IMyBroadcastListener)

Active broadcast listener for given tag.

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) tag
