**Assembly:** VRage.dll

```csharp
public struct MyStringHash: IEquatable<MyStringHash>, IXmlSerializable
```

Generates string hashes deterministically and crashes on collisions. When used as key for hash tables (Dictionary or HashSet) always pass in MyStringHash.Comparer, otherwise lookups will allocate memory! Can be safely used in network but never serialize to disk! IDs are computed as hash from string so there is a risk of collisions. Use only when MyStringId is not sufficient (eg. sending over network). Because the odds of collision get higher the more hashes are in use, do not use this for generated strings and make sure hashes are computed deterministically (eg. at startup) and don't require lengthy gameplay. This way we know about any collision early and not from rare and random crash reports.

## Fields

|Member|Description|
|---|---|
|[static Comparer](VRage.Utils.MyStringHash@Comparer)||
|[static NullOrEmpty](VRage.Utils.MyStringHash@NullOrEmpty)||
|[m_hash](VRage.Utils.MyStringHash@m_hash)||

## Properties

|Member|Description|
|---|---|
|[String](VRage.Utils.MyStringHash@String)||

## Methods

|Member|Description|
|---|---|
|[static Get(string)](VRage.Utils.MyStringHash@Get)||
|[static GetOrCompute(string)](VRage.Utils.MyStringHash@GetOrCompute)||
|[static IsKnown(MyStringHash)](VRage.Utils.MyStringHash@IsKnown)||
|[static TryGet(string, out MyStringHash)](VRage.Utils.MyStringHash@TryGet)||
|[static TryGet(string)](VRage.Utils.MyStringHash@TryGet)||
|[static TryGet(int)](VRage.Utils.MyStringHash@TryGet)|Think HARD before using this. Usually you should be able to use MyStringHash as it is without conversion to int.|
|[Equals(object)](VRage.Utils.MyStringHash@Equals)||
|[Equals(MyStringHash)](VRage.Utils.MyStringHash@Equals)||
|[GetHashCode()](VRage.Utils.MyStringHash@GetHashCode)||
|[GetSchema()](VRage.Utils.MyStringHash@GetSchema)||
|[ReadXml(XmlReader)](VRage.Utils.MyStringHash@ReadXml)||
|[ToString()](VRage.Utils.MyStringHash@ToString)||
|[WriteXml(XmlWriter)](VRage.Utils.MyStringHash@WriteXml)||

**Implements:**  
* [IEquatable<MyStringHash>](https://docs.microsoft.com/en-us/dotnet/api/System.IEquatable-1?view=netframework-4.6)  
* IXmlSerializable <sub>prohibited</sub>

