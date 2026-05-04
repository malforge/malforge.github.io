**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyRepairServiceComponent
```

Describes repair service entity component

## Methods

|Member|Description|
|---|---|
|[RequestGrids(Action<List<MyObjectBuilder_ServiceGridData>, bool>)](Sandbox.ModAPI.IMyRepairServiceComponent@RequestGrids)||
|[RequestRepair(MyObjectBuilder_ServiceQuoteData, Action<RepairResult>)](Sandbox.ModAPI.IMyRepairServiceComponent@RequestRepair)|Requests repair for given quote|
|[RequestRepairQuote(long, Action<MyObjectBuilder_ServiceQuoteData>)](Sandbox.ModAPI.IMyRepairServiceComponent@RequestRepairQuote)|Gets quote data for given cube grid|

