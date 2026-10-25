## Summary

```csharp
public Func<float> SetRequiredInputFuncByType(MyDefinitionId resourceTypeId, Func<float> newRequiredInputFunc)
```

Change the required input function (callback) for given type of resource. It does not call it immediately to update required input value.

## Returns

[Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1?view=netframework-4.6)&lt;[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)&gt;

## Parameters

* [MyDefinitionId](VRage.Game.MyDefinitionId) resourceTypeId
* [Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1?view=netframework-4.6)&lt;[float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6)&gt; newRequiredInputFunc
