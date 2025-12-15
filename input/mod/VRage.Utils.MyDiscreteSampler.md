**Assembly:** VRage.dll

```csharp
public class MyDiscreteSampler
```

Provides a simple and efficient way of sampling a discrete probability distribution as described in http://www.jstatsoft.org/v11/i03/paper Instances can be reused by calling the Prepare method every time you want to change the distribution. Sampling a value is O(1), while the storage requirements are O(N), where N is number of possible values

## Properties

|Member|Description|
|---|---|
|[Initialized](VRage.Utils.MyDiscreteSampler@Initialized)||

## Constructors

|Member|Description|
|---|---|
|[MyDiscreteSampler()](VRage.Utils.MyDiscreteSampler@.ctor)||
|[MyDiscreteSampler(int)](VRage.Utils.MyDiscreteSampler@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Prepare(IEnumerable<float>)](VRage.Utils.MyDiscreteSampler@Prepare)||
|[ReadBins()](VRage.Utils.MyDiscreteSampler@ReadBins)|Get a copy of the internal bins.|
|[Sample(MyRandom)](VRage.Utils.MyDiscreteSampler@Sample)||
|[Sample(float)](VRage.Utils.MyDiscreteSampler@Sample)||
|[Sample()](VRage.Utils.MyDiscreteSampler@Sample)||

