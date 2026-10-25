## Summary

```csharp
public void SetLimits(float min, float max)
```

Allows you to set the upper and lower limits of the slider

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) min
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) max
## Summary

```csharp
public void SetLimits(Func<IMyTerminalBlock, float> minGetter, Func<IMyTerminalBlock, float> maxGetter)
```

Allows you to set the upper and lower limits of the slider with delegates

## Parameters

* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;[IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock), [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)&gt; minGetter
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;[IMyTerminalBlock](Sandbox.ModAPI.IMyTerminalBlock), [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)&gt; maxGetter
