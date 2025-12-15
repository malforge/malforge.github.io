**Assembly:** VRage.Game.dll

```csharp
public interface IMyGui
```

ModAPI interface giving access to GUI

## Events

|Member|Description|
|---|---|
|[GuiControlCreated](VRage.Game.ModAPI.IMyGui@GuiControlCreated)|Event triggered on gui control created.|
|[GuiControlRemoved](VRage.Game.ModAPI.IMyGui@GuiControlRemoved)|Event triggered on gui control removed.|

## Properties

|Member|Description|
|---|---|
|[ActiveGamePlayScreen](VRage.Game.ModAPI.IMyGui@ActiveGamePlayScreen)|Gets the name of the currently open GUI screen.|
|[ChatEntryVisible](VRage.Game.ModAPI.IMyGui@ChatEntryVisible)|Checks if the chat entry box is visible.|
|[GetCurrentScreen](VRage.Game.ModAPI.IMyGui@GetCurrentScreen)|Gets an enum describing the currently open GUI screen.|
|[InteractedEntity](VRage.Game.ModAPI.IMyGui@InteractedEntity)|Gets the entity the player is currently interacting with.|
|[IsCursorVisible](VRage.Game.ModAPI.IMyGui@IsCursorVisible)|Checks if the cursor is visible.|

## Methods

|Member|Description|
|---|---|
|[ChangeInteractedEntity(IMyEntity, bool)](VRage.Game.ModAPI.IMyGui@ChangeInteractedEntity)|Switches the entity the terminal is activated for.|
|[ShowTerminalPage(MyTerminalPageEnum, IMyCharacter, IMyEntity, bool)](VRage.Game.ModAPI.IMyGui@ShowTerminalPage)|Shows the terminal and opens a specific tab.|

**Inheritors:**  
* [MyGuiModHelpers](Sandbox.ModAPI.MyGuiModHelpers)

