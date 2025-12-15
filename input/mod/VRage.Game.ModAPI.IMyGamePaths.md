**Assembly:** VRage.Game.dll

```csharp
public interface IMyGamePaths
```

ModAPI interface that, giving you information about most important game paths

## Properties

|Member|Description|
|---|---|
|[ContentPath](VRage.Game.ModAPI.IMyGamePaths@ContentPath)|Return path, where original SE content folder is located. Example: D:\SteamLibrary\steamapps\common\SpaceEngineers\Content|
|[ModScopeName](VRage.Game.ModAPI.IMyGamePaths@ModScopeName)|Gets the calling mod's assembly ScopeName. This name is used in storage paths (eg. 1234567.sbm_TypeName).|
|[ModsPath](VRage.Game.ModAPI.IMyGamePaths@ModsPath)|Return path, where SE mod folder is located. Example: C:\Users\{USERNAME}\AppData\Roaming\SpaceEngineers\Mods|
|[SavesPath](VRage.Game.ModAPI.IMyGamePaths@SavesPath)|Return path, where SE user saves path is located. Example: C:\Users\{USERNAME}\AppData\Roaming\SpaceEngineers\Saves|
|[UserDataPath](VRage.Game.ModAPI.IMyGamePaths@UserDataPath)|Return path, where SE user folder is located. Example: C:\Users\{USERNAME}\AppData\Roaming\SpaceEngineers|

**Inheritors:**  
* [MyAPIUtilities](Sandbox.ModAPI.MyAPIUtilities)

