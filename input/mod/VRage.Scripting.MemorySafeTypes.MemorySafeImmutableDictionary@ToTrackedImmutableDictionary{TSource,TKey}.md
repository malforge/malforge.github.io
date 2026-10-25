## Summary

```csharp
public static ImmutableDictionary<TKey, TSource> ToTrackedImmutableDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TSource&gt;

## Parameters

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;TSource&gt; source
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TKey&gt; keySelector
## Summary

```csharp
public static ImmutableDictionary<TKey, TSource> ToTrackedImmutableDictionary<TSource, TKey>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, IEqualityComparer<TKey> keyComparer)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TSource&gt;

## Parameters

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;TSource&gt; source
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TKey&gt; keySelector
* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TKey&gt; keyComparer
