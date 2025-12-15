## Summary

```csharp
public bool IsExposureScalingNeeded { get; }
```

Indicates whether the value provided by GetCurrentExposure needs adjustment based on call interval. If the stat is meant to be affected in bursts (e.g. Health damage) and the source is responsible for correct average magnitude, this should return false

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

