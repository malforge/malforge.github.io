## Summary

```csharp
public bool SpotlightNotTooLarge(float reflectorConeMaxAngleCos, float reflectorRange)
```

When setting Reflector properties, use this function to test whether properties are in bounds and light AABB is not too large. Properties which affects calculations are ReflectorRange and ReflectorConeMaxAngleCos (ReflectorConeDegrees, ReflectorConeRadians)

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) reflectorConeMaxAngleCos
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) reflectorRange
