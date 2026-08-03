**Assembly:** VRage.Game.dll

```csharp
public abstract sealed class MyEntityLifetimeTracker
```

Diagnostic counter of entity lifetimes used to spot leaks: entities that are closed but never reclaimed by the GC because something still references them. Lives in the same assembly as [MyEntity](VRage.Game.Entity.MyEntity) so the constructor hook is a cheap field read. Disabled by default; gate is checked first so there is no cost when off. All public mutators are safe to call from any thread (entities are created in parallel); [Scan()](VRage.Game.Entity.MyEntityLifetimeTracker@Scan) must run on the update thread only.

## Fields

|Member|Description|
|---|---|
|[static Enabled](VRage.Game.Entity.MyEntityLifetimeTracker@Enabled)||

## Properties

|Member|Description|
|---|---|
|[static Collected](VRage.Game.Entity.MyEntityLifetimeTracker@Collected)||
|[static Created](VRage.Game.Entity.MyEntityLifetimeTracker@Created)||
|[static Live](VRage.Game.Entity.MyEntityLifetimeTracker@Live)||
|[static MarkedForClose](VRage.Game.Entity.MyEntityLifetimeTracker@MarkedForClose)||

## Methods

|Member|Description|
|---|---|
|[static GetSuspectedLeaks(Dictionary<string, int>)](VRage.Game.Entity.MyEntityLifetimeTracker@GetSuspectedLeaks)|Copies the current suspected-leak buckets into the supplied dictionary (cleared first). Safe to call from any thread.|
|[static OnCreated(MyEntity)](VRage.Game.Entity.MyEntityLifetimeTracker@OnCreated)||
|[static Reset()](VRage.Game.Entity.MyEntityLifetimeTracker@Reset)||
|[static Scan()](VRage.Game.Entity.MyEntityLifetimeTracker@Scan)|Update-thread only. Prunes collected entities, counts them, and rebuilds the suspected-leak report.|

