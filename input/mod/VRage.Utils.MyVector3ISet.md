**Assembly:** VRage.dll

```csharp
public class MyVector3ISet: IEnumerable<Vector3I>, IEnumerable
```

A data structure for a set of Vector3I coordinates optimized for sets with high spatial coherence (hence the name)

## Properties

|Member|Description|
|---|---|
|[Empty](VRage.Utils.MyVector3ISet@Empty)||

## Constructors

|Member|Description|
|---|---|
|[MyVector3ISet()](VRage.Utils.MyVector3ISet@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Add(ref Vector3I)](VRage.Utils.MyVector3ISet@Add)||
|[Add(Vector3I)](VRage.Utils.MyVector3ISet@Add)||
|[Clear()](VRage.Utils.MyVector3ISet@Clear)||
|[Contains(ref Vector3I)](VRage.Utils.MyVector3ISet@Contains)||
|[Contains(Vector3I)](VRage.Utils.MyVector3ISet@Contains)||
|[GetEnumerator()](VRage.Utils.MyVector3ISet@GetEnumerator)||
|[Remove(ref Vector3I)](VRage.Utils.MyVector3ISet@Remove)||
|[Remove(Vector3I)](VRage.Utils.MyVector3ISet@Remove)||
|[Union(MyVector3ISet)](VRage.Utils.MyVector3ISet@Union)|Makes a union of this set and the other set and saves it in this set|

**Implements:**  
* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=netframework-4.6)  
* [IEnumerable<Vector3I>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)

