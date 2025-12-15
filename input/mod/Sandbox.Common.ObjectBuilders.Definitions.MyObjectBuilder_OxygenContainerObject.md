**Assembly:** SpaceEngineers.ObjectBuilders.dll

```csharp
public class MyObjectBuilder_OxygenContainerObject: MyObjectBuilder_GasContainerObject
```

## Fields

|Member|Description|
|---|---|
|[OxygenLevel](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_OxygenContainerObject@OxygenLevel)|This is not synced automatically Call SyncOxygenContainerLevel on inventory to sync it|
|[DurabilityHP](VRage.Game.MyObjectBuilder_PhysicalObject@DurabilityHP)|This is used for GUI to show the amount of health points (durability) of the weapons and tools. This is updated through Durability entity component if entity exists..<br /><br />_Inherited from [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)_|
|[Flags](VRage.Game.MyObjectBuilder_PhysicalObject@Flags)|_Inherited from [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)_|

## Properties

|Member|Description|
|---|---|
|[GasLevel](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_GasContainerObject@GasLevel)|_Inherited from [MyObjectBuilder_GasContainerObject](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_GasContainerObject)_|
|[SubtypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[SubtypeName](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeName)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[TypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@TypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

## Constructors

|Member|Description|
|---|---|
|[MyObjectBuilder_OxygenContainerObject()](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_OxygenContainerObject@.ctor)||
|[MyObjectBuilder_GasContainerObject()](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_GasContainerObject@.ctor)|_Inherited from [MyObjectBuilder_GasContainerObject](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_GasContainerObject)_|
|[MyObjectBuilder_PhysicalObject()](VRage.Game.MyObjectBuilder_PhysicalObject@.ctor)|_Inherited from [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)_|
|[MyObjectBuilder_PhysicalObject(MyItemFlags)](VRage.Game.MyObjectBuilder_PhysicalObject@.ctor)|_Inherited from [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)_|

## Methods

|Member|Description|
|---|---|
|[CanStack(MyObjectBuilder_PhysicalObject)](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_OxygenContainerObject@CanStack)||
|[GetInstanceOnStackSplit()](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_OxygenContainerObject@GetInstanceOnStackSplit)||
|[CanStack(MyObjectBuilder_PhysicalObject)](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_GasContainerObject@CanStack)|_Inherited from [MyObjectBuilder_GasContainerObject](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_GasContainerObject)_|
|[CanStack(MyObjectBuilder_PhysicalObject)](VRage.Game.MyObjectBuilder_PhysicalObject@CanStack)|_Inherited from [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)_|
|[CanStack(MyObjectBuilderType, MyStringHash, MyItemFlags)](VRage.Game.MyObjectBuilder_PhysicalObject@CanStack)|_Inherited from [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)_|
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[GetInstanceOnStackSplit()](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_GasContainerObject@GetInstanceOnStackSplit)|_Inherited from [MyObjectBuilder_GasContainerObject](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_GasContainerObject)_|
|[GetInstanceOnStackSplit()](VRage.Game.MyObjectBuilder_PhysicalObject@GetInstanceOnStackSplit)|Since 204 items like gas containers can stack. All items that has data, that can change should override this method, and return a clone.<br /><br />_Inherited from [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)_|
|[GetObjectId()](VRage.Game.MyObjectBuilder_PhysicalObject@GetObjectId)|_Inherited from [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)_|
|[ShouldSerializeDurabilityHP()](VRage.Game.MyObjectBuilder_PhysicalObject@ShouldSerializeDurabilityHP)|_Inherited from [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject) ˃ [MyObjectBuilder_GasContainerObject](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_GasContainerObject)

