**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyOffensiveCombatHitAndRun: IMyOffensiveCombatHitAndRun, IMyAttackPatternComponent, IMyAttackPatternComponent
```

Describes entity component for AttackPattern of offensive combat block

## Events

|Member|Description|
|---|---|
|[StateChanged](Sandbox.ModAPI.IMyOffensiveCombatHitAndRun@StateChanged)|Triggered when changed state between IsMovingAwayFromTarget, IsMovingToTarget, and idle state|

## Properties

|Member|Description|
|---|---|
|[BlockValidation](Sandbox.ModAPI.IMyOffensiveCombatHitAndRun@BlockValidation)|Gets or sets function that is called when block caches all available weapons, and called on server to validate, that user selected weapon is correct Used for adding custom weapons. By default used reference to Keen default function Must not be null. You need override it on server and client|
|[ClearBlocksShootingState](Sandbox.ModAPI.IMyOffensiveCombatHitAndRun@ClearBlocksShootingState)|Gets or sets function that is called when grid is copied. You need clear state of shooting weapons By default used reference to Keen default function Must not be null. You need override it on server and client IMyCubeGrid - original grid which would be copied MyObjectBuilder_CubeGrid - grid which state you need clear IMyAttackPatternComponent - attack pattern, that calls this clear|
|[GetFirstWeaponForwardVector](Sandbox.ModAPI.IMyOffensiveCombatHitAndRun@GetFirstWeaponForwardVector)|Gets or sets function that is called to know how grid should rotate to face target By default used reference to Keen default function (returns WorldMatrix.Forward vector) IMyAttackPatternComponent - attack pattern, that calls this clear Returns blocks WorldMatrix.Forward|
|[GetPredictedLookAt](Sandbox.ModAPI.IMyOffensiveCombatHitAndRun@GetPredictedLookAt)|Gets or sets function that is called for aiming grid at enemy By default used reference to Keen default function Must not be null. You need override it on server and client IMyEntity - entity that you should aim at predicting it's future position, and bullet speed IMyAttackPatternComponent - current component that need aim Double - distance to target squared Returns world position|
|[SetShooting](Sandbox.ModAPI.IMyOffensiveCombatHitAndRun@SetShooting)|Gets or sets function that is called per block requesting it start or stop shooting. Used for adding custom weapons. By default used reference to Keen default function Must not be null. You need override it on server and client IMyCubeBlock - Weapon block to test bool - Should block shoot or not double - DistanceToTargetSq squared distance in meters to target Vector3D? - aim position, predicted shoot position Base6Directions.Direction - shoot direction Called in parallel update of Autopilot|
|[AttackPatternId](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternId)|Gets attack pattern id<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[AttackPatternName](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternName)|Gets attack pattern name<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[AttackPatternTooltip](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternTooltip)|Gets attack pattern tooltip<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[BreakOffDistance](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun@BreakOffDistance)|Gets or sets break off distance (in meters)<br /><br />_Inherited from [IMyOffensiveCombatHitAndRun](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun)_|
|[HasEnemy](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@HasEnemy)|Gets if attack pattern has enemy in range<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[IsMovingAwayFromTarget](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun@IsMovingAwayFromTarget)|Gets if grid is moving away from target<br /><br />_Inherited from [IMyOffensiveCombatHitAndRun](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun)_|
|[IsMovingToTarget](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun@IsMovingToTarget)|Gets if grid is moving to target<br /><br />_Inherited from [IMyOffensiveCombatHitAndRun](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun)_|
|[IsSelected](Sandbox.ModAPI.IMyAttackPatternComponent@IsSelected)|Gets if attack pattern is selected<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)_|
|[IsSelected](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@IsSelected)|Gets if attack pattern is selected<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[RetreatAngle](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun@RetreatAngle)|Gets or sets retreat angle (in degrees)<br /><br />_Inherited from [IMyOffensiveCombatHitAndRun](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun)_|
|[RetreatDistance](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun@RetreatDistance)|Gets or sets max distance that grid can run away from target<br /><br />_Inherited from [IMyOffensiveCombatHitAndRun](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun)_|
|[RetreatTimeout](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun@RetreatTimeout)|Gets or sets max time that grid can run away from target<br /><br />_Inherited from [IMyOffensiveCombatHitAndRun](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun)_|

## Methods

|Member|Description|
|---|---|
|[AppendCustomInfo(StringBuilder)](Sandbox.ModAPI.IMyAttackPatternComponent@AppendCustomInfo)|Override to add information about mission status<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)_|
|[CreateTerminalInterfaceControls<T>()](Sandbox.ModAPI.IMyAttackPatternComponent@CreateTerminalInterfaceControls{T})|_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)_|
|[GetSelectedWeapons(List<long>)](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun@GetSelectedWeapons)|Gets weapons that should be used to damage to attack enemy May return also modded guns EntityId.<br /><br />_Inherited from [IMyOffensiveCombatHitAndRun](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun)_|
|[IsWeaponSelected(long)](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun@IsWeaponSelected)|Gets if weapon is selected<br /><br />_Inherited from [IMyOffensiveCombatHitAndRun](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun)_|
|[SetSelectedWeapons(List<long>)](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun@SetSelectedWeapons)|Sets weapons EntityIds that can would be used to damage to attack enemy Modded gun are allowed, but you need override [BlockValidation](Sandbox.ModAPI.IMyOffensiveCombatHitAndRun@BlockValidation) and [SetShooting](Sandbox.ModAPI.IMyOffensiveCombatHitAndRun@SetShooting)<br /><br />_Inherited from [IMyOffensiveCombatHitAndRun](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun)_|

**Implements:**  
* [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)  
* [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)  
* [IMyOffensiveCombatHitAndRun](Sandbox.ModAPI.Ingame.IMyOffensiveCombatHitAndRun)

