**Assembly:** VRage.Game.dll

```csharp
public interface IMySession
```

ModAPI giving access to MySession functions and properties for modders

## Events

|Member|Description|
|---|---|
|[OnSessionLoading](VRage.Game.ModAPI.IMySession@OnSessionLoading)|Called when session started loading|
|[OnSessionReady](VRage.Game.ModAPI.IMySession@OnSessionReady)|Called when session is ready|

## Properties

|Member|Description|
|---|---|
|[AssemblerEfficiencyMultiplier](VRage.Game.ModAPI.IMySession@AssemblerEfficiencyMultiplier)|Gets game session global assembler efficiency multiplier|
|[AssemblerSpeedMultiplier](VRage.Game.ModAPI.IMySession@AssemblerSpeedMultiplier)|Gets game session global assembler speed multiplier|
|[AutoHealing](VRage.Game.ModAPI.IMySession@AutoHealing)|Gets if game settings allows auto healing|
|[AutoSaveInMinutes](VRage.Game.ModAPI.IMySession@AutoSaveInMinutes)|Gets auto save game setting|
|[BlocksInventorySizeMultiplier](VRage.Game.ModAPI.IMySession@BlocksInventorySizeMultiplier)|Gets game session global block inventory size multiplier|
|[Camera](VRage.Game.ModAPI.IMySession@Camera)|Gets current camera|
|[CameraController](VRage.Game.ModAPI.IMySession@CameraController)|Gets current camera controller|
|[CameraTargetDistance](VRage.Game.ModAPI.IMySession@CameraTargetDistance)|Gets or sets the third person camera distance.|
|[CargoShipsEnabled](VRage.Game.ModAPI.IMySession@CargoShipsEnabled)|Gets if game settings allows auto healing|
|[CharactersInventoryMultiplier](VRage.Game.ModAPI.IMySession@CharactersInventoryMultiplier)|Gets game session global characters inventory size multiplier|
|[Config](VRage.Game.ModAPI.IMySession@Config)|Obtaining values from config is slow and can allocate memory! Do it only when necessary.|
|[ControlledObject](VRage.Game.ModAPI.IMySession@ControlledObject)||
|[CreativeMode](VRage.Game.ModAPI.IMySession@CreativeMode)|Gets whether current create game is in creative mode|
|[CurrentPath](VRage.Game.ModAPI.IMySession@CurrentPath)|Gets current game save path|
|[DamageSystem](VRage.Game.ModAPI.IMySession@DamageSystem)|Gets ModAPI interface providing control over damage system|
|[Description](VRage.Game.ModAPI.IMySession@Description)|Gets or sets current game description (used in MOTD)|
|[ElapsedPlayTime](VRage.Game.ModAPI.IMySession@ElapsedPlayTime)|Gets time elapsed since the start of current session|
|[EnableCopyPaste](VRage.Game.ModAPI.IMySession@EnableCopyPaste)|Get whether current player can copy/paste grids.|
|[EnvironmentHostility](VRage.Game.ModAPI.IMySession@EnvironmentHostility)|Gets current game environment hostility setting|
|[Factions](VRage.Game.ModAPI.IMySession@Factions)|Gets ModAPI interface providing control over faction|
|[GameDateTime](VRage.Game.ModAPI.IMySession@GameDateTime)|Gets and sets game date time, that is a sum of 2081 Jan 1 at 0:00:00 and [ElapsedPlayTime](VRage.Game.ModAPI.IMySession@ElapsedPlayTime) Note using setter, would change [ElapsedPlayTime](VRage.Game.ModAPI.IMySession@ElapsedPlayTime) as well|
|[GameplayFrameCounter](VRage.Game.ModAPI.IMySession@GameplayFrameCounter)|Gets current game amounts of ticks passed from start. Only gets updated when the game is not paused|
|[GPS](VRage.Game.ModAPI.IMySession@GPS)|Gets ModAPI interface providing control over gps coordinates|
|[GrinderSpeedMultiplier](VRage.Game.ModAPI.IMySession@GrinderSpeedMultiplier)|Gets game session global grinder speed multiplier|
|[HackSpeedMultiplier](VRage.Game.ModAPI.IMySession@HackSpeedMultiplier)|Gets game session global hacking speed multiplier|
|[HasCreativeRights](VRage.Game.ModAPI.IMySession@HasCreativeRights)|Checks if the local player is an admin or is promoted to space master (or higher).|
|[InventoryMultiplier](VRage.Game.ModAPI.IMySession@InventoryMultiplier)|Not used|
|[IsCameraAwaitingEntity](VRage.Game.ModAPI.IMySession@IsCameraAwaitingEntity)|Not used|
|[IsCameraControlledObject](VRage.Game.ModAPI.IMySession@IsCameraControlledObject)|Gets if the current camera is the current controlled object (not spectator)|
|[IsCameraUserControlledSpectator](VRage.Game.ModAPI.IMySession@IsCameraUserControlledSpectator)|Gets if the current camera is the user controlled spectator|
|[IsServer](VRage.Game.ModAPI.IMySession@IsServer)|Gets whether this game instance is server. (Not if game is multiplayer)|
|[LocalHumanPlayer](VRage.Game.ModAPI.IMySession@LocalHumanPlayer)|Gets player that playing on this game window. Always null, when called on dedicated server instance, and not null in any other cases|
|[MaxBackupSaves](VRage.Game.ModAPI.IMySession@MaxBackupSaves)|Gets maximum backups allowed in game settings|
|[MaxFloatingObjects](VRage.Game.ModAPI.IMySession@MaxFloatingObjects)|Gets maximum floating objects allowed in game settings|
|[MaxPlayers](VRage.Game.ModAPI.IMySession@MaxPlayers)|Gets maximum players allowed in game settings|
|[Mods](VRage.Game.ModAPI.IMySession@Mods)|Gets or sets mods added to current game|
|[MultiplayerAlive](VRage.Game.ModAPI.IMySession@MultiplayerAlive)|Gets or sets whether there is connection with server. When it is false, a warning would appear.|
|[MultiplayerDirect](VRage.Game.ModAPI.IMySession@MultiplayerDirect)||
|[MultiplayerLastMsg](VRage.Game.ModAPI.IMySession@MultiplayerLastMsg)|Gets or sets time in seconds, from last message from server|
|[Name](VRage.Game.ModAPI.IMySession@Name)|Gets or sets name of the game|
|[NegativeIntegrityTotal](VRage.Game.ModAPI.IMySession@NegativeIntegrityTotal)|Gets or sets amount of damage applied to blocks|
|[OnlineMode](VRage.Game.ModAPI.IMySession@OnlineMode)|Gets current session online mode|
|[OxygenProviderSystem](VRage.Game.ModAPI.IMySession@OxygenProviderSystem)|Gets ModAPI interface providing control oxygen system|
|[Password](VRage.Game.ModAPI.IMySession@Password)|Gets or sets password, that player must enter to join server|
|[Player](VRage.Game.ModAPI.IMySession@Player)||
|[PositiveIntegrityTotal](VRage.Game.ModAPI.IMySession@PositiveIntegrityTotal)|Gets or sets amount of integrity added to blocks|
|[PromoteLevel](VRage.Game.ModAPI.IMySession@PromoteLevel)|Gets the local player's promote level.|
|[RefinerySpeedMultiplier](VRage.Game.ModAPI.IMySession@RefinerySpeedMultiplier)|Gets or sets global refinery speed multiplier|
|[SessionSettings](VRage.Game.ModAPI.IMySession@SessionSettings)||
|[ShowPlayerNamesOnHud](VRage.Game.ModAPI.IMySession@ShowPlayerNamesOnHud)|Gets whether player names should be drawn on hud|
|[SurvivalMode](VRage.Game.ModAPI.IMySession@SurvivalMode)|Gets whether current create game is in creative mode|
|[ThrusterDamage](VRage.Game.ModAPI.IMySession@ThrusterDamage)|Gets whether thruster damage setting is enable|
|[ThumbPath](VRage.Game.ModAPI.IMySession@ThumbPath)|Gets current game path to thumbnail|
|[TimeOnBigShip](VRage.Game.ModAPI.IMySession@TimeOnBigShip)|Gets time spent on controlling large grid|
|[TimeOnFoot](VRage.Game.ModAPI.IMySession@TimeOnFoot)|Gets time spent on foot|
|[TimeOnJetpack](VRage.Game.ModAPI.IMySession@TimeOnJetpack)|Gets time spent flying on jetpack|
|[TimeOnSmallShip](VRage.Game.ModAPI.IMySession@TimeOnSmallShip)|Gets time spent on controlling small ship|
|[TotalBotLimit](VRage.Game.ModAPI.IMySession@TotalBotLimit)|Gets limitation on maximum bot amount|
|[Version](VRage.Game.ModAPI.IMySession@Version)|Get version of Space Engineers|
|[VoxelMaps](VRage.Game.ModAPI.IMySession@VoxelMaps)|Gets ModAPI interface providing control over voxel maps|
|[WeaponsEnabled](VRage.Game.ModAPI.IMySession@WeaponsEnabled)|Gets whether weapons are enabled in current game|
|[WeatherEffects](VRage.Game.ModAPI.IMySession@WeatherEffects)|Gets MySectorWeatherComponent ModAPI interface|
|[WelderSpeedMultiplier](VRage.Game.ModAPI.IMySession@WelderSpeedMultiplier)|Gets current game welder speed global multiplier|
|[WorkshopId](VRage.Game.ModAPI.IMySession@WorkshopId)|Gets current game scenario workshop id|
|[WorldBoundaries](VRage.Game.ModAPI.IMySession@WorldBoundaries)|Gets world boundaries. Not letting character leaving them|
|[ClientCanSave](VRage.Game.ModAPI.IMySession@ClientCanSave)|_**Obsolete:** Client saving not supported anymore_|
|[HasAdminPrivileges](VRage.Game.ModAPI.IMySession@HasAdminPrivileges)|_**Obsolete:** Use HasCreativeRights_|

