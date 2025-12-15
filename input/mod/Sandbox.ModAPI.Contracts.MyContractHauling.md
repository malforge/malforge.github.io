**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractHauling: IMyContractHauling, IMyContract
```

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractHauling@Collateral)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractHauling@Duration)||
|[EndBlockId](Sandbox.ModAPI.Contracts.MyContractHauling@EndBlockId)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractHauling@MoneyReward)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractHauling@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractHauling@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractHauling@OnContractSucceeded)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractHauling@StartBlockId)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[EndBlockId](VRage.Game.ModAPI.IMyContractHauling@EndBlockId)|_Inherited from [IMyContractHauling](VRage.Game.ModAPI.IMyContractHauling)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractHauling(long, int, int, int, long)](Sandbox.ModAPI.Contracts.MyContractHauling@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractHauling](VRage.Game.ModAPI.IMyContractHauling)

