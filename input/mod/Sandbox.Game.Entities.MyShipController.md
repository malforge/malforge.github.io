**Assembly:** Sandbox.Game.dll

```csharp
public class MyShipController: MyTerminalBlock, IMyEntity, IMyEntity, IMyComponentOwner<MyIDModule>, IMyCubeBlock, IMyCubeBlock, IMyUpgradableBlock, IMyUpgradableBlock, IMyEventProxy, IMyEventOwner, IMySyncedEntity, IMyTerminalBlock, IMyTerminalBlock, IMyControllableEntity, IMyControllableEntity, IMyRechargeSocketOwner, IMyShipController, IMyShipController, IMyTargetingCapableBlock, IMyShootOrigin, IMyPilotable, IMyShipControl, IMyWheelControllableEntity
```

## Fields

|Member|Description|
|---|---|
|[BuildingMode](Sandbox.Game.Entities.MyShipController@BuildingMode)||
|[GridSelectionSystem](Sandbox.Game.Entities.MyShipController@GridSelectionSystem)||
|[TargetData](Sandbox.Game.Entities.MyShipController@TargetData)||
|[hasPower](Sandbox.Game.Entities.MyShipController@hasPower)|_**Obsolete**_|

## Events

|Member|Description|
|---|---|
|[AppendingCustomInfo](Sandbox.ModAPI.IMyTerminalBlock@AppendingCustomInfo)|Event to append custom info.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[CubeGridChanged](VRage.Game.ModAPI.IMyCubeBlock@CubeGridChanged)|Triggers when blocks cube grid is changed<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[CustomDataChanged](Sandbox.ModAPI.IMyTerminalBlock@CustomDataChanged)|Called when custom data of block changed<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[CustomNameChanged](Sandbox.ModAPI.IMyTerminalBlock@CustomNameChanged)|Called when custom name of block changed<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[IsWorkingChanged](VRage.Game.ModAPI.IMyCubeBlock@IsWorkingChanged)|Called when "WorkingState" is changed.<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[OnClose](VRage.ModAPI.IMyEntity@OnClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnClosing](VRage.ModAPI.IMyEntity@OnClosing)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose)|Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnPhysicsChanged](VRage.ModAPI.IMyEntity@OnPhysicsChanged)|Called when havok rigid body physics are changed: inited, closed, modified.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnUpgradeValuesChanged](VRage.Game.ModAPI.IMyCubeBlock@OnUpgradeValuesChanged)|Event called when upgrade values are changed Either upgrades were built or destroyed, or they become damaged or unpowered<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[OwnershipChanged](Sandbox.ModAPI.IMyTerminalBlock@OwnershipChanged)|Called when block ownership changed<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[PropertiesChanged](Sandbox.ModAPI.IMyTerminalBlock@PropertiesChanged)|Called when any of block properties changed. It could be anything, starting from CustomName ending with Inventory items<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[ShowOnHUDChanged](Sandbox.ModAPI.IMyTerminalBlock@ShowOnHUDChanged)|Called when ShowOnHUD Changed<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[VisibilityChanged](Sandbox.ModAPI.IMyTerminalBlock@VisibilityChanged)|Called properties that modify the visibility of this block's controls, are changed<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|

## Properties

