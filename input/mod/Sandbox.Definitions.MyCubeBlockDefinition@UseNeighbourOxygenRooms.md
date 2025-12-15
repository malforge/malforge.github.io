## Summary

```csharp
public bool UseNeighbourOxygenRooms
```

Flag used by GridGasSystem to determine if this block should exclude from creating pressurize room. If true, this block cannot be pressurize room itself. This is only valid for blocks which are bigger than 1x1x1, because otherwise they are excluded automatically.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

