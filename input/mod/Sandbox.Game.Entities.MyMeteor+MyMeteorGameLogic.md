**Assembly:** Sandbox.Game.dll

```csharp
public class MyMeteorGameLogic: MyEntityGameLogic, IMyComponentBase, IMyEntityComponentBase, IMyGameLogicComponent
```

## Fields

|Member|Description|
|---|---|
|[Item](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@Item)||

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnClose](Sandbox.Game.Components.MyEntityGameLogic@OnClose)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[OnClosing](Sandbox.Game.Components.MyEntityGameLogic@OnClosing)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[OnMarkForClose](Sandbox.Game.Components.MyEntityGameLogic@OnMarkForClose)|This event may not be invoked at all, when calling MyEntities.CloseAll, marking is bypassed<br /><br />_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|

## Properties

|Member|Description|
|---|---|
|[Integrity](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@Integrity)||
|[VoxelMaterial](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@VoxelMaterial)||
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Closed](VRage.Game.Components.MyGameLogicComponent@Closed)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyGameLogicComponent@ComponentTypeDebugString)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[EntityUpdate](VRage.Game.Components.MyGameLogicComponent@EntityUpdate)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GameLogic](Sandbox.Game.Components.MyEntityGameLogic@GameLogic)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[MarkedForClose](VRage.Game.Components.MyGameLogicComponent@MarkedForClose)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[ModContext](VRage.Game.Components.MyGameLogicComponent@ModContext)|Returns the mod context this gamelogic belongs to. This can be passed to methods to read content from the mod's directory.<br /><br />_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[NeedsUpdate](VRage.Game.Components.MyGameLogicComponent@NeedsUpdate)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyMeteorGameLogic()](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@.ctor)||
|[MyEntityGameLogic()](Sandbox.Game.Components.MyEntityGameLogic@.ctor)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|

## Methods

|Member|Description|
|---|---|
|[Close()](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@Close)||
|[DoDamage(float, MyStringHash, bool, MyHitInfo?, long, MyStringHash?)](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@DoDamage)||
|[GetObjectBuilder(bool)](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@GetObjectBuilder)||
|[Init(MyObjectBuilder_EntityBase)](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@Init)||
|[MarkForClose()](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@MarkForClose)||
|[OnAddedToContainer()](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@OnAddedToContainer)||
|[OnAddedToScene()](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@OnAddedToScene)||
|[OnDestroy()](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@OnDestroy)||
|[UpdateAfterSimulation()](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@UpdateAfterSimulation)||
|[UpdateBeforeSimulation()](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@UpdateBeforeSimulation)||
|[UpdateBeforeSimulation100()](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@UpdateBeforeSimulation100)||
|[UpdateOnceBeforeFrame()](Sandbox.Game.Entities.MyMeteor+MyMeteorGameLogic@UpdateOnceBeforeFrame)||
|[Close()](Sandbox.Game.Components.MyEntityGameLogic@Close)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[Close()](VRage.Game.Components.MyGameLogicComponent@Close)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetObjectBuilder(bool)](Sandbox.Game.Components.MyEntityGameLogic@GetObjectBuilder)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[GetObjectBuilder(bool)](VRage.Game.Components.MyGameLogicComponent@GetObjectBuilder)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyObjectBuilder_EntityBase)](Sandbox.Game.Components.MyEntityGameLogic@Init)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[Init(StringBuilder, string, MyEntity, float?, string)](Sandbox.Game.Components.MyEntityGameLogic@Init)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[Init(MyObjectBuilder_EntityBase)](VRage.Game.Components.MyGameLogicComponent@Init)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[MarkForClose()](Sandbox.Game.Components.MyEntityGameLogic@MarkForClose)|This method marks this entity for close which means, that Close will be called after all entities are updated<br /><br />_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[MarkForClose()](VRage.Game.Components.MyGameLogicComponent@MarkForClose)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](Sandbox.Game.Components.MyEntityGameLogic@OnAddedToContainer)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[UpdateAfterSimulation()](Sandbox.Game.Components.MyEntityGameLogic@UpdateAfterSimulation)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[UpdateAfterSimulation()](VRage.Game.Components.MyGameLogicComponent@UpdateAfterSimulation)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[UpdateAfterSimulation10()](Sandbox.Game.Components.MyEntityGameLogic@UpdateAfterSimulation10)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[UpdateAfterSimulation10()](VRage.Game.Components.MyGameLogicComponent@UpdateAfterSimulation10)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[UpdateAfterSimulation100()](Sandbox.Game.Components.MyEntityGameLogic@UpdateAfterSimulation100)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[UpdateAfterSimulation100()](VRage.Game.Components.MyGameLogicComponent@UpdateAfterSimulation100)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[UpdateBeforeSimulation()](Sandbox.Game.Components.MyEntityGameLogic@UpdateBeforeSimulation)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[UpdateBeforeSimulation()](VRage.Game.Components.MyGameLogicComponent@UpdateBeforeSimulation)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[UpdateBeforeSimulation10()](Sandbox.Game.Components.MyEntityGameLogic@UpdateBeforeSimulation10)|Called each 10th frame if registered for update10<br /><br />_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[UpdateBeforeSimulation10()](VRage.Game.Components.MyGameLogicComponent@UpdateBeforeSimulation10)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[UpdateBeforeSimulation100()](Sandbox.Game.Components.MyEntityGameLogic@UpdateBeforeSimulation100)|Called each 100th frame if registered for update100<br /><br />_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[UpdateBeforeSimulation100()](VRage.Game.Components.MyGameLogicComponent@UpdateBeforeSimulation100)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[UpdateOnceBeforeFrame()](Sandbox.Game.Components.MyEntityGameLogic@UpdateOnceBeforeFrame)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[UpdateOnceBeforeFrame()](VRage.Game.Components.MyGameLogicComponent@UpdateOnceBeforeFrame)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|
|[UpdatingStopped()](Sandbox.Game.Components.MyEntityGameLogic@UpdatingStopped)|_Inherited from [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)_|
|[UpdatingStopped()](VRage.Game.Components.MyGameLogicComponent@UpdatingStopped)|_Inherited from [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent) ˃ [MyEntityGameLogic](Sandbox.Game.Components.MyEntityGameLogic)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)  
* IMyGameLogicComponent <sub>prohibited</sub>

