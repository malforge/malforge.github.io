**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyMissiles
```

Interface for controlling missiles

## Events

|Member|Description|
|---|---|
|[OnMissileAdded](Sandbox.ModAPI.IMyMissiles@OnMissileAdded)|Called when missile was created|
|[OnMissileCollided](Sandbox.ModAPI.IMyMissiles@OnMissileCollided)|Called when missile hits something. May be more than 1 call per missile.|
|[OnMissileMoved](Sandbox.ModAPI.IMyMissiles@OnMissileMoved)|Called each frame after missile was moved|
|[OnMissileRemoved](Sandbox.ModAPI.IMyMissiles@OnMissileRemoved)|Called when missile was removed|

## Methods

|Member|Description|
|---|---|
|[GetAllMissilesInSphere(ref BoundingSphereD, List<MyEntity>)](Sandbox.ModAPI.IMyMissiles@GetAllMissilesInSphere)|Returns all missiles in sphere|
|[Remove(long)](Sandbox.ModAPI.IMyMissiles@Remove)|Removes missile with EntityId|

