**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyPathRecorderComponent: IMyPathRecorderComponent
```

Interface for modding PathRecorderComponent

## Events

|Member|Description|
|---|---|
|[IsPlayingChanged](Sandbox.ModAPI.IMyPathRecorderComponent@IsPlayingChanged)|Event triggered when IsPlaying changes|
|[IsRecordingChanged](Sandbox.ModAPI.IMyPathRecorderComponent@IsRecordingChanged)|Event triggered when IsRecording changes|

## Properties

|Member|Description|
|---|---|
|[BeaconDisplayText](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@BeaconDisplayText)|Gets Beacon display text<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[BeaconEntityId](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@BeaconEntityId)|Entity of beacon in which the waypoints are in relation to<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[BeaconWorldPosition](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@BeaconWorldPosition)|Gets BeaconWorldPosition<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[IsPlaying](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@IsPlaying)|Gets bool if the PR block is playing<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[IsRecording](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@IsRecording)|Get bool if the PR block is recording<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[MinimalDistance](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@MinimalDistance)|Gets/sets minimal distance between waypoints for automatic recording to record new waypoint<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[RecordInterval](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@RecordInterval)|Gets/sets record interval. Sets how often the block tries to records its position as a waypoint. Operates every 100 frames<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[RepeatPath](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@RepeatPath)|Repeat path toggle<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[ShowPath](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@ShowPath)|Gets/sets if block is showing path on clients screen<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[ShowSelectedPoints](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@ShowSelectedPoints)|Gets/sets if block is showing points, selected by client on his screen<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|

## Methods

|Member|Description|
|---|---|
|[AddWaypoint(IMyAutopilotWaypoint)](Sandbox.ModAPI.IMyPathRecorderComponent@AddWaypoint)|Adds a waypoint unless the waypoint limit is already reached|
|[DeleteAllWaypoints()](Sandbox.ModAPI.IMyPathRecorderComponent@DeleteAllWaypoints)|Deletes all waypoints|
|[GetWaypoints(List<IMyAutopilotWaypoint>)](Sandbox.ModAPI.IMyPathRecorderComponent@GetWaypoints)|Gets list of waypoints in this component|
|[RemoveWaypoint(IMyAutopilotWaypoint)](Sandbox.ModAPI.IMyPathRecorderComponent@RemoveWaypoint)|Removes waypoint|
|[ReverseOrder()](Sandbox.ModAPI.IMyPathRecorderComponent@ReverseOrder)|Reverses order of waypoints|
|[Play()](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@Play)|Starts playing current waypoints<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[Record()](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@Record)|Starts recording<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[RemoveBeacon()](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@RemoveBeacon)|Sets BeaconEntityId = 0<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[StopPlay()](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@StopPlay)|Stops playing current waypoints<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|
|[StopRecord()](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent@StopRecord)|Stops recording<br /><br />_Inherited from [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)_|

**Implements:**  
* [IMyPathRecorderComponent](Sandbox.ModAPI.Ingame.IMyPathRecorderComponent)

**Inheritors:**  
* [MyPathRecorderComponent](Sandbox.Game.EntityComponents.MyPathRecorderComponent)

