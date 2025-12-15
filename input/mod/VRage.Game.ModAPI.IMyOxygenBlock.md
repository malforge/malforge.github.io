**Assembly:** VRage.Game.dll

```csharp
public interface IMyOxygenBlock
```

ModAPI describing block that can work with gas in airtight rooms (AirVent)

## Properties

|Member|Description|
|---|---|
|[OxygenChangeTime](VRage.Game.ModAPI.IMyOxygenBlock@OxygenChangeTime)|Get time in milliseconds when last oxygen level was changed.|
|[PreviousOxygenAmount](VRage.Game.ModAPI.IMyOxygenBlock@PreviousOxygenAmount)|Gets previous oxygen level. Oxygen level is updated each 100 frames.|
|[Room](VRage.Game.ModAPI.IMyOxygenBlock@Room)|Gets oxygen room to which this block belongs to.|

## Methods

|Member|Description|
|---|---|
|[OxygenLevel(float)](VRage.Game.ModAPI.IMyOxygenBlock@OxygenLevel)|Gets oxygen level in current oxygen room|

