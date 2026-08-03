**Assembly:** Sandbox.Game.dll

```csharp
public abstract sealed class MyServiceRangeHelper
```

Shared helpers for service components (repair/salvage) that operate within a fixed range instead of relying on an NPC station safe zone.

## Fields

|Member|Description|
|---|---|
|[static MAX_SERVICE_RANGE](Sandbox.Game.EntityComponents.MyServiceRangeHelper@MAX_SERVICE_RANGE)||

## Methods

|Member|Description|
|---|---|
|[static ClampRange(float)](Sandbox.Game.EntityComponents.MyServiceRangeHelper@ClampRange)|Clamps a service range to [0, MAX_SERVICE_RANGE], falling back to the max for non-finite input (e.g. a tampered network value).|
|[static GetGridsInRange(Vector3D, float, List<MyCubeGrid>)](Sandbox.Game.EntityComponents.MyServiceRangeHelper@GetGridsInRange)|Collects top-most cube grids whose world AABB intersects a sphere of the given range around the center.|
|[static IsGridInRange(IMyEntity, float, MyCubeGrid)](Sandbox.Game.EntityComponents.MyServiceRangeHelper@IsGridInRange)|Whether any grid in the target's mechanical group has a world AABB within range of the service block. Group-aware to match the enumeration, which lists a group if any of its subgrids is in range.|

