## Summary

```csharp
public static void ChangeUpdate(MyGameLogicComponent component, MyEntityUpdateEnum newUpdate, bool immediate)
```

Modifies a component's update flags without modifying lists the component is already in. Much more performant than Unregister/Register pattern!

## Parameters

* [MyGameLogicComponent](VRage.Game.Components.MyGameLogicComponent) component
* [MyEntityUpdateEnum](VRage.ModAPI.MyEntityUpdateEnum) newUpdate
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) immediate
