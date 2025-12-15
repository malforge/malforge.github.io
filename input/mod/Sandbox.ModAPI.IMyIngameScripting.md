**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyIngameScripting
```

Allows mods change programmable block script settings

## Properties

|Member|Description|
|---|---|
|[ScriptBlacklist](Sandbox.ModAPI.IMyIngameScripting@ScriptBlacklist)|Provides the ability for mods to add and remove items from a type and member blacklist, giving the ability to remove even more API for scripts. Intended for server admins to restrict what people are able to do with scripts to keep their simspeed up.|

## Methods

|Member|Description|
|---|---|
|[Clean()](Sandbox.ModAPI.IMyIngameScripting@Clean)|Clears all [ScriptBlacklist](Sandbox.ModAPI.IMyIngameScripting@ScriptBlacklist) changes|

**Inheritors:**  
* [MyVRageIngameScriptingAdapter](Sandbox.ModAPI.MyVRageIngameScriptingAdapter)

