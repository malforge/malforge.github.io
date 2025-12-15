## Summary

```csharp
public void ModifyContentForRifle(MyPhysicalInventoryItem item, Action<MyObjectBuilder_PhysicalObject> action, bool cloneIsForRestOfStack)
```

Other way of ModifyContent, it is created specifically for MyAutomaticRifleGun because of complexity of callbacks. Instead it would not force sync

## Parameters

* [MyPhysicalInventoryItem](VRage.Game.Entity.MyPhysicalInventoryItem) item
* [Action<MyObjectBuilder_PhysicalObject>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6) action
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) cloneIsForRestOfStack
