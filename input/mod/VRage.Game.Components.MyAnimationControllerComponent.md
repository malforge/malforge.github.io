**Assembly:** VRage.Game.dll

```csharp
public class MyAnimationControllerComponent: MyEntityComponentBase, IMyComponentBase, IMyEntityComponentBase
```

Entity component containing animation controller.

## Fields

|Member|Description|
|---|---|
|[CameraDistance](VRage.Game.Components.MyAnimationControllerComponent@CameraDistance)||
|[MainLayerAnimationSpeed](VRage.Game.Components.MyAnimationControllerComponent@MainLayerAnimationSpeed)||
|[OtherLayersAnimationSpeed](VRage.Game.Components.MyAnimationControllerComponent@OtherLayersAnimationSpeed)||
|[ReloadBonesNeeded](VRage.Game.Components.MyAnimationControllerComponent@ReloadBonesNeeded)||

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ActionTriggered](VRage.Game.Components.MyAnimationControllerComponent@ActionTriggered)||
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[BoneAbsoluteTransforms](VRage.Game.Components.MyAnimationControllerComponent@BoneAbsoluteTransforms)||
|[BoneRelativeTransforms](VRage.Game.Components.MyAnimationControllerComponent@BoneRelativeTransforms)||
|[CharacterBones](VRage.Game.Components.MyAnimationControllerComponent@CharacterBones)|Get reference to array of character pack and its contents.|
|[CharacterBonesSorted](VRage.Game.Components.MyAnimationControllerComponent@CharacterBonesSorted)||
|[ComponentTypeDebugString](VRage.Game.Components.MyAnimationControllerComponent@ComponentTypeDebugString)|Name of the component type for debug purposes (e.g.: "Position")|
|[Controller](VRage.Game.Components.MyAnimationControllerComponent@Controller)|Get the animation controller instance.|
|[InverseKinematics](VRage.Game.Components.MyAnimationControllerComponent@InverseKinematics)|Get the instance of inverse kinematics.|
|[LastFrameActions](VRage.Game.Components.MyAnimationControllerComponent@LastFrameActions)||
|[LastRawBoneResult](VRage.Game.Components.MyAnimationControllerComponent@LastRawBoneResult)||
|[SourceId](VRage.Game.Components.MyAnimationControllerComponent@SourceId)||
|[Variables](VRage.Game.Components.MyAnimationControllerComponent@Variables)|Get the variable storage of animation controller instance. Shortcut.|
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

## Constructors

|Member|Description|
|---|---|
|[MyAnimationControllerComponent(MyEntity, Action, IMyTerrainHeightProvider)](VRage.Game.Components.MyAnimationControllerComponent@.ctor)||

## Methods

|Member|Description|
|---|---|
|[ApplyVariables()](VRage.Game.Components.MyAnimationControllerComponent@ApplyVariables)||
|[AttachAnimationEventCallback(Action<List<string>>)](VRage.Game.Components.MyAnimationControllerComponent@AttachAnimationEventCallback)||
|[Clear()](VRage.Game.Components.MyAnimationControllerComponent@Clear)||
|[DetachAnimationEventCallback(Action<List<string>>)](VRage.Game.Components.MyAnimationControllerComponent@DetachAnimationEventCallback)||
|[FindBone(string, out int)](VRage.Game.Components.MyAnimationControllerComponent@FindBone)||
|[FinishUpdate()](VRage.Game.Components.MyAnimationControllerComponent@FinishUpdate)||
|[GetKeyedAnimationTracks(string)](VRage.Game.Components.MyAnimationControllerComponent@GetKeyedAnimationTracks)||
|[MarkAsValid()](VRage.Game.Components.MyAnimationControllerComponent@MarkAsValid)||
|[OnAddedToContainer()](VRage.Game.Components.MyAnimationControllerComponent@OnAddedToContainer)|Component was added in the entity component container.|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyAnimationControllerComponent@OnBeforeRemovedFromContainer)|Component will be removed from entity component container.|
|[SetCharacterBones(MyCharacterBone[], Matrix[], Matrix[])](VRage.Game.Components.MyAnimationControllerComponent@SetCharacterBones)||
|[TriggerAction(MyStringId, String[])](VRage.Game.Components.MyAnimationControllerComponent@TriggerAction)|Trigger an action in the layers specified. If no layers are specified, it is triggered for all instead. If there is a transition having given (non-null) name, it is followed immediatelly. Conditions of transition are ignored. This is a shortcut to Controller.TriggerAction.|
|[Update()](VRage.Game.Components.MyAnimationControllerComponent@Update)||
|[UpdateInverseKinematics()](VRage.Game.Components.MyAnimationControllerComponent@UpdateInverseKinematics)||
|[UpdateTransformations()](VRage.Game.Components.MyAnimationControllerComponent@UpdateTransformations)||
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
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)

