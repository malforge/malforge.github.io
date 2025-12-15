## Summary

```csharp
public static void InitComponents(this IMyComponentContainer container, MyObjectBuilderType type, MyStringHash subtypeName, MyObjectBuilder_ComponentContainer builder)
```

Tries to retrieve entity definition of the entity owning this container, check if the definition has some DefaultComponents, tries to retrieve these components definitions, create these components instances and add them TODO: This should be ideally a behavior of the MyEntityComponentContainer when it is initialized (deserialized).. or by the factory, for now, this is an extension method

## Parameters

* [IMyComponentContainer](VRage.Game.Components.Interfaces.IMyComponentContainer) container
* [MyObjectBuilderType](VRage.ObjectBuilders.MyObjectBuilderType) type
* [MyStringHash](VRage.Utils.MyStringHash) subtypeName
* [MyObjectBuilder_ComponentContainer](VRage.Game.ObjectBuilders.ComponentSystem.MyObjectBuilder_ComponentContainer) builder
