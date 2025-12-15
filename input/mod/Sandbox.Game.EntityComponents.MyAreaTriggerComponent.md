**Assembly:** Sandbox.Game.dll

```csharp
public class MyAreaTriggerComponent: MyTriggerComponent, IMyComponentBase, IMyEntityComponentBase
```

## Fields

|Member|Description|
|---|---|
|[EntityEntered](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@EntityEntered)||

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[Name](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@Name)||
|[Radius](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@Radius)||
|[SizeX](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@SizeX)||
|[SizeY](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@SizeY)||
|[SizeZ](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@SizeZ)||
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Center](Sandbox.Game.Components.MyTriggerComponent@Center)|Trigger BB center position.<br /><br />_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](Sandbox.Game.Components.MyTriggerComponent@ComponentTypeDebugString)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[CustomDebugColor](Sandbox.Game.Components.MyTriggerComponent@CustomDebugColor)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[Enabled](Sandbox.Game.Components.MyTriggerComponent@Enabled)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OBB](Sandbox.Game.Components.MyTriggerComponent@OBB)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[TriggerAreaType](Sandbox.Game.Components.MyTriggerComponent@TriggerAreaType)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[UpdateFrequency](Sandbox.Game.Components.MyTriggerComponent@UpdateFrequency)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|

## Constructors

|Member|Description|
|---|---|
|[MyAreaTriggerComponent()](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@.ctor)||
|[MyAreaTriggerComponent(string)](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@.ctor)||
|[MyTriggerComponent(TriggerType, uint)](Sandbox.Game.Components.MyTriggerComponent@.ctor)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[MyTriggerComponent()](Sandbox.Game.Components.MyTriggerComponent@.ctor)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|

## Methods

|Member|Description|
|---|---|
|[DebugDraw()](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@DebugDraw)||
|[Deserialize(MyObjectBuilder_ComponentBase)](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@Deserialize)||
|[IsSerialized()](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@IsSerialized)||
|[Serialize(bool)](Sandbox.Game.EntityComponents.MyAreaTriggerComponent@Serialize)||
|[Contains(Vector3D)](Sandbox.Game.Components.MyTriggerComponent@Contains)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[DebugDraw()](Sandbox.Game.Components.MyTriggerComponent@DebugDraw)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](Sandbox.Game.Components.MyTriggerComponent@Deserialize)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Dispose()](Sandbox.Game.Components.MyTriggerComponent@Dispose)|Override for custom trigger disposal before removing.<br /><br />_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](Sandbox.Game.Components.MyTriggerComponent@IsSerialized)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](Sandbox.Game.Components.MyTriggerComponent@OnAddedToContainer)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](Sandbox.Game.Components.MyTriggerComponent@OnAddedToScene)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](Sandbox.Game.Components.MyTriggerComponent@OnBeforeRemovedFromContainer)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](Sandbox.Game.Components.MyTriggerComponent@OnRemovedFromScene)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](Sandbox.Game.Components.MyTriggerComponent@Serialize)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Update()](Sandbox.Game.Components.MyTriggerComponent@Update)|_Inherited from [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyTriggerComponent](Sandbox.Game.Components.MyTriggerComponent)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)

