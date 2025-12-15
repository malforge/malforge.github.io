**Assembly:** VRage.Game.dll

```csharp
public interface IMyPrefabManager
```

ModAPI interface giving ability for modders to spawn prefabs

## Methods

|Member|Description|
|---|---|
|[IsPathClear(Vector3D, Vector3D)](VRage.Game.ModAPI.IMyPrefabManager@IsPathClear)|Checks if there is noting between 2 points. Raycasts inside|
|[IsPathClear(Vector3D, Vector3D, double)](VRage.Game.ModAPI.IMyPrefabManager@IsPathClear)|Checks if there is noting between 2 points, in cylinder shape. Does 4 Raycasts inside|
|[SpawnPrefab(List<IMyCubeGrid>, string, Vector3D, Vector3, Vector3, Vector3, Vector3, string, SpawningOptions, bool, Action)](VRage.Game.ModAPI.IMyPrefabManager@SpawnPrefab)|Spawns prefab|
|[SpawnPrefab(List<IMyCubeGrid>, string, Vector3D, Vector3, Vector3, Vector3, Vector3, string, SpawningOptions, long, bool, Action)](VRage.Game.ModAPI.IMyPrefabManager@SpawnPrefab)|Spawns prefab|

