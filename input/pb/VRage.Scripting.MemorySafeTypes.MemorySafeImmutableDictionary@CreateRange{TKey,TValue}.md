## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> CreateRange<TKey, TValue>(IEnumerable<KeyValuePair<TKey, TValue>> items)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;

## Parameters

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;[KeyValuePair](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=netframework-4.6)&lt;TKey, TValue&gt;&gt; items
## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> CreateRange<TKey, TValue>(IEqualityComparer<TKey> keyComparer, IEnumerable<KeyValuePair<TKey, TValue>> items)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;

## Parameters

* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TKey&gt; keyComparer
* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;[KeyValuePair](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=netframework-4.6)&lt;TKey, TValue&gt;&gt; items
## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> CreateRange<TKey, TValue>(IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer, IEnumerable<KeyValuePair<TKey, TValue>> items)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;

## Parameters

* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TKey&gt; keyComparer
* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TValue&gt; valueComparer
* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;[KeyValuePair](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.KeyValuePair-2?view=netframework-4.6)&lt;TKey, TValue&gt;&gt; items
