## Summary

```csharp
public void CreateBoxPhysics(PhysicsSettings settings, Vector3 halfExtends, float convexRadius)
```

Creates physical body when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is null, or physics detector, when [DetectorColliderCallback](VRage.ModAPI.PhysicsSettings@DetectorColliderCallback) is not null. Created physics has a box collision

## Parameters

* [PhysicsSettings](VRage.ModAPI.PhysicsSettings) settings
* [Vector3](VRageMath.Vector3) halfExtends
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) convexRadius
