## Summary

```csharp
public Action<IMyEntity, bool> DetectorColliderCallback
```

If it is not null, then it would be call this callback each time entity Enters/Leaves it's collision. Also removes physical collision (Now all entities can go through it) CollisionCallback is called from parallel thread, and called once per HkBody. Grids can have more than 100 bodies. Try find best collision layer, to filter unneeded collisions and improve performance If you trying detect grids:```csharp  
protected MyConcurrentHashSet<long> m_containedEntities = new MyConcurrentHashSet<long>();  
var topEntity = entity.GetTopMostParent() as MyEntity;  
if (m_containedEntities.Add(topEntity.EntityId))  
{  
    MyAPIGateway.Utilities.InvokeOnGameThread(() =>  
    {  
        //Called once in main thread  
    });  
}  
  
```

## Returns

[Action<IMyEntity, bool>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6)

