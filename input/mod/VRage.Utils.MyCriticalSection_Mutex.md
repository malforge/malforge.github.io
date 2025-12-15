**Assembly:** VRage.dll

```csharp
public class MyCriticalSection_Mutex: ISharedCriticalSection, IDisposable
```

## Constructors

|Member|Description|
|---|---|
|[MyCriticalSection_Mutex()](VRage.Utils.MyCriticalSection_Mutex@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Dispose()](VRage.Utils.MyCriticalSection_Mutex@Dispose)||
|[EnterShared()](VRage.Utils.MyCriticalSection_Mutex@EnterShared)||
|[EnterUnique()](VRage.Utils.MyCriticalSection_Mutex@EnterUnique)||
|[LeaveShared_Internal()](VRage.Utils.MyCriticalSection_Mutex@LeaveShared_Internal)||
|[LeaveUnique_Internal()](VRage.Utils.MyCriticalSection_Mutex@LeaveUnique_Internal)||

**Implements:**  
* [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable?view=netframework-4.6)  
* ISharedCriticalSection <sub>prohibited</sub>

