## Summary

```csharp
public MyConcurrentPool(int defaultCapacity, Action<T> clear, int expectedAllocations, Func<T> activator, Action<T> deactivator)
```

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) defaultCapacity
* [Action<T>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) clear
* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) expectedAllocations
* [Func<T>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1?view=netframework-4.6) activator
* [Action<T>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) deactivator
