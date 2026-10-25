## Summary

```csharp
public static ImmutableArray<TResult> CreateRange<TSource, TResult>(ImmutableArray<TSource> items, Func<TSource, TResult> selector)
```

## Returns

[ImmutableArray](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)&lt;TResult&gt;

## Parameters

* [ImmutableArray](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)&lt;TSource&gt; items
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TResult&gt; selector
## Summary

```csharp
public static ImmutableArray<TResult> CreateRange<TSource, TResult>(ImmutableArray<TSource> items, int start, int length, Func<TSource, TResult> selector)
```

## Returns

[ImmutableArray](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)&lt;TResult&gt;

## Parameters

* [ImmutableArray](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)&lt;TSource&gt; items
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) start
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TSource, TResult&gt; selector
