## Summary

```csharp
public Func<long, long, MyActivationCustomResults> CustomCanActivateContract { get; set; }
```

Gets or sets function that is triggered when player trying to take contract First argument - ContractId, Second - IdentityId

## Returns

[Func](https://docs.microsoft.com/en-us/dotnet/api/System.Func-3?view=netframework-4.6)&lt;[long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6), [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6), [MyActivationCustomResults](VRage.Game.ModAPI.MyActivationCustomResults)&gt;

