**Assembly:** VRage.Game.dll

```csharp
public abstract class MyInventoryBase: MyEntityComponentBase, IMyComponentBase, IMyEntityComponentBase, IMyEventProxy, IMyEventOwner
```

## Fields

|Member|Description|
|---|---|
|[CanPutItems](VRage.Game.Entity.MyInventoryBase@CanPutItems)||
|[IsInModifyInventory](VRage.Game.Entity.MyInventoryBase@IsInModifyInventory)||
|[RemoveEntityOnEmpty](VRage.Game.Entity.MyInventoryBase@RemoveEntityOnEmpty)|Setting this flag to true causes to call Close() on the Entity of Container, when the GetItemsCount() == 0. This causes to remove entity from the world, when this inventory is empty.|

## Events

|Member|Description|
|---|---|
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[AfterModifyFinished](VRage.Game.Entity.MyInventoryBase@AfterModifyFinished)||
|[BeforeContentsChanged](VRage.Game.Entity.MyInventoryBase@BeforeContentsChanged)||
|[ContentsAdded](VRage.Game.Entity.MyInventoryBase@ContentsAdded)||
|[ContentsChanged](VRage.Game.Entity.MyInventoryBase@ContentsChanged)|Called when items were added or removed, or their amount has changed|
|[ContentsRemoved](VRage.Game.Entity.MyInventoryBase@ContentsRemoved)||
|[InventoryContentChanged](VRage.Game.Entity.MyInventoryBase@InventoryContentChanged)||
|[OwnerChanged](VRage.Game.Entity.MyInventoryBase@OwnerChanged)|Called if this inventory changed its owner|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|

## Properties

|Member|Description|
|---|---|
|[AttachSyncToEntity](VRage.Game.Entity.MyInventoryBase@AttachSyncToEntity)||
|[ComponentTypeDebugString](VRage.Game.Entity.MyInventoryBase@ComponentTypeDebugString)||
|[CurrentMass](VRage.Game.Entity.MyInventoryBase@CurrentMass)||
|[CurrentVolume](VRage.Game.Entity.MyInventoryBase@CurrentVolume)||
|[ForcedPriority](VRage.Game.Entity.MyInventoryBase@ForcedPriority)||
|[InventoryId](VRage.Game.Entity.MyInventoryBase@InventoryId)|This is for the purpose of identifying the inventory in aggregates (i.e. "Backpack", "LeftHand", ...)|
|[MaxItemCount](VRage.Game.Entity.MyInventoryBase@MaxItemCount)||
|[MaxMass](VRage.Game.Entity.MyInventoryBase@MaxMass)||
|[MaxVolume](VRage.Game.Entity.MyInventoryBase@MaxVolume)||
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
|[MyInventoryBase(string)](VRage.Game.Entity.MyInventoryBase@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Add(IMyInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@Add)||
|[AddItems(MyFixedPoint, MyObjectBuilder_Base)](VRage.Game.Entity.MyInventoryBase@AddItems)|Adds item to inventory|
|[ApplyChanges(List<MyComponentChange>)](VRage.Game.Entity.MyInventoryBase@ApplyChanges)||
|[ComputeAmountThatFits(MyDefinitionId, float, float)](VRage.Game.Entity.MyInventoryBase@ComputeAmountThatFits)||
|[ConsumeItem(MyDefinitionId, MyFixedPoint, long)](VRage.Game.Entity.MyInventoryBase@ConsumeItem)||
|[CountItems(Dictionary<MyDefinitionId, MyFixedPoint>)](VRage.Game.Entity.MyInventoryBase@CountItems)||
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Entity.MyInventoryBase@Deserialize)||
|[GetInventoryCount()](VRage.Game.Entity.MyInventoryBase@GetInventoryCount)|Returns number of embedded inventories - this inventory can be aggregation of other inventories.|
|[GetItemAmount(MyDefinitionId, MyItemFlags, bool)](VRage.Game.Entity.MyInventoryBase@GetItemAmount)||
|[GetItems()](VRage.Game.Entity.MyInventoryBase@GetItems)||
|[GetItemsCount()](VRage.Game.Entity.MyInventoryBase@GetItemsCount)|Returns the number of items in the inventory. This needs to be overrided, otherwise it returns 0!|
|[IsSerialized()](VRage.Game.Entity.MyInventoryBase@IsSerialized)||
|[ItemsCanBeAdded(MyFixedPoint, IMyInventoryItem)](VRage.Game.Entity.MyInventoryBase@ItemsCanBeAdded)||
|[ItemsCanBeRemoved(MyFixedPoint, IMyInventoryItem)](VRage.Game.Entity.MyInventoryBase@ItemsCanBeRemoved)||
|[IterateInventory(int, int)](VRage.Game.Entity.MyInventoryBase@IterateInventory)|Search for inventory having given search index. Aggregate inventory: Iterates through aggregate inventory until simple inventory with matching index is found. Simple inventory: Returns itself if currentIndex == searchIndex. Usage: searchIndex = index of inventory being searched, leave currentIndex = 0.|
|[OnBeforeContentsChanged()](VRage.Game.Entity.MyInventoryBase@OnBeforeContentsChanged)||
|[OnContentsAdded(MyPhysicalInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@OnContentsAdded)||
|[OnContentsChanged()](VRage.Game.Entity.MyInventoryBase@OnContentsChanged)||
|[OnContentsRemoved(MyPhysicalInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@OnContentsRemoved)||
|[RaiseAfterModifyFinished()](VRage.Game.Entity.MyInventoryBase@RaiseAfterModifyFinished)||
|[RaiseBeforeContentsChanged()](VRage.Game.Entity.MyInventoryBase@RaiseBeforeContentsChanged)||
|[RaiseContentsAdded(MyPhysicalInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@RaiseContentsAdded)||
|[RaiseContentsChanged()](VRage.Game.Entity.MyInventoryBase@RaiseContentsChanged)||
|[RaiseContentsRemoved(MyPhysicalInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@RaiseContentsRemoved)||
|[RaiseInventoryContentChanged(MyPhysicalInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@RaiseInventoryContentChanged)||
|[Remove(IMyInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@Remove)||
|[RemoveItemsOfType(MyFixedPoint, MyDefinitionId, MyItemFlags, bool)](VRage.Game.Entity.MyInventoryBase@RemoveItemsOfType)|Remove items of a given amount and definition|
|[Serialize(bool)](VRage.Game.Entity.MyInventoryBase@Serialize)||
|[ToString()](VRage.Game.Entity.MyInventoryBase@ToString)||
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
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)

**Inheritors:**  
* [MyInventory](Sandbox.Game.MyInventory)

