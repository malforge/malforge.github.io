## Summary

```csharp
public Action<IMyGridGroupData> event OnReleased
```

You must clean your subscriptions here. Instances of IMyGridGroupData are re-used in ObjectPool. At the time event is called it has no grids attached to it.

## Returns

[Action<IMyGridGroupData>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6)

