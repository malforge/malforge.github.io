## Summary

```csharp
public float HealthPool { get; set; }
```

Gets or sets health of missile. While it is more than 0, it is damaging blocks that it collide with, each time subtracting amount of damage dealt. When left health is less or equal 0, missile explodes (if it hitted anything and [ShouldExplode](Sandbox.ModAPI.IMyMissile@ShouldExplode) is true).

## Returns

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

