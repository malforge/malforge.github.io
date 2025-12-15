## Summary

```csharp
public bool TryReduceControl(IMyControllableEntity entityWhichKeepsControl, IMyEntity entityWhichLoosesControl)
```

Control extension and reduction is a mechanism that saves the control of other entities than IMyControllableEntities. A typical example is a cockpit inside a cube grid - you control the cockpit, but you want to "extend" the control to the cube grid as well. You can extend the control multiple times, but you always have to extend from the "base" entity, i.e. the cockpit in our example. The same goes for control reduction: always reduce to the "base" entity

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if control was reduced

## Parameters

* [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity) entityWhichKeepsControl
* [IMyEntity](VRage.ModAPI.IMyEntity) entityWhichLoosesControl
## Remarks

Same as [ReduceControl(IMyControllableEntity, IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@ReduceControl) 

