## Summary

```csharp
public void PlayHitEffects(MySoundPair hitSound, MySoundPair glitchSound)
```

The cues are defined on the emitter rather than here, which is why they are handed in instead of being read from a definition of this component. The looped one is kept, it outlives the discharge that sent it.

## Parameters

* [MySoundPair](Sandbox.Game.Entities.MySoundPair) hitSound
* [MySoundPair](Sandbox.Game.Entities.MySoundPair) glitchSound
