**Assembly:** Sandbox.Game.dll

```csharp
public class MyAPIUtilities: IMyUtilities, IMyGamePaths
```

## Fields

|Member|Description|
|---|---|
|[static Static](Sandbox.ModAPI.MyAPIUtilities@Static)||
|[Variables](Sandbox.ModAPI.MyAPIUtilities@Variables)||

## Events

|Member|Description|
|---|---|
|[MessageEntered](Sandbox.ModAPI.MyAPIUtilities@MessageEntered)||
|[MessageEnteredSender](Sandbox.ModAPI.MyAPIUtilities@MessageEnteredSender)||
|[MessageRecieved](Sandbox.ModAPI.MyAPIUtilities@MessageRecieved)||
|[MessageEntered](VRage.Game.ModAPI.IMyUtilities@MessageEntered)|Old handler. Use [MessageEnteredSender](VRage.Game.ModAPI.IMyUtilities@MessageEnteredSender) instead<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[MessageEnteredSender](VRage.Game.ModAPI.IMyUtilities@MessageEnteredSender)|Called when player sending message. If you changeto false, message won't be sent to other players and server It may be used to handle local commands like /wave<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[MessageRecieved](VRage.Game.ModAPI.IMyUtilities@MessageRecieved)|Called when message arrived from server (other player). Arguments - Player SteamId and message text.<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|

## Properties

|Member|Description|
|---|---|
|[ConfigDedicated](VRage.Game.ModAPI.IMyUtilities@ConfigDedicated)|Gets config of dedicated server<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ContentPath](VRage.Game.ModAPI.IMyGamePaths@ContentPath)|Return path, where original SE content folder is located. Example: D:\SteamLibrary\steamapps\common\SpaceEngineers\Content<br /><br />_Inherited from [IMyGamePaths](VRage.Game.ModAPI.IMyGamePaths)_|
|[GamePaths](VRage.Game.ModAPI.IMyUtilities@GamePaths)|Gets ModAPI interface that, giving you information about most important game paths<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[IsDedicated](VRage.Game.ModAPI.IMyUtilities@IsDedicated)|Gets if this game instance is dedicated server<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ModScopeName](VRage.Game.ModAPI.IMyGamePaths@ModScopeName)|Gets the calling mod's assembly ScopeName. This name is used in storage paths (eg. 1234567.sbm_TypeName).<br /><br />_Inherited from [IMyGamePaths](VRage.Game.ModAPI.IMyGamePaths)_|
|[ModsPath](VRage.Game.ModAPI.IMyGamePaths@ModsPath)|Return path, where SE mod folder is located. Example: C:\Users\{USERNAME}\AppData\Roaming\SpaceEngineers\Mods<br /><br />_Inherited from [IMyGamePaths](VRage.Game.ModAPI.IMyGamePaths)_|
|[SavesPath](VRage.Game.ModAPI.IMyGamePaths@SavesPath)|Return path, where SE user saves path is located. Example: C:\Users\{USERNAME}\AppData\Roaming\SpaceEngineers\Saves<br /><br />_Inherited from [IMyGamePaths](VRage.Game.ModAPI.IMyGamePaths)_|
|[UserDataPath](VRage.Game.ModAPI.IMyGamePaths@UserDataPath)|Return path, where SE user folder is located. Example: C:\Users\{USERNAME}\AppData\Roaming\SpaceEngineers<br /><br />_Inherited from [IMyGamePaths](VRage.Game.ModAPI.IMyGamePaths)_|

## Constructors

|Member|Description|
|---|---|
|[MyAPIUtilities()](Sandbox.ModAPI.MyAPIUtilities@.ctor)||

## Methods

