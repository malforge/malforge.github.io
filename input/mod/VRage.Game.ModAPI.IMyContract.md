**Assembly:** VRage.Game.dll

```csharp
public interface IMyContract
```

Describes contracts that player can take in contract block (mods interface)

## Properties

|Member|Description|
|---|---|
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract|

**Inheritors:**  
* [IMyContractAcquisition](VRage.Game.ModAPI.IMyContractAcquisition)  
* [IMyContractBounty](VRage.Game.ModAPI.IMyContractBounty)  
* [IMyContractCustom](VRage.Game.ModAPI.IMyContractCustom)  
* [IMyContractEscort](VRage.Game.ModAPI.IMyContractEscort)  
* [IMyContractHauling](VRage.Game.ModAPI.IMyContractHauling)  
* [IMyContractRepair](VRage.Game.ModAPI.IMyContractRepair)  
* [IMyContractSearch](VRage.Game.ModAPI.IMyContractSearch)  
* [MyContractAcquisition](Sandbox.ModAPI.Contracts.MyContractAcquisition)  
* [MyContractBounty](Sandbox.ModAPI.Contracts.MyContractBounty)  
* [MyContractCustom](Sandbox.ModAPI.Contracts.MyContractCustom)  
* [MyContractEscort](Sandbox.ModAPI.Contracts.MyContractEscort)  
* [MyContractHauling](Sandbox.ModAPI.Contracts.MyContractHauling)  
* [MyContractRepair](Sandbox.ModAPI.Contracts.MyContractRepair)  
* [MyContractSearch](Sandbox.ModAPI.Contracts.MyContractSearch)

