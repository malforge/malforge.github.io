**Assembly:** Sandbox.Game.dll

```csharp
public abstract sealed class MyCubeGridDefinitions
```

## Fields

|Member|Description|
|---|---|
|[static EdgeOrientations](Sandbox.Definitions.MyCubeGridDefinitions@EdgeOrientations)||
|[static TileGridOrientations](Sandbox.Definitions.MyCubeGridDefinitions@TileGridOrientations)||

## Properties

|Member|Description|
|---|---|
|[static AllPossible90rotations](Sandbox.Definitions.MyCubeGridDefinitions@AllPossible90rotations)||

## Methods

|Member|Description|
|---|---|
|[static GetCubeRotationOptions(MyCubeBlockDefinition)](Sandbox.Definitions.MyCubeGridDefinitions@GetCubeRotationOptions)||
|[static GetCubeTiles(MyCubeBlockDefinition)](Sandbox.Definitions.MyCubeGridDefinitions@GetCubeTiles)||
|[static GetRotatedBlockSize(MyCubeBlockDefinition, ref Matrix, out Vector3I)](Sandbox.Definitions.MyCubeGridDefinitions@GetRotatedBlockSize)||
|[static GetTopologyInfo(MyCubeTopology)](Sandbox.Definitions.MyCubeGridDefinitions@GetTopologyInfo)||
|[static GetTopologyUniqueOrientation(MyCubeTopology, MyBlockOrientation)](Sandbox.Definitions.MyCubeGridDefinitions@GetTopologyUniqueOrientation)|From 90degrees rotations combinations returns one unique topology orientation, which can differ from input, but the resulted shape of topology is same|

