**Assembly:** VRage.Game.dll

```csharp
public struct MyIniParseResult
```

Represents the results of a configuration parsing.

## Fields

|Member|Description|
|---|---|
|[Error](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult@Error)|Gets a description of the error that occurred during parsing. Will be`null`if no error occurred.|

## Properties

|Member|Description|
|---|---|
|[IsDefined](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult@IsDefined)|Determines if the value of this result is defined, meaning whether the [Success](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult@Success) actually holds any meaning.|
|[LineNo](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult@LineNo)|Gets the line number where an error occured.|
|[Success](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult@Success)|Determines the success of the configuration parsing.|

## Methods

|Member|Description|
|---|---|
|[Equals(MyIniParseResult)](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult@Equals)|Compares this [MyIniParseResult](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult) with another.|
|[Equals(object)](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult@Equals)|Compares this [MyIniParseResult](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult) with another.|
|[GetHashCode()](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult@GetHashCode)|Gets the hash code for this [MyIniParseResult](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult) .|
|[ToString()](VRage.Game.ModAPI.Ingame.Utilities.MyIniParseResult@ToString)|Generates a generic error message in the form of`Line N: Error`|

