## Summary

```csharp
public static Builder<TKey, TValue> CreateBuilder<TKey, TValue>()
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;.[Builder](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2+Builder?view=netframework-4.6)

## Summary

```csharp
public static Builder<TKey, TValue> CreateBuilder<TKey, TValue>(IEqualityComparer<TKey> keyComparer)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;.[Builder](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2+Builder?view=netframework-4.6)

## Parameters

* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TKey&gt; keyComparer
## Summary

```csharp
public static Builder<TKey, TValue> CreateBuilder<TKey, TValue>(IEqualityComparer<TKey> keyComparer, IEqualityComparer<TValue> valueComparer)
```

## Returns

[ImmutableDictionary](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2?view=netframework-4.6)&lt;TKey, TValue&gt;.[Builder](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableDictionary-2+Builder?view=netframework-4.6)

## Parameters

* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TKey&gt; keyComparer
* [IEqualityComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)&lt;TValue&gt; valueComparer
