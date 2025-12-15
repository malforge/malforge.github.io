**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyItemProducerComponent: IMyItemProducerComponent
```

Describes an entity that produces items (mods interface).

## Properties

|Member|Description|
|---|---|
|[UseConveyorSystem](Sandbox.ModAPI.IMyItemProducerComponent@UseConveyorSystem)|Indicates whether the conveyor system should be used when this entity's inventory is full.|

## Methods

|Member|Description|
|---|---|
|[Produce(MyDefinitionId, MyFixedPoint)](Sandbox.ModAPI.IMyItemProducerComponent@Produce)|Tries to produce an item of the given the definition and quantity.|

**Implements:**  
* [IMyItemProducerComponent](Sandbox.ModAPI.Ingame.IMyItemProducerComponent)

