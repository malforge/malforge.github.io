## Summary

```csharp
public IMyEntity CreateFromObjectBuilderParallel(MyObjectBuilder_EntityBase objectBuilder, bool addToScene, Action<IMyEntity> completionCallback)
```

Creates and asynchronously initializes and entity.

## Returns

[IMyEntity](VRage.ModAPI.IMyEntity)

Createentity. Entity would be inited correctly after callback trigger

## Parameters

* [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase) objectBuilder
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) addToScene
* [Action<IMyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) completionCallback
