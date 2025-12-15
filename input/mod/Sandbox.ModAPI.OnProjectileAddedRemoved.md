**Assembly:** Sandbox.Common.dll

```csharp
public sealed class OnProjectileAddedRemoved: MulticastDelegate, ICloneable, ISerializable
```

Index is used to get position of projectile Projectile can change it index, when it's index == projectilesCount - 1

## Constructors

|Member|Description|
|---|---|
|[OnProjectileAddedRemoved(object, IntPtr)](Sandbox.ModAPI.OnProjectileAddedRemoved@.ctor)||

## Methods

|Member|Description|
|---|---|
|[BeginInvoke(ref MyProjectileInfo, int, AsyncCallback, object)](Sandbox.ModAPI.OnProjectileAddedRemoved@BeginInvoke)||
|[EndInvoke(ref MyProjectileInfo, IAsyncResult)](Sandbox.ModAPI.OnProjectileAddedRemoved@EndInvoke)||
|[Invoke(ref MyProjectileInfo, int)](Sandbox.ModAPI.OnProjectileAddedRemoved@Invoke)||

**Inheritance:**   MulticastDelegate <sub>prohibited</sub>

**Implements:**  
* ICloneable <sub>prohibited</sub>  
* ISerializable <sub>prohibited</sub>

