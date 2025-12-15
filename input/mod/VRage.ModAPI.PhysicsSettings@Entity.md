## Summary

```csharp
public IMyEntity Entity
```

For modders: You can create your own entities with this code.```csharp  
var entity = new MyEntity();  
entity.WorldMatrix = MatrixD.Identity;  
entity.Init(new StringBuilder("Name"), "Models\\Cubes\\Large\\GeneratorLarge.mwm", null, null, "Models\\Cubes\\Large\\GeneratorLarge.mwm");  
MyAPIGateway.Entities.AddEntity(entity);  
  
```

## Returns

[IMyEntity](VRage.ModAPI.IMyEntity)

