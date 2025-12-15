**Assembly:** VRage.dll

```csharp
public class MySimpleProfiler
```

A simple performance profiler intended to show players information about which area of the game is slowing it down

## Fields

|Member|Description|
|---|---|
|[static ENABLE_SIMPLE_PROFILER](VRage.MySimpleProfiler@ENABLE_SIMPLE_PROFILER)||

## Events

|Member|Description|
|---|---|
|[static ShowPerformanceWarning](VRage.MySimpleProfiler@ShowPerformanceWarning)||

## Properties

|Member|Description|
|---|---|
|[static CurrentWarnings](VRage.MySimpleProfiler@CurrentWarnings)||

## Constructors

|Member|Description|
|---|---|
|[MySimpleProfiler()](VRage.MySimpleProfiler@.ctor)||

## Methods

|Member|Description|
|---|---|
|[static AttachTestingTool()](VRage.MySimpleProfiler@AttachTestingTool)||
|[static Begin(string, ProfilingBlockType, string)](VRage.MySimpleProfiler@Begin)||
|[static BeginBlock(string, ProfilingBlockType)](VRage.MySimpleProfiler@BeginBlock)||
|[static BeginGPUBlock(string)](VRage.MySimpleProfiler@BeginGPUBlock)|Set which GPU profiling block is going to receive timing next|
|[static Commit()](VRage.MySimpleProfiler@Commit)|Check performance and reset time|
|[static End(string)](VRage.MySimpleProfiler@End)|End profiling block|
|[static EndGPUBlock(MyTimeSpan)](VRage.MySimpleProfiler@EndGPUBlock)|Log timing of currently set GPU block|
|[static EndMemberPairingCheck(string)](VRage.MySimpleProfiler@EndMemberPairingCheck)||
|[static EndNoMemberPairingCheck()](VRage.MySimpleProfiler@EndNoMemberPairingCheck)||
|[static LogPerformanceTestResults()](VRage.MySimpleProfiler@LogPerformanceTestResults)||
|[static Reset(bool)](VRage.MySimpleProfiler@Reset)||
|[static SetBlockSettings(string, int, int, ProfilingBlockType)](VRage.MySimpleProfiler@SetBlockSettings)||
|[static ShowServerPerformanceWarning(string, ProfilingBlockType)](VRage.MySimpleProfiler@ShowServerPerformanceWarning)||

