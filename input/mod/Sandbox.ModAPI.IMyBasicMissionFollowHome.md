**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyBasicMissionFollowHome: IMyBasicMissionComponent, IMyBasicMissionComponent, IMyBasicMissionFollowHome
```

Describes follow home mission for Basic AI block

## Properties

|Member|Description|
|---|---|
|[DetailedInfo](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@DetailedInfo)|Contains detailed info with current status/error messages<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[IsSelected](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@IsSelected)|Gets or sets whether the mission is selected<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[MaxRange](Sandbox.ModAPI.Ingame.IMyBasicMissionFollowHome@MaxRange)|Gets or sets max range from home. Controlled grid will stay between min and max range.<br /><br />_Inherited from [IMyBasicMissionFollowHome](Sandbox.ModAPI.Ingame.IMyBasicMissionFollowHome)_|
|[MinRange](Sandbox.ModAPI.Ingame.IMyBasicMissionFollowHome@MinRange)|Gets or sets min range from home. Controlled grid will stay between min and max range.<br /><br />_Inherited from [IMyBasicMissionFollowHome](Sandbox.ModAPI.Ingame.IMyBasicMissionFollowHome)_|
|[MissionName](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@MissionName)|Gets mission name<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[UniqueSelectionId](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@UniqueSelectionId)|Gets unique selection id for the mission. You can find id of the mission in the EntityComponents.sbc.<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[Wander](Sandbox.ModAPI.Ingame.IMyBasicMissionFollowHome@Wander)|Gets or sets wander behavior of the controlled grid<br /><br />_Inherited from [IMyBasicMissionFollowHome](Sandbox.ModAPI.Ingame.IMyBasicMissionFollowHome)_|

## Methods

|Member|Description|
|---|---|
|[GoHome(long)](Sandbox.ModAPI.IMyBasicMissionFollowHome@GoHome)|Goes home to the specified beacon|
|[GoHome(IMyGps)](Sandbox.ModAPI.IMyBasicMissionFollowHome@GoHome)|Goes home to the specified GPS|
|[CreateTerminalInterfaceControls<T>()](Sandbox.ModAPI.IMyBasicMissionComponent@CreateTerminalInterfaceControls{T})|_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.IMyBasicMissionComponent)_|

**Implements:**  
* [IMyBasicMissionComponent](Sandbox.ModAPI.IMyBasicMissionComponent)  
* [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)  
* [IMyBasicMissionFollowHome](Sandbox.ModAPI.Ingame.IMyBasicMissionFollowHome)

