**Assembly:** Sandbox.Common.dll

```csharp
public interface IMySalvageServiceComponent
```

Describes salvage service entity component

## Methods

|Member|Description|
|---|---|
|[ClearCallbacks()](Sandbox.ModAPI.IMySalvageServiceComponent@ClearCallbacks)|Clears all request callbacks|
|[RequestAcceptOffer(Action<bool>, MyObjectBuilder_SalvageServiceQuote)](Sandbox.ModAPI.IMySalvageServiceComponent@RequestAcceptOffer)|Accepts salvage quote|
|[RequestGrids(Action<List<MyObjectBuilder_ServiceGridData>, bool>)](Sandbox.ModAPI.IMySalvageServiceComponent@RequestGrids)||
|[RequestQuote(Action<MyObjectBuilder_SalvageServiceQuote>, long)](Sandbox.ModAPI.IMySalvageServiceComponent@RequestQuote)|Gets salvage quote|

