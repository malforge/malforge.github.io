## Summary

```csharp
public Func<IMyAttackPatternComponent, Vector3?> GetFirstWeaponForwardVector { get; set; }
```

Gets or sets function that is called to know how grid should rotate to face target By default used reference to Keen default function (returns WorldMatrix.Forward vector) IMyAttackPatternComponent - attack pattern, that calls this clear Returns blocks WorldMatrix.Forward

## Returns

[Func<IMyAttackPatternComponent, Vector3?>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)

