**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyOffensiveCombatIntercept: IMyOffensiveCombatIntercept, IMyAttackPatternComponent, IMyAttackPatternComponent
```

Describes entity component for AttackPattern of offensive combat block

## Events

|Member|Description|
|---|---|
|[OnGuidanceTypeValueChanged](Sandbox.ModAPI.IMyOffensiveCombatIntercept@OnGuidanceTypeValueChanged)|Triggered when guidance type changed|

## Properties

|Member|Description|
|---|---|
|[AttackPatternId](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternId)|Gets attack pattern id<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[AttackPatternName](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternName)|Gets attack pattern name<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[AttackPatternTooltip](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternTooltip)|Gets attack pattern tooltip<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[GuidanceType](Sandbox.ModAPI.Ingame.IMyOffensiveCombatIntercept@GuidanceType)|Gets intercept logic type<br /><br />_Inherited from [IMyOffensiveCombatIntercept](Sandbox.ModAPI.Ingame.IMyOffensiveCombatIntercept)_|
|[HasEnemy](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@HasEnemy)|Gets if attack pattern has enemy in range<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[IsSelected](Sandbox.ModAPI.IMyAttackPatternComponent@IsSelected)|Gets if attack pattern is selected<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)_|
|[IsSelected](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@IsSelected)|Gets if attack pattern is selected<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[ShouldOverrideCollisionAvoidance](Sandbox.ModAPI.Ingame.IMyOffensiveCombatIntercept@ShouldOverrideCollisionAvoidance)|Gets if should override collision avoidance<br /><br />_Inherited from [IMyOffensiveCombatIntercept](Sandbox.ModAPI.Ingame.IMyOffensiveCombatIntercept)_|

## Methods

|Member|Description|
|---|---|
|[AppendCustomInfo(StringBuilder)](Sandbox.ModAPI.IMyAttackPatternComponent@AppendCustomInfo)|Override to add information about mission status<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)_|
|[CreateTerminalInterfaceControls<T>()](Sandbox.ModAPI.IMyAttackPatternComponent@CreateTerminalInterfaceControls{T})|_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)_|

**Implements:**  
* [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)  
* [IMyAttackPatternComponent](Sandbox.ModAPI.IMyAttackPatternComponent)  
* [IMyOffensiveCombatIntercept](Sandbox.ModAPI.Ingame.IMyOffensiveCombatIntercept)

