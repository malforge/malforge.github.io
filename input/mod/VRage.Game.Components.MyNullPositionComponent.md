**Assembly:** VRage.Game.dll

```csharp
public class MyNullPositionComponent: MyPositionComponentBase, IMyComponentBase, IMyEntityComponentBase
```

## Fields

|Member|Description|
|---|---|
|[static OnReportInvalidMatrix](VRage.Game.Components.MyPositionComponentBase@OnReportInvalidMatrix)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[m_lastParentWorldMatrixCounter](VRage.Game.Components.MyPositionComponentBase@m_lastParentWorldMatrixCounter)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[m_worldMatrixCounter](VRage.Game.Components.MyPositionComponentBase@m_worldMatrixCounter)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[m_worldMatrixDirty](VRage.Game.Components.MyPositionComponentBase@m_worldMatrixDirty)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnLocalAABBChanged](VRage.Game.Components.MyPositionComponentBase@OnLocalAABBChanged)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[OnPositionChanged](VRage.Game.Components.MyPositionComponentBase@OnPositionChanged)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyPositionComponentBase@ComponentTypeDebugString)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)|Sets the local aabb.<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[LocalMatrixRef](VRage.Game.Components.MyPositionComponentBase@LocalMatrixRef)|Gets or sets the local matrix.<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[LocalVolume](VRage.Game.Components.MyPositionComponentBase@LocalVolume)|Sets the local volume.<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[LocalVolumeOffset](VRage.Game.Components.MyPositionComponentBase@LocalVolumeOffset)|Gets or sets the local volume offset.<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[NeedsRecalculateWorldMatrix](VRage.Game.Components.MyPositionComponentBase@NeedsRecalculateWorldMatrix)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Scale](VRage.Game.Components.MyPositionComponentBase@Scale)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[WorldAABB](VRage.Game.Components.MyPositionComponentBase@WorldAABB)|Gets the world aabb.<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[WorldMatrixInvScaled](VRage.Game.Components.MyPositionComponentBase@WorldMatrixInvScaled)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[WorldMatrixNormalizedInv](VRage.Game.Components.MyPositionComponentBase@WorldMatrixNormalizedInv)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[WorldMatrixRef](VRage.Game.Components.MyPositionComponentBase@WorldMatrixRef)|World matrix of this physic object. Use it whenever you want to do world-matrix transformations with this physic objects.<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[WorldVolume](VRage.Game.Components.MyPositionComponentBase@WorldVolume)|Gets the world volume.<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[LocalMatrix](VRage.Game.Components.MyPositionComponentBase@LocalMatrix)|_**Obsolete:** Deprecated, use LocalMatrixRef instead._<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[WorldMatrix](VRage.Game.Components.MyPositionComponentBase@WorldMatrix)|_**Obsolete:** Deprecated, use WorldMatrixRef instead._<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyNullPositionComponent()](VRage.Game.Components.MyNullPositionComponent@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetOrientation()](VRage.Game.Components.MyPositionComponentBase@GetOrientation)|Gets the entity orientation.<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[GetPosition()](VRage.Game.Components.MyPositionComponentBase@GetPosition)|Gets the entity position.<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[GetViewMatrix()](VRage.Game.Components.MyPositionComponentBase@GetViewMatrix)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyPositionComponentBase@OnAddedToContainer)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyPositionComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetLocalMatrix(ref Matrix, object, bool, ref Matrix, bool)](VRage.Game.Components.MyPositionComponentBase@SetLocalMatrix)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[SetLocalMatrix(ref Matrix, object, bool)](VRage.Game.Components.MyPositionComponentBase@SetLocalMatrix)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[SetPosition(Vector3D, object, bool, bool)](VRage.Game.Components.MyPositionComponentBase@SetPosition)|Sets the position.<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[SetWorldMatrix(ref MatrixD, object, bool, bool, bool, bool, bool, bool)](VRage.Game.Components.MyPositionComponentBase@SetWorldMatrix)|Sets the world matrix.<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[ToString()](VRage.Game.Components.MyPositionComponentBase@ToString)|_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[UpdateWorldMatrix(ref MatrixD, object, bool, bool)](VRage.Game.Components.MyPositionComponentBase@UpdateWorldMatrix)|Updates the world matrix (change caused by parent)<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|
|[SetWorldMatrix(MatrixD, object, bool, bool, bool, bool, bool, bool)](VRage.Game.Components.MyPositionComponentBase@SetWorldMatrix)|_**Obsolete:** SetWorldMatrix(MatrixD,...) is deprecated, please use SetWorldMatrix(ref MatrixD,...) instead._<br /><br />_Inherited from [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyPositionComponentBase](VRage.Game.Components.MyPositionComponentBase)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)

