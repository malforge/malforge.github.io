## Summary

```csharp
public Action<MyFactionStateChange, long, long, long, long> event FactionStateChanged
```

Called when on of factions changed Arguments: action, fromFactionId, faction Id toFactionId, faction Id, or 0 playerId - IdentityId on whom action was applied, or 0 senderId - IdentityId who triggered state change, or 0

## Returns

[Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-5?view=netframework-4.6)&lt;[MyFactionStateChange](VRage.Game.ModAPI.MyFactionStateChange), [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6), [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6), [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6), [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6)&gt;

