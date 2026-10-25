## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> ToTrackedImmutableDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;

## Parameters

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;[KeyValuePair](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=netframework-4.6)&lt;TKey, TValue&gt;&gt; source
## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> ToTrackedImmutableDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IEqualityComparer<TKey> keyComparer)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;

## Parameters

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;[KeyValuePair](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=netframework-4.6)&lt;TKey, TValue&gt;&gt; source
* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TKey&gt; keyComparer
## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> ToTrackedImmutableDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;

## Parameters

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;[KeyValuePair](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=netframework-4.6)&lt;TKey, TValue&gt;&gt; source
* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TKey&gt; keyComparer
* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TValue&gt; valueComparer
