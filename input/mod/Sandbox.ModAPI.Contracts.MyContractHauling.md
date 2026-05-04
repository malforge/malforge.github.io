**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractHauling: IMyContractHauling, IMyContract
```

Implements IMyContractHauling interface so you can create your own contract. Call IMYContractSystem.AddContract with this instance.

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractHauling@Collateral)||
|[ContractCondition](Sandbox.ModAPI.Contracts.MyContractHauling@ContractCondition)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractHauling@Duration)||
|[EndBlockId](Sandbox.ModAPI.Contracts.MyContractHauling@EndBlockId)||
|[EndFactionStationId](Sandbox.ModAPI.Contracts.MyContractHauling@EndFactionStationId)||
|[FailReputationPrice](Sandbox.ModAPI.Contracts.MyContractHauling@FailReputationPrice)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractHauling@MoneyReward)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractHauling@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractHauling@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractHauling@OnContractSucceeded)||
|[RewardReputation](Sandbox.ModAPI.Contracts.MyContractHauling@RewardReputation)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractHauling@StartBlockId)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[ContractCondition](VRage.Game.ModAPI.IMyContract@ContractCondition)|Gets contract condition. Condition has contract after is created, not in wrapper class. You have to get contract from the contract system.<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[EndBlockId](VRage.Game.ModAPI.IMyContractHauling@EndBlockId)|Entity id of the block, where contract is finished<br /><br />_Inherited from [IMyContractHauling](VRage.Game.ModAPI.IMyContractHauling)_|
|[EndFactionStationId](VRage.Game.ModAPI.IMyContractHauling@EndFactionStationId)|Faction Station Id where contract is finished. If not 0, this will replace EndBlock behavior.<br /><br />_Inherited from [IMyContractHauling](VRage.Game.ModAPI.IMyContractHauling)_|
|[FailReputationPrice](VRage.Game.ModAPI.IMyContract@FailReputationPrice)|Gets reputation price when contract fails<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[RewardReputation](VRage.Game.ModAPI.IMyContract@RewardReputation)|Gets reputation reward<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractHauling()](Sandbox.ModAPI.Contracts.MyContractHauling@.ctor)||
|[MyContractHauling(long, int, int, int, long)](Sandbox.ModAPI.Contracts.MyContractHauling@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractHauling](VRage.Game.ModAPI.IMyContractHauling)

