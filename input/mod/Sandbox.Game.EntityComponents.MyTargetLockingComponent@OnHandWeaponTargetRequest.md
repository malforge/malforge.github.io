## Summary

```csharp
public void OnHandWeaponTargetRequest(MyEntity target, bool playStartSound)
```

Asks the server to start lockingtargetfrom a hand weapon, which holds its lock by keeping the sights up rather than by a button press. A repeat for the same target is therefore a retry, not an unlock, and stays silent - the server refuses without a reply, so an unconditional start sound would chirp on every retry.

## Parameters

* [MyEntity](VRage.Game.Entity.MyEntity) target
* [bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6) playStartSound
