## Summary

```csharp
public static int GetInitialPCU(MyObjectBuilder_SessionSettings settings)
```

If you are modifying this function, also modify MyBlockLimits.GetInitialPCU (This function cannot be moved into MyBlockLimits as using MyBlockLimits while MySession.Static == null will result in crash during intialization of statics of MyBlockLimits)

## Returns

[int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6)



## Parameters

* [MyObjectBuilder_SessionSettings](VRage.Game.MyObjectBuilder_SessionSettings) settings
