## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> ToTrackedImmutableDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source)
```

## Returns

[ImmutableDictionary<TKey, TValue>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)

## Parameters

* [IEnumerable<KeyValuePair<TKey, TValue>>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6) source
## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> ToTrackedImmutableDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IEqualityComparer<TKey> keyComparer)
```

## Returns

[ImmutableDictionary<TKey, TValue>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)

## Parameters

* [IEnumerable<KeyValuePair<TKey, TValue>>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6) source
* [IEqualityComparer<TKey>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6) keyComparer
## Summary

```csharp
public static ImmutableDictionary<TKey, TValue> ToTrackedImmutableDictionary<TKey, TValue>(this IEnumerable<KeyValuePair<TKey, TValue>> source, IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
```

## Returns

[ImmutableDictionary<TKey, TValue>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)

## Parameters

* [IEnumerable<KeyValuePair<TKey, TValue>>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6) source
* [IEqualityComparer<TKey>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6) keyComparer
* [IEqualityComparer<TValue>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6) valueComparer
