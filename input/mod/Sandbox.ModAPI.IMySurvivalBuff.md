**Assembly:** Sandbox.Common.dll

```csharp
public interface IMySurvivalBuff
```

Describes single survival buff

## Properties

|Member|Description|
|---|---|
|[Level](Sandbox.ModAPI.IMySurvivalBuff@Level)|Curent buff level|
|[MaxLevel](Sandbox.ModAPI.IMySurvivalBuff@MaxLevel)|Max buff level|
|[NameId](Sandbox.ModAPI.IMySurvivalBuff@NameId)|Buff name id|
|[NotificationText](Sandbox.ModAPI.IMySurvivalBuff@NotificationText)|Buff progress notification text id|
|[NotificationTitle](Sandbox.ModAPI.IMySurvivalBuff@NotificationTitle)|Buff progress notification title id|
|[ProgressionTime](Sandbox.ModAPI.IMySurvivalBuff@ProgressionTime)|Time to progress to next buff level in seconds|

## Methods

|Member|Description|
|---|---|
|[DoProgressStep()](Sandbox.ModAPI.IMySurvivalBuff@DoProgressStep)|Checks whether the buff should progress to next level|
|[GetCurrentBuffValue()](Sandbox.ModAPI.IMySurvivalBuff@GetCurrentBuffValue)|Gets current value of buff|
|[GetCurrentBuffValueString()](Sandbox.ModAPI.IMySurvivalBuff@GetCurrentBuffValueString)|Gets current value of buff in a readable form with unit representation. Example: 120%|
|[Reset()](Sandbox.ModAPI.IMySurvivalBuff@Reset)|Resets buff progress|

