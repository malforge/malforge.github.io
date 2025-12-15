**Assembly:** Sandbox.Game.dll

```csharp
public class MyInventory: MyInventoryBase, IMyComponentBase, IMyEntityComponentBase, IMyEventProxy, IMyEventOwner, IMyInventory, IMyInventory
```

## Fields

|Member|Description|
|---|---|
|[static INVENTORY_CHANGED](Sandbox.Game.MyInventory@INVENTORY_CHANGED)||
|[Constraint](Sandbox.Game.MyInventory@Constraint)|Constraint filtering items added to inventory. If null, everything is allowed. Note that setting this constraint will not affect items already in the inventory.|
|[ExternalMass](Sandbox.Game.MyInventory@ExternalMass)||
|[IsWildlifeAgentInventory](Sandbox.Game.MyInventory@IsWildlifeAgentInventory)||
|[SyncType](Sandbox.Game.MyInventory@SyncType)||
|[UserData](Sandbox.Game.MyInventory@UserData)|Any attached data..|
|[CanPutItems](VRage.Game.Entity.MyInventoryBase@CanPutItems)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[IsInModifyInventory](VRage.Game.Entity.MyInventoryBase@IsInModifyInventory)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[RemoveEntityOnEmpty](VRage.Game.Entity.MyInventoryBase@RemoveEntityOnEmpty)|Setting this flag to true causes to call Close() on the Entity of Container, when the GetItemsCount() == 0. This causes to remove entity from the world, when this inventory is empty.<br /><br />_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|

## Events

|Member|Description|
|---|---|
|[static OnTransferByUser](Sandbox.Game.MyInventory@OnTransferByUser)||
|[static OnAfterAddedToContainer](VRage.Game.Components.MyEntityComponentBase@OnAfterAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnVolumeChanged](Sandbox.Game.MyInventory@OnVolumeChanged)||
|[AfterModifyFinished](VRage.Game.Entity.MyInventoryBase@AfterModifyFinished)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[BeforeContentsChanged](VRage.Game.Entity.MyInventoryBase@BeforeContentsChanged)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.Interfaces.IMyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[BeforeRemovedFromContainer](VRage.Game.Components.MyEntityComponentBase@BeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContentsAdded](VRage.Game.Entity.MyInventoryBase@ContentsAdded)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[ContentsChanged](VRage.Game.Entity.MyInventoryBase@ContentsChanged)|Called when items were added or removed, or their amount has changed<br /><br />_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[ContentsRemoved](VRage.Game.Entity.MyInventoryBase@ContentsRemoved)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[InventoryContentChanged](VRage.Game.Entity.MyInventoryBase@InventoryContentChanged)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[OnVolumeChanged](VRage.Game.ModAPI.IMyInventory@OnVolumeChanged)|Triggers when volume of the inventory is changed<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[OwnerChanged](VRage.Game.Entity.MyInventoryBase@OwnerChanged)|Called if this inventory changed its owner<br /><br />_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|

## Properties

