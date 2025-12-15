**Assembly:** VRage.Game.dll

```csharp
public interface IMyConfigDedicated
```

Describes dedicated server configuration (mods interface)

## Properties

|Member|Description|
|---|---|
|[Administrators](VRage.Game.ModAPI.IMyConfigDedicated@Administrators)|Gets or sets administrators It may contain ids in 2 different formats: First - steamId.ToString() Second - starts with `STEAM_0:`|
|[AsteroidAmount](VRage.Game.ModAPI.IMyConfigDedicated@AsteroidAmount)|Not used|
|[AutodetectDependencies](VRage.Game.ModAPI.IMyConfigDedicated@AutodetectDependencies)|Gets or sets if game should automatically add dependency mods in mods list|
|[AutoRestartEnabled](VRage.Game.ModAPI.IMyConfigDedicated@AutoRestartEnabled)|Gets or sets whether auto restart is enabled|
|[AutoRestatTimeInMin](VRage.Game.ModAPI.IMyConfigDedicated@AutoRestatTimeInMin)|Gets or sets auto restart time in minutes|
|[AutoUpdateBranchPassword](VRage.Game.ModAPI.IMyConfigDedicated@AutoUpdateBranchPassword)|Gets or sets password of steam version branch|
|[AutoUpdateCheckIntervalInMin](VRage.Game.ModAPI.IMyConfigDedicated@AutoUpdateCheckIntervalInMin)|Gets or sets how often game checks if new version is available|
|[AutoUpdateEnabled](VRage.Game.ModAPI.IMyConfigDedicated@AutoUpdateEnabled)|Gets or sets if game auto update enabled|
|[AutoUpdateRestartDelayInMin](VRage.Game.ModAPI.IMyConfigDedicated@AutoUpdateRestartDelayInMin)|Gets or sets time before restart after new update found|
|[AutoUpdateSteamBranch](VRage.Game.ModAPI.IMyConfigDedicated@AutoUpdateSteamBranch)|Gets or sets name of steam version branch|
|[Banned](VRage.Game.ModAPI.IMyConfigDedicated@Banned)|Gets or sets Banned players. SteamId and Xbox live ids|
|[ChatAntiSpamEnabled](VRage.Game.ModAPI.IMyConfigDedicated@ChatAntiSpamEnabled)|Gets or sets whether chat anti spam is enabled|
|[ConsoleCompatibility](VRage.Game.ModAPI.IMyConfigDedicated@ConsoleCompatibility)|Not used|
|[CrossPlatform](VRage.Game.ModAPI.IMyConfigDedicated@CrossPlatform)||
|[DedicatedId](VRage.Game.ModAPI.IMyConfigDedicated@DedicatedId)|Id of a dedicated server|
|[GroupID](VRage.Game.ModAPI.IMyConfigDedicated@GroupID)|Steam group id, that blocking access to player not from this group.|
|[IgnoreLastSession](VRage.Game.ModAPI.IMyConfigDedicated@IgnoreLastSession)|Setting that is used server start. When it is true, it should not load previous server launch world|
|[IP](VRage.Game.ModAPI.IMyConfigDedicated@IP)|Gets or sets server IP|
|[LoadWorld](VRage.Game.ModAPI.IMyConfigDedicated@LoadWorld)|Gets current world load path or sets next server start load path|
|[ManualActionChatMessage](VRage.Game.ModAPI.IMyConfigDedicated@ManualActionChatMessage)|Not used|
|[ManualActionDelay](VRage.Game.ModAPI.IMyConfigDedicated@ManualActionDelay)|Not used|
|[MessageOfTheDay](VRage.Game.ModAPI.IMyConfigDedicated@MessageOfTheDay)|Shows Gui Popup for players|
|[MessageOfTheDayUrl](VRage.Game.ModAPI.IMyConfigDedicated@MessageOfTheDayUrl)|Shows Gui Popup for players but in web browser|
|[NetworkParameters](VRage.Game.ModAPI.IMyConfigDedicated@NetworkParameters)|Not used|
|[NetworkType](VRage.Game.ModAPI.IMyConfigDedicated@NetworkType)|Not used|
|[PauseGameWhenEmpty](VRage.Game.ModAPI.IMyConfigDedicated@PauseGameWhenEmpty)|Pause game when zero players on servers|
|[Plugins](VRage.Game.ModAPI.IMyConfigDedicated@Plugins)|Gets or sets server plugins. List contains file paths to dlls|
|[PremadeCheckpointPath](VRage.Game.ModAPI.IMyConfigDedicated@PremadeCheckpointPath)|When [IgnoreLastSession](VRage.Game.ModAPI.IMyConfigDedicated@IgnoreLastSession) is true and [LoadWorld](VRage.Game.ModAPI.IMyConfigDedicated@LoadWorld) is null or empty, or failed - game would be start new world from [PremadeCheckpointPath](VRage.Game.ModAPI.IMyConfigDedicated@PremadeCheckpointPath) |
|[RemoteApiEnabled](VRage.Game.ModAPI.IMyConfigDedicated@RemoteApiEnabled)|Gets or sets if remote api enabled|
|[RemoteApiIP](VRage.Game.ModAPI.IMyConfigDedicated@RemoteApiIP)|Gets or sets remote API IP|
|[RemoteApiPort](VRage.Game.ModAPI.IMyConfigDedicated@RemoteApiPort)|Gets or sets remote api port|
|[RemoteSecurityKey](VRage.Game.ModAPI.IMyConfigDedicated@RemoteSecurityKey)|Gets or sets remote api password|
|[Reserved](VRage.Game.ModAPI.IMyConfigDedicated@Reserved)|Gets or sets reserved players (player can join server even if it is full). SteamId and Xbox live ids|
|[RestartSave](VRage.Game.ModAPI.IMyConfigDedicated@RestartSave)|Gets or sets if game should save on server stop|
|[SameMessageTimeout](VRage.Game.ModAPI.IMyConfigDedicated@SameMessageTimeout)|Gets or sets the timeout for the same message, it cannot be sent again sooner than this (seconds)|
|[SaveChatToLog](VRage.Game.ModAPI.IMyConfigDedicated@SaveChatToLog)|Gets or sets if game should automatically add dependency mods in mods list|
|[ServerDescription](VRage.Game.ModAPI.IMyConfigDedicated@ServerDescription)|Gets or sets server description|
|[ServerName](VRage.Game.ModAPI.IMyConfigDedicated@ServerName)|Gets or sets server name|
|[ServerPasswordHash](VRage.Game.ModAPI.IMyConfigDedicated@ServerPasswordHash)|Gets or sets server password hash|
|[ServerPasswordSalt](VRage.Game.ModAPI.IMyConfigDedicated@ServerPasswordSalt)|Gets or sets server password hash|
|[ServerPort](VRage.Game.ModAPI.IMyConfigDedicated@ServerPort)|Gets or sets server connection port 27016 - default|
|[SessionSettings](VRage.Game.ModAPI.IMyConfigDedicated@SessionSettings)|Gets or sets (but that doesn't change anything) session settings|
|[SpamMessagesTime](VRage.Game.ModAPI.IMyConfigDedicated@SpamMessagesTime)|Gets or sets the time threshold for spam. If elapsed time between messages is less they are considered spam (seconds)|
|[SpamMessagesTimeout](VRage.Game.ModAPI.IMyConfigDedicated@SpamMessagesTimeout)|If player is considered a spammer based on SpamMessagesTime they cannot send any messages for the duration of this timeout (seconds)|
|[SteamPort](VRage.Game.ModAPI.IMyConfigDedicated@SteamPort)|Gets or sets steam port|
|[VerboseNetworkLogging](VRage.Game.ModAPI.IMyConfigDedicated@VerboseNetworkLogging)|Not used|
|[WatcherInterval](VRage.Game.ModAPI.IMyConfigDedicated@WatcherInterval)|Not used|
|[WatcherSimulationSpeedMinimum](VRage.Game.ModAPI.IMyConfigDedicated@WatcherSimulationSpeedMinimum)|Not used|
|[WorldName](VRage.Game.ModAPI.IMyConfigDedicated@WorldName)|Gets or sets world name. Doesn't change world name in client find server gui when setted.|

## Methods

|Member|Description|
|---|---|
|[GenerateRemoteSecurityKey()](VRage.Game.ModAPI.IMyConfigDedicated@GenerateRemoteSecurityKey)|Gets remote api password|
|[GetFilePath()](VRage.Game.ModAPI.IMyConfigDedicated@GetFilePath)|Gets where settings file is located|
|[Load(string)](VRage.Game.ModAPI.IMyConfigDedicated@Load)|Load settings from file|
|[Save(string)](VRage.Game.ModAPI.IMyConfigDedicated@Save)|Saves game.|
|[SetPassword(string)](VRage.Game.ModAPI.IMyConfigDedicated@SetPassword)|Used to set new password for server|

