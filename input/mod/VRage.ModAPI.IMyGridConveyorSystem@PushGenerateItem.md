## Summary

```csharp
public bool PushGenerateItem(MyDefinitionId itemDefinitionId, MyFixedPoint? amount, out MyFixedPoint transferredAmount, IMyEntity sourceBlock, bool partialPush)
```

Implements push item from one source block. Item will be generated from source.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

Returns info whether all items could fit in target network or not.

## Parameters

* [MyDefinitionId](VRage.Game.MyDefinitionId) itemDefinitionId
* [MyFixedPoint?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) amount
* [MyFixedPoint](VRage.MyFixedPoint) transferredAmount
* [IMyEntity](VRage.ModAPI.IMyEntity) sourceBlock
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) partialPush
