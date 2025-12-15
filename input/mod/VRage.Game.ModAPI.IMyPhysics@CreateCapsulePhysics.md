## Summary

```csharp
public void CreateCapsulePhysics(PhysicsSettings settings, Vector3 vertexA, Vector3 vertexB, float radius)
```

Creates physical body when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is null, or physics detector, when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is not null. Created physics has a capsule collision

## Parameters

* [PhysicsSettings](VRage.ModAPI.PhysicsSettings) settings
* [Vector3](VRageMath.Vector3) vertexA
* [Vector3](VRageMath.Vector3) vertexB
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) radius
