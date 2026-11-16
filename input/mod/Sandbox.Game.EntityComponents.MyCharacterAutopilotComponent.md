**Assembly:** Sandbox.Game.dll

```csharp
public class MyCharacterAutopilotComponent: MyUpdatingEntityComponent, IMyComponentBase, IMyEntityComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent, IMyCharacterComponent
```

Jetpack autopilot for NPC characters: flies the character to a world position and holds there. Owns thrust (via the grid-autopilot AI thrust path) and orientation while an order is active. Stop() brakes and holds position rather than disengaging — behavior trees call navigation Stop liberally, and a released jetpack character would free-fall with dampeners off.

## Fields

|Member|Description|
|---|---|
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
|[Character](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@Character)||
|[ComponentTypeDebugString](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@ComponentTypeDebugString)||
|[CurrentAvoidance](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@CurrentAvoidance)|Character-avoidance push last published by the bot's steering, zero once stale. Debug surface.|
|[CurrentLandingHeight](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@CurrentLandingHeight)|Height above the probed surface while a Land order descends; NaN with no probe hit or no Land order. Debug surface.|
|[CurrentLandingSpeedCap](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@CurrentLandingSpeedCap)|Descent speed cap of the landing flare. Debug surface.|
|[CurrentSeekTarget](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@CurrentSeekTarget)|Point the control law is currently steering at (waypoint, spline carrot or follow point). Debug surface.|
|[CurrentWaypointIndex](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@CurrentWaypointIndex)||
|[IsHolding](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@IsHolding)|True once the order has settled into position hold (arrival or Stop), false while still flying.|
|[IsLanding](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@IsLanding)|True while a Land order is descending; a caller stopping the bot leaves that one to finish.|
|[IsOrderActive](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@IsOrderActive)||
|[IsOrderRunning](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@IsOrderRunning)|True while an order is still being flown, i.e. neither settled into a hold nor over.|
|[LastOrderOutcome](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@LastOrderOutcome)|Terminal result of the most recent accepted order. None while an order is still in progress; a rejected order call (no server, no definition, no jetpack) keeps the previous value. Disambiguates the otherwise identical Holding states: an arrival versus a degraded Land/Follow.|
|[OrderSerial](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@OrderSerial)|Changes with every accepted order, so an issuer can tell its own order from one that replaced it.|
|[State](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@State)|Debug surface.|
|[Strategy](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@Strategy)|Debug surface.|
|[AttachSyncToEntity](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@AttachSyncToEntity)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Character](Sandbox.Game.Entities.Character.Components.IMyCharacterComponent@Character)|_Inherited from [IMyCharacterComponent](Sandbox.Game.Entities.Character.Components.IMyCharacterComponent)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
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
|[UpdateParallel](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateParallel)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateParallelChanged](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateParallelChanged)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdatingType](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdatingType)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|

## Constructors

|Member|Description|
|---|---|
|[MyCharacterAutopilotComponent()](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@.ctor)||
|[MyEventProxyEntityComponent()](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@.ctor)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|

## Methods

|Member|Description|
|---|---|
|[FlyTo(Vector3D, MyGravityStrategy, MyEntity)](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@FlyTo)||
|[FlyWaypoints(List<Vector3D>, bool?, MyGravityStrategy)](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@FlyWaypoints)||
|[Follow(MyEntity, float)](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@Follow)|Follows the entity at the given radial distance, velocity-matched while station-keeping. Never self-completes; a dead or closed target degrades to a brake-and-hold.|
|[Init(MyComponentDefinitionBase)](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@Init)||
|[Land()](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@Land)|Descends onto the surface below: descent speed capped by height above terrain, flare to TouchdownSpeed, jetpack off on contact. Zero-g lands along the nearest grid's seat-up axis (mag boots hold on contact); with no grid, no surface, or a touchdown surface steeper than the character's MaxSlope, the order degrades to a brake-and-hold (LastOrderOutcome Degraded). Order intake only — see `MyCharacterAutopilotComponent.FlyTo(Vector3D, MyCharacterAutopilotComponent.MyGravityStrategy, MyEntity)`<sub>prohibited</sub> .|
|[OnBeforeRemovedFromContainer()](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@OnBeforeRemovedFromContainer)||
|[Stop()](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@Stop)|Brake and hold: keeps the AI thrust branch engaged with a zero command, which cancels velocity (5x slowdown envelope) and hovers. Full disengage only on death/removal. Cancels an in-flight order; an already-settled order keeps its recorded outcome.|
|[UpdateBeforeSimulation()](Sandbox.Game.EntityComponents.MyCharacterAutopilotComponent@UpdateBeforeSimulation)||
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@OnBeforeRemovedFromContainer)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnCharacterDead()](Sandbox.Game.Entities.Character.Components.IMyCharacterComponent@OnCharacterDead)|_Inherited from [IMyCharacterComponent](Sandbox.Game.Entities.Character.Components.IMyCharacterComponent)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[UpdateAfterSimulation()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateAfterSimulation)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateAfterSimulation10()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateAfterSimulation10)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateAfterSimulation100()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateAfterSimulation100)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateAfterSimulationParallel()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateAfterSimulationParallel)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateBeforeSimulation()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateBeforeSimulation)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateBeforeSimulation100()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateBeforeSimulation100)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateBeforeSimulationParallel()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateBeforeSimulationParallel)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateOnceBeforeFrame()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateOnceBeforeFrame)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateSimulate()](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateSimulate)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent) ˃ [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)

**Implements:**  
* [IMyCharacterComponent](Sandbox.Game.Entities.Character.Components.IMyCharacterComponent)  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)  
* IMyUpdatingEntityComponent <sub>prohibited</sub>

