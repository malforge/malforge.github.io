**Assembly:** VRage.Game.dll

```csharp
public interface IMyContractAcquisition: IMyContract
```

Describes acquisition contract that player can take in contract block (mods interface)

## Properties

|Member|Description|
|---|---|
|[EndBlockId](VRage.Game.ModAPI.IMyContractAcquisition@EndBlockId)|Gets id of block, that should receive goods|
|[ItemAmount](VRage.Game.ModAPI.IMyContractAcquisition@ItemAmount)|Gets amount of items that should be delivered|
|[ItemTypeId](VRage.Game.ModAPI.IMyContractAcquisition@ItemTypeId)|Gets id of item that should be delivered|
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)

**Inheritors:**  
* [MyContractAcquisition](Sandbox.ModAPI.Contracts.MyContractAcquisition)

