**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyTargetingCapableBlock
```

Describes block that can target (cockpits and turrets) (mods interface)

## Methods

|Member|Description|
|---|---|
|[CanActiveToolShoot()](Sandbox.ModAPI.IMyTargetingCapableBlock@CanActiveToolShoot)|Get whether toolbar selected tool can shoot|
|[GetActiveToolPosition()](Sandbox.ModAPI.IMyTargetingCapableBlock@GetActiveToolPosition)|Gets average position|
|[GetWorldMatrix()](Sandbox.ModAPI.IMyTargetingCapableBlock@GetWorldMatrix)|Gets barrel or block world matrix|
|[IsShipToolSelected()](Sandbox.ModAPI.IMyTargetingCapableBlock@IsShipToolSelected)|Get whether toolbar selected item is ship tool (drill, grinder, welder)|
|[IsTargetLockingEnabled()](Sandbox.ModAPI.IMyTargetingCapableBlock@IsTargetLockingEnabled)|Gets if target locking is enabled|
|[SetLockedTarget(IMyCubeGrid)](Sandbox.ModAPI.IMyTargetingCapableBlock@SetLockedTarget)|Sets locked target grid|
|[SetLockedTarget(IMyCharacter)](Sandbox.ModAPI.IMyTargetingCapableBlock@SetLockedTarget)|Sets locked target grid|

**Inheritors:**  
* [IMyCockpit](Sandbox.ModAPI.IMyCockpit)  
* [IMyCryoChamber](Sandbox.ModAPI.IMyCryoChamber)  
* [IMyLargeConveyorTurretBase](SpaceEngineers.Game.ModAPI.IMyLargeConveyorTurretBase)  
* [IMyLargeGatlingTurret](SpaceEngineers.Game.ModAPI.IMyLargeGatlingTurret)  
* [IMyLargeInteriorTurret](SpaceEngineers.Game.ModAPI.IMyLargeInteriorTurret)  
* [IMyLargeMissileTurret](SpaceEngineers.Game.ModAPI.IMyLargeMissileTurret)  
* [IMyLargeTurretBase](Sandbox.ModAPI.IMyLargeTurretBase)  
* [IMyRemoteControl](Sandbox.ModAPI.IMyRemoteControl)  
* [IMyShipController](Sandbox.ModAPI.IMyShipController)  
* [MyCockpit](Sandbox.Game.Entities.MyCockpit)  
* [MyRemoteControl](Sandbox.Game.Entities.MyRemoteControl)  
* [MyShipController](Sandbox.Game.Entities.MyShipController)

