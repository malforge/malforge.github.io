**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyHazardReceiver
```

Describes a subject of hazard exposure

## Methods

|Member|Description|
|---|---|
|[Apply(float, MyStringHash, MyStringHash)](Sandbox.ModAPI.IMyHazardReceiver@Apply)|Affects corresponding entity stat. Does not check admin protection. For Radiation, checks immunity stat. Positive value increases stat (except Health, which is reduced by positive damage value).|
|[CanBeAffected()](Sandbox.ModAPI.IMyHazardReceiver@CanBeAffected)|Is it sheltered from the exposure?|
|[GetEntity()](Sandbox.ModAPI.IMyHazardReceiver@GetEntity)|Gets the associated entity|
|[GetPosition()](Sandbox.ModAPI.IMyHazardReceiver@GetPosition)|Gets world position|

**Inheritors:**  
* [MyCharacterStatComponent](Sandbox.Game.Components.MyCharacterStatComponent)

