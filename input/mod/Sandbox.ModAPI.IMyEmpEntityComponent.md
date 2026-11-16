**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyEmpEntityComponent: IMyEmpEntityComponent
```

Describes an EMP entity component.

## Properties

|Member|Description|
|---|---|
|[Countdown](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent@Countdown)|Gets or sets the countdown, in seconds, remaining before the device discharges itself. The value is clamped to the range supported by the terminal slider. Setting it while the countdown is running restarts the remaining time from the new value.<br /><br />_Inherited from [IMyEmpEntityComponent](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent)_|
|[IsCountingDown](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent@IsCountingDown)|Gets whether the countdown is currently running.<br /><br />_Inherited from [IMyEmpEntityComponent](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent)_|

## Methods

|Member|Description|
|---|---|
|[Discharge()](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent@Discharge)|Releases the EMP field immediately, without waiting for the countdown.<br /><br />_Inherited from [IMyEmpEntityComponent](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent)_|
|[StartCountdown()](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent@StartCountdown)|Starts the countdown. Does nothing when the countdown is already running or when the block is not working. A countdown of zero discharges the device on the next update.<br /><br />_Inherited from [IMyEmpEntityComponent](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent)_|
|[StopCountdown()](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent@StopCountdown)|Stops a running countdown, keeping the remaining time so that a later [StartCountdown()](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent@StartCountdown) resumes from it. Does nothing when no countdown is running.<br /><br />_Inherited from [IMyEmpEntityComponent](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent)_|

**Implements:**  
* [IMyEmpEntityComponent](Sandbox.ModAPI.Ingame.IMyEmpEntityComponent)

