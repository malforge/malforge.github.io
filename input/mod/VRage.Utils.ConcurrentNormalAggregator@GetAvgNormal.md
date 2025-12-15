## Summary

```csharp
public bool GetAvgNormal(out Vector3 normal)
```

Consumption is allowed only from one thread at the time! It's not safe to call [Clear()](VRage.Utils.ConcurrentNormalAggregator@Clear) method in parallel!

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [Vector3](VRageMath.Vector3) normal
