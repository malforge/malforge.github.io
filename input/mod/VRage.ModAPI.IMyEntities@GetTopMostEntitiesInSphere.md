## Summary

```csharp
public List<IMyEntity> GetTopMostEntitiesInSphere(ref BoundingSphereD boundingSphere)
```

Returns list of `TopMost` entities that intersects with sphere. This function won't return CubeBlocks. Use [GetEntitiesInSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetEntitiesInSphere) to retrieve CubeBlocks also.

## Returns

[List<IMyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)

New list of entities

## Parameters

* [BoundingSphereD](VRageMath.BoundingSphereD) boundingSphere
