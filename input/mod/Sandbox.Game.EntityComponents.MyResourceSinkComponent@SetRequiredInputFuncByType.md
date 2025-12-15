## Summary

```csharp
public virtual Func<float> SetRequiredInputFuncByType(MyDefinitionId resourceTypeId, Func<float> newRequiredInputFunc)
```

Change the required input function (callback) for given type of resource. It does not call it immediatelly to update required input value.

## Returns

[Func<float>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1?view=netframework-4.6)

## Parameters

* [MyDefinitionId](VRage.Game.MyDefinitionId) resourceTypeId
* [Func<float>](https://docs.microsoft.com/en-us/dotnet/api/System.Func-1?view=netframework-4.6) newRequiredInputFunc
