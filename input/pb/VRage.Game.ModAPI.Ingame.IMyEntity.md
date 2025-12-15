**Assembly:** VRage.Game.dll

```csharp
public interface IMyEntity
```

Interface for all entities. (PB scripting interface)

## Properties

|Member|Description|
|---|---|
|[Closed](VRage.Game.ModAPI.Ingame.IMyEntity@Closed)|True if the block has been removed from the world.|
|[Components](VRage.Game.ModAPI.Ingame.IMyEntity@Components)|Gets blocks component logic container|
|[DisplayName](VRage.Game.ModAPI.Ingame.IMyEntity@DisplayName)|Gets user friendly name of entity. May be null For block terminal name use [DisplayNameText](VRage.Game.ModAPI.Ingame.IMyCubeBlock@DisplayNameText) |
|[EntityId](VRage.Game.ModAPI.Ingame.IMyEntity@EntityId)|Id of entity|
|[HasInventory](VRage.Game.ModAPI.Ingame.IMyEntity@HasInventory)|Returns true if this entity has got at least one inventory. Note that one aggregate inventory can contain zero simple inventories => zero will be returned even if GetInventory() != null.|
|[InventoryCount](VRage.Game.ModAPI.Ingame.IMyEntity@InventoryCount)|Returns the count of the number of inventories this entity has.|
|[Name](VRage.Game.ModAPI.Ingame.IMyEntity@Name)|Some entities can have uniq name, and game can find them by name `IMyEntities.TryGetEntityByName`<sub>prohibited</sub> |
|[WorldAABB](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABB)|Gets world axis-aligned bounding box|
|[WorldAABBHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldAABBHr)|Gets world axis-aligned bounding box|
|[WorldMatrix](VRage.Game.ModAPI.Ingame.IMyEntity@WorldMatrix)|Gets world matrix of this entity|
|[WorldVolume](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolume)|Gets bounding sphere of this entity|
|[WorldVolumeHr](VRage.Game.ModAPI.Ingame.IMyEntity@WorldVolumeHr)|Gets bounding sphere of this entity|

## Methods

