**Assembly:** Sandbox.Game.dll

```csharp
public class MyCharacterStatComponent: MyEntityStatComponent, IMyComponentBase, IMyEntityComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent, IMyHazardReceiver
```

## Fields

|Member|Description|
|---|---|
|[static FOOD_ID](Sandbox.Game.Components.MyCharacterStatComponent@FOOD_ID)||
|[static HEALTH_RATIO_CRITICAL](Sandbox.Game.Components.MyCharacterStatComponent@HEALTH_RATIO_CRITICAL)||
|[static HEALTH_RATIO_LOW](Sandbox.Game.Components.MyCharacterStatComponent@HEALTH_RATIO_LOW)||
|[static HealthId](Sandbox.Game.Components.MyCharacterStatComponent@HealthId)||
|[static RADIATION_ID](Sandbox.Game.Components.MyCharacterStatComponent@RADIATION_ID)||
|[static RADIATION_IMMUNITY_CHARACTER_SUBTYPE_ID](Sandbox.Game.Components.MyCharacterStatComponent@RADIATION_IMMUNITY_CHARACTER_SUBTYPE_ID)||
|[static RADIATION_IMMUNITY_ID](Sandbox.Game.Components.MyCharacterStatComponent@RADIATION_IMMUNITY_ID)||
|[static SHOW_CAUSE_OF_DEATH_FADE_START_FRAMES](Sandbox.Game.Components.MyCharacterStatComponent@SHOW_CAUSE_OF_DEATH_FADE_START_FRAMES)||
|[static SHOW_CAUSE_OF_DEATH_FRAMES](Sandbox.Game.Components.MyCharacterStatComponent@SHOW_CAUSE_OF_DEATH_FRAMES)||
|[LastDamage](Sandbox.Game.Components.MyCharacterStatComponent@LastDamage)||
|[SyncType](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@SyncType)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[Food](Sandbox.Game.Components.MyCharacterStatComponent@Food)||
|[FoodRatio](Sandbox.Game.Components.MyCharacterStatComponent@FoodRatio)||
|[Health](Sandbox.Game.Components.MyCharacterStatComponent@Health)||
|[HealthRatio](Sandbox.Game.Components.MyCharacterStatComponent@HealthRatio)||
|[LastDamageSoundOverride](Sandbox.Game.Components.MyCharacterStatComponent@LastDamageSoundOverride)||
|[Radiation](Sandbox.Game.Components.MyCharacterStatComponent@Radiation)||
|[RadiationImmunity](Sandbox.Game.Components.MyCharacterStatComponent@RadiationImmunity)||
|[RadiationImmunityRatio](Sandbox.Game.Components.MyCharacterStatComponent@RadiationImmunityRatio)||
|[RadiationRatio](Sandbox.Game.Components.MyCharacterStatComponent@RadiationRatio)||
|[AttachSyncToEntity](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@AttachSyncToEntity)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](Sandbox.Game.Components.MyEntityStatComponent@ComponentTypeDebugString)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[NeedsUpdate](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@NeedsUpdate)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[NeedsUpdateAfterSimulation](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@NeedsUpdateAfterSimulation)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[NeedsUpdateAfterSimulation10](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@NeedsUpdateAfterSimulation10)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[NeedsUpdateAfterSimulation100](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@NeedsUpdateAfterSimulation100)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[NeedsUpdateBeforeSimulation](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@NeedsUpdateBeforeSimulation)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[NeedsUpdateBeforeSimulation100](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@NeedsUpdateBeforeSimulation100)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[NeedsUpdateChanged](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@NeedsUpdateChanged)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[NeedsUpdateSimulation](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@NeedsUpdateSimulation)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[ParentEntity](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@ParentEntity)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Stats](Sandbox.Game.Components.MyEntityStatComponent@Stats)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[UpdateParallel](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateParallel)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateParallelChanged](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateParallelChanged)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdatingType](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdatingType)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|

## Constructors

|Member|Description|
|---|---|
|[MyCharacterStatComponent()](Sandbox.Game.Components.MyCharacterStatComponent@.ctor)||
|[MyEntityStatComponent()](Sandbox.Game.Components.MyEntityStatComponent@.ctor)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[MyEventProxyEntityComponent()](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@.ctor)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|

## Methods

