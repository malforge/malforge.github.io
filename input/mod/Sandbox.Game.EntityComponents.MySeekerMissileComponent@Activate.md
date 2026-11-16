## Summary

```csharp
public void Activate(MyMissile missile, MyMissileAmmoDefinition definition, long targetEntityId)
```

(Re)initializes the seeker for a fresh launch, caching the guidance parameters (cones stored as half-angle cosines, per-tick turn step in radians and its cosine) and clearing prior lock state. Cheap enough to call on every (re)spawn of a pooled missile.

## Parameters

* MyMissile <sub>prohibited</sub> missile
* [MyMissileAmmoDefinition](Sandbox.Definitions.MyMissileAmmoDefinition) definition
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) targetEntityId
