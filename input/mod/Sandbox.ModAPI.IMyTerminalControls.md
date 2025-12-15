**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyTerminalControls
```

This interface allows you to query, add or remove terminal controls for a block. The terminal controls are the controls that appear in the terminal screen when you select a block. You may add new controls, remove existing controls, or modify existing controls.

## Events

|Member|Description|
|---|---|
|[CustomActionGetter](Sandbox.ModAPI.IMyTerminalControls@CustomActionGetter)|This event allows you to modify the list of actions available when a user wants to select an action for a block in the toolbar. Modifying the list in this event modifies the list displayed to the user so that you can customize it in specific situations (like blocks with different subtypes, or even on specific blocks by entityId)|
|[CustomControlGetter](Sandbox.ModAPI.IMyTerminalControls@CustomControlGetter)|This event allows you to modify the list of controls that the game displays when a user selects a block. Each time terminal controls are enumerated for a block, this delegate is called, which allows you to modify the control list directly, and remove/add as you see fit before the controls are displayed. This is to allow fine grain control of the controls being displayed, so you can display only controls you want to in specific situations (like blocks with different subtypes, or even on specific blocks by entityId)|

## Methods

|Member|Description|
|---|---|
|[AddAction<TBlock>(IMyTerminalAction)](Sandbox.ModAPI.IMyTerminalControls@AddAction{TBlock})||
|[AddControl<TBlock>(IMyTerminalControl)](Sandbox.ModAPI.IMyTerminalControls@AddControl{TBlock})||
|[CreateAction<TBlock>(string)](Sandbox.ModAPI.IMyTerminalControls@CreateAction{TBlock})||
|[CreateControl<TControl, TBlock>(string)](Sandbox.ModAPI.IMyTerminalControls@CreateControl{TControl,TBlock})||
|[CreateProperty<TValue, TBlock>(string)](Sandbox.ModAPI.IMyTerminalControls@CreateProperty{TValue,TBlock})||
|[GetActions<TBlock>(out List<IMyTerminalAction>)](Sandbox.ModAPI.IMyTerminalControls@GetActions{TBlock})||
|[GetControls<TBlock>(out List<IMyTerminalControl>)](Sandbox.ModAPI.IMyTerminalControls@GetControls{TBlock})||
|[RemoveAction<TBlock>(IMyTerminalAction)](Sandbox.ModAPI.IMyTerminalControls@RemoveAction{TBlock})||
|[RemoveControl<TBlock>(IMyTerminalControl)](Sandbox.ModAPI.IMyTerminalControls@RemoveControl{TBlock})||

