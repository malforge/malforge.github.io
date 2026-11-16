## Summary

```csharp
public IMyToolbarSlots GamepadSlots { get; }
```

The parallel set of slots a gamepad player uses. Null on a character toolbar, which has no gamepad slots a player can reach; check for it before use.  
  
 [SlotCount](VRage.Game.ModAPI.IMyToolbarSlots@SlotCount) is always four, whatever this toolbar's is, because a page maps to the four directions of a pad rather than to the owning block. Pages grow as a player fills them and only those up to the last filled slot survive a save, so do not store a gamepad slot index between sessions.

## Returns

[IMyToolbarSlots](VRage.Game.ModAPI.IMyToolbarSlots)

