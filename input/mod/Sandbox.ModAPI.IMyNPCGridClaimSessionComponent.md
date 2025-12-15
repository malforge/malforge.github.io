**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyNPCGridClaimSessionComponent
```

Session for maintaining info about claims on npc grids

## Events

|Member|Description|
|---|---|
|[ClaimTimerResumed](Sandbox.ModAPI.IMyNPCGridClaimSessionComponent@ClaimTimerResumed)|When claim timer resumes on some grid, grid entity id in parameter during world load|
|[ClaimTimerStarted](Sandbox.ModAPI.IMyNPCGridClaimSessionComponent@ClaimTimerStarted)|When claim timer starts for the first time on some grid, grid entity id in parameter|
|[GridUnregistered](Sandbox.ModAPI.IMyNPCGridClaimSessionComponent@GridUnregistered)|When grid is unregistered, grid instance in parameter|

## Methods

|Member|Description|
|---|---|
|[GetFramesElapsed(long)](Sandbox.ModAPI.IMyNPCGridClaimSessionComponent@GetFramesElapsed)|Gets frame elapsed since countdown started|
|[GetTimeRemaining(long)](Sandbox.ModAPI.IMyNPCGridClaimSessionComponent@GetTimeRemaining)|Gets remaining time for that gridId|
|[RequestRegisterGrid(long)](Sandbox.ModAPI.IMyNPCGridClaimSessionComponent@RequestRegisterGrid)|Registers a npc grid as such|
|[RequestSetFramesElapsed(long, int?)](Sandbox.ModAPI.IMyNPCGridClaimSessionComponent@RequestSetFramesElapsed)|Sets frame elapsed since countdown started|
|[RequestUnregisterGrid(long)](Sandbox.ModAPI.IMyNPCGridClaimSessionComponent@RequestUnregisterGrid)|Registers a npc grid as such|

