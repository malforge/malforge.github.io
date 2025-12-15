**Assembly:** VRage.Game.dll

```csharp
public interface IMyFaction
```

Describes faction (mods interface)

## Properties

|Member|Description|
|---|---|
|[AcceptHumans](VRage.Game.ModAPI.IMyFaction@AcceptHumans)|Gets or set if faction accepts players|
|[AutoAcceptMember](VRage.Game.ModAPI.IMyFaction@AutoAcceptMember)|Gets if faction automatically accept new members|
|[AutoAcceptPeace](VRage.Game.ModAPI.IMyFaction@AutoAcceptPeace)|Gets if faction automatically accept peace from other factions|
|[CustomColor](VRage.Game.ModAPI.IMyFaction@CustomColor)|Gets faction icon background color|
|[Description](VRage.Game.ModAPI.IMyFaction@Description)|Gets faction description|
|[FactionIcon](VRage.Game.ModAPI.IMyFaction@FactionIcon)|Gets faction icon|
|[FactionId](VRage.Game.ModAPI.IMyFaction@FactionId)|Gets faction id|
|[FactionType](VRage.Game.ModAPI.IMyFaction@FactionType)|Gets faction type: Pirate, Miner ...|
|[FounderId](VRage.Game.ModAPI.IMyFaction@FounderId)|IdentityId of founder of faction|
|[IconColor](VRage.Game.ModAPI.IMyFaction@IconColor)|Gets faction icon color|
|[JoinRequests](VRage.Game.ModAPI.IMyFaction@JoinRequests)|Gets all faction join requests.|
|[Members](VRage.Game.ModAPI.IMyFaction@Members)|Gets all members (founder, leaders also) of faction.|
|[Name](VRage.Game.ModAPI.IMyFaction@Name)|Gets faction name|
|[ObjectivePercentageCompleted](VRage.Game.ModAPI.IMyFaction@ObjectivePercentageCompleted)|Gets or sets percentage of completed objective. Used in Uranium Heist scenario|
|[PrivateInfo](VRage.Game.ModAPI.IMyFaction@PrivateInfo)|Gets faction private info|
|[Score](VRage.Game.ModAPI.IMyFaction@Score)|Gets or sets score of faction. Used in Uranium Heist scenario|
|[Tag](VRage.Game.ModAPI.IMyFaction@Tag)|Gets faction tag|

## Methods

|Member|Description|
|---|---|
|[GetBalanceShortString()](VRage.Game.ModAPI.IMyFaction@GetBalanceShortString)|Gets balance of an account associated with faction. Format is 'BALANCE CURRENCYSHORTNAME'.|
|[HasLastMember()](VRage.Game.ModAPI.IMyFaction@HasLastMember)|Returns if faction has last member|
|[IsEnemy(long)](VRage.Game.ModAPI.IMyFaction@IsEnemy)|Returns if player with provided playerId is enemy to faction|
|[IsEveryoneNpc()](VRage.Game.ModAPI.IMyFaction@IsEveryoneNpc)|Returns if faction has no humans|
|[IsFounder(long)](VRage.Game.ModAPI.IMyFaction@IsFounder)|Returns if player with provided playerId is founder of faction|
|[IsFriendly(long)](VRage.Game.ModAPI.IMyFaction@IsFriendly)|Returns if player with provided playerId is friendly to faction|
|[IsLeader(long)](VRage.Game.ModAPI.IMyFaction@IsLeader)|Returns if player with provided playerId is faction leader|
|[IsMember(long)](VRage.Game.ModAPI.IMyFaction@IsMember)|Returns if player with provided playerId is faction member|
|[IsNeutral(long)](VRage.Game.ModAPI.IMyFaction@IsNeutral)|Returns if player with provided playerId is neutral to faction|
|[RequestChangeBalance(long)](VRage.Game.ModAPI.IMyFaction@RequestChangeBalance)|Changes the balance of the account of this faction by given amount. Sends a message to server with the request.|
|[TryGetBalanceInfo(out long)](VRage.Game.ModAPI.IMyFaction@TryGetBalanceInfo)|Gets balance of an account associated with faction.|

