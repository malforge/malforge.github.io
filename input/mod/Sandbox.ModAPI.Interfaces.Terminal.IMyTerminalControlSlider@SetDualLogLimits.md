## Summary

```csharp
public void SetDualLogLimits(float absMin, float absMax, float centerBand)
```

Allows you to set the upper and lower limits of the slider, interpolating on a logarithmic scale at both ends

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) absMin
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) absMax
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) centerBand
## Summary

```csharp
public void SetDualLogLimits(Func<IMyTerminalBlock, float> minGetter, Func<IMyTerminalBlock, float> maxGetter, float centerBand)
```

Allows you to set the upper and lower limits of the slider with delegates, interpolating on a logarithmic scale at both ends

## Parameters

* [Func<IMyTerminalBlock, float>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) minGetter
* [Func<IMyTerminalBlock, float>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) maxGetter
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) centerBand
