## Summary

```csharp
public bool ShowOnHud { get; set; }
```

Gets or sets whether GPS should be visible on HUD

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

## Remarks

Set method doesn't synchronize data over network. Use [ModifyGps(long, IMyGps)](VRage.Game.ModAPI.IMyGpsCollection@ModifyGps) , to update data

