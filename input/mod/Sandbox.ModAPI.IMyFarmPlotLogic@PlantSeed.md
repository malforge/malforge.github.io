## Summary

```csharp
public bool PlantSeed(MyDefinitionId seedItemDefinitionId)
```

Plants a given seed and starts growing the plant. It is the responsibility of the caller to handle inventory management. This method will just plant the seed from the definition with the necessary amount. Only works when called from the server.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

Whether the action completed successfully.

## Parameters

* [MyDefinitionId](VRage.Game.MyDefinitionId) seedItemDefinitionId
