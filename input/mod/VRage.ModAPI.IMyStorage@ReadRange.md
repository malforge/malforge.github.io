## Summary

```csharp
public void ReadRange(MyStorageData target, MyStorageDataTypeFlags dataToRead, int lodIndex, Vector3I lodVoxelRangeMin, Vector3I lodVoxelRangeMax, ref MyVoxelRequestFlags requestFlags)
```

Reads range of content and/or materials from specified LOD. If you want to write data back later, you must read LOD0 as that is the only writable one.

## Parameters

* [MyStorageData](VRage.Voxels.MyStorageData) target
* [MyStorageDataTypeFlags](VRage.Voxels.MyStorageDataTypeFlags) dataToRead
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) lodIndex
* [Vector3I](VRageMath.Vector3I) lodVoxelRangeMin
* [Vector3I](VRageMath.Vector3I) lodVoxelRangeMax
* [MyVoxelRequestFlags](VRage.Voxels.MyVoxelRequestFlags) requestFlags
## Summary

```csharp
public void ReadRange(MyStorageData target, MyStorageDataTypeFlags dataToRead, int lodIndex, Vector3I lodVoxelRangeMin, Vector3I lodVoxelRangeMax)
```

Reads range of content and/or materials from specified LOD. If you want to write data back later, you must read LOD0 as that is the only writable one.

## Parameters

* [MyStorageData](VRage.Voxels.MyStorageData) target
* [MyStorageDataTypeFlags](VRage.Voxels.MyStorageDataTypeFlags) dataToRead
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) lodIndex
* [Vector3I](VRageMath.Vector3I) lodVoxelRangeMin
* [Vector3I](VRageMath.Vector3I) lodVoxelRangeMax
