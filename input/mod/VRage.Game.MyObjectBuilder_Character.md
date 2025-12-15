**Assembly:** VRage.Game.dll

```csharp
public class MyObjectBuilder_Character: MyObjectBuilder_EntityBase
```

## Fields

|Member|Description|
|---|---|
|[static CharacterModels](VRage.Game.MyObjectBuilder_Character@CharacterModels)||
|[AIMode](VRage.Game.MyObjectBuilder_Character@AIMode)||
|[AutoenableJetpackDelay](VRage.Game.MyObjectBuilder_Character@AutoenableJetpackDelay)||
|[Battery](VRage.Game.MyObjectBuilder_Character@Battery)||
|[BuildPlanner](VRage.Game.MyObjectBuilder_Character@BuildPlanner)||
|[CharacterFeetOffset](VRage.Game.MyObjectBuilder_Character@CharacterFeetOffset)||
|[CharacterGeneralDamageModifier](VRage.Game.MyObjectBuilder_Character@CharacterGeneralDamageModifier)||
|[CharacterModel](VRage.Game.MyObjectBuilder_Character@CharacterModel)||
|[CharacterSpeedDebuff](VRage.Game.MyObjectBuilder_Character@CharacterSpeedDebuff)||
|[ColorMaskHSV](VRage.Game.MyObjectBuilder_Character@ColorMaskHSV)||
|[DampenersEnabled](VRage.Game.MyObjectBuilder_Character@DampenersEnabled)||
|[DisplayName](VRage.Game.MyObjectBuilder_Character@DisplayName)||
|[EnableBroadcasting](VRage.Game.MyObjectBuilder_Character@EnableBroadcasting)||
|[EnableBroadcastingPlayerToggle](VRage.Game.MyObjectBuilder_Character@EnableBroadcastingPlayerToggle)||
|[EnabledComponents](VRage.Game.MyObjectBuilder_Character@EnabledComponents)||
|[EnvironmentOxygenLevel](VRage.Game.MyObjectBuilder_Character@EnvironmentOxygenLevel)||
|[HandWeapon](VRage.Game.MyObjectBuilder_Character@HandWeapon)||
|[HeadAngle](VRage.Game.MyObjectBuilder_Character@HeadAngle)||
|[Health](VRage.Game.MyObjectBuilder_Character@Health)||
|[Inventory](VRage.Game.MyObjectBuilder_Character@Inventory)||
|[IsInFirstPersonView](VRage.Game.MyObjectBuilder_Character@IsInFirstPersonView)||
|[IsPersistenceCharacter](VRage.Game.MyObjectBuilder_Character@IsPersistenceCharacter)||
|[IsStartingCharacterForLobby](VRage.Game.MyObjectBuilder_Character@IsStartingCharacterForLobby)||
|[JetpackEnabled](VRage.Game.MyObjectBuilder_Character@JetpackEnabled)||
|[LightEnabled](VRage.Game.MyObjectBuilder_Character@LightEnabled)||
|[LinearVelocity](VRage.Game.MyObjectBuilder_Character@LinearVelocity)||
|[LootingCounter](VRage.Game.MyObjectBuilder_Character@LootingCounter)||
|[MovementState](VRage.Game.MyObjectBuilder_Character@MovementState)||
|[NeedsOxygenFromSuit](VRage.Game.MyObjectBuilder_Character@NeedsOxygenFromSuit)||
|[OwningPlayerIdentityId](VRage.Game.MyObjectBuilder_Character@OwningPlayerIdentityId)||
|[OxygenLevel](VRage.Game.MyObjectBuilder_Character@OxygenLevel)||
|[RelativeDampeningEntity](VRage.Game.MyObjectBuilder_Character@RelativeDampeningEntity)||
|[StoredGases](VRage.Game.MyObjectBuilder_Character@StoredGases)||
|[UsingLadder](VRage.Game.MyObjectBuilder_Character@UsingLadder)||
|[UsingLadderInfo](VRage.Game.MyObjectBuilder_Character@UsingLadderInfo)||
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
|[MyObjectBuilder_Character()](VRage.Game.MyObjectBuilder_Character@.ctor)||
|[MyObjectBuilder_EntityBase()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@.ctor)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|

## Methods

|Member|Description|
|---|---|
|[ShouldSerializeHealth()](VRage.Game.MyObjectBuilder_Character@ShouldSerializeHealth)||
|[ShouldSerializeMovementState()](VRage.Game.MyObjectBuilder_Character@ShouldSerializeMovementState)||
|[Clone()](VRage.ObjectBuilders.MyObjectBuilder_Base@Clone)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Equals(MyObjectBuilder_Base)](VRage.ObjectBuilders.MyObjectBuilder_Base@Equals)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|
|[Remap(IMyRemapHelper)](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@Remap)|Remaps this entity's entityId to a new value. If there are cross-referenced between different entities in this object builder, the remapHelper should be used to rememeber these references and retrieve them.<br /><br />_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ShouldSerializeComponentContainer()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializeComponentContainer)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ShouldSerializeEntityDefinitionId()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializeEntityDefinitionId)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ShouldSerializeLocalPositionAndOrientation()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializeLocalPositionAndOrientation)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ShouldSerializePositionAndOrientation()](VRage.ObjectBuilders.MyObjectBuilder_EntityBase@ShouldSerializePositionAndOrientation)|_Inherited from [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)_|
|[ShouldSerializeSubtypeId()](VRage.ObjectBuilders.MyObjectBuilder_Base@ShouldSerializeSubtypeId)|_Inherited from [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base)_|

**Inheritance:**   [MyObjectBuilder_Base](VRage.ObjectBuilders.MyObjectBuilder_Base) ˃ [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase)

