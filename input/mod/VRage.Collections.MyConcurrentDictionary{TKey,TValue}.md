**Assembly:** VRage.Library.dll

```csharp
public class MyConcurrentDictionary<TKey, TValue>: IEnumerable<KeyValuePair<TKey, TValue>>, IEnumerable
```

## Properties

|Member|Description|
|---|---|
|[Count](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@Count)||
|[Item](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@Item)||
|[Keys](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@Keys)||
|[Values](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@Values)||

## Constructors

|Member|Description|
|---|---|
|[MyConcurrentDictionary(IEqualityComparer<TKey>)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@.ctor)||
|[MyConcurrentDictionary(int, IEqualityComparer<TKey>)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Add(TKey, TValue)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@Add)||
|[AssignCopyTo(ref IReadOnlyDictionary<TKey, TValue>)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@AssignCopyTo)||
|[ChangeKey(TKey, TKey)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@ChangeKey)||
|[Clear()](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@Clear)||
|[ContainsKey(TKey)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@ContainsKey)||
|[ContainsValue(TValue)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@ContainsValue)||
|[FirstPair()](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@FirstPair)||
|[GetEnumerator()](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@GetEnumerator)||
|[GetOrAdd(TKey, Func<TKey, TValue>)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@GetOrAdd)||
|[GetValueOrDefault(TKey, TValue)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@GetValueOrDefault)||
|[GetValues(List<TValue>)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@GetValues)||
|[Remove(TKey)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@Remove)||
|[TryAdd(TKey, TValue)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@TryAdd)||
|[TryGetValue(TKey, out TValue)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@TryGetValue)||
|[TryRemove(TKey, out TValue)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@TryRemove)||
|[TryRemoveConditionally<TCondition>(TKey, out TValue, TCondition)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@TryRemoveConditionally{TCondition})||
|[WithExclusiveLock(Action<MyConcurrentDictionary<TKey, TValue>>)](VRage.Collections.MyConcurrentDictionary{TKey,TValue}@WithExclusiveLock)||

**Implements:**  
* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=netframework-4.6)  
* [IEnumerable<KeyValuePair<TKey, TValue>>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)

