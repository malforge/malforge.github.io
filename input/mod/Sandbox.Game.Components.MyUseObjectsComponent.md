**Assembly:** Sandbox.Game.dll

```csharp
public class MyUseObjectsComponent: MyUseObjectsComponentBase, IMyComponentBase, IMyEntityComponentBase
```

## Fields

|Member|Description|
|---|---|
|[DetectorInteractiveObjects](Sandbox.Game.Components.MyUseObjectsComponent@DetectorInteractiveObjects)||

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[DetectorPhysics](Sandbox.Game.Components.MyUseObjectsComponent@DetectorPhysics)||
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyUseObjectsComponentBase@ComponentTypeDebugString)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[DetectorPhysics](VRage.Game.Components.MyUseObjectsComponentBase@DetectorPhysics)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyUseObjectsComponent()](Sandbox.Game.Components.MyUseObjectsComponent@.ctor)||

## Methods

|Member|Description|
|---|---|
|[AddDetector(string, Matrix)](Sandbox.Game.Components.MyUseObjectsComponent@AddDetector)||
|[Deserialize(MyObjectBuilder_ComponentBase)](Sandbox.Game.Components.MyUseObjectsComponent@Deserialize)||
|[GetDetectorTransformation(IMyUseObject)](Sandbox.Game.Components.MyUseObjectsComponent@GetDetectorTransformation)||
|[GetInteractiveObject(uint)](Sandbox.Game.Components.MyUseObjectsComponent@GetInteractiveObject)||
|[GetInteractiveObject(string)](Sandbox.Game.Components.MyUseObjectsComponent@GetInteractiveObject)||
|[GetInteractiveObjects<T>(List<T>)](Sandbox.Game.Components.MyUseObjectsComponent@GetInteractiveObjects{T})||
|[Init(MyComponentDefinitionBase)](Sandbox.Game.Components.MyUseObjectsComponent@Init)||
|[IsSerialized()](Sandbox.Game.Components.MyUseObjectsComponent@IsSerialized)||
|[LoadDetectorsFromModel()](Sandbox.Game.Components.MyUseObjectsComponent@LoadDetectorsFromModel)||
|[OnAddedToScene()](Sandbox.Game.Components.MyUseObjectsComponent@OnAddedToScene)||
|[PositionChanged(MyPositionComponentBase)](Sandbox.Game.Components.MyUseObjectsComponent@PositionChanged)||
|[ProcessComponentToUseObjectsAndDistances(ref Dictionary<IMyUseObject, Tuple`2>, Vector3D, Vector3, object)](Sandbox.Game.Components.MyUseObjectsComponent@ProcessComponentToUseObjectsAndDistances)||
|[RaycastDetector(IMyUseObject, Vector3D, Vector3D, out float)](Sandbox.Game.Components.MyUseObjectsComponent@RaycastDetector)||
|[RaycastDetectors(Vector3D, Vector3D, out float)](Sandbox.Game.Components.MyUseObjectsComponent@RaycastDetectors)||
|[RecreatePhysics()](Sandbox.Game.Components.MyUseObjectsComponent@RecreatePhysics)||
|[RemoveDetector(uint)](Sandbox.Game.Components.MyUseObjectsComponent@RemoveDetector)||
|[Serialize(bool)](Sandbox.Game.Components.MyUseObjectsComponent@Serialize)||
|[SetUseObjectIDs(uint, int)](Sandbox.Game.Components.MyUseObjectsComponent@SetUseObjectIDs)||
|[AddDetector(string, Matrix)](VRage.Game.Components.MyUseObjectsComponentBase@AddDetector)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[ClearPhysics()](VRage.Game.Components.MyUseObjectsComponentBase@ClearPhysics)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetDetectors(string)](VRage.Game.Components.MyUseObjectsComponentBase@GetDetectors)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[GetDetectorTransformation(IMyUseObject)](VRage.Game.Components.MyUseObjectsComponentBase@GetDetectorTransformation)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[GetInteractiveObject(uint)](VRage.Game.Components.MyUseObjectsComponentBase@GetInteractiveObject)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[GetInteractiveObject(string)](VRage.Game.Components.MyUseObjectsComponentBase@GetInteractiveObject)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[GetInteractiveObjects<T>(List<T>)](VRage.Game.Components.MyUseObjectsComponentBase@GetInteractiveObjects{T})|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[LoadDetectorsFromModel()](VRage.Game.Components.MyUseObjectsComponentBase@LoadDetectorsFromModel)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyUseObjectsComponentBase@OnAddedToScene)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyUseObjectsComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyUseObjectsComponentBase@OnRemovedFromScene)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[PositionChanged(MyPositionComponentBase)](VRage.Game.Components.MyUseObjectsComponentBase@PositionChanged)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[ProcessComponentToUseObjectsAndDistances(ref Dictionary<IMyUseObject, Tuple`2>, Vector3D, Vector3, object)](VRage.Game.Components.MyUseObjectsComponentBase@ProcessComponentToUseObjectsAndDistances)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[RaycastDetector(IMyUseObject, Vector3D, Vector3D, out float)](VRage.Game.Components.MyUseObjectsComponentBase@RaycastDetector)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[RaycastDetectors(Vector3D, Vector3D)](VRage.Game.Components.MyUseObjectsComponentBase@RaycastDetectors)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[RaycastDetectors(Vector3D, Vector3D, out float)](VRage.Game.Components.MyUseObjectsComponentBase@RaycastDetectors)|Determine whether the given ray intersects any detector. If so, returns the parametric value of the point of first intersection. PARAMATER IS NOT DISTANCE!<br /><br />_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[RecreatePhysics()](VRage.Game.Components.MyUseObjectsComponentBase@RecreatePhysics)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[RemoveDetector(uint)](VRage.Game.Components.MyUseObjectsComponentBase@RemoveDetector)|_Inherited from [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyUseObjectsComponentBase](VRage.Game.Components.MyUseObjectsComponentBase)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)

