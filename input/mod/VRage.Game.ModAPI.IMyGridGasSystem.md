**Assembly:** VRage.Game.dll

```csharp
public interface IMyGridGasSystem
```

ModAPI interface giving access to grid-group gas system

## Properties

|Member|Description|
|---|---|
|[ForcePressurize](VRage.Game.ModAPI.IMyGridGasSystem@ForcePressurize)|Specifies if the grid should be able to pressurize without air vents present.|
|[IsProcessingData](VRage.Game.ModAPI.IMyGridGasSystem@IsProcessingData)|Returns true if the grid is currently recalculating airtightness (It's multithreaded)|
|[OnProcessingDataComplete](VRage.Game.ModAPI.IMyGridGasSystem@OnProcessingDataComplete)|Called when ProcessingData becomes false|
|[OnProcessingDataStart](VRage.Game.ModAPI.IMyGridGasSystem@OnProcessingDataStart)|Called when ProcessingData becomes true|

## Methods

|Member|Description|
|---|---|
|[GetOxygenBlock(Vector3D)](VRage.Game.ModAPI.IMyGridGasSystem@GetOxygenBlock)|Returns an oxygen block at the position if there is one|
|[GetOxygenRoomForCubeGridPosition(ref Vector3I)](VRage.Game.ModAPI.IMyGridGasSystem@GetOxygenRoomForCubeGridPosition)|Returns an oxygen room at the position if there is one|
|[GetRooms(List<IMyOxygenRoom>)](VRage.Game.ModAPI.IMyGridGasSystem@GetRooms)|Gets all oxygen rooms on the grid|