|Member|Description|
|---|---|
|[AreBreaksOn](Sandbox.Game.Entities.MyShipController@AreBreaksOn)||
|[AuxiliaryContext](Sandbox.Game.Entities.MyShipController@AuxiliaryContext)||
|[BlockDefinition](Sandbox.Game.Entities.MyShipController@BlockDefinition)||
|[CanHavePreviousCameraEntity](Sandbox.Game.Entities.MyShipController@CanHavePreviousCameraEntity)||
|[CanHavePreviousControlledEntity](Sandbox.Game.Entities.MyShipController@CanHavePreviousControlledEntity)||
|[CanSwitchLandingGears](Sandbox.Game.Entities.MyShipController@CanSwitchLandingGears)||
|[ControlContext](Sandbox.Game.Entities.MyShipController@ControlContext)||
|[ControlGroup](Sandbox.Game.Entities.MyShipController@ControlGroup)||
|[ControlGyros](Sandbox.Game.Entities.MyShipController@ControlGyros)||
|[ControllerInfo](Sandbox.Game.Entities.MyShipController@ControllerInfo)||
|[ControlThrusters](Sandbox.Game.Entities.MyShipController@ControlThrusters)||
|[ControlWheels](Sandbox.Game.Entities.MyShipController@ControlWheels)||
|[EnableFirstPersonView](Sandbox.Game.Entities.MyShipController@EnableFirstPersonView)||
|[EnableShipControl](Sandbox.Game.Entities.MyShipController@EnableShipControl)||
|[Entity](Sandbox.Game.Entities.MyShipController@Entity)||
|[EntityThrustComponent](Sandbox.Game.Entities.MyShipController@EntityThrustComponent)||
|[ForceFirstPersonCamera](Sandbox.Game.Entities.MyShipController@ForceFirstPersonCamera)||
|[GetAmmoDefinition](Sandbox.Game.Entities.MyShipController@GetAmmoDefinition)||
|[GetPreviousCameraEntity](Sandbox.Game.Entities.MyShipController@GetPreviousCameraEntity)||
|[GridGyroSystem](Sandbox.Game.Entities.MyShipController@GridGyroSystem)||
|[GridReflectorLights](Sandbox.Game.Entities.MyShipController@GridReflectorLights)||
|[GridResourceDistributor](Sandbox.Game.Entities.MyShipController@GridResourceDistributor)||
|[GridWheels](Sandbox.Game.Entities.MyShipController@GridWheels)||
|[HasWheels](Sandbox.Game.Entities.MyShipController@HasWheels)||
|[HeadLocalXAngle](Sandbox.Game.Entities.MyShipController@HeadLocalXAngle)||
|[HeadLocalYAngle](Sandbox.Game.Entities.MyShipController@HeadLocalYAngle)||
|[HorizonIndicatorEnabled](Sandbox.Game.Entities.MyShipController@HorizonIndicatorEnabled)||
|[IsAutopilotControlled](Sandbox.Game.Entities.MyShipController@IsAutopilotControlled)||
|[IsDefault3rdView](Sandbox.Game.Entities.MyShipController@IsDefault3rdView)||
|[IsMainCockpit](Sandbox.Game.Entities.MyShipController@IsMainCockpit)||
|[IsTargetLockingEnabledValue](Sandbox.Game.Entities.MyShipController@IsTargetLockingEnabledValue)||
|[IsUsing](Sandbox.Game.Entities.MyShipController@IsUsing)||
|[LastMotionIndicator](Sandbox.Game.Entities.MyShipController@LastMotionIndicator)||
|[LastRotationIndicator](Sandbox.Game.Entities.MyShipController@LastRotationIndicator)||
|[LocationForHudMarker](Sandbox.Game.Entities.MyShipController@LocationForHudMarker)||
|[MaxShootRange](Sandbox.Game.Entities.MyShipController@MaxShootRange)||
|[NeedsPerFrameUpdate](Sandbox.Game.Entities.MyShipController@NeedsPerFrameUpdate)||
|[OnLockedToolbar](Sandbox.Game.Entities.MyShipController@OnLockedToolbar)||
|[Pilot](Sandbox.Game.Entities.MyShipController@Pilot)||
|[PlayDefaultUseSound](Sandbox.Game.Entities.MyShipController@PlayDefaultUseSound)||
|[PreviousControlledEntity](Sandbox.Game.Entities.MyShipController@PreviousControlledEntity)||
|[PreviousController](Sandbox.Game.Entities.MyShipController@PreviousController)||
|[PrimaryLookaround](Sandbox.Game.Entities.MyShipController@PrimaryLookaround)||
|[Priority](Sandbox.Game.Entities.MyShipController@Priority)||
|[RaycasterHitBlock](Sandbox.Game.Entities.MyShipController@RaycasterHitBlock)||
|[RelativeDampeningDistance](Sandbox.Game.Entities.MyShipController@RelativeDampeningDistance)||
|[RelativeDampeningEntity](Sandbox.Game.Entities.MyShipController@RelativeDampeningEntity)||
|[ShootOrigin](Sandbox.Game.Entities.MyShipController@ShootOrigin)||
|[SingleWeaponMode](Sandbox.Game.Entities.MyShipController@SingleWeaponMode)||
|[Toolbar](Sandbox.Game.Entities.MyShipController@Toolbar)||
|[ToolbarType](Sandbox.Game.Entities.MyShipController@ToolbarType)||
|[TopGrid](Sandbox.Game.Entities.MyShipController@TopGrid)||
|[AuxiliaryContext](Sandbox.Game.Entities.IMyControllableEntity@AuxiliaryContext)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[BlockDefinition](VRage.Game.ModAPI.Ingame.IMyCubeBlock@BlockDefinition)|Gets definition.Id assigned to this block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[CanControlShip](Sandbox.ModAPI.Ingame.IMyShipController@CanControlShip)|Determines whether this specific ship controller is capable of controlling the ship it's installed on.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[CanSwitchLandingGears](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@CanSwitchLandingGears)|Gets if entity can switch landing gears<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[CastShadows](VRage.ModAPI.IMyEntity@CastShadows)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[CenterOfMass](Sandbox.ModAPI.Ingame.IMyShipController@CenterOfMass)|Center of mass in world coordinates<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[CheckConnectionAllowed](VRage.Game.ModAPI.IMyCubeBlock@CheckConnectionAllowed)|Whether the grid should call the ConnectionAllowed method for this block (ConnectionAllowed checks mount points and other per-block requirements)<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[Closed](VRage.Game.ModAPI.Ingame.IMyEntity@Closed)|True if the block has been removed from the world.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Components](VRage.Game.ModAPI.Ingame.IMyEntity@Components)|Gets blocks component logic container<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[ControlContext](Sandbox.Game.Entities.IMyControllableEntity@ControlContext)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[ControllerInfo](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ControllerInfo)|Gets information about who controls this Entity<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ControllerInfo](Sandbox.Game.Entities.IMyControllableEntity@ControllerInfo)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[ControlThrusters](Sandbox.ModAPI.Ingame.IMyShipController@ControlThrusters)|Gets or sets whether thrusters are being controlled by this controller.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[ControlWheels](Sandbox.ModAPI.Ingame.IMyShipController@ControlWheels)|Gets or sets whether wheels are being controlled by this controller.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[CubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeBlock@CubeGrid)|Grid in which the block is placed<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[CubeGrid](VRage.Game.ModAPI.IMyCubeBlock@CubeGrid)|Grid in which the block is placed<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[CustomData](Sandbox.ModAPI.Ingame.IMyTerminalBlock@CustomData)|Gets or sets the Custom Data string. NOTE: Only use this for user input. For storing large mod configs, create your own MyModStorageComponent<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[CustomInfo](Sandbox.ModAPI.Ingame.IMyTerminalBlock@CustomInfo)|Gets information about block status (available from mods) [AppendingCustomInfo](Sandbox.ModAPI.IMyTerminalBlock@AppendingCustomInfo)  [RefreshCustomInfo()](Sandbox.ModAPI.IMyTerminalBlock@RefreshCustomInfo) .<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[CustomName](Sandbox.ModAPI.Ingame.IMyTerminalBlock@CustomName)|Gets or sets how block is named in Terminal menu<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[CustomNameWithFaction](Sandbox.ModAPI.Ingame.IMyTerminalBlock@CustomNameWithFaction)|Gets or sets how block is named in Terminal menu. Work only for Cockpit, LaserAntenna RadioAntenna, SpaceBall, Beacon<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[DampenersOverride](Sandbox.ModAPI.Ingame.IMyShipController@DampenersOverride)|Gets or sets whether dampeners are currently enabled.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[DebugAsyncLoading](VRage.ModAPI.IMyEntity@DebugAsyncLoading)|Used for internal usage. Modders should not use it. Will be eventually removed<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DefinitionDisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DefinitionDisplayNameText)|Definition name<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[DetailedInfo](Sandbox.ModAPI.Ingame.IMyTerminalBlock@DetailedInfo)|Gets information about block status. In Control panel bottom right text<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[DisassembleRatio](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisassembleRatio)|Is set in definition Ratio at which is the block disassembled (grinding) Bigger values - longer grinding<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[DisplayName](VRage.Game.ModAPI.Ingame.IMyEntity@DisplayName)|Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisplayNameText)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[DisplayName](VRage.ModAPI.IMyEntity@DisplayName)|Gets or sets user friendly name of entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisplayNameText)|Translated block name<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[EnabledBroadcasting](Sandbox.Game.Entities.IMyControllableEntity@EnabledBroadcasting)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[EnabledDamping](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledDamping)|Gets if Damping enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledHelmet](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledHelmet)|Gets if helmet is opened<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledLeadingGears](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledLeadingGears)|Gets if at least one leading gear is enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledLights](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledLights)|Gets if lights are enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledReactors](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledReactors)|Gets if grid is powered<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnabledThrusts](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@EnabledThrusts)|Gets if thrusts are enabled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Entity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Entity)|Gets information which entity is being controlled<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Entity](Sandbox.Game.Entities.IMyControllableEntity@Entity)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[EntityId](VRage.Game.ModAPI.Ingame.IMyEntity@EntityId)|Id of entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[EntityId](VRage.ModAPI.IMyEntity@EntityId)|Uniq id of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[FastCastShadowResolve](VRage.ModAPI.IMyEntity@FastCastShadowResolve)|Gets or sets flag [CastShadows](VRage.ObjectBuilders.MyPersistentEntityFlags2@CastShadows)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Flags](VRage.ModAPI.IMyEntity@Flags)|Gets or set some behavior of entity. [EntityFlags](VRage.ModAPI.EntityFlags)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ForceFirstPersonCamera](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ForceFirstPersonCamera)|Gets or sets if camera should be first person<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[GameLogic](VRage.ModAPI.IMyEntity@GameLogic)|Gets or sets game logic for object. If there is more than 1 game logic attached it should be wrapped into.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetAmmoDefinition](Sandbox.ModAPI.IMyShootOrigin@GetAmmoDefinition)|Gets ammo definition<br /><br />_Inherited from [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)_|
|[HandBrake](Sandbox.ModAPI.Ingame.IMyShipController@HandBrake)|Gets or sets the current state of the handbrake.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[HasFirstPersonCamera](Sandbox.ModAPI.IMyShipController@HasFirstPersonCamera)|Gets if this ship controller contains a first-person camera view.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.IMyShipController)_|
|[HasInventory](VRage.Game.ModAPI.Ingame.IMyEntity@HasInventory)|Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[HasWheels](Sandbox.ModAPI.Ingame.IMyShipController@HasWheels)|Determines whether there are any wheels on this ship.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[HeadLocalXAngle](Sandbox.Game.Entities.IMyControllableEntity@HeadLocalXAngle)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[HeadLocalYAngle](Sandbox.Game.Entities.IMyControllableEntity@HeadLocalYAngle)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[Hierarchy](VRage.ModAPI.IMyEntity@Hierarchy)|Gets or sets Hierarchy component<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InScene](VRage.ModAPI.IMyEntity@InScene)|Gets or set if grid is InScene. Objects that are not in scene are not updated and drawn.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InvalidateOnMove](VRage.ModAPI.IMyEntity@InvalidateOnMove)|Gets if entity is invalidated on move When visual look of entity depends on position - then InvalidateOnMove should be true<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[InventoryCount](VRage.Game.ModAPI.Ingame.IMyEntity@InventoryCount)|Returns the count of the number of inventories this entity has.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[IsAutopilotControlled](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@IsAutopilotControlled)|Gets whether the entity is controller by autopilot<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[IsBeingHacked](VRage.Game.ModAPI.Ingame.IMyCubeBlock@IsBeingHacked)|Hacking of the block is in progress<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[IsDefault3rdView](Sandbox.ModAPI.IMyShipController@IsDefault3rdView)|If player gets into this cockpit for the first time, the camera is in 3rd view<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.IMyShipController)_|
|[IsDetailedInfoDirty](Sandbox.ModAPI.IMyTerminalBlock@IsDetailedInfoDirty)|Gets whether detailed info is dirty and to be updated<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[IsFunctional](VRage.Game.ModAPI.Ingame.IMyCubeBlock@IsFunctional)|Gets if integrity is above breaking threshold<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[IsMainCockpit](Sandbox.ModAPI.Ingame.IMyShipController@IsMainCockpit)|Gets or sets if this controller is the main one for current ship Setter checks if there is any other main cockpit on the ship before proceeding<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[IsShooting](Sandbox.ModAPI.IMyShipController@IsShooting)|Gets if the ship is shooting selected weapons.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.IMyShipController)_|
|[IsUnderControl](Sandbox.ModAPI.Ingame.IMyShipController@IsUnderControl)|Indicates whether a block is locally or remotely controlled.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[IsVolumetric](VRage.ModAPI.IMyEntity@IsVolumetric)|Always returns false<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[IsWorking](VRage.Game.ModAPI.Ingame.IMyCubeBlock@IsWorking)|True if block is able to do its work depening on block type (is functional, powered, enabled, etc...)<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[LastMotionIndicator](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@LastMotionIndicator)|Gets last motion indicator. User input W/A/S/D Space/C<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[LastPilot](Sandbox.ModAPI.IMyShipController@LastPilot)|Get the last character that was piloting the controller.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.IMyShipController)_|
|[LastRotationIndicator](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@LastRotationIndicator)|Gets last rotation indicator. Z used for RollIndicator<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB)|Gets or sets local axis aligned bounding box. Same as [LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalAABBHr](VRage.ModAPI.IMyEntity@LocalAABBHr)|Gets local axis aligned bounding box. Same as [LocalAABB](VRage.ModAPI.IMyEntity@LocalAABB) , [LocalAABB](VRage.Game.Components.MyPositionComponentBase@LocalAABB)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalMatrix](VRage.ModAPI.IMyEntity@LocalMatrix)|Gets or sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolume](VRage.ModAPI.IMyEntity@LocalVolume)|Gets or sets local volume. Same as [LocalVolume](VRage.Game.Components.MyPositionComponentBase@LocalVolume)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocalVolumeOffset](VRage.ModAPI.IMyEntity@LocalVolumeOffset)|Gets or sets local volume offset. Same as [LocalVolumeOffset](VRage.Game.Components.MyPositionComponentBase@LocalVolumeOffset)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MarkedForClose](VRage.ModAPI.IMyEntity@MarkedForClose)|Checked if [Close()](VRage.ModAPI.IMyEntity@Close) was called<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Mass](VRage.Game.ModAPI.Ingame.IMyCubeBlock@Mass)|Block mass<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[Max](VRage.Game.ModAPI.Ingame.IMyCubeBlock@Max)|Maximum coordinates of grid cells occupied by this block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[MaxGlassDistSq](VRage.ModAPI.IMyEntity@MaxGlassDistSq)|Not used in game anymore<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MaxShootRange](Sandbox.ModAPI.IMyShootOrigin@MaxShootRange)|Gets weapon max shoot range<br /><br />_Inherited from [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)_|
|[Min](VRage.Game.ModAPI.Ingame.IMyCubeBlock@Min)|Minimum coordinates of grid cells occupied by this block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[Model](VRage.ModAPI.IMyEntity@Model)|Gets model of block<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ModelCollision](VRage.ModAPI.IMyEntity@ModelCollision)|Gets collision model of block<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[MoveIndicator](Sandbox.ModAPI.Ingame.IMyShipController@MoveIndicator)|Directional input from user/autopilot. Values can be very large with high controller sensitivity<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[Name](VRage.Game.ModAPI.Ingame.IMyEntity@Name)|Some entities can have uniq name, and game can find them by name [TryGetEntityByName(string, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityByName)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Name](VRage.ModAPI.IMyEntity@Name)|Uniq name of entity. Can be used to find entity by name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NearFlag](VRage.ModAPI.IMyEntity@NearFlag)|Gets or sets flag [Near](VRage.ModAPI.EntityFlags@Near)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsDraw](VRage.ModAPI.IMyEntity@NeedsDraw)|Gets or sets flag [NeedsDraw](VRage.ModAPI.EntityFlags@NeedsDraw)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsDrawFromParent](VRage.ModAPI.IMyEntity@NeedsDrawFromParent)|Gets or sets flag [NeedsDrawFromParent](VRage.ModAPI.EntityFlags@NeedsDrawFromParent)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsResolveCastShadow](VRage.ModAPI.IMyEntity@NeedsResolveCastShadow)|Gets or sets flag [NeedsResolveCastShadow](VRage.ModAPI.EntityFlags@NeedsResolveCastShadow)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsUpdate](VRage.ModAPI.IMyEntity@NeedsUpdate)|Gets or sets how often the entity should be updated.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NeedsWorldMatrix](VRage.ModAPI.IMyEntity@NeedsWorldMatrix)|Gets or sets if [WorldMatrix](VRage.ModAPI.IMyEntity@WorldMatrix) should be calculated when parent WorldMatrix is changed.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[NumberInGrid](VRage.Game.ModAPI.Ingame.IMyCubeBlock@NumberInGrid)|Order in which were the blocks of same type added to grid Used in default display name<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[Orientation](VRage.Game.ModAPI.Ingame.IMyCubeBlock@Orientation)|Returns block orientation in base 6 directions<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[OwnerId](VRage.Game.ModAPI.Ingame.IMyCubeBlock@OwnerId)|IdentityId of player owning block (not steam Id)<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[Parent](VRage.ModAPI.IMyEntity@Parent)|Gets parent of entity or null, if this entity doesn't have parent. Ex: character sitting in cockpit, has parent - cockpit, cockpit has parent - cube grid, connected grids also has main grid, which would be parent for other grids.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[PersistentFlags](VRage.ModAPI.IMyEntity@PersistentFlags)|Gets or sets persistent flags that are used in rendering.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Physics](VRage.ModAPI.IMyEntity@Physics)|Gets or sets physics for object<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Pilot](Sandbox.ModAPI.IMyShipController@Pilot)|Get the character that is currently piloting the controller.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.IMyShipController)_|
|[Position](VRage.Game.ModAPI.Ingame.IMyCubeBlock@Position)|Position in grid coordinates<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[PositionComp](VRage.ModAPI.IMyEntity@PositionComp)|Gets or sets position provider logic<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[PrimaryLookaround](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PrimaryLookaround)|When false, blocks 3rd view look around<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[RelativeDampeningDistance](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@RelativeDampeningDistance)|Allows you to set a custom max distance which relative dampening to another entity will remain active.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[RelativeDampeningEntity](Sandbox.Game.Entities.IMyControllableEntity@RelativeDampeningEntity)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[RelativeDampeningTarget](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@RelativeDampeningTarget)|Allows you to get or set the relative dampening entity.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Render](VRage.ModAPI.IMyEntity@Render)|Gets or sets render logic<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ResourceSink](VRage.Game.ModAPI.IMyCubeBlock@ResourceSink)|Resource sink (draws power)<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[RollIndicator](Sandbox.ModAPI.Ingame.IMyShipController@RollIndicator)|Roll input from user/autopilot. Values can be very large with high controller sensitivity<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[RotationIndicator](Sandbox.ModAPI.Ingame.IMyShipController@RotationIndicator)|Pitch, yaw input from user/autopilot. Values can be very large with high controller sensitivity<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[Save](VRage.ModAPI.IMyEntity@Save)|Gets or sets [Save](VRage.ModAPI.EntityFlags@Save) . Entity won't be saved if [Save](VRage.ModAPI.IMyEntity@Save) is false<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ShadowBoxLod](VRage.ModAPI.IMyEntity@ShadowBoxLod)|Gets or sets flag [ShadowBoxLod](VRage.Game.Components.MyRenderComponentBase@ShadowBoxLod)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ShootOrigin](Sandbox.ModAPI.IMyShootOrigin@ShootOrigin)|Gets shot starting position<br /><br />_Inherited from [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)_|
|[ShowHorizonIndicator](Sandbox.ModAPI.Ingame.IMyShipController@ShowHorizonIndicator)|Gets or sets whether the horizon indicator should be displayed for this block.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[ShowInInventory](Sandbox.ModAPI.Ingame.IMyTerminalBlock@ShowInInventory)|Represent terminal gui toggle `Show block in Inventory Screen`. Gets or sets its value<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[ShowInTerminal](Sandbox.ModAPI.Ingame.IMyTerminalBlock@ShowInTerminal)|Represent terminal gui toggle `Show block in terminal`. Gets or sets its value<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[ShowInToolbarConfig](Sandbox.ModAPI.Ingame.IMyTerminalBlock@ShowInToolbarConfig)|Represent terminal gui toggle `Show in toolbar config`. Gets or sets its value<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[ShowOnHUD](Sandbox.ModAPI.Ingame.IMyTerminalBlock@ShowOnHUD)|Represent terminal gui toggle `Show On HUD`. Gets or sets its value<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[SkipIfTooSmall](VRage.ModAPI.IMyEntity@SkipIfTooSmall)|Gets or sets flag [SkipIfTooSmall](VRage.ModAPI.EntityFlags@SkipIfTooSmall)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SlimBlock](VRage.Game.ModAPI.IMyCubeBlock@SlimBlock)|Gets the SlimBlock associated with this block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[StopPhysicsActivation](VRage.ModAPI.IMyEntity@StopPhysicsActivation)|_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Storage](VRage.ModAPI.IMyEntity@Storage)|Custom storage for mods. Shared with all mods.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Synchronized](VRage.ModAPI.IMyEntity@Synchronized)|Gets or sets if the entity should be synced.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SyncObject](VRage.ModAPI.IMyEntity@SyncObject)|Gets SyncObject used for synchronizing data over network with<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Toolbar](Sandbox.Game.Entities.IMyControllableEntity@Toolbar)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[ToolbarType](Sandbox.Game.Entities.IMyControllableEntity@ToolbarType)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[Transparent](VRage.ModAPI.IMyEntity@Transparent)|Gets or sets [Transparency](VRage.Game.Components.MyRenderComponentBase@Transparency) . When setting true entity would be 25% transparent<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[UpgradeCount](Sandbox.ModAPI.Ingame.IMyUpgradableBlock@UpgradeCount)|Gets number of upgrades applied<br /><br />_Inherited from [IMyUpgradableBlock](Sandbox.ModAPI.Ingame.IMyUpgradableBlock)_|
|[UpgradeValues](VRage.Game.ModAPI.IMyCubeBlock@UpgradeValues)|Get all values changed by upgrade modules Should only be used as read-only<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[Visible](VRage.ModAPI.IMyEntity@Visible)|Gets or sets flag [Visible](VRage.Game.Components.MyRenderComponentBase@Visible)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldAABB](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABB)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldAABBHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABBHr)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.Game.ModAPI.Ingame.IMyEntity@WorldMatrix)|Gets world matrix of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.ModAPI.IMyEntity@WorldMatrix)|Gets or sets world matrix.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldMatrixInvScaled](VRage.ModAPI.IMyEntity@WorldMatrixInvScaled)|Get scaled, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv) , but not normalized<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)|Get normalized, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[WorldVolume](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolume)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldVolumeHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolumeHr)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[IsCCDForProjectiles](VRage.ModAPI.IMyEntity@IsCCDForProjectiles)|_**Obsolete**_<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[LocationForHudMarker](VRage.ModAPI.IMyEntity@LocationForHudMarker)|_**Obsolete**_<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|

