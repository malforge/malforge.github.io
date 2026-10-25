## Summary

```csharp
public static TValue GetOrAdd<TKey, TValue, TContext>(this ConcurrentDictionary<TKey, TValue> dictionary, TKey key, TContext context, Func<TContext, TKey, TValue> activator)
```

## Returns

TValue

## Parameters

* [ConcurrentDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Concurrent.ConcurrentDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt; dictionary
* TKey key
* TContext context
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3?view=netframework-4.6)&lt;TContext, TKey, TValue&gt; activator
