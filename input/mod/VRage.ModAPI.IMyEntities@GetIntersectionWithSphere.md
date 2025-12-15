## Summary

```csharp
public IMyEntity GetIntersectionWithSphere(ref BoundingSphereD sphere)
```

Returns first found (not closest) entity that intersects with sphere

## Returns

[IMyEntity](VRage.ModAPI.IMyEntity)

First found entity

## Parameters

* [BoundingSphereD](VRageMath.BoundingSphereD) sphere
## Summary

```csharp
public IMyEntity GetIntersectionWithSphere(ref BoundingSphereD sphere, IMyEntity ignoreEntity0, IMyEntity ignoreEntity1)
```

Returns first found (not closest) entity that intersects with sphere

## Returns

[IMyEntity](VRage.ModAPI.IMyEntity)

First found entity, or null

## Parameters

* [BoundingSphereD](VRageMath.BoundingSphereD) sphere
* [IMyEntity](VRage.ModAPI.IMyEntity) ignoreEntity0
* [IMyEntity](VRage.ModAPI.IMyEntity) ignoreEntity1
## Summary

```csharp
public IMyEntity GetIntersectionWithSphere(ref BoundingSphereD sphere, IMyEntity ignoreEntity0, IMyEntity ignoreEntity1, bool ignoreVoxelMaps, bool volumetricTest, bool excludeEntitiesWithDisabledPhysics, bool ignoreFloatingObjects, bool ignoreHandWeapons)
```

Returns first found (not closest) entity that intersects with sphere

## Returns

[IMyEntity](VRage.ModAPI.IMyEntity)

Found entity matching conditions

## Parameters

* [BoundingSphereD](VRageMath.BoundingSphereD) sphere
* [IMyEntity](VRage.ModAPI.IMyEntity) ignoreEntity0
* [IMyEntity](VRage.ModAPI.IMyEntity) ignoreEntity1
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) ignoreVoxelMaps
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) volumetricTest
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) excludeEntitiesWithDisabledPhysics
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) ignoreFloatingObjects
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) ignoreHandWeapons
## Summary

```csharp
public List<IMyEntity> GetIntersectionWithSphere(ref BoundingSphereD sphere, IMyEntity ignoreEntity0, IMyEntity ignoreEntity1, bool ignoreVoxelMaps, bool volumetricTest)
```

Returns list of entities that intersects with sphere

## Returns

[List<IMyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6)

List of entities inside of sphere

## Parameters

* [BoundingSphereD](VRageMath.BoundingSphereD) sphere
* [IMyEntity](VRage.ModAPI.IMyEntity) ignoreEntity0
* [IMyEntity](VRage.ModAPI.IMyEntity) ignoreEntity1
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) ignoreVoxelMaps
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) volumetricTest
## Remarks

Returned list may be used by system, next call if this or other similar function will clear list, so if you need to store data for long time, copy data from it. Also clean list, after you don't need it anymore

