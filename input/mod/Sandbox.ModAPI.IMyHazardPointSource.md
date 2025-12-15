**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyHazardPointSource: IMyHazardSource
```

A source of environmental hazard which has specific position

## Properties

|Member|Description|
|---|---|
|[DamageType](Sandbox.ModAPI.IMyHazardSource@DamageType)|If the hazard affects Health stat, [MyDamageType](VRage.Game.MyDamageType) is used to differentiate kinds of damage<br /><br />_Inherited from [IMyHazardSource](Sandbox.ModAPI.IMyHazardSource)_|
|[IgnoresSheltering](Sandbox.ModAPI.IMyHazardSource@IgnoresSheltering)|Indicates whether the source penetrates [IMyHazardReceiver](Sandbox.ModAPI.IMyHazardReceiver) sheltering logic. When true, CanBeAffected result is ignored.<br /><br />_Inherited from [IMyHazardSource](Sandbox.ModAPI.IMyHazardSource)_|
|[IsExposureScalingNeeded](Sandbox.ModAPI.IMyHazardSource@IsExposureScalingNeeded)|Indicates whether the value provided by GetCurrentExposure needs adjustment based on call interval. If the stat is meant to be affected in bursts (e.g. Health damage) and the source is responsible for correct average magnitude, this should return false<br /><br />_Inherited from [IMyHazardSource](Sandbox.ModAPI.IMyHazardSource)_|
|[StatId](Sandbox.ModAPI.IMyHazardSource@StatId)|ID of the affected entity stat<br /><br />_Inherited from [IMyHazardSource](Sandbox.ModAPI.IMyHazardSource)_|

## Methods

|Member|Description|
|---|---|
|[GetPosition()](Sandbox.ModAPI.IMyHazardPointSource@GetPosition)|Provides the position of the point source|
|[GetCurrentExposure(IMyHazardReceiver)](Sandbox.ModAPI.IMyHazardSource@GetCurrentExposure)|Provides momentary hazard exposure which would be scaled according to the update rate<br /><br />_Inherited from [IMyHazardSource](Sandbox.ModAPI.IMyHazardSource)_|

**Implements:**  
* [IMyHazardSource](Sandbox.ModAPI.IMyHazardSource)

