**Assembly:** VRage.dll

```csharp
public class MyTimedItemCache
```

Temporaly stores information about item (event/place) existence. This is useful if you want to launch some actions only from time to time. You ask timed cache whether your last event still takes effect.

## Properties

|Member|Description|
|---|---|
|[EventTimeoutMs](VRage.Utils.MyTimedItemCache@EventTimeoutMs)||

## Constructors

|Member|Description|
|---|---|
|[MyTimedItemCache(int)](VRage.Utils.MyTimedItemCache@.ctor)||

## Methods

|Member|Description|
|---|---|
|[IsItemPresent(long, int, bool)](VRage.Utils.MyTimedItemCache@IsItemPresent)|Generic item. Check whether generic item exists in the timed cache. autoinsert param: If the item is not found, it is inserted to the cache if the argument autoinsert is true.|
|[IsPlaceUsed(Vector3D, double, int, bool)](VRage.Utils.MyTimedItemCache@IsPlaceUsed)|Helper function. Check temporal usage of space. Check whether the place is taken. Internally converts position to generic item. Please use consistent eventSpaceMapping, otherwise cache will not find your items. autoinsert param: If the item is not found, it is inserted to the cache if the argument autoinsert is true.|

