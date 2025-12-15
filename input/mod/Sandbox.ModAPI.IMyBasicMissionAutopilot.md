**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyBasicMissionAutopilot: IMyBasicMissionComponent, IMyBasicMissionComponent
```

Describes autopilot mission for the Basic AI block

## Properties

|Member|Description|
|---|---|
|[Mode](Sandbox.ModAPI.IMyBasicMissionAutopilot@Mode)|Current FlightMode|
|[DetailedInfo](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@DetailedInfo)|Contains detailed info with current status/error messages<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[IsSelected](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@IsSelected)|Gets or sets whether the mission is selected<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[MissionName](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@MissionName)|Gets mission name<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[UniqueSelectionId](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@UniqueSelectionId)|Gets unique selection id for the mission. You can find id of the mission in the EntityComponents.sbc.<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|

## Methods

|Member|Description|
|---|---|
|[AddWaypoint(IMyAutopilotWaypoint)](Sandbox.ModAPI.IMyBasicMissionAutopilot@AddWaypoint)|Adds waypoint|
|[AddWaypoint(IMyGps)](Sandbox.ModAPI.IMyBasicMissionAutopilot@AddWaypoint)|Adds waypoint from gps|
|[ClearWaypoints()](Sandbox.ModAPI.IMyBasicMissionAutopilot@ClearWaypoints)|Removes all waypoints|
|[GetLastWaypoint()](Sandbox.ModAPI.IMyBasicMissionAutopilot@GetLastWaypoint)|Gets the last waypoint|
|[GetWaypoints(List<IMyAutopilotWaypoint>)](Sandbox.ModAPI.IMyBasicMissionAutopilot@GetWaypoints)|Gets list of waypoints in this component|
|[RemoveWaypoint(IMyAutopilotWaypoint)](Sandbox.ModAPI.IMyBasicMissionAutopilot@RemoveWaypoint)|Removes waypoint|
|[SetMode(FlightMode)](Sandbox.ModAPI.IMyBasicMissionAutopilot@SetMode)|Sets current FlightMode|
|[CreateTerminalInterfaceControls<T>()](Sandbox.ModAPI.IMyBasicMissionComponent@CreateTerminalInterfaceControls{T})|_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.IMyBasicMissionComponent)_|

**Implements:**  
* [IMyBasicMissionComponent](Sandbox.ModAPI.IMyBasicMissionComponent)  
* [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)

