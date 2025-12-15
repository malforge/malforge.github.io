**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractSearch: IMyContractSearch, IMyContract
```

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractSearch@Collateral)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractSearch@Duration)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractSearch@MoneyReward)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractSearch@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractSearch@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractSearch@OnContractSucceeded)||
|[SearchRadius](Sandbox.ModAPI.Contracts.MyContractSearch@SearchRadius)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractSearch@StartBlockId)||
|[TargetGridId](Sandbox.ModAPI.Contracts.MyContractSearch@TargetGridId)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[SearchRadius](VRage.Game.ModAPI.IMyContractSearch@SearchRadius)|Gets radius in which would be target grid<br /><br />_Inherited from [IMyContractSearch](VRage.Game.ModAPI.IMyContractSearch)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[TargetGridId](VRage.Game.ModAPI.IMyContractSearch@TargetGridId)|Gets grid that should be found<br /><br />_Inherited from [IMyContractSearch](VRage.Game.ModAPI.IMyContractSearch)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractSearch(long, int, int, int, long, double)](Sandbox.ModAPI.Contracts.MyContractSearch@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractSearch](VRage.Game.ModAPI.IMyContractSearch)

