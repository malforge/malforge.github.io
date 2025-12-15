**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyBasicMissionFollowPlayer: IMyBasicMissionComponent, IMyBasicMissionComponent, IMyBasicMissionFollowPlayer
```

Describes follow player mission for Basic AI block

## Properties

|Member|Description|
|---|---|
|[DetailedInfo](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@DetailedInfo)|Contains detailed info with current status/error messages<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[FollowDistance](Sandbox.ModAPI.Ingame.IMyBasicMissionFollowPlayer@FollowDistance)|Gets or Sets the following distance<br /><br />_Inherited from [IMyBasicMissionFollowPlayer](Sandbox.ModAPI.Ingame.IMyBasicMissionFollowPlayer)_|
|[IsSelected](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@IsSelected)|Gets or sets whether the mission is selected<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[MissionName](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@MissionName)|Gets mission name<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|
|[UniqueSelectionId](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent@UniqueSelectionId)|Gets unique selection id for the mission. You can find id of the mission in the EntityComponents.sbc.<br /><br />_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)_|

## Methods

|Member|Description|
|---|---|
|[FollowPlayer(long)](Sandbox.ModAPI.IMyBasicMissionFollowPlayer@FollowPlayer)|Starts following the specified player. This method works only when called from the server. Also follow player has to be selected mission.|
|[StopFollowing()](Sandbox.ModAPI.IMyBasicMissionFollowPlayer@StopFollowing)|Stops following player. Follow player has to be selected mission.|
|[CreateTerminalInterfaceControls<T>()](Sandbox.ModAPI.IMyBasicMissionComponent@CreateTerminalInterfaceControls{T})|_Inherited from [IMyBasicMissionComponent](Sandbox.ModAPI.IMyBasicMissionComponent)_|

**Implements:**  
* [IMyBasicMissionComponent](Sandbox.ModAPI.IMyBasicMissionComponent)  
* [IMyBasicMissionComponent](Sandbox.ModAPI.Ingame.IMyBasicMissionComponent)  
* [IMyBasicMissionFollowPlayer](Sandbox.ModAPI.Ingame.IMyBasicMissionFollowPlayer)

