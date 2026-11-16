**Assembly:** VRage.Library.dll

```csharp
public abstract sealed class MyCompilationSymbols
```

## Fields

|Member|Description|
|---|---|
|[static AftermathEnabled](VRage.MyCompilationSymbols@AftermathEnabled)||
|[static CreateRefenceDevice](VRage.MyCompilationSymbols@CreateRefenceDevice)||
|[static DX11Debug](VRage.MyCompilationSymbols@DX11Debug)||
|[static DX11DebugOutput](VRage.MyCompilationSymbols@DX11DebugOutput)||
|[static DX11DebugOutputEnableInfo](VRage.MyCompilationSymbols@DX11DebugOutputEnableInfo)||
|[static DX11DebugSymbol](VRage.MyCompilationSymbols@DX11DebugSymbol)||
|[static DX11ForceStereo](VRage.MyCompilationSymbols@DX11ForceStereo)||
|[static DX11LogOutput](VRage.MyCompilationSymbols@DX11LogOutput)||
|[static DX12DebugLayer](VRage.MyCompilationSymbols@DX12DebugLayer)|D3D12 debug layer (DX12 backend bring-up). Costs real frame time — validation runs on every API call and every stored message is marshalled out in`DrainDebugMessages`— so turn it off when measuring frame time and back on when bringing up a new pass family. Must be set before device creation to have any effect.|
|[static DX12DetectCrossFrameWrites](VRage.MyCompilationSymbols@DX12DetectCrossFrameWrites)|Diagnostic: report every CPU write to a buffer the GPU may still be reading — a write whose target was last bound by a frame the GPU has not finished. Unlike the discard-map tally this covers all write paths and reports the race actually happening rather than the buffer merely being at risk, and unlike [DX12SerializeFrames](VRage.MyCompilationSymbols@DX12SerializeFrames) it does not perturb timing, so it can catch an artifact that only appears at full speed. Never ship it on.|
|[static DX12DetectDirectDiscardMaps](VRage.MyCompilationSymbols@DX12DetectDirectDiscardMaps)|Diagnostic: report a buffer`WriteDiscard`-mapped more than once in a frame on the path where discard renaming does not apply, where the second map overwrites what the draws recorded after the first still read. The only detector for that corruption — [DX12DetectCrossFrameWrites](VRage.MyCompilationSymbols@DX12DetectCrossFrameWrites) sees the cross-frame race instead. Turn it off when profiling/release: the tally takes a backend-wide lock on every such map, and the recording threads map in parallel.|
|[static DX12DirectStorage](VRage.MyCompilationSymbols@DX12DirectStorage)|DirectStorage file-to-GPU texture uploads. Cleared by the`-nodirectstorage`command line switch, which also keeps`dstorage.dll`from being loaded at all — the escape hatch for when the runtime itself is suspect. Must be set before device creation to stop the uploader from being created; flipping it later only steers subsequent loads back onto the CPU path.|
|[static DX12DStorageSmokeTest](VRage.MyCompilationSymbols@DX12DStorageSmokeTest)|Debug-only DirectStorage interop smoke test: right after D3D12 device creation, DStorage-read one content DDS into memory and byte-compare against File.ReadAllBytes, logging [DStorage] PASSED/FAILED. Proves the whole interop layer (factory, file, queue, request struct layout, status array, fence signal) with no renderer integration. Compiled out of Release entirely.|
|[static DX12GpuValidation](VRage.MyCompilationSymbols@DX12GpuValidation)|D3D12 GPU-based validation. Instruments the shaders, so out-of-bounds descriptor-table reads, uninitialised descriptors and wrong resource states are named in the log instead of surfacing as a bare`DXGI_ERROR_DEVICE_HUNG`. Drastically slower — turn on only to diagnose a GPU fault, and expect the slowdown itself to change frame timings. Requires [DX12DebugLayer](VRage.MyCompilationSymbols@DX12DebugLayer) ; must be set before device creation.|
|[static DX12MarkFrameRequested](VRage.MyCompilationSymbols@DX12MarkFrameRequested)|One-shot request (Ctrl+Shift+M) to stamp the render log with the current frame number and per-frame counters, so a visually-spotted artifact can be located in continuously-running traces. Set from the game thread, cleared by the render thread when it services it.|
|[static DX12MeasureMaterialBinds](VRage.MyCompilationSymbols@DX12MeasureMaterialBinds)|Measurement scaffold for the bindless-material plan: splits per-draw material SRV binds by binding pipeline and by merge-instancing, tracks the distinct material descriptors a session needs, and times the ring staging. See`MyMaterialBindStats`. Costs a timestamp pair per staged block plus a hash insert per material descriptor, so the timing it reports is very slightly inflated by its own measurement — turn it off before quoting absolute frame times. Temporary; remove with the scaffold.|
|[static DX12SerializeFrames](VRage.MyCompilationSymbols@DX12SerializeFrames)|Diagnostic: block in`Present`until the GPU has finished the whole frame, removing all CPU/GPU overlap while leaving parallel recording intact. Discriminates a cross-frame write-under-read (a buffer rewritten by frame N+1 while frame N's draws still read it) from a recording race — the former disappears here, the latter does not. Halves throughput; never ship it on.|
|[static DX12VramReport](VRage.MyCompilationSymbols@DX12VramReport)|Diagnostic: log the per-second VRAM breakdown (file textures, buffer pools, unaccounted). Off by default because each line walks every registered texture and pool on the render thread and adds ~350 lines per five minutes of log. Peaks, the sampler thread and the over-budget warning stay on regardless.|
|[static EnableAnalytics](VRage.MyCompilationSymbols@EnableAnalytics)||
|[static EnableNetworkClientUpdateTracking](VRage.MyCompilationSymbols@EnableNetworkClientUpdateTracking)||
|[static EnableNetworkPacketTracking](VRage.MyCompilationSymbols@EnableNetworkPacketTracking)||
|[static EnableNetworkPositionTracking](VRage.MyCompilationSymbols@EnableNetworkPositionTracking)||
|[static EnableNetworkServerIncomingPacketTracking](VRage.MyCompilationSymbols@EnableNetworkServerIncomingPacketTracking)||
|[static EnableNetworkServerOutgoingPacketTracking](VRage.MyCompilationSymbols@EnableNetworkServerOutgoingPacketTracking)||
|[static EnableNsightDebugging](VRage.MyCompilationSymbols@EnableNsightDebugging)||
|[static EnableNsightShaderDebugging](VRage.MyCompilationSymbols@EnableNsightShaderDebugging)||
|[static EnableNsightShaderPreprocessor](VRage.MyCompilationSymbols@EnableNsightShaderPreprocessor)||
|[static EnableOptick](VRage.MyCompilationSymbols@EnableOptick)||
|[static EnableSharpDxObjectTracking](VRage.MyCompilationSymbols@EnableSharpDxObjectTracking)||
|[static GpuMarkers](VRage.MyCompilationSymbols@GpuMarkers)|GPU debug markers: a BeginEvent/EndEvent region around every RHI profiling block, so a PIX/Nsight/RenderDoc capture reads as named passes instead of a flat draw list. Separate from [PerformanceProfiling](VRage.MyCompilationSymbols@PerformanceProfiling) because that also collects timestamps and is only reachable in a RELEASE_PROFILE build, which the DX12 renderer has no buildable configuration for.|
|[static GpuMarkersSymbol](VRage.MyCompilationSymbols@GpuMarkersSymbol)||
|[static HavokDeepProfiling](VRage.MyCompilationSymbols@HavokDeepProfiling)||
|[static LogRenderGIDs](VRage.MyCompilationSymbols@LogRenderGIDs)||
|[static PerformanceProfiling](VRage.MyCompilationSymbols@PerformanceProfiling)||
|[static PerformanceProfilingSymbol](VRage.MyCompilationSymbols@PerformanceProfilingSymbol)||
|[static ProfileFromStart](VRage.MyCompilationSymbols@ProfileFromStart)||
|[static ProfileManagedAllocations](VRage.MyCompilationSymbols@ProfileManagedAllocations)||
|[static ProfileRenderMessages](VRage.MyCompilationSymbols@ProfileRenderMessages)||
|[static ReinterpretFormatsStoredInFiles](VRage.MyCompilationSymbols@ReinterpretFormatsStoredInFiles)||
|[static RenderProfileFromStart](VRage.MyCompilationSymbols@RenderProfileFromStart)| [ProfileFromStart](VRage.MyCompilationSymbols@ProfileFromStart) for [RenderProfiling](VRage.MyCompilationSymbols@RenderProfiling) : collect from the first frame instead of waiting for the profiler to be opened (Alt+Decimal) and unpaused (Alt+Enter) by hand.|
|[static RenderProfiling](VRage.MyCompilationSymbols@RenderProfiling)|Render-only profiling. Keeps the profiler call sites of the render assemblies alive — the render thread's CPU blocks and the GPU timestamp blocks — while every game-side one stays compiled out, so DX12 can be profiled without [PerformanceProfiling](VRage.MyCompilationSymbols@PerformanceProfiling) , whose whole-game instrumentation costs a dictionary lookup and a timestamp on every block in the simulation and which the DX12 renderer has no buildable configuration for. Works because the symbol is only in the render projects' DefineConstants, and`[Conditional]`is resolved against the caller's defines.|
|[static RenderProfilingSymbol](VRage.MyCompilationSymbols@RenderProfilingSymbol)||
|[static TracingEnabled](VRage.MyCompilationSymbols@TracingEnabled)||

## Properties

|Member|Description|
|---|---|
|[static IsDebugBuild](VRage.MyCompilationSymbols@IsDebugBuild)||

