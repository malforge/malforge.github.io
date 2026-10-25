## Summary

```csharp
public static ImmutableArray<TResult> CreateRange<TSource, TArg, TResult>(ImmutableArray<TSource> items, Func<TSource, TArg, TResult> selector, TArg arg)
```

## Returns

[ImmutableArray](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)&lt;TResult&gt;

## Parameters

* [ImmutableArray](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)&lt;TSource&gt; items
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3?view=netframework-4.6)&lt;TSource, TArg, TResult&gt; selector
* TArg arg
## Summary

```csharp
public static ImmutableArray<TResult> CreateRange<TSource, TArg, TResult>(ImmutableArray<TSource> items, int start, int length, Func<TSource, TArg, TResult> selector, TArg arg)
```

## Returns

[ImmutableArray](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)&lt;TResult&gt;

## Parameters

* [ImmutableArray](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Immutable.ImmutableArray-1?view=netframework-4.6)&lt;TSource&gt; items
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) start
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) length
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3?view=netframework-4.6)&lt;TSource, TArg, TResult&gt; selector
* TArg arg
