**Assembly:** VRage.Game.dll

```csharp
public interface IMyFactionCollection
```

## Events

|Member|Description|
|---|---|
|[FactionAutoAcceptChanged](VRage.Game.ModAPI.IMyFactionCollection@FactionAutoAcceptChanged)|Called when faction [AutoAcceptMember](VRage.Game.ModAPI.IMyFaction@AutoAcceptMember) and [AutoAcceptPeace](VRage.Game.ModAPI.IMyFaction@AutoAcceptPeace) changed|
|[FactionCreated](VRage.Game.ModAPI.IMyFactionCollection@FactionCreated)|Called when new faction created. FactionId is used as argument|
|[FactionEdited](VRage.Game.ModAPI.IMyFactionCollection@FactionEdited)|Called when faction somehow changes.|
|[FactionStateChanged](VRage.Game.ModAPI.IMyFactionCollection@FactionStateChanged)|Called when on of factions changed Arguments: action, fromFactionId, faction Id toFactionId, faction Id, or 0 playerId - IdentityId on whom action was applied, or 0 senderId - IdentityId who triggered state change, or 0|
|[ReputationChanged](VRage.Game.ModAPI.IMyFactionCollection@ReputationChanged)|Called when a reputation change is applied between an identity and a faction|

## Properties

|Member|Description|
|---|---|
|[Factions](VRage.Game.ModAPI.IMyFactionCollection@Factions)|Gets new dictionary with all factions. As keys used factionId|

## Methods

