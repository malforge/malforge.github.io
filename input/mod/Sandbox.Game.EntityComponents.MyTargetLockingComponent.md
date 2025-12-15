**Assembly:** Sandbox.Game.dll

```csharp
public class MyTargetLockingComponent: MyUpdatingEntityComponent, IMyComponentBase, IMyEntityComponentBase, IMyEventProxy, IMyEventOwner, IMyUpdatingEntityComponent, IMyTargetLockingComponent, IMyDistanceToLockedTarget
```

## Fields

|Member|Description|
|---|---|
|[static LOST_GRID_RETRY_ATTEMPTS](Sandbox.Game.EntityComponents.MyTargetLockingComponent@LOST_GRID_RETRY_ATTEMPTS)||
|[SyncType](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@SyncType)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[DistanceToLockedTargetChanged](Sandbox.Game.EntityComponents.MyTargetLockingComponent@DistanceToLockedTargetChanged)||
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[DistanceToLockedTargetChanged](Sandbox.ModAPI.IMyDistanceToLockedTarget@DistanceToLockedTargetChanged)|Event distance to locked target is changed (block, old value, new value)<br /><br />_Inherited from [IMyDistanceToLockedTarget](Sandbox.ModAPI.IMyDistanceToLockedTarget)_|

## Properties

|Member|Description|
|---|---|
|[ComponentTypeDebugString](Sandbox.Game.EntityComponents.MyTargetLockingComponent@ComponentTypeDebugString)||
|[Definition](Sandbox.Game.EntityComponents.MyTargetLockingComponent@Definition)||
|[DistanceToLockedTarget](Sandbox.Game.EntityComponents.MyTargetLockingComponent@DistanceToLockedTarget)||
|[IsLosingLock](Sandbox.Game.EntityComponents.MyTargetLockingComponent@IsLosingLock)||
|[IsTargetLocked](Sandbox.Game.EntityComponents.MyTargetLockingComponent@IsTargetLocked)||
|[LockingProgressMilliseconds](Sandbox.Game.EntityComponents.MyTargetLockingComponent@LockingProgressMilliseconds)||
|[LockingProgressPercent](Sandbox.Game.EntityComponents.MyTargetLockingComponent@LockingProgressPercent)||
|[LockingTimeRemainingMilliseconds](Sandbox.Game.EntityComponents.MyTargetLockingComponent@LockingTimeRemainingMilliseconds)||
|[TargetData](Sandbox.Game.EntityComponents.MyTargetLockingComponent@TargetData)||
|[TargetEntity](Sandbox.Game.EntityComponents.MyTargetLockingComponent@TargetEntity)||
|[AttachSyncToEntity](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@AttachSyncToEntity)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[DistanceToLockedTarget](Sandbox.ModAPI.IMyDistanceToLockedTarget@DistanceToLockedTarget)|Gets distance to locked target in meters<br /><br />_Inherited from [IMyDistanceToLockedTarget](Sandbox.ModAPI.IMyDistanceToLockedTarget)_|
|[Entity](Sandbox.ModAPI.IMyDistanceToLockedTarget@Entity)|Gets the entity of this interface entity component<br /><br />_Inherited from [IMyDistanceToLockedTarget](Sandbox.ModAPI.IMyDistanceToLockedTarget)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsTargetLocked](Sandbox.Game.EntityComponents.IMyTargetLockingComponent@IsTargetLocked)|_Inherited from [IMyTargetLockingComponent](Sandbox.Game.EntityComponents.IMyTargetLockingComponent)_|
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
|[TargetData](Sandbox.Game.EntityComponents.IMyTargetLockingComponent@TargetData)|_Inherited from [IMyTargetLockingComponent](Sandbox.Game.EntityComponents.IMyTargetLockingComponent)_|
|[TargetEntity](Sandbox.Game.EntityComponents.IMyTargetLockingComponent@TargetEntity)|_Inherited from [IMyTargetLockingComponent](Sandbox.Game.EntityComponents.IMyTargetLockingComponent)_|
|[UpdateParallel](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateParallel)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdateParallelChanged](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdateParallelChanged)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[UpdatingType](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent@UpdatingType)|_Inherited from [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)_|
|[Target](Sandbox.Game.EntityComponents.MyTargetLockingComponent@Target)|_**Obsolete:** ModAPI, dont use in Keen code. In v203 added locking characters. Use TargetEntity instead_|
|[Target](Sandbox.Game.EntityComponents.IMyTargetLockingComponent@Target)|_**Obsolete**_<br /><br />_Inherited from [IMyTargetLockingComponent](Sandbox.Game.EntityComponents.IMyTargetLockingComponent)_|

## Constructors

|Member|Description|
|---|---|
|[MyTargetLockingComponent()](Sandbox.Game.EntityComponents.MyTargetLockingComponent@.ctor)||
|[MyEventProxyEntityComponent()](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@.ctor)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|

## Methods

|Member|Description|
|---|---|
|[static RequestReleaseTargetLock()](Sandbox.Game.EntityComponents.MyTargetLockingComponent@RequestReleaseTargetLock)||
|[Init(MyComponentDefinitionBase)](Sandbox.Game.EntityComponents.MyTargetLockingComponent@Init)||
|[OnAddedToContainer()](Sandbox.Game.EntityComponents.MyTargetLockingComponent@OnAddedToContainer)||
|[OnBeforeRemovedFromContainer()](Sandbox.Game.EntityComponents.MyTargetLockingComponent@OnBeforeRemovedFromContainer)||
|[OnControlledEntityChanged(IMyControllableEntity, IMyControllableEntity)](Sandbox.Game.EntityComponents.MyTargetLockingComponent@OnControlledEntityChanged)||
|[OnLockAcquired()](Sandbox.Game.EntityComponents.MyTargetLockingComponent@OnLockAcquired)||
|[OnLockLost()](Sandbox.Game.EntityComponents.MyTargetLockingComponent@OnLockLost)||
|[OnTargetInfoChanged(SyncBase)](Sandbox.Game.EntityComponents.MyTargetLockingComponent@OnTargetInfoChanged)||
|[OnTargetRequest(MyEntity)](Sandbox.Game.EntityComponents.MyTargetLockingComponent@OnTargetRequest)||
|[ReleaseTargetLock()](Sandbox.Game.EntityComponents.MyTargetLockingComponent@ReleaseTargetLock)||
|[ReleaseTargetLockRequest()](Sandbox.Game.EntityComponents.MyTargetLockingComponent@ReleaseTargetLockRequest)||
|[UpdateAfterSimulation10()](Sandbox.Game.EntityComponents.MyTargetLockingComponent@UpdateAfterSimulation10)||
|[UpdateBeforeSimulation()](Sandbox.Game.EntityComponents.MyTargetLockingComponent@UpdateBeforeSimulation)|Should be called in UpdateBeforeSimulation1 We can let characters to have update 1 as there are only few of them in world|
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
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyDistanceToLockedTarget](Sandbox.ModAPI.IMyDistanceToLockedTarget)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)  
* [IMyTargetLockingComponent](Sandbox.Game.EntityComponents.IMyTargetLockingComponent)  
* IMyUpdatingEntityComponent <sub>prohibited</sub>

