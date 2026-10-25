## Summary

```csharp
public ListReader<IMyDLC> GetDLCs()
```

Get a list of all DLCs the game has. This will not change for the lifetime of the session and is safe to cache.

## Returns

[ListReader](VRage.Collections.ListReader{T})&lt;[IMyDLC](VRage.Game.ModAPI.IMyDLC)&gt;

