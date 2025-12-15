**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyHazardSource
```

Describes the ambient hazard source that affects entity stats

## Properties

|Member|Description|
|---|---|
|[DamageType](Sandbox.ModAPI.IMyHazardSource@DamageType)|If the hazard affects Health stat, [MyDamageType](VRage.Game.MyDamageType) is used to differentiate kinds of damage|
|[IgnoresSheltering](Sandbox.ModAPI.IMyHazardSource@IgnoresSheltering)|Indicates whether the source penetrates [IMyHazardReceiver](Sandbox.ModAPI.IMyHazardReceiver) sheltering logic. When true, CanBeAffected result is ignored.|
|[IsExposureScalingNeeded](Sandbox.ModAPI.IMyHazardSource@IsExposureScalingNeeded)|Indicates whether the value provided by GetCurrentExposure needs adjustment based on call interval. If the stat is meant to be affected in bursts (e.g. Health damage) and the source is responsible for correct average magnitude, this should return false|
|[StatId](Sandbox.ModAPI.IMyHazardSource@StatId)|ID of the affected entity stat|

## Methods

|Member|Description|
|---|---|
|[GetCurrentExposure(IMyHazardReceiver)](Sandbox.ModAPI.IMyHazardSource@GetCurrentExposure)|Provides momentary hazard exposure which would be scaled according to the update rate|

**Inheritors:**  
* [IMyHazardPointSource](Sandbox.ModAPI.IMyHazardPointSource)

