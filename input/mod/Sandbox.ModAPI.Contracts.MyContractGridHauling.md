**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractGridHauling: IMyContractGridHauling, IMyContract
```

Implements IMyContractGridHauling interface so you can create your own grid hauling contract. Call IMyContractSystem.AddContract with this instance. Either set [TargetGridId](Sandbox.ModAPI.Contracts.MyContractGridHauling@TargetGridId) for an existing grid, or [PrefabName](Sandbox.ModAPI.Contracts.MyContractGridHauling@PrefabName) and [GridPosition](Sandbox.ModAPI.Contracts.MyContractGridHauling@GridPosition) to have the contract spawn one.

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractGridHauling@Collateral)||
|[ContractCondition](Sandbox.ModAPI.Contracts.MyContractGridHauling@ContractCondition)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractGridHauling@Duration)||
|[FailReputationPrice](Sandbox.ModAPI.Contracts.MyContractGridHauling@FailReputationPrice)||
|[GridPosition](Sandbox.ModAPI.Contracts.MyContractGridHauling@GridPosition)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractGridHauling@MoneyReward)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractGridHauling@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractGridHauling@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractGridHauling@OnContractSucceeded)||
|[PrefabName](Sandbox.ModAPI.Contracts.MyContractGridHauling@PrefabName)||
|[RewardReputation](Sandbox.ModAPI.Contracts.MyContractGridHauling@RewardReputation)||
|[RiskLevel](Sandbox.ModAPI.Contracts.MyContractGridHauling@RiskLevel)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractGridHauling@StartBlockId)||
|[TargetGridId](Sandbox.ModAPI.Contracts.MyContractGridHauling@TargetGridId)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[ContractCondition](VRage.Game.ModAPI.IMyContract@ContractCondition)|Gets contract condition. Condition has contract after is created, not in wrapper class. You have to get contract from the contract system.<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[FailReputationPrice](VRage.Game.ModAPI.IMyContract@FailReputationPrice)|Gets reputation price when contract fails<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[GridPosition](VRage.Game.ModAPI.IMyContractGridHauling@GridPosition)|The position where the cargo grid is or will be spawned.<br /><br />_Inherited from [IMyContractGridHauling](VRage.Game.ModAPI.IMyContractGridHauling)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[PrefabName](VRage.Game.ModAPI.IMyContractGridHauling@PrefabName)|Prefab name to spawn. Ignored when [TargetGridId](VRage.Game.ModAPI.IMyContractGridHauling@TargetGridId) points to an existing grid.<br /><br />_Inherited from [IMyContractGridHauling](VRage.Game.ModAPI.IMyContractGridHauling)_|
|[RewardReputation](VRage.Game.ModAPI.IMyContract@RewardReputation)|Gets reputation reward<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[RiskLevel](VRage.Game.ModAPI.IMyContractGridHauling@RiskLevel)|Risk level of the contract (0=Low, 1=Moderate, 2=High)<br /><br />_Inherited from [IMyContractGridHauling](VRage.Game.ModAPI.IMyContractGridHauling)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[TargetGridId](VRage.Game.ModAPI.IMyContractGridHauling@TargetGridId)|Entity id of an existing grid to be hauled. Set to 0 to spawn from [PrefabName](VRage.Game.ModAPI.IMyContractGridHauling@PrefabName) instead.<br /><br />_Inherited from [IMyContractGridHauling](VRage.Game.ModAPI.IMyContractGridHauling)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractGridHauling()](Sandbox.ModAPI.Contracts.MyContractGridHauling@.ctor)||
|[MyContractGridHauling(long, int, int, int, long, int)](Sandbox.ModAPI.Contracts.MyContractGridHauling@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractGridHauling](VRage.Game.ModAPI.IMyContractGridHauling)

