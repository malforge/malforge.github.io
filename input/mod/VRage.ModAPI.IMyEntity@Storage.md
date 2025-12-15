## Summary

```csharp
public MyModStorageComponentBase Storage { get; set; }
```

Custom storage for mods. Shared with all mods.

## Returns

[MyModStorageComponentBase](VRage.Game.Components.MyModStorageComponentBase)

## Remarks

Not synced, but saved with blueprints. Only use set accessor if value is null.```csharp  
Entity.Storage = new MyModStorageComponent();  
  
```

