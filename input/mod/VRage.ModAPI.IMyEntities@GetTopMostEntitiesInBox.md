## Summary

```csharp
public List<IMyEntity> GetTopMostEntitiesInBox(ref BoundingBoxD boundingBox)
```

Returns list of `TopMost` entities that intersects with bounding box. This function won't return CubeBlocks. Use [GetElementsInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetElementsInBox) to retrieve CubeBlocks also.

## Returns

[List](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)&lt;[IMyEntity](VRage.ModAPI.IMyEntity)&gt;

New list of entities

## Parameters

* [BoundingBoxD](VRageMath.BoundingBoxD) boundingBox
