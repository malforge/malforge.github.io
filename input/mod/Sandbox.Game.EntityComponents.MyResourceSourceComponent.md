**Assembly:** Sandbox.Game.dll

```csharp
public class MyResourceSourceComponent: MyResourceSourceComponentBase, IMyComponentBase, IMyEntityComponentBase
```

## Fields

|Member|Description|
|---|---|
|[CountTowardsRemainingEnergyTime](Sandbox.Game.EntityComponents.MyResourceSourceComponent@CountTowardsRemainingEnergyTime)||
|[PreciseMode](Sandbox.Game.EntityComponents.MyResourceSourceComponent@PreciseMode)||

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[HasCapacityRemainingChanged](Sandbox.Game.EntityComponents.MyResourceSourceComponent@HasCapacityRemainingChanged)||
|[MaxOutputChanged](Sandbox.Game.EntityComponents.MyResourceSourceComponent@MaxOutputChanged)||
|[OutputChanged](Sandbox.Game.EntityComponents.MyResourceSourceComponent@OutputChanged)||
|[ProductionEnabledChanged](Sandbox.Game.EntityComponents.MyResourceSourceComponent@ProductionEnabledChanged)||
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[ComponentTypeDebugString](Sandbox.Game.EntityComponents.MyResourceSourceComponent@ComponentTypeDebugString)||
|[CurrentOutput](Sandbox.Game.EntityComponents.MyResourceSourceComponent@CurrentOutput)||
|[DefinedOutput](Sandbox.Game.EntityComponents.MyResourceSourceComponent@DefinedOutput)||
|[Enabled](Sandbox.Game.EntityComponents.MyResourceSourceComponent@Enabled)||
|[Grid](Sandbox.Game.EntityComponents.MyResourceSourceComponent@Grid)||
|[Group](Sandbox.Game.EntityComponents.MyResourceSourceComponent@Group)||
|[HasCapacityRemaining](Sandbox.Game.EntityComponents.MyResourceSourceComponent@HasCapacityRemaining)||
|[IsInfiniteCapacity](Sandbox.Game.EntityComponents.MyResourceSourceComponent@IsInfiniteCapacity)||
|[MaxOutput](Sandbox.Game.EntityComponents.MyResourceSourceComponent@MaxOutput)||
|[ProductionEnabled](Sandbox.Game.EntityComponents.MyResourceSourceComponent@ProductionEnabled)||
|[ProductionToCapacityMultiplier](Sandbox.Game.EntityComponents.MyResourceSourceComponent@ProductionToCapacityMultiplier)||
|[RemainingCapacity](Sandbox.Game.EntityComponents.MyResourceSourceComponent@RemainingCapacity)||
|[ResourceTypes](Sandbox.Game.EntityComponents.MyResourceSourceComponent@ResourceTypes)||
|[TemporaryConnectedEntity](Sandbox.Game.EntityComponents.MyResourceSourceComponent@TemporaryConnectedEntity)||
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
|[MyResourceSourceComponent()](Sandbox.Game.EntityComponents.MyResourceSourceComponent@.ctor)||
|[MyResourceSourceComponent(int)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@.ctor)||

## Methods

|Member|Description|
|---|---|
|[CurrentOutputByType(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@CurrentOutputByType)||
|[DebugDraw(Matrix)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@DebugDraw)||
|[DefinedOutputByType(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@DefinedOutputByType)||
|[HasCapacityRemainingByType(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@HasCapacityRemainingByType)||
|[Init(MyStringHash, MyResourceSourceInfo)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@Init)||
|[Init(MyStringHash, List<MyResourceSourceInfo>)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@Init)||
|[MaxOutputByType(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@MaxOutputByType)||
|[MaxOutputUnlimitedByCapacity(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@MaxOutputUnlimitedByCapacity)||
|[OnProductionEnabledChanged(MyDefinitionId?)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@OnProductionEnabledChanged)|Do not use this unless absolutely necessary.|
|[ProductionEnabledByType(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@ProductionEnabledByType)||
|[ProductionToCapacityMultiplierByType(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@ProductionToCapacityMultiplierByType)||
|[RemainingCapacityByType(MyDefinitionId)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@RemainingCapacityByType)||
|[SetMaxOutput(float)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@SetMaxOutput)||
|[SetMaxOutputByType(MyDefinitionId, float)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@SetMaxOutputByType)||
|[SetOutput(float)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@SetOutput)||
|[SetOutputByType(MyDefinitionId, float)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@SetOutputByType)||
|[SetProductionEnabledByType(MyDefinitionId, bool)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@SetProductionEnabledByType)||
|[SetRemainingCapacityByType(MyDefinitionId, float)](Sandbox.Game.EntityComponents.MyResourceSourceComponent@SetRemainingCapacityByType)||
|[ToString()](Sandbox.Game.EntityComponents.MyResourceSourceComponent@ToString)||
|[CurrentOutputByType(MyDefinitionId)](VRage.Game.Components.MyResourceSourceComponentBase@CurrentOutputByType)|Currently used power output of the producer in MW or litres/h.<br /><br />_Inherited from [MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase)_|
|[DefinedOutputByType(MyDefinitionId)](VRage.Game.Components.MyResourceSourceComponentBase@DefinedOutputByType)|Max resource output defined in definition in MW or litres/h.<br /><br />_Inherited from [MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[MaxOutputByType(MyDefinitionId)](VRage.Game.Components.MyResourceSourceComponentBase@MaxOutputByType)|Maximum power output of the producer in MW or litres/h.<br /><br />_Inherited from [MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase)_|
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
|[ProductionEnabledByType(MyDefinitionId)](VRage.Game.Components.MyResourceSourceComponentBase@ProductionEnabledByType)|Resource production is enabled<br /><br />_Inherited from [MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyResourceSourceComponentBase](VRage.Game.Components.MyResourceSourceComponentBase)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)

