## Summary

```csharp
public float MaxLaunchOffAxisDegrees
```

Widest angle between the launcher's forward and the target at which an AI combat block may still fire this ammo, in degrees; 0 keeps the attack pattern's own firing angle. Only seeking ammo can convert an off-axis launch into a hit, so keep it within what MaxTurnRateDegreesPerSecond and Lifetime can actually recover.

## Returns

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

