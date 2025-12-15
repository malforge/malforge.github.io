## Summary

```csharp
public static float DenormalizeFloatCenter(uint value, float min, float max, int bits)
```

Denormalizes uint with specified number of bits into uniform-space float within min/max. This preserves 0 when min = -max

## Returns

[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)

## Parameters

* [uint](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32?view=netframework-4.6) value
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) min
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) max
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) bits
