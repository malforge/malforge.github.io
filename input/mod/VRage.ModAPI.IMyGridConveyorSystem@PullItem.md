## Summary

```csharp
public MyFixedPoint PullItem(MyDefinitionId itemDefinitionId, MyFixedPoint? amount, IMyEntity startingBlock, IMyInventory destinationInventory, bool remove)
```

Implements pull item with possible optional remove. Computation part of this method is done in parallel, so if you call it on new conveyor network, it will not pull anything for the first time. So the best approach is to call it in some steps, so it does not matter that you don't get result instantly. Be careful not to call it every frame as it can degrade performance.

## Returns

[MyFixedPoint](VRage.MyFixedPoint)

amount of item pulled

## Parameters

* [MyDefinitionId](VRage.Game.MyDefinitionId) itemDefinitionId
* [MyFixedPoint?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) amount
* [IMyEntity](VRage.ModAPI.IMyEntity) startingBlock
* [IMyInventory](VRage.Game.ModAPI.IMyInventory) destinationInventory
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) remove
