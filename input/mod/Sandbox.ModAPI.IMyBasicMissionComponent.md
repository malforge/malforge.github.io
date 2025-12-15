**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyBasicMissionComponent: IMyBasicMissionComponent
```

Describes entity component interface for basic mission (Basic AI block)

## Properties

|Member|Description|
|---|---|
|[DetailedInfo](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@DetailedInfo)|Contains detailed info with current status/error messages<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[IsSelected](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@IsSelected)|Gets or sets whether the mission is selected<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[MissionName](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@MissionName)|Gets mission name<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[UniqueSelectionId](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@UniqueSelectionId)|Gets unique selection id for the mission. You can find id of the mission in the EntityComponents.sbc.<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|

## Methods

|Member|Description|
|---|---|
|[CreateTerminalInterfaceControls<T>()](Sandbox.ModAPI.IMyBasicMissionComponent@CreateTerminalInterfaceControls{T})||

**Implements:**  
* [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)

**Inheritors:**  
* [IMyBasicMissionAutopilot](Sandbox.ModAPI.IMyBasicMissionAutopilot)  
* [IMyBasicMissionFollowHome](Sandbox.ModAPI.IMyBasicMissionFollowHome)  
* [IMyBasicMissionFollowPlayer](Sandbox.ModAPI.IMyBasicMissionFollowPlayer)

