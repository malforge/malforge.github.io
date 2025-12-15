## Summary

```csharp
public void SetSeed(int Seed)
```

Sets new seed, only use this method when you have separate instance of MyRandom. Setting seed for RNG used for EntityId without reverting to previous state is dangerous. Use PushSeed for EntityId random generator.

## Parameters

* [int](https://docs.microsoft.com/en-us/dotnet/api/System.Int32?view=netframework-4.6) Seed
