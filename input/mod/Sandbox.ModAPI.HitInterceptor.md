**Assembly:** Sandbox.Common.dll

```csharp
public sealed class HitInterceptor: MulticastDelegate, ICloneable, ISerializable
```

Provide information about projectiles hit.

## Constructors

|Member|Description|
|---|---|
|[HitInterceptor(object, IntPtr)](Sandbox.ModAPI.HitInterceptor@.ctor)||

## Methods

|Member|Description|
|---|---|
|[BeginInvoke(ref MyProjectileInfo, ref MyProjectileHitInfo, AsyncCallback, object)](Sandbox.ModAPI.HitInterceptor@BeginInvoke)||
|[EndInvoke(ref MyProjectileInfo, ref MyProjectileHitInfo, IAsyncResult)](Sandbox.ModAPI.HitInterceptor@EndInvoke)||
|[Invoke(ref MyProjectileInfo, ref MyProjectileHitInfo)](Sandbox.ModAPI.HitInterceptor@Invoke)||

**Inheritance:**   MulticastDelegate <sub>prohibited</sub>

**Implements:**  
* ICloneable <sub>prohibited</sub>  
* ISerializable <sub>prohibited</sub>

