**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyTextPanel: IMyFunctionalBlock, IMyFunctionalBlock, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyTerminalBlock, IMyCubeBlock, IMyEntity, IMyTextSurface, IMyTextSurface, IMyTextPanel
```

Describes text panel block (mods interface)

## Events

|Member|Description|
|---|---|
|[AppendingCustomInfo](Sandbox.ModAPI.IMyTerminalBlock@AppendingCustomInfo)|Event to append custom info.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[CubeGridChanged](VRage.Game.ModAPI.IMyCubeBlock@CubeGridChanged)|Triggers when blocks cube grid is changed<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[CustomDataChanged](Sandbox.ModAPI.IMyTerminalBlock@CustomDataChanged)|Called when custom data of block changed<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[CustomNameChanged](Sandbox.ModAPI.IMyTerminalBlock@CustomNameChanged)|Called when custom name of block changed<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[EnabledChanged](Sandbox.ModAPI.IMyFunctionalBlock@EnabledChanged)|Called when Enabled changed<br /><br />_Inherited from [IMyFunctionalBlock](Sandbox.ModAPI.IMyFunctionalBlock)_|
|[IsWorkingChanged](VRage.Game.ModAPI.IMyCubeBlock@IsWorkingChanged)|Called when "WorkingState" is changed.<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[OnClose](VRage.ModAPI.IMyEntity@OnClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnClosing](VRage.ModAPI.IMyEntity@OnClosing)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnPhysicsChanged](VRage.ModAPI.IMyEntity@OnPhysicsChanged)|Called when havok rigid body physics are changed: inited, closed, modified.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnUpgradeValuesChanged](VRage.Game.ModAPI.IMyCubeBlock@OnUpgradeValuesChanged)|Event called when upgrade values are changed Either upgrades were built or destroyed, or they become damaged or unpowered<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[OwnershipChanged](Sandbox.ModAPI.IMyTerminalBlock@OwnershipChanged)|Called when block ownership changed<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[PropertiesChanged](Sandbox.ModAPI.IMyTerminalBlock@PropertiesChanged)|Called when any of block properties changed. It could be anything, starting from CustomName ending with Inventory items<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[ShowOnHUDChanged](Sandbox.ModAPI.IMyTerminalBlock@ShowOnHUDChanged)|Called when ShowOnHUD Changed<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[UpdateTimerTriggered](Sandbox.ModAPI.IMyFunctionalBlock@UpdateTimerTriggered)|Triggered when update timer ticks, event is fired after the block does all gameplay stuff<br /><br />_Inherited from [IMyFunctionalBlock](Sandbox.ModAPI.IMyFunctionalBlock)_|
|[VisibilityChanged](Sandbox.ModAPI.IMyTerminalBlock@VisibilityChanged)|Called properties that modify the visibility of this block's controls, are changed<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|

## Properties