|Member|Description|
|---|---|
|[GetInventory()](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Simply get the MyInventoryBase component stored in this entity.|
|[GetInventory(int)](VRage.Game.ModAPI.Ingame.IMyEntity@GetInventory)|Search for inventory component with maching index.|
|[GetPosition()](VRage.Game.ModAPI.Ingame.IMyEntity@GetPosition)|Gets position in world coordinates|

**Inheritors:**  
* [IMyAdvancedDoor](Sandbox.ModAPI.Ingame.IMyAdvancedDoor)  
* [IMyAirtightDoorBase](Sandbox.ModAPI.Ingame.IMyAirtightDoorBase)  
* [IMyAirtightHangarDoor](Sandbox.ModAPI.Ingame.IMyAirtightHangarDoor)  
* [IMyAirtightSlideDoor](Sandbox.ModAPI.Ingame.IMyAirtightSlideDoor)  
* [IMyAirVent](SpaceEngineers.Game.ModAPI.Ingame.IMyAirVent)  
* [IMyArtificialMassBlock](SpaceEngineers.Game.ModAPI.Ingame.IMyArtificialMassBlock)  
* [IMyAssembler](Sandbox.ModAPI.Ingame.IMyAssembler)  
* [IMyAttachableTopBlock](Sandbox.ModAPI.Ingame.IMyAttachableTopBlock)  
* [IMyBasicMissionBlock](Sandbox.ModAPI.Ingame.IMyBasicMissionBlock)  
* [IMyBatteryBlock](Sandbox.ModAPI.Ingame.IMyBatteryBlock)  
* [IMyBeacon](Sandbox.ModAPI.Ingame.IMyBeacon)  
* [IMyBroadcastController](SpaceEngineers.Game.ModAPI.Ingame.IMyBroadcastController)  
* [IMyBroadcastControllerBlock](Sandbox.ModAPI.Ingame.IMyBroadcastControllerBlock)  
* [IMyButtonPanel](SpaceEngineers.Game.ModAPI.Ingame.IMyButtonPanel)  
* [IMyCameraBlock](Sandbox.ModAPI.Ingame.IMyCameraBlock)  
* [IMyCargoContainer](Sandbox.ModAPI.Ingame.IMyCargoContainer)  
* [IMyCockpit](Sandbox.ModAPI.Ingame.IMyCockpit)  
* [IMyCollector](Sandbox.ModAPI.Ingame.IMyCollector)  
* [IMyControlPanel](SpaceEngineers.Game.ModAPI.Ingame.IMyControlPanel)  
* [IMyConveyor](Sandbox.ModAPI.Ingame.IMyConveyor)  
* [IMyConveyorSorter](Sandbox.ModAPI.Ingame.IMyConveyorSorter)  
* [IMyConveyorTube](Sandbox.ModAPI.Ingame.IMyConveyorTube)  
* [IMyCryoChamber](Sandbox.ModAPI.Ingame.IMyCryoChamber)  
* [IMyCubeBlock](VRage.Game.ModAPI.Ingame.IMyCubeBlock)  
* [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid)  
* [IMyDecoy](Sandbox.ModAPI.Ingame.IMyDecoy)  
* [IMyDefensiveCombatBlock](Sandbox.ModAPI.Ingame.IMyDefensiveCombatBlock)  
* [IMyDoor](Sandbox.ModAPI.Ingame.IMyDoor)  
* [IMyEmotionControllerBlock](Sandbox.ModAPI.Ingame.IMyEmotionControllerBlock)  
* [IMyEventControllerBlock](Sandbox.ModAPI.Ingame.IMyEventControllerBlock)  
* [IMyExtendedPistonBase](Sandbox.ModAPI.Ingame.IMyExtendedPistonBase)  
* [IMyFlightMovementBlock](Sandbox.ModAPI.Ingame.IMyFlightMovementBlock)  
* [IMyFunctionalBlock](Sandbox.ModAPI.Ingame.IMyFunctionalBlock)  
* [IMyGasGenerator](Sandbox.ModAPI.Ingame.IMyGasGenerator)  
* [IMyGasTank](Sandbox.ModAPI.Ingame.IMyGasTank)  
* [IMyGravityGenerator](SpaceEngineers.Game.ModAPI.Ingame.IMyGravityGenerator)  
* [IMyGravityGeneratorBase](SpaceEngineers.Game.ModAPI.Ingame.IMyGravityGeneratorBase)  
* [IMyGravityGeneratorSphere](SpaceEngineers.Game.ModAPI.Ingame.IMyGravityGeneratorSphere)  
* [IMyGyro](Sandbox.ModAPI.Ingame.IMyGyro)  
* [IMyHeatVent](SpaceEngineers.Game.ModAPI.Ingame.IMyHeatVent)  
* [IMyInteriorLight](SpaceEngineers.Game.ModAPI.Ingame.IMyInteriorLight)  
* [IMyJumpDrive](Sandbox.ModAPI.Ingame.IMyJumpDrive)  
* [IMyLandingGear](SpaceEngineers.Game.ModAPI.Ingame.IMyLandingGear)  
* [IMyLargeConveyorTurretBase](SpaceEngineers.Game.ModAPI.Ingame.IMyLargeConveyorTurretBase)  
* [IMyLargeGatlingTurret](SpaceEngineers.Game.ModAPI.Ingame.IMyLargeGatlingTurret)  
* [IMyLargeInteriorTurret](SpaceEngineers.Game.ModAPI.Ingame.IMyLargeInteriorTurret)  
* [IMyLargeMissileTurret](SpaceEngineers.Game.ModAPI.Ingame.IMyLargeMissileTurret)  
* [IMyLargeTurretBase](Sandbox.ModAPI.Ingame.IMyLargeTurretBase)  
* [IMyLaserAntenna](Sandbox.ModAPI.Ingame.IMyLaserAntenna)  
* [IMyLightingBlock](Sandbox.ModAPI.Ingame.IMyLightingBlock)  
* [IMyMechanicalConnectionBlock](Sandbox.ModAPI.Ingame.IMyMechanicalConnectionBlock)  
* [IMyMedicalRoom](SpaceEngineers.Game.ModAPI.Ingame.IMyMedicalRoom)  
* [IMyMotorAdvancedRotor](Sandbox.ModAPI.Ingame.IMyMotorAdvancedRotor)  
* [IMyMotorAdvancedStator](Sandbox.ModAPI.Ingame.IMyMotorAdvancedStator)  
* [IMyMotorBase](Sandbox.ModAPI.Ingame.IMyMotorBase)  
* [IMyMotorRotor](Sandbox.ModAPI.Ingame.IMyMotorRotor)  
* [IMyMotorStator](Sandbox.ModAPI.Ingame.IMyMotorStator)  
* [IMyMotorSuspension](Sandbox.ModAPI.Ingame.IMyMotorSuspension)  
* [IMyOffensiveCombatBlock](Sandbox.ModAPI.Ingame.IMyOffensiveCombatBlock)  
* [IMyOreDetector](Sandbox.ModAPI.Ingame.IMyOreDetector)  
* [IMyOxygenFarm](SpaceEngineers.Game.ModAPI.Ingame.IMyOxygenFarm)  
* [IMyParachute](SpaceEngineers.Game.ModAPI.Ingame.IMyParachute)  
* [IMyPassage](Sandbox.ModAPI.Ingame.IMyPassage)  
* [IMyPathRecorderBlock](Sandbox.ModAPI.Ingame.IMyPathRecorderBlock)  
* [IMyPistonBase](Sandbox.ModAPI.Ingame.IMyPistonBase)  
* [IMyPistonTop](Sandbox.ModAPI.Ingame.IMyPistonTop)  
* [IMyPowerProducer](Sandbox.ModAPI.Ingame.IMyPowerProducer)  
* [IMyProductionBlock](Sandbox.ModAPI.Ingame.IMyProductionBlock)  
* [IMyProgrammableBlock](Sandbox.ModAPI.Ingame.IMyProgrammableBlock)  
* [IMyProjector](Sandbox.ModAPI.Ingame.IMyProjector)  
* [IMyRadioAntenna](Sandbox.ModAPI.Ingame.IMyRadioAntenna)  
* [IMyReactor](Sandbox.ModAPI.Ingame.IMyReactor)  
* [IMyRefinery](Sandbox.ModAPI.Ingame.IMyRefinery)  
* [IMyReflectorLight](Sandbox.ModAPI.Ingame.IMyReflectorLight)  
* [IMyRemoteControl](Sandbox.ModAPI.Ingame.IMyRemoteControl)  
* [IMySafeZoneBlock](SpaceEngineers.Game.ModAPI.Ingame.IMySafeZoneBlock)  
* [IMySearchlight](Sandbox.ModAPI.Ingame.IMySearchlight)  
* [IMySensorBlock](Sandbox.ModAPI.Ingame.IMySensorBlock)  
* [IMyShipConnector](Sandbox.ModAPI.Ingame.IMyShipConnector)  
* [IMyShipController](Sandbox.ModAPI.Ingame.IMyShipController)  
* [IMyShipDrill](Sandbox.ModAPI.Ingame.IMyShipDrill)  
* [IMyShipGrinder](Sandbox.ModAPI.Ingame.IMyShipGrinder)  
* [IMyShipMergeBlock](SpaceEngineers.Game.ModAPI.Ingame.IMyShipMergeBlock)  
* [IMyShipToolBase](Sandbox.ModAPI.Ingame.IMyShipToolBase)  
* [IMyShipWelder](Sandbox.ModAPI.Ingame.IMyShipWelder)  
* [IMySmallGatlingGun](Sandbox.ModAPI.Ingame.IMySmallGatlingGun)  
* [IMySmallMissileLauncher](Sandbox.ModAPI.Ingame.IMySmallMissileLauncher)  
* [IMySmallMissileLauncherReload](Sandbox.ModAPI.Ingame.IMySmallMissileLauncherReload)  
* [IMySolarPanel](SpaceEngineers.Game.ModAPI.Ingame.IMySolarPanel)  
* [IMySoundBlock](SpaceEngineers.Game.ModAPI.Ingame.IMySoundBlock)  
* [IMySpaceBall](SpaceEngineers.Game.ModAPI.Ingame.IMySpaceBall)  
* [IMyStoreBlock](Sandbox.ModAPI.Ingame.IMyStoreBlock)  
* [IMyTargetDummyBlock](Sandbox.ModAPI.Ingame.IMyTargetDummyBlock)  
* [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock)  
* [IMyTextPanel](Sandbox.ModAPI.Ingame.IMyTextPanel)  
* [IMyThrust](Sandbox.ModAPI.Ingame.IMyThrust)  
* [IMyTimerBlock](SpaceEngineers.Game.ModAPI.Ingame.IMyTimerBlock)  
* [IMyTransponder](SpaceEngineers.Game.ModAPI.Ingame.IMyTransponder)  
* [IMyTurretControlBlock](SpaceEngineers.Game.ModAPI.Ingame.IMyTurretControlBlock)  
* [IMyUpgradableBlock](Sandbox.ModAPI.Ingame.IMyUpgradableBlock)  
* [IMyUpgradeModule](Sandbox.ModAPI.Ingame.IMyUpgradeModule)  
* [IMyUserControllableGun](Sandbox.ModAPI.Ingame.IMyUserControllableGun)  
* [IMyVirtualMass](SpaceEngineers.Game.ModAPI.Ingame.IMyVirtualMass)  
* [IMyWarhead](Sandbox.ModAPI.Ingame.IMyWarhead)  
* [IMyWheel](Sandbox.ModAPI.Ingame.IMyWheel)  
* [IMyWindTurbine](Sandbox.ModAPI.Ingame.IMyWindTurbine)

