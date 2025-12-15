**Assembly:** Sandbox.Game.dll

```csharp
public class MyTargetLockingBlockComponent: MyEventProxyEntityComponent, IMyComponentBase, IMyEntityComponentBase, IMyEventProxy, IMyEventOwner, IMyTargetLockingComponent, IMyDistanceToLockedTarget
```

## Fields

|Member|Description|
|---|---|
|[SyncType](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@SyncType)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[DistanceToLockedTargetChanged](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@DistanceToLockedTargetChanged)||
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[DistanceToLockedTargetChanged](Sandbox.ModAPI.IMyDistanceToLockedTarget@DistanceToLockedTargetChanged)|Event distance to locked target is changed (block, old value, new value)<br /><br />_Inherited from [IMyDistanceToLockedTarget](Sandbox.ModAPI.IMyDistanceToLockedTarget)_|

## Properties

|Member|Description|
|---|---|
|[ComponentTypeDebugString](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@ComponentTypeDebugString)||
|[Definition](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@Definition)||
|[DistanceToLockedTarget](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@DistanceToLockedTarget)||
|[IsLosingLock](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@IsLosingLock)||
|[IsTargetLocked](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@IsTargetLocked)||
|[LockingProgressMilliseconds](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@LockingProgressMilliseconds)||
|[LockingProgressPercent](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@LockingProgressPercent)||
|[LockingTimeRemainingMilliseconds](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@LockingTimeRemainingMilliseconds)||
|[TargetData](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@TargetData)||
|[TargetEntity](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@TargetEntity)||
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
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[TargetData](Sandbox.Game.EntityComponents.IMyTargetLockingComponent@TargetData)|_Inherited from [IMyTargetLockingComponent](Sandbox.Game.EntityComponents.IMyTargetLockingComponent)_|
|[TargetEntity](Sandbox.Game.EntityComponents.IMyTargetLockingComponent@TargetEntity)|_Inherited from [IMyTargetLockingComponent](Sandbox.Game.EntityComponents.IMyTargetLockingComponent)_|
|[Target](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@Target)|_**Obsolete:** ModAPI, dont use in Keen code. In v203 added locking characters. Use TargetEntity instead_|
|[Target](Sandbox.Game.EntityComponents.IMyTargetLockingComponent@Target)|_**Obsolete**_<br /><br />_Inherited from [IMyTargetLockingComponent](Sandbox.Game.EntityComponents.IMyTargetLockingComponent)_|

## Constructors

|Member|Description|
|---|---|
|[MyTargetLockingBlockComponent()](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@.ctor)||
|[MyEventProxyEntityComponent()](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent@.ctor)|_Inherited from [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)_|

## Methods

|Member|Description|
|---|---|
|[Init(MyComponentDefinitionBase)](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@Init)||
|[OnAddedToContainer()](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@OnAddedToContainer)||
|[OnBeforeRemovedFromContainer()](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@OnBeforeRemovedFromContainer)||
|[OnTargetInfoChanged(SyncBase)](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@OnTargetInfoChanged)||
|[OnTargetRequest(MyEntity)](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@OnTargetRequest)||
|[ReleaseTargetLock()](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@ReleaseTargetLock)||
|[Update()](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent@Update)||
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

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyDistanceToLockedTarget](Sandbox.ModAPI.IMyDistanceToLockedTarget)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)  
* [IMyTargetLockingComponent](Sandbox.Game.EntityComponents.IMyTargetLockingComponent)

