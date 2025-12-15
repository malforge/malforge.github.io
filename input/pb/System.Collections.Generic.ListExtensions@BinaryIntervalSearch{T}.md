## Summary

```csharp
public static int BinaryIntervalSearch<T>(this IList<T> self, T value, IComparer<T> comparer)
```

## Returns

[int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6)

## Parameters

* [IList<T>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netframework-4.6) self
* [T](System.Collections.Generic.ListExtensions+T) value
* [IComparer<T>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1?view=netframework-4.6) comparer
## Summary

```csharp
public static int BinaryIntervalSearch<T>(this IList<T> self, Func<T, bool> less)
```

## Returns

[int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6)

## Parameters

* [IList<T>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netframework-4.6) self
* [Func<T, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6) less
## Summary

```csharp
public static int BinaryIntervalSearch<T>(this IList<T> self, T value, Comparison<T> comparison)
```

## Returns

[int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6)

## Parameters

* [IList<T>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netframework-4.6) self
* [T](System.Collections.Generic.ListExtensions+T) value
* Comparison<T> <sub>prohibited</sub> comparison
