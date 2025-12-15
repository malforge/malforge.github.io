**Assembly:** Sandbox.Common.dll

```csharp
public sealed class MissileMoveDelegate: MulticastDelegate, ICloneable, ISerializable
```

Missile Move delegate

## Constructors

|Member|Description|
|---|---|
|[MissileMoveDelegate(object, IntPtr)](Sandbox.ModAPI.MissileMoveDelegate@.ctor)||

## Methods

|Member|Description|
|---|---|
|[BeginInvoke(IMyMissile, ref Vector3, AsyncCallback, object)](Sandbox.ModAPI.MissileMoveDelegate@BeginInvoke)||
|[EndInvoke(ref Vector3, IAsyncResult)](Sandbox.ModAPI.MissileMoveDelegate@EndInvoke)||
|[Invoke(IMyMissile, ref Vector3)](Sandbox.ModAPI.MissileMoveDelegate@Invoke)||

**Inheritance:**   MulticastDelegate <sub>prohibited</sub>

**Implements:**  
* ICloneable <sub>prohibited</sub>  
* ISerializable <sub>prohibited</sub>

