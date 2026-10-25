## Summary

```csharp
public MyConcurrentPool(int defaultCapacity, Action<T> clear, int expectedAllocations, Func<T> activator, Action<T> deactivator)
```

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) defaultCapacity
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6)&lt;T&gt; clear
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) expectedAllocations
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1?view=netframework-4.6)&lt;T&gt; activator
* [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6)&lt;T&gt; deactivator
