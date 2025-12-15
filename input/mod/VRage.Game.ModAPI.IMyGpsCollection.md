**Assembly:** VRage.Game.dll

```csharp
public interface IMyGpsCollection
```

## Methods

|Member|Description|
|---|---|
|[AddGps(long, IMyGps)](VRage.Game.ModAPI.IMyGpsCollection@AddGps)|Sends a network request to add the GPS entry for the said player, which will also save it to the server.|
|[AddLocalGps(IMyGps)](VRage.Game.ModAPI.IMyGpsCollection@AddLocalGps)|Adds a GPS entry only for this client which won't be synchronized or saved.|
|[Create(string, string, Vector3D, bool, bool)](VRage.Game.ModAPI.IMyGpsCollection@Create)|Creates a GPS entry object. Does not automatically add it, you need to use AddGps() or AddLocalGps().|
|[GetGpsList(long)](VRage.Game.ModAPI.IMyGpsCollection@GetGpsList)|Gets the GPS entries from the specified identity (does not use network traffic).|
|[GetGpsList(long, List<IMyGps>)](VRage.Game.ModAPI.IMyGpsCollection@GetGpsList)|Gets the GPS entries from the specified identity (does not use network traffic).|
|[ModifyGps(long, IMyGps)](VRage.Game.ModAPI.IMyGpsCollection@ModifyGps)|Sends a network request to modify the contents of an existing GPS entry.|
|[RemoveGps(long, IMyGps)](VRage.Game.ModAPI.IMyGpsCollection@RemoveGps)|Sends a network request to remove the specified GPS entry.|
|[RemoveGps(long, int)](VRage.Game.ModAPI.IMyGpsCollection@RemoveGps)|Sends a network request to remove the specified GPS entry.|
|[RemoveLocalGps(IMyGps)](VRage.Game.ModAPI.IMyGpsCollection@RemoveLocalGps)|Remove a local GPS entry, no network updates sent. NOTE: This can remove synchronized ones too.|
|[RemoveLocalGps(int)](VRage.Game.ModAPI.IMyGpsCollection@RemoveLocalGps)|Remove a local GPS entry, no network updates sent. NOTE: This can remove synchronized ones too.|
|[SetShowOnHud(long, IMyGps, bool)](VRage.Game.ModAPI.IMyGpsCollection@SetShowOnHud)|Sends a network request to set the GPS entry if it's shown on HUD or not.|
|[SetShowOnHud(long, int, bool)](VRage.Game.ModAPI.IMyGpsCollection@SetShowOnHud)|Sends a network request to set the GPS entry if it's shown on HUD or not.|

