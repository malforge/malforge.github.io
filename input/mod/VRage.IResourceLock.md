**Assembly:** VRage.Library.dll

```csharp
public interface IResourceLock
```

## Methods

|Member|Description|
|---|---|
|[AcquireExclusive()](VRage.IResourceLock@AcquireExclusive)|Acquires the lock in exclusive mode, blocking if necessary.|
|[AcquireShared()](VRage.IResourceLock@AcquireShared)|Acquires the lock in shared mode, blocking if necessary.|
|[ReleaseExclusive()](VRage.IResourceLock@ReleaseExclusive)|Releases the lock in exclusive mode.|
|[ReleaseShared()](VRage.IResourceLock@ReleaseShared)|Releases the lock in shared mode.|
|[TryAcquireExclusive()](VRage.IResourceLock@TryAcquireExclusive)|Attempts to acquire the lock in exclusive mode.|
|[TryAcquireShared()](VRage.IResourceLock@TryAcquireShared)|Attempts to acquire the lock in shared mode.|

**Inheritors:**  
* [FastResourceLock](VRage.FastResourceLock)

