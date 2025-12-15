## Summary

```csharp
public IReadOnlyDictionary<Guid, string> Storage { get; }
```

Store custom mod data here. Use a GUID unique to your mod. Use only system types, not custom types in mod script or game.

## Returns

[IReadOnlyDictionary<Guid, string>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IReadOnlyDictionary-2?view=netframework-4.6)

## Remarks

This is not synced. Caution, this contains data formods. It is recommended to use the appropriate methods instead (GetValue, TryGetValue, SetValue, RemoveValue).

