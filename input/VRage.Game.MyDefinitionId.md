**Assembly:** VRage.Game.dll

```csharp
public struct MyDefinitionId: IEquatable<MyDefinitionId>
```

Prefer getting definition ID using object builder used to create the item. If you have automatic rifle, in its Init method create new MyDefinitionId using TypeId and SubtypeName of object builder. Do not write specific values in code, as data comes from XML and if those change, code needs to change as well.

## Fields

|Member|Description|
|---|---|
|[static Comparer](VRage.Game.MyDefinitionId@Comparer)||
|[SubtypeId](VRage.Game.MyDefinitionId@SubtypeId)||
|[TypeId](VRage.Game.MyDefinitionId@TypeId)||

## Properties

|Member|Description|
|---|---|
|[SubtypeName](VRage.Game.MyDefinitionId@SubtypeName)||

## Constructors

|Member|Description|
|---|---|
|[MyDefinitionId(MyObjectBuilderType)](VRage.Game.MyDefinitionId@.ctor)||
|[MyDefinitionId(MyObjectBuilderType, string)](VRage.Game.MyDefinitionId@.ctor)||
|[MyDefinitionId(MyObjectBuilderType, MyStringHash)](VRage.Game.MyDefinitionId@.ctor)||
|[MyDefinitionId(MyRuntimeObjectBuilderId, MyStringHash)](VRage.Game.MyDefinitionId@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static DropToStringCache()](VRage.Game.MyDefinitionId@DropToStringCache)||
|[static FromContent(MyObjectBuilder_Base)](VRage.Game.MyDefinitionId@FromContent)|Creates a new definition ID from a given content.|
|[static Parse(string)](VRage.Game.MyDefinitionId@Parse)|Attempts to create a definition ID from a definition string, which has the form (using ores as an example) "MyObjectBuilder_Ore/Iron". The first part must represent an existing type. If it does not, an exception will be thrown. The second (the subtype) is not enforced. See TryParse for a parsing method that does not throw an exception.|
|[static TryParse(string, out MyDefinitionId)](VRage.Game.MyDefinitionId@TryParse)|Attempts to create a definition ID from a definition string, which has the form (using ores as an example) "MyObjectBuilder_Ore/Iron". The first part must represent an existing type, while the second (the subtype) is not enforced.|
|[static TryParse(string, string, out MyDefinitionId)](VRage.Game.MyDefinitionId@TryParse)||
|[Equals(object)](VRage.Game.MyDefinitionId@Equals)||
|[Equals(MyDefinitionId)](VRage.Game.MyDefinitionId@Equals)||
|[GetHashCode()](VRage.Game.MyDefinitionId@GetHashCode)||
|[GetHashCodeLong()](VRage.Game.MyDefinitionId@GetHashCodeLong)|Safer hash code. It is unique in more situations than GetHashCode would be, but it may still require full check.|
|[ToString()](VRage.Game.MyDefinitionId@ToString)||

**Implements:**  
* [IEquatable<MyDefinitionId>](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

