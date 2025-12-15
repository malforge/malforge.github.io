## Summary

```csharp
public Func<IMyEntity, IMyAttackPatternComponent, double, Vector3D> GetPredictedLookAt { get; set; }
```

Gets or sets function that is called for aiming grid at enemy By default used reference to Keen default function Must not be null. You need override it on server and client IMyEntity - entity that you should aim at predicting it's future position, and bullet speed IMyAttackPatternComponent - current component that need aim Double - distance to target squared Returns world position

## Returns

[Func<IMyEntity, IMyAttackPatternComponent, double, Vector3D>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-4?view=netframework-4.6)

