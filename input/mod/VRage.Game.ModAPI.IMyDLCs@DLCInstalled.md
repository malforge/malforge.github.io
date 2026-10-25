## Summary

```csharp
public Action<ulong, uint> event DLCInstalled
```

Called when a new DLC is installed by a client. On the client, this only reports DLC installed on the local client.

## Returns

[Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6)&lt;[ulong](https://docs.microsoft.com/en-us/dotnet/api/System.UInt64?view=netframework-4.6), [uint](https://docs.microsoft.com/en-us/dotnet/api/System.UInt32?view=netframework-4.6)&gt;

## Remarks

The first action argument is the client SteamId. The second argument is the DLC AppId. This event will be called on the server each time a player connects.  
  
Note:Space Engineers 2013 is AppId 573900  
  
Deluxe Edition Artwork is AppId 573161  
  
Neither of the above DLC are present in the list returned by [GetDLCs()](VRage.Game.ModAPI.IMyDLCs@GetDLCs) . In addition, [GetDLC(uint)](VRage.Game.ModAPI.IMyDLCs@GetDLC) will throw [KeyNotFoundException](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.keynotfoundexception?view=netframework-4.6) when passed either of those AppIds.

