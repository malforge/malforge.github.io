**Assembly:** VRage.Game.dll

```csharp
public interface IMyContractSystem
```

Describes contract system (mods interface)

## Events

|Member|Description|
|---|---|
|[CustomActivateContract](VRage.Game.ModAPI.IMyContractSystem@CustomActivateContract)|Called when contract is activated.|
|[CustomCleanUp](VRage.Game.ModAPI.IMyContractSystem@CustomCleanUp)|Called when contract ended due to any reason. Use to clean up/remove anything.|
|[CustomConditionFinished](VRage.Game.ModAPI.IMyContractSystem@CustomConditionFinished)|Called after Condition has been successfully finished.|
|[CustomFail](VRage.Game.ModAPI.IMyContractSystem@CustomFail)|Called when contract failed.|
|[CustomFailFor](VRage.Game.ModAPI.IMyContractSystem@CustomFailFor)|Called when contract has failed. Has additional information associated with the contract.|
|[CustomFinish](VRage.Game.ModAPI.IMyContractSystem@CustomFinish)|Called when contract was finished.|
|[CustomFinishFor](VRage.Game.ModAPI.IMyContractSystem@CustomFinishFor)|Called when contract was finished. Has additional information associated with the contract.|
|[CustomTimeRanOut](VRage.Game.ModAPI.IMyContractSystem@CustomTimeRanOut)|Called immediately just before contract failed.|
|[CustomUpdate](VRage.Game.ModAPI.IMyContractSystem@CustomUpdate)|Called every frame if marked for it by CustomNeedsUpdate.|

## Properties

|Member|Description|
|---|---|
|[CustomCanActivateContract](VRage.Game.ModAPI.IMyContractSystem@CustomCanActivateContract)|Gets or sets function that is triggered when player trying to take contract First argument - ContractId, Second - IdentityId|
|[CustomFinishCondition](VRage.Game.ModAPI.IMyContractSystem@CustomFinishCondition)|The operation of finishing Condition itself Returns whether it succeeded or not|
|[CustomNeedsUpdate](VRage.Game.ModAPI.IMyContractSystem@CustomNeedsUpdate)|Gets or sets function that is triggered each 100 frames per each contract.|

## Methods

|Member|Description|
|---|---|
|[AddContract(IMyContract)](VRage.Game.ModAPI.IMyContractSystem@AddContract)|Adds the contract|
|[GetContractDefinitionId(long)](VRage.Game.ModAPI.IMyContractSystem@GetContractDefinitionId)|Gets Contracts Definition Id|
|[GetContractState(long)](VRage.Game.ModAPI.IMyContractSystem@GetContractState)|Gets Contract State|
|[IsContractActive(long)](VRage.Game.ModAPI.IMyContractSystem@IsContractActive)|Checks if specified contract is in active state|
|[RemoveContract(long)](VRage.Game.ModAPI.IMyContractSystem@RemoveContract)|Removes the contract|
|[TryAbandonCustomContract(long, long)](VRage.Game.ModAPI.IMyContractSystem@TryAbandonCustomContract)|Tries to abandon the contract|
|[TryFailCustomContract(long)](VRage.Game.ModAPI.IMyContractSystem@TryFailCustomContract)|Tries to set the contract to fail state|
|[TryFinishCustomContract(long)](VRage.Game.ModAPI.IMyContractSystem@TryFinishCustomContract)|Tries to set the contract to finish state|

