## Summary

```csharp
public virtual void Remap(IMyRemapHelper remapHelper)
```

Remaps this entity's entityId to a new value. If there are cross-referenced between different entities in this object builder, the remapHelper should be used to rememeber these references and retrieve them.

## Parameters

* [IMyRemapHelper](VRage.ModAPI.IMyRemapHelper) remapHelper
