**Assembly:** Sandbox.Game.dll

```csharp
public class MyResourceDistributorComponent: MyEntityComponentBase, IMyComponentBase, IMyEntityComponentBase, IMyResourceDistributorComponent
```

## Fields

|Member|Description|
|---|---|
|[static ElectricityId](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@ElectricityId)||
|[static HydrogenId](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@HydrogenId)||
|[static OxygenId](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@OxygenId)||
|[static ShowTrace](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@ShowTrace)|For debugging purposes. Enables trace messages and watches for this instance.|
|[static WaterId](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@WaterId)||
|[DebugName](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@DebugName)||

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnPowerGenerationChanged](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@OnPowerGenerationChanged)||
|[SystemChanged](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@SystemChanged)|Event raised when any element of this system is changed, requiring the system to update.|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnPowerGenerationChanged](VRage.Game.ModAPI.IMyResourceDistributorComponent@OnPowerGenerationChanged)|Called when power generation status changed<br /><br />_Inherited from [IMyResourceDistributorComponent](VRage.Game.ModAPI.IMyResourceDistributorComponent)_|

## Properties

|Member|Description|
|---|---|
|[static SinkGroupPrioritiesTotal](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@SinkGroupPrioritiesTotal)||
|[static SinkSubtypesToPriority](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@SinkSubtypesToPriority)||
|[ComponentTypeDebugString](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@ComponentTypeDebugString)||
|[ResourceState](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@ResourceState)||
|[SourcesEnabled](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@SourcesEnabled)||
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
|[ResourceState](VRage.Game.ModAPI.IMyResourceDistributorComponent@ResourceState)|Gets current resource state<br /><br />_Inherited from [IMyResourceDistributorComponent](VRage.Game.ModAPI.IMyResourceDistributorComponent)_|
|[SourcesEnabled](VRage.Game.ModAPI.IMyResourceDistributorComponent@SourcesEnabled)|Gets if first found resources has enabled ResourceSource<br /><br />_Inherited from [IMyResourceDistributorComponent](VRage.Game.ModAPI.IMyResourceDistributorComponent)_|

## Constructors

|Member|Description|
|---|---|
|[MyResourceDistributorComponent(string)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static Clear()](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@Clear)||
|[static GetConveyorEndpointBlock(IMyEntity)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@GetConveyorEndpointBlock)||
|[static IsConveyorConnectionRequiredTotal(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@IsConveyorConnectionRequiredTotal)||
|[static IsConveyorConnectionRequiredTotal(ref MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@IsConveyorConnectionRequiredTotal)||
|[AddSink(MyResourceSinkComponent)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@AddSink)||
|[AddSource(MyResourceSourceComponent)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@AddSource)||
|[ChangeSourcesState(MyDefinitionId, MyMultipleEnabledEnum, long, MyCubeGrid)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@ChangeSourcesState)||
|[ClearData()](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@ClearData)||
|[ConveyorSystem_OnPoweredChanged()](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@ConveyorSystem_OnPoweredChanged)||
|[DebugDraw(MyEntity)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@DebugDraw)||
|[GetElectricalGridsGroups()](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@GetElectricalGridsGroups)||
|[GetElectricalGroupIndex(ref MyDefinitionId, MyCubeGrid)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@GetElectricalGroupIndex)||
|[GetSourceCount(MyDefinitionId, MyStringHash)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@GetSourceCount)||
|[MarkConveyoredResourcesDirty()](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@MarkConveyoredResourcesDirty)||
|[MarkForUpdate()](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@MarkForUpdate)||
|[MaxAvailableResourceByType(MyDefinitionId, MyCubeGrid)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@MaxAvailableResourceByType)||
|[MaxAvailableResourceByType(MyDefinitionId, IMyCubeGrid)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@MaxAvailableResourceByType)||
|[RecomputeResourceDistribution(ref MyDefinitionId, bool)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@RecomputeResourceDistribution)||
|[RemainingFuelTimeByType(MyDefinitionId, MyCubeGrid)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@RemainingFuelTimeByType)|Specify grid when asking for electricity.|
|[RemoveSink(MyResourceSinkComponent, bool, bool)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@RemoveSink)||
|[RemoveSource(MyResourceSourceComponent)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@RemoveSource)||
|[ResourceStateByType(MyDefinitionId, bool, MyCubeGrid)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@ResourceStateByType)|Specify grid when asking for electricity. Electricity is shared only between certain grids.|
|[SetDataDirty(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@SetDataDirty)||
|[SetNeedRecompute(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@SetNeedRecompute)||
|[SetNeedRecomputeAll()](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@SetNeedRecomputeAll)||
|[SourcesEnabledByType(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@SourcesEnabledByType)||
|[TotalRequiredInputByType(MyDefinitionId, MyCubeGrid)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@TotalRequiredInputByType)||
|[TotalRequiredInputByType(MyDefinitionId, IMyCubeGrid)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@TotalRequiredInputByType)||
|[UpdateBeforeSimulation()](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@UpdateBeforeSimulation)||
|[UpdateBeforeSimulation100()](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@UpdateBeforeSimulation100)||
|[UpdateHud(MyHudSinkGroupInfo)](Sandbox.Game.EntityComponents.MyResourceDistributorComponent@UpdateHud)|Computes number of groups that have enough energy to work.|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[MaxAvailableResourceByType(MyDefinitionId, IMyCubeGrid)](VRage.Game.ModAPI.IMyResourceDistributorComponent@MaxAvailableResourceByType)|Gets maximum resource available by resource type<br /><br />_Inherited from [IMyResourceDistributorComponent](VRage.Game.ModAPI.IMyResourceDistributorComponent)_|
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
|[TotalRequiredInputByType(MyDefinitionId, IMyCubeGrid)](VRage.Game.ModAPI.IMyResourceDistributorComponent@TotalRequiredInputByType)|Gets currently needed resource by resource type<br /><br />_Inherited from [IMyResourceDistributorComponent](VRage.Game.ModAPI.IMyResourceDistributorComponent)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)  
* [IMyResourceDistributorComponent](VRage.Game.ModAPI.IMyResourceDistributorComponent)

