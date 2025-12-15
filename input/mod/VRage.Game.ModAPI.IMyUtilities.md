**Assembly:** VRage.Game.dll

```csharp
public interface IMyUtilities
```

ModAPI interface giving access to utility functions

## Events

|Member|Description|
|---|---|
|[MessageEntered](VRage.Game.ModAPI.IMyUtilities@MessageEntered)|Old handler. Use [MessageEnteredSender](VRage.Game.ModAPI.IMyUtilities@MessageEnteredSender) instead|
|[MessageEnteredSender](VRage.Game.ModAPI.IMyUtilities@MessageEnteredSender)|Called when player sending message. If you changeto false, message won't be sent to other players and server It may be used to handle local commands like /wave|
|[MessageRecieved](VRage.Game.ModAPI.IMyUtilities@MessageRecieved)|Called when message arrived from server (other player). Arguments - Player SteamId and message text.|

## Properties

|Member|Description|
|---|---|
|[ConfigDedicated](VRage.Game.ModAPI.IMyUtilities@ConfigDedicated)|Gets config of dedicated server|
|[GamePaths](VRage.Game.ModAPI.IMyUtilities@GamePaths)|Gets ModAPI interface that, giving you information about most important game paths|
|[IsDedicated](VRage.Game.ModAPI.IMyUtilities@IsDedicated)|Gets if this game instance is dedicated server|

## Methods

|Member|Description|
|---|---|
|[CreateNotification(string, int, string)](VRage.Game.ModAPI.IMyUtilities@CreateNotification)|Create a notification object. The object needs to have Show() called on it to be shown. On top of that you can dynamically change the text, font and adjust the time to live.|
|[DeleteFileInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@DeleteFileInGlobalStorage)|Deletes file in global storage %APPDATA%/Roaming/SpaceEngineers/Storage|
|[DeleteFileInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@DeleteFileInLocalStorage)|Deletes file in local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName|
|[DeleteFileInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@DeleteFileInWorldStorage)|Deletes file in world storage %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName|
|[FileExistsInGameContent(string)](VRage.Game.ModAPI.IMyUtilities@FileExistsInGameContent)|Checks if file exists in game content folder. (Folder where SE is installed)|
|[FileExistsInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@FileExistsInGlobalStorage)|Checks if file exists in %APPDATA%/Roaming/SpaceEngineers/Storage folder. (Folder where SE is installed)|
|[FileExistsInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@FileExistsInLocalStorage)|Checks if file exists in %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName|
|[FileExistsInModLocation(string, ModItem)](VRage.Game.ModAPI.IMyUtilities@FileExistsInModLocation)||
|[FileExistsInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@FileExistsInWorldStorage)|Checks if file exists in world save %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName|
|[GetObjectiveLine()](VRage.Game.ModAPI.IMyUtilities@GetObjectiveLine)|Gets objectives interface|
|[GetTypeName(Type)](VRage.Game.ModAPI.IMyUtilities@GetTypeName)|Gets name of type|
|[GetVariable<T>(string, out T)](VRage.Game.ModAPI.IMyUtilities@GetVariable{T})||
|[InvokeOnGameThread(Action, string, int, int)](VRage.Game.ModAPI.IMyUtilities@InvokeOnGameThread)|Invokes action on simulation thread|
|[ReadBinaryFileInGameContent(string)](VRage.Game.ModAPI.IMyUtilities@ReadBinaryFileInGameContent)|Reads text file from game content folder. (Folder where SE is installed)|
|[ReadBinaryFileInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@ReadBinaryFileInGlobalStorage)|Reads text file from global storage %APPDATA%/Roaming/SpaceEngineers/Storage|
|[ReadBinaryFileInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@ReadBinaryFileInLocalStorage)|Reads binary file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}|
|[ReadBinaryFileInModLocation(string, ModItem)](VRage.Game.ModAPI.IMyUtilities@ReadBinaryFileInModLocation)||
|[ReadBinaryFileInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@ReadBinaryFileInWorldStorage)|Read binary file from world storage %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope}|
|[ReadFileInGameContent(string)](VRage.Game.ModAPI.IMyUtilities@ReadFileInGameContent)|Reads text file from game content folder. (Folder where SE is installed)|
|[ReadFileInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@ReadFileInGlobalStorage)|Reads text file from global storage %APPDATA%/Roaming/SpaceEngineers/Storage|
|[ReadFileInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@ReadFileInLocalStorage)|Reads text file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}|
|[ReadFileInModLocation(string, ModItem)](VRage.Game.ModAPI.IMyUtilities@ReadFileInModLocation)||
|[ReadFileInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@ReadFileInWorldStorage)|Read text file from world storage %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope}|
|[RegisterMessageHandler(long, Action<object>)](VRage.Game.ModAPI.IMyUtilities@RegisterMessageHandler)|Adds a handler to the mod message system.|
|[RemoveVariable(string)](VRage.Game.ModAPI.IMyUtilities@RemoveVariable)|Unregisters variable|
|[SendMessage(string)](VRage.Game.ModAPI.IMyUtilities@SendMessage)|Send message to other players|
|[SendModMessage(long, object)](VRage.Game.ModAPI.IMyUtilities@SendModMessage)|Allows passing data between mods on the same client.|
|[SerializeFromBinary<T>(Byte[])](VRage.Game.ModAPI.IMyUtilities@SerializeFromBinary{T})||
|[SerializeFromXML<T>(string)](VRage.Game.ModAPI.IMyUtilities@SerializeFromXML{T})||
|[SerializeToBinary<T>(T)](VRage.Game.ModAPI.IMyUtilities@SerializeToBinary{T})||
|[SerializeToXML<T>(T)](VRage.Game.ModAPI.IMyUtilities@SerializeToXML{T})||
|[SetVariable<T>(string, T)](VRage.Game.ModAPI.IMyUtilities@SetVariable{T})||
|[ShowMessage(string, string)](VRage.Game.ModAPI.IMyUtilities@ShowMessage)|Shows message for local player without sending it to other players|
|[ShowMissionScreen(string, string, string, string, Action<ResultEnum>, string)](VRage.Game.ModAPI.IMyUtilities@ShowMissionScreen)|Shows mission screen|
|[ShowNotification(string, int, string)](VRage.Game.ModAPI.IMyUtilities@ShowNotification)|Shows notification|
|[UnregisterMessageHandler(long, Action<object>)](VRage.Game.ModAPI.IMyUtilities@UnregisterMessageHandler)|Removes a handler from the mod message system.|
|[WriteBinaryFileInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@WriteBinaryFileInGlobalStorage)|Write bytes to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}|
|[WriteBinaryFileInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@WriteBinaryFileInLocalStorage)|Write bytes to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}|
|[WriteBinaryFileInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@WriteBinaryFileInWorldStorage)|Write file to the current world's Storage directory.|
|[WriteFileInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@WriteFileInGlobalStorage)|Write text to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}|
|[WriteFileInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@WriteFileInLocalStorage)|Write text to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}|
|[WriteFileInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@WriteFileInWorldStorage)|Write text to file from current world's storage directory. %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope}|

**Inheritors:**  
* [MyAPIUtilities](Sandbox.ModAPI.MyAPIUtilities)

