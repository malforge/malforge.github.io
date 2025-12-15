**Assembly:** VRage.Game.dll

```csharp
public interface IMyGridConveyorSystem
```

ModAPI interface giving access to grid-group conveyor system

## Methods

|Member|Description|
|---|---|
|[PullItem(MyDefinitionId, MyFixedPoint?, IMyEntity, IMyInventory, bool)](VRage.ModAPI.IMyGridConveyorSystem@PullItem)|Implements pull item with possible optional remove. Computation part of this method is done in parallel, so if you call it on new conveyor network, it will not pull anything for the first time. So the best approach is to call it in some steps, so it does not matter that you don't get result instantly. Be careful not to call it every frame as it can degrade performance.|
|[PushGenerateItem(MyDefinitionId, MyFixedPoint?, out MyFixedPoint, IMyEntity, bool)](VRage.ModAPI.IMyGridConveyorSystem@PushGenerateItem)|Implements push item from one source block. Item will be generated from source.|

