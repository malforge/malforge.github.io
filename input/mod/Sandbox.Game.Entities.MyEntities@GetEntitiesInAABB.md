## Summary

```csharp
public static List<MyEntity> GetEntitiesInAABB(ref BoundingBox boundingBox)
```

Get all rigid body elements touching a bounding box. Clear() the result list after you're done with it!

## Returns

[List<MyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)

The list of results.

## Parameters

* [BoundingBox](VRageMath.BoundingBox) boundingBox
## Summary

```csharp
public static List<MyEntity> GetEntitiesInAABB(ref BoundingBoxD boundingBox, bool exact)
```

Returns list of entities that intersects with BoundingBox. If you are modder, you better use IMyEntities method. It is safe to use.

## Returns

[List<MyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)

WARNING: Next call of function GetEntitiesInAABB would add elements to that list.right after use. It may break or slow game, if you won't clean array before next [GetEntitiesInAABB(ref BoundingBox)](Sandbox.Game.Entities.MyEntities@GetEntitiesInAABB) , [GetEntitiesInAABB(ref BoundingBoxD, bool)](Sandbox.Game.Entities.MyEntities@GetEntitiesInAABB) , [GetEntitiesInSphere(ref BoundingSphereD)](Sandbox.Game.Entities.MyEntities@GetEntitiesInSphere)  [GetElementsInBox(ref BoundingBoxD, List<MyEntity>)](Sandbox.Game.Entities.MyEntities@GetElementsInBox)  [GetTopMostEntitiesInSphere(ref BoundingSphereD)](Sandbox.Game.Entities.MyEntities@GetTopMostEntitiesInSphere)  [GetTopMostEntitiesInBox(ref BoundingBoxD, List<MyEntity>, MyEntityQueryType)](Sandbox.Game.Entities.MyEntities@GetTopMostEntitiesInBox) 

## Parameters

* [BoundingBoxD](VRageMath.BoundingBoxD) boundingBox
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) exact
