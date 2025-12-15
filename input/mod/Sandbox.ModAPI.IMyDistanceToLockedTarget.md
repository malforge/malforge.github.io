**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyDistanceToLockedTarget
```

Describes distance to locked target interface for block, which is able to target lock

## Events

|Member|Description|
|---|---|
|[DistanceToLockedTargetChanged](Sandbox.ModAPI.IMyDistanceToLockedTarget@DistanceToLockedTargetChanged)|Event distance to locked target is changed (block, old value, new value)|

## Properties

|Member|Description|
|---|---|
|[DistanceToLockedTarget](Sandbox.ModAPI.IMyDistanceToLockedTarget@DistanceToLockedTarget)|Gets distance to locked target in meters|
|[Entity](Sandbox.ModAPI.IMyDistanceToLockedTarget@Entity)|Gets the entity of this interface entity component|

**Inheritors:**  
* [MyTargetLockingBlockComponent](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent)  
* [MyTargetLockingComponent](Sandbox.Game.EntityComponents.MyTargetLockingComponent)

