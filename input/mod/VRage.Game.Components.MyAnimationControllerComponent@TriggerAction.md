## Summary

```csharp
public void TriggerAction(MyStringId actionName, String[] layers)
```

Trigger an action in the layers specified. If no layers are specified, it is triggered for all instead. If there is a transition having given (non-null) name, it is followed immediatelly. Conditions of transition are ignored. This is a shortcut to Controller.TriggerAction.

## Parameters

* [MyStringId](VRage.Utils.MyStringId) actionName
* String[] <sub>prohibited</sub> layers
