**Assembly:** VRage.Game.dll

```csharp
public interface IMyVoxelMaps
```

## Properties

|Member|Description|
|---|---|
|[VoxelMaterialCount](VRage.Game.ModAPI.IMyVoxelMaps@VoxelMaterialCount)||

## Methods

|Member|Description|
|---|---|
|[Clear()](VRage.Game.ModAPI.IMyVoxelMaps@Clear)|Resets all voxels over whole world|
|[CreatePredefinedVoxelMap(string, string, MatrixD, bool)](VRage.Game.ModAPI.IMyVoxelMaps@CreatePredefinedVoxelMap)|Creates an voxel map with some additional options.|
|[CreateProceduralVoxelMap(int, float, MatrixD)](VRage.Game.ModAPI.IMyVoxelMaps@CreateProceduralVoxelMap)||
|[CreateStorage(Vector3I)](VRage.Game.ModAPI.IMyVoxelMaps@CreateStorage)|Creates voxels storage|
|[CreateStorage(Byte[])](VRage.Game.ModAPI.IMyVoxelMaps@CreateStorage)|Creates storage from GZipped bytes.|
|[CreateVoxelMap(string, IMyStorage, Vector3D, long)](VRage.Game.ModAPI.IMyVoxelMaps@CreateVoxelMap)|Creates voxels map|
|[CreateVoxelMapFromStorageName(string, string, Vector3D)](VRage.Game.ModAPI.IMyVoxelMaps@CreateVoxelMapFromStorageName)|Adds a prefab voxel to the game world.|
|[CutOutShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@CutOutShape)|Will cut out given shape|
|[Exist(IMyVoxelBase)](VRage.Game.ModAPI.IMyVoxelMaps@Exist)|Returns if voxel registered|
|[FillInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@FillInShape)|Will fill given material with given shape|
|[GetBoxVoxelHand()](VRage.Game.ModAPI.IMyVoxelMaps@GetBoxVoxelHand)|Gets box voxel hand. Can be used in [PaintInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@PaintInShape) , [CutOutShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@CutOutShape) , [FillInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@FillInShape) , [RevertShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@RevertShape) |
|[GetCapsuleVoxelHand()](VRage.Game.ModAPI.IMyVoxelMaps@GetCapsuleVoxelHand)|Gets capsule voxel hand. Can be used in [PaintInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@PaintInShape) , [CutOutShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@CutOutShape) , [FillInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@FillInShape) , [RevertShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@RevertShape) |
|[GetInstances(List<IMyVoxelBase>, Func<IMyVoxelBase, bool>)](VRage.Game.ModAPI.IMyVoxelMaps@GetInstances)|Gets all instances of [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase) |
|[GetOverlappingWithSphere(ref BoundingSphereD)](VRage.Game.ModAPI.IMyVoxelMaps@GetOverlappingWithSphere)|Get first found [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase) that intersects with sphere|
|[GetRampVoxelHand()](VRage.Game.ModAPI.IMyVoxelMaps@GetRampVoxelHand)|Gets ramp voxel hand. Can be used in [PaintInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@PaintInShape) , [CutOutShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@CutOutShape) , [FillInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@FillInShape) , [RevertShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@RevertShape) |
|[GetSphereVoxelHand()](VRage.Game.ModAPI.IMyVoxelMaps@GetSphereVoxelHand)|Gets sphere voxel hand. Can be used in [PaintInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@PaintInShape) , [CutOutShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@CutOutShape) , [FillInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@FillInShape) , [RevertShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@RevertShape) |
|[GetVoxelMapWhoseBoundingBoxIntersectsBox(ref BoundingBoxD, IMyVoxelBase)](VRage.Game.ModAPI.IMyVoxelMaps@GetVoxelMapWhoseBoundingBoxIntersectsBox)|Get first found [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase) that intersects with bounding box, ordered by distance to box center|
|[MakeCrater(IMyVoxelBase, BoundingSphereD, Vector3, byte)](VRage.Game.ModAPI.IMyVoxelMaps@MakeCrater)||
|[PaintInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@PaintInShape)|Will paint given material with given shape|
|[RevertShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@RevertShape)||
|[SpawnPlanet(string, float, int, Vector3D)](VRage.Game.ModAPI.IMyVoxelMaps@SpawnPlanet)|Creates a Planet Entity|

**Inheritors:**  
* [MyVoxelMaps](Sandbox.Game.Entities.MyVoxelMaps)