## Methods

|Member|Description|
|---|---|
|[BeforeStartComponents()](VRage.Game.ModAPI.IMySession@BeforeStartComponents)|Triggers BeforeStart for each game session component, resets game timer.|
|[Draw()](VRage.Game.ModAPI.IMySession@Draw)|Calls Draw on all game session components|
|[GameOver()](VRage.Game.ModAPI.IMySession@GameOver)|Does nothing|
|[GameOver(MyStringId?)](VRage.Game.ModAPI.IMySession@GameOver)|Does nothing|
|[GetCheckpoint(string)](VRage.Game.ModAPI.IMySession@GetCheckpoint)|Gets current game save. Game is saved in several files. This function returns object builder for file: Sandbox.sbc|
|[GetComponentByInterfaceType<T>()](VRage.Game.ModAPI.IMySession@GetComponentByInterfaceType{T})||
|[GetSector()](VRage.Game.ModAPI.IMySession@GetSector)|Gets current game save. Game is saved in several files. This function returns object builder for file: SANDBOX_0_0_0_.sbs|
|[GetUserPromoteLevel(ulong)](VRage.Game.ModAPI.IMySession@GetUserPromoteLevel)|Gets a remote player's promote level.|
|[GetVoxelMapsArray()](VRage.Game.ModAPI.IMySession@GetVoxelMapsArray)||
|[GetWorld()](VRage.Game.ModAPI.IMySession@GetWorld)|Gets information what receives client when connecting to server|
|[IsPausable()](VRage.Game.ModAPI.IMySession@IsPausable)|Get whether game is pauseable (not multiplayer)|
|[IsUserAdmin(ulong)](VRage.Game.ModAPI.IMySession@IsUserAdmin)|Checks if a given player is an admin (or higher).|
|[IsUserIgnorePCULimit(ulong)](VRage.Game.ModAPI.IMySession@IsUserIgnorePCULimit)|Gets whether user can ignore pcu and block limits|
|[IsUserIgnoreSafeZones(ulong)](VRage.Game.ModAPI.IMySession@IsUserIgnoreSafeZones)|Gets whether user can ignore safezone settings|
|[IsUserInvulnerable(ulong)](VRage.Game.ModAPI.IMySession@IsUserInvulnerable)|Gets whether user is invulnerable|
|[IsUserKeepOriginalOwnershipOnPaste(ulong)](VRage.Game.ModAPI.IMySession@IsUserKeepOriginalOwnershipOnPaste)|Gets whether user can keep original BuiltBy of blocks when pasting grid|
|[IsUserShowAllPlayers(ulong)](VRage.Game.ModAPI.IMySession@IsUserShowAllPlayers)|Gets whether user can see all players|
|[IsUserUntargetable(ulong)](VRage.Game.ModAPI.IMySession@IsUserUntargetable)|Gets whether user can't be targeted by turrets|
|[IsUserUseAllTerminals(ulong)](VRage.Game.ModAPI.IMySession@IsUserUseAllTerminals)|Gets whether user can see use all terminals|
|[RegisterComponent(MySessionComponentBase, MyUpdateOrder, int)](VRage.Game.ModAPI.IMySession@RegisterComponent)|Registers game session component for updates.|
|[Save(string)](VRage.Game.ModAPI.IMySession@Save)|Saves game|
|[SetAsNotReady()](VRage.Game.ModAPI.IMySession@SetAsNotReady)|Making game "not ready", preventing joining server for EOS server|
|[SetCameraController(MyCameraControllerEnum, IMyEntity, Vector3D?)](VRage.Game.ModAPI.IMySession@SetCameraController)|Sets mode of camera controller|
|[SetComponentUpdateOrder(MySessionComponentBase, MyUpdateOrder)](VRage.Game.ModAPI.IMySession@SetComponentUpdateOrder)|Change the update order of a session component. There is a proxy for this method in the session component itself.|
|[TryGetAdminSettings(ulong, out MyAdminSettingsEnum)](VRage.Game.ModAPI.IMySession@TryGetAdminSettings)|Gets enabled admins settings|
|[Unload()](VRage.Game.ModAPI.IMySession@Unload)|Unloads current game session. Calls [UnloadDataComponents()](VRage.Game.ModAPI.IMySession@UnloadDataComponents) , [UnloadMultiplayer()](VRage.Game.ModAPI.IMySession@UnloadMultiplayer) |
|[UnloadDataComponents()](VRage.Game.ModAPI.IMySession@UnloadDataComponents)|Unloads data components. Shouldn't be called directly. Use [Unload()](VRage.Game.ModAPI.IMySession@Unload) instead|
|[UnloadMultiplayer()](VRage.Game.ModAPI.IMySession@UnloadMultiplayer)|Unloads data components. Shouldn't be called directly. Use [Unload()](VRage.Game.ModAPI.IMySession@Unload) instead|
|[UnregisterComponent(MySessionComponentBase)](VRage.Game.ModAPI.IMySession@UnregisterComponent)|Unregisters components from updates and calls.|
|[Update(MyTimeSpan)](VRage.Game.ModAPI.IMySession@Update)|Updates games. Does 1 simulation tick|
|[UpdateComponents()](VRage.Game.ModAPI.IMySession@UpdateComponents)|Updates games. Does 1 simulation tick, but without any other logic, that is executed in [Update(MyTimeSpan)](VRage.Game.ModAPI.IMySession@Update) |
|[IsUserPromoted(ulong)](VRage.Game.ModAPI.IMySession@IsUserPromoted)|_**Obsolete:** Use GetUserPromoteLevel_|

