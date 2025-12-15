**Assembly:** Sandbox.Common.dll

```csharp
public interface ITerminalProperty<TValue>: ITerminalProperty
```

## Properties

|Member|Description|
|---|---|
|[Id](Sandbox.ModAPI.Interfaces.ITerminalProperty@Id)|Property Id (value name)<br /><br />_Inherited from [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)_|
|[TypeName](Sandbox.ModAPI.Interfaces.ITerminalProperty@TypeName)|Property type (bool - [bool](https://docs.microsoft.com/en-us/dotnet/api/system.boolean?view=netframework-4.6) , float - [float](https://docs.microsoft.com/en-us/dotnet/api/system.single?view=netframework-4.6) , color - [Color](VRageMath.Color) )<br /><br />_Inherited from [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)_|

## Methods

|Member|Description|
|---|---|
|[GetDefaultValue(IMyCubeBlock)](Sandbox.ModAPI.Interfaces.ITerminalProperty{TValue}@GetDefaultValue)||
|[GetMaximum(IMyCubeBlock)](Sandbox.ModAPI.Interfaces.ITerminalProperty{TValue}@GetMaximum)||
|[GetMinimum(IMyCubeBlock)](Sandbox.ModAPI.Interfaces.ITerminalProperty{TValue}@GetMinimum)||
|[GetValue(IMyCubeBlock)](Sandbox.ModAPI.Interfaces.ITerminalProperty{TValue}@GetValue)||
|[SetValue(IMyCubeBlock, TValue)](Sandbox.ModAPI.Interfaces.ITerminalProperty{TValue}@SetValue)||
|[GetMininum(IMyCubeBlock)](Sandbox.ModAPI.Interfaces.ITerminalProperty{TValue}@GetMininum)|_**Obsolete:** Use GetMinimum instead_|

**Implements:**  
* [ITerminalProperty](Sandbox.ModAPI.Interfaces.ITerminalProperty)

