**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractBounty: IMyContractBounty, IMyContract
```

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractBounty@Collateral)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractBounty@Duration)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractBounty@MoneyReward)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractBounty@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractBounty@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractBounty@OnContractSucceeded)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractBounty@StartBlockId)||
|[TargetIdentityId](Sandbox.ModAPI.Contracts.MyContractBounty@TargetIdentityId)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[TargetIdentityId](VRage.Game.ModAPI.IMyContractBounty@TargetIdentityId)|Gets IdentityId of target, that should be killed<br /><br />_Inherited from [IMyContractBounty](VRage.Game.ModAPI.IMyContractBounty)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractBounty(long, int, int, int, long)](Sandbox.ModAPI.Contracts.MyContractBounty@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractBounty](VRage.Game.ModAPI.IMyContractBounty)

