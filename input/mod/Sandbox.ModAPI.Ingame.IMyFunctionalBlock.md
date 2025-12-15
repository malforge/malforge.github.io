**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyFunctionalBlock: IMyTerminalBlock, IMyCubeBlock, IMyEntity
```

Describes functional block (block with Enabled/Disabled toggle) (PB scripting interface)

## Properties

|Member|Description|
|---|---|
|[Enabled](Sandbox.ModAPI.Ingame.IMyFunctionalBlock@Enabled)|Represents terminal gui toggle. Gets or sets if block is Enabled|
|[BlockDefinition](VRage.Game.ModAPI.Ingame.IMyCubeBlock@BlockDefinition)|Gets definition.Id assigned to this block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[Closed](VRage.Game.ModAPI.Ingame.IMyEntity@Closed)|True if the block has been removed from the world.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[Components](VRage.Game.ModAPI.Ingame.IMyEntity@Components)|Gets blocks component logic container<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[CubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeBlock@CubeGrid)|Grid in which the block is placed<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[CustomData](Sandbox.ModAPI.Ingame.IMyTerminalBlock@CustomData)|Gets or sets the Custom Data string. NOTE: Only use this for user input. For storing large mod configs, create your own MyModStorageComponent<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[CustomInfo](Sandbox.ModAPI.Ingame.IMyTerminalBlock@CustomInfo)|Gets information about block status (available from mods) [AppendingCustomInfo](Sandbox.ModAPI.IMyTerminalBlock@AppendingCustomInfo)  [RefreshCustomInfo()](Sandbox.ModAPI.IMyTerminalBlock@RefreshCustomInfo) .<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[CustomName](Sandbox.ModAPI.Ingame.IMyTerminalBlock@CustomName)|Gets or sets how block is named in Terminal menu<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[CustomNameWithFaction](Sandbox.ModAPI.Ingame.IMyTerminalBlock@CustomNameWithFaction)|Gets or sets how block is named in Terminal menu. Work only for Cockpit, LaserAntenna RadioAntenna, SpaceBall, Beacon<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[DefinitionDisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DefinitionDisplayNameText)|Definition name<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[DetailedInfo](Sandbox.ModAPI.Ingame.IMyTerminalBlock@DetailedInfo)|Gets information about block status. In Control panel bottom right text<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[DisassembleRatio](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisassembleRatio)|Is set in definition Ratio at which is the block disassembled (grinding) Bigger values - longer grinding<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[DisplayName](VRage.Game.ModAPI.Ingame.IMyEntity@DisplayName)|Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisplayNameText)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisplayNameText)|Translated block name<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[EntityId](VRage.Game.ModAPI.Ingame.IMyEntity@EntityId)|Id of entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[HasInventory](VRage.Game.ModAPI.Ingame.IMyEntity@HasInventory)|Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[InventoryCount](VRage.Game.ModAPI.Ingame.IMyEntity@InventoryCount)|Returns the count of the number of inventories this entity has.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[IsBeingHacked](VRage.Game.ModAPI.Ingame.IMyCubeBlock@IsBeingHacked)|Hacking of the block is in progress<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[IsFunctional](VRage.Game.ModAPI.Ingame.IMyCubeBlock@IsFunctional)|Gets if integrity is above breaking threshold<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[IsWorking](VRage.Game.ModAPI.Ingame.IMyCubeBlock@IsWorking)|True if block is able to do its work depening on block type (is functional, powered, enabled, etc...)<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[Mass](VRage.Game.ModAPI.Ingame.IMyCubeBlock@Mass)|Block mass<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[Max](VRage.Game.ModAPI.Ingame.IMyCubeBlock@Max)|Maximum coordinates of grid cells occupied by this block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[Min](VRage.Game.ModAPI.Ingame.IMyCubeBlock@Min)|Minimum coordinates of grid cells occupied by this block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[Name](VRage.Game.ModAPI.Ingame.IMyEntity@Name)|Some entities can have uniq name, and game can find them by name [TryGetEntityByName(string, out IMyEntity)](VRage.ModAPI.IMyEntities@TryGetEntityByName)<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[NumberInGrid](VRage.Game.ModAPI.Ingame.IMyCubeBlock@NumberInGrid)|Order in which were the blocks of same type added to grid Used in default display name<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[Orientation](VRage.Game.ModAPI.Ingame.IMyCubeBlock@Orientation)|Returns block orientation in base 6 directions<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[OwnerId](VRage.Game.ModAPI.Ingame.IMyCubeBlock@OwnerId)|IdentityId of player owning block (not steam Id)<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[Position](VRage.Game.ModAPI.Ingame.IMyCubeBlock@Position)|Position in grid coordinates<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[ShowInInventory](Sandbox.ModAPI.Ingame.IMyTerminalBlock@ShowInInventory)|Represent terminal gui toggle `Show block in Inventory Screen`. Gets or sets its value<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[ShowInTerminal](Sandbox.ModAPI.Ingame.IMyTerminalBlock@ShowInTerminal)|Represent terminal gui toggle `Show block in terminal`. Gets or sets its value<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[ShowInToolbarConfig](Sandbox.ModAPI.Ingame.IMyTerminalBlock@ShowInToolbarConfig)|Represent terminal gui toggle `Show in toolbar config`. Gets or sets its value<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[ShowOnHUD](Sandbox.ModAPI.Ingame.IMyTerminalBlock@ShowOnHUD)|Represent terminal gui toggle `Show On HUD`. Gets or sets its value<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[WorldAABB](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABB)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldAABBHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABBHr)|Gets world axis-aligned bounding box<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldMatrix](VRage.Game.ModAPI.Ingame.IMyEntity@WorldMatrix)|Gets world matrix of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldVolume](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolume)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[WorldVolumeHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolumeHr)|Gets bounding sphere of this entity<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|

## Methods

|Member|Description|
|---|---|
|[GetActions(List<ITerminalAction>, Func<ITerminalAction, bool>)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@GetActions)|Get all terminal actions available for block<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[GetActionWithName(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@GetActionWithName)|Get first found terminal action with name<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[GetInventory()](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetInventory(int)](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Search for inventory component with maching index.<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetOwnerFactionTag()](VRage.Game.ModAPI.Ingame.IMyCubeBlock@GetOwnerFactionTag)|Tag of faction owning block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[GetPosition()](VRage.Game.ModAPI.Ingame.IMyEntity@GetPosition)|Gets position in world coordinates<br /><br />_Inherited from [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)_|
|[GetProperties(List<ITerminalProperty>, Func<ITerminalProperty, bool>)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@GetProperties)|Get all terminal actions available for block.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[GetProperty(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@GetProperty)|Finds terminal property with provided id<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[GetUserRelationToOwner(long, MyRelationsBetweenPlayerAndBlock)](VRage.Game.ModAPI.Ingame.IMyCubeBlock@GetUserRelationToOwner)|Gets relation to owner of block<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[HasLocalPlayerAccess()](Sandbox.ModAPI.Ingame.IMyTerminalBlock@HasLocalPlayerAccess)|Returns if local player can use block. Executes [HasPlayerAccess(long, MyRelationsBetweenPlayerAndBlock)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@HasPlayerAccess) with local player identityId. On Dedicated Server as identityId it is using 0 as playerId<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[HasNobodyPlayerAccessToBlock()](Sandbox.ModAPI.Ingame.IMyTerminalBlock@HasNobodyPlayerAccessToBlock)|Returns if Nobody has access to block.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[HasPlayerAccess(long, MyRelationsBetweenPlayerAndBlock)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@HasPlayerAccess)|Returns if local player can use block. It is also checking for admin access.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[HasPlayerAccessWithNobodyCheck(long, bool)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@HasPlayerAccessWithNobodyCheck)|Returns if player can use block. If playerId is 0 (Nobody), calls HasNobodyPlayerAccessToBlock instead It is also checking for admin access.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[IsSameConstructAs(IMyTerminalBlock)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@IsSameConstructAs)|Determines whether this block is [Mechanical](VRage.Game.ModAPI.GridLinkTypeEnum@Mechanical) connected to the other. This is any block connected with rotors or pistons or other mechanical devices, but not things like connectors. This will in most cases constitute your complete construct.<br /><br />Be aware that using merge blocks combines grids into one, so this function will not filter out grids connected that way. Also be aware that detaching the heads of pistons and rotors will cause this connection to change.<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[SearchActionsOfName(string, List<ITerminalAction>, Func<ITerminalAction, bool>)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@SearchActionsOfName)|Get all terminal actions available for block. NOTE: First called `<br /><br />` and then `<br /><br />` check<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[RequestEnable(bool)](Sandbox.ModAPI.Ingame.IMyFunctionalBlock@RequestEnable)|_**Obsolete:** Use the setter of Enabled_<br /><br />Obsolete|
|[GetPlayerRelationToOwner()](VRage.Game.ModAPI.Ingame.IMyCubeBlock@GetPlayerRelationToOwner)|_**Obsolete:** GetPlayerRelationToOwner() is useless ingame. Mods should use the one in ModAPI.IMyCubeBlock_<br /><br />Relation of local player to the block Should not be called on Dedicated Server.<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[SetCustomName(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@SetCustomName)|_**Obsolete:** Use the setter of Customname_<br /><br />Obsolete<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[SetCustomName(StringBuilder)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@SetCustomName)|_**Obsolete:** Use the setter of Customname_<br /><br />Obsolete<br /><br />_Inherited from [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)_|
|[UpdateIsWorking()](VRage.Game.ModAPI.Ingame.IMyCubeBlock@UpdateIsWorking)|_**Obsolete**_<br /><br />Force refresh working state. Call if you change block state that could affect its working status.<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|
|[UpdateVisual()](VRage.Game.ModAPI.Ingame.IMyCubeBlock@UpdateVisual)|_**Obsolete**_<br /><br />Updates block visuals (ie. block emissivity)<br /><br />_Inherited from [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)_|

**Implements:**  
* [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)  
* [IMyEntity](VRage.Game.ModAPI.Ingame.IMyEntity)  
* [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)

**Inheritors:**  
* [IMyAdvancedDoor](Sandbox.ModAPI.IMyAdvancedDoor)  
* [IMyAdvancedDoor](Sandbox.ModAPI.Ingame.IMyAdvancedDoor)  
* [IMyAirtightDoorBase](Sandbox.ModAPI.IMyAirtightDoorBase)  
* [IMyAirtightDoorBase](Sandbox.ModAPI.Ingame.IMyAirtightDoorBase)  
* [IMyAirtightHangarDoor](Sandbox.ModAPI.IMyAirtightHangarDoor)  
* [IMyAirtightHangarDoor](Sandbox.ModAPI.Ingame.IMyAirtightHangarDoor)  
* [IMyAirtightSlideDoor](Sandbox.ModAPI.IMyAirtightSlideDoor)  
* [IMyAirtightSlideDoor](Sandbox.ModAPI.Ingame.IMyAirtightSlideDoor)  
* [IMyAirVent](SpaceEngineers.Game.ModAPI.IMyAirVent)  
* [IMyAirVent](SpaceEngineers.Game.ModAPI.Ingame.IMyAirVent)  
* [IMyArtificialMassBlock](SpaceEngineers.Game.ModAPI.IMyArtificialMassBlock)  
* [IMyArtificialMassBlock](SpaceEngineers.Game.ModAPI.Ingame.IMyArtificialMassBlock)  
* [IMyAssembler](Sandbox.ModAPI.IMyAssembler)  
* [IMyAssembler](Sandbox.ModAPI.Ingame.IMyAssembler)  
* [IMyBasicMissionBlock](Sandbox.ModAPI.IMyBasicMissionBlock)  
* [IMyBasicMissionBlock](Sandbox.ModAPI.Ingame.IMyBasicMissionBlock)  
* [IMyBatteryBlock](Sandbox.ModAPI.IMyBatteryBlock)  
* [IMyBatteryBlock](Sandbox.ModAPI.Ingame.IMyBatteryBlock)  
* [IMyBeacon](Sandbox.ModAPI.IMyBeacon)  
* [IMyBeacon](Sandbox.ModAPI.Ingame.IMyBeacon)  
* [IMyBroadcastController](SpaceEngineers.Game.ModAPI.IMyBroadcastController)  
* [IMyBroadcastController](SpaceEngineers.Game.ModAPI.Ingame.IMyBroadcastController)  
* [IMyBroadcastControllerBlock](Sandbox.ModAPI.Ingame.IMyBroadcastControllerBlock)  
* [IMyCameraBlock](Sandbox.ModAPI.IMyCameraBlock)  
* [IMyCameraBlock](Sandbox.ModAPI.Ingame.IMyCameraBlock)  
* [IMyCollector](Sandbox.ModAPI.IMyCollector)  
* [IMyCollector](Sandbox.ModAPI.Ingame.IMyCollector)  
* [IMyConveyorSorter](Sandbox.ModAPI.IMyConveyorSorter)  
* [IMyConveyorSorter](Sandbox.ModAPI.Ingame.IMyConveyorSorter)  
* [IMyDecoy](Sandbox.ModAPI.IMyDecoy)  
* [IMyDecoy](Sandbox.ModAPI.Ingame.IMyDecoy)  
* [IMyDefensiveCombatBlock](Sandbox.ModAPI.IMyDefensiveCombatBlock)  
* [IMyDefensiveCombatBlock](Sandbox.ModAPI.Ingame.IMyDefensiveCombatBlock)  
* [IMyDoor](Sandbox.ModAPI.IMyDoor)  
* [IMyDoor](Sandbox.ModAPI.Ingame.IMyDoor)  
* [IMyEmotionControllerBlock](Sandbox.ModAPI.IMyEmotionControllerBlock)  
* [IMyEmotionControllerBlock](Sandbox.ModAPI.Ingame.IMyEmotionControllerBlock)  
* [IMyEventControllerBlock](Sandbox.ModAPI.IMyEventControllerBlock)  
* [IMyEventControllerBlock](Sandbox.ModAPI.Ingame.IMyEventControllerBlock)  
* [IMyExhaustBlock](Sandbox.ModAPI.IMyExhaustBlock)  
* [IMyExtendedPistonBase](Sandbox.ModAPI.IMyExtendedPistonBase)  
* [IMyExtendedPistonBase](Sandbox.ModAPI.Ingame.IMyExtendedPistonBase)  
* [IMyFlightMovementBlock](Sandbox.ModAPI.IMyFlightMovementBlock)  
* [IMyFlightMovementBlock](Sandbox.ModAPI.Ingame.IMyFlightMovementBlock)  
* [IMyFunctionalBlock](Sandbox.ModAPI.IMyFunctionalBlock)  
* [IMyGasGenerator](Sandbox.ModAPI.IMyGasGenerator)  
* [IMyGasGenerator](Sandbox.ModAPI.Ingame.IMyGasGenerator)  
* [IMyGasTank](Sandbox.ModAPI.IMyGasTank)  
* [IMyGasTank](Sandbox.ModAPI.Ingame.IMyGasTank)  
* [IMyGravityGenerator](SpaceEngineers.Game.ModAPI.IMyGravityGenerator)  
* [IMyGravityGenerator](SpaceEngineers.Game.ModAPI.Ingame.IMyGravityGenerator)  
* [IMyGravityGeneratorBase](SpaceEngineers.Game.ModAPI.IMyGravityGeneratorBase)  
* [IMyGravityGeneratorBase](SpaceEngineers.Game.ModAPI.Ingame.IMyGravityGeneratorBase)  
* [IMyGravityGeneratorSphere](SpaceEngineers.Game.ModAPI.IMyGravityGeneratorSphere)  
* [IMyGravityGeneratorSphere](SpaceEngineers.Game.ModAPI.Ingame.IMyGravityGeneratorSphere)  
* [IMyGyro](Sandbox.ModAPI.IMyGyro)  
* [IMyGyro](Sandbox.ModAPI.Ingame.IMyGyro)  
* [IMyHeatVent](SpaceEngineers.Game.ModAPI.IMyHeatVent)  
* [IMyHeatVent](SpaceEngineers.Game.ModAPI.Ingame.IMyHeatVent)  
* [IMyInteriorLight](SpaceEngineers.Game.ModAPI.IMyInteriorLight)  
* [IMyInteriorLight](SpaceEngineers.Game.ModAPI.Ingame.IMyInteriorLight)  
* [IMyJumpDrive](Sandbox.ModAPI.IMyJumpDrive)  
* [IMyJumpDrive](Sandbox.ModAPI.Ingame.IMyJumpDrive)  
* [IMyLandingGear](SpaceEngineers.Game.ModAPI.IMyLandingGear)  
* [IMyLandingGear](SpaceEngineers.Game.ModAPI.Ingame.IMyLandingGear)  
* [IMyLargeConveyorTurretBase](SpaceEngineers.Game.ModAPI.IMyLargeConveyorTurretBase)  
* [IMyLargeConveyorTurretBase](SpaceEngineers.Game.ModAPI.Ingame.IMyLargeConveyorTurretBase)  
* [IMyLargeGatlingTurret](SpaceEngineers.Game.ModAPI.IMyLargeGatlingTurret)  
* [IMyLargeGatlingTurret](SpaceEngineers.Game.ModAPI.Ingame.IMyLargeGatlingTurret)  
* [IMyLargeInteriorTurret](SpaceEngineers.Game.ModAPI.IMyLargeInteriorTurret)  
* [IMyLargeInteriorTurret](SpaceEngineers.Game.ModAPI.Ingame.IMyLargeInteriorTurret)  
* [IMyLargeMissileTurret](SpaceEngineers.Game.ModAPI.IMyLargeMissileTurret)  
* [IMyLargeMissileTurret](SpaceEngineers.Game.ModAPI.Ingame.IMyLargeMissileTurret)  
* [IMyLargeTurretBase](Sandbox.ModAPI.IMyLargeTurretBase)  
* [IMyLargeTurretBase](Sandbox.ModAPI.Ingame.IMyLargeTurretBase)  
* [IMyLaserAntenna](Sandbox.ModAPI.IMyLaserAntenna)  
* [IMyLaserAntenna](Sandbox.ModAPI.Ingame.IMyLaserAntenna)  
* [IMyLightingBlock](Sandbox.ModAPI.IMyLightingBlock)  
* [IMyLightingBlock](Sandbox.ModAPI.Ingame.IMyLightingBlock)  
* [IMyMechanicalConnectionBlock](Sandbox.ModAPI.IMyMechanicalConnectionBlock)  
* [IMyMechanicalConnectionBlock](Sandbox.ModAPI.Ingame.IMyMechanicalConnectionBlock)  
* [IMyMedicalRoom](SpaceEngineers.Game.ModAPI.IMyMedicalRoom)  
* [IMyMedicalRoom](SpaceEngineers.Game.ModAPI.Ingame.IMyMedicalRoom)  
* [IMyMotorAdvancedStator](Sandbox.ModAPI.IMyMotorAdvancedStator)  
* [IMyMotorAdvancedStator](Sandbox.ModAPI.Ingame.IMyMotorAdvancedStator)  
* [IMyMotorBase](Sandbox.ModAPI.IMyMotorBase)  
* [IMyMotorBase](Sandbox.ModAPI.Ingame.IMyMotorBase)  
* [IMyMotorStator](Sandbox.ModAPI.IMyMotorStator)  
* [IMyMotorStator](Sandbox.ModAPI.Ingame.IMyMotorStator)  
* [IMyMotorSuspension](Sandbox.ModAPI.IMyMotorSuspension)  
* [IMyMotorSuspension](Sandbox.ModAPI.Ingame.IMyMotorSuspension)  
* [IMyOffensiveCombatBlock](Sandbox.ModAPI.IMyOffensiveCombatBlock)  
* [IMyOffensiveCombatBlock](Sandbox.ModAPI.Ingame.IMyOffensiveCombatBlock)  
* [IMyOreDetector](Sandbox.ModAPI.IMyOreDetector)  
* [IMyOreDetector](Sandbox.ModAPI.Ingame.IMyOreDetector)  
* [IMyOxygenFarm](SpaceEngineers.Game.ModAPI.IMyOxygenFarm)  
* [IMyOxygenFarm](SpaceEngineers.Game.ModAPI.Ingame.IMyOxygenFarm)  
* [IMyParachute](SpaceEngineers.Game.ModAPI.IMyParachute)  
* [IMyParachute](SpaceEngineers.Game.ModAPI.Ingame.IMyParachute)  
* [IMyPathRecorderBlock](Sandbox.ModAPI.IMyPathRecorderBlock)  
* [IMyPathRecorderBlock](Sandbox.ModAPI.Ingame.IMyPathRecorderBlock)  
* [IMyPistonBase](Sandbox.ModAPI.IMyPistonBase)  
* [IMyPistonBase](Sandbox.ModAPI.Ingame.IMyPistonBase)  
* [IMyPowerProducer](Sandbox.ModAPI.IMyPowerProducer)  
* [IMyPowerProducer](Sandbox.ModAPI.Ingame.IMyPowerProducer)  
* [IMyProductionBlock](Sandbox.ModAPI.IMyProductionBlock)  
* [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)  
* [IMyProgrammableBlock](Sandbox.ModAPI.IMyProgrammableBlock)  
* [IMyProgrammableBlock](Sandbox.ModAPI.Ingame.IMyProgrammableBlock)  
* [IMyProjector](Sandbox.ModAPI.IMyProjector)  
* [IMyProjector](Sandbox.ModAPI.Ingame.IMyProjector)  
* [IMyRadioAntenna](Sandbox.ModAPI.IMyRadioAntenna)  
* [IMyRadioAntenna](Sandbox.ModAPI.Ingame.IMyRadioAntenna)  
* [IMyReactor](Sandbox.ModAPI.IMyReactor)  
* [IMyReactor](Sandbox.ModAPI.Ingame.IMyReactor)  
* [IMyRefinery](Sandbox.ModAPI.IMyRefinery)  
* [IMyRefinery](Sandbox.ModAPI.Ingame.IMyRefinery)  
* [IMyReflectorLight](Sandbox.ModAPI.IMyReflectorLight)  
* [IMyReflectorLight](Sandbox.ModAPI.Ingame.IMyReflectorLight)  
* [IMySafeZoneBlock](SpaceEngineers.Game.ModAPI.IMySafeZoneBlock)  
* [IMySafeZoneBlock](SpaceEngineers.Game.ModAPI.Ingame.IMySafeZoneBlock)  
* [IMySearchlight](Sandbox.ModAPI.IMySearchlight)  
* [IMySearchlight](Sandbox.ModAPI.Ingame.IMySearchlight)  
* [IMySensorBlock](Sandbox.ModAPI.IMySensorBlock)  
* [IMySensorBlock](Sandbox.ModAPI.Ingame.IMySensorBlock)  
* [IMyShipConnector](Sandbox.ModAPI.IMyShipConnector)  
* [IMyShipConnector](Sandbox.ModAPI.Ingame.IMyShipConnector)  
* [IMyShipDrill](Sandbox.ModAPI.IMyShipDrill)  
* [IMyShipDrill](Sandbox.ModAPI.Ingame.IMyShipDrill)  
* [IMyShipGrinder](Sandbox.ModAPI.IMyShipGrinder)  
* [IMyShipGrinder](Sandbox.ModAPI.Ingame.IMyShipGrinder)  
* [IMyShipMergeBlock](SpaceEngineers.Game.ModAPI.IMyShipMergeBlock)  
* [IMyShipMergeBlock](SpaceEngineers.Game.ModAPI.Ingame.IMyShipMergeBlock)  
* [IMyShipToolBase](Sandbox.ModAPI.IMyShipToolBase)  
* [IMyShipToolBase](Sandbox.ModAPI.Ingame.IMyShipToolBase)  
* [IMyShipWelder](Sandbox.ModAPI.IMyShipWelder)  
* [IMyShipWelder](Sandbox.ModAPI.Ingame.IMyShipWelder)  
* [IMySmallGatlingGun](Sandbox.ModAPI.IMySmallGatlingGun)  
* [IMySmallGatlingGun](Sandbox.ModAPI.Ingame.IMySmallGatlingGun)  
* [IMySmallMissileLauncher](Sandbox.ModAPI.IMySmallMissileLauncher)  
* [IMySmallMissileLauncher](Sandbox.ModAPI.Ingame.IMySmallMissileLauncher)  
* [IMySmallMissileLauncherReload](Sandbox.ModAPI.IMySmallMissileLauncherReload)  
* [IMySmallMissileLauncherReload](Sandbox.ModAPI.Ingame.IMySmallMissileLauncherReload)  
* [IMySolarPanel](SpaceEngineers.Game.ModAPI.IMySolarPanel)  
* [IMySolarPanel](SpaceEngineers.Game.ModAPI.Ingame.IMySolarPanel)  
* [IMySoundBlock](SpaceEngineers.Game.ModAPI.IMySoundBlock)  
* [IMySoundBlock](SpaceEngineers.Game.ModAPI.Ingame.IMySoundBlock)  
* [IMySpaceBall](SpaceEngineers.Game.ModAPI.IMySpaceBall)  
* [IMySpaceBall](SpaceEngineers.Game.ModAPI.Ingame.IMySpaceBall)  
* [IMyStoreBlock](Sandbox.ModAPI.IMyStoreBlock)  
* [IMyStoreBlock](Sandbox.ModAPI.Ingame.IMyStoreBlock)  
* [IMyTargetDummyBlock](Sandbox.ModAPI.IMyTargetDummyBlock)  
* [IMyTargetDummyBlock](Sandbox.ModAPI.Ingame.IMyTargetDummyBlock)  
* [IMyTextPanel](Sandbox.ModAPI.IMyTextPanel)  
* [IMyTextPanel](Sandbox.ModAPI.Ingame.IMyTextPanel)  
* [IMyThrust](Sandbox.ModAPI.IMyThrust)  
* [IMyThrust](Sandbox.ModAPI.Ingame.IMyThrust)  
* [IMyTimerBlock](SpaceEngineers.Game.ModAPI.IMyTimerBlock)  
* [IMyTimerBlock](SpaceEngineers.Game.ModAPI.Ingame.IMyTimerBlock)  
* [IMyTransponder](SpaceEngineers.Game.ModAPI.IMyTransponder)  
* [IMyTransponder](SpaceEngineers.Game.ModAPI.Ingame.IMyTransponder)  
* [IMyTurretControlBlock](SpaceEngineers.Game.ModAPI.IMyTurretControlBlock)  
* [IMyTurretControlBlock](SpaceEngineers.Game.ModAPI.Ingame.IMyTurretControlBlock)  
* [IMyUpgradeModule](Sandbox.ModAPI.IMyUpgradeModule)  
* [IMyUpgradeModule](Sandbox.ModAPI.Ingame.IMyUpgradeModule)  
* [IMyUserControllableGun](Sandbox.ModAPI.IMyUserControllableGun)  
* [IMyUserControllableGun](Sandbox.ModAPI.Ingame.IMyUserControllableGun)  
* [IMyVendingMachine](Sandbox.ModAPI.IMyVendingMachine)  
* [IMyVirtualMass](SpaceEngineers.Game.ModAPI.IMyVirtualMass)  
* [IMyVirtualMass](SpaceEngineers.Game.ModAPI.Ingame.IMyVirtualMass)  
* [IMyWindTurbine](Sandbox.ModAPI.IMyWindTurbine)  
* [IMyWindTurbine](Sandbox.ModAPI.Ingame.IMyWindTurbine)  
* [MyAdvancedDoor](Sandbox.Game.Entities.MyAdvancedDoor)  
* [MyAirtightDoorGeneric](Sandbox.Game.Entities.MyAirtightDoorGeneric)  
* [MyAirtightHangarDoor](Sandbox.Game.Entities.MyAirtightHangarDoor)  
* [MyAirtightSlideDoor](Sandbox.Game.Entities.MyAirtightSlideDoor)  
* [MyBatteryBlock](Sandbox.Game.Entities.MyBatteryBlock)  
* [MyCameraBlock](Sandbox.Game.Entities.MyCameraBlock)  
* [MyConveyorSorter](Sandbox.Game.Entities.MyConveyorSorter)  
* [MyDoor](Sandbox.Game.Entities.MyDoor)  
* [MyDoorBase](Sandbox.Game.Entities.MyDoorBase)  
* [MyFueledPowerProducer](Sandbox.Game.Entities.MyFueledPowerProducer)  
* [MyGyro](Sandbox.Game.Entities.MyGyro)  
* [MyJumpDrive](Sandbox.Game.Entities.MyJumpDrive)  
* [MyReactor](Sandbox.Game.Entities.MyReactor)  
* [MyReflectorLight](Sandbox.Game.Entities.MyReflectorLight)  
* [MyThrust](Sandbox.Game.Entities.MyThrust)

