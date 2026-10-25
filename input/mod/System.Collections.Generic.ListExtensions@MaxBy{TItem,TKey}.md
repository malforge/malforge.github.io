## Summary

```csharp
public static TItem MaxBy<TItem, TKey>(this IEnumerable<TItem> source, Func<TItem, TKey> selector, IComparer<TKey> comparer)
```

## Returns

TItem

## Parameters

* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)&lt;TItem&gt; source
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-2?view=netframework-4.6)&lt;TItem, TKey&gt; selector
* [IComparer](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IComparer-1?view=netframework-4.6)&lt;TKey&gt; comparer
