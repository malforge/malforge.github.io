## Summary

```csharp
public Action<IMyEntity> event OnClose
```

Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .

## Returns

[Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6)&lt;[IMyEntity](VRage.ModAPI.IMyEntity)&gt;

## Remarks

Modders should prefer [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) or [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 

