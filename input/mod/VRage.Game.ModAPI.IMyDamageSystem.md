**Assembly:** VRage.Game.dll

```csharp
public interface IMyDamageSystem
```

Mod API interface allowing you handle damage events

## Methods

|Member|Description|
|---|---|
|[RaiseAfterDamageApplied(object, MyDamageInformation)](VRage.Game.ModAPI.IMyDamageSystem@RaiseAfterDamageApplied)|Allowing mods, to raise `AfterDamageApplied` event|
|[RaiseBeforeDamageApplied(object, ref MyDamageInformation)](VRage.Game.ModAPI.IMyDamageSystem@RaiseBeforeDamageApplied)|Allowing mods, to raise `BeforeDamageApplied` event|
|[RegisterAfterDamageHandler(int, Action<object, MyDamageInformation>)](VRage.Game.ModAPI.IMyDamageSystem@RegisterAfterDamageHandler)|Registers a handler that is called after an object in game is damaged.|
|[RegisterBeforeDamageHandler(int, BeforeDamageApplied)](VRage.Game.ModAPI.IMyDamageSystem@RegisterBeforeDamageHandler)|Registers a handler that is called before an object in game is damaged. The damage can be modified in this handler.|
|[RegisterDestroyHandler(int, Action<object, MyDamageInformation>)](VRage.Game.ModAPI.IMyDamageSystem@RegisterDestroyHandler)|Registers a handler for when an object in game is destroyed.|

