**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractPvEBounty: IMyContractPvEBounty, IMyContract
```

Implements IMyContractPvEBounty interface so you can create your own PvE bounty contract. Call IMyContractSystem.AddContract with this instance.

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractPvEBounty@Collateral)||
|[ContractCondition](Sandbox.ModAPI.Contracts.MyContractPvEBounty@ContractCondition)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractPvEBounty@Duration)||
|[FailReputationPrice](Sandbox.ModAPI.Contracts.MyContractPvEBounty@FailReputationPrice)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractPvEBounty@MoneyReward)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractPvEBounty@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractPvEBounty@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractPvEBounty@OnContractSucceeded)||
|[RewardReputation](Sandbox.ModAPI.Contracts.MyContractPvEBounty@RewardReputation)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractPvEBounty@StartBlockId)||
|[TargetFactionId](Sandbox.ModAPI.Contracts.MyContractPvEBounty@TargetFactionId)||
|[TargetPosition](Sandbox.ModAPI.Contracts.MyContractPvEBounty@TargetPosition)||
|[TargetSpawnGroup](Sandbox.ModAPI.Contracts.MyContractPvEBounty@TargetSpawnGroup)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[ContractCondition](VRage.Game.ModAPI.IMyContract@ContractCondition)|Gets contract condition. Condition has contract after is created, not in wrapper class. You have to get contract from the contract system.<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[FailReputationPrice](VRage.Game.ModAPI.IMyContract@FailReputationPrice)|Gets reputation price when contract fails<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[RewardReputation](VRage.Game.ModAPI.IMyContract@RewardReputation)|Gets reputation reward<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[TargetFactionId](VRage.Game.ModAPI.IMyContractPvEBounty@TargetFactionId)|The faction ID of the target NPC to hunt.<br /><br />_Inherited from [IMyContractPvEBounty](VRage.Game.ModAPI.IMyContractPvEBounty)_|
|[TargetPosition](VRage.Game.ModAPI.IMyContractPvEBounty@TargetPosition)|The position where the target will spawn.<br /><br />_Inherited from [IMyContractPvEBounty](VRage.Game.ModAPI.IMyContractPvEBounty)_|
|[TargetSpawnGroup](VRage.Game.ModAPI.IMyContractPvEBounty@TargetSpawnGroup)|The spawn group used to spawn the NPC target.<br /><br />_Inherited from [IMyContractPvEBounty](VRage.Game.ModAPI.IMyContractPvEBounty)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractPvEBounty()](Sandbox.ModAPI.Contracts.MyContractPvEBounty@.ctor)||
|[MyContractPvEBounty(long, int, int, int, long, Vector3D, MyDefinitionId)](Sandbox.ModAPI.Contracts.MyContractPvEBounty@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractPvEBounty](VRage.Game.ModAPI.IMyContractPvEBounty)

