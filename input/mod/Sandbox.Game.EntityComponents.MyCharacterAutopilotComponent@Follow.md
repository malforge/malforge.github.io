## Summary

```csharp
public void Follow(MyEntity entity, float distance)
```

Follows the entity at the given radial distance, velocity-matched while station-keeping. Never self-completes; a dead or closed target degrades to a brake-and-hold.

## Parameters

* [MyEntity](VRage.Game.Entity.MyEntity) entity
* [float](https://docs.microsoft.com/en-us/dotnet/api/System.Single?view=netframework-4.6) distance
