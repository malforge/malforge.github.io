## Summary

```csharp
public static bool TryGetEntityComponentTypes(long entityId, out List<Type> components)
```

This will retrieve component types in the entity container. This method allocates, use only for debugging etc.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

true if success

## Parameters

* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) entityId
* [List<Type>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.List-1?view=netframework-4.6) components
