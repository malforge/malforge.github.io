**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyOffensiveCombatCircleOrbit: IMyOffensiveCombatCircleOrbit, IMyAttackPatternComponent, IMyAttackPatternComponent
```

Describes circle orbit attack pattern of offensive combat block

## Properties

|Member|Description|
|---|---|
|[BlockValidation](Sandbox.ModAPI.IMyOffensiveCombatCircleOrbit@BlockValidation)|Gets or sets function that is called when block caches all available weapons, and called on server to validate, that user selected weapon is correct Used for adding custom weapons. By default used reference to Keen default function Must not be null. You need override it on server and client|
|[ClearBlocksShootingState](Sandbox.ModAPI.IMyOffensiveCombatCircleOrbit@ClearBlocksShootingState)|Gets or sets function that is called when grid is copied. You need clear state of shooting weapons By default used reference to Keen default function Must not be null. You need override it on server and client IMyCubeGrid - original grid which would be copied MyObjectBuilder_CubeGrid - grid which state you need clear IMyAttackPatternComponent - attack pattern, that calls this clear|
|[GetFirstWeaponForwardVector](Sandbox.ModAPI.IMyOffensiveCombatCircleOrbit@GetFirstWeaponForwardVector)|Gets or sets function that is called to know how grid should rotate to face target By default used reference to Keen default function (returns WorldMatrix.Forward vector) IMyAttackPatternComponent - attack pattern, that calls this clear Returns blocks WorldMatrix.Forward|
|[GetPredictedLookAt](Sandbox.ModAPI.IMyOffensiveCombatCircleOrbit@GetPredictedLookAt)|Gets or sets function that is called for aiming grid at enemy By default used reference to Keen default function Must not be null. You need override it on server and client IMyEntity - entity that you should aim at predicting it's future position, and bullet speed IMyAttackPatternComponent - current component that need aim Double - distance to target squared Returns world position|
|[SetShooting](Sandbox.ModAPI.IMyOffensiveCombatCircleOrbit@SetShooting)|Gets or sets function that is called per block requesting it start or stop shooting. Used for adding custom weapons. By default used reference to Keen default function Must not be null. You need override it on server and client IMyCubeBlock - Weapon block to test bool - Should block shoot or not double - DistanceToTargetSq squared distance in meters to target Vector3D? - aim position, predicted shoot position Base6Directions.Direction - shoot direction Called in parallel update of Autopilot|
|[AttackPatternId](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternId)|Gets attack pattern id<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[AttackPatternName](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternName)|Gets attack pattern name<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[AttackPatternTooltip](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternTooltip)|Gets attack pattern tooltip<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[CircleDistance](Sandbox.ModAPI.Ingame.IMyOffensiveCombatCircleOrbit@CircleDistance)|Gets or sets circle/orbit distance<br /><br />_Inherited from [IMyOffensiveCombatCircleOrbit](Sandbox.ModAPI.Ingame.IMyOffensiveCombatCircleOrbit)_|
|[CircleInPGravity](Sandbox.ModAPI.Ingame.IMyOffensiveCombatCircleOrbit@CircleInPGravity)|Gets if grid should circle instead of orbiting in gravity<br /><br />_Inherited from [IMyOffensiveCombatCircleOrbit](Sandbox.ModAPI.Ingame.IMyOffensiveCombatCircleOrbit)_|
|[Facing](Sandbox.ModAPI.Ingame.IMyOffensiveCombatCircleOrbit@Facing)|Gets which side grid should face target<br /><br />_Inherited from [IMyOffensiveCombatCircleOrbit](Sandbox.ModAPI.Ingame.IMyOffensiveCombatCircleOrbit)_|
|[HasEnemy](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@HasEnemy)|Gets if attack pattern has enemy in range<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[IsOrbiting](Sandbox.ModAPI.Ingame.IMyOffensiveCombatCircleOrbit@IsOrbiting)|Gets if ship currently circling or orbiting<br /><br />_Inherited from [IMyOffensiveCombatCircleOrbit](Sandbox.ModAPI.Ingame.IMyOffensiveCombatCircleOrbit)_|
|[IsSelected](Sandbox.ModAPI.IMyAttackPatternComponent@IsSelected)|Gets if attack pattern is selected<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)_|
|[IsSelected](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@IsSelected)|Gets if attack pattern is selected<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|

## Methods

|Member|Description|
|---|---|
|[AppendCustomInfo(StringBuilder)](Sandbox.ModAPI.IMyAttackPatternComponent@AppendCustomInfo)|Override to add information about mission status<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)_|
|[CreateTerminalInterfaceControls<T>()](Sandbox.ModAPI.IMyAttackPatternComponent@CreateTerminalInterfaceControls{T})|_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)_|

**Implements:**  
* [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)  
* [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)  
* [IMyOffensiveCombatCircleOrbit](Sandbox.ModAPI.Ingame.IMyOffensiveCombatCircleOrbit)

