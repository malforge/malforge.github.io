**Assembly:** VRage.Game.dll

```csharp
public enum MyPromoteLevel
```

Describes what permissions a user has If you add items, always preserve order from lowest to highest permission

## Fields

|Member|Description|
|---|---|
|Admin|Has access to Admin tools|
|Moderator|Can kick and ban players, has access to 'Show All Players' option in Admin Tools menu|
|None|Normal players|
|Owner|Admins listed in server config, cannot be demoted|
|Scripter|Can edit scripts when the scripter role is enabled|
|SpaceMaster|Has access to Space Master tools|

