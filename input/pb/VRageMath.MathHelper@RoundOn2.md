## Summary

```csharp
public static float RoundOn2(float x)
```

Rounds to two decimal places. Not through an int: every renderer passes squared camera distances here and those leave int's range at 4.6 km, where the cast wrapped them to a large negative - which reads as the nearest thing in the scene to anything ordering by distance.

## Returns

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) x
