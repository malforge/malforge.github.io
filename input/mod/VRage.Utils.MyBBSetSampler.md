**Assembly:** VRage.dll

```csharp
public class MyBBSetSampler
```

This class allows for uniform generation of points from a set of bounding boxes. You start by constructing a bounding box from where the points will be sampled. Then you can incrementally subtract bounding boxes and the resulting structure will allow you to generate uniformly distributed points using the Sample() function.

## Properties

|Member|Description|
|---|---|
|[Valid](VRage.Utils.MyBBSetSampler@Valid)||

## Constructors

|Member|Description|
|---|---|
|[MyBBSetSampler(Vector3D, Vector3D)](VRage.Utils.MyBBSetSampler@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Sample()](VRage.Utils.MyBBSetSampler@Sample)||
|[SubtractBB(ref BoundingBoxD)](VRage.Utils.MyBBSetSampler@SubtractBB)||

