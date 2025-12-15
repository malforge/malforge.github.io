**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_PhysicalObject: MyObjectBuilder_Base
```

## Fields

|Member|Description|
|---|---|
|[DurabilityHP](VRage.Game.MyObjectBuilder_PhysicalObject@DurabilityHP)|This is used for GUI to show the amount of health points (durability) of the weapons and tools. This is updated through Durability entity component if entity exists..|
|[Flags](VRage.Game.MyObjectBuilder_PhysicalObject@Flags)||

## Properties

|Member|Description|
|---|---|
|[SubtypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[SubtypeName](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeName)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[TypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@TypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

## Constructors

|Member|Description|
|---|---|
|[MyObjectBuilder_PhysicalObject()](VRage.Game.MyObjectBuilder_PhysicalObject@.ctor)||
|[MyObjectBuilder_PhysicalObject(MyItemFlags)](VRage.Game.MyObjectBuilder_PhysicalObject@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CanStack(MyObjectBuilder_PhysicalObject)](VRage.Game.MyObjectBuilder_PhysicalObject@CanStack)||
|[CanStack(MyObjectBuilderType, MyStringHash, MyItemFlags)](VRage.Game.MyObjectBuilder_PhysicalObject@CanStack)||
|[GetInstanceOnStackSplit()](VRage.Game.MyObjectBuilder_PhysicalObject@GetInstanceOnStackSplit)|Since 204 items like gas containers can stack. All items that has data, that can change should override this method, and return a clone.|
|[GetObjectId()](VRage.Game.MyObjectBuilder_PhysicalObject@GetObjectId)||
|[ShouldSerializeDurabilityHP()](VRage.Game.MyObjectBuilder_PhysicalObject@ShouldSerializeDurabilityHP)||
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)

**Inheritors:**  
* [MyObjectBuilder_AmmoMagazine](VRage.Game.MyObjectBuilder_AmmoMagazine)  
* [MyObjectBuilder_BlockItem](VRage.Game.MyObjectBuilder_BlockItem)  
* [MyObjectBuilder_Component](VRage.Game.MyObjectBuilder_Component)  
* [MyObjectBuilder_Datapad](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_Datapad)  
* [MyObjectBuilder_GasContainerObject](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_GasContainerObject)  
* [MyObjectBuilder_Ingot](VRage.Game.MyObjectBuilder_Ingot)  
* [MyObjectBuilder_Ore](VRage.Game.MyObjectBuilder_Ore)  
* [MyObjectBuilder_Package](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_Package)  
* [MyObjectBuilder_PhysicalGunObject](VRage.Game.MyObjectBuilder_PhysicalGunObject)  
* [MyObjectBuilder_SeedItem](Sandbox.Common.ObjectBuilders.MyObjectBuilder_SeedItem)  
* [MyObjectBuilder_TreeObject](VRage.Game.MyObjectBuilder_TreeObject)  
* [MyObjectBuilder_UsableItem](VRage.Game.ObjectBuilders.MyObjectBuilder_UsableItem)  
* [MyObjectBuilder_ZoneChipObject](Sandbox.Common.ObjectBuilders.Definitions.MyObjectBuilder_ZoneChipObject)

