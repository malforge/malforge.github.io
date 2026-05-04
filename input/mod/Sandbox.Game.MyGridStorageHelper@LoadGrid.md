## Summary

```csharp
public MyGridLoadFuture LoadGrid(Guid guid, Quaternion orientation, Vector3D basePos, Vector3D desiredPos, float placementTolerance, long owner, Action<MyGridLoadFuture> onCompletion)
```

## Returns

[MyGridLoadFuture](Sandbox.Game.MyGridStorageHelper+MyGridLoadFuture)

## Parameters

* [Guid](https://docs.microsoft.com/en-us/dotnet/api/System.Guid?view=netframework-4.6) guid
* [Quaternion](VRageMath.Quaternion) orientation
* [Vector3D](VRageMath.Vector3D) basePos
* [Vector3D](VRageMath.Vector3D) desiredPos
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) placementTolerance
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) owner
* [Action<MyGridLoadFuture>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) onCompletion
