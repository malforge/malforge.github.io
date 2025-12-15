**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyScriptBlacklist
```

Exposes blacklist functionality to allow mods to disallow parts of the scripting API that has been allowed by the system whitelist.

## Methods

|Member|Description|
|---|---|
|[GetBlacklistedIngameEntries()](Sandbox.ModAPI.IMyScriptBlacklist@GetBlacklistedIngameEntries)|Gets the entries that have been blacklisted for the ingame scripts.|
|[GetWhitelist()](Sandbox.ModAPI.IMyScriptBlacklist@GetWhitelist)|Gets the entries that have been whitelisted by the system. Each entry may represent a whole namespace, a single type and all its members, or a single member of a type.|
|[OpenIngameBlacklistBatch()](Sandbox.ModAPI.IMyScriptBlacklist@OpenIngameBlacklistBatch)|Opens a batch to add or remove members to the blacklist.|

**Inheritors:**  
* [MyVRageIngameScriptingAdapter](Sandbox.ModAPI.MyVRageIngameScriptingAdapter)

