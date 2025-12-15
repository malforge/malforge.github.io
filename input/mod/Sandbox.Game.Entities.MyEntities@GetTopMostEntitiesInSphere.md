## Summary

```csharp
public static List<MyEntity> GetTopMostEntitiesInSphere(ref BoundingSphereD boundingSphere)
```

Returns list of entities that intersects with oriented bounding box. If you are modder, you better use IMyEntities method. It is safe to use.

## Returns

[List<MyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)

WARNING: Next call of function GetEntitiesInAABB would add elements to that list.right after use. It may break or slow game, if you won't clean array before next [GetEntitiesInAABB(ref BoundingBox)](Sandbox.Game.Entities.MyEntities@GetEntitiesInAABB) , [GetEntitiesInAABB(ref BoundingBoxD, bool)](Sandbox.Game.Entities.MyEntities@GetEntitiesInAABB) , [GetEntitiesInSphere(ref BoundingSphereD)](Sandbox.Game.Entities.MyEntities@GetEntitiesInSphere)  [GetElementsInBox(ref BoundingBoxD, List<MyEntity>)](Sandbox.Game.Entities.MyEntities@GetElementsInBox)  [GetTopMostEntitiesInSphere(ref BoundingSphereD)](Sandbox.Game.Entities.MyEntities@GetTopMostEntitiesInSphere)  [GetTopMostEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)](Sandbox.Game.Entities.MyEntities@GetTopMostEntitiesInBox) 

## Parameters

* [BoundingSphereD](VRageMath.BoundingSphereD) boundingSphere
