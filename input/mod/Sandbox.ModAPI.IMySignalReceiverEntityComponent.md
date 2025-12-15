**Assembly:** Sandbox.Common.dll

```csharp
public interface IMySignalReceiverEntityComponent
```

Describes entity component for triggering toolbar-defined actions when receiving a signal

## Events

|Member|Description|
|---|---|
|[SignalReceived](Sandbox.ModAPI.IMySignalReceiverEntityComponent@SignalReceived)|Called when a signal is received|
|[TriggeredBySignal](Sandbox.ModAPI.IMySignalReceiverEntityComponent@TriggeredBySignal)|Called when successfully triggered by a signal|

## Properties

|Member|Description|
|---|---|
|[AllowSignalsFrom](Sandbox.ModAPI.IMySignalReceiverEntityComponent@AllowSignalsFrom)|Gets or sets [MyTransponderRelationFilter](VRage.Game.ModAPI.Ingame.MyTransponderRelationFilter) which defines allowed relation between signal sender and signal receiver.|

## Methods

|Member|Description|
|---|---|
|[Receive(long, int)](Sandbox.ModAPI.IMySignalReceiverEntityComponent@Receive)|Checks the channel and relations between receivers' owner and signal sender, triggers if appropriate to do so|

