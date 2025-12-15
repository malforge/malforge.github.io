**Assembly:** VRage.Game.dll

```csharp
public abstract sealed class MyGameLogic
```

This is mostly a copy of the updating system present in MyEntities. The old style of GameLogic component was tied to entity updates. This meant that when the entity removed one of its update flags, the component would stop updating with no warning. Here we update GameLogic components separately from the containing entity.

## Methods

|Member|Description|
|---|---|
|[static ChangeUpdate(MyGameLogicComponent, MyEntityUpdateEnum, bool)](VRage.Game.Entity.MyGameLogic@ChangeUpdate)|Modifies a component's update flags without modifying lists the component is already in. Much more performant than Unregister/Register pattern!|
|[static RegisterForUpdate(MyGameLogicComponent)](VRage.Game.Entity.MyGameLogic@RegisterForUpdate)|Registers a component to the update system. Only use for first-time registration! If changing update flags, use ChangeUpdate!|
|[static UnloadData()](VRage.Game.Entity.MyGameLogic@UnloadData)||
|[static UnregisterForUpdate(MyGameLogicComponent)](VRage.Game.Entity.MyGameLogic@UnregisterForUpdate)|Unregisters a component from the update system. Only use when disposing a component! If changing update flags, use ChangeUpdate!|
|[static UpdateAfterSimulation()](VRage.Game.Entity.MyGameLogic@UpdateAfterSimulation)||
|[static UpdateBeforeSimulation()](VRage.Game.Entity.MyGameLogic@UpdateBeforeSimulation)||
|[static UpdateOnceBeforeFrame()](VRage.Game.Entity.MyGameLogic@UpdateOnceBeforeFrame)||
|[static UpdatingStopped()](VRage.Game.Entity.MyGameLogic@UpdatingStopped)||