|Member|Description|
|---|---|
|[Consume(MyFixedPoint, MyConsumableItemDefinition)](Sandbox.Game.Components.MyCharacterStatComponent@Consume)||
|[Deserialize(MyObjectBuilder_ComponentBase)](Sandbox.Game.Components.MyCharacterStatComponent@Deserialize)||
|[DoDamage(float, object)](Sandbox.Game.Components.MyCharacterStatComponent@DoDamage)||
|[GetAccumulatedDelta()](Sandbox.Game.Components.MyCharacterStatComponent@GetAccumulatedDelta)|Gets accumulated incoming value change (before clamping and immunities) and resets it|
|[OnAddedToContainer()](Sandbox.Game.Components.MyCharacterStatComponent@OnAddedToContainer)||
|[OnBeforeRemovedFromContainer()](Sandbox.Game.Components.MyCharacterStatComponent@OnBeforeRemovedFromContainer)||
|[OnHealthChanged(float, float, object)](Sandbox.Game.Components.MyCharacterStatComponent@OnHealthChanged)||
|[SendStatChangeNotification(string, string, float)](Sandbox.Game.Components.MyCharacterStatComponent@SendStatChangeNotification)||
|[SetDamageSoundOverride(string)](Sandbox.Game.Components.MyCharacterStatComponent@SetDamageSoundOverride)||
|[TryGetScript<T>(out T)](Sandbox.Game.Components.MyCharacterStatComponent@TryGetScript{T})||
|[UpdateAfterSimulationParallel()](Sandbox.Game.Components.MyCharacterStatComponent@UpdateAfterSimulationParallel)||
|[Apply(float, MyStringHash, MyStringHash)](Sandbox.ModAPI.IMyHazardReceiver@Apply)|Affects corresponding entity stat. Does not check admin protection. For Radiation, checks immunity stat. Positive value increases stat (except Health, which is reduced by positive damage value).<br /><br />_Inherited from [IMyHazardReceiver](Sandbox.ModAPI.IMyHazardReceiver)_|
|[ApplyModifier(string)](Sandbox.Game.Components.MyEntityStatComponent@ApplyModifier)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[CanBeAffected()](Sandbox.ModAPI.IMyHazardReceiver@CanBeAffected)|Is it sheltered from the exposure?<br /><br />_Inherited from [IMyHazardReceiver](Sandbox.ModAPI.IMyHazardReceiver)_|
|[CanDoAction(string, out MyTuple<ushort, MyStringHash>, bool)](Sandbox.Game.Components.MyEntityStatComponent@CanDoAction)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](Sandbox.Game.Components.MyEntityStatComponent@Deserialize)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[DoAction(string)](Sandbox.Game.Components.MyEntityStatComponent@DoAction)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetEfficiencyModifier(string)](Sandbox.Game.Components.MyEntityStatComponent@GetEfficiencyModifier)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[GetEntity()](Sandbox.ModAPI.IMyHazardReceiver@GetEntity)|Gets the associated entity<br /><br />_Inherited from [IMyHazardReceiver](Sandbox.ModAPI.IMyHazardReceiver)_|
|[GetPosition()](Sandbox.ModAPI.IMyHazardReceiver@GetPosition)|Gets world position<br /><br />_Inherited from [IMyHazardReceiver](Sandbox.ModAPI.IMyHazardReceiver)_|
|[HasAnyComsumableEffect(IEnumerable<MyEntityStatRegenEffect>)](Sandbox.Game.Components.MyEntityStatComponent@HasAnyComsumableEffect)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](Sandbox.Game.Components.MyEntityStatComponent@Init)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](Sandbox.Game.Components.MyEntityStatComponent@IsSerialized)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](Sandbox.Game.Components.MyEntityStatComponent@OnAddedToContainer)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](Sandbox.Game.Components.MyEntityStatComponent@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[OnBeforeRemovedFromContainer()](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@OnBeforeRemovedFromContainer)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](Sandbox.Game.Components.MyEntityStatComponent@Serialize)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[TryGetStat(MyStringHash, out MyEntityStat)](Sandbox.Game.Components.MyEntityStatComponent@TryGetStat)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[UpdateAfterSimulation()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateAfterSimulation)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateAfterSimulation10()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateAfterSimulation10)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateAfterSimulation100()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateAfterSimulation100)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateAfterSimulationParallel()](Sandbox.Game.Components.MyEntityStatComponent@UpdateAfterSimulationParallel)|_Inherited from [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)_|
|[UpdateAfterSimulationParallel()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateAfterSimulationParallel)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateBeforeSimulation()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateBeforeSimulation)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateBeforeSimulation100()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateBeforeSimulation100)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateBeforeSimulationParallel()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateBeforeSimulationParallel)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateOnceBeforeFrame()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateOnceBeforeFrame)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateSimulate()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateSimulate)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent) ˃ [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent) ˃ [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)  
* [IMyHazardReceiver](Sandbox.ModAPI.IMyHazardReceiver)  
* IMyUpdatingEntityComponent <sub>prohibited</sub>

