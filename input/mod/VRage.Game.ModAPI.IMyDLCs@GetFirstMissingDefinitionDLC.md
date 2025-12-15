## Summary

```csharp
public IMyDLC GetFirstMissingDefinitionDLC(MyDefinitionBase definition, ulong steamId)
```

Get the first DLC a player is missing that a definition requires. Null if they have all.

## Returns

[IMyDLC](VRage.Game.ModAPI.IMyDLC)

The first DLC not available by the specifiedsteamId.if definition has no DLC, or the user has all of them.

## Parameters

* [MyDefinitionBase](VRage.Game.MyDefinitionBase) definition
* [ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6) steamId
