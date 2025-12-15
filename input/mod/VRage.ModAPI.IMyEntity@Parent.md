## Summary

```csharp
public IMyEntity Parent { get; }
```

Gets parent of entity or null, if this entity doesn't have parent. Ex: character sitting in cockpit, has parent - cockpit, cockpit has parent - cube grid, connected grids also has main grid, which would be parent for other grids.

## Returns

[IMyEntity](VRage.ModAPI.IMyEntity)

