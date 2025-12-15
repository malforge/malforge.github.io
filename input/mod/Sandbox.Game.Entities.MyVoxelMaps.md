**Assembly:** Sandbox.Game.dll

```csharp
public class MyVoxelMaps: IMyVoxelMaps
```

## Properties

|Member|Description|
|---|---|
|[Instances](Sandbox.Game.Entities.MyVoxelMaps@Instances)||
|[VoxelMaterialCount](VRage.Game.ModAPI.IMyVoxelMaps@VoxelMaterialCount)|_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|

## Constructors

|Member|Description|
|---|---|
|[MyVoxelMaps()](Sandbox.Game.Entities.MyVoxelMaps@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Add(MyVoxelBase)](Sandbox.Game.Entities.MyVoxelMaps@Add)||
|[Clear()](Sandbox.Game.Entities.MyVoxelMaps@Clear)||
|[DebugDraw(MyVoxelDebugDrawMode)](Sandbox.Game.Entities.MyVoxelMaps@DebugDraw)||
|[Exist(MyVoxelBase)](Sandbox.Game.Entities.MyVoxelMaps@Exist)||
|[GetAllOverlappingWithSphere(ref BoundingSphereD, List<MyVoxelBase>)](Sandbox.Game.Entities.MyVoxelMaps@GetAllOverlappingWithSphere)||
|[GetAllOverlappingWithSphere(ref BoundingSphereD)](Sandbox.Game.Entities.MyVoxelMaps@GetAllOverlappingWithSphere)||
|[GetCacheStats(out int, out int)](Sandbox.Game.Entities.MyVoxelMaps@GetCacheStats)||
|[GetOverlappingWithSphere(ref BoundingSphereD)](Sandbox.Game.Entities.MyVoxelMaps@GetOverlappingWithSphere)||
|[GetVoxelMapsArray(bool)](Sandbox.Game.Entities.MyVoxelMaps@GetVoxelMapsArray)||
|[GetVoxelMapsData(bool, bool, Dictionary<string, IMyStorage>)](Sandbox.Game.Entities.MyVoxelMaps@GetVoxelMapsData)||
|[GetVoxelMapsWhoseBoundingBoxesIntersectBox(ref BoundingBoxD, MyVoxelBase, List<MyVoxelBase>)](Sandbox.Game.Entities.MyVoxelMaps@GetVoxelMapsWhoseBoundingBoxesIntersectBox)||
|[GetVoxelMapWhoseBoundingBoxIntersectsBox(ref BoundingBoxD, MyVoxelBase)](Sandbox.Game.Entities.MyVoxelMaps@GetVoxelMapWhoseBoundingBoxIntersectsBox)|Return reference to voxel map that intersects the box. If not voxel map found, null is returned.|
|[RemoveVoxelMap(MyVoxelBase)](Sandbox.Game.Entities.MyVoxelMaps@RemoveVoxelMap)||
|[TryGetVoxelBaseById(long)](Sandbox.Game.Entities.MyVoxelMaps@TryGetVoxelBaseById)||
|[TryGetVoxelMapByName(string)](Sandbox.Game.Entities.MyVoxelMaps@TryGetVoxelMapByName)||
|[TryGetVoxelMapByNameStart(string)](Sandbox.Game.Entities.MyVoxelMaps@TryGetVoxelMapByNameStart)||
|[Clear()](VRage.Game.ModAPI.IMyVoxelMaps@Clear)|Resets all voxels over whole world<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[CreatePredefinedVoxelMap(string, string, MatrixD, bool)](VRage.Game.ModAPI.IMyVoxelMaps@CreatePredefinedVoxelMap)|Creates an voxel map with some additional options.<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[CreateProceduralVoxelMap(int, float, MatrixD)](VRage.Game.ModAPI.IMyVoxelMaps@CreateProceduralVoxelMap)|_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[CreateStorage(Vector3I)](VRage.Game.ModAPI.IMyVoxelMaps@CreateStorage)|Creates voxels storage<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[CreateStorage(Byte[])](VRage.Game.ModAPI.IMyVoxelMaps@CreateStorage)|Creates storage from GZipped bytes.<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[CreateVoxelMap(string, IMyStorage, Vector3D, long)](VRage.Game.ModAPI.IMyVoxelMaps@CreateVoxelMap)|Creates voxels map<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[CreateVoxelMapFromStorageName(string, string, Vector3D)](VRage.Game.ModAPI.IMyVoxelMaps@CreateVoxelMapFromStorageName)|Adds a prefab voxel to the game world.<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[CutOutShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@CutOutShape)|Will cut out given shape<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[Exist(IMyVoxelBase)](VRage.Game.ModAPI.IMyVoxelMaps@Exist)|Returns if voxel registered<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[FillInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@FillInShape)|Will fill given material with given shape<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[GetBoxVoxelHand()](VRage.Game.ModAPI.IMyVoxelMaps@GetBoxVoxelHand)|Gets box voxel hand. Can be used in [PaintInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@PaintInShape) , [CutOutShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@CutOutShape) , [FillInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@FillInShape) , [RevertShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@RevertShape)<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[GetCapsuleVoxelHand()](VRage.Game.ModAPI.IMyVoxelMaps@GetCapsuleVoxelHand)|Gets capsule voxel hand. Can be used in [PaintInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@PaintInShape) , [CutOutShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@CutOutShape) , [FillInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@FillInShape) , [RevertShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@RevertShape)<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[GetInstances(List<IMyVoxelBase>, Func<IMyVoxelBase, bool>)](VRage.Game.ModAPI.IMyVoxelMaps@GetInstances)|Gets all instances of [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase)<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[GetOverlappingWithSphere(ref BoundingSphereD)](VRage.Game.ModAPI.IMyVoxelMaps@GetOverlappingWithSphere)|Get first found [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase) that intersects with sphere<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[GetRampVoxelHand()](VRage.Game.ModAPI.IMyVoxelMaps@GetRampVoxelHand)|Gets ramp voxel hand. Can be used in [PaintInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@PaintInShape) , [CutOutShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@CutOutShape) , [FillInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@FillInShape) , [RevertShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@RevertShape)<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[GetSphereVoxelHand()](VRage.Game.ModAPI.IMyVoxelMaps@GetSphereVoxelHand)|Gets sphere voxel hand. Can be used in [PaintInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@PaintInShape) , [CutOutShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@CutOutShape) , [FillInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@FillInShape) , [RevertShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@RevertShape)<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[GetVoxelMapWhoseBoundingBoxIntersectsBox(ref BoundingBoxD, IMyVoxelBase)](VRage.Game.ModAPI.IMyVoxelMaps@GetVoxelMapWhoseBoundingBoxIntersectsBox)|Get first found [IMyVoxelBase](VRage.ModAPI.IMyVoxelBase) that intersects with bounding box, ordered by distance to box center<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[MakeCrater(IMyVoxelBase, BoundingSphereD, Vector3, byte)](VRage.Game.ModAPI.IMyVoxelMaps@MakeCrater)|_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[PaintInShape(IMyVoxelBase, IMyVoxelShape, byte)](VRage.Game.ModAPI.IMyVoxelMaps@PaintInShape)|Will paint given material with given shape<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[RevertShape(IMyVoxelBase, IMyVoxelShape)](VRage.Game.ModAPI.IMyVoxelMaps@RevertShape)|_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|
|[SpawnPlanet(string, float, int, Vector3D)](VRage.Game.ModAPI.IMyVoxelMaps@SpawnPlanet)|Creates a Planet Entity<br /><br />_Inherited from [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)_|

**Implements:**  
* [IMyVoxelMaps](VRage.Game.ModAPI.IMyVoxelMaps)