|Member|Description|
|---|---|
|[EnterMessage(ulong, string, ref bool)](Sandbox.ModAPI.MyAPIUtilities@EnterMessage)||
|[EnterMessageSender(ulong, string, ref bool)](Sandbox.ModAPI.MyAPIUtilities@EnterMessageSender)||
|[RecieveMessage(ulong, string)](Sandbox.ModAPI.MyAPIUtilities@RecieveMessage)||
|[RegisterMessageHandler(long, Action<object>)](Sandbox.ModAPI.MyAPIUtilities@RegisterMessageHandler)||
|[SendModMessage(long, object)](Sandbox.ModAPI.MyAPIUtilities@SendModMessage)||
|[UnregisterMessageHandler(long, Action<object>)](Sandbox.ModAPI.MyAPIUtilities@UnregisterMessageHandler)||
|[CreateNotification(string, int, string)](VRage.Game.ModAPI.IMyUtilities@CreateNotification)|Create a notification object. The object needs to have Show() called on it to be shown. On top of that you can dynamically change the text, font and adjust the time to live.<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[DeleteFileInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@DeleteFileInGlobalStorage)|Deletes file in global storage %APPDATA%/Roaming/SpaceEngineers/Storage<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[DeleteFileInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@DeleteFileInLocalStorage)|Deletes file in local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[DeleteFileInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@DeleteFileInWorldStorage)|Deletes file in world storage %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[FileExistsInGameContent(string)](VRage.Game.ModAPI.IMyUtilities@FileExistsInGameContent)|Checks if file exists in game content folder. (Folder where SE is installed)<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[FileExistsInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@FileExistsInGlobalStorage)|Checks if file exists in %APPDATA%/Roaming/SpaceEngineers/Storage folder. (Folder where SE is installed)<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[FileExistsInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@FileExistsInLocalStorage)|Checks if file exists in %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[FileExistsInModLocation(string, ModItem)](VRage.Game.ModAPI.IMyUtilities@FileExistsInModLocation)|_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[FileExistsInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@FileExistsInWorldStorage)|Checks if file exists in world save %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[GetObjectiveLine()](VRage.Game.ModAPI.IMyUtilities@GetObjectiveLine)|Gets objectives interface<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[GetTypeName(Type)](VRage.Game.ModAPI.IMyUtilities@GetTypeName)|Gets name of type<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[GetVariable<T>(string, out T)](VRage.Game.ModAPI.IMyUtilities@GetVariable{T})|_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[InvokeOnGameThread(Action, string, int, int)](VRage.Game.ModAPI.IMyUtilities@InvokeOnGameThread)|Invokes action on simulation thread<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ReadBinaryFileInGameContent(string)](VRage.Game.ModAPI.IMyUtilities@ReadBinaryFileInGameContent)|Reads text file from game content folder. (Folder where SE is installed)<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ReadBinaryFileInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@ReadBinaryFileInGlobalStorage)|Reads text file from global storage %APPDATA%/Roaming/SpaceEngineers/Storage<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ReadBinaryFileInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@ReadBinaryFileInLocalStorage)|Reads binary file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ReadBinaryFileInModLocation(string, ModItem)](VRage.Game.ModAPI.IMyUtilities@ReadBinaryFileInModLocation)|_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ReadBinaryFileInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@ReadBinaryFileInWorldStorage)|Read binary file from world storage %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope}<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ReadFileInGameContent(string)](VRage.Game.ModAPI.IMyUtilities@ReadFileInGameContent)|Reads text file from game content folder. (Folder where SE is installed)<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ReadFileInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@ReadFileInGlobalStorage)|Reads text file from global storage %APPDATA%/Roaming/SpaceEngineers/Storage<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ReadFileInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@ReadFileInLocalStorage)|Reads text file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ReadFileInModLocation(string, ModItem)](VRage.Game.ModAPI.IMyUtilities@ReadFileInModLocation)|_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ReadFileInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@ReadFileInWorldStorage)|Read text file from world storage %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope}<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[RegisterMessageHandler(long, Action<object>)](VRage.Game.ModAPI.IMyUtilities@RegisterMessageHandler)|Adds a handler to the mod message system.<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[RemoveVariable(string)](VRage.Game.ModAPI.IMyUtilities@RemoveVariable)|Unregisters variable<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[SendMessage(string)](VRage.Game.ModAPI.IMyUtilities@SendMessage)|Send message to other players<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[SendModMessage(long, object)](VRage.Game.ModAPI.IMyUtilities@SendModMessage)|Allows passing data between mods on the same client.<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[SerializeFromBinary<T>(Byte[])](VRage.Game.ModAPI.IMyUtilities@SerializeFromBinary{T})|_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[SerializeFromXML<T>(string)](VRage.Game.ModAPI.IMyUtilities@SerializeFromXML{T})|_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[SerializeToBinary<T>(T)](VRage.Game.ModAPI.IMyUtilities@SerializeToBinary{T})|_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[SerializeToXML<T>(T)](VRage.Game.ModAPI.IMyUtilities@SerializeToXML{T})|_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[SetVariable<T>(string, T)](VRage.Game.ModAPI.IMyUtilities@SetVariable{T})|_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ShowMessage(string, string)](VRage.Game.ModAPI.IMyUtilities@ShowMessage)|Shows message for local player without sending it to other players<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ShowMissionScreen(string, string, string, string, Action<ResultEnum>, string)](VRage.Game.ModAPI.IMyUtilities@ShowMissionScreen)|Shows mission screen<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[ShowNotification(string, int, string)](VRage.Game.ModAPI.IMyUtilities@ShowNotification)|Shows notification<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[UnregisterMessageHandler(long, Action<object>)](VRage.Game.ModAPI.IMyUtilities@UnregisterMessageHandler)|Removes a handler from the mod message system.<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[WriteBinaryFileInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@WriteBinaryFileInGlobalStorage)|Write bytes to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[WriteBinaryFileInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@WriteBinaryFileInLocalStorage)|Write bytes to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[WriteBinaryFileInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@WriteBinaryFileInWorldStorage)|Write file to the current world's Storage directory.<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[WriteFileInGlobalStorage(string)](VRage.Game.ModAPI.IMyUtilities@WriteFileInGlobalStorage)|Write text to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[WriteFileInLocalStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@WriteFileInLocalStorage)|Write text to file from local storage %APPDATA%/Roaming/SpaceEngineers/Storage/{Assembly Scope}<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|
|[WriteFileInWorldStorage(string, Type)](VRage.Game.ModAPI.IMyUtilities@WriteFileInWorldStorage)|Write text to file from current world's storage directory. %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope}<br /><br />_Inherited from [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)_|

**Implements:**  
* [IMyGamePaths](VRage.Game.ModAPI.IMyGamePaths)  
* [IMyUtilities](VRage.Game.ModAPI.IMyUtilities)

