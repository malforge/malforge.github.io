**Assembly:** VRage.Game.dll

```csharp
public class MyDefinitionManagerSimple: MyDefinitionManagerBase
```

Simple definition manager class that allows loading of definitions from files and support type overrides (e.g. for loading subset of EnvironmentDefinition)

## Fields

|Member|Description|
|---|---|
|[static Static](VRage.Game.MyDefinitionManagerBase@Static)|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|

## Properties

|Member|Description|
|---|---|
|[Definitions](VRage.Game.MyDefinitionManagerBase@Definitions)|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|

## Constructors

|Member|Description|
|---|---|
|[MyDefinitionManagerSimple()](VRage.Game.MyDefinitionManagerSimple@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static GetObjectBuilderType(Type)](VRage.Game.MyDefinitionManagerBase@GetObjectBuilderType)|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[static GetObjectFactory()](VRage.Game.MyDefinitionManagerBase@GetObjectFactory)|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[static GetPostProcessor(Type)](VRage.Game.MyDefinitionManagerBase@GetPostProcessor)|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[static RegisterTypesFromAssembly(Assembly)](VRage.Game.MyDefinitionManagerBase@RegisterTypesFromAssembly)|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[AddDefinitionOverride(Type, string)](VRage.Game.MyDefinitionManagerSimple@AddDefinitionOverride)||
|[GetLoadingSet()](VRage.Game.MyDefinitionManagerSimple@GetLoadingSet)||
|[LoadDefinitions(string)](VRage.Game.MyDefinitionManagerSimple@LoadDefinitions)||
|[TryGetComponentDefinition(MyObjectBuilderType, MyStringHash, out MyComponentDefinitionBase)](VRage.Game.MyDefinitionManagerSimple@TryGetComponentDefinition)||
|[TryGetContainerDefinition(MyObjectBuilderType, MyStringHash, out MyContainerDefinition)](VRage.Game.MyDefinitionManagerSimple@TryGetContainerDefinition)||
|[GetAllDefinitions<T>()](VRage.Game.MyDefinitionManagerBase@GetAllDefinitions{T})|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[GetDefinition<T>(string)](VRage.Game.MyDefinitionManagerBase@GetDefinition{T})|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[GetDefinition<T>(MyStringHash)](VRage.Game.MyDefinitionManagerBase@GetDefinition{T})|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[GetDefinition<T>(MyDefinitionId)](VRage.Game.MyDefinitionManagerBase@GetDefinition{T})|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[GetDefinitions<T>()](VRage.Game.MyDefinitionManagerBase@GetDefinitions{T})|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[GetLoadingSet()](VRage.Game.MyDefinitionManagerBase@GetLoadingSet)|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[GetSubtypes<T>()](VRage.Game.MyDefinitionManagerBase@GetSubtypes{T})|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[TryGetComponentDefinition(MyObjectBuilderType, MyStringHash, out MyComponentDefinitionBase)](VRage.Game.MyDefinitionManagerBase@TryGetComponentDefinition)|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[TryGetContainerDefinition(MyObjectBuilderType, MyStringHash, out MyContainerDefinition)](VRage.Game.MyDefinitionManagerBase@TryGetContainerDefinition)|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|
|[TryGetDefinition<T>(MyStringHash, out T)](VRage.Game.MyDefinitionManagerBase@TryGetDefinition{T})|_Inherited from [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)_|

**Inheritance:**   [MyDefinitionManagerBase](VRage.Game.MyDefinitionManagerBase)

