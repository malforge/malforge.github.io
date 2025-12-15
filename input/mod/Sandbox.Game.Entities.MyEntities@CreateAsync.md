## Summary

```csharp
public static void CreateAsync(MyObjectBuilder_EntityBase objectBuilder, bool addToScene, Action<MyEntity> doneHandler)
```

Creates object asynchronously and adds it into scene. DoneHandler is invoked from update thread when the object is added into scene.

## Parameters

* [MyObjectBuilder_EntityBase](VRage.ObjectBuilders.MyObjectBuilder_EntityBase) objectBuilder
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) addToScene
* [Action<MyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) doneHandler
