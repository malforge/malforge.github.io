**Assembly:** VRage.Game.dll

```csharp
public interface IMyEntityComponentBase: IMyComponentBase
```

## Events

|Member|Description|
|---|---|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)||

## Properties

|Member|Description|
|---|---|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)||
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)||
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)||
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|

## Methods

|Member|Description|
|---|---|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)

**Inheritors:**  
* [MyAiBlockComponent](Sandbox.Game.EntityComponents.MyAiBlockComponent)  
* [MyAnimationControllerComponent](VRage.Game.Components.MyAnimationControllerComponent)  
* [MyAreaTriggerComponent](Sandbox.Game.EntityComponents.MyAreaTriggerComponent)  
* [MyAssetModifierComponent](Sandbox.Game.EntityComponents.MyAssetModifierComponent)  
* [MyAtmosphereDetectorComponent](Sandbox.Game.EntityComponents.MyAtmosphereDetectorComponent)  
* [MyAutopilotComponent](Sandbox.Game.EntityComponents.MyAutopilotComponent)  
* [MyBlockingBody](Sandbox.Game.Entities.MyHandToolBase+MyBlockingBody)  
* [MyBlockPosComponent](Sandbox.Game.Entities.MyCubeBlock+MyBlockPosComponent)  
* [MyBlocksPruningStructureComponent](Sandbox.Game.EntityComponents.MyBlocksPruningStructureComponent)  
* [MyCasterComponent](Sandbox.Game.EntityComponents.MyCasterComponent)  
* [MyCharacterComponent](Sandbox.Game.Entities.Character.Components.MyCharacterComponent)  
* [MyCharacterDetectorComponent](Sandbox.Game.Entities.Character.Components.MyCharacterDetectorComponent)  
* [MyCharacterJetpackComponent](Sandbox.Game.Entities.Character.Components.MyCharacterJetpackComponent)  
* [MyCharacterOxygenComponent](Sandbox.Game.Entities.Character.Components.MyCharacterOxygenComponent)  
* [MyCharacterPickupComponent](Sandbox.Game.Entities.Character.Components.MyCharacterPickupComponent)  
* [MyCharacterRagdollComponent](Sandbox.Game.Entities.Character.Components.MyCharacterRagdollComponent)  
* [MyCharacterRaycastDetectorComponent](Sandbox.Game.Entities.Character.Components.MyCharacterRaycastDetectorComponent)  
* [MyCharacterShapecastDetectorComponent](Sandbox.Game.Entities.Character.Components.MyCharacterShapecastDetectorComponent)  
* [MyCharacterSoundComponent](Sandbox.Game.Components.MyCharacterSoundComponent)  
* [MyCharacterStatComponent](Sandbox.Game.Components.MyCharacterStatComponent)  
* [MyCharacterWeaponPositionComponent](Sandbox.Game.Entities.Character.Components.MyCharacterWeaponPositionComponent)  
* [MyCompositeGameLogicComponent](Sandbox.Game.Entities.MyCompositeGameLogicComponent)  
* [MyContainerDropComponent](Sandbox.Game.Components.MyContainerDropComponent)  
* [MyDataBroadcaster](Sandbox.Game.Entities.MyDataBroadcaster)  
* [MyDataReceiver](Sandbox.Game.Entities.MyDataReceiver)  
* [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)  
* [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)  
* [MyEntityInventorySpawnComponent](Sandbox.Game.EntityComponents.MyEntityInventorySpawnComponent)  
* [MyEntityReferenceComponent](Sandbox.Game.EntityComponents.MyEntityReferenceComponent)  
* [MyEntityRespawnComponentBase](Sandbox.Game.EntityComponents.MyEntityRespawnComponentBase)  
* [MyEntityReverbDetectorComponent](Sandbox.Game.EntityComponents.MyEntityReverbDetectorComponent)  
* [MyEntityStatComponent](Sandbox.Game.Components.MyEntityStatComponent)  
* [MyEntityStorageComponent](VRage.Game.Components.MyEntityStorageComponent)  
* [MyEventProxyEntityComponent](Sandbox.Game.EntityComponents.MyEventProxyEntityComponent)  
* [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)  
* [MyGravityProviderComponent](Sandbox.Game.Entities.MyGravityProviderComponent)  
* [MyGridOwnershipComponentBase](Sandbox.Game.EntityComponents.MyGridOwnershipComponentBase)  
* [MyGridTargeting](Sandbox.Game.EntityComponents.MyGridTargeting)  
* [MyHierarchyComponent<TYPE>](VRage.Game.Components.MyHierarchyComponent{TYPE})  
* [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)  
* [MyIngameScriptComponent](Sandbox.Game.EntityComponents.MyIngameScriptComponent)  
* [MyInventory](Sandbox.Game.MyInventory)  
* [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)  
* [MyInventorySpawnComponent](Sandbox.Game.Entities.Character.Components.MyInventorySpawnComponent)  
* [MyMeteorGameLogic](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic)  
* [MyModAPINaturalGravityComponent](Sandbox.Game.Entities.MyModAPINaturalGravityComponent)  
* [MyModelComponent](Sandbox.Game.EntityComponents.MyModelComponent)  
* [MyModStorageComponent](Sandbox.Game.EntityComponents.MyModStorageComponent)  
* [MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)  
* [MyMultiTextPanelComponent](Sandbox.Game.EntityComponents.MyMultiTextPanelComponent)  
* [MyNullGameLogicComponent](VRage.Game.Components.MyNullGameLogicComponent)  
* [MyNullPositionComponent](VRage.Game.Components.MyNullPositionComponent)  
* [MyNullRenderComponent](VRage.Game.Components.MyNullRenderComponent)  
* [MyPathRecorderComponent](Sandbox.Game.EntityComponents.MyPathRecorderComponent)  
* [MyPhysicsComponentBase](VRage.Game.Components.MyPhysicsComponentBase)  
* [MyPositionComponent](VRage.Game.Components.MyPositionComponent)  
* [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)  
* [MyPropellerRenderComponent](Sandbox.Game.Components.MyRenderComponentThrust+MyPropellerRenderComponent)  
* [MyRenderComponent](Sandbox.Game.Components.MyRenderComponent)  
* [MyRenderComponentBase](VRage.Game.Components.MyRenderComponentBase)  
* [MyRenderComponentCharacter](Sandbox.Game.Components.MyRenderComponentCharacter)  
* [MyRenderComponentCubeBlock](Sandbox.Game.Components.MyRenderComponentCubeBlock)  
* [MyRenderComponentCubeGrid](Sandbox.Game.Components.MyRenderComponentCubeGrid)  
* [MyRenderComponentLight](Sandbox.Game.Components.MyRenderComponentLight)  
* [MyRenderComponentReflectorLight](Sandbox.Game.Components.MyRenderComponentReflectorLight)  
* [MyRenderComponentScreenAreas](Sandbox.Game.Components.MyRenderComponentScreenAreas)  
* [MyRenderComponentSkinnedEntity](Sandbox.Game.Components.MyRenderComponentSkinnedEntity)  
* [MyRenderComponentThrust](Sandbox.Game.Components.MyRenderComponentThrust)  
* [MyResourceDistributorComponent](Sandbox.Game.EntityComponents.MyResourceDistributorComponent)  
* [MyResourceSinkComponent](Sandbox.Game.EntityComponents.MyResourceSinkComponent)  
* [MyResourceSinkComponentBase](VRage.Game.Components.MyResourceSinkComponentBase)  
* [MyResourceSourceComponent](Sandbox.Game.EntityComponents.MyResourceSourceComponent)  
* [MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase)  
* [MyShipSoundComponent](Sandbox.Game.EntityComponents.MyShipSoundComponent)  
* [MySphericalNaturalGravityComponent](Sandbox.Game.Entities.MySphericalNaturalGravityComponent)  
* [MySyncComponentBase](VRage.Game.Components.MySyncComponentBase)  
* [MyTargetFocusComponent](Sandbox.Game.EntityComponents.MyTargetFocusComponent)  
* [MyTargetLockingBlockComponent](Sandbox.Game.EntityComponents.MyTargetLockingBlockComponent)  
* [MyTargetLockingComponent](Sandbox.Game.EntityComponents.MyTargetLockingComponent)  
* [MyTimerComponent](Sandbox.Game.Components.MyTimerComponent)  
* [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)  
* [MyUpdateTriggerComponent](Sandbox.Game.Components.MyUpdateTriggerComponent)  
* [MyUpdatingEntityComponent](Sandbox.Game.EntityComponents.MyUpdatingEntityComponent)  
* [MyUseObjectsComponent](Sandbox.Game.Components.MyUseObjectsComponent)  
* [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)

