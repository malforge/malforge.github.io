**Assembly:** VRage.Game.dll

```csharp
public interface IMyContractCustom: IMyContract
```

Describes custom contract (mods interface)

## Properties

|Member|Description|
|---|---|
|[DefinitionId](VRage.Game.ModAPI.IMyContractCustom@DefinitionId)|Definition id of contract.|
|[Description](VRage.Game.ModAPI.IMyContractCustom@Description)|Description of contract|
|[EndBlockId](VRage.Game.ModAPI.IMyContractCustom@EndBlockId)| [EntityId](VRage.ModAPI.IMyEntity@EntityId) of block that should finish contract|
|[FailReputationPrice](VRage.Game.ModAPI.IMyContractCustom@FailReputationPrice)|Amount of reputation you lose on contract failure|
|[Name](VRage.Game.ModAPI.IMyContractCustom@Name)|Name of contract|
|[ReputationReward](VRage.Game.ModAPI.IMyContractCustom@ReputationReward)|Amount of reputation gained on contract success|
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
* [MyContractCustom](Sandbox.ModAPI.Contracts.MyContractCustom)

