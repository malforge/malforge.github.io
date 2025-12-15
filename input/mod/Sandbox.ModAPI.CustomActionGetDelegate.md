**Assembly:** Sandbox.Common.dll

```csharp
public sealed class CustomActionGetDelegate: MulticastDelegate, ICloneable, ISerializable
```

Allows you to modify the actions associated with a block before it's displayed to user.

## Constructors

|Member|Description|
|---|---|
|[CustomActionGetDelegate(object, IntPtr)](Sandbox.ModAPI.CustomActionGetDelegate@.ctor)||

## Methods

|Member|Description|
|---|---|
|[BeginInvoke(IMyTerminalBlock, List<IMyTerminalAction>, AsyncCallback, object)](Sandbox.ModAPI.CustomActionGetDelegate@BeginInvoke)||
|[EndInvoke(IAsyncResult)](Sandbox.ModAPI.CustomActionGetDelegate@EndInvoke)||
|[Invoke(IMyTerminalBlock, List<IMyTerminalAction>)](Sandbox.ModAPI.CustomActionGetDelegate@Invoke)||

**Inheritance:**   MulticastDelegate <sub>prohibited</sub>

**Implements:**  
* ICloneable <sub>prohibited</sub>  
* ISerializable <sub>prohibited</sub>

