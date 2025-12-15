**Assembly:** VRage.Game.dll

```csharp
public interface IMyPlayerCollection
```

ModAPI interface giving control on players

## Events

|Member|Description|
|---|---|
|[ItemConsumed](VRage.Game.ModAPI.IMyPlayerCollection@ItemConsumed)|Called when consumable item was consumed|

## Properties

|Member|Description|
|---|---|
|[Count](VRage.Game.ModAPI.IMyPlayerCollection@Count)|Gets amount of players online|

## Methods

|Member|Description|
|---|---|
|[ExtendControl(IMyControllableEntity, IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@ExtendControl)|Control extension and reduction is a mechanism that saves the control of other entities than IMyControllableEntities. A typical example is a cockpit inside a cube grid - you control the cockpit, but you want to "extend" the control to the cube grid as well. You can extend the control multiple times, but you always have to extend from the "base" entity, i.e. the cockpit in our example. The same goes for control reduction: always reduce to the "base" entity|
|[GetAllIdentites(List<IMyIdentity>, Func<IMyIdentity, bool>)](VRage.Game.ModAPI.IMyPlayerCollection@GetAllIdentites)|Get all registered identities: players that at least once visited server, bots, and online players|
|[GetPlayerControllingEntity(IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@GetPlayerControllingEntity)|Gets player that controls entity|
|[GetPlayers(List<IMyPlayer>, Func<IMyPlayer, bool>)](VRage.Game.ModAPI.IMyPlayerCollection@GetPlayers)|Gets list of currently connected players|
|[HasExtendedControl(IMyControllableEntity, IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@HasExtendedControl)|Gets whether player controls both entities|
|[ReduceControl(IMyControllableEntity, IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@ReduceControl)|Control extension and reduction is a mechanism that saves the control of other entities than IMyControllableEntities. A typical example is a cockpit inside a cube grid - you control the cockpit, but you want to "extend" the control to the cube grid as well. You can extend the control multiple times, but you always have to extend from the "base" entity, i.e. the cockpit in our example. The same goes for control reduction: always reduce to the "base" entity|
|[RemoveControlledEntity(IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@RemoveControlledEntity)|Removes control from entity|
|[RequestChangeBalance(long, long)](VRage.Game.ModAPI.IMyPlayerCollection@RequestChangeBalance)|Requests change of the balance (money) for specific identity id|
|[SetControlledEntity(ulong, IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@SetControlledEntity)|Set entity controlled by player. Functions [ExtendControl(IMyControllableEntity, IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@ExtendControl) and [TryExtendControl(IMyControllableEntity, IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@TryExtendControl) using this function.|
|[TryExtendControl(IMyControllableEntity, IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@TryExtendControl)|Control extension and reduction is a mechanism that saves the control of other entities than IMyControllableEntities. A typical example is a cockpit inside a cube grid - you control the cockpit, but you want to "extend" the control to the cube grid as well. You can extend the control multiple times, but you always have to extend from the "base" entity, i.e. the cockpit in our example. The same goes for control reduction: always reduce to the "base" entity|
|[TryGetIdentityId(ulong)](VRage.Game.ModAPI.IMyPlayerCollection@TryGetIdentityId)|Gets identity for steamId|
|[TryGetIdentityId(long)](VRage.Game.ModAPI.IMyPlayerCollection@TryGetIdentityId)|Gets player for identity|
|[TryGetSteamId(long)](VRage.Game.ModAPI.IMyPlayerCollection@TryGetSteamId)|Gets steamId for passed identityId|
|[TryReduceControl(IMyControllableEntity, IMyEntity)](VRage.Game.ModAPI.IMyPlayerCollection@TryReduceControl)|Control extension and reduction is a mechanism that saves the control of other entities than IMyControllableEntities. A typical example is a cockpit inside a cube grid - you control the cockpit, but you want to "extend" the control to the cube grid as well. You can extend the control multiple times, but you always have to extend from the "base" entity, i.e. the cockpit in our example. The same goes for control reduction: always reduce to the "base" entity|

