**Assembly:** VRage.Game.dll

```csharp
public interface IMySlimBlock
```

Basic block interface (PB scripting interface)

## Properties

|Member|Description|
|---|---|
|[AccumulatedDamage](VRage.Game.ModAPI.Ingame.IMySlimBlock@AccumulatedDamage)|Current accumlated damage, pending application|
|[BlockDefinition](VRage.Game.ModAPI.Ingame.IMySlimBlock@BlockDefinition)|Block definition ID|
|[BuildIntegrity](VRage.Game.ModAPI.Ingame.IMySlimBlock@BuildIntegrity)|Build integrity (of components)|
|[BuildLevelRatio](VRage.Game.ModAPI.Ingame.IMySlimBlock@BuildLevelRatio)|Ratio of BuildIntegrity and MaxIntegrity|
|[ColorMaskHSV](VRage.Game.ModAPI.Ingame.IMySlimBlock@ColorMaskHSV)|Gets the color of the block|
|[CubeGrid](VRage.Game.ModAPI.Ingame.IMySlimBlock@CubeGrid)|Gets the grid the slimblock is on|
|[CurrentDamage](VRage.Game.ModAPI.Ingame.IMySlimBlock@CurrentDamage)|BuildIntegrity - Integrity|
|[DamageRatio](VRage.Game.ModAPI.Ingame.IMySlimBlock@DamageRatio)||
|[FatBlock](VRage.Game.ModAPI.Ingame.IMySlimBlock@FatBlock)|Gets the fatblock if there is one|
|[HasDeformation](VRage.Game.ModAPI.Ingame.IMySlimBlock@HasDeformation)|If this block is deformed (bones deformed)|
|[IsDestroyed](VRage.Game.ModAPI.Ingame.IMySlimBlock@IsDestroyed)|Gets if component stack is empty|
|[IsFullIntegrity](VRage.Game.ModAPI.Ingame.IMySlimBlock@IsFullIntegrity)|Integrity is at maximum|
|[IsFullyDismounted](VRage.Game.ModAPI.Ingame.IMySlimBlock@IsFullyDismounted)|Gets if component stack is empty|
|[Mass](VRage.Game.ModAPI.Ingame.IMySlimBlock@Mass)|Block mass|
|[MaxDeformation](VRage.Game.ModAPI.Ingame.IMySlimBlock@MaxDeformation)|Maximum deformation of block|
|[MaxIntegrity](VRage.Game.ModAPI.Ingame.IMySlimBlock@MaxIntegrity)|The maximum integrity of block|
|[OwnerId](VRage.Game.ModAPI.Ingame.IMySlimBlock@OwnerId)|Fatblock owner, if present; otherwise grid owner|
|[Position](VRage.Game.ModAPI.Ingame.IMySlimBlock@Position)|Grid relative position of block|
|[ShowParts](VRage.Game.ModAPI.Ingame.IMySlimBlock@ShowParts)|Gets if sub parts are shown|
|[SkinSubtypeId](VRage.Game.ModAPI.Ingame.IMySlimBlock@SkinSubtypeId)|Gets the skin of the block|
|[StockpileAllocated](VRage.Game.ModAPI.Ingame.IMySlimBlock@StockpileAllocated)|A component stockpile has been allocated|
|[StockpileEmpty](VRage.Game.ModAPI.Ingame.IMySlimBlock@StockpileEmpty)|The component stockpile is empty (no build components)|

## Methods

|Member|Description|
|---|---|
|[GetMissingComponents(Dictionary<string, int>)](VRage.Game.ModAPI.Ingame.IMySlimBlock@GetMissingComponents)|Gets the list of missing components for this block|

