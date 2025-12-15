**Assembly:** VRage.Game.dll

```csharp
public interface IMyVoxelShapeCapsule: IMyVoxelShape
```

Describes capsule voxel shape for filling or excavating

## Properties

|Member|Description|
|---|---|
|[A](VRage.Game.ModAPI.IMyVoxelShapeCapsule@A)|In world Coordinates|
|[B](VRage.Game.ModAPI.IMyVoxelShapeCapsule@B)|In world Coordinates|
|[Radius](VRage.Game.ModAPI.IMyVoxelShapeCapsule@Radius)||
|[Transform](VRage.Game.ModAPI.IMyVoxelShape@Transform)|World matrix of voxel shape<br /><br />_Inherited from [IMyVoxelShape](VRage.Game.ModAPI.IMyVoxelShape)_|

## Methods

|Member|Description|
|---|---|
|[GetIntersectionVolume(ref Vector3D)](VRage.Game.ModAPI.IMyVoxelShape@GetIntersectionVolume)|Gets volume of intersection of shape and voxel<br /><br />_Inherited from [IMyVoxelShape](VRage.Game.ModAPI.IMyVoxelShape)_|
|[GetWorldBoundary()](VRage.Game.ModAPI.IMyVoxelShape@GetWorldBoundary)|Gets current world boundaries<br /><br />_Inherited from [IMyVoxelShape](VRage.Game.ModAPI.IMyVoxelShape)_|
|[PeekWorldBoundary(ref Vector3D)](VRage.Game.ModAPI.IMyVoxelShape@PeekWorldBoundary)|Peeks world boundaries at given position<br /><br />_Inherited from [IMyVoxelShape](VRage.Game.ModAPI.IMyVoxelShape)_|

**Implements:**  
* [IMyVoxelShape](VRage.Game.ModAPI.IMyVoxelShape)

