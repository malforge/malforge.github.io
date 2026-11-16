## Summary

```csharp
public void PullAmmo(MyGridConveyorSystem conveyorSystem, IMyConveyorEndpointBlock puller, MyInventory inventory, MyFixedPoint amount)
```

Pulls [AmmoMagazineIdToPull](Sandbox.Game.Weapons.MyGunBase@AmmoMagazineIdToPull) over the conveyor system. An empty weapon set to any ammo type falls back to the first magazine type, in definition order, that the conveyor system can supply.

## Parameters

* MyGridConveyorSystem <sub>prohibited</sub> conveyorSystem
* IMyConveyorEndpointBlock <sub>prohibited</sub> puller
* [MyInventory](Sandbox.Game.MyInventory) inventory
* [MyFixedPoint](VRage.MyFixedPoint) amount
