## Summary

```csharp
public static bool TryParse(string id, out MyDefinitionId definitionId)
```

Attempts to create a definition ID from a definition string, which has the form (using ores as an example) "MyObjectBuilder_Ore/Iron". The first part must represent an existing type, while the second (the subtype) is not enforced.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) id
* [MyDefinitionId](VRage.Game.MyDefinitionId) definitionId
## Summary

```csharp
public static bool TryParse(string type, string subtype, out MyDefinitionId definitionId)
```

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) type
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) subtype
* [MyDefinitionId](VRage.Game.MyDefinitionId) definitionId
