**Assembly:** VRage.Game.dll

```csharp
public struct MyIniValue
```

Represents the value of a single configuration item.

## Fields

|Member|Description|
|---|---|
|[static EMPTY](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@EMPTY)|Represents an empty [MyIniValue](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue) |
|[Key](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@Key)|Gets the [MyIniKey](VRage.Game.ModAPI.Ingame.Utilities.MyIniKey) this value was retrieved from|

## Properties

|Member|Description|
|---|---|
|[IsEmpty](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@IsEmpty)|Determines whether this value is empty. Be aware that an empty string is not considered to be an empty value.|

## Constructors

|Member|Description|
|---|---|
|[MyIniValue(MyIniKey, string)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@.ctor)||

## Methods

|Member|Description|
|---|---|
|[GetLines(List<string>)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@GetLines)|Retrieves each individual line of this value into the provided list.|
|[ToBoolean(bool)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToBoolean)|Attempts to get this value as a [bool](https://docs.microsoft.com/en-us/dotnet/api/system.boolean?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToByte(byte)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToByte)|Attempts to get this value as a [byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToChar(char)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToChar)|Attempts to get this value as a [char](https://docs.microsoft.com/en-us/dotnet/api/system.char?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToDecimal(decimal)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToDecimal)|Attempts to get this value as a [decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToDouble(double)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToDouble)|Attempts to get this value as a [double](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToInt16(short)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToInt16)|Attempts to get this value as a [short](https://docs.microsoft.com/en-us/dotnet/api/system.int16?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToInt32(int)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToInt32)|Attempts to get this value as a [int](https://docs.microsoft.com/en-us/dotnet/api/system.int32?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToInt64(long)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToInt64)|Attempts to get this value as a [long](https://docs.microsoft.com/en-us/dotnet/api/system.int64?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToSByte(sbyte)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToSByte)|Attempts to get this value as a [sbyte](https://docs.microsoft.com/en-us/dotnet/api/system.sbyte?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToSingle(float)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToSingle)|Attempts to get this value as a [float](https://docs.microsoft.com/en-us/dotnet/api/system.single?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToString()](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToString)|Attempts to get this value as a [string](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, an empty string will be returned instead.|
|[ToString(string)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToString)|Attempts to get this value as a [string](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToUInt16(ushort)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToUInt16)|Attempts to get this value as a [ushort](https://docs.microsoft.com/en-us/dotnet/api/system.uint16?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToUInt32(uint)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToUInt32)|Attempts to get this value as a [uint](https://docs.microsoft.com/en-us/dotnet/api/system.uint32?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[ToUInt64(ulong)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@ToUInt64)|Attempts to get this value as a [ulong](https://docs.microsoft.com/en-us/dotnet/api/system.uint64?view=netframework-4.6) . If the value is empty or cannot be understood as this data type, the defaultValue will be returned instead.|
|[TryGetBoolean(out bool)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetBoolean)|Attempts to get this value as a [bool](https://docs.microsoft.com/en-us/dotnet/api/system.boolean?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetByte(out byte)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetByte)|Attempts to get this value as a [byte](https://docs.microsoft.com/en-us/dotnet/api/system.byte?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetChar(out char)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetChar)|Attempts to get this value as a [char](https://docs.microsoft.com/en-us/dotnet/api/system.char?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetDecimal(out decimal)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetDecimal)|Attempts to get this value as a [decimal](https://docs.microsoft.com/en-us/dotnet/api/system.decimal?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetDouble(out double)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetDouble)|Attempts to get this value as a [double](https://docs.microsoft.com/en-us/dotnet/api/system.double?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetInt16(out short)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetInt16)|Attempts to get this value as a [short](https://docs.microsoft.com/en-us/dotnet/api/system.int16?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetInt32(out int)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetInt32)|Attempts to get this value as a [int](https://docs.microsoft.com/en-us/dotnet/api/system.int32?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetInt64(out long)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetInt64)|Attempts to get this value as a [long](https://docs.microsoft.com/en-us/dotnet/api/system.int64?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetSByte(out sbyte)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetSByte)|Attempts to get this value as a [sbyte](https://docs.microsoft.com/en-us/dotnet/api/system.sbyte?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetSingle(out float)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetSingle)|Attempts to get this value as a [float](https://docs.microsoft.com/en-us/dotnet/api/system.single?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetString(out string)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetString)|Attempts to get this value as a [string](https://docs.microsoft.com/en-us/dotnet/api/system.string?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetUInt16(out ushort)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetUInt16)|Attempts to get this value as a [ushort](https://docs.microsoft.com/en-us/dotnet/api/system.uint16?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetUInt32(out uint)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetUInt32)|Attempts to get this value as a [uint](https://docs.microsoft.com/en-us/dotnet/api/system.uint32?view=netframework-4.6) . Fills the`value`on success.|
|[TryGetUInt64(out ulong)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@TryGetUInt64)|Attempts to get this value as a [ulong](https://docs.microsoft.com/en-us/dotnet/api/system.uint64?view=netframework-4.6) . Fills the`value`on success.|
|[Write(StringBuilder)](VRage.Game.ModAPI.Ingame.Utilities.MyIniValue@Write)|Writes this value as a string to the given string builder.|

