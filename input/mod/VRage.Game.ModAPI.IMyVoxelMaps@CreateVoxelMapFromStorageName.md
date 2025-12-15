## Summary

```csharp
public IMyVoxelMap CreateVoxelMapFromStorageName(string storageName, string prefabVoxelMapName, Vector3D position)
```

Adds a prefab voxel to the game world.

## Returns

[IMyVoxelMap](VRage.Game.ModAPI.IMyVoxelMap)

The newly added voxel map. Returns null if the prefabVoxelMapName does not exist.

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) storageName
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) prefabVoxelMapName
* [Vector3D](VRageMath.Vector3D) position
