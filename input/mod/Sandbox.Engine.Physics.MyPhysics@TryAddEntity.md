## Summary

```csharp
public static ulong TryAddEntity(IMyEntity entity, MyPhysicsBody activationHandler, bool batchRequest)
```

Attempts to add the entity to the cluster Creates new cluster if allowed (!SingleCluster.HasValue) and needed (entity is outside of existing clusters). If not allowed, marks entity as left the world.

## Returns

[ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6)

id

## Parameters

* [IMyEntity](VRage.ModAPI.IMyEntity) entity
* MyPhysicsBody <sub>prohibited</sub> activationHandler
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) batchRequest
