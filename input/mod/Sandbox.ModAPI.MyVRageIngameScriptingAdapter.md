**Assembly:** Sandbox.Common.dll

```csharp
public class MyVRageIngameScriptingAdapter: IMyIngameScripting, IMyScriptBlacklist
```

Allows mods change programmable block script settings

## Properties

|Member|Description|
|---|---|
|[ScriptBlacklist](Sandbox.ModAPI.MyVRageIngameScriptingAdapter@ScriptBlacklist)|Provides the ability for mods to add and remove items from a type and member blacklist, giving the ability to remove even more API for scripts. Intended for server admins to restrict what people are able to do with scripts to keep their simspeed up.|
|[ScriptBlacklist](Sandbox.ModAPI.IMyIngameScripting@ScriptBlacklist)|Provides the ability for mods to add and remove items from a type and member blacklist, giving the ability to remove even more API for scripts. Intended for server admins to restrict what people are able to do with scripts to keep their simspeed up.<br /><br />_Inherited from [IMyIngameScripting](Sandbox.ModAPI.IMyIngameScripting)_|

## Constructors

|Member|Description|
|---|---|
|[MyVRageIngameScriptingAdapter(IMyIngameScripting)](Sandbox.ModAPI.MyVRageIngameScriptingAdapter@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Clean()](Sandbox.ModAPI.MyVRageIngameScriptingAdapter@Clean)|Clears all [ScriptBlacklist](Sandbox.ModAPI.MyVRageIngameScriptingAdapter@ScriptBlacklist) changes|
|[GetBlacklistedIngameEntries()](Sandbox.ModAPI.MyVRageIngameScriptingAdapter@GetBlacklistedIngameEntries)|Gets the entries that have been blacklisted for the ingame scripts.|
|[GetWhitelist()](Sandbox.ModAPI.MyVRageIngameScriptingAdapter@GetWhitelist)|Gets information about whitelisted classes and methods|
|[OpenIngameBlacklistBatch()](Sandbox.ModAPI.MyVRageIngameScriptingAdapter@OpenIngameBlacklistBatch)|Opens a batch to add or remove members to the blacklist.|
|[Clean()](Sandbox.ModAPI.IMyIngameScripting@Clean)|Clears all [ScriptBlacklist](Sandbox.ModAPI.IMyIngameScripting@ScriptBlacklist) changes<br /><br />_Inherited from [IMyIngameScripting](Sandbox.ModAPI.IMyIngameScripting)_|
|[GetBlacklistedIngameEntries()](Sandbox.ModAPI.IMyScriptBlacklist@GetBlacklistedIngameEntries)|Gets the entries that have been blacklisted for the ingame scripts.<br /><br />_Inherited from [IMyScriptBlacklist](Sandbox.ModAPI.IMyScriptBlacklist)_|
|[GetWhitelist()](Sandbox.ModAPI.IMyScriptBlacklist@GetWhitelist)|Gets the entries that have been whitelisted by the system. Each entry may represent a whole namespace, a single type and all its members, or a single member of a type.<br /><br />_Inherited from [IMyScriptBlacklist](Sandbox.ModAPI.IMyScriptBlacklist)_|
|[OpenIngameBlacklistBatch()](Sandbox.ModAPI.IMyScriptBlacklist@OpenIngameBlacklistBatch)|Opens a batch to add or remove members to the blacklist.<br /><br />_Inherited from [IMyScriptBlacklist](Sandbox.ModAPI.IMyScriptBlacklist)_|

**Implements:**  
* [IMyIngameScripting](Sandbox.ModAPI.IMyIngameScripting)  
* [IMyScriptBlacklist](Sandbox.ModAPI.IMyScriptBlacklist)

