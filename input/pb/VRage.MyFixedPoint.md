**Assembly:** VRage.Library.dll

```csharp
public struct MyFixedPoint: IXmlSerializable
```

Fixed point number represented as 64-bit integer with 6 decimal places (one millionts)

## Fields

|Member|Description|
|---|---|
|[static MaxIntValue](VRage.MyFixedPoint@MaxIntValue)||
|[static MaxValue](VRage.MyFixedPoint@MaxValue)||
|[static MinIntValue](VRage.MyFixedPoint@MinIntValue)||
|[static MinValue](VRage.MyFixedPoint@MinValue)||
|[static SmallestPossibleValue](VRage.MyFixedPoint@SmallestPossibleValue)||
|[static Zero](VRage.MyFixedPoint@Zero)||
|[RawValue](VRage.MyFixedPoint@RawValue)||

## Methods

|Member|Description|
|---|---|
|[static AddSafe(MyFixedPoint, MyFixedPoint)](VRage.MyFixedPoint@AddSafe)||
|[static Ceiling(MyFixedPoint)](VRage.MyFixedPoint@Ceiling)||
|[static DeserializeString(string)](VRage.MyFixedPoint@DeserializeString)||
|[static DeserializeStringSafe(string)](VRage.MyFixedPoint@DeserializeStringSafe)|For XmlSerialization, format is 123.456789 Handles double and decimal formats too.|
|[static Floor(MyFixedPoint)](VRage.MyFixedPoint@Floor)||
|[static IsIntegral(MyFixedPoint)](VRage.MyFixedPoint@IsIntegral)||
|[static Max(MyFixedPoint, MyFixedPoint)](VRage.MyFixedPoint@Max)||
|[static Min(MyFixedPoint, MyFixedPoint)](VRage.MyFixedPoint@Min)||
|[static MultiplySafe(MyFixedPoint, float)](VRage.MyFixedPoint@MultiplySafe)||
|[static MultiplySafe(MyFixedPoint, int)](VRage.MyFixedPoint@MultiplySafe)||
|[static MultiplySafe(float, MyFixedPoint)](VRage.MyFixedPoint@MultiplySafe)||
|[static MultiplySafe(int, MyFixedPoint)](VRage.MyFixedPoint@MultiplySafe)||
|[static MultiplySafe(MyFixedPoint, MyFixedPoint)](VRage.MyFixedPoint@MultiplySafe)||
|[static Round(MyFixedPoint)](VRage.MyFixedPoint@Round)||
|[Equals(object)](VRage.MyFixedPoint@Equals)||
|[GetHashCode()](VRage.MyFixedPoint@GetHashCode)||
|[SerializeString()](VRage.MyFixedPoint@SerializeString)|For XmlSerialization, format is 123.456789|
|[ToIntSafe()](VRage.MyFixedPoint@ToIntSafe)||
|[ToString()](VRage.MyFixedPoint@ToString)||

**Implements:**  
* IXmlSerializable <sub>prohibited</sub>

