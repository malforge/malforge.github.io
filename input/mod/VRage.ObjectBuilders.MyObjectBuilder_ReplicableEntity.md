**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_ReplicableEntity: MyObjectBuilder_EntityBase
```

This object builder is old and is for "MyInventoryBagEntity". Do not use it as base class or for anything. It is here only for backward compatibility.

## Fields

|Member|Description|
|---|---|
|[AngularVelocity](VRage.ObjectBuilders.MyObjectBuilder_ReplicableEntity@AngularVelocity)||
|[LinearVelocity](VRage.ObjectBuilders.MyObjectBuilder_ReplicableEntity@LinearVelocity)||
|[Mass](VRage.ObjectBuilders.MyObjectBuilder_ReplicableEntity@Mass)||
|[ComponentContainer](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ComponentContainer)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[EntityDefinitionId](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@EntityDefinitionId)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[EntityId](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@EntityId)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[LocalPositionAndOrientation](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@LocalPositionAndOrientation)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[Name](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@Name)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[PersistentFlags](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@PersistentFlags)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[PositionAndOrientation](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@PositionAndOrientation)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|

## Properties

|Member|Description|
|---|---|
|[SubtypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[SubtypeName](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeName)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[TypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@TypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

## Constructors

|Member|Description|
|---|---|
|[MyObjectBuilder_ReplicableEntity()](VRage.ObjectBuilders.MyObjectBuilder_ReplicableEntity@.ctor)||
|[MyObjectBuilder_EntityBase()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@.ctor)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|

## Methods

|Member|Description|
|---|---|
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Remap(IMyRemapHelper)](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@Remap)|Remaps this entity's entityId to a new value. If there are cross-referenced between different entities in this object builder, the remapHelper should be used to rememeber these references and retrieve them.<br /><br />_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ShouldSerializeComponentContainer()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializeComponentContainer)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ShouldSerializeEntityDefinitionId()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializeEntityDefinitionId)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ShouldSerializeLocalPositionAndOrientation()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializeLocalPositionAndOrientation)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ShouldSerializePositionAndOrientation()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializePositionAndOrientation)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)

