## Summary

```csharp
public List<IMyEntity> GetElementsInBox(ref BoundingBoxD boundingBox)
```

Returns list of entities that intersects with BoundingBox. This function will return CubeBlocks. This function works slower than [GetTopMostEntitiesInBox(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetTopMostEntitiesInBox) 

## Returns

[List<IMyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)

New list of entities

## Parameters

* [BoundingBoxD](VRageMath.BoundingBoxD) boundingBox
## Remarks

Same as [GetEntitiesInAABB(ref BoundingBoxD)](VRage.ModAPI.IMyEntities@GetEntitiesInAABB) 

