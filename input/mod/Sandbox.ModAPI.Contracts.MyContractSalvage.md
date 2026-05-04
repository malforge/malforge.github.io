**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractSalvage: IMyContractSalvage, IMyContract
```

Implements IMyContractSalvage interface so you can create your own salvage space contract. Call IMyContractSystem.AddContract with this instance.

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractSalvage@Collateral)||
|[ContractCondition](Sandbox.ModAPI.Contracts.MyContractSalvage@ContractCondition)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractSalvage@Duration)||
|[FailReputationPrice](Sandbox.ModAPI.Contracts.MyContractSalvage@FailReputationPrice)||
|[GridPosition](Sandbox.ModAPI.Contracts.MyContractSalvage@GridPosition)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractSalvage@MoneyReward)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractSalvage@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractSalvage@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractSalvage@OnContractSucceeded)||
|[PrefabName](Sandbox.ModAPI.Contracts.MyContractSalvage@PrefabName)||
|[RewardReputation](Sandbox.ModAPI.Contracts.MyContractSalvage@RewardReputation)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractSalvage@StartBlockId)||
|[TargetGridId](Sandbox.ModAPI.Contracts.MyContractSalvage@TargetGridId)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[ContractCondition](VRage.Game.ModAPI.IMyContract@ContractCondition)|Gets contract condition. Condition has contract after is created, not in wrapper class. You have to get contract from the contract system.<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[FailReputationPrice](VRage.Game.ModAPI.IMyContract@FailReputationPrice)|Gets reputation price when contract fails<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[GridPosition](VRage.Game.ModAPI.IMyContractSalvage@GridPosition)|Gets the position where the salvage grid is spawned<br /><br />_Inherited from [IMyContractSalvage](VRage.Game.ModAPI.IMyContractSalvage)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[PrefabName](VRage.Game.ModAPI.IMyContractSalvage@PrefabName)|Gets the prefab name used for the salvage grid<br /><br />_Inherited from [IMyContractSalvage](VRage.Game.ModAPI.IMyContractSalvage)_|
|[RewardReputation](VRage.Game.ModAPI.IMyContract@RewardReputation)|Gets reputation reward<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[TargetGridId](VRage.Game.ModAPI.IMyContractSalvage@TargetGridId)|Gets the entity ID of the target grid containing the objective<br /><br />_Inherited from [IMyContractSalvage](VRage.Game.ModAPI.IMyContractSalvage)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractSalvage()](Sandbox.ModAPI.Contracts.MyContractSalvage@.ctor)||
|[MyContractSalvage(long, int, int, int, Vector3D, string)](Sandbox.ModAPI.Contracts.MyContractSalvage@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractSalvage](VRage.Game.ModAPI.IMyContractSalvage)

