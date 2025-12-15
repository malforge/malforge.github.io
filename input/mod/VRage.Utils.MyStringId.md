**Assembly:** VRage.Library.dll

```csharp
public struct MyStringId: IXmlSerializable
```

Generates unique IDs for strings. When used as key for hash tables (Dictionary or HashSet) always pass in MyStringId.Comparer, otherwise lookups will allocate memory! Never serialize to network or disk! IDs are created sequentially as they get requested so two IDs might be different between sessions or clients and server. You can safely use ToString() as it will not allocate.

## Fields

|Member|Description|
|---|---|
|[static Comparer](VRage.Utils.MyStringId@Comparer)||
|[static NullOrEmpty](VRage.Utils.MyStringId@NullOrEmpty)||
|[m_id](VRage.Utils.MyStringId@m_id)||

## Properties

|Member|Description|
|---|---|
|[Id](VRage.Utils.MyStringId@Id)||
|[String](VRage.Utils.MyStringId@String)||

## Methods

|Member|Description|
|---|---|
|[static Get(string)](VRage.Utils.MyStringId@Get)||
|[static GetOrCompute(string)](VRage.Utils.MyStringId@GetOrCompute)||
|[static IsKnown(MyStringId)](VRage.Utils.MyStringId@IsKnown)||
|[static TryGet(string, out MyStringId)](VRage.Utils.MyStringId@TryGet)||
|[static TryGet(string)](VRage.Utils.MyStringId@TryGet)||
|[Equals(object)](VRage.Utils.MyStringId@Equals)||
|[Equals(MyStringId)](VRage.Utils.MyStringId@Equals)||
|[GetHashCode()](VRage.Utils.MyStringId@GetHashCode)||
|[GetSchema()](VRage.Utils.MyStringId@GetSchema)||
|[ReadXml(XmlReader)](VRage.Utils.MyStringId@ReadXml)||
|[ToString()](VRage.Utils.MyStringId@ToString)||
|[WriteXml(XmlWriter)](VRage.Utils.MyStringId@WriteXml)||

**Implements:**  
* IXmlSerializable <sub>prohibited</sub>

