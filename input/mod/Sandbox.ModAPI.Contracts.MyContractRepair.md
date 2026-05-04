**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractRepair: IMyContractRepair, IMyContract
```

Implements IMyContractRepair interface so you can create your own contract. Call IMYContractSystem.AddContract with this instance.

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractRepair@Collateral)||
|[ContractCondition](Sandbox.ModAPI.Contracts.MyContractRepair@ContractCondition)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractRepair@Duration)||
|[FailReputationPrice](Sandbox.ModAPI.Contracts.MyContractRepair@FailReputationPrice)||
|[GridId](Sandbox.ModAPI.Contracts.MyContractRepair@GridId)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractRepair@MoneyReward)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractRepair@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractRepair@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractRepair@OnContractSucceeded)||
|[RewardReputation](Sandbox.ModAPI.Contracts.MyContractRepair@RewardReputation)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractRepair@StartBlockId)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[ContractCondition](VRage.Game.ModAPI.IMyContract@ContractCondition)|Gets contract condition. Condition has contract after is created, not in wrapper class. You have to get contract from the contract system.<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[FailReputationPrice](VRage.Game.ModAPI.IMyContract@FailReputationPrice)|Gets reputation price when contract fails<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[GridId](VRage.Game.ModAPI.IMyContractRepair@GridId)|Gets grid id, that should be repaired<br /><br />_Inherited from [IMyContractRepair](VRage.Game.ModAPI.IMyContractRepair)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[RewardReputation](VRage.Game.ModAPI.IMyContract@RewardReputation)|Gets reputation reward<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractRepair()](Sandbox.ModAPI.Contracts.MyContractRepair@.ctor)||
|[MyContractRepair(long, int, int, int, long)](Sandbox.ModAPI.Contracts.MyContractRepair@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractRepair](VRage.Game.ModAPI.IMyContractRepair)