|Member|Description|
|---|---|
|[CargoPercentage](Sandbox.Game.MyInventory@CargoPercentage)|Returns a value in the range [0,1] that indicates how full this inventory is. 0 is empty 1 is full If there are no cargo constraints, will return empty|
|[CurrentMass](Sandbox.Game.MyInventory@CurrentMass)||
|[CurrentVolume](Sandbox.Game.MyInventory@CurrentVolume)||
|[ForcedPriority](Sandbox.Game.MyInventory@ForcedPriority)||
|[InventoryIdx](Sandbox.Game.MyInventory@InventoryIdx)||
|[IsCharacterOwner](Sandbox.Game.MyInventory@IsCharacterOwner)||
|[IsConstrained](Sandbox.Game.MyInventory@IsConstrained)||
|[IsFull](Sandbox.Game.MyInventory@IsFull)||
|[ItemCount](Sandbox.Game.MyInventory@ItemCount)||
|[MaxItemCount](Sandbox.Game.MyInventory@MaxItemCount)||
|[MaxMass](Sandbox.Game.MyInventory@MaxMass)||
|[MaxVolume](Sandbox.Game.MyInventory@MaxVolume)||
|[Owner](Sandbox.Game.MyInventory@Owner)||
|[VolumeFillFactor](Sandbox.Game.MyInventory@VolumeFillFactor)||
|[AttachSyncToEntity](VRage.Game.Entity.MyInventoryBase@AttachSyncToEntity)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[AttachSyncToEntity](VRage.Game.Components.MyEntityComponentBase@AttachSyncToEntity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[CanPutItems](VRage.Game.ModAPI.Ingame.IMyInventory@CanPutItems)|Gets if inventory can receive items or not.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[CanPutItems](VRage.Game.ModAPI.IMyInventory@CanPutItems)|Gets or sets if inventory can receive items or not.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[ComponentTypeDebugString](VRage.Game.Components.Interfaces.IMyEntityComponentBase@ComponentTypeDebugString)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[ComponentTypeDebugString](VRage.Game.Entity.MyInventoryBase@ComponentTypeDebugString)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[ComponentTypeDebugString](VRage.Game.Components.MyEntityComponentBase@ComponentTypeDebugString)|Name of the base component type for debug purposes (e.g.: "Position")<br /><br />_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[Container](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Container)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Container](VRage.Game.Components.MyEntityComponentBase@Container)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[ContainerBase](VRage.Game.Components.Interfaces.IMyComponentBase@ContainerBase)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[ContainerBase](VRage.Game.Components.MyComponentBase@ContainerBase)|This cannot be named Container to not conflict with the definition of Container in MyEntityComponentBase.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[CurrentMass](VRage.Game.ModAPI.Ingame.IMyInventory@CurrentMass)|Returns total mass of items inside this inventory in Kg.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[CurrentMass](VRage.Game.Entity.MyInventoryBase@CurrentMass)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[CurrentVolume](VRage.Game.ModAPI.Ingame.IMyInventory@CurrentVolume)|Returns total volume of items inside this inventory in m^3.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[CurrentVolume](VRage.Game.Entity.MyInventoryBase@CurrentVolume)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[Entity](VRage.Game.Components.Interfaces.IMyEntityComponentBase@Entity)|_Inherited from [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)_|
|[Entity](VRage.Game.Components.MyEntityComponentBase@Entity)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[FailedOnSceneAdd](VRage.Game.Components.MyComponentBase@FailedOnSceneAdd)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[ForcedPriority](VRage.Game.Entity.MyInventoryBase@ForcedPriority)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[InventoryId](VRage.Game.Entity.MyInventoryBase@InventoryId)|This is for the purpose of identifying the inventory in aggregates (i.e. "Backpack", "LeftHand", ...)<br /><br />_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[IsFull](VRage.Game.ModAPI.Ingame.IMyInventory@IsFull)|Determines if inventory is absolutely full.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[ItemCount](VRage.Game.ModAPI.Ingame.IMyInventory@ItemCount)|Returns number of occupied inventory slots.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[MaxItemCount](VRage.Game.Entity.MyInventoryBase@MaxItemCount)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[MaxMass](VRage.Game.Entity.MyInventoryBase@MaxMass)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[MaxVolume](VRage.Game.ModAPI.Ingame.IMyInventory@MaxVolume)|Sets maximum volume of items this inventory can contain in m^3.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[MaxVolume](VRage.Game.Entity.MyInventoryBase@MaxVolume)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[Owner](VRage.Game.ModAPI.Ingame.IMyInventory@Owner)|Returns entity this inventory belongs to.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[Owner](VRage.Game.ModAPI.IMyInventory@Owner)|Returns entity this inventory belongs to.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.Interfaces.IMyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[RemoveExistingComponentOnNewInsert](VRage.Game.Components.MyComponentBase@RemoveExistingComponentOnNewInsert)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[VolumeFillFactor](VRage.Game.ModAPI.Ingame.IMyInventory@VolumeFillFactor)|Gets the current volume fill factor of the inventory<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|

