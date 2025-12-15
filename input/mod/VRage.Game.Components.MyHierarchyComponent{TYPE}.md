**Assembly:** VRage.Game.dll

```csharp
public class MyHierarchyComponent<TYPE>: MyHierarchyComponentBase, IMyComponentBase, IMyEntityComponentBase
```

## Fields

|Member|Description|
|---|---|
|[QueryAABBImpl](VRage.Game.Components.MyHierarchyComponent{TYPE}@QueryAABBImpl)||
|[QueryLineImpl](VRage.Game.Components.MyHierarchyComponent{TYPE}@QueryLineImpl)||
|[QuerySphereImpl](VRage.Game.Components.MyHierarchyComponent{TYPE}@QuerySphereImpl)||
|[ChildId](VRage.Game.Components.MyHierarchyComponentBase@ChildId)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnChildRemoved](VRage.Game.Components.MyHierarchyComponentBase@OnChildRemoved)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[OnParentChanged](VRage.Game.Components.MyHierarchyComponentBase@OnParentChanged)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Children](VRage.Game.Components.MyHierarchyComponentBase@Children)|Gets the children collection.<br /><br />_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[ChildrenNeedingWorldMatrix](VRage.Game.Components.MyHierarchyComponentBase@ChildrenNeedingWorldMatrix)|Gets the children collection for spatial updates.<br /><br />_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyHierarchyComponentBase@ComponentTypeDebugString)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Parent](VRage.Game.Components.MyHierarchyComponentBase@Parent)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyHierarchyComponent()](VRage.Game.Components.MyHierarchyComponent{TYPE}@.ctor)||
|[MyHierarchyComponentBase()](VRage.Game.Components.MyHierarchyComponentBase@.ctor)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|

## Methods

|Member|Description|
|---|---|
|[QueryAABB(ref BoundingBoxD, List<TYPE>)](VRage.Game.Components.MyHierarchyComponent{TYPE}@QueryAABB)||
|[QueryLine(ref LineD, List<MyLineSegmentOverlapResult<TYPE>>)](VRage.Game.Components.MyHierarchyComponent{TYPE}@QueryLine)||
|[QuerySphere(ref BoundingSphereD, List<TYPE>)](VRage.Game.Components.MyHierarchyComponent{TYPE}@QuerySphere)||
|[AddChild(IMyEntity, bool, bool)](VRage.Game.Components.MyHierarchyComponentBase@AddChild)|Adds the child.<br /><br />_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[AddChildWithMatrix(IMyEntity, ref Matrix, bool)](VRage.Game.Components.MyHierarchyComponentBase@AddChildWithMatrix)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[Delete()](VRage.Game.Components.MyHierarchyComponentBase@Delete)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyHierarchyComponentBase@Deserialize)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetChildrenRecursive(HashSet<IMyEntity>)](VRage.Game.Components.MyHierarchyComponentBase@GetChildrenRecursive)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[GetTopMostParent(Type)](VRage.Game.Components.MyHierarchyComponentBase@GetTopMostParent)|Return top most parent of this entity<br /><br />_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyHierarchyComponentBase@IsSerialized)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyHierarchyComponentBase@OnAddedToScene)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyHierarchyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[RemoveByJN(MyHierarchyComponentBase)](VRage.Game.Components.MyHierarchyComponentBase@RemoveByJN)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[RemoveChild(IMyEntity, bool)](VRage.Game.Components.MyHierarchyComponentBase@RemoveChild)|Removes the child.<br /><br />_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyHierarchyComponentBase@Serialize)|_Inherited from [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyHierarchyComponentBase](VRage.Game.Components.MyHierarchyComponentBase)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)

