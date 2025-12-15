**Assembly:** VRage.Library.dll

```csharp
public class MyIntervalList
```

A set of integer numbers optimized for sets with long consecutive runs. Each interval is stored as two values in m_list: the lower and the upper bound.  
  
For example, the set of numbers 2, 3, 4, 5, 7, 9, 10, 11, 12, 13 (or alternatively in the interval notation <2, 5> U <7, 7> U <9, 13>) is saved as a list { 2, 5, 7, 7, 9, 13 }

## Properties

|Member|Description|
|---|---|
|[Count](VRage.Collections.MyIntervalList@Count)||
|[IntervalCount](VRage.Collections.MyIntervalList@IntervalCount)||
|[Item](VRage.Collections.MyIntervalList@Item)||

## Constructors

|Member|Description|
|---|---|
|[MyIntervalList()](VRage.Collections.MyIntervalList@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Add(int)](VRage.Collections.MyIntervalList@Add)|Add a value to the list|
|[Clear()](VRage.Collections.MyIntervalList@Clear)||
|[Contains(int)](VRage.Collections.MyIntervalList@Contains)||
|[GetCopy()](VRage.Collections.MyIntervalList@GetCopy)||
|[GetEnumerator()](VRage.Collections.MyIntervalList@GetEnumerator)||
|[IndexOf(int)](VRage.Collections.MyIntervalList@IndexOf)||
|[ToString()](VRage.Collections.MyIntervalList@ToString)||

