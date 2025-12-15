**Assembly:** VRage.Game.dll

```csharp
public abstract class MyResourceSinkComponentBase: MyEntityComponentBase, IMyComponentBase, IMyEntityComponentBase, IMyResourceSinkComponent
```

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[AcceptedResources](VRage.Game.Components.MyResourceSinkComponentBase@AcceptedResources)||
|[TemporaryConnectedEntity](VRage.Game.Components.MyResourceSinkComponentBase@TemporaryConnectedEntity)||
|[AcceptedResources](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@AcceptedResources)|_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[TemporaryConnectedEntity](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@TemporaryConnectedEntity)|_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|

## Methods

|Member|Description|
|---|---|
|[CurrentInputByType(MyDefinitionId)](VRage.Game.Components.MyResourceSinkComponentBase@CurrentInputByType)||
|[IsPowerAvailable(MyDefinitionId, float)](VRage.Game.Components.MyResourceSinkComponentBase@IsPowerAvailable)||
|[IsPoweredByType(MyDefinitionId)](VRage.Game.Components.MyResourceSinkComponentBase@IsPoweredByType)||
|[MaxRequiredInputByType(MyDefinitionId)](VRage.Game.Components.MyResourceSinkComponentBase@MaxRequiredInputByType)||
|[RequiredInputByType(MyDefinitionId)](VRage.Game.Components.MyResourceSinkComponentBase@RequiredInputByType)||
|[SetInputFromDistributor(MyDefinitionId, float, bool, bool)](VRage.Game.Components.MyResourceSinkComponentBase@SetInputFromDistributor)||
|[SetMaxRequiredInputByType(MyDefinitionId, float)](VRage.Game.Components.MyResourceSinkComponentBase@SetMaxRequiredInputByType)||
|[SetRequiredInputByType(MyDefinitionId, float)](VRage.Game.Components.MyResourceSinkComponentBase@SetRequiredInputByType)||
|[SetRequiredInputFuncByType(MyDefinitionId, Func<float>)](VRage.Game.Components.MyResourceSinkComponentBase@SetRequiredInputFuncByType)||
|[SuppliedRatioByType(MyDefinitionId)](VRage.Game.Components.MyResourceSinkComponentBase@SuppliedRatioByType)||
|[CurrentInputByType(MyDefinitionId)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@CurrentInputByType)|_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsPowerAvailable(MyDefinitionId, float)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@IsPowerAvailable)|_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|
|[IsPoweredByType(MyDefinitionId)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@IsPoweredByType)|_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[MaxRequiredInputByType(MyDefinitionId)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@MaxRequiredInputByType)|_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[RequiredInputByType(MyDefinitionId)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@RequiredInputByType)|_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetInputFromDistributor(MyDefinitionId, float, bool, bool)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@SetInputFromDistributor)|_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|
|[SetMaxRequiredInputByType(MyDefinitionId, float)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@SetMaxRequiredInputByType)|_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|
|[SetRequiredInputByType(MyDefinitionId, float)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@SetRequiredInputByType)|_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|
|[SetRequiredInputFuncByType(MyDefinitionId, Func<float>)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@SetRequiredInputFuncByType)|Change the required input function (callback) for given type of resource. It does not call it immediately to update required input value.<br /><br />_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|
|[SuppliedRatioByType(MyDefinitionId)](VRage.Game.Components.Interfaces.IMyResourceSinkComponent@SuppliedRatioByType)|_Inherited from [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)  
* [IMyResourceSinkComponent](VRage.Game.Components.Interfaces.IMyResourceSinkComponent)

**Inheritors:**  
* [MyResourceSinkComponent](Sandbox.Game.EntityComponents.MyResourceSinkComponent)

