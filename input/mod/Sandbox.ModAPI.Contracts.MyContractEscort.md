**Assembly:** Sandbox.Game.dll

```csharp
public class MyContractEscort: IMyContractEscort, IMyContract
```

## Properties

|Member|Description|
|---|---|
|[Collateral](Sandbox.ModAPI.Contracts.MyContractEscort@Collateral)||
|[Duration](Sandbox.ModAPI.Contracts.MyContractEscort@Duration)||
|[End](Sandbox.ModAPI.Contracts.MyContractEscort@End)||
|[MoneyReward](Sandbox.ModAPI.Contracts.MyContractEscort@MoneyReward)||
|[OnContractAcquired](Sandbox.ModAPI.Contracts.MyContractEscort@OnContractAcquired)||
|[OnContractFailed](Sandbox.ModAPI.Contracts.MyContractEscort@OnContractFailed)||
|[OnContractSucceeded](Sandbox.ModAPI.Contracts.MyContractEscort@OnContractSucceeded)||
|[OwnerIdentityId](Sandbox.ModAPI.Contracts.MyContractEscort@OwnerIdentityId)||
|[Start](Sandbox.ModAPI.Contracts.MyContractEscort@Start)||
|[StartBlockId](Sandbox.ModAPI.Contracts.MyContractEscort@StartBlockId)||
|[Collateral](VRage.Game.ModAPI.IMyContract@Collateral)|Gets money that player would loose if he won't complete contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[Duration](VRage.Game.ModAPI.IMyContract@Duration)|Gets duration of contract in minutes<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[End](VRage.Game.ModAPI.IMyContractEscort@End)|_Inherited from [IMyContractEscort](VRage.Game.ModAPI.IMyContractEscort)_|
|[MoneyReward](VRage.Game.ModAPI.IMyContract@MoneyReward)|Gets reward for completion of this contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractAcquired](VRage.Game.ModAPI.IMyContract@OnContractAcquired)|Gets or sets function that is triggered when contract is acquired by player. IdentityId is passed as an argument<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractFailed](VRage.Game.ModAPI.IMyContract@OnContractFailed)|Gets or sets function that is triggered when contract is failed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OnContractSucceeded](VRage.Game.ModAPI.IMyContract@OnContractSucceeded)|Gets or sets function that is triggered when contract is successfully completed<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|
|[OwnerIdentityId](VRage.Game.ModAPI.IMyContractEscort@OwnerIdentityId)|_Inherited from [IMyContractEscort](VRage.Game.ModAPI.IMyContractEscort)_|
|[Start](VRage.Game.ModAPI.IMyContractEscort@Start)|_Inherited from [IMyContractEscort](VRage.Game.ModAPI.IMyContractEscort)_|
|[StartBlockId](VRage.Game.ModAPI.IMyContract@StartBlockId)|Gets id of block, that created contract<br /><br />_Inherited from [IMyContract](VRage.Game.ModAPI.IMyContract)_|

## Constructors

|Member|Description|
|---|---|
|[MyContractEscort(long, int, int, int, Vector3D, Vector3D, long)](Sandbox.ModAPI.Contracts.MyContractEscort@.ctor)||

**Implements:**  
* [IMyContract](VRage.Game.ModAPI.IMyContract)  
* [IMyContractEscort](VRage.Game.ModAPI.IMyContractEscort)

