## Summary

```csharp
public MyCubeGrid LockedTargetGrid { get; }
```

Grid the seeker still holds a lock on, or null once it has gone dumb-fire or committed to something that is not part of a grid (a decoy, a character). Resolves a block target to the (sub)grid the block sits on.

## Returns

[MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid)

