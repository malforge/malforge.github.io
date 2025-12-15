## Summary

```csharp
public Action<IMyMotorBase> event AttachedEntityChanged
```

When the rotor head is attached or detached from the base

## Returns

[Action<IMyMotorBase>](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6)

## Remarks

This event can be called in three states:Stator is detached from rotor, Stator is looking for rotor attachment, Stator is attached to rotorThe looking and attached states will both returnfor [IsAttached](Sandbox.ModAPI.Ingame.IMyMechanicalConnectionBlock@IsAttached) . To determine which state it is, use the [PendingAttachment](Sandbox.ModAPI.Ingame.IMyMechanicalConnectionBlock@PendingAttachment) property:means awaiting attachment,means the rotor is attached.

