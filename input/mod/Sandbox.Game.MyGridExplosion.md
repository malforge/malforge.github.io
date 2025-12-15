**Assembly:** Sandbox.Game.dll

```csharp
public class MyGridExplosion
```

This class is responsible for calculating damage from explosions It works by recursively raycasting from the point it needs to calculate to the explosion center. It does two types of raycast, 3D DDA raycasts for traversing grids (ships, stations) and Havok raycasts for traversing space between grids. For each block, it builds a stack of blocks that are between it and the explosion center and then calculates the damage for all blocks in this stack. It early exits if it encounters a block that was already calculated.

## Fields

|Member|Description|
|---|---|
|[AffectedCubeBlocks](Sandbox.Game.MyGridExplosion@AffectedCubeBlocks)||
|[AffectedCubeGrids](Sandbox.Game.MyGridExplosion@AffectedCubeGrids)||

## Properties

|Member|Description|
|---|---|
|[Damage](Sandbox.Game.MyGridExplosion@Damage)||
|[DamagedBlocks](Sandbox.Game.MyGridExplosion@DamagedBlocks)||
|[DamageRemaining](Sandbox.Game.MyGridExplosion@DamageRemaining)||
|[Sphere](Sandbox.Game.MyGridExplosion@Sphere)||

## Constructors

|Member|Description|
|---|---|
|[MyGridExplosion()](Sandbox.Game.MyGridExplosion@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Clear()](Sandbox.Game.MyGridExplosion@Clear)||
|[ComputeDamagedBlocks()](Sandbox.Game.MyGridExplosion@ComputeDamagedBlocks)|Computes damage for all blocks assigned in constructor|
|[ComputeDamageForEntity(Vector3D)](Sandbox.Game.MyGridExplosion@ComputeDamageForEntity)|Used to calculate damage for entities that are not grids Can be called even if ComputeDamagedBlocks was not called before, but it doesn't do any caching|
|[Init(BoundingSphereD, float)](Sandbox.Game.MyGridExplosion@Init)||

