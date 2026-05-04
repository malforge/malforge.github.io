**Assembly:** VRage.Game.dll

```csharp
public interface IMyContract
```

Describes contracts that player can take in contract block (mods interface)

## Properties

|Member|Description|
|---|---|
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract|
|[ContractCondition](VRage.Game.ModAPI.IMyContract@ContractCondition)|Gets contract condition. Condition has contract after is created, not in wrapper class. You have to get contract from the contract system.|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes|
|[FailReputationPrice](VRage.Game.ModAPI.IMyContract@FailReputationPrice)|Gets reputation price when contract fails|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed|
|[RewardReputation](VRage.Game.ModAPI.IMyContract@RewardReputation)|Gets reputation reward|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract|

**Inheritors:**  
* [IMyContractAcquisition](VRage.Game.ModAPI.IMyContractAcquisition)  
* [IMyContractBounty](VRage.Game.ModAPI.IMyContractBounty)  
* [IMyContractCustom](VRage.Game.ModAPI.IMyContractCustom)  
* [IMyContractEscort](VRage.Game.ModAPI.IMyContractEscort)  
* [IMyContractGridHauling](VRage.Game.ModAPI.IMyContractGridHauling)  
* [IMyContractHauling](VRage.Game.ModAPI.IMyContractHauling)  
* [IMyContractPvEBounty](VRage.Game.ModAPI.IMyContractPvEBounty)  
* [IMyContractRepair](VRage.Game.ModAPI.IMyContractRepair)  
* [IMyContractSalvage](VRage.Game.ModAPI.IMyContractSalvage)  
* [IMyContractSearch](VRage.Game.ModAPI.IMyContractSearch)  
* [MyContractAcquisition](Sandbox.ModAPI.Contracts.MyContractAcquisition)  
* [MyContractBounty](Sandbox.ModAPI.Contracts.MyContractBounty)  
* [MyContractCustom](Sandbox.ModAPI.Contracts.MyContractCustom)  
* [MyContractEscort](Sandbox.ModAPI.Contracts.MyContractEscort)  
* [MyContractGridHauling](Sandbox.ModAPI.Contracts.MyContractGridHauling)  
* [MyContractHauling](Sandbox.ModAPI.Contracts.MyContractHauling)  
* [MyContractPvEBounty](Sandbox.ModAPI.Contracts.MyContractPvEBounty)  
* [MyContractRepair](Sandbox.ModAPI.Contracts.MyContractRepair)  
* [MyContractSalvage](Sandbox.ModAPI.Contracts.MyContractSalvage)  
* [MyContractSearch](Sandbox.ModAPI.Contracts.MyContractSearch)

