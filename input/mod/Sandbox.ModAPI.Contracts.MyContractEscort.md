**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractEscort: IMyContractEscort, IMyContract
```

Implements IMyContractEscort interface so you can create your own contract. Call IMYContractSystem.AddContract with this instance.

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractEscort@Collateral)||
|[ContractCondition](Sandbox.ModAPI.Contracts.MyContractEscort@ContractCondition)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractEscort@Duration)||
|[End](Sandbox.ModAPI.Contracts.MyContractEscort@End)||
|[FailReputationPrice](Sandbox.ModAPI.Contracts.MyContractEscort@FailReputationPrice)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractEscort@MoneyReward)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractEscort@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractEscort@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractEscort@OnContractSucceeded)||
|[OwnerIdentityId](Sandbox.ModAPI.Contracts.MyContractEscort@OwnerIdentityId)||
|[RewardReputation](Sandbox.ModAPI.Contracts.MyContractEscort@RewardReputation)||
|[Start](Sandbox.ModAPI.Contracts.MyContractEscort@Start)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractEscort@StartBlockId)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[ContractCondition](VRage.Game.ModAPI.IMyContract@ContractCondition)|Gets contract condition. Condition has contract after is created, not in wrapper class. You have to get contract from the contract system.<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[End](VRage.Game.ModAPI.IMyContractEscort@End)|End position of the contract<br /><br />_Inherited from [IMyContractEscort](VRage.Game.ModAPI.IMyContractEscort)_|
|[FailReputationPrice](VRage.Game.ModAPI.IMyContract@FailReputationPrice)|Gets reputation price when contract fails<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OwnerIdentityId](VRage.Game.ModAPI.IMyContractEscort@OwnerIdentityId)|Identity id of the owner of the escorted grid<br /><br />_Inherited from [IMyContractEscort](VRage.Game.ModAPI.IMyContractEscort)_|
|[RewardReputation](VRage.Game.ModAPI.IMyContract@RewardReputation)|Gets reputation reward<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Start](VRage.Game.ModAPI.IMyContractEscort@Start)|Start position of the contract<br /><br />_Inherited from [IMyContractEscort](VRage.Game.ModAPI.IMyContractEscort)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractEscort()](Sandbox.ModAPI.Contracts.MyContractEscort@.ctor)||
|[MyContractEscort(long, int, int, int, Vector3D, Vector3D, long)](Sandbox.ModAPI.Contracts.MyContractEscort@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractEscort](VRage.Game.ModAPI.IMyContractEscort)

