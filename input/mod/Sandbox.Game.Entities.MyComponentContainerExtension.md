**Assembly:** Sandbox.Game.dll

```csharp
public abstract sealed class MyComponentContainerExtension
```

TODO: This should be later ideally some factory rather than just an extension on the MyComponentContainer

## Methods

|Member|Description|
|---|---|
|[static FindComponentBuilder(DefaultComponent, MyObjectBuilder_ComponentContainer)](Sandbox.Game.Entities.MyComponentContainerExtension@FindComponentBuilder)||
|[static InitComponents(this IMyComponentContainer, MyObjectBuilderType, MyStringHash, MyObjectBuilder_ComponentContainer)](Sandbox.Game.Entities.MyComponentContainerExtension@InitComponents)|Tries to retrieve entity definition of the entity owning this container, check if the definition has some DefaultComponents, tries to retrieve these components definitions, create these components instances and add them TODO: This should be ideally a behavior of the MyEntityComponentContainer when it is initialized (deserialized).. or by the factory, for now, this is an extension method|
|[static TryAddComponent(long, MyDefinitionId)](Sandbox.Game.Entities.MyComponentContainerExtension@TryAddComponent)|This will look for the component definition and if found, it will create its instance and add to the entity with the give id|
|[static TryAddComponent(long, string, string)](Sandbox.Game.Entities.MyComponentContainerExtension@TryAddComponent)|This will try to parse strings to types and create an instance of the component type. Don't use this in retail code, use for debug, modding etc.|
|[static TryGetComponentDefinition(MyObjectBuilderType, MyStringHash, out MyComponentDefinitionBase)](Sandbox.Game.Entities.MyComponentContainerExtension@TryGetComponentDefinition)||
|[static TryGetContainerDefinition(MyObjectBuilderType, MyStringHash, out MyContainerDefinition)](Sandbox.Game.Entities.MyComponentContainerExtension@TryGetContainerDefinition)||
|[static TryGetEntityComponentTypes(long, out List<Type>)](Sandbox.Game.Entities.MyComponentContainerExtension@TryGetEntityComponentTypes)|This will retrieve component types in the entity container. This method allocates, use only for debugging etc.|
|[static TryRemoveComponent(long, Type)](Sandbox.Game.Entities.MyComponentContainerExtension@TryRemoveComponent)||

