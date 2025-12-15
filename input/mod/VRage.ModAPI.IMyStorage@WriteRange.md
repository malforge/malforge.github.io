## Summary

```csharp
public void WriteRange(MyStorageData source, MyStorageDataTypeFlags dataToWrite, Vector3I voxelRangeMin, Vector3I voxelRangeMax, bool notify, bool skipCache)
```

Writes range of content and/or materials from cache to storage. Note that this can only write to LOD0 (higher LODs must be computed based on that).

## Parameters

* [MyStorageData](VRage.Voxels.MyStorageData) source
* [MyStorageDataTypeFlags](VRage.Voxels.MyStorageDataTypeFlags) dataToWrite
* [Vector3I](VRageMath.Vector3I) voxelRangeMin
* [Vector3I](VRageMath.Vector3I) voxelRangeMax
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) notify
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) skipCache
