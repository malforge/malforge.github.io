**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractCustom: IMyContractCustom, IMyContract
```

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractCustom@Collateral)||
|[DefinitionId](Sandbox.ModAPI.Contracts.MyContractCustom@DefinitionId)||
|[Description](Sandbox.ModAPI.Contracts.MyContractCustom@Description)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractCustom@Duration)||
|[EndBlockId](Sandbox.ModAPI.Contracts.MyContractCustom@EndBlockId)||
|[FailReputationPrice](Sandbox.ModAPI.Contracts.MyContractCustom@FailReputationPrice)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractCustom@MoneyReward)||
|[Name](Sandbox.ModAPI.Contracts.MyContractCustom@Name)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractCustom@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractCustom@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractCustom@OnContractSucceeded)||
|[ReputationReward](Sandbox.ModAPI.Contracts.MyContractCustom@ReputationReward)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractCustom@StartBlockId)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[DefinitionId](VRage.Game.ModAPI.IMyContractCustom@DefinitionId)|Definition id of contract.<br /><br />_Inherited from [IMyContractCustom](VRage.Game.ModAPI.IMyContractCustom)_|
|[Description](VRage.Game.ModAPI.IMyContractCustom@Description)|Description of contract<br /><br />_Inherited from [IMyContractCustom](VRage.Game.ModAPI.IMyContractCustom)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[EndBlockId](VRage.Game.ModAPI.IMyContractCustom@EndBlockId)| [EntityId](VRage.ModAPI.IMyEntity@EntityId) of block that should finish contract<br /><br />_Inherited from [IMyContractCustom](VRage.Game.ModAPI.IMyContractCustom)_|
|[FailReputationPrice](VRage.Game.ModAPI.IMyContractCustom@FailReputationPrice)|Amount of reputation you lose on contract failure<br /><br />_Inherited from [IMyContractCustom](VRage.Game.ModAPI.IMyContractCustom)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Name](VRage.Game.ModAPI.IMyContractCustom@Name)|Name of contract<br /><br />_Inherited from [IMyContractCustom](VRage.Game.ModAPI.IMyContractCustom)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[ReputationReward](VRage.Game.ModAPI.IMyContractCustom@ReputationReward)|Amount of reputation gained on contract success<br /><br />_Inherited from [IMyContractCustom](VRage.Game.ModAPI.IMyContractCustom)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractCustom(MyDefinitionId, long, int, int, int, string, string, int, int, long?)](Sandbox.ModAPI.Contracts.MyContractCustom@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractCustom](VRage.Game.ModAPI.IMyContractCustom)

