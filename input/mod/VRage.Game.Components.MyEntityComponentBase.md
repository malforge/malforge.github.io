**Assembly:** VRage.Game.dll

```csharp
public abstract class MyEntityComponentBase: MyComponentBase, IMyComponentBase, IMyEntityComponentBase
```

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)||
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)||
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)||
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)||
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)||
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

## Methods

|Member|Description|
|---|---|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)||
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)||
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)

**Inheritors:**  
* [MyAiBlockComponent](Sandbox.Game.EntityComponents.MyAiBlockComponent)  
* [MyAnimationControllerComponent](VRage.Game.Components.MyAnimationControllerComponent)  
* [MyAssetModifierComponent](Sandbox.Game.EntityComponents.MyAssetModifierComponent)  
* [MyBlocksPruningStructureComponent](Sandbox.Game.EntityComponents.MyBlocksPruningStructureComponent)  
* [MyCasterComponent](Sandbox.Game.EntityComponents.MyCasterComponent)  
* [MyCharacterComponent](Sandbox.Game.Entities.Character.Components.MyCharacterComponent)  
* [MyCharacterPickupComponent](Sandbox.Game.Entities.Character.Components.MyCharacterPickupComponent)  
* [MyCharacterWeaponPositionComponent](Sandbox.Game.Entities.Character.Components.MyCharacterWeaponPositionComponent)  
* [MyContainerDropComponent](Sandbox.Game.Components.MyContainerDropComponent)  
* [MyDataBroadcaster](Sandbox.Game.Entities.MyDataBroadcaster)  
* [MyDataReceiver](Sandbox.Game.Entities.MyDataReceiver)  
* [MyEntityInventorySpawnComponent](Sandbox.Game.EntityComponents.MyEntityInventorySpawnComponent)  
* [MyEntityReferenceComponent](Sandbox.Game.EntityComponents.MyEntityReferenceComponent)  
* [MyEntityRespawnComponentBase](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase)  
* [MyEntityStorageComponent](VRage.Game.Components.MyEntityStorageComponent)  
* [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)  
* [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)  
* [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)  
* [MyGridOwnershipComponentBase](Sandbox.Game.EntityComponents.MyGridOwnershipComponentBase)  
* [MyGridTargeting](Sandbox.Game.EntityComponents.MyGridTargeting)  
* [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)  
* [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)  
* [MyInventorySpawnComponent](Sandbox.Game.Entities.Character.Components.MyInventorySpawnComponent)  
* [MyModelComponent](Sandbox.Game.EntityComponents.MyModelComponent)  
* [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)  
* [MyPhysicsComponentBase](VRage.Game.Components.MyPhysicsComponentBase)  
* [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)  
* [MyRenderComponentBase](VRage.Game.Components.MyRenderComponentBase)  
* [MyResourceDistributorComponent](Sandbox.Game.EntityComponents.MyResourceDistributorComponent)  
* [MyResourceSinkComponentBase](VRage.Game.Components.MyResourceSinkComponentBase)  
* [MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase)  
* [MyShipSoundComponent](Sandbox.Game.EntityComponents.MyShipSoundComponent)  
* [MySyncComponentBase](VRage.Game.Components.MySyncComponentBase)  
* [MyTimerComponent](Sandbox.Game.Components.MyTimerComponent)  
* [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)  
* [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)

