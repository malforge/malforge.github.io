## Summary

```csharp
public void ExtendControl(IMyControllableEntity entityWithControl, IMyEntity entityGettingControl)
```

Control extension and reduction is a mechanism that saves the control of other entities than IMyControllableEntities. A typical example is a cockpit inside a cube grid - you control the cockpit, but you want to "extend" the control to the cube grid as well. You can extend the control multiple times, but you always have to extend from the "base" entity, i.e. the cockpit in our example. The same goes for control reduction: always reduce to the "base" entity

## Parameters

* [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity) entityWithControl
* [IMyEntity](VRage.ModAPI.IMyEntity) entityGettingControl
## Remarks

Same as [TryExtendControl(IMyControllableEntity, IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@TryExtendControl) 

