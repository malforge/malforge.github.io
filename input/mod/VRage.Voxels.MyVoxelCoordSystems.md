**Assembly:** VRage.dll

```csharp
public abstract sealed class MyVoxelCoordSystems
```

Functions for transforming to and from various coordinate systems in voxel maps and for computing bounding boxes of various types of cells. Note that local and world positions are (and should be) always in the min-corner!

## Methods

|Member|Description|
|---|---|
|[static FindBestOctreeSize(float)](VRage.Voxels.MyVoxelCoordSystems@FindBestOctreeSize)||
|[static GeometryCellCenterCoordToWorldPos(Vector3D, ref Vector3I, out Vector3D)](VRage.Voxels.MyVoxelCoordSystems@GeometryCellCenterCoordToWorldPos)||
|[static GeometryCellCoordToLocalAABB(ref Vector3I, out BoundingBox)](VRage.Voxels.MyVoxelCoordSystems@GeometryCellCoordToLocalAABB)||
|[static GeometryCellCoordToLocalPosition(ref MyCellCoord, out Vector3)](VRage.Voxels.MyVoxelCoordSystems@GeometryCellCoordToLocalPosition)||
|[static GeometryCellCoordToLocalPosition(ref Vector3I, out Vector3)](VRage.Voxels.MyVoxelCoordSystems@GeometryCellCoordToLocalPosition)||
|[static GeometryCellCoordToWorldAABB(Vector3D, ref Vector3I, out BoundingBoxD)](VRage.Voxels.MyVoxelCoordSystems@GeometryCellCoordToWorldAABB)||
|[static GeometryCellCoordToWorldAABB(Vector3D, ref MyCellCoord, out BoundingBoxD)](VRage.Voxels.MyVoxelCoordSystems@GeometryCellCoordToWorldAABB)||
|[static LocalPositionToGeometryCellCoord(ref Vector3, out Vector3I)](VRage.Voxels.MyVoxelCoordSystems@LocalPositionToGeometryCellCoord)||
|[static LocalPositionToVertexCell(int, ref Vector3, out Vector3I)](VRage.Voxels.MyVoxelCoordSystems@LocalPositionToVertexCell)||
|[static LocalPositionToVoxelCoord(ref Vector3, out Vector3I)](VRage.Voxels.MyVoxelCoordSystems@LocalPositionToVoxelCoord)||
|[static LocalPositionToVoxelCoord(ref Vector3, out Vector3D)](VRage.Voxels.MyVoxelCoordSystems@LocalPositionToVoxelCoord)||
|[static LocalPositionToWorldPosition(MatrixD, Vector3D, Vector3, ref Vector3, out Vector3D)](VRage.Voxels.MyVoxelCoordSystems@LocalPositionToWorldPosition)||
|[static LocalPositionToWorldPosition(Vector3D, ref Vector3, out Vector3D)](VRage.Voxels.MyVoxelCoordSystems@LocalPositionToWorldPosition)||
|[static VertexCellToLocalAABB(int, ref Vector3I, out BoundingBoxD)](VRage.Voxels.MyVoxelCoordSystems@VertexCellToLocalAABB)||
|[static VertexCellToLocalPosition(int, ref Vector3I, out Vector3)](VRage.Voxels.MyVoxelCoordSystems@VertexCellToLocalPosition)||
|[static VoxelCoordToGeometryCellCoord(ref Vector3I, out Vector3I)](VRage.Voxels.MyVoxelCoordSystems@VoxelCoordToGeometryCellCoord)||
|[static VoxelCoordToLocalPosition(ref Vector3I, out Vector3)](VRage.Voxels.MyVoxelCoordSystems@VoxelCoordToLocalPosition)||
|[static VoxelCoordToWorldAABB(Vector3D, ref Vector3I, out BoundingBoxD)](VRage.Voxels.MyVoxelCoordSystems@VoxelCoordToWorldAABB)||
|[static VoxelCoordToWorldPosition(MatrixD, Vector3D, Vector3, ref Vector3I, out Vector3D)](VRage.Voxels.MyVoxelCoordSystems@VoxelCoordToWorldPosition)||
|[static VoxelCoordToWorldPosition(Vector3D, ref Vector3I, out Vector3D)](VRage.Voxels.MyVoxelCoordSystems@VoxelCoordToWorldPosition)||
|[static WorldPositionToGeometryCellCoord(Vector3D, ref Vector3D, out Vector3I)](VRage.Voxels.MyVoxelCoordSystems@WorldPositionToGeometryCellCoord)||
|[static WorldPositionToLocalPosition(Vector3D, MatrixD, MatrixD, Vector3, out Vector3)](VRage.Voxels.MyVoxelCoordSystems@WorldPositionToLocalPosition)||
|[static WorldPositionToLocalPosition(MatrixD, Vector3D, Vector3, ref Vector3D, out Vector3)](VRage.Voxels.MyVoxelCoordSystems@WorldPositionToLocalPosition)||
|[static WorldPositionToLocalPosition(Vector3D, ref Vector3D, out Vector3)](VRage.Voxels.MyVoxelCoordSystems@WorldPositionToLocalPosition)||
|[static WorldPositionToVoxelCoord(ref Vector3D, MatrixD, MatrixD, Vector3, out Vector3I)](VRage.Voxels.MyVoxelCoordSystems@WorldPositionToVoxelCoord)||
|[static WorldPositionToVoxelCoord(Vector3D, ref Vector3D, out Vector3I)](VRage.Voxels.MyVoxelCoordSystems@WorldPositionToVoxelCoord)||
|[static WorldPositionToVoxelCoord(MatrixD, Vector3D, Vector3, ref Vector3D, out Vector3I)](VRage.Voxels.MyVoxelCoordSystems@WorldPositionToVoxelCoord)||

