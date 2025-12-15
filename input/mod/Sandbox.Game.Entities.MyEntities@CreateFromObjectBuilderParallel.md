## Summary

```csharp
public static MyEntity CreateFromObjectBuilderParallel(MyObjectBuilder_EntityBase objectBuilder, bool addToScene, Action<MyEntity> completionCallback, MyEntity entity, MyEntity relativeSpawner, Vector3D? relativeOffset, bool checkPosition, bool fadeIn)
```

Create and asynchronously initialize and entity.

## Returns

[MyEntity](VRage.Game.Entity.MyEntity)



## Parameters

* [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase) objectBuilder
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) addToScene
* [Action<MyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) completionCallback
* [MyEntity](VRage.Game.Entity.MyEntity) entity
* [MyEntity](VRage.Game.Entity.MyEntity) relativeSpawner
* [Vector3D?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) relativeOffset
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) checkPosition
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) fadeIn
