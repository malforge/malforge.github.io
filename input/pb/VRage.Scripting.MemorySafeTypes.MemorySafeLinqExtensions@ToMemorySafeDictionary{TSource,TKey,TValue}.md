## Summary

```csharp
public static MemorySafeDictionary<TKey, TValue> ToMemorySafeDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> valueSelector)
```

## Returns

[MemorySafeDictionary](VRage.Scripting.MemorySafeTypes.MemorySafeDictionary{TKey,TValue})&lt;TKey, TValue&gt;

## Parameters

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;TSource&gt; source
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TKey&gt; keySelector
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TValue&gt; valueSelector
