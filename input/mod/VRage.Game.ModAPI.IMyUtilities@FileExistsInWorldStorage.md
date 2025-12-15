## Summary

```csharp
public bool FileExistsInWorldStorage(string file, Type callingType)
```

Checks if file exists in world save %APPDATA%/Roaming/SpaceEngineers/Save/{SteamId}/{WorldName}/Storage/{Assembly Scope} Where {Assembly Scope} - callingType.Assembly.ManifestModule.ScopeName

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

True if file exists

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) file
* [Type](https://docs.microsoft.com/en-us/dotnet/api/System.Type?view=netframework-4.6) callingType
