## Summary

```csharp
public float GetOutsideTemperature()
```

Returns outside temperature around character. If character is in presurrized/oxygen environment, then the temperature is always friendly.

## Returns

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

0 for extreme freeze, 0.5 for cozy, 1.0 for extreme hot

