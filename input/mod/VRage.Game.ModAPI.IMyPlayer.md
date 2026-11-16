**Assembly:** VRage.Game.dll

```csharp
public interface IMyPlayer
```

## Events

|Member|Description|
|---|---|
|[IdentityChanged](VRage.Game.ModAPI.IMyPlayer@IdentityChanged)|Event triggered when the player's identity changed (eg. died w/permadeath on)|

## Properties

|Member|Description|
|---|---|
|[BuildColorSlots](VRage.Game.ModAPI.IMyPlayer@BuildColorSlots)|Gets or sets all the player's build color slots|
|[Character](VRage.Game.ModAPI.IMyPlayer@Character)|Gets the Character entity for the player.|
|[CharacterToolbar](VRage.Game.ModAPI.IMyPlayer@CharacterToolbar)|Gets the live character toolbar this machine draws for the player, the one their hotbar shows on foot. This is the character toolbar that accepts writes; [Toolbar](VRage.Game.ModAPI.IMyPlayer@Toolbar) is the session's saved copy and is read only. Null for every player except the one running the code, and null on a dedicated server.|
|[Client](VRage.Game.ModAPI.IMyPlayer@Client)|Gets network client for this player. Used for sending network messages between players and server|
|[Controller](VRage.Game.ModAPI.IMyPlayer@Controller)|Gets the EntityController for the player.|
|[CurrentToolbar](VRage.Game.ModAPI.IMyPlayer@CurrentToolbar)|Gets the toolbar this player is driving at the moment: their character toolbar, or the controlled block's while they are seated, following the same switches the HUD does. This is local state rather than session state, so it is null for every player except the one running the code, and null on a dedicated server.|
|[DefaultBuildColorSlots](VRage.Game.ModAPI.IMyPlayer@DefaultBuildColorSlots)|Gets the list of the default build colors.|
|[DisplayName](VRage.Game.ModAPI.IMyPlayer@DisplayName)|Visible player name|
|[Grids](VRage.Game.ModAPI.IMyPlayer@Grids)|List of grids where the player owns at least one block.|
|[Identity](VRage.Game.ModAPI.IMyPlayer@Identity)|Gets the identity for the player|
|[IdentityId](VRage.Game.ModAPI.IMyPlayer@IdentityId)|Unique id for the current player identity.|
|[IsBot](VRage.Game.ModAPI.IMyPlayer@IsBot)|Gets if the player is a bot (non-human)|
|[PromoteLevel](VRage.Game.ModAPI.IMyPlayer@PromoteLevel)|Gets the player's promote level|
|[RespawnShip](VRage.Game.ModAPI.IMyPlayer@RespawnShip)|Gets the entity id for the player's respawn ship(s).|
|[SelectedBuildColor](VRage.Game.ModAPI.IMyPlayer@SelectedBuildColor)|Gets or sets the build color for the selected slot.|
|[SelectedBuildColorSlot](VRage.Game.ModAPI.IMyPlayer@SelectedBuildColorSlot)|Gets or sets the selected slot for the build color.|
|[SteamUserId](VRage.Game.ModAPI.IMyPlayer@SteamUserId)|Gets the Steam user id for the player.|
|[Toolbar](VRage.Game.ModAPI.IMyPlayer@Toolbar)|Gets this player's character toolbar, or null when the session holds none for them. This is the copy the session owns and saves, which is a separate object from the live toolbar the local player's HUD draws; edits reach it through a client to server update. See [CurrentToolbar](VRage.Game.ModAPI.IMyPlayer@CurrentToolbar) for the live one.|
|[IsAdmin](VRage.Game.ModAPI.IMyPlayer@IsAdmin)|_**Obsolete:** Use Promote Level instead_<br /><br />Gets if the player is an admin on the server.|
|[IsPromoted](VRage.Game.ModAPI.IMyPlayer@IsPromoted)|_**Obsolete:** Use Promote Level instead_<br /><br />Gets if the player is promoted to Space Master.|
|[PlayerID](VRage.Game.ModAPI.IMyPlayer@PlayerID)|_**Obsolete:** Use IdentityId instead._|

## Methods

|Member|Description|
|---|---|
|[AddGrid(long)](VRage.Game.ModAPI.IMyPlayer@AddGrid)|Adds a grid to the player's Grids list.|
|[ChangeOrSwitchToColor(Vector3)](VRage.Game.ModAPI.IMyPlayer@ChangeOrSwitchToColor)|Switches to slot containing color, if present. Otherwise sets active slot to color.|
|[GetBalanceShortString()](VRage.Game.ModAPI.IMyPlayer@GetBalanceShortString)|Gets balance of an account associated with player. Format is 'BALANCE CURRENCYSHORTNAME'.|
|[GetPosition()](VRage.Game.ModAPI.IMyPlayer@GetPosition)|Gets the position of controlled entity. Grid/Character|
|[GetRelationTo(long)](VRage.Game.ModAPI.IMyPlayer@GetRelationTo)|Gets the relationship between this player and another.|
|[RemoveGrid(long)](VRage.Game.ModAPI.IMyPlayer@RemoveGrid)|Removes a grid from the player's Grids list.|
|[RequestChangeBalance(long)](VRage.Game.ModAPI.IMyPlayer@RequestChangeBalance)|Changes the balance of the account of this player by given amount. Sends a message to server with the request.|
|[SetDefaultColors()](VRage.Game.ModAPI.IMyPlayer@SetDefaultColors)|Sets build colors back to defaults.|
|[SpawnAt(MatrixD, Vector3, IMyEntity, bool, string, Color?)](VRage.Game.ModAPI.IMyPlayer@SpawnAt)|Spawns the player at a specific place. Must be called on server.|
|[SpawnAt(MatrixD, Vector3, IMyEntity)](VRage.Game.ModAPI.IMyPlayer@SpawnAt)|Spawns the player at a specific place. Must be called on server.|
|[SpawnIntoCharacter(IMyCharacter)](VRage.Game.ModAPI.IMyPlayer@SpawnIntoCharacter)|Spawns the player as a new character (changes the model).|
|[TryGetBalanceInfo(out long)](VRage.Game.ModAPI.IMyPlayer@TryGetBalanceInfo)|Gets balance of an account associated with player.|

