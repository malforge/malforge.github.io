**Assembly:** VRage.Game.dll

```csharp
public interface IMyStorage
```

ModAPI interface giving access to voxel functions

## Properties

|Member|Description|
|---|---|
|[Closed](VRage.ModAPI.IMyStorage@Closed)|Returns true if voxel storage was closed|
|[DeleteSupported](VRage.ModAPI.IMyStorage@DeleteSupported)|Returns if deletion is supported|
|[MarkedForClose](VRage.ModAPI.IMyStorage@MarkedForClose)|Returns true if the voxel storage is marked for a pending close|
|[Size](VRage.ModAPI.IMyStorage@Size)|The size of the voxel storage, in voxel coordinates|

## Methods

|Member|Description|
|---|---|
|[DeleteRange(MyStorageDataTypeFlags, Vector3I, Vector3I, bool)](VRage.ModAPI.IMyStorage@DeleteRange)|Deletes content in cache and storage|
|[ExecuteOperationFast<TVoxelOperator>(ref TVoxelOperator, MyStorageDataTypeFlags, ref Vector3I, ref Vector3I, bool)](VRage.ModAPI.IMyStorage@ExecuteOperationFast{TVoxelOperator})||
|[Intersect(ref BoundingBox, bool)](VRage.ModAPI.IMyStorage@Intersect)|Returns the intersection with the storage region|
|[Intersect(ref LineD)](VRage.ModAPI.IMyStorage@Intersect)|Returns true if the specific line intersects the storage region|
|[NotifyRangeChanged(ref Vector3I, ref Vector3I, MyStorageDataTypeFlags)](VRage.ModAPI.IMyStorage@NotifyRangeChanged)|Notify that range changed|
|[PinAndExecute(Action)](VRage.ModAPI.IMyStorage@PinAndExecute)|Pins the voxel storage to prevent closing, then executes specified action. Unpins when action completes.|
|[PinAndExecute(Action<IMyStorage>)](VRage.ModAPI.IMyStorage@PinAndExecute)|Pins the voxel storage to prevent closing, then executes specified action. Unpins when action completes.|
|[ReadRange(MyStorageData, MyStorageDataTypeFlags, int, Vector3I, Vector3I, ref MyVoxelRequestFlags)](VRage.ModAPI.IMyStorage@ReadRange)|Reads range of content and/or materials from specified LOD. If you want to write data back later, you must read LOD0 as that is the only writable one.|
|[ReadRange(MyStorageData, MyStorageDataTypeFlags, int, Vector3I, Vector3I)](VRage.ModAPI.IMyStorage@ReadRange)|Reads range of content and/or materials from specified LOD. If you want to write data back later, you must read LOD0 as that is the only writable one.|
|[Reset(MyStorageDataTypeFlags)](VRage.ModAPI.IMyStorage@Reset)|Resets the data specified by flags to values from data provider, or default if no provider is assigned.|
|[Save(out Byte[])](VRage.ModAPI.IMyStorage@Save)|Gets compressed voxel data|
|[WriteRange(MyStorageData, MyStorageDataTypeFlags, Vector3I, Vector3I, bool, bool)](VRage.ModAPI.IMyStorage@WriteRange)|Writes range of content and/or materials from cache to storage. Note that this can only write to LOD0 (higher LODs must be computed based on that).|
|[OverwriteAllMaterials(byte)](VRage.ModAPI.IMyStorage@OverwriteAllMaterials)|_**Obsolete**_<br /><br />Replaces all materials in range with the specific material|

