## Summary

```csharp
public void TriggerCharacterAnimationEvent(string eventName, bool sync)
```

Trigger animation event in the new animation system. If there is a transition leading from current animation state having same name as this event, animation state machine will change state accordingly. If not, nothing happens.

## Parameters

* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) eventName
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) sync
