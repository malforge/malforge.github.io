## Summary

```csharp
public bool TryGetMission(long id, out IMyBasicMissionComponent mission)
```

Gets instance of mission by id. This method return basic interface for mission. Retype it to specific mission interface to get API for it.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

selected mission

## Parameters

* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) id
* [IMyBasicMissionComponent](Sandbox.ModAPI.IMyBasicMissionComponent) mission