## Constructors

|Member|Description|
|---|---|
|[MyShipController()](Sandbox.Game.Entities.MyShipController@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static HasPriorityOver(MyShipController, MyShipController)](Sandbox.Game.Entities.MyShipController@HasPriorityOver)||
|[AddControlSystem(MyGroupControlSystem)](Sandbox.Game.Entities.MyShipController@AddControlSystem)||
|[BeginShoot(MyShootActionEnum)](Sandbox.Game.Entities.MyShipController@BeginShoot)||
|[BeginShootSync(MyShootActionEnum)](Sandbox.Game.Entities.MyShipController@BeginShootSync)||
|[CalculateShipMass()](Sandbox.Game.Entities.MyShipController@CalculateShipMass)||
|[CanActiveToolShoot()](Sandbox.Game.Entities.MyShipController@CanActiveToolShoot)||
|[CanSwitchToWeapon(MyDefinitionId?)](Sandbox.Game.Entities.MyShipController@CanSwitchToWeapon)||
|[CleanControls()](Sandbox.Game.Entities.MyShipController@CleanControls)||
|[ClearMovementControl()](Sandbox.Game.Entities.MyShipController@ClearMovementControl)||
|[Crouch()](Sandbox.Game.Entities.MyShipController@Crouch)||
|[Die()](Sandbox.Game.Entities.MyShipController@Die)||
|[Down()](Sandbox.Game.Entities.MyShipController@Down)||
|[DrawHud(IMyCameraController, long)](Sandbox.Game.Entities.MyShipController@DrawHud)||
|[EndShoot(MyShootActionEnum)](Sandbox.Game.Entities.MyShipController@EndShoot)||
|[EndShootSync(MyShootActionEnum)](Sandbox.Game.Entities.MyShipController@EndShootSync)||
|[FindProjectedBlock()](Sandbox.Game.Entities.MyShipController@FindProjectedBlock)||
|[ForceReleaseControl()](Sandbox.Game.Entities.MyShipController@ForceReleaseControl)||
|[GetActiveToolPosition()](Sandbox.Game.Entities.MyShipController@GetActiveToolPosition)||
|[GetArtificialGravity()](Sandbox.Game.Entities.MyShipController@GetArtificialGravity)||
|[GetCameraEntitySettings()](Sandbox.Game.Entities.MyShipController@GetCameraEntitySettings)||
|[GetHeadMatrix(bool, bool, bool, bool)](Sandbox.Game.Entities.MyShipController@GetHeadMatrix)||
|[GetNaturalGravity()](Sandbox.Game.Entities.MyShipController@GetNaturalGravity)||
|[GetNetState()](Sandbox.Game.Entities.MyShipController@GetNetState)||
|[GetObjectBuilderCubeBlock(bool)](Sandbox.Game.Entities.MyShipController@GetObjectBuilderCubeBlock)||
|[GetTotalGravity()](Sandbox.Game.Entities.MyShipController@GetTotalGravity)||
|[GetViewMatrix()](Sandbox.Game.Entities.MyShipController@GetViewMatrix)||
|[GetWorldMatrix()](Sandbox.Game.Entities.MyShipController@GetWorldMatrix)||
|[Init(MyObjectBuilder_CubeBlock, MyCubeGrid)](Sandbox.Game.Entities.MyShipController@Init)||
|[IsLargeShip()](Sandbox.Game.Entities.MyShipController@IsLargeShip)||
|[IsShipToolSelected()](Sandbox.Game.Entities.MyShipController@IsShipToolSelected)||
|[IsShooting()](Sandbox.Game.Entities.MyShipController@IsShooting)||
|[IsTargetLockingEnabled()](Sandbox.Game.Entities.MyShipController@IsTargetLockingEnabled)||
|[Jump(Vector3)](Sandbox.Game.Entities.MyShipController@Jump)||
|[MoveAndRotate(Vector3, Vector2, float)](Sandbox.Game.Entities.MyShipController@MoveAndRotate)||
|[MoveAndRotate()](Sandbox.Game.Entities.MyShipController@MoveAndRotate)||
|[MoveAndRotateStopped()](Sandbox.Game.Entities.MyShipController@MoveAndRotateStopped)||
|[OnAddedToScene(object)](Sandbox.Game.Entities.MyShipController@OnAddedToScene)||
|[OnBeginShoot(MyShootActionEnum)](Sandbox.Game.Entities.MyShipController@OnBeginShoot)||
|[OnEndShoot(MyShootActionEnum)](Sandbox.Game.Entities.MyShipController@OnEndShoot)||
|[OnRegisteredToGridSystems()](Sandbox.Game.Entities.MyShipController@OnRegisteredToGridSystems)||
|[OnRemovedFromScene(object)](Sandbox.Game.Entities.MyShipController@OnRemovedFromScene)||
|[OnUnregisteredFromGridSystems()](Sandbox.Game.Entities.MyShipController@OnUnregisteredFromGridSystems)||
|[PickUp()](Sandbox.Game.Entities.MyShipController@PickUp)||
|[PickUpContinues()](Sandbox.Game.Entities.MyShipController@PickUpContinues)||
|[PickUpFinished()](Sandbox.Game.Entities.MyShipController@PickUpFinished)||
|[PlayUseSound(bool)](Sandbox.Game.Entities.MyShipController@PlayUseSound)||
|[RaiseControlledEntityUsed()](Sandbox.Game.Entities.MyShipController@RaiseControlledEntityUsed)||
|[RefreshControlNotifications()](Sandbox.Game.Entities.MyShipController@RefreshControlNotifications)||
|[RemoveControlNotifications()](Sandbox.Game.Entities.MyShipController@RemoveControlNotifications)||
|[RemoveControlSystem(MyGroupControlSystem)](Sandbox.Game.Entities.MyShipController@RemoveControlSystem)||
|[RemoveUsers(bool)](Sandbox.Game.Entities.MyShipController@RemoveUsers)||
|[SetLockedTarget(IMyCubeGrid)](Sandbox.Game.Entities.MyShipController@SetLockedTarget)||
|[SetLockedTarget(IMyCharacter)](Sandbox.Game.Entities.MyShipController@SetLockedTarget)||
|[SetNetState(MyGridClientState)](Sandbox.Game.Entities.MyShipController@SetNetState)||
|[SetWeaponSystem(MyGridWeaponSystem)](Sandbox.Game.Entities.MyShipController@SetWeaponSystem)||
|[Shoot(MyShootActionEnum)](Sandbox.Game.Entities.MyShipController@Shoot)||
|[ShouldEndShootingOnPause(MyShootActionEnum)](Sandbox.Game.Entities.MyShipController@ShouldEndShootingOnPause)||
|[ShowInventory()](Sandbox.Game.Entities.MyShipController@ShowInventory)||
|[ShowRemoteAccessMenu()](Sandbox.Game.Entities.MyShipController@ShowRemoteAccessMenu)||
|[ShowTerminal()](Sandbox.Game.Entities.MyShipController@ShowTerminal)||
|[Sprint(bool)](Sandbox.Game.Entities.MyShipController@Sprint)||
|[SwitchBroadcasting()](Sandbox.Game.Entities.MyShipController@SwitchBroadcasting)||
|[SwitchDamping()](Sandbox.Game.Entities.MyShipController@SwitchDamping)||
|[SwitchHandbrake()](Sandbox.Game.Entities.MyShipController@SwitchHandbrake)||
|[SwitchLandingGears()](Sandbox.Game.Entities.MyShipController@SwitchLandingGears)||
|[SwitchLights()](Sandbox.Game.Entities.MyShipController@SwitchLights)||
|[SwitchParkedStatus()](Sandbox.Game.Entities.MyShipController@SwitchParkedStatus)||
|[SwitchReactors()](Sandbox.Game.Entities.MyShipController@SwitchReactors)||
|[SwitchReactorsLocal()](Sandbox.Game.Entities.MyShipController@SwitchReactorsLocal)||
|[SwitchThrusts()](Sandbox.Game.Entities.MyShipController@SwitchThrusts)||
|[SwitchToWeapon(MyDefinitionId)](Sandbox.Game.Entities.MyShipController@SwitchToWeapon)||
|[SwitchToWeapon(MyToolbarItemWeapon)](Sandbox.Game.Entities.MyShipController@SwitchToWeapon)||
|[SwitchWalk()](Sandbox.Game.Entities.MyShipController@SwitchWalk)||
|[TryEnableBrakes(bool)](Sandbox.Game.Entities.MyShipController@TryEnableBrakes)|Tries to set the brakes. May fail if this is not the main cockpit.|
|[Up()](Sandbox.Game.Entities.MyShipController@Up)||
|[UpdateAfterSimulation()](Sandbox.Game.Entities.MyShipController@UpdateAfterSimulation)||
|[UpdateAfterSimulation10()](Sandbox.Game.Entities.MyShipController@UpdateAfterSimulation10)||
|[UpdateBeforeSimulation100()](Sandbox.Game.Entities.MyShipController@UpdateBeforeSimulation100)||
|[UpdateControls()](Sandbox.Game.Entities.MyShipController@UpdateControls)||
|[UpdateVisual()](Sandbox.Game.Entities.MyShipController@UpdateVisual)||
|[UpdatingStopped()](Sandbox.Game.Entities.MyShipController@UpdatingStopped)||
|[Use()](Sandbox.Game.Entities.MyShipController@Use)||
|[UseContinues()](Sandbox.Game.Entities.MyShipController@UseContinues)||
|[UseFinished()](Sandbox.Game.Entities.MyShipController@UseFinished)||
|[WheelJump(bool)](Sandbox.Game.Entities.MyShipController@WheelJump)||
|[WheelJumpFromOtherBlock(bool)](Sandbox.Game.Entities.MyShipController@WheelJumpFromOtherBlock)||
|[Zoom(bool)](Sandbox.Game.Entities.MyShipController@Zoom)||
|[AddUpgradeValue(string, float)](VRage.Game.ModAPI.IMyCubeBlock@AddUpgradeValue)|Preferred way of registering a block for upgrades Adding directly to the dictionary can have unintended consequences when multiple mods are involved.<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[BeforeSave()](VRage.ModAPI.IMyEntity@BeforeSave)|Called before method GetObjectBuilder, when saving sector<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[BeginShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@BeginShoot)|This will be called locally to start shooting with the given action<br /><br />_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[CalcLocalMatrix(out Matrix, out string)](VRage.Game.ModAPI.IMyCubeBlock@CalcLocalMatrix)|Calculates local matrix, and currentModel<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[CalculateCurrentModel(out Matrix)](VRage.Game.ModAPI.IMyCubeBlock@CalculateCurrentModel)|Calculates model currently used by block depending on its build progress and other factors<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[CalculateShipMass()](Sandbox.ModAPI.Ingame.IMyShipController@CalculateShipMass)|Gets information about the current mass of the ship.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[CanActiveToolShoot()](Sandbox.ModAPI.IMyTargetingCapableBlock@CanActiveToolShoot)|Get whether toolbar selected tool can shoot<br /><br />_Inherited from [IMyTargetingCapableBlock](Sandbox.ModAPI.IMyTargetingCapableBlock)_|
|[CanSwitchAmmoMagazine()](Sandbox.Game.Entities.IMyControllableEntity@CanSwitchAmmoMagazine)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[CanSwitchToWeapon(MyDefinitionId?)](Sandbox.Game.Entities.IMyControllableEntity@CanSwitchToWeapon)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[CleanControls()](Sandbox.Game.Entities.IMyControllableEntity@CleanControls)|Implementation should clear previousControlled entities and cameras. They are no longer valid. Called on game load, if player is not online<br /><br />_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[ClearDetailedInfo()](Sandbox.ModAPI.IMyTerminalBlock@ClearDetailedInfo)|Clears detailed info<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[Close()](VRage.ModAPI.IMyEntity@Close)|This method marks this entity for close which means, that Close will be called after all entities are updated<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Crouch()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Crouch)|Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[DebugDraw()](VRage.ModAPI.IMyEntity@DebugDraw)|Calls debug draw of entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[DebugDrawInvalidTriangles()](VRage.ModAPI.IMyEntity@DebugDrawInvalidTriangles)|Calls special debug draw, that highlighting invalid triangles in model<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Delete()](VRage.ModAPI.IMyEntity@Delete)|Performs real cleaning of entity. Should be called by game. Modders should prefer [Close()](VRage.ModAPI.IMyEntity@Close) method.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Die()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Die)|Makes character dead.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[DoOverlapSphereTest(float, Vector3D)](VRage.ModAPI.IMyEntity@DoOverlapSphereTest)|Checks if intersects Works only with [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Down()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Down)|Move direction : down. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[DrawHud(IMyCameraController, long)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@DrawHud)|Updates hud logic, connected to entity<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[EnableColorMaskForSubparts(bool)](VRage.ModAPI.IMyEntity@EnableColorMaskForSubparts)|Allows subparts have different color than their parent<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[EndShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@EndShoot)|This will be called locally to start shooting with the given action<br /><br />_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[FillUpgradesDictionary(Dictionary<string, float>)](Sandbox.ModAPI.Ingame.IMyUpgradableBlock@FillUpgradesDictionary)|Get list of upgrades. Read only.<br /><br />_Inherited from [IMyUpgradableBlock](Sandbox.ModAPI.Ingame.IMyUpgradableBlock)_|
|[GetActions(List<ITerminalAction>, Func<ITerminalAction, bool>)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@GetActions)|Get all terminal actions available for block<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[GetActionWithName(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@GetActionWithName)|Get first found terminal action with name<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[GetActiveToolPosition()](Sandbox.ModAPI.IMyTargetingCapableBlock@GetActiveToolPosition)|Gets average position<br /><br />_Inherited from [IMyTargetingCapableBlock](Sandbox.ModAPI.IMyTargetingCapableBlock)_|
|[GetArtificialGravity()](Sandbox.ModAPI.Ingame.IMyShipController@GetArtificialGravity)|Gets the detected artificial gravity vector and power at the current location.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[GetCameraEntitySettings()](Sandbox.Game.Entities.IMyControllableEntity@GetCameraEntitySettings)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[GetChildren(List<IMyEntity>, Func<IMyEntity, bool>)](VRage.ModAPI.IMyEntity@GetChildren)|Gets children of entity. Child - entity, who's [Parent](VRage.ModAPI.IMyEntity@Parent) is this entity<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDetailedInfo()](Sandbox.ModAPI.IMyTerminalBlock@GetDetailedInfo)|Gets detailed info instance<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[GetDiffuseColor()](VRage.ModAPI.IMyEntity@GetDiffuseColor)|Gets render diffuse color<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndBoundingSphere)|Distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. (in meters)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetDistanceBetweenCameraAndPosition()](VRage.ModAPI.IMyEntity@GetDistanceBetweenCameraAndPosition)|Distance from camera to position of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetFriendlyName()](VRage.ModAPI.IMyEntity@GetFriendlyName)|Not used. Actually not a friendly name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetHeadMatrix(bool, bool, bool, bool)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@GetHeadMatrix)|Gets head of character that controls this<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[GetIntersectionWithAABB(ref BoundingBoxD)](VRage.ModAPI.IMyEntity@GetIntersectionWithAABB)|Return true if object intersects specified bounding box.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithLine(ref LineD, out MyIntersectionResultLineTriangleEx?, IntersectionFlags)](VRage.ModAPI.IMyEntity@GetIntersectionWithLine)|Get intersection of model with provided line<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithLineAndBoundingSphere(ref LineD, float)](VRage.ModAPI.IMyEntity@GetIntersectionWithLineAndBoundingSphere)|Calculates intersection of line with any bounding sphere in this model instance. Center of the bounding sphere will be returned. It takes boundingSphereRadiusMultiplier argument which serves for extending the influence (radius) for interaction with line.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetIntersectionWithSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntity@GetIntersectionWithSphere)|Return true if object intersects specified sphere.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetInventory()](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetInventory(int)](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Search for inventory component with maching index.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetInventory()](VRage.ModAPI.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetInventory(int)](VRage.ModAPI.IMyEntity@GetInventory)|Search for inventory component with matching index.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetLargestDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetLargestDistanceBetweenCameraAndBoundingSphere)|Largest distance from camera to bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere. It's actually distance between camera and opposite side of the sphere<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetNaturalGravity()](Sandbox.ModAPI.Ingame.IMyShipController@GetNaturalGravity)|Gets the detected natural gravity vector and power at the current location.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[GetObjectBuilder(bool)](VRage.ModAPI.IMyEntity@GetObjectBuilder)|Returns object builder - object representing block state, and allows restore it. Used in game save, or syncing over network.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetObjectBuilderCubeBlock(bool)](VRage.Game.ModAPI.IMyCubeBlock@GetObjectBuilderCubeBlock)|Returns block object builder which can be serialized or added to grid<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[GetOwnerFactionTag()](VRage.Game.ModAPI.Ingame.IMyCubeBlock@GetOwnerFactionTag)|Tag of faction owning block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[GetPosition()](VRage.Game.ModAPI.Ingame.IMyEntity@GetPosition)|Gets position in world coordinates<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetProperties(List<ITerminalProperty>, Func<ITerminalProperty, bool>)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@GetProperties)|Get all terminal actions available for block.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[GetProperty(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@GetProperty)|Finds terminal property with provided id<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[GetShipSpeed()](Sandbox.ModAPI.Ingame.IMyShipController@GetShipSpeed)|Gets the basic ship speed in meters per second, for when you just need to know how fast you're going.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[GetShipVelocities()](Sandbox.ModAPI.Ingame.IMyShipController@GetShipVelocities)|Determines the linear velocities in meters per second and angular velocities in radians per second. Provides a more accurate representation of the directions and axis speeds.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[GetSmallestDistanceBetweenCameraAndBoundingSphere()](VRage.ModAPI.IMyEntity@GetSmallestDistanceBetweenCameraAndBoundingSphere)|Smallest distance between camera and bounding sphere of this phys object. Result is always positive, even if camera is inside the sphere.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetSubpart(string)](VRage.ModAPI.IMyEntity@GetSubpart)|Gets subpart by subpart name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetTopMostParent(Type)](VRage.ModAPI.IMyEntity@GetTopMostParent)|Gets top most [Parent](VRage.ModAPI.IMyEntity@Parent) of specified type. Top most is entity that doesn't have parent (of specified type)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetTotalGravity()](Sandbox.ModAPI.Ingame.IMyShipController@GetTotalGravity)|Gets the total accumulated gravity vector and power at the current location, taking both natural and artificial gravity into account.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[GetTrianglesIntersectingSphere(ref BoundingSphere, Vector3?, float?, List<MyTriangle_Vertex_Normals>, int)](VRage.ModAPI.IMyEntity@GetTrianglesIntersectingSphere)|Return list of triangles intersecting specified sphere. Angle between every triangleVertexes normal vector and 'referenceNormalVector' is calculated, and if more than 'maxAngle', we ignore such triangleVertexes. Triangles are returned in 'retTriangles', and this list must be preallocated! IMPORTANT: Sphere must be in model space, so don't transform it!<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetUserRelationToOwner(long, MyRelationsBetweenPlayerAndBlock)](VRage.Game.ModAPI.Ingame.IMyCubeBlock@GetUserRelationToOwner)|Gets relation to owner of block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix)|Get normalized, inverted world matrix. Same as [GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetWorldMatrix()](Sandbox.ModAPI.IMyTargetingCapableBlock@GetWorldMatrix)|Gets barrel or block world matrix<br /><br />_Inherited from [IMyTargetingCapableBlock](Sandbox.ModAPI.IMyTargetingCapableBlock)_|
|[GetWorldMatrixNormalizedInv()](VRage.ModAPI.IMyEntity@GetWorldMatrixNormalizedInv)|Get normalized, inverted world matrix. Same as [GetViewMatrix()](VRage.ModAPI.IMyEntity@GetViewMatrix) , [WorldMatrixNormalizedInv](VRage.ModAPI.IMyEntity@WorldMatrixNormalizedInv)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[HasLocalPlayerAccess()](Sandbox.ModAPI.Ingame.IMyTerminalBlock@HasLocalPlayerAccess)|Returns if local player can use block. Executes [HasPlayerAccess(long, MyRelationsBetweenPlayerAndBlock)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@HasPlayerAccess) with local player identityId. On Dedicated Server as identityId it is using 0 as playerId<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[HasNobodyPlayerAccessToBlock()](Sandbox.ModAPI.Ingame.IMyTerminalBlock@HasNobodyPlayerAccessToBlock)|Returns if Nobody has access to block.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[HasPlayerAccess(long, MyRelationsBetweenPlayerAndBlock)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@HasPlayerAccess)|Returns if local player can use block. It is also checking for admin access.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[HasPlayerAccessWithNobodyCheck(long, bool)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@HasPlayerAccessWithNobodyCheck)|Returns if player can use block. If playerId is 0 (Nobody), calls HasNobodyPlayerAccessToBlock instead It is also checking for admin access.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[Init()](VRage.Game.ModAPI.IMyCubeBlock@Init)|Reloads block model and interactive objects (doors, terminals, etc...)<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[Init(MyObjectBuilder_CubeBlock, IMyCubeGrid)](VRage.Game.ModAPI.IMyCubeBlock@Init)|Initializes block state from object builder<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[IsInSameLogicalGroupAs(IMyTerminalBlock)](Sandbox.ModAPI.IMyTerminalBlock@IsInSameLogicalGroupAs)|Determines whether this block is in the same logical group as the other, meaning they're connected either mechanically or via blocks like connectors. Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[IsSameConstructAs(IMyTerminalBlock)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@IsSameConstructAs)|Determines whether this block is [Mechanical](VRage.Game.ModAPI.GridLinkTypeEnum@Mechanical) connected to the other. This is any block connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.<br /><br />Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[IsSameConstructAs(IMyTerminalBlock)](Sandbox.ModAPI.IMyTerminalBlock@IsSameConstructAs)|Determines whether this block is mechanically connected to the other. This is any block connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct. Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[IsShipToolSelected()](Sandbox.ModAPI.IMyTargetingCapableBlock@IsShipToolSelected)|Get whether toolbar selected item is ship tool (drill, grinder, welder)<br /><br />_Inherited from [IMyTargetingCapableBlock](Sandbox.ModAPI.IMyTargetingCapableBlock)_|
|[IsTargetLockingEnabled()](Sandbox.ModAPI.IMyTargetingCapableBlock@IsTargetLockingEnabled)|Gets if target locking is enabled<br /><br />_Inherited from [IMyTargetingCapableBlock](Sandbox.ModAPI.IMyTargetingCapableBlock)_|
|[IsVisible()](VRage.ModAPI.IMyEntity@IsVisible)|Gets or result of function [IsVisible()](VRage.Game.Components.MyRenderComponentBase@IsVisible) . Function inside check for [IsVisible(IMyEntity)](VRage.ModAPI.IMyEntities@IsVisible)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Jump(Vector3)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Jump)|Character jump. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[MoveAndRotate(Vector3, Vector2, float)](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotate)|Defines user input. Call [MoveAndRotateStopped()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotateStopped) on user input finished<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[MoveAndRotateStopped()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@MoveAndRotateStopped)|Should be called when input is finished<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[OnAddedToScene(object)](VRage.ModAPI.IMyEntity@OnAddedToScene)|Adds entity to scene: init updates, render physics<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnBeginShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@OnBeginShoot)|This will be called back from the sync object both on local and remote clients<br /><br />_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[OnBuildSuccess(long)](VRage.Game.ModAPI.IMyCubeBlock@OnBuildSuccess)|Method called when a block has been built (after adding to the grid). This is called right after placing the block and it doesn't matter whether it is fully built (creative mode) or is only construction site. Note that it is not called for blocks which do not create FatBlock at that moment.<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[OnBuildSuccess(long, bool)](VRage.Game.ModAPI.IMyCubeBlock@OnBuildSuccess)|Method called when a block has been built (after adding to the grid). This is called right after placing the block and it doesn't matter whether it is fully built (creative mode) or is only construction site. Note that it is not called for blocks which do not create FatBlock at that moment.<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[OnDestroy()](VRage.Game.ModAPI.IMyCubeBlock@OnDestroy)|Called when block is destroyed before being removed from grid<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[OnEndShoot(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@OnEndShoot)|This will be called back from the sync object both on local and remote clients<br /><br />_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[OnModelChange()](VRage.Game.ModAPI.IMyCubeBlock@OnModelChange)|Called when the model referred by the block is changed<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[OnRegisteredToGridSystems()](VRage.Game.ModAPI.IMyCubeBlock@OnRegisteredToGridSystems)|Called at the end of registration from grid systems (after block has been registered).<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[OnRemovedByCubeBuilder()](VRage.Game.ModAPI.IMyCubeBlock@OnRemovedByCubeBuilder)|Method called when user removes a cube block from grid. Useful when block has to remove some other attached block (like motors).<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[OnRemovedFromScene(object)](VRage.ModAPI.IMyEntity@OnRemovedFromScene)|Remove entity and it's children from scene: stops updates and render, deactivates physics. Usually called when entity deleted<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[OnUnregisteredFromGridSystems()](VRage.Game.ModAPI.IMyCubeBlock@OnUnregisteredFromGridSystems)|Called at the end of unregistration from grid systems (after block has been unregistered).<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[PickUp()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PickUp)|Forwarding this action to [Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use) with argument [PickUp](VRage.Game.Entity.UseObject.UseActionEnum@PickUp)<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[PickUpContinues()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@PickUpContinues)|Forwarding this action to [Use(UseActionEnum, IMyEntity)](VRage.Game.Entity.UseObject.IMyUseObject@Use) with argument [PickUp](VRage.Game.Entity.UseObject.UseActionEnum@PickUp)<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[PickUpFinished()](Sandbox.Game.Entities.IMyControllableEntity@PickUpFinished)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[RaycastDetectors(Vector3D, Vector3D)](VRage.Game.ModAPI.IMyCubeBlock@RaycastDetectors)|Gets the name of interactive object intersected by defined line<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[RefreshCustomInfo()](Sandbox.ModAPI.IMyTerminalBlock@RefreshCustomInfo)|Raises AppendingCustomInfo so every subscriber can append custom info.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[ReloadDetectors(bool)](VRage.Game.ModAPI.IMyCubeBlock@ReloadDetectors)|Reloads detectors (interactive objects) in model<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[RemoveEffect(string, int)](VRage.Game.ModAPI.IMyCubeBlock@RemoveEffect)|Removes active effect set with SetEffect<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[SearchActionsOfName(string, List<ITerminalAction>, Func<ITerminalAction, bool>)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@SearchActionsOfName)|Get all terminal actions available for block. NOTE: First called `<br /><br />` and then `<br /><br />` check<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[SetColorMaskForSubparts(Vector3)](VRage.ModAPI.IMyEntity@SetColorMaskForSubparts)|Sets subparts custom col<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetDamageEffect(bool)](VRage.Game.ModAPI.IMyCubeBlock@SetDamageEffect)|Start or stop damage effect on cube block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[SetDetailedInfoDirty()](Sandbox.ModAPI.IMyTerminalBlock@SetDetailedInfoDirty)|Sets detailed info dirty and to be updated<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)_|
|[SetEffect(string, bool)](VRage.Game.ModAPI.IMyCubeBlock@SetEffect)|Activate block effect listed in definition<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[SetEffect(string, float, bool, bool, bool)](VRage.Game.ModAPI.IMyCubeBlock@SetEffect)|Activate block effect with parameters listed in definition See: Sandbox.Definitions.CubeBlockEffectBase<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)_|
|[SetEmissiveParts(string, Color, float)](VRage.ModAPI.IMyEntity@SetEmissiveParts)|Sets the emissive value of a specific emissive material on entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetEmissivePartsForSubparts(string, Color, float)](VRage.ModAPI.IMyEntity@SetEmissivePartsForSubparts)|Sets the emissive value of a specific emissive material on all entity subparts.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetLocalMatrix(Matrix, object)](VRage.ModAPI.IMyEntity@SetLocalMatrix)|Sets local matrix. When entity, has parent, it's world coordinates are calculated from localMatrix and parent world matrix<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetLockedTarget(IMyCubeGrid)](Sandbox.ModAPI.IMyTargetingCapableBlock@SetLockedTarget)|Sets locked target grid<br /><br />_Inherited from [IMyTargetingCapableBlock](Sandbox.ModAPI.IMyTargetingCapableBlock)_|
|[SetLockedTarget(IMyCharacter)](Sandbox.ModAPI.IMyTargetingCapableBlock@SetLockedTarget)|Sets locked target grid<br /><br />_Inherited from [IMyTargetingCapableBlock](Sandbox.ModAPI.IMyTargetingCapableBlock)_|
|[SetPosition(Vector3D)](VRage.ModAPI.IMyEntity@SetPosition)|Set WorldMatrix's [Translation](VRageMath.MatrixD@Translation) . Moves entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetTextureChangesForSubparts(Dictionary<MyStringId, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|Sets subparts custom skinning. Copy values from [TextureChanges](VRage.Game.Components.MyRenderComponentBase@TextureChanges) , then change needed keys. You can retrieve values for exact skin with following code:```csharp<br />MyDefinitionManager.Static.GetAssetModifierDefinitionForRender(skinId);<br /><br />```<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetWorldMatrix(MatrixD, object)](VRage.ModAPI.IMyEntity@SetWorldMatrix)|Sets world matrix of entity.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[ShouldEndShootingOnPause(MyShootActionEnum)](Sandbox.Game.Entities.IMyControllableEntity@ShouldEndShootingOnPause)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[ShowInventory()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowInventory)|Shows inventory gui of controlled Entity<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ShowRemoteAccessMenu()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowRemoteAccessMenu)|Shows remote access menu<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[ShowTerminal()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@ShowTerminal)|Shows terminal gui<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Sprint(bool)](Sandbox.Game.Entities.IMyControllableEntity@Sprint)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[SwitchAmmoMagazine()](Sandbox.Game.Entities.IMyControllableEntity@SwitchAmmoMagazine)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[SwitchBroadcasting()](Sandbox.Game.Entities.IMyControllableEntity@SwitchBroadcasting)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[SwitchDamping()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchDamping)|Switches damping state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchHandbrake()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchHandbrake)|Switches handbrake state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchHelmet()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchHelmet)|Switches helmet open/closed state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchLandingGears()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchLandingGears)|Switches landing gears state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchLights()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchLights)|Switches lights state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchReactors()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchReactors)|Switches reactors state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchReactorsLocal()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchReactorsLocal)|Switches handbrake state<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchThrusts()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchThrusts)|Turns on jetpack on character<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[SwitchToWeapon(MyDefinitionId)](Sandbox.Game.Entities.IMyControllableEntity@SwitchToWeapon)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[SwitchToWeapon(MyToolbarItemWeapon)](Sandbox.Game.Entities.IMyControllableEntity@SwitchToWeapon)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[SwitchWalk()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@SwitchWalk)|Switch between walk / run mode. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[Teleport(MatrixD, object, bool)](VRage.ModAPI.IMyEntity@Teleport)|When moving entity over large distances or when entity has children, using this method preferred over [SetPosition(Vector3D)](VRage.ModAPI.IMyEntity@SetPosition)<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[TryGetPlanetElevation(MyPlanetElevation, out double)](Sandbox.ModAPI.Ingame.IMyShipController@TryGetPlanetElevation)|Attempts to get the elevation of the ship in relation to the nearest planet. This method is only available when a ship is within the gravity well of a planet.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[TryGetPlanetPosition(out Vector3D)](Sandbox.ModAPI.Ingame.IMyShipController@TryGetPlanetPosition)|Attempts to get the world position of the nearest planet. This method is only available when a ship is within the gravity well of a planet.<br /><br />_Inherited from [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)_|
|[TryGetSubpart(string, out MyEntitySubpart)](VRage.ModAPI.IMyEntity@TryGetSubpart)|Gets subpart by subpart name<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Up()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Up)|Move direction : up. Only [IMyCharacter](VRage.Game.ModAPI.IMyCharacter) has implementation for this method.<br /><br />_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[UpdateGamePruningStructure()](VRage.ModAPI.IMyEntity@UpdateGamePruningStructure)|Update position of entity in MyGamePruningStructure. Calls:```csharp<br />MyGamePruningStructure.Move(this)<br /><br />```<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[Use()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@Use)|_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[UseContinues()](VRage.Game.ModAPI.Interfaces.IMyControllableEntity@UseContinues)|_Inherited from [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)_|
|[UseFinished()](Sandbox.Game.Entities.IMyControllableEntity@UseFinished)|_Inherited from [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)_|
|[AddToGamePruningStructure()](VRage.ModAPI.IMyEntity@AddToGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[GetPlayerRelationToOwner()](VRage.Game.ModAPI.Ingame.IMyCubeBlock@GetPlayerRelationToOwner)|_**Obsolete:** GetPlayerRelationToOwner() is useless ingame. Mods should use the one in ModAPI.IMyCubeBlock_<br /><br />Relation of local player to the block Should not be called on Dedicated Server.<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[GetUpgrades(out Dictionary<string, float>)](Sandbox.ModAPI.Ingame.IMyUpgradableBlock@GetUpgrades)|_**Obsolete:** Use FillUpgradesDictionary without the out parameter instead._<br /><br />Obsolete<br /><br />_Inherited from [IMyUpgradableBlock](Sandbox.ModAPI.Ingame.IMyUpgradableBlock)_|
|[RemoveFromGamePruningStructure()](VRage.ModAPI.IMyEntity@RemoveFromGamePruningStructure)|_**Obsolete:** Only used during Sandbox removal._<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[SetCustomName(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@SetCustomName)|_**Obsolete:** Use the setter of Customname_<br /><br />Obsolete<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[SetCustomName(StringBuilder)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@SetCustomName)|_**Obsolete:** Use the setter of Customname_<br /><br />Obsolete<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[SetTextureChangesForSubparts(Dictionary<string, MyTextureChange>)](VRage.ModAPI.IMyEntity@SetTextureChangesForSubparts)|_**Obsolete**_<br /><br />This calling is obsolete, use another version.<br /><br />_Inherited from [IMyEntity](VRage.ModAPI.IMyEntity)_|
|[UpdateIsWorking()](VRage.Game.ModAPI.Ingame.IMyCubeBlock@UpdateIsWorking)|_**Obsolete**_<br /><br />Force refresh working state. Call if you change block state that could affect its working status.<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[UpdateVisual()](VRage.Game.ModAPI.Ingame.IMyCubeBlock@UpdateVisual)|_**Obsolete**_<br /><br />Updates block visuals (ie. block emissivity)<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|

**Inheritance:**   MyTerminalBlock <sub>prohibited</sub>

**Implements:**  
* [IMyComponentOwner<MyIDModule>](VRage.Game.Components.IMyComponentOwner{MyIDModule})  
* [IMyControllableEntity](Sandbox.Game.Entities.IMyControllableEntity)  
* [IMyControllableEntity](VRage.Game.ModAPI.Interfaces.IMyControllableEntity)  
* [IMyCubeBlock](VRage.Game.ModAPI.IMyCubeBlock)  
* [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)  
* [IMyEntity](VRage.ModAPI.IMyEntity)  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)  
* IMyEventOwner <sub>prohibited</sub>  
* [IMyEventProxy](VRage.Network.IMyEventProxy)  
* IMyPilotable <sub>prohibited</sub>  
* IMyRechargeSocketOwner <sub>prohibited</sub>  
* IMyShipControl <sub>prohibited</sub>  
* [IMyShipController](Sandbox.ModAPI.IMyShipController)  
* [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)  
* [IMyShootOrigin](Sandbox.ModAPI.IMyShootOrigin)  
* IMySyncedEntity <sub>prohibited</sub>  
* [IMyTargetingCapableBlock](Sandbox.ModAPI.IMyTargetingCapableBlock)  
* [IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock)  
* [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)  
* [IMyUpgradableBlock](Sandbox.ModAPI.IMyUpgradableBlock)  
* [IMyUpgradableBlock](Sandbox.ModAPI.Ingame.IMyUpgradableBlock)  
* IMyWheelControllableEntity <sub>prohibited</sub>

**Inheritors:**  
* [MyCockpit](Sandbox.Game.Entities.MyCockpit)  
* [MyRemoteControl](Sandbox.Game.Entities.MyRemoteControl)

