**Assembly:** VRage.Game.dll

```csharp
public interface IMyVoxelShape
```

Describes voxel shape for filling or excavating

## Properties

|Member|Description|
|---|---|
|[Transform](VRage.Game.ModAPI.IMyVoxelShape@Transform)|World matrix of voxel shape|

## Methods

|Member|Description|
|---|---|
|[GetIntersectionVolume(ref Vector3D)](VRage.Game.ModAPI.IMyVoxelShape@GetIntersectionVolume)|Gets volume of intersection of shape and voxel|
|[GetWorldBoundary()](VRage.Game.ModAPI.IMyVoxelShape@GetWorldBoundary)|Gets current world boundaries|
|[PeekWorldBoundary(ref Vector3D)](VRage.Game.ModAPI.IMyVoxelShape@PeekWorldBoundary)|Peeks world boundaries at given position|

**Inheritors:**  
* [IMyVoxelShapeBox](VRage.Game.ModAPI.IMyVoxelShapeBox)  
* [IMyVoxelShapeCapsule](VRage.Game.ModAPI.IMyVoxelShapeCapsule)  
* [IMyVoxelShapeRamp](VRage.Game.ModAPI.IMyVoxelShapeRamp)  
* [IMyVoxelShapeSphere](VRage.Game.ModAPI.IMyVoxelShapeSphere)

