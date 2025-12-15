**Assembly:** VRage.Game.dll

```csharp
public sealed class MyContractUpdateDelegate: MulticastDelegate, ICloneable, ISerializable
```

Delegate used for custom update event.

## Constructors

|Member|Description|
|---|---|
|[MyContractUpdateDelegate(object, IntPtr)](VRage.Game.ModAPI.MyContractUpdateDelegate@.ctor)||

## Methods

|Member|Description|
|---|---|
|[BeginInvoke(long, MyCustomContractStateEnum, MyTimeSpan, AsyncCallback, object)](VRage.Game.ModAPI.MyContractUpdateDelegate@BeginInvoke)||
|[EndInvoke(IAsyncResult)](VRage.Game.ModAPI.MyContractUpdateDelegate@EndInvoke)||
|[Invoke(long, MyCustomContractStateEnum, MyTimeSpan)](VRage.Game.ModAPI.MyContractUpdateDelegate@Invoke)||

**Inheritance:**   MulticastDelegate <sub>prohibited</sub>

**Implements:**  
* ICloneable <sub>prohibited</sub>  
* ISerializable <sub>prohibited</sub>

