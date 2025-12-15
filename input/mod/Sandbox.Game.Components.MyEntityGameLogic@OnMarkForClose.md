## Summary

```csharp
public Action<MyEntity> event OnMarkForClose
```

This event may not be invoked at all, when calling MyEntities.CloseAll, marking is bypassed

## Returns

[Action<MyEntity>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6)

