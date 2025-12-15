**Assembly:** VRage.Library.dll

```csharp
public class MyGameTimer
```

Global thread-safe timer. Time for update and time for draw must be copied at the beginning of update and draw.

## Fields

|Member|Description|
|---|---|
|[static Frequency](VRage.Library.Utils.MyGameTimer@Frequency)|Number of ticks per seconds|

## Properties

|Member|Description|
|---|---|
|[Elapsed](VRage.Library.Utils.MyGameTimer@Elapsed)||
|[ElapsedTicks](VRage.Library.Utils.MyGameTimer@ElapsedTicks)||
|[ElapsedTimeSpan](VRage.Library.Utils.MyGameTimer@ElapsedTimeSpan)|This may not be accurate for large values - double accuracy|

## Constructors

|Member|Description|
|---|---|
|[MyGameTimer()](VRage.Library.Utils.MyGameTimer@.ctor)||

## Methods

|Member|Description|
|---|---|
|[AddElapsed(MyTimeSpan)](VRage.Library.Utils.MyGameTimer@AddElapsed)||

