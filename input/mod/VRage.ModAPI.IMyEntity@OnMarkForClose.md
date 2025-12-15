## Summary

```csharp
public Action<IMyEntity> event OnMarkForClose
```

Called when [Close()](VRage.ModAPI.IMyEntity@Close) is called. Order 1) [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) 2) [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) 3) [OnClose](VRage.ModAPI.IMyEntity@OnClose) .

## Returns

[Action<IMyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6)

## Remarks

Modders should prefer [OnMarkForClose](VRage.ModAPI.IMyEntity@OnMarkForClose) or [OnClosing](VRage.ModAPI.IMyEntity@OnClosing) . This event may not be invoked at all, when calling MyEntities.CloseAll, marking is bypassed

