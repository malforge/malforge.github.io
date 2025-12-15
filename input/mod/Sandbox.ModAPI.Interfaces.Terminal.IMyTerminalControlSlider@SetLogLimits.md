## Summary

```csharp
public void SetLogLimits(float min, float max)
```

Allows you to set the upper and lower limits of the slider, interpolating on a logarithmic scale

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) min
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) max
## Summary

```csharp
public void SetLogLimits(Func<IMyTerminalBlock, float> minGetter, Func<IMyTerminalBlock, float> maxGetter)
```

Allows you to set the upper and lower limits of the slider with delegates, interpolating on a logarithmic scale

## Parameters

* [Func<IMyTerminalBlock, float>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) minGetter
* [Func<IMyTerminalBlock, float>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) maxGetter
