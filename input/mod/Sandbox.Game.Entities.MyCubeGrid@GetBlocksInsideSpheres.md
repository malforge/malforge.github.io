## Summary

```csharp
public void GetBlocksInsideSpheres(ref BoundingSphereD sphere1, ref BoundingSphereD sphere2, ref BoundingSphereD sphere3, HashSet<MySlimBlock> blocks1, HashSet<MySlimBlock> blocks2, HashSet<MySlimBlock> blocks3, bool respectDeformationRatio, float detectionBlockHalfSize, ref MatrixD invWorldGrid)
```

Optimized version where spheres are sorted from smallest to largest

## Parameters

* [BoundingSphereD](VRageMath.BoundingSphereD) sphere1
* [BoundingSphereD](VRageMath.BoundingSphereD) sphere2
* [BoundingSphereD](VRageMath.BoundingSphereD) sphere3
* [HashSet](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netframework-4.6)&lt;MySlimBlock <sub>prohibited</sub>&gt; blocks1
* [HashSet](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netframework-4.6)&lt;MySlimBlock <sub>prohibited</sub>&gt; blocks2
* [HashSet](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.HashSet-1?view=netframework-4.6)&lt;MySlimBlock <sub>prohibited</sub>&gt; blocks3
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) respectDeformationRatio
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) detectionBlockHalfSize
* [MatrixD](VRageMath.MatrixD) invWorldGrid
