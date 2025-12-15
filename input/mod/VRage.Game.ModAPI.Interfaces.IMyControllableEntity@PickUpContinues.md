## Summary

```csharp
public void PickUpContinues()
```

Forwarding this action to [Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use) with argument [PickUp](VRage.Game.Entity.UseObject.UseActionEnum@PickUp) 

## Remarks

Works only for [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) . Method is called after first call of [PickUp()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PickUp) , and only if target supports [ContinuousUsage](VRage.Game.Entity.UseObject.IMyUseObject@ContinuousUsage) 

