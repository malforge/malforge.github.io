## Summary

```csharp
public void SetResourceDisrupted(MyDefinitionId typeId, bool disrupted)
```

Suppresses distribution of the given resource until it is cleared again, leaving every sink and source at zero. Electricity only, other types keep distributing.

## Parameters

* [MyDefinitionId](VRage.Game.MyDefinitionId) typeId
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) disrupted
