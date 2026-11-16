**Assembly:** Sandbox.Game.dll

```csharp
public class MyFlightStallWatchdog
```

Tells a flight that still closes on its target from one pinned against geometry: fires once the distance to the target has not dropped by the minimum progress for the stall time. Progress, not displacement, so a bot sliding along a hull does not count as moving.

## Constructors

|Member|Description|
|---|---|
|[MyFlightStallWatchdog()](Sandbox.Game.EntityComponents.MyFlightStallWatchdog@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Reset(int)](Sandbox.Game.EntityComponents.MyFlightStallWatchdog@Reset)||
|[Update(double, int, float, float)](Sandbox.Game.EntityComponents.MyFlightStallWatchdog@Update)|True while the flight is stalled. A non-positivestallTimeSecdisables the watchdog.|

