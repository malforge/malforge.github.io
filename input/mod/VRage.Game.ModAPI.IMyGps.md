**Assembly:** VRage.Game.dll

```csharp
public interface IMyGps
```

Describes GPS (mods interface)

## Properties

|Member|Description|
|---|---|
|[ContainerRemainingTime](VRage.Game.ModAPI.IMyGps@ContainerRemainingTime)|Gets or sets gps text that would be displayed on HUD|
|[Coords](VRage.Game.ModAPI.IMyGps@Coords)|Gets or sets GPS coordinates|
|[Description](VRage.Game.ModAPI.IMyGps@Description)|Gets or sets GPS description|
|[DiscardAt](VRage.Game.ModAPI.IMyGps@DiscardAt)|If it's null then the GPS is confirmed (does not expire automatically). Otherwise, time at which we should drop it from the list, relative to ElapsedPlayTime|
|[GPSColor](VRage.Game.ModAPI.IMyGps@GPSColor)|Gets or sets GPS color|
|[Hash](VRage.Game.ModAPI.IMyGps@Hash)|The GPS entry id hash which is generated using the GPS name and coordinates.|
|[Name](VRage.Game.ModAPI.IMyGps@Name)|Gets or sets GPS name|
|[ShowOnHud](VRage.Game.ModAPI.IMyGps@ShowOnHud)|Gets or sets whether GPS should be visible on HUD|

## Methods

|Member|Description|
|---|---|
|[ToString()](VRage.Game.ModAPI.IMyGps@ToString)|Gets information about GPS|
|[UpdateHash()](VRage.Game.ModAPI.IMyGps@UpdateHash)|Updates the hash id if you've changed the name or the coordinates. NOTE: Do not use this if you plan on using this object to update existing GPS entries.|

