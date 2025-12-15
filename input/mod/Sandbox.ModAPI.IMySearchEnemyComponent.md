**Assembly:** Sandbox.Common.dll

```csharp
public interface IMySearchEnemyComponent: IMySearchEnemyComponent
```

Describes component that can find enemy grids and characters in range

## Events

|Member|Description|
|---|---|
|[ForceSearchRequired](Sandbox.ModAPI.IMySearchEnemyComponent@ForceSearchRequired)|Called when the search component should receive a scan immediately. For example: previous target was destroyed|
|[SearchComplete](Sandbox.ModAPI.IMySearchEnemyComponent@SearchComplete)|Called when Search was finished, as argument found enemy (block or character) is returned|
|[TargetChanged](Sandbox.ModAPI.IMySearchEnemyComponent@TargetChanged)|Called when target enemy (grid or character) is changed|

## Properties

|Member|Description|
|---|---|
|[FoundEnemy](Sandbox.ModAPI.IMySearchEnemyComponent@FoundEnemy)|Gets found enemy (block or character)|
|[FoundEnemyId](Sandbox.ModAPI.Ingame.IMySearchEnemyComponent@FoundEnemyId)|Gets found enemy (block or character)<br /><br />_Inherited from [IMySearchEnemyComponent](Sandbox.ModAPI.Ingame.IMySearchEnemyComponent)_|
|[SubsystemsToDestroy](Sandbox.ModAPI.Ingame.IMySearchEnemyComponent@SubsystemsToDestroy)|Gets or set which grids with what subsystems should be targeted<br /><br />_Inherited from [IMySearchEnemyComponent](Sandbox.ModAPI.Ingame.IMySearchEnemyComponent)_|
|[TargetingLockOptions](Sandbox.ModAPI.Ingame.IMySearchEnemyComponent@TargetingLockOptions)|Gets or sets targeting lock option<br /><br />_Inherited from [IMySearchEnemyComponent](Sandbox.ModAPI.Ingame.IMySearchEnemyComponent)_|

**Implements:**  
* [IMySearchEnemyComponent](Sandbox.ModAPI.Ingame.IMySearchEnemyComponent)

