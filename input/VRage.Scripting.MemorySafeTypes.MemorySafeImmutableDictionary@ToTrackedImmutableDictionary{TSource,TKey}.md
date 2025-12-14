## Summary

```csharp
public static ImmutableDictionary<TKey, TSource> ToTrackedImmutableDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

## Returns

[ImmutableDictionary<TKey, TSource>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)

## Parameters

* [IEnumerable<TSource>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6) source
* [Func<TSource, TKey>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) keySelector
## Summary

```csharp
public static ImmutableDictionary<TKey, TSource> ToTrackedImmutableDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> keyComparer)
```

## Returns

[ImmutableDictionary<TKey, TSource>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)

## Parameters

* [IEnumerable<TSource>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6) source
* [Func<TSource, TKey>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) keySelector
* [IEqualityComparer<TKey>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6) keyComparer
