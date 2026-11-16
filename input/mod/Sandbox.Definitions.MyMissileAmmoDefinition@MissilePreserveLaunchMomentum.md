## Summary

```csharp
public bool MissilePreserveLaunchMomentum
```

Keeps momentum inherited from the launching grid out of the missile's heading: the nose is not snapped onto the travel direction while that momentum dominates, and the velocity is swung onto the nose at MaxTurnRateDegreesPerSecond instead of instantly. Required by ammo whose MissileInitialSpeed is well below grid speeds. Not for ammo relying on MissileGravityEnabled, whose arc the velocity turn would cancel out.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

