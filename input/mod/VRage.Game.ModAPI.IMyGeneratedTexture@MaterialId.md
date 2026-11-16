## Summary

```csharp
public MyStringId MaterialId { get; }
```

 [Name](VRage.Game.ModAPI.IMyGeneratedTexture@Name) as the id`Sandbox.ModAPI.MyScreenSpaceSprite`takes, interned once here rather than per call —`MyStringId.GetOrCompute`never releases what it interns, and every texture gets a name of its own. [NullOrEmpty](VRage.Utils.MyStringId@NullOrEmpty) once the texture has been disposed.

## Returns

[MyStringId](VRage.Utils.MyStringId)

