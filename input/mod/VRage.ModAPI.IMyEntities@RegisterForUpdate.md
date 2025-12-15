## Summary

```csharp
public void RegisterForUpdate(IMyEntity entity)
```

Make entity receive UpdateBeforeSimulation, UpdateBefore10Simulation, UpdateBefore100Simulation, UpdateAfterSimulation, UpdateAfter10Simulation, UpdateAfter100Simulation, Simulate, UpdateBeforeNextFrame depending on it's [NeedsUpdate](VRage.ModAPI.IMyEntity@NeedsUpdate) flags. Physics are still simulated

## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) entity
