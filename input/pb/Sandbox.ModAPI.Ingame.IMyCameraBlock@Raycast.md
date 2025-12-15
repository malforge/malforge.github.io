## Summary

```csharp
public MyDetectedEntityInfo Raycast(double distance, float pitch, float yaw)
```

Does a raycast in the direction the camera is facing.

## Returns

[MyDetectedEntityInfo](Sandbox.ModAPI.Ingame.MyDetectedEntityInfo)

Empty if distance or angle are out of bounds.

## Parameters

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) distance
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) pitch
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) yaw
## Summary

```csharp
public MyDetectedEntityInfo Raycast(Vector3D targetPos)
```

Does a raycast to the specific target point.

## Returns

[MyDetectedEntityInfo](Sandbox.ModAPI.Ingame.MyDetectedEntityInfo)

Empty if distance or angle are out of bounds.

## Parameters

* [Vector3D](VRageMath.Vector3D) targetPos
## Summary

```csharp
public MyDetectedEntityInfo Raycast(double distance, Vector3D targetDirection)
```

Does a raycast in the given direction (in camera local space).

## Returns

[MyDetectedEntityInfo](Sandbox.ModAPI.Ingame.MyDetectedEntityInfo)

Empty if distance or angle are out of bounds.

## Parameters

* [double](https://docs.microsoft.com/en-us/dotnet/api/System.Double?view=netframework-4.6) distance
* [Vector3D](VRageMath.Vector3D) targetDirection
