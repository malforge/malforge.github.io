**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_Planet: MyObjectBuilder_VoxelMap
```

## Fields

|Member|Description|
|---|---|
|[AtmosphereRadius](VRage.Game.MyObjectBuilder_Planet@AtmosphereRadius)||
|[AtmosphereSettings](VRage.Game.MyObjectBuilder_Planet@AtmosphereSettings)||
|[AtmosphereWavelengths](VRage.Game.MyObjectBuilder_Planet@AtmosphereWavelengths)||
|[GravityFalloff](VRage.Game.MyObjectBuilder_Planet@GravityFalloff)||
|[HasAtmosphere](VRage.Game.MyObjectBuilder_Planet@HasAtmosphere)||
|[MarkAreaEmpty](VRage.Game.MyObjectBuilder_Planet@MarkAreaEmpty)||
|[MaximumHillRadius](VRage.Game.MyObjectBuilder_Planet@MaximumHillRadius)||
|[MinimumSurfaceRadius](VRage.Game.MyObjectBuilder_Planet@MinimumSurfaceRadius)||
|[PlanetGenerator](VRage.Game.MyObjectBuilder_Planet@PlanetGenerator)||
|[Radius](VRage.Game.MyObjectBuilder_Planet@Radius)||
|[SavedEnviromentSectors](VRage.Game.MyObjectBuilder_Planet@SavedEnviromentSectors)||
|[Seed](VRage.Game.MyObjectBuilder_Planet@Seed)||
|[ShowGPS](VRage.Game.MyObjectBuilder_Planet@ShowGPS)||
|[SpawnsFlora](VRage.Game.MyObjectBuilder_Planet@SpawnsFlora)||
|[SpherizeWithDistance](VRage.Game.MyObjectBuilder_Planet@SpherizeWithDistance)||
|[SurfaceGravity](VRage.Game.MyObjectBuilder_Planet@SurfaceGravity)||
|[BoulderItemId](VRage.Game.MyObjectBuilder_VoxelMap@BoulderItemId)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
|[BoulderPlanetId](VRage.Game.MyObjectBuilder_VoxelMap@BoulderPlanetId)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
|[BoulderSectorId](VRage.Game.MyObjectBuilder_VoxelMap@BoulderSectorId)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
|[ComponentContainer](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ComponentContainer)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ContentChanged](VRage.Game.MyObjectBuilder_VoxelMap@ContentChanged)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
|[CreatedByUser](VRage.Game.MyObjectBuilder_VoxelMap@CreatedByUser)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
|[EntityDefinitionId](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@EntityDefinitionId)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[EntityId](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@EntityId)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[Filename](VRage.Game.MyObjectBuilder_VoxelMap@Filename)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
|[IsGlobalEncounterAsteroid](VRage.Game.MyObjectBuilder_VoxelMap@IsGlobalEncounterAsteroid)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
|[LocalPositionAndOrientation](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@LocalPositionAndOrientation)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[MutableStorage](VRage.Game.MyObjectBuilder_VoxelMap@MutableStorage)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
|[Name](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@Name)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[PersistentFlags](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@PersistentFlags)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[PositionAndOrientation](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@PositionAndOrientation)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|

## Properties

|Member|Description|
|---|---|
|[StorageName](VRage.Game.MyObjectBuilder_VoxelMap@StorageName)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
|[SubtypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[SubtypeName](VRage.ObjectBuilders.MyObjectBuilder_Base@SubtypeName)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[TypeId](VRage.ObjectBuilders.MyObjectBuilder_Base@TypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

## Constructors

|Member|Description|
|---|---|
|[MyObjectBuilder_Planet()](VRage.Game.MyObjectBuilder_Planet@.ctor)||
|[MyObjectBuilder_VoxelMap()](VRage.Game.MyObjectBuilder_VoxelMap@.ctor)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
|[MyObjectBuilder_VoxelMap(Vector3, string)](VRage.Game.MyObjectBuilder_VoxelMap@.ctor)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
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
|[ShouldSerializeMutableStorage()](VRage.Game.MyObjectBuilder_VoxelMap@ShouldSerializeMutableStorage)|_Inherited from [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)_|
|[ShouldSerializePositionAndOrientation()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializePositionAndOrientation)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase) ˃ [MyObjectBuilder_VoxelMap](VRage.Game.MyObjectBuilder_VoxelMap)

