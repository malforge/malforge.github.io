**Assembly:** VRage.Library.dll

```csharp
public class WaitForTargetFrameRate
```

## Fields

|Member|Description|
|---|---|
|[static ENABLE_TIMING_HOTFIX](VRage.Library.Utils.WaitForTargetFrameRate@ENABLE_TIMING_HOTFIX)||
|[EnableMaxSpeed](VRage.Library.Utils.WaitForTargetFrameRate@EnableMaxSpeed)||

## Properties

|Member|Description|
|---|---|
|[TargetFrequency](VRage.Library.Utils.WaitForTargetFrameRate@TargetFrequency)|Frames per second this waiter paces to. Settable at runtime; the accumulated target is rebased on the current tick, without which the first frame after a change is stretched or skipped by the ratio of the old period to the new one.|
|[TickPerFrame](VRage.Library.Utils.WaitForTargetFrameRate@TickPerFrame)||

## Constructors

|Member|Description|
|---|---|
|[WaitForTargetFrameRate(MyGameTimer, float)](VRage.Library.Utils.WaitForTargetFrameRate@.ctor)||

## Methods

|Member|Description|
|---|---|
|[SetNextFrameDelayDelta(float)](VRage.Library.Utils.WaitForTargetFrameRate@SetNextFrameDelayDelta)||
|[Wait()](VRage.Library.Utils.WaitForTargetFrameRate@Wait)||

