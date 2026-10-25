## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> ToTrackedImmutableDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> elementSelector)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;

## Parameters

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;TSource&gt; source
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TKey&gt; keySelector
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TValue&gt; elementSelector
## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> ToTrackedImmutableDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> elementSelector, IEqualityComparer<TKey> keyComparer)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;

## Parameters

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;TSource&gt; source
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TKey&gt; keySelector
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TValue&gt; elementSelector
* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TKey&gt; keyComparer
## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> ToTrackedImmutableDictionary<TSource, TKey, TValue>(this IEnumerable<TSource> source, Func<TSource, TKey> keySelector, Func<TSource, TValue> elementSelector, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;

## Parameters

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;TSource&gt; source
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TKey&gt; keySelector
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TValue&gt; elementSelector
* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TKey&gt; keyComparer
* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TValue&gt; valueComparer
