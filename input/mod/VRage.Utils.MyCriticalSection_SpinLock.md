**Assembly:** VRage.dll

```csharp
public class MyCriticalSection_SpinLock: ISharedCriticalSection, IDisposable
```

## Constructors

|Member|Description|
|---|---|
|[MyCriticalSection_SpinLock()](VRage.Utils.MyCriticalSection_SpinLock@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Dispose()](VRage.Utils.MyCriticalSection_SpinLock@Dispose)||
|[EnterShared()](VRage.Utils.MyCriticalSection_SpinLock@EnterShared)||
|[EnterUnique()](VRage.Utils.MyCriticalSection_SpinLock@EnterUnique)||
|[LeaveShared_Internal()](VRage.Utils.MyCriticalSection_SpinLock@LeaveShared_Internal)||
|[LeaveUnique_Internal()](VRage.Utils.MyCriticalSection_SpinLock@LeaveUnique_Internal)||

**Implements:**  
* [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable?view=netframework-4.6)  
* ISharedCriticalSection <sub>prohibited</sub>

