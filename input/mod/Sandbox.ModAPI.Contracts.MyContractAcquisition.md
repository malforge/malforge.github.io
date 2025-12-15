**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractAcquisition: IMyContractAcquisition, IMyContract
```

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractAcquisition@Collateral)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractAcquisition@Duration)||
|[EndBlockId](Sandbox.ModAPI.Contracts.MyContractAcquisition@EndBlockId)||
|[ItemAmount](Sandbox.ModAPI.Contracts.MyContractAcquisition@ItemAmount)||
|[ItemTypeId](Sandbox.ModAPI.Contracts.MyContractAcquisition@ItemTypeId)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractAcquisition@MoneyReward)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractAcquisition@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractAcquisition@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractAcquisition@OnContractSucceeded)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractAcquisition@StartBlockId)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[EndBlockId](VRage.Game.ModAPI.IMyContractAcquisition@EndBlockId)|Gets id of block, that should receive goods<br /><br />_Inherited from [IMyContractAcquisition](VRage.Game.ModAPI.IMyContractAcquisition)_|
|[ItemAmount](VRage.Game.ModAPI.IMyContractAcquisition@ItemAmount)|Gets amount of items that should be delivered<br /><br />_Inherited from [IMyContractAcquisition](VRage.Game.ModAPI.IMyContractAcquisition)_|
|[ItemTypeId](VRage.Game.ModAPI.IMyContractAcquisition@ItemTypeId)|Gets id of item that should be delivered<br /><br />_Inherited from [IMyContractAcquisition](VRage.Game.ModAPI.IMyContractAcquisition)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractAcquisition(long, int, int, int, long, MyDefinitionId, int)](Sandbox.ModAPI.Contracts.MyContractAcquisition@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractAcquisition](VRage.Game.ModAPI.IMyContractAcquisition)

