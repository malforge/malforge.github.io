## Summary

```csharp
public virtual MyObjectBuilder_PhysicalObject GetInstanceOnStackSplit()
```

Since 204 items like gas containers can stack. All items that has data, that can change should override this method, and return a clone.

## Returns

[MyObjectBuilder_PhysicalObject](VRage.Game.MyObjectBuilder_PhysicalObject)

This or clone of this object

