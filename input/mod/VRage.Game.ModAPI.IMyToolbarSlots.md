**Assembly:** VRage.Game.dll

```csharp
public interface IMyToolbarSlots
```

A paged set of toolbar slots. Implemented by [IMyToolbar](VRage.Game.ModAPI.IMyToolbar) for the slots a keyboard player uses, and by [GamepadSlots](VRage.Game.ModAPI.IMyToolbar@GamepadSlots) for the parallel set a gamepad player uses. Both address slots the same way, so code written against this interface works on either.

## Properties

|Member|Description|
|---|---|
|[ItemCount](VRage.Game.ModAPI.IMyToolbarSlots@ItemCount)|Total number of slots, [SlotCount](VRage.Game.ModAPI.IMyToolbarSlots@SlotCount) multiplied by [PageCount](VRage.Game.ModAPI.IMyToolbarSlots@PageCount) .|
|[PageCount](VRage.Game.ModAPI.IMyToolbarSlots@PageCount)|Number of pages.|
|[SlotCount](VRage.Game.ModAPI.IMyToolbarSlots@SlotCount)|Number of slots on a single page.|

## Methods

|Member|Description|
|---|---|
|[BeginChanges()](VRage.Game.ModAPI.IMyToolbarSlots@BeginChanges)|Starts a batch of slot assignments. Chain calls onto the result and finish with [Apply()](VRage.Game.ModAPI.IMyToolbarChangeBuilder@Apply) , which applies the lot together and, for a block toolbar, sends it to clients as one message. Later calls win where two address the same slot.|
|[GetItems(List<MyToolbarItemInfo>)](VRage.Game.ModAPI.IMyToolbarSlots@GetItems)|Clearsoutputand fills it with one entry per slot, so that list index matches slot index. Empty slots come back as [Empty](VRage.Game.ModAPI.MyToolbarItemKind@Empty) .|
|[Trigger(int)](VRage.Game.ModAPI.IMyToolbarSlots@Trigger)|Runs the item in a slot, as a player pressing it would. A block toolbar is owned by the server, so this runs there and refuses anywhere else; a mod gets itself to the server by sending its own message and calls this from there. What the item does replicates as usual.<br /><br />An item that is not currently available does not run: a block action needs its target to share a grid group with the block owning the toolbar.<br /><br />A slot holding a definition rather than an action - a block to build, a tool - selects it for whoever is at the keyboard. That is the expected thing in single player and nothing useful on a dedicated server, where nobody is.|
|[TryGetItem(int, out MyToolbarItemInfo)](VRage.Game.ModAPI.IMyToolbarSlots@TryGetItem)|Reads what a slot holds. Copies out; nothing in the result tracks later edits.|

**Inheritors:**  
* [IMyToolbar](VRage.Game.ModAPI.IMyToolbar)

