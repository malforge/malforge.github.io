**Assembly:** VRage.Library.dll

```csharp
public class MyLibraryUtils
```

## Constructors

|Member|Description|
|---|---|
|[MyLibraryUtils()](VRage.Library.Utils.MyLibraryUtils@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static AssertBlittable<T>()](VRage.Library.Utils.MyLibraryUtils@AssertBlittable{T})||
|[static DenormalizeFloat(uint, float, float, int)](VRage.Library.Utils.MyLibraryUtils@DenormalizeFloat)|Denormalizes uint with specified number of bits into uniform-space float within min/max. This does not preserve 0 when min = -max|
|[static DenormalizeFloatCenter(uint, float, float, int)](VRage.Library.Utils.MyLibraryUtils@DenormalizeFloatCenter)|Denormalizes uint with specified number of bits into uniform-space float within min/max. This preserves 0 when min = -max|
|[static GetDivisionCeil(int, int)](VRage.Library.Utils.MyLibraryUtils@GetDivisionCeil)||
|[static GetDivisionCeil(long, long)](VRage.Library.Utils.MyLibraryUtils@GetDivisionCeil)||
|[static NormalizeFloat(float, float, float, int)](VRage.Library.Utils.MyLibraryUtils@NormalizeFloat)|Normalizes uniform-spaced float within min/max into uint with specified number of bits. This does not preserve 0 when min = -max|
|[static NormalizeFloatCenter(float, float, float, int)](VRage.Library.Utils.MyLibraryUtils@NormalizeFloatCenter)|Normalizes uniform-spaced float within min/max into uint with specified number of bits. This preserves 0 when min = -max|
|[static ThrowNonBlittable<T>()](VRage.Library.Utils.MyLibraryUtils@ThrowNonBlittable{T})||

