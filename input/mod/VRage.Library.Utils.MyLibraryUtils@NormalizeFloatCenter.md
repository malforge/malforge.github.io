## Summary

```csharp
public static uint NormalizeFloatCenter(float value, float min, float max, int bits)
```

Normalizes uniform-spaced float within min/max into uint with specified number of bits. This preserves 0 when min = -max

## Returns

[uint](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32?view=netframework-4.6)

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) value
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) min
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) max
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) bits
