## Summary

```csharp
public long GetSeekTargetEntityId(MyEntity controller)
```

Resolves the entity id a guided (CanSeek) missile fired now should home on; 0 means dumb-fire.

## Returns

[long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6)

Entity id to home on, or 0 when there is nothing to guide towards.

## Parameters

* [MyEntity](VRage.Game.Entity.MyEntity) controller
