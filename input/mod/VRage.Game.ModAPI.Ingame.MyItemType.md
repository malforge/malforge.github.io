**Assembly:** VRage.Game.dll

```csharp
public struct MyItemType: IComparable<MyItemType>, IEquatable<MyItemType>
```

Use by [MyInventoryItem](VRage.Game.ModAPI.Ingame.MyInventoryItem) 

## Properties

|Member|Description|
|---|---|
|[SubtypeId](VRage.Game.ModAPI.Ingame.MyItemType@SubtypeId)|Gets Subtype of Item|
|[TypeId](VRage.Game.ModAPI.Ingame.MyItemType@TypeId)|Gets TypeId of Item|

## Constructors

|Member|Description|
|---|---|
|[MyItemType(string, string)](VRage.Game.ModAPI.Ingame.MyItemType@.ctor)||
|[MyItemType(MyObjectBuilderType, MyStringHash)](VRage.Game.ModAPI.Ingame.MyItemType@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static MakeAmmo(string)](VRage.Game.ModAPI.Ingame.MyItemType@MakeAmmo)||
|[static MakeComponent(string)](VRage.Game.ModAPI.Ingame.MyItemType@MakeComponent)||
|[static MakeIngot(string)](VRage.Game.ModAPI.Ingame.MyItemType@MakeIngot)||
|[static MakeOre(string)](VRage.Game.ModAPI.Ingame.MyItemType@MakeOre)||
|[static MakeTool(string)](VRage.Game.ModAPI.Ingame.MyItemType@MakeTool)||
|[static Parse(string)](VRage.Game.ModAPI.Ingame.MyItemType@Parse)||
|[CompareTo(MyItemType)](VRage.Game.ModAPI.Ingame.MyItemType@CompareTo)||
|[Equals(MyItemType)](VRage.Game.ModAPI.Ingame.MyItemType@Equals)||
|[Equals(object)](VRage.Game.ModAPI.Ingame.MyItemType@Equals)||
|[GetHashCode()](VRage.Game.ModAPI.Ingame.MyItemType@GetHashCode)||
|[ToString()](VRage.Game.ModAPI.Ingame.MyItemType@ToString)||

**Implements:**  
* [IComparable<MyItemType>](https://docs.microsoft.com/en-us/dotnet/api/System.IComparable-1?view=netframework-4.6)  
* [IEquatable<MyItemType>](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)

