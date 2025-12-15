**Assembly:** VRage.Library.dll

```csharp
public sealed class FastResourceLock: IDisposable, IResourceLock
```

## Properties

|Member|Description|
|---|---|
|[ExclusiveWaiters](VRage.FastResourceLock@ExclusiveWaiters)||
|[Owned](VRage.FastResourceLock@Owned)||
|[SharedOwners](VRage.FastResourceLock@SharedOwners)||
|[SharedWaiters](VRage.FastResourceLock@SharedWaiters)||

## Constructors

|Member|Description|
|---|---|
|[FastResourceLock()](VRage.FastResourceLock@.ctor)||

## Methods

|Member|Description|
|---|---|
|[AcquireExclusive()](VRage.FastResourceLock@AcquireExclusive)||
|[AcquireShared()](VRage.FastResourceLock@AcquireShared)||
|[ConvertExclusiveToShared()](VRage.FastResourceLock@ConvertExclusiveToShared)||
|[Dispose()](VRage.FastResourceLock@Dispose)||
|[ReleaseExclusive()](VRage.FastResourceLock@ReleaseExclusive)||
|[ReleaseShared()](VRage.FastResourceLock@ReleaseShared)||
|[SpinAcquireExclusive()](VRage.FastResourceLock@SpinAcquireExclusive)||
|[SpinAcquireShared()](VRage.FastResourceLock@SpinAcquireShared)||
|[SpinConvertSharedToExclusive()](VRage.FastResourceLock@SpinConvertSharedToExclusive)||
|[TryAcquireExclusive()](VRage.FastResourceLock@TryAcquireExclusive)||
|[TryAcquireShared()](VRage.FastResourceLock@TryAcquireShared)||
|[TryConvertSharedToExclusive()](VRage.FastResourceLock@TryConvertSharedToExclusive)||
|[AcquireExclusive()](VRage.IResourceLock@AcquireExclusive)|Acquires the lock in exclusive mode, blocking if necessary.<br /><br />_Inherited from [IResourceLock](VRage.IResourceLock)_|
|[AcquireShared()](VRage.IResourceLock@AcquireShared)|Acquires the lock in shared mode, blocking if necessary.<br /><br />_Inherited from [IResourceLock](VRage.IResourceLock)_|
|[ReleaseExclusive()](VRage.IResourceLock@ReleaseExclusive)|Releases the lock in exclusive mode.<br /><br />_Inherited from [IResourceLock](VRage.IResourceLock)_|
|[ReleaseShared()](VRage.IResourceLock@ReleaseShared)|Releases the lock in shared mode.<br /><br />_Inherited from [IResourceLock](VRage.IResourceLock)_|
|[TryAcquireExclusive()](VRage.IResourceLock@TryAcquireExclusive)|Attempts to acquire the lock in exclusive mode.<br /><br />_Inherited from [IResourceLock](VRage.IResourceLock)_|
|[TryAcquireShared()](VRage.IResourceLock@TryAcquireShared)|Attempts to acquire the lock in shared mode.<br /><br />_Inherited from [IResourceLock](VRage.IResourceLock)_|

**Implements:**  
* [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable?view=netframework-4.6)  
* [IResourceLock](VRage.IResourceLock)

