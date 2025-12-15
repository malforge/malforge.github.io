**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyHazardExposureComponent
```

Describes session component responsible for hazard exposure application

## Methods

|Member|Description|
|---|---|
|[AddSource(IMyHazardSource)](Sandbox.ModAPI.IMyHazardExposureComponent@AddSource)|Adds an [IMyHazardSource](Sandbox.ModAPI.IMyHazardSource) to the processing list|
|[GetCurrentlyProcessedSources(List<IMyHazardSource>)](Sandbox.ModAPI.IMyHazardExposureComponent@GetCurrentlyProcessedSources)|Gets references to sources in the processing list|
|[RemoveSource<T>()](Sandbox.ModAPI.IMyHazardExposureComponent@RemoveSource{T})||
|[RemoveSource(IMyHazardSource)](Sandbox.ModAPI.IMyHazardExposureComponent@RemoveSource)|Removes specific source from the processing list|

