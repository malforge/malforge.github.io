**Assembly:** VRage.Game.dll

```csharp
public interface IMyGridControlSystem
```

ModAPI interface giving access to grid-group control system

## Events

|Member|Description|
|---|---|
|[IsControlledChanged](VRage.Game.ModAPI.IMyGridControlSystem@IsControlledChanged)|Called when [IsControlled](VRage.Game.ModAPI.IMyGridControlSystem@IsControlled) changed. Invoked with grid main grid that|

## Properties

|Member|Description|
|---|---|
|[CurrentShipController](VRage.Game.ModAPI.IMyGridControlSystem@CurrentShipController)|Gets the controllable entity of the ship controller currently controlling the grid. Can cast its Entity property to IMyShipController|
|[IsControlled](VRage.Game.ModAPI.IMyGridControlSystem@IsControlled)|Gets whether grid-group is controlled|

