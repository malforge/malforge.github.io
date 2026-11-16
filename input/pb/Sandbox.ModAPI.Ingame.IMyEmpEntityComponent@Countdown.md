## Summary

```csharp
public float Countdown { get; set; }
```

Gets or sets the countdown, in seconds, remaining before the device discharges itself. The value is clamped to the range supported by the terminal slider. Setting it while the countdown is running restarts the remaining time from the new value.

## Returns

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

