## Summary

```csharp
public static TValue GetOrAdd<TKey, TValue, TContext>(this ConcurrentDictionary<TKey, TValue> dictionary, TKey key, TContext context, Func<TContext, TKey, TValue> activator)
```

## Returns

[TValue](System.Collections.Generic.DictionaryExtensions+TValue)

## Parameters

* [ConcurrentDictionary<TKey, TValue>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Concurrent.ConcurrentDictionary-2?view=netframework-4.6) dictionary
* [TKey](System.Collections.Generic.DictionaryExtensions+TKey) key
* [TContext](System.Collections.Generic.DictionaryExtensions+TContext) context
* [Func<TContext, TKey, TValue>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3?view=netframework-4.6) activator
