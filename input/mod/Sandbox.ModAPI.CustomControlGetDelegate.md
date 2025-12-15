**Assembly:** Sandbox.Common.dll

```csharp
public sealed class CustomControlGetDelegate: MulticastDelegate, ICloneable, ISerializable
```

Allows you to modify the terminal control list before it is displayed to the user. Modifying controls will change which controls are displayed.

## Constructors

|Member|Description|
|---|---|
|[CustomControlGetDelegate(object, IntPtr)](Sandbox.ModAPI.CustomControlGetDelegate@.ctor)||

## Methods

|Member|Description|
|---|---|
|[BeginInvoke(IMyTerminalBlock, List<IMyTerminalControl>, AsyncCallback, object)](Sandbox.ModAPI.CustomControlGetDelegate@BeginInvoke)||
|[EndInvoke(IAsyncResult)](Sandbox.ModAPI.CustomControlGetDelegate@EndInvoke)||
|[Invoke(IMyTerminalBlock, List<IMyTerminalControl>)](Sandbox.ModAPI.CustomControlGetDelegate@Invoke)||

**Inheritance:**   MulticastDelegate <sub>prohibited</sub>

**Implements:**  
* ICloneable <sub>prohibited</sub>  
* ISerializable <sub>prohibited</sub>

