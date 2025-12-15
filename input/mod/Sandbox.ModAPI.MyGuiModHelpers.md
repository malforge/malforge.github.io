**Assembly:** Sandbox.Game.dll

```csharp
public class MyGuiModHelpers: IMyGui
```

## Events

|Member|Description|
|---|---|
|[GuiControlCreated](Sandbox.ModAPI.MyGuiModHelpers@GuiControlCreated)||
|[GuiControlRemoved](Sandbox.ModAPI.MyGuiModHelpers@GuiControlRemoved)||
|[GuiControlCreated](VRage.Game.ModAPI.IMyGui@GuiControlCreated)|Event triggered on gui control created.<br /><br />_Inherited from [IMyGui](VRage.Game.ModAPI.IMyGui)_|
|[GuiControlRemoved](VRage.Game.ModAPI.IMyGui@GuiControlRemoved)|Event triggered on gui control removed.<br /><br />_Inherited from [IMyGui](VRage.Game.ModAPI.IMyGui)_|

## Properties

|Member|Description|
|---|---|
|[ActiveGamePlayScreen](Sandbox.ModAPI.MyGuiModHelpers@ActiveGamePlayScreen)||
|[ChatEntryVisible](Sandbox.ModAPI.MyGuiModHelpers@ChatEntryVisible)||
|[GetCurrentScreen](Sandbox.ModAPI.MyGuiModHelpers@GetCurrentScreen)||
|[InteractedEntity](Sandbox.ModAPI.MyGuiModHelpers@InteractedEntity)||
|[IsCursorVisible](Sandbox.ModAPI.MyGuiModHelpers@IsCursorVisible)||
|[ActiveGamePlayScreen](VRage.Game.ModAPI.IMyGui@ActiveGamePlayScreen)|Gets the name of the currently open GUI screen.<br /><br />_Inherited from [IMyGui](VRage.Game.ModAPI.IMyGui)_|
|[ChatEntryVisible](VRage.Game.ModAPI.IMyGui@ChatEntryVisible)|Checks if the chat entry box is visible.<br /><br />_Inherited from [IMyGui](VRage.Game.ModAPI.IMyGui)_|
|[GetCurrentScreen](VRage.Game.ModAPI.IMyGui@GetCurrentScreen)|Gets an enum describing the currently open GUI screen.<br /><br />_Inherited from [IMyGui](VRage.Game.ModAPI.IMyGui)_|
|[InteractedEntity](VRage.Game.ModAPI.IMyGui@InteractedEntity)|Gets the entity the player is currently interacting with.<br /><br />_Inherited from [IMyGui](VRage.Game.ModAPI.IMyGui)_|
|[IsCursorVisible](VRage.Game.ModAPI.IMyGui@IsCursorVisible)|Checks if the cursor is visible.<br /><br />_Inherited from [IMyGui](VRage.Game.ModAPI.IMyGui)_|

## Constructors

|Member|Description|
|---|---|
|[MyGuiModHelpers()](Sandbox.ModAPI.MyGuiModHelpers@.ctor)||

## Methods

|Member|Description|
|---|---|
|[ChangeInteractedEntity(IMyEntity, bool)](Sandbox.ModAPI.MyGuiModHelpers@ChangeInteractedEntity)||
|[ShowTerminalPage(MyTerminalPageEnum, IMyCharacter, IMyEntity, bool)](Sandbox.ModAPI.MyGuiModHelpers@ShowTerminalPage)||
|[ChangeInteractedEntity(IMyEntity, bool)](VRage.Game.ModAPI.IMyGui@ChangeInteractedEntity)|Switches the entity the terminal is activated for.<br /><br />_Inherited from [IMyGui](VRage.Game.ModAPI.IMyGui)_|
|[ShowTerminalPage(MyTerminalPageEnum, IMyCharacter, IMyEntity, bool)](VRage.Game.ModAPI.IMyGui@ShowTerminalPage)|Shows the terminal and opens a specific tab.<br /><br />_Inherited from [IMyGui](VRage.Game.ModAPI.IMyGui)_|

**Implements:**  
* [IMyGui](VRage.Game.ModAPI.IMyGui)

