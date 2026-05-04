**Assembly:** VRage.Game.dll

```csharp
public interface IMyContractCondition
```

Describes base contract condition

## Properties

|Member|Description|
|---|---|
|[BlockEndId](VRage.Game.ModAPI.IMyContractCondition@BlockEndId)|Gets block id of the final desition|
|[ContractId](VRage.Game.ModAPI.IMyContractCondition@ContractId)|Gets contrac id for this condition|
|[FactionEndId](VRage.Game.ModAPI.IMyContractCondition@FactionEndId)|Gets faction id|
|[Id](VRage.Game.ModAPI.IMyContractCondition@Id)|Gets Id of the condition|
|[IsFinished](VRage.Game.ModAPI.IMyContractCondition@IsFinished)|Gets if condition is finished|
|[StationEndId](VRage.Game.ModAPI.IMyContractCondition@StationEndId)|Gets station id of the final desition|

## Methods

|Member|Description|
|---|---|
|[FinalizeCondition()](VRage.Game.ModAPI.IMyContractCondition@FinalizeCondition)|Finalize Condition|

**Inheritors:**  
* [IMyContractConditionCustom](VRage.Game.ModAPI.IMyContractConditionCustom)  
* [IMyContractConditionDeliverItems](VRage.Game.ModAPI.IMyContractConditionDeliverItems)  
* [IMyContractConditionHauling](VRage.Game.ModAPI.IMyContractConditionHauling)

