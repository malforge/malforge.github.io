**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyEventComponentWithGui: IMyEventControllerEntityComponent
```

Describes interface of event controller entity component, which requires UI in the terminal panel

## Properties

|Member|Description|
|---|---|
|[IsBlocksListUsed](Sandbox.ModAPI.IMyEventComponentWithGui@IsBlocksListUsed)|Gets whether the block list UI is used|
|[IsConditionSelectionUsed](Sandbox.ModAPI.IMyEventComponentWithGui@IsConditionSelectionUsed)|Gets whether the condition selection UI is used|
|[IsThresholdUsed](Sandbox.ModAPI.IMyEventComponentWithGui@IsThresholdUsed)|Gets whether the threshold UI is used|
|[EventDisplayName](Sandbox.ModAPI.IMyEventControllerEntityComponent@EventDisplayName)|Gets the display name of the event<br /><br />_Inherited from [IMyEventControllerEntityComponent](Sandbox.ModAPI.IMyEventControllerEntityComponent)_|
|[IsSelected](Sandbox.ModAPI.IMyEventControllerEntityComponent@IsSelected)|Gets whether the event is selected in the terminal panel UI<br /><br />_Inherited from [IMyEventControllerEntityComponent](Sandbox.ModAPI.IMyEventControllerEntityComponent)_|
|[UniqueSelectionId](Sandbox.ModAPI.IMyEventControllerEntityComponent@UniqueSelectionId)|Gets the unique id of the event<br /><br />_Inherited from [IMyEventControllerEntityComponent](Sandbox.ModAPI.IMyEventControllerEntityComponent)_|
|[YesNoToolbarNoDescription](Sandbox.ModAPI.IMyEventControllerEntityComponent@YesNoToolbarNoDescription)|No description of the toolbar tooltip<br /><br />_Inherited from [IMyEventControllerEntityComponent](Sandbox.ModAPI.IMyEventControllerEntityComponent)_|
|[YesNoToolbarYesDescription](Sandbox.ModAPI.IMyEventControllerEntityComponent@YesNoToolbarYesDescription)|Yes description of the toolbar tooltip<br /><br />_Inherited from [IMyEventControllerEntityComponent](Sandbox.ModAPI.IMyEventControllerEntityComponent)_|

## Methods

|Member|Description|
|---|---|
|[AddBlocks(List<IMyTerminalBlock>)](Sandbox.ModAPI.IMyEventComponentWithGui@AddBlocks)|Adds the specified block to the monitoring of the event|
|[IsBlockValidForList(IMyTerminalBlock)](Sandbox.ModAPI.IMyEventComponentWithGui@IsBlockValidForList)|Gets the information if the specified block is valid for the block list UI|
|[NotifyValuesChanged()](Sandbox.ModAPI.IMyEventComponentWithGui@NotifyValuesChanged)|Notifies about change of some UI value, which is required for this event|
|[RemoveBlocks(IEnumerable<IMyTerminalBlock>)](Sandbox.ModAPI.IMyEventComponentWithGui@RemoveBlocks)|Removes the specified block from the monitoring|
|[CreateTerminalInterfaceControls<T>()](Sandbox.ModAPI.IMyEventControllerEntityComponent@CreateTerminalInterfaceControls{T})|_Inherited from [IMyEventControllerEntityComponent](Sandbox.ModAPI.IMyEventControllerEntityComponent)_|

**Implements:**  
* [IMyEventControllerEntityComponent](Sandbox.ModAPI.IMyEventControllerEntityComponent)

