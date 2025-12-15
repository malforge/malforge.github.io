## Summary

```csharp
public virtual bool ReceivedDamage(float damage, MyStringHash damageType, long attackerId, long realHitEntityId, bool shouldDetonateAmmo, MyStringHash? extraInfo)
```

Block received damage from any source.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

Returns true if damage should be inflicted upon the block normally.

## Parameters

* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) damage
* [MyStringHash](VRage.Utils.MyStringHash) damageType
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) attackerId
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) realHitEntityId
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) shouldDetonateAmmo
* [MyStringHash?](https://docs.microsoft.com/en-us/dotnet/api/System.Nullable-1?view=netframework-4.6) extraInfo
