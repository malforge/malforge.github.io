## Summary

```csharp
public static MemorySafeDictionary<TKey, TValue> ToMemorySafeDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
```

## Returns

[MemorySafeDictionary<TKey, TValue>](VRage.Scripting.MemorySafeTypes.MemorySafeDictionary{TKey,TValue})

## Parameters

* [IEnumerable<TSource>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6) source
* [Func<TSource, TKey>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) keySelector
* [Func<TSource, TValue>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) valueSelector
