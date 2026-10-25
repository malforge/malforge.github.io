## Summary

```csharp
public List<IMyEntity> GetEntitiesInSphere(ref BoundingSphereD boundingSphere)
```

Returns list of entities that intersects with sphere. This function will return CubeBlocks. This function works slower than [GetTopMostEntitiesInSphere(ref BoundingSphereD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInSphere) 

## Returns

[List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[IMyEntity](VRage.ModAPI.IMyEntity)&gt;

New list of entities

## Parameters

* [BoundingSphereD](VRageMath.BoundingSphereD) boundingSphere
