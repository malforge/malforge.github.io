## Summary

```csharp
public static ImmutableArray<TResult> CreateRange<TSource, TArg, TResult>(ImmutableArray<TSource> items, Func<TSource, TArg, TResult> selector, TArg arg)
```

## Returns

[ImmutableArray<TResult>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)

## Parameters

* [ImmutableArray<TSource>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6) items
* [Func<TSource, TArg, TResult>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3?view=netframework-4.6) selector
* [TArg](VRage.Scripting.MemorySafeTypes.MemorySafeImmutableArray+TArg) arg
## Summary

```csharp
public static ImmutableArray<TResult> CreateRange<TSource, TArg, TResult>(ImmutableArray<TSource> items, int start, int length, Func<TSource, TArg, TResult> selector, TArg arg)
```

## Returns

[ImmutableArray<TResult>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)

## Parameters

* [ImmutableArray<TSource>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6) items
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) start
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
* [Func<TSource, TArg, TResult>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3?view=netframework-4.6) selector
* [TArg](VRage.Scripting.MemorySafeTypes.MemorySafeImmutableArray+TArg) arg
