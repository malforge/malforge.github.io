**Assembly:** VRage.Game.dll

```csharp
public abstract class MyRenderComponentBase: MyEntityComponentBase, IMyComponentBase, IMyEntityComponentBase
```

## Fields

|Member|Description|
|---|---|
|[static OldBlackToHSV](VRage.Game.Components.MyRenderComponentBase@OldBlackToHSV)||
|[static OldBlueToHSV](VRage.Game.Components.MyRenderComponentBase@OldBlueToHSV)||
|[static OldGrayToHSV](VRage.Game.Components.MyRenderComponentBase@OldGrayToHSV)||
|[static OldGreenToHSV](VRage.Game.Components.MyRenderComponentBase@OldGreenToHSV)||
|[static OldRedToHSV](VRage.Game.Components.MyRenderComponentBase@OldRedToHSV)||
|[static OldWhiteToHSV](VRage.Game.Components.MyRenderComponentBase@OldWhiteToHSV)||
|[static OldYellowToHSV](VRage.Game.Components.MyRenderComponentBase@OldYellowToHSV)||
|[static UNINITIALIZED_IDs](VRage.Game.Components.MyRenderComponentBase@UNINITIALIZED_IDs)||
|[DepthBias](VRage.Game.Components.MyRenderComponentBase@DepthBias)||
|[FadeIn](VRage.Game.Components.MyRenderComponentBase@FadeIn)||
|[FadeOut](VRage.Game.Components.MyRenderComponentBase@FadeOut)||
|[LastMomentUpdateIndex](VRage.Game.Components.MyRenderComponentBase@LastMomentUpdateIndex)||
|[NeedForDrawFromParentChanged](VRage.Game.Components.MyRenderComponentBase@NeedForDrawFromParentChanged)||
|[Transparency](VRage.Game.Components.MyRenderComponentBase@Transparency)||

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[CastShadows](VRage.Game.Components.MyRenderComponentBase@CastShadows)||
|[ColorMaskHsv](VRage.Game.Components.MyRenderComponentBase@ColorMaskHsv)||
|[ComponentTypeDebugString](VRage.Game.Components.MyRenderComponentBase@ComponentTypeDebugString)||
|[DrawInAllCascades](VRage.Game.Components.MyRenderComponentBase@DrawInAllCascades)||
|[DrawOutsideViewDistance](VRage.Game.Components.MyRenderComponentBase@DrawOutsideViewDistance)||
|[EnableColorMaskHsv](VRage.Game.Components.MyRenderComponentBase@EnableColorMaskHsv)||
|[FastCastShadowResolve](VRage.Game.Components.MyRenderComponentBase@FastCastShadowResolve)||
|[MetalnessColorable](VRage.Game.Components.MyRenderComponentBase@MetalnessColorable)||
|[ModelStorage](VRage.Game.Components.MyRenderComponentBase@ModelStorage)|Used by game to store model here. In game this is always of type MyModel. Implementation should only store and return passed object.|
|[NearFlag](VRage.Game.Components.MyRenderComponentBase@NearFlag)||
|[NeedsDraw](VRage.Game.Components.MyRenderComponentBase@NeedsDraw)||
|[NeedsDrawFromParent](VRage.Game.Components.MyRenderComponentBase@NeedsDrawFromParent)||
|[NeedsResolveCastShadow](VRage.Game.Components.MyRenderComponentBase@NeedsResolveCastShadow)||
|[OffsetInVertexShader](VRage.Game.Components.MyRenderComponentBase@OffsetInVertexShader)||
|[ParentIDs](VRage.Game.Components.MyRenderComponentBase@ParentIDs)||
|[PersistentFlags](VRage.Game.Components.MyRenderComponentBase@PersistentFlags)||
|[RenderObjectIDs](VRage.Game.Components.MyRenderComponentBase@RenderObjectIDs)||
|[ShadowBoxLod](VRage.Game.Components.MyRenderComponentBase@ShadowBoxLod)||
|[SkipIfTooSmall](VRage.Game.Components.MyRenderComponentBase@SkipIfTooSmall)||
|[TextureChanges](VRage.Game.Components.MyRenderComponentBase@TextureChanges)||
|[Visible](VRage.Game.Components.MyRenderComponentBase@Visible)||
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

## Methods

|Member|Description|
|---|---|
|[AddRenderObjects()](VRage.Game.Components.MyRenderComponentBase@AddRenderObjects)||
|[Draw()](VRage.Game.Components.MyRenderComponentBase@Draw)||
|[GetDiffuseColor()](VRage.Game.Components.MyRenderComponentBase@GetDiffuseColor)||
|[GetRenderCullingOptions()](VRage.Game.Components.MyRenderComponentBase@GetRenderCullingOptions)||
|[GetRenderFlags()](VRage.Game.Components.MyRenderComponentBase@GetRenderFlags)||
|[GetRenderObjectID()](VRage.Game.Components.MyRenderComponentBase@GetRenderObjectID)||
|[InvalidateRenderObjects()](VRage.Game.Components.MyRenderComponentBase@InvalidateRenderObjects)||
|[IsChild(int)](VRage.Game.Components.MyRenderComponentBase@IsChild)||
|[IsRenderObjectAssigned(int)](VRage.Game.Components.MyRenderComponentBase@IsRenderObjectAssigned)||
|[IsVisible()](VRage.Game.Components.MyRenderComponentBase@IsVisible)||
|[ReleaseRenderObjectID(int)](VRage.Game.Components.MyRenderComponentBase@ReleaseRenderObjectID)||
|[RemoveRenderObjects()](VRage.Game.Components.MyRenderComponentBase@RemoveRenderObjects)||
|[ResizeRenderObjectArray(int)](VRage.Game.Components.MyRenderComponentBase@ResizeRenderObjectArray)||
|[SetParent(int, uint, Matrix?)](VRage.Game.Components.MyRenderComponentBase@SetParent)||
|[SetRenderObjectID(int, uint)](VRage.Game.Components.MyRenderComponentBase@SetRenderObjectID)||
|[SetVisibilityUpdates(bool)](VRage.Game.Components.MyRenderComponentBase@SetVisibilityUpdates)||
|[UpdateRenderEntity(Vector3)](VRage.Game.Components.MyRenderComponentBase@UpdateRenderEntity)||
|[UpdateRenderObject(bool, bool)](VRage.Game.Components.MyRenderComponentBase@UpdateRenderObject)||
|[UpdateRenderObjectLocal(Matrix)](VRage.Game.Components.MyRenderComponentBase@UpdateRenderObjectLocal)||
|[UpdateRenderTextureChanges(Dictionary<MyStringId, MyTextureChange>)](VRage.Game.Components.MyRenderComponentBase@UpdateRenderTextureChanges)||
|[UpdateTransparency()](VRage.Game.Components.MyRenderComponentBase@UpdateTransparency)||
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

**Inheritors:**  
* [MyNullRenderComponent](VRage.Game.Components.MyNullRenderComponent)  
* [MyRenderComponent](Sandbox.Game.Components.MyRenderComponent)

