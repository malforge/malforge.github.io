## Summary

```csharp
public static bool TryAddComponent(long entityId, MyDefinitionId componentDefinitionId)
```

This will look for the component definition and if found, it will create its instance and add to the entity with the give id

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

true on success

## Parameters

* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) entityId
* [MyDefinitionId](VRage.Game.MyDefinitionId) componentDefinitionId
## Summary

```csharp
public static bool TryAddComponent(long entityId, string instanceTypeStr, string componentTypeStr)
```

This will try to parse strings to types and create an instance of the component type. Don't use this in retail code, use for debug, modding etc.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

true on success

## Parameters

* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) entityId
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) instanceTypeStr
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) componentTypeStr
