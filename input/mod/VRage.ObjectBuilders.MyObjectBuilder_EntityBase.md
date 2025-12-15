**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_EntityBase: MyObjectBuilder_Base
```

## Fields

|Member|Description|
|---|---|
|[ComponentContainer](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ComponentContainer)||
|[EntityDefinitionId](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@EntityDefinitionId)||
|[EntityId](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@EntityId)||
|[LocalPositionAndOrientation](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@LocalPositionAndOrientation)||
|[Name](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@Name)||
|[PersistentFlags](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@PersistentFlags)||
|[PositionAndOrientation](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@PositionAndOrientation)||

## Properties

|Member|Description|
|---|---|
|[SubtypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[SubtypeName](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeName)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[TypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@TypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

## Constructors

|Member|Description|
|---|---|
|[MyObjectBuilder_EntityBase()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Remap(IMyRemapHelper)](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@Remap)|Remaps this entity's entityId to a new value. If there are cross-referenced between different entities in this object builder, the remapHelper should be used to rememeber these references and retrieve them.|
|[ShouldSerializeComponentContainer()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializeComponentContainer)||
|[ShouldSerializeEntityDefinitionId()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializeEntityDefinitionId)||
|[ShouldSerializeLocalPositionAndOrientation()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializeLocalPositionAndOrientation)||
|[ShouldSerializePositionAndOrientation()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializePositionAndOrientation)||
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)

**Inheritors:**  
* [MyObjectBuilder_AutomaticRifle](Sandbox.Common.ObjectBuilders.MyObjectBuilder_AutomaticRifle)  
* [MyObjectBuilder_CargoContainerInventoryBagEntity](VRage.Game.ObjectBuilders.MyObjectBuilder_CargoContainerInventoryBagEntity)  
* [MyObjectBuilder_Character](VRage.Game.MyObjectBuilder_Character)  
* [MyObjectBuilder_CubeGrid](VRage.Game.MyObjectBuilder_CubeGrid)  
* [MyObjectBuilder_CubePlacer](VRage.Game.MyObjectBuilder_CubePlacer)  
* [MyObjectBuilder_DestroyableItem](VRage.Game.MyObjectBuilder_DestroyableItem)  
* [MyObjectBuilder_EngineerToolBase](VRage.Game.MyObjectBuilder_EngineerToolBase)  
* [MyObjectBuilder_EnvironmentItems](VRage.Game.MyObjectBuilder_EnvironmentItems)  
* [MyObjectBuilder_FloatingObject](VRage.Game.MyObjectBuilder_FloatingObject)  
* [MyObjectBuilder_ForageableEntity](VRage.Game.ObjectBuilders.MyObjectBuilder_ForageableEntity)  
* [MyObjectBuilder_GhostCharacter](VRage.Game.MyObjectBuilder_GhostCharacter)  
* [MyObjectBuilder_HandDrill](Sandbox.Common.ObjectBuilders.MyObjectBuilder_HandDrill)  
* [MyObjectBuilder_HandToolBase](VRage.Game.MyObjectBuilder_HandToolBase)  
* [MyObjectBuilder_InventoryBagEntity](VRage.Game.ObjectBuilders.MyObjectBuilder_InventoryBagEntity)  
* [MyObjectBuilder_ManipulationTool](VRage.Game.MyObjectBuilder_ManipulationTool)  
* [MyObjectBuilder_Meteor](Sandbox.Common.ObjectBuilders.MyObjectBuilder_Meteor)  
* [MyObjectBuilder_Missile](Sandbox.Common.ObjectBuilders.MyObjectBuilder_Missile)  
* [MyObjectBuilder_ModifiableEntity](VRage.Game.ObjectBuilders.MyObjectBuilder_ModifiableEntity)  
* [MyObjectBuilder_ProxyAntenna](VRage.Game.MyObjectBuilder_ProxyAntenna)  
* [MyObjectBuilder_ReplicableEntity](VRage.ObjectBuilders.MyObjectBuilder_ReplicableEntity)  
* [MyObjectBuilder_SafeZone](Sandbox.Common.ObjectBuilders.MyObjectBuilder_SafeZone)  
* [MyObjectBuilder_Tree](VRage.Game.MyObjectBuilder_Tree)  
* [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)  
* [MyObjectBuilder_Waypoint](Sandbox.Common.ObjectBuilders.MyObjectBuilder_Waypoint)

