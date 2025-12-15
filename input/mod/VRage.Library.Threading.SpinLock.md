**Assembly:** VRage.Library.dll

```csharp
public struct SpinLock
```

A struct which implements a spin lock.

## Methods

|Member|Description|
|---|---|
|[Enter()](VRage.Library.Threading.SpinLock@Enter)|Enters the lock. The calling thread will spin wait until it gains ownership of the lock.|
|[Exit()](VRage.Library.Threading.SpinLock@Exit)|Exits the lock. This allows other threads to take ownership of the lock.|
|[TryEnter()](VRage.Library.Threading.SpinLock@TryEnter)|Tries to enter the lock.|

