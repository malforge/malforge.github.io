## Summary

```csharp
public static bool IsActionAllowed(MyEntity entity, MySafeZoneAction action, long sourceEntityId, ulong user)
```

Checks if action is allowed.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



## Parameters

* [MyEntity](VRage.Game.Entity.MyEntity) entity
* [MySafeZoneAction](VRage.Game.ObjectBuilders.Components.MySafeZoneAction) action
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) sourceEntityId
* [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6) user
## Summary

```csharp
public static bool IsActionAllowed(BoundingBoxD aabb, MySafeZoneAction action, long sourceEntityId, ulong user)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [BoundingBoxD](VRageMath.BoundingBoxD) aabb
* [MySafeZoneAction](VRage.Game.ObjectBuilders.Components.MySafeZoneAction) action
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) sourceEntityId
* [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6) user
## Summary

```csharp
public static bool IsActionAllowed(BoundingSphere boundingSphere, MySafeZoneAction action, long sourceEntityId, ulong user)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [BoundingSphere](VRageMath.BoundingSphere) boundingSphere
* [MySafeZoneAction](VRage.Game.ObjectBuilders.Components.MySafeZoneAction) action
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) sourceEntityId
* [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6) user
## Summary

```csharp
public static bool IsActionAllowed(Vector3D point, MySafeZoneAction action, long sourceEntityId, ulong user)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [Vector3D](VRageMath.Vector3D) point
* [MySafeZoneAction](VRage.Game.ObjectBuilders.Components.MySafeZoneAction) action
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) sourceEntityId
* [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6) user
## Summary

```csharp
public static bool IsActionAllowed(MyCubeGrid grid, Vector3I cubeMin, Vector3I cubeMax, MySafeZoneAction AllowedActions, long attackerId)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [MyCubeGrid](Sandbox.Game.Entities.MyCubeGrid) grid
* [Vector3I](VRageMath.Vector3I) cubeMin
* [Vector3I](VRageMath.Vector3I) cubeMax
* [MySafeZoneAction](VRage.Game.ObjectBuilders.Components.MySafeZoneAction) AllowedActions
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) attackerId
