**Assembly:** VRage.Game.dll

```csharp
public struct MyIniKey: IEquatable<MyIniKey>
```

Represents the combination of a section and a key in a [MyIni](VRage.Game.ModAPI.Ingame.Utilities.MyIni) structure.

## Fields

|Member|Description|
|---|---|
|[static EMPTY](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey@EMPTY)||

## Properties

|Member|Description|
|---|---|
|[IsEmpty](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey@IsEmpty)|Determines whether this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) is empty.|
|[Name](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey@Name)|Gets the Key part of this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) |
|[Section](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey@Section)|Gets the Section part of this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) |

## Constructors

|Member|Description|
|---|---|
|[MyIniKey(string, string)](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static Parse(string)](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey@Parse)|Parses a string in the form of`section/key`into a [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) object.|
|[static TryParse(string, out MyIniKey)](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey@TryParse)|Parses a string in the form of`section/key`into a [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) object.|
|[Equals(MyIniKey)](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey@Equals)|Compares this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) with another. Note that this is equality in the sense of a configuration key, which means the comparison is implicitly case insensitive.|
|[Equals(object)](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey@Equals)|Compares this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) with another. Note that this is equality in the sense of a configuration key, which means the comparison is implicitly case insensitive.|
|[GetHashCode()](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey@GetHashCode)|Gets the hash code representing this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) |
|[ToString()](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey@ToString)|Generates a string representing this [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) in the form of`section/key`.|

**Implements:**  
* [IEquatable<MyIniKey>](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

