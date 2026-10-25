## Summary

```csharp
public static int BinaryIntervalSearch<T>(this IList<T> self, T value, IComparer<T> comparer)
```

## Returns

[int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6)

## Parameters

* [IList](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netframework-4.6)&lt;T&gt; self
* T value
* [IComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1?view=netframework-4.6)&lt;T&gt; comparer
## Summary

```csharp
public static int BinaryIntervalSearch<T>(this IList<T> self, Func<T, bool> less)
```

## Returns

[int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6)

## Parameters

* [IList](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netframework-4.6)&lt;T&gt; self
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;T, [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt; less
## Summary

```csharp
public static int BinaryIntervalSearch<T>(this IList<T> self, T value, Comparison<T> comparison)
```

## Returns

[int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6)

## Parameters

* [IList](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netframework-4.6)&lt;T&gt; self
* T value
* Comparison&lt;T&gt; <sub>prohibited</sub> comparison
