**Assembly:** VRage.dll

```csharp
public class ConcurrentNormalAggregator
```

## Constructors

|Member|Description|
|---|---|
|[ConcurrentNormalAggregator(int)](VRage.Utils.ConcurrentNormalAggregator@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Clear()](VRage.Utils.ConcurrentNormalAggregator@Clear)|Allowed to be called only from one thread at the time! It's not safe to call [GetAvgNormal(out Vector3)](VRage.Utils.ConcurrentNormalAggregator@GetAvgNormal) method in parallel!|
|[GetAvgNormal(out Vector3)](VRage.Utils.ConcurrentNormalAggregator@GetAvgNormal)|Consumption is allowed only from one thread at the time! It's not safe to call [Clear()](VRage.Utils.ConcurrentNormalAggregator@Clear) method in parallel!|
|[GetAvgNormalCached(out Vector3)](VRage.Utils.ConcurrentNormalAggregator@GetAvgNormalCached)||
|[PushNext(ref Vector3)](VRage.Utils.ConcurrentNormalAggregator@PushNext)|Might be safely called from multiple threads at the same time.|

