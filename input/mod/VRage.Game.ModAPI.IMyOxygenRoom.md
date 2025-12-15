**Assembly:** VRage.Game.dll

```csharp
public interface IMyOxygenRoom
```

Represents space containing air vent. May be not airtight

## Properties

|Member|Description|
|---|---|
|[BlockCount](VRage.Game.ModAPI.IMyOxygenRoom@BlockCount)|Gets blocks in room. Can be used to calculate max oxygen available for this room: BlockCount * gridSize * gridSize * gridSize|
|[Blocks](VRage.Game.ModAPI.IMyOxygenRoom@Blocks)|HashSet of all the airtight positions in the room (Reference, not a copy!)|
|[EnvironmentOxygen](VRage.Game.ModAPI.IMyOxygenRoom@EnvironmentOxygen)|Gets current oxygen level|
|[IsAirtight](VRage.Game.ModAPI.IMyOxygenRoom@IsAirtight)|Gets if room is airtight|
|[IsDirty](VRage.Game.ModAPI.IMyOxygenRoom@IsDirty)|Gets if room state is dirty, and would be updated soon.|
|[OxygenAmount](VRage.Game.ModAPI.IMyOxygenRoom@OxygenAmount)|Gets oxygen amount in cubic meters. BlockCount * gridSize * gridSize * gridSize|
|[StartingPosition](VRage.Game.ModAPI.IMyOxygenRoom@StartingPosition)|Gets oxygen room starting position|

## Methods

|Member|Description|
|---|---|
|[MaxOxygen(float)](VRage.Game.ModAPI.IMyOxygenRoom@MaxOxygen)|Gets the maximum volume of oxygen in the room (m^3)|
|[MissingOxygen(float)](VRage.Game.ModAPI.IMyOxygenRoom@MissingOxygen)|Returns the volume of oxygen that is not in the room (m^3)|
|[OxygenLevel(float)](VRage.Game.ModAPI.IMyOxygenRoom@OxygenLevel)|Returns the percentage of oxygen in the room compared to the maximum possible oxygen|