|Member|Description|
|---|---|
|[AcceptJoin(long, long)](VRage.Game.ModAPI.IMyFactionCollection@AcceptJoin)|Accepts faction join request|
|[AcceptPeace(long, long)](VRage.Game.ModAPI.IMyFactionCollection@AcceptPeace)|Accepts peace|
|[AddNewNPCToFaction(long)](VRage.Game.ModAPI.IMyFactionCollection@AddNewNPCToFaction)|Adds new NPC to faction. Name example: "SPRT NPC3340"|
|[AddNewNPCToFaction(long, string)](VRage.Game.ModAPI.IMyFactionCollection@AddNewNPCToFaction)|Adds new NPC to faction|
|[AreFactionsEnemies(long, long)](VRage.Game.ModAPI.IMyFactionCollection@AreFactionsEnemies)|Gets if factions are enemies to each other|
|[CancelJoinRequest(long, long)](VRage.Game.ModAPI.IMyFactionCollection@CancelJoinRequest)|Cancels player faction join request|
|[CancelPeaceRequest(long, long)](VRage.Game.ModAPI.IMyFactionCollection@CancelPeaceRequest)|Cancel peace request from one faction to another|
|[ChangeAutoAccept(long, long, bool, bool)](VRage.Game.ModAPI.IMyFactionCollection@ChangeAutoAccept)|Changes AutoAccept for faction|
|[CreateFaction(long, string, string, string, string)](VRage.Game.ModAPI.IMyFactionCollection@CreateFaction)|Creates new faction with faction type. Obsolete. Use [CreateFactionNew(long, string, string, string, string, string)](VRage.Game.ModAPI.IMyFactionCollection@CreateFactionNew) |
|[CreateFaction(long, string, string, string, string, MyFactionTypes)](VRage.Game.ModAPI.IMyFactionCollection@CreateFaction)|Creates new faction Obsolete. Use [CreateFactionNew(long, string, string, string, string, string)](VRage.Game.ModAPI.IMyFactionCollection@CreateFactionNew) |
|[CreateFactionNew(long, string, string, string, string, string)](VRage.Game.ModAPI.IMyFactionCollection@CreateFactionNew)|Creates new faction|
|[CreateNPCFaction(string, string, string, string)](VRage.Game.ModAPI.IMyFactionCollection@CreateNPCFaction)|Creates new faction with faction type [None](VRage.Game.MyFactionTypes@None) |
|[DeclareWar(long, long)](VRage.Game.ModAPI.IMyFactionCollection@DeclareWar)|Declare war|
|[DemoteMember(long, long)](VRage.Game.ModAPI.IMyFactionCollection@DemoteMember)|Demote faction member|
|[EditFaction(long, string, string, string, string)](VRage.Game.ModAPI.IMyFactionCollection@EditFaction)|Edits faction|
|[EditFaction(long, string, string, string, string, string, Vector3, Vector3)](VRage.Game.ModAPI.IMyFactionCollection@EditFaction)|Edits faction|
|[FactionNameExists(string, IMyFaction)](VRage.Game.ModAPI.IMyFactionCollection@FactionNameExists)|Gets if faction with provided tag exists|
|[FactionTagExists(string, IMyFaction)](VRage.Game.ModAPI.IMyFactionCollection@FactionTagExists)|Gets if faction with provided tag exists|
|[GetObjectBuilder()](VRage.Game.ModAPI.IMyFactionCollection@GetObjectBuilder)|Gets object builder|
|[GetRelationBetweenFactions(long, long)](VRage.Game.ModAPI.IMyFactionCollection@GetRelationBetweenFactions)|Gets relation between 2 factions|
|[GetReputationBetweenFactions(long, long)](VRage.Game.ModAPI.IMyFactionCollection@GetReputationBetweenFactions)|Gets reputation between 2 factions|
|[GetReputationBetweenPlayerAndFaction(long, long)](VRage.Game.ModAPI.IMyFactionCollection@GetReputationBetweenPlayerAndFaction)|Gets reputation between identity and faction|
|[IsPeaceRequestStatePending(long, long)](VRage.Game.ModAPI.IMyFactionCollection@IsPeaceRequestStatePending)||
|[IsPeaceRequestStateSent(long, long)](VRage.Game.ModAPI.IMyFactionCollection@IsPeaceRequestStateSent)|Gets if there is peace request sent|
|[KickMember(long, long)](VRage.Game.ModAPI.IMyFactionCollection@KickMember)|Kicks member from faction|
|[MemberLeaves(long, long)](VRage.Game.ModAPI.IMyFactionCollection@MemberLeaves)|Forces member to leave|
|[PromoteMember(long, long)](VRage.Game.ModAPI.IMyFactionCollection@PromoteMember)|Promotes faction member|
|[RemoveFaction(long)](VRage.Game.ModAPI.IMyFactionCollection@RemoveFaction)|Remove faction by id|
|[SendJoinRequest(long, long)](VRage.Game.ModAPI.IMyFactionCollection@SendJoinRequest)|Send faction join request|
|[SendPeaceRequest(long, long)](VRage.Game.ModAPI.IMyFactionCollection@SendPeaceRequest)|Send peace request from one faction to another|
|[SetReputation(long, long, int)](VRage.Game.ModAPI.IMyFactionCollection@SetReputation)|Sets reputation between 2 factions Note: Faction 1 always has same reputation to Faction 2, as Faction 2 to Faction 1|
|[SetReputationBetweenPlayerAndFaction(long, long, int)](VRage.Game.ModAPI.IMyFactionCollection@SetReputationBetweenPlayerAndFaction)|Sets reputation between player and faction.|
|[TryGetFactionById(long)](VRage.Game.ModAPI.IMyFactionCollection@TryGetFactionById)|Tries get faction by faction id|
|[TryGetFactionByName(string)](VRage.Game.ModAPI.IMyFactionCollection@TryGetFactionByName)|Tries get faction with provided name|
|[TryGetFactionByTag(string)](VRage.Game.ModAPI.IMyFactionCollection@TryGetFactionByTag)|Tries get faction with provided tag|
|[TryGetPlayerFaction(long)](VRage.Game.ModAPI.IMyFactionCollection@TryGetPlayerFaction)|Tries get faction that has member with provided id|
|[AddPlayerToFaction(long, long)](VRage.Game.ModAPI.IMyFactionCollection@AddPlayerToFaction)|_**Obsolete:** Use SendJoinRequest instead, this will be removed in future_|
|[KickPlayerFromFaction(long)](VRage.Game.ModAPI.IMyFactionCollection@KickPlayerFromFaction)|_**Obsolete:** Use KickMember instead, this will be removed in future_|

