## Summary

```csharp
public void AddDecals(ref MyHitInfo hitInfo, MyStringHash source, Vector3 forwardDirection, object customdata, IMyDecalHandler decalHandler, MyStringHash physicalMaterial, MyStringHash voxelMaterial, bool isTrail, MyDecalFlags flags, int aliveUntil, List<uint> outids)
```

Called from Sandbox.Game.MyDecals

## Parameters

* [MyHitInfo](VRage.Game.ModAPI.MyHitInfo) hitInfo
* [MyStringHash](VRage.Utils.MyStringHash) source
* [Vector3](VRageMath.Vector3) forwardDirection
* [object](https://docs.microsoft.com/en-us/dotnet/api/System.Object?view=netframework-4.6) customdata
* [IMyDecalHandler](VRage.Game.ModAPI.Interfaces.IMyDecalHandler) decalHandler
* [MyStringHash](VRage.Utils.MyStringHash) physicalMaterial
* [MyStringHash](VRage.Utils.MyStringHash) voxelMaterial
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) isTrail
* [MyDecalFlags](VRageRender.MyDecalFlags) flags
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) aliveUntil
* [List<uint>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) outids
