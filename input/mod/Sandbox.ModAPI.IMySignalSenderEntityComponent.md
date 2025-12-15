**Assembly:** Sandbox.Common.dll

```csharp
public interface IMySignalSenderEntityComponent
```

Describes entity component for sending a signal to appropriate receivers

## Methods

|Member|Description|
|---|---|
|[SendSignal(int?)](Sandbox.ModAPI.IMySignalSenderEntityComponent@SendSignal)|Sends a signal to the channel. If no channel number is provided, uses channel number from IMySignalChannelProvider component of the same container.|

