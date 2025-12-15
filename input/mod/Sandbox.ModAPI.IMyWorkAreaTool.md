**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyWorkAreaTool
```

Describes tool used by work area component

## Events

|Member|Description|
|---|---|
|[BusyStatusChanged](Sandbox.ModAPI.IMyWorkAreaTool@BusyStatusChanged)|Event invoked when busy status of the tool has changed|
|[InventoryActionTriggered](Sandbox.ModAPI.IMyWorkAreaTool@InventoryActionTriggered)|Event invoked upon inventory action triggers (can't push from inventory of drill and grinder or empty inventory of welder)|

## Properties

|Member|Description|
|---|---|
|[IsBusy](Sandbox.ModAPI.IMyWorkAreaTool@IsBusy)|Indicates if the tool is currently busy (welding, drilling, grinding in progress)|

