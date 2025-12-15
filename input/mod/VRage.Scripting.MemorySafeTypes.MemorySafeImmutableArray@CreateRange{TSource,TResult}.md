## Summary

```csharp
public static ImmutableArray<TResult> CreateRange<TSource, TResult>(ImmutableArray<TSource> items, Func<TSource, TResult> selector)
```

## Returns

[ImmutableArray<TResult>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)

## Parameters

* [ImmutableArray<TSource>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6) items
* [Func<TSource, TResult>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) selector
## Summary

```csharp
public static ImmutableArray<TResult> CreateRange<TSource, TResult>(ImmutableArray<TSource> items, int start, int length, Func<TSource, TResult> selector)
```

## Returns

[ImmutableArray<TResult>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)

## Parameters

* [ImmutableArray<TSource>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6) items
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) start
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
* [Func<TSource, TResult>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) selector
