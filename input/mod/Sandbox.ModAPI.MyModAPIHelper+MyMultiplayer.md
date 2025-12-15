**Assembly:** Sandbox.Game.dll

```csharp
public class MyMultiplayer: IMyMultiplayer
```

## Fields

|Member|Description|
|---|---|
|[static Static](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@Static)||

## Properties

|Member|Description|
|---|---|
|[IsServer](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@IsServer)||
|[MultiplayerActive](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@MultiplayerActive)||
|[MyId](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@MyId)||
|[MyName](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@MyName)||
|[Players](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@Players)||
|[ServerId](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@ServerId)||
|[IsServer](VRage.Game.ModAPI.IMyMultiplayer@IsServer)|Returns if current game instance is server<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[MultiplayerActive](VRage.Game.ModAPI.IMyMultiplayer@MultiplayerActive)|Gets if game supports several people<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[MyId](VRage.Game.ModAPI.IMyMultiplayer@MyId)|Gets this game instance id (steamId or other)<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[MyName](VRage.Game.ModAPI.IMyMultiplayer@MyName)|Get current player name<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[Players](VRage.Game.ModAPI.IMyMultiplayer@Players)|Gets players currently connected to server<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[ServerId](VRage.Game.ModAPI.IMyMultiplayer@ServerId)|Gets id (steamId or other) of server<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|

## Constructors

|Member|Description|
|---|---|
|[MyMultiplayer()](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@.ctor)||

## Methods

|Member|Description|
|---|---|
|[IsServerPlayer(IMyNetworkClient)](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@IsServerPlayer)||
|[JoinServer(string)](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@JoinServer)||
|[RegisterMessageHandler(ushort, Action<Byte[]>)](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@RegisterMessageHandler)||
|[RegisterSecureMessageHandler(ushort, Action<ushort, Byte[], ulong, bool>)](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@RegisterSecureMessageHandler)||
|[SendEntitiesCreated(List<MyObjectBuilder_EntityBase>)](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@SendEntitiesCreated)||
|[SendMessageTo(ushort, Byte[], ulong, bool)](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@SendMessageTo)||
|[SendMessageToOthers(ushort, Byte[], bool)](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@SendMessageToOthers)||
|[SendMessageToServer(ushort, Byte[], bool)](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@SendMessageToServer)||
|[UnregisterMessageHandler(ushort, Action<Byte[]>)](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@UnregisterMessageHandler)||
|[UnregisterSecureMessageHandler(ushort, Action<ushort, Byte[], ulong, bool>)](Sandbox.ModAPI.MyModAPIHelper+MyMultiplayer@UnregisterSecureMessageHandler)||
|[IsServerPlayer(IMyNetworkClient)](VRage.Game.ModAPI.IMyMultiplayer@IsServerPlayer)|Gets if provided network is a player and also server<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[JoinServer(string)](VRage.Game.ModAPI.IMyMultiplayer@JoinServer)|Exiting current server, and joining other server<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[RegisterSecureMessageHandler(ushort, Action<ushort, Byte[], ulong, bool>)](VRage.Game.ModAPI.IMyMultiplayer@RegisterSecureMessageHandler)|Allows you do reliable checks WHO have sent message to you. Action - HandlerId, Package, Player SteamID or 0 for Dedicated server, Sent message comes from server<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[SendEntitiesCreated(List<MyObjectBuilder_EntityBase>)](VRage.Game.ModAPI.IMyMultiplayer@SendEntitiesCreated)|Does nothing<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[SendMessageTo(ushort, Byte[], ulong, bool)](VRage.Game.ModAPI.IMyMultiplayer@SendMessageTo)|Send message to one recipient.<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[SendMessageToOthers(ushort, Byte[], bool)](VRage.Game.ModAPI.IMyMultiplayer@SendMessageToOthers)|Send message to everyone on server (including server)<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[SendMessageToServer(ushort, Byte[], bool)](VRage.Game.ModAPI.IMyMultiplayer@SendMessageToServer)|Send message to server<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[UnregisterSecureMessageHandler(ushort, Action<ushort, Byte[], ulong, bool>)](VRage.Game.ModAPI.IMyMultiplayer@UnregisterSecureMessageHandler)|Unsubscribes from incoming messages<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[RegisterMessageHandler(ushort, Action<Byte[]>)](VRage.Game.ModAPI.IMyMultiplayer@RegisterMessageHandler)|_**Obsolete:** Use RegisterSecureMessageHandler && UnregisterSecureMessageHandler pair instead_<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|
|[UnregisterMessageHandler(ushort, Action<Byte[]>)](VRage.Game.ModAPI.IMyMultiplayer@UnregisterMessageHandler)|_**Obsolete:** Use RegisterSecureMessageHandler && UnregisterSecureMessageHandler pair instead_<br /><br />_Inherited from [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)_|

**Implements:**  
* [IMyMultiplayer](VRage.Game.ModAPI.IMyMultiplayer)

