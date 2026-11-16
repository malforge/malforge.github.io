**Assembly:** VRage.Game.dll

```csharp
public interface IMyToolbar: IMyToolbarSlots
```

A toolbar a player can configure: a block's action toolbar, a cockpit's own toolbar, or a player's character toolbar. Obtained from a block's [IMyToolbarProvider](VRage.Game.ModAPI.IMyToolbarProvider) component, and for players from [CharacterToolbar](VRage.Game.ModAPI.IMyPlayer@CharacterToolbar) , which accepts writes, or [Toolbar](VRage.Game.ModAPI.IMyPlayer@Toolbar) , the session's read only copy. The inherited members address the slots a keyboard player uses; the gamepad slots are a parallel set reached through [GamepadSlots](VRage.Game.ModAPI.IMyToolbar@GamepadSlots) .

## Properties

|Member|Description|
|---|---|
|[GamepadSlots](VRage.Game.ModAPI.IMyToolbar@GamepadSlots)|The parallel set of slots a gamepad player uses. Null on a character toolbar, which has no gamepad slots a player can reach; check for it before use.<br /><br /> [SlotCount](VRage.Game.ModAPI.IMyToolbarSlots@SlotCount) is always four, whatever this toolbar's is, because a page maps to the four directions of a pad rather than to the owning block. Pages grow as a player fills them and only those up to the last filled slot survive a save, so do not store a gamepad slot index between sessions.|
|[Type](VRage.Game.ModAPI.IMyToolbar@Type)|The toolbar's type. Action toolbars are [ButtonPanel](VRage.Game.MyToolbarType@ButtonPanel) ; a cockpit's own toolbar reports [Ship](VRage.Game.MyToolbarType@Ship) or [Seat](VRage.Game.MyToolbarType@Seat) , its build toolbar [BuildCockpit](VRage.Game.MyToolbarType@BuildCockpit) , and a character toolbar [Character](VRage.Game.MyToolbarType@Character) .|
|[ItemCount](VRage.Game.ModAPI.IMyToolbarSlots@ItemCount)|Total number of slots, [SlotCount](VRage.Game.ModAPI.IMyToolbarSlots@SlotCount) multiplied by [PageCount](VRage.Game.ModAPI.IMyToolbarSlots@PageCount) .<br /><br />_Inherited from [IMyToolbarSlots](VRage.Game.ModAPI.IMyToolbarSlots)_|
|[PageCount](VRage.Game.ModAPI.IMyToolbarSlots@PageCount)|Number of pages.<br /><br />_Inherited from [IMyToolbarSlots](VRage.Game.ModAPI.IMyToolbarSlots)_|
|[SlotCount](VRage.Game.ModAPI.IMyToolbarSlots@SlotCount)|Number of slots on a single page.<br /><br />_Inherited from [IMyToolbarSlots](VRage.Game.ModAPI.IMyToolbarSlots)_|

## Methods

|Member|Description|
|---|---|
|[GetObjectBuilder()](VRage.Game.ModAPI.IMyToolbar@GetObjectBuilder)|Gets a copy of the entire toolbar, including the gamepad slots and the selected slot.|
|[BeginChanges()](VRage.Game.ModAPI.IMyToolbarSlots@BeginChanges)|Starts a batch of slot assignments. Chain calls onto the result and finish with [Apply()](VRage.Game.ModAPI.IMyToolbarChangeBuilder@Apply) , which applies the lot together and, for a block toolbar, sends it to clients as one message. Later calls win where two address the same slot.<br /><br />_Inherited from [IMyToolbarSlots](VRage.Game.ModAPI.IMyToolbarSlots)_|
|[GetItems(List<MyToolbarItemInfo>)](VRage.Game.ModAPI.IMyToolbarSlots@GetItems)|Clearsoutputand fills it with one entry per slot, so that list index matches slot index. Empty slots come back as [Empty](VRage.Game.ModAPI.MyToolbarItemKind@Empty) .<br /><br />_Inherited from [IMyToolbarSlots](VRage.Game.ModAPI.IMyToolbarSlots)_|
|[Trigger(int)](VRage.Game.ModAPI.IMyToolbarSlots@Trigger)|Runs the item in a slot, as a player pressing it would. A block toolbar is owned by the server, so this runs there and refuses anywhere else; a mod gets itself to the server by sending its own message and calls this from there. What the item does replicates as usual.<br /><br />An item that is not currently available does not run: a block action needs its target to share a grid group with the block owning the toolbar.<br /><br />A slot holding a definition rather than an action - a block to build, a tool - selects it for whoever is at the keyboard. That is the expected thing in single player and nothing useful on a dedicated server, where nobody is.<br /><br />_Inherited from [IMyToolbarSlots](VRage.Game.ModAPI.IMyToolbarSlots)_|
|[TryGetItem(int, out MyToolbarItemInfo)](VRage.Game.ModAPI.IMyToolbarSlots@TryGetItem)|Reads what a slot holds. Copies out; nothing in the result tracks later edits.<br /><br />_Inherited from [IMyToolbarSlots](VRage.Game.ModAPI.IMyToolbarSlots)_|

**Implements:**  
* [IMyToolbarSlots](VRage.Game.ModAPI.IMyToolbarSlots)

