## Summary

```csharp
public static bool ReinsertBodiesBatched(List<MyPhysicsBody> bodies)
```

Re-inserts moved bodies (physics already disabled by the caller) via the batch path, so every body re-enters the world before any of its constraints — a per-body re-enable would reject a constraint whose partner body is not back yet. Caller sets velocities and excludes welded bodies. Returns false if activation aborted (StopPhysicsActivation), leaving the move incomplete.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [List<MyPhysicsBody>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) bodies
