**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyAttackPatternComponent: IMyAttackPatternComponent
```

Describes entity component for AttackPattern of offensive combat block

## Properties

|Member|Description|
|---|---|
|[IsSelected](Sandbox.ModAPI.IMyAttackPatternComponent@IsSelected)|Gets if attack pattern is selected|
|[AttackPatternId](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternId)|Gets attack pattern id<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[AttackPatternName](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternName)|Gets attack pattern name<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[AttackPatternTooltip](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@AttackPatternTooltip)|Gets attack pattern tooltip<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[HasEnemy](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@HasEnemy)|Gets if attack pattern has enemy in range<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|
|[IsSelected](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent@IsSelected)|Gets if attack pattern is selected<br /><br />_Inherited from [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)_|

## Methods

|Member|Description|
|---|---|
|[AppendCustomInfo(StringBuilder)](Sandbox.ModAPI.IMyAttackPatternComponent@AppendCustomInfo)|Override to add information about mission status|
|[CreateTerminalInterfaceControls<T>()](Sandbox.ModAPI.IMyAttackPatternComponent@CreateTerminalInterfaceControls{T})||

**Implements:**  
* [IMyAttackPatternComponent](Sandbox.ModAPI.Ingame.IMyAttackPatternComponent)

**Inheritors:**  
* [IMyOffensiveCombatCircleOrbit](Sandbox.ModAPI.IMyOffensiveCombatCircleOrbit)  
* [IMyOffensiveCombatHitAndRun](Sandbox.ModAPI.IMyOffensiveCombatHitAndRun)  
* [IMyOffensiveCombatIntercept](Sandbox.ModAPI.IMyOffensiveCombatIntercept)  
* [IMyOffensiveCombatStayAtRange](Sandbox.ModAPI.IMyOffensiveCombatStayAtRange)

