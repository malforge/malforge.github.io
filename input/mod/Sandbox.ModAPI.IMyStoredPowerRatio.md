**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyStoredPowerRatio
```

Describes stored power ration interface for block, which are storing power

## Events

|Member|Description|
|---|---|
|[StoredPowerRatioChanged](Sandbox.ModAPI.IMyStoredPowerRatio@StoredPowerRatioChanged)|Event when stored power ratio is changed (block, old value, new value)|

## Properties

|Member|Description|
|---|---|
|[StoredPowerRatio](Sandbox.ModAPI.IMyStoredPowerRatio@StoredPowerRatio)|Gets stored power ration (current / max)|

**Inheritors:**  
* [MyBatteryBlock](Sandbox.Game.Entities.MyBatteryBlock)  
* [MyJumpDrive](Sandbox.Game.Entities.MyJumpDrive)

