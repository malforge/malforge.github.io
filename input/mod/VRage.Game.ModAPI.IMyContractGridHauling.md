**Assembly:** VRage.Game.dll

```csharp
public interface IMyContractGridHauling: IMyContract
```

Describes grid hauling contract where player physically transports a cargo grid. Either provide [TargetGridId](VRage.Game.ModAPI.IMyContractGridHauling@TargetGridId) for an existing grid, or [PrefabName](VRage.Game.ModAPI.IMyContractGridHauling@PrefabName) and [GridPosition](VRage.Game.ModAPI.IMyContractGridHauling@GridPosition) to have the contract spawn one.

## Properties

|Member|Description|
|---|---|
|[GridPosition](VRage.Game.ModAPI.IMyContractGridHauling@GridPosition)|The position where the cargo grid is or will be spawned.|
|[PrefabName](VRage.Game.ModAPI.IMyContractGridHauling@PrefabName)|Prefab name to spawn. Ignored when [TargetGridId](VRage.Game.ModAPI.IMyContractGridHauling@TargetGridId) points to an existing grid.|
|[RiskLevel](VRage.Game.ModAPI.IMyContractGridHauling@RiskLevel)|Risk level of the contract (0=Low, 1=Moderate, 2=High)|
|[TargetGridId](VRage.Game.ModAPI.IMyContractGridHauling@TargetGridId)|Entity id of an existing grid to be hauled. Set to 0 to spawn from [PrefabName](VRage.Game.ModAPI.IMyContractGridHauling@PrefabName) instead.|
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

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)

**Inheritors:**  
* [MyContractGridHauling](Sandbox.ModAPI.Contracts.MyContractGridHauling)

