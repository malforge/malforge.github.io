**Assembly:** VRage.Game.dll

```csharp
public interface IMyEntityCapacitorComponent
```

Describes a component that can charge like a battery and has the ability to lose stored power.

## Events

|Member|Description|
|---|---|
|[OnCharged](VRage.Game.ModAPI.Interfaces.IMyEntityCapacitorComponent@OnCharged)|Called on server and client when capacitor is fully charged.|

## Properties

|Member|Description|
|---|---|
|[Capacity](VRage.Game.ModAPI.Interfaces.IMyEntityCapacitorComponent@Capacity)|Gets or sets maximum capacity in MWh.|
|[IsCharged](VRage.Game.ModAPI.Interfaces.IMyEntityCapacitorComponent@IsCharged)|Gets whether the capacitor is fully charged.|
|[RechargeDraw](VRage.Game.ModAPI.Interfaces.IMyEntityCapacitorComponent@RechargeDraw)|Gets or sets maximum recharge rate in megawatts. When it is fully charged, it starts using entity default consumption.|
|[StoredPower](VRage.Game.ModAPI.Interfaces.IMyEntityCapacitorComponent@StoredPower)|Gets or sets the currently stored amount of energy. Setter should be called on server.|
|[TimeRemaining](VRage.Game.ModAPI.Interfaces.IMyEntityCapacitorComponent@TimeRemaining)|Gets or sets time in seconds until the block is fully charged. Updated every 100 frames.|