## Constructors

|Member|Description|
|---|---|
|[MyInventory()](Sandbox.Game.MyInventory@.ctor)||
|[MyInventory(float, Vector3, MyInventoryFlags)](Sandbox.Game.MyInventory@.ctor)||
|[MyInventory(float, float, Vector3, MyInventoryFlags)](Sandbox.Game.MyInventory@.ctor)||
|[MyInventory(MyFixedPoint, MyFixedPoint, Vector3, MyInventoryFlags)](Sandbox.Game.MyInventory@.ctor)||
|[MyInventory(MyFixedPoint, MyFixedPoint, MyInventoryFlags, List<MyPhysicalInventoryItem>)](Sandbox.Game.MyInventory@.ctor)||
|[MyInventory(MyObjectBuilder_InventoryDefinition, MyInventoryFlags)](Sandbox.Game.MyInventory@.ctor)||
|[MyInventoryBase(string)](VRage.Game.Entity.MyInventoryBase@.ctor)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|

## Methods

|Member|Description|
|---|---|
|[static GetItemVolumeAndMass(MyDefinitionId, out float, out float)](Sandbox.Game.MyInventory@GetItemVolumeAndMass)||
|[static ShowCantConsume()](Sandbox.Game.MyInventory@ShowCantConsume)||
|[static Transfer(MyInventory, MyInventory, MyDefinitionId, MyItemFlags, MyFixedPoint?, bool)](Sandbox.Game.MyInventory@Transfer)||
|[static Transfer(MyInventory, MyInventory, uint, int, MyFixedPoint?, bool)](Sandbox.Game.MyInventory@Transfer)||
|[static TransferAll(MyInventory, MyInventory)](Sandbox.Game.MyInventory@TransferAll)||
|[static TransferByPlanner(MyInventory, MyInventory, SerializableDefinitionId, MyItemFlags, MyFixedPoint?, bool)](Sandbox.Game.MyInventory@TransferByPlanner)||
|[static TransferByUser(MyInventory, MyInventory, uint, int, MyFixedPoint?)](Sandbox.Game.MyInventory@TransferByUser)||
|[static TryConsumeItem(MyCharacter, MyInventory, MyDefinitionId, out bool, bool)](Sandbox.Game.MyInventory@TryConsumeItem)||
|[static TryTransferAll(MyInventory, MyInventory)](Sandbox.Game.MyInventory@TryTransferAll)||
|[Add(IMyInventoryItem, MyFixedPoint)](Sandbox.Game.MyInventory@Add)||
|[AddBlocks(MyCubeBlockDefinition, MyFixedPoint)](Sandbox.Game.MyInventory@AddBlocks)||
|[AddItemClient(int, MyPhysicalInventoryItem)](Sandbox.Game.MyInventory@AddItemClient)||
|[AddItems(MyFixedPoint, MyObjectBuilder_Base)](Sandbox.Game.MyInventory@AddItems)||
|[ApplyChanges(List<MyComponentChange>)](Sandbox.Game.MyInventory@ApplyChanges)||
|[CanItemsBeAdded(MyFixedPoint, MyDefinitionId)](Sandbox.Game.MyInventory@CanItemsBeAdded)||
|[CanItemsBeAdded(MyFixedPoint, MyDefinitionId, MyFixedPoint, MyFixedPoint, MyFixedPoint, MyFixedPoint)](Sandbox.Game.MyInventory@CanItemsBeAdded)||
|[ChangeItemClient(MyPhysicalInventoryItem, int)](Sandbox.Game.MyInventory@ChangeItemClient)||
|[CheckConstraint(MyDefinitionId)](Sandbox.Game.MyInventory@CheckConstraint)||
|[Clear(bool)](Sandbox.Game.MyInventory@Clear)||
|[ClearItems()](Sandbox.Game.MyInventory@ClearItems)||
|[ComputeAmountThatFits(MyDefinitionId, float, float)](Sandbox.Game.MyInventory@ComputeAmountThatFits)||
|[ComputeAmountThatFits(MyBlueprintDefinitionBase)](Sandbox.Game.MyInventory@ComputeAmountThatFits)||
|[ConsumeItem(MyDefinitionId, MyFixedPoint, long)](Sandbox.Game.MyInventory@ConsumeItem)||
|[ContainItems(MyFixedPoint, MyObjectBuilder_PhysicalObject)](Sandbox.Game.MyInventory@ContainItems)||
|[ContainItems(MyFixedPoint?, MyDefinitionId, MyItemFlags)](Sandbox.Game.MyInventory@ContainItems)||
|[CountItems(Dictionary<MyDefinitionId, MyFixedPoint>)](Sandbox.Game.MyInventory@CountItems)||
|[DebugAddItems(MyFixedPoint, MyObjectBuilder_Base)](Sandbox.Game.MyInventory@DebugAddItems)||
|[Deserialize(MyObjectBuilder_ComponentBase)](Sandbox.Game.MyInventory@Deserialize)||
|[DropItem(int, MyFixedPoint)](Sandbox.Game.MyInventory@DropItem)||
|[DropItemById(uint, MyFixedPoint)](Sandbox.Game.MyInventory@DropItemById)||
|[Empty()](Sandbox.Game.MyInventory@Empty)||
|[FilterItemsUsingConstraint()](Sandbox.Game.MyInventory@FilterItemsUsingConstraint)||
|[FindFreeSlotSpace(MyDefinitionId, IMyInventoryItemAdapter)](Sandbox.Game.MyInventory@FindFreeSlotSpace)||
|[FindItem(MyDefinitionId)](Sandbox.Game.MyInventory@FindItem)||
|[FindItem(Func<MyPhysicalInventoryItem, bool>)](Sandbox.Game.MyInventory@FindItem)||
|[FindUsableItem(MyDefinitionId)](Sandbox.Game.MyInventory@FindUsableItem)|This will try to find the first item that can be use. This means, if durability is enabled on items, it will look for first item with durability HP > 0, if this is disabled, this will behave the same as FindItem method|
|[FixInventoryVolume(float)](Sandbox.Game.MyInventory@FixInventoryVolume)||
|[GenerateContent(MyContainerTypeDefinition)](Sandbox.Game.MyInventory@GenerateContent)||
|[GetFlags()](Sandbox.Game.MyInventory@GetFlags)||
|[GetInventoryCount()](Sandbox.Game.MyInventory@GetInventoryCount)|Returns number of embedded inventories - this inventory can be aggregation of other inventories.|
|[GetItemAmount(MyDefinitionId, MyItemFlags, bool)](Sandbox.Game.MyInventory@GetItemAmount)||
|[GetItemAt(int)](Sandbox.Game.MyInventory@GetItemAt)||
|[GetItemByID(uint)](Sandbox.Game.MyInventory@GetItemByID)||
|[GetItemByIndex(int)](Sandbox.Game.MyInventory@GetItemByIndex)||
|[GetItemIndexById(uint)](Sandbox.Game.MyInventory@GetItemIndexById)||
|[GetItems()](Sandbox.Game.MyInventory@GetItems)||
|[GetItemsCount()](Sandbox.Game.MyInventory@GetItemsCount)||
|[GetObjectBuilder()](Sandbox.Game.MyInventory@GetObjectBuilder)||
|[Init(MyObjectBuilder_Inventory)](Sandbox.Game.MyInventory@Init)||
|[Init(MyComponentDefinitionBase)](Sandbox.Game.MyInventory@Init)||
|[IsItemAt(int)](Sandbox.Game.MyInventory@IsItemAt)||
|[IsUniqueId(uint)](Sandbox.Game.MyInventory@IsUniqueId)||
|[ItemsCanBeAdded(MyFixedPoint, IMyInventoryItem)](Sandbox.Game.MyInventory@ItemsCanBeAdded)||
|[ItemsCanBeRemoved(MyFixedPoint, IMyInventoryItem)](Sandbox.Game.MyInventory@ItemsCanBeRemoved)||
|[IterateInventory(int, int)](Sandbox.Game.MyInventory@IterateInventory)|Search for inventory having given search index. Aggregate inventory: Iterates through aggregate inventory until simple inventory with matching index is found. Simple inventory: Returns itself if currentIndex == searchIndex. Usage: searchIndex = index of inventory being searched, leave currentIndex = 0.|
|[ModifyContent(MyPhysicalInventoryItem, Action<MyObjectBuilder_PhysicalObject>, bool)](Sandbox.Game.MyInventory@ModifyContent)||
|[ModifyContentForRifle(MyPhysicalInventoryItem, Action<MyObjectBuilder_PhysicalObject>, bool)](Sandbox.Game.MyInventory@ModifyContentForRifle)|Other way of ModifyContent, it is created specifically for MyAutomaticRifleGun because of complexity of callbacks. Instead it would not force sync|
|[ModifyDatapad(int, uint, string, string)](Sandbox.Game.MyInventory@ModifyDatapad)||
|[OnAddedToContainer()](Sandbox.Game.MyInventory@OnAddedToContainer)||
|[OnBeforeContentsChanged()](Sandbox.Game.MyInventory@OnBeforeContentsChanged)||
|[OnContentsAdded(MyPhysicalInventoryItem, MyFixedPoint)](Sandbox.Game.MyInventory@OnContentsAdded)||
|[OnContentsChanged()](Sandbox.Game.MyInventory@OnContentsChanged)||
|[OnContentsRemoved(MyPhysicalInventoryItem, MyFixedPoint)](Sandbox.Game.MyInventory@OnContentsRemoved)||
|[PickupItem(MyFloatingObject, MyFixedPoint)](Sandbox.Game.MyInventory@PickupItem)||
|[RecordConsumedFood(MyFixedPoint, SerializableDefinitionId, ulong)](Sandbox.Game.MyInventory@RecordConsumedFood)||
|[Refresh()](Sandbox.Game.MyInventory@Refresh)||
|[Remove(IMyInventoryItem, MyFixedPoint)](Sandbox.Game.MyInventory@Remove)||
|[RemoveItemClient(uint)](Sandbox.Game.MyInventory@RemoveItemClient)||
|[RemoveItems(uint, MyFixedPoint?, bool, bool, MatrixD?, Action<MyDefinitionId, MyEntity>, bool)](Sandbox.Game.MyInventory@RemoveItems)||
|[RemoveItemsAt(int, MyFixedPoint?, bool, bool, bool)](Sandbox.Game.MyInventory@RemoveItemsAt)||
|[RemoveItemsOfType(MyFixedPoint, MyObjectBuilder_PhysicalObject, bool, bool)](Sandbox.Game.MyInventory@RemoveItemsOfType)||
|[RemoveItemsOfType(MyFixedPoint, MyDefinitionId, MyItemFlags, bool)](Sandbox.Game.MyInventory@RemoveItemsOfType)||
|[ResetVolume()](Sandbox.Game.MyInventory@ResetVolume)||
|[Serialize(bool)](Sandbox.Game.MyInventory@Serialize)||
|[SetFlags(MyInventoryFlags)](Sandbox.Game.MyInventory@SetFlags)||
|[TakeFloatingBag(MyCargoContainerInventoryBagEntity)](Sandbox.Game.MyInventory@TakeFloatingBag)||
|[TakeFloatingObject(MyFloatingObject)](Sandbox.Game.MyInventory@TakeFloatingObject)||
|[TransferItemFrom(MyInventory, int, int?, bool?, MyFixedPoint?)](Sandbox.Game.MyInventory@TransferItemFrom)||
|[UpdateItem(MyDefinitionId, uint?, float?, float?)](Sandbox.Game.MyInventory@UpdateItem)||
|[UpdateItemAmoutClient(uint, MyFixedPoint, float)](Sandbox.Game.MyInventory@UpdateItemAmoutClient)||
|[Add(IMyInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@Add)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[AddItems(MyFixedPoint, MyObjectBuilder_PhysicalObject, int)](VRage.Game.ModAPI.IMyInventory@AddItems)|Adds item to inventory. Doesn't do all checks inside. Call [CanAddItemAmount(IMyInventoryItem, MyFixedPoint)](VRage.Game.ModAPI.IMyInventory@CanAddItemAmount) before this function<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[AddItems(MyFixedPoint, MyObjectBuilder_Base)](VRage.Game.Entity.MyInventoryBase@AddItems)|Adds item to inventory<br /><br />_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[ApplyChanges(List<MyComponentChange>)](VRage.Game.Entity.MyInventoryBase@ApplyChanges)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[CanAddItemAmount(IMyInventoryItem, MyFixedPoint)](VRage.Game.ModAPI.IMyInventory@CanAddItemAmount)|Gets whether item could be added into inventory, but doesn't add it Checks: - Inserting volume - Inventory can receive items - Inventory filter can<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[CanItemsBeAdded(MyFixedPoint, MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@CanItemsBeAdded)|Determines if given amount of items fits into this inventory on top of existing items.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[CanTransferItemTo(IMyInventory, MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@CanTransferItemTo)|Determines if there is working conveyor connection for item of give type to be transferred to other inventory.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[Clear(bool)](VRage.Game.ModAPI.IMyInventory@Clear)|Remove all items from inventory<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[ComputeAmountThatFits(MyDefinitionId, float, float)](VRage.Game.Entity.MyInventoryBase@ComputeAmountThatFits)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[ConsumeItem(MyDefinitionId, MyFixedPoint, long)](VRage.Game.Entity.MyInventoryBase@ConsumeItem)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[ContainItems(MyFixedPoint, MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@ContainItems)|Determines if there is at least given amount of items of given type contained inside this inventory.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[CountItems(Dictionary<MyDefinitionId, MyFixedPoint>)](VRage.Game.Entity.MyInventoryBase@CountItems)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Deserialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Entity.MyInventoryBase@Deserialize)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[Deserialize(MyObjectBuilder_ComponentBase)](VRage.Game.Components.MyComponentBase@Deserialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[Empty()](VRage.Game.ModAPI.IMyInventory@Empty)|Gets if inventory is empty<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[FindItem(MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@FindItem)|Tries to find an item of given type inside this inventory.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[FindItem(SerializableDefinitionId)](VRage.Game.ModAPI.IMyInventory@FindItem)|Finds first item stack, whose content matching provided id<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[GetAcceptedItems(List<MyItemType>, Func<MyItemType, bool>)](VRage.Game.ModAPI.Ingame.IMyInventory@GetAcceptedItems)|Returns all items this inventory accepts.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[GetAs<T>()](VRage.Game.Components.Interfaces.IMyComponentBase@GetAs{T})|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[GetAs<T>()](VRage.Game.Components.MyComponentBase@GetAs{T})|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[GetInventoryCount()](VRage.Game.Entity.MyInventoryBase@GetInventoryCount)|Returns number of embedded inventories - this inventory can be aggregation of other inventories.<br /><br />_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[GetItemAmount(MyItemType)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItemAmount)|Sums up total amount of items of given type contained inside this inventory.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[GetItemAmount(MyDefinitionId, MyItemFlags, bool)](VRage.Game.Entity.MyInventoryBase@GetItemAmount)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[GetItemAt(int)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItemAt)|Returns info about item at give position.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[GetItemByID(uint)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItemByID)|Returns info about item contained inside this inventory.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[GetItemByID(uint)](VRage.Game.ModAPI.IMyInventory@GetItemByID)|Gets item by id<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[GetItems(List<MyInventoryItem>, Func<MyInventoryItem, bool>)](VRage.Game.ModAPI.Ingame.IMyInventory@GetItems)|Collects all items present inside this inventory and returns snapshot of the current inventory state.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[GetItems()](VRage.Game.Entity.MyInventoryBase@GetItems)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[GetItemsCount()](VRage.Game.Entity.MyInventoryBase@GetItemsCount)|Returns the number of items in the inventory. This needs to be overrided, otherwise it returns 0!<br /><br />_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.Interfaces.IMyComponentBase@Init)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Init(MyComponentDefinitionBase)](VRage.Game.Components.MyComponentBase@Init)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[IsConnectedTo(IMyInventory)](VRage.Game.ModAPI.Ingame.IMyInventory@IsConnectedTo)|Checks if two inventories are connected.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[IsItemAt(int)](VRage.Game.ModAPI.Ingame.IMyInventory@IsItemAt)|Determines if there is any item on given inventory slot.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[IsSerialized()](VRage.Game.Components.Interfaces.IMyComponentBase@IsSerialized)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[IsSerialized()](VRage.Game.Entity.MyInventoryBase@IsSerialized)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[IsSerialized()](VRage.Game.Components.MyComponentBase@IsSerialized)|Tells the component container serializer whether this component should be saved<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[ItemsCanBeAdded(MyFixedPoint, IMyInventoryItem)](VRage.Game.Entity.MyInventoryBase@ItemsCanBeAdded)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[ItemsCanBeRemoved(MyFixedPoint, IMyInventoryItem)](VRage.Game.Entity.MyInventoryBase@ItemsCanBeRemoved)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[IterateInventory(int, int)](VRage.Game.Entity.MyInventoryBase@IterateInventory)|Search for inventory having given search index. Aggregate inventory: Iterates through aggregate inventory until simple inventory with matching index is found. Simple inventory: Returns itself if currentIndex == searchIndex. Usage: searchIndex = index of inventory being searched, leave currentIndex = 0.<br /><br />_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[OnAddedToContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyEntityComponentBase@OnAddedToContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnAddedToContainer()](VRage.Game.Components.MyComponentBase@OnAddedToContainer)|Gets called after the container of this component changes<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnAddedToScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnAddedToScene()](VRage.Game.Components.MyComponentBase@OnAddedToScene)|CH: TOOD: Be careful! This does not get called if the component is added to a container that is in the scene already!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnBeforeContentsChanged()](VRage.Game.Entity.MyInventoryBase@OnBeforeContentsChanged)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.Interfaces.IMyComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyEntityComponentBase@OnBeforeRemovedFromContainer)|_Inherited from [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase)_|
|[OnBeforeRemovedFromContainer()](VRage.Game.Components.MyComponentBase@OnBeforeRemovedFromContainer)|Gets called before the removal of this component from a container<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[OnContentsAdded(MyPhysicalInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@OnContentsAdded)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[OnContentsChanged()](VRage.Game.Entity.MyInventoryBase@OnContentsChanged)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[OnContentsRemoved(MyPhysicalInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@OnContentsRemoved)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.Interfaces.IMyComponentBase@OnRemovedFromScene)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[OnRemovedFromScene()](VRage.Game.Components.MyComponentBase@OnRemovedFromScene)|CH: TOOD: Be careful! This does not get called if the component is removed from a container that is still in the scene!<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[RaiseAfterModifyFinished()](VRage.Game.Entity.MyInventoryBase@RaiseAfterModifyFinished)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[RaiseBeforeContentsChanged()](VRage.Game.Entity.MyInventoryBase@RaiseBeforeContentsChanged)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[RaiseContentsAdded(MyPhysicalInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@RaiseContentsAdded)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[RaiseContentsChanged()](VRage.Game.Entity.MyInventoryBase@RaiseContentsChanged)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[RaiseContentsRemoved(MyPhysicalInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@RaiseContentsRemoved)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[RaiseInventoryContentChanged(MyPhysicalInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@RaiseInventoryContentChanged)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[Remove(IMyInventoryItem, MyFixedPoint)](VRage.Game.Entity.MyInventoryBase@Remove)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[RemoveItemAmount(IMyInventoryItem, MyFixedPoint)](VRage.Game.ModAPI.IMyInventory@RemoveItemAmount)|Remove<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[RemoveItems(uint, MyFixedPoint?, bool, bool)](VRage.Game.ModAPI.IMyInventory@RemoveItems)|Removes item by itemId<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[RemoveItemsAt(int, MyFixedPoint?, bool, bool)](VRage.Game.ModAPI.IMyInventory@RemoveItemsAt)|Removes items at exact inventory index<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[RemoveItemsOfType(MyFixedPoint, MyObjectBuilder_PhysicalObject, bool)](VRage.Game.ModAPI.IMyInventory@RemoveItemsOfType)|Removes amount for specified item type from inventory<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[RemoveItemsOfType(MyFixedPoint, SerializableDefinitionId, MyItemFlags, bool)](VRage.Game.ModAPI.IMyInventory@RemoveItemsOfType)|Removes amount for specified item type from inventory<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[RemoveItemsOfType(MyFixedPoint, MyDefinitionId, MyItemFlags, bool)](VRage.Game.Entity.MyInventoryBase@RemoveItemsOfType)|Remove items of a given amount and definition<br /><br />_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[Serialize(bool)](VRage.Game.Components.Interfaces.IMyComponentBase@Serialize)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[Serialize(bool)](VRage.Game.Entity.MyInventoryBase@Serialize)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[Serialize(bool)](VRage.Game.Components.MyComponentBase@Serialize)|_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.Interfaces.IMyComponentBase@SetContainer)|_Inherited from [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)_|
|[SetContainer(IMyComponentContainer)](VRage.Game.Components.MyComponentBase@SetContainer)|Sets the container of this component. Note that the component is not added to the container here! Therefore, use MyComponentContainer.Add(...) method and it will in turn call this method. Actually, you should seldom have the need to call this method yourself.<br /><br />_Inherited from [MyComponentBase](VRage.Game.Components.MyComponentBase)_|
|[ToString()](VRage.Game.Entity.MyInventoryBase@ToString)|_Inherited from [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)_|
|[TransferItemFrom(IMyInventory, MyInventoryItem, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemFrom)|Attempts to transfer item from one inventory to another.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[TransferItemFrom(IMyInventory, int, int?, bool?, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemFrom)|Attempts to transfer item from one inventory to another.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[TransferItemFrom(IMyInventory, int, int?, bool?, MyFixedPoint?, bool)](VRage.Game.ModAPI.IMyInventory@TransferItemFrom)|Transfer item from one inventory to another<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[TransferItemFrom(IMyInventory, IMyInventoryItem, MyFixedPoint)](VRage.Game.ModAPI.IMyInventory@TransferItemFrom)|Transfer item from one inventory to another<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[TransferItemTo(IMyInventory, MyInventoryItem, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemTo)|Attempts to transfer item from one inventory to another.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[TransferItemTo(IMyInventory, int, int?, bool?, MyFixedPoint?)](VRage.Game.ModAPI.Ingame.IMyInventory@TransferItemTo)|Attempts to transfer item from one inventory to another.<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)_|
|[TransferItemTo(IMyInventory, int, int?, bool?, MyFixedPoint?, bool)](VRage.Game.ModAPI.IMyInventory@TransferItemTo)|Transfer item from one inventory to another<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|
|[GetItems()](VRage.Game.ModAPI.IMyInventory@GetItems)|_**Obsolete:** Use non-allocating GetItems overload_<br /><br />_Inherited from [IMyInventory](VRage.Game.ModAPI.IMyInventory)_|

**Inheritance:**   [MyComponentBase](VRage.Game.Components.MyComponentBase) ˃ [MyEntityComponentBase](VRage.Game.Components.MyEntityComponentBase) ˃ [MyInventoryBase](VRage.Game.Entity.MyInventoryBase)

**Implements:**  
* [IMyComponentBase](VRage.Game.Components.Interfaces.IMyComponentBase)  
* [IMyEntityComponentBase](VRage.Game.Components.Interfaces.IMyEntityComponentBase)  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)  
* [IMyInventory](VRage.Game.ModAPI.IMyInventory)  
* [IMyInventory](VRage.Game.ModAPI.Ingame.IMyInventory)

