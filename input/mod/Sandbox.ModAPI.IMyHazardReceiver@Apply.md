## Summary

```csharp
public void Apply(float amount, MyStringHash statId, MyStringHash damageType)
```

Affects corresponding entity stat. Does not check admin protection. For Radiation, checks immunity stat. Positive value increases stat (except Health, which is reduced by positive damage value).

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) amount
* [MyStringHash](VRage.Utils.MyStringHash) statId
* [MyStringHash](VRage.Utils.MyStringHash) damageType
