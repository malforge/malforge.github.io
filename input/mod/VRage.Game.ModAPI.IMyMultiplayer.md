**Assembly:** VRage.Game.dll

```csharp
public interface IMyMultiplayer
```

ModAPI interface giving access to interaction between server and client

## Properties

|Member|Description|
|---|---|
|[IsServer](VRage.Game.ModAPI.IMyMultiplayer@IsServer)|Returns if current game instance is server|
|[MultiplayerActive](VRage.Game.ModAPI.IMyMultiplayer@MultiplayerActive)|Gets if game supports several people|
|[MyId](VRage.Game.ModAPI.IMyMultiplayer@MyId)|Gets this game instance id (steamId or other)|
|[MyName](VRage.Game.ModAPI.IMyMultiplayer@MyName)|Get current player name|
|[Players](VRage.Game.ModAPI.IMyMultiplayer@Players)|Gets players currently connected to server|
|[ServerId](VRage.Game.ModAPI.IMyMultiplayer@ServerId)|Gets id (steamId or other) of server|

## Methods

|Member|Description|
|---|---|
|[IsServerPlayer(IMyNetworkClient)](VRage.Game.ModAPI.IMyMultiplayer@IsServerPlayer)|Gets if provided network is a player and also server|
|[JoinServer(string)](VRage.Game.ModAPI.IMyMultiplayer@JoinServer)|Exiting current server, and joining other server|
|[RegisterSecureMessageHandler(ushort, Action<ushort, Byte[], ulong, bool>)](VRage.Game.ModAPI.IMyMultiplayer@RegisterSecureMessageHandler)|Allows you do reliable checks WHO have sent message to you. Action - HandlerId, Package, Player SteamID or 0 for Dedicated server, Sent message comes from server|
|[SendEntitiesCreated(List<MyObjectBuilder_EntityBase>)](VRage.Game.ModAPI.IMyMultiplayer@SendEntitiesCreated)|Does nothing|
|[SendMessageTo(ushort, Byte[], ulong, bool)](VRage.Game.ModAPI.IMyMultiplayer@SendMessageTo)|Send message to one recipient.|
|[SendMessageToOthers(ushort, Byte[], bool)](VRage.Game.ModAPI.IMyMultiplayer@SendMessageToOthers)|Send message to everyone on server (including server)|
|[SendMessageToServer(ushort, Byte[], bool)](VRage.Game.ModAPI.IMyMultiplayer@SendMessageToServer)|Send message to server|
|[UnregisterSecureMessageHandler(ushort, Action<ushort, Byte[], ulong, bool>)](VRage.Game.ModAPI.IMyMultiplayer@UnregisterSecureMessageHandler)|Unsubscribes from incoming messages|
|[RegisterMessageHandler(ushort, Action<Byte[]>)](VRage.Game.ModAPI.IMyMultiplayer@RegisterMessageHandler)|_**Obsolete:** Use RegisterSecureMessageHandler && UnregisterSecureMessageHandler pair instead_|
|[UnregisterMessageHandler(ushort, Action<Byte[]>)](VRage.Game.ModAPI.IMyMultiplayer@UnregisterMessageHandler)|_**Obsolete:** Use RegisterSecureMessageHandler && UnregisterSecureMessageHandler pair instead_|

**Inheritors:**  
* [MyMultiplayer](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer)

