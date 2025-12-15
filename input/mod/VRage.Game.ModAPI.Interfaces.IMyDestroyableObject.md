**Assembly:** VRage.Game.dll

```csharp
public interface IMyDestroyableObject
```

## Properties

|Member|Description|
|---|---|
|[Integrity](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@Integrity)|Gets the integrity (health) of the object|
|[UseDamageSystem](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@UseDamageSystem)|When set to true, it should use MyDamageSystem damage routing.|

## Methods

|Member|Description|
|---|---|
|[DoDamage(float, MyStringHash, bool, MyHitInfo?, long, long, bool, MyStringHash?)](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@DoDamage)|Applies damage to an object|
|[OnDestroy()](VRage.Game.ModAPI.Interfaces.IMyDestroyableObject@OnDestroy)||

**Inheritors:**  
* [IMyCharacter](VRage.Game.ModAPI.IMyCharacter)  
* [IMyFloatingObject](VRage.Game.ModAPI.IMyFloatingObject)  
* [IMyMeteor](Sandbox.ModAPI.IMyMeteor)  
* [IMyMissile](Sandbox.ModAPI.IMyMissile)  
* [IMySlimBlock](VRage.Game.ModAPI.IMySlimBlock)  
* [IMyWarhead](Sandbox.ModAPI.IMyWarhead)  
* [MyCargoContainerInventoryBagEntity](Sandbox.Game.Entities.MyCargoContainerInventoryBagEntity)  
* [MyFloatingObject](Sandbox.Game.Entities.MyFloatingObject)  
* [MyMeteor](Sandbox.Game.Entities.MyMeteor)

