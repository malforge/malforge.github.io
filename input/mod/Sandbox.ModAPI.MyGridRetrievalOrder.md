**Assembly:** Sandbox.Common.dll

```csharp
public class MyGridRetrievalOrder
```

Represents a grid storage retrieval order

## Fields

|Member|Description|
|---|---|
|[CallerEndpointId](Sandbox.ModAPI.MyGridRetrievalOrder@CallerEndpointId)|Client id (network) which had generated this order, intended for client-side UI callbacks|
|[CallerEntityId](Sandbox.ModAPI.MyGridRetrievalOrder@CallerEntityId)|ID of the entity which was used to generate this order|
|[CountdownMs](Sandbox.ModAPI.MyGridRetrievalOrder@CountdownMs)|Milliseconds before spawn attempt|
|[CreditsPaid](Sandbox.ModAPI.MyGridRetrievalOrder@CreditsPaid)|SC paid for the "expedite" feature|
|[DisplayName](Sandbox.ModAPI.MyGridRetrievalOrder@DisplayName)|Name|
|[Id](Sandbox.ModAPI.MyGridRetrievalOrder@Id)|Identity of an item in the grid storage|
|[InProgress](Sandbox.ModAPI.MyGridRetrievalOrder@InProgress)|Countdown finished, the retrieval request was generated and is being handled|

## Constructors

|Member|Description|
|---|---|
|[MyGridRetrievalOrder()](Sandbox.ModAPI.MyGridRetrievalOrder@.ctor)||

