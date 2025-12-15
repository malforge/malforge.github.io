**Assembly:** Sandbox.Common.dll

```csharp
public abstract class MyGridProgram: IMyGridProgram
```

All programmable block scripts derive from this class, meaning that all properties in this class are directly available for use in your scripts. If you use Visual Studio or other external editors to write your scripts, you can derive directly from this class and have a compatible script template.

## Example

```csharp  
public void Main()  
{  
    // Print out the time elapsed since the currently running programmable block was run  
    // the last time.  
    Echo(Me.CustomName + " was last run " + Runtime.TimeSinceLastRun.TotalSeconds + " seconds ago.");  
}  
  
```

## Properties

|Member|Description|
|---|---|
|[Echo](Sandbox.ModAPI.Ingame.MyGridProgram@Echo)|Prints out text onto the currently running programmable block's detail info area.|
|[GridTerminalSystem](Sandbox.ModAPI.Ingame.MyGridProgram@GridTerminalSystem)|Provides access to the grid terminal system as viewed from this programmable block.|
|[IGC](Sandbox.ModAPI.Ingame.MyGridProgram@IGC)|Gets IGC instance|
|[Me](Sandbox.ModAPI.Ingame.MyGridProgram@Me)|Gets a reference to the currently running programmable block.|
|[Runtime](Sandbox.ModAPI.Ingame.MyGridProgram@Runtime)|Gets runtime information for the running grid program.|
|[Storage](Sandbox.ModAPI.Ingame.MyGridProgram@Storage)|Allows you to store data between game sessions.|
|[World](Sandbox.ModAPI.Ingame.MyGridProgram@World)|Gets world information for the running grid program.|
|[Echo](Sandbox.ModAPI.IMyGridProgram@Echo)|Gets or sets the action which prints out text onto the currently running programmable block's detail info area.<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|
|[GridTerminalSystem](Sandbox.ModAPI.IMyGridProgram@GridTerminalSystem)|Gets or sets the GridTerminalSystem available for the grid programs.<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|
|[HasMainMethod](Sandbox.ModAPI.IMyGridProgram@HasMainMethod)|Determines whether this grid program has a valid Main method.<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|
|[HasSaveMethod](Sandbox.ModAPI.IMyGridProgram@HasSaveMethod)|Determines whether this grid program has a valid Save method.<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|
|[IGC_ContextGetter](Sandbox.ModAPI.IMyGridProgram@IGC_ContextGetter)|Sets provider for [IMyIntergridCommunicationSystem](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem)<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|
|[Me](Sandbox.ModAPI.IMyGridProgram@Me)|Gets or sets the programmable block which is currently running this grid program.<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|
|[Runtime](Sandbox.ModAPI.IMyGridProgram@Runtime)|Gets or sets the object used to provide runtime information for the running grid program.<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|
|[Storage](Sandbox.ModAPI.IMyGridProgram@Storage)|Gets or sets the storage string for this grid program.<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|
|[World](Sandbox.ModAPI.IMyGridProgram@World)|Gets or sets the object used to provide world information for the running grid progrma.<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|

## Methods

|Member|Description|
|---|---|
|[Main(string, UpdateType)](Sandbox.ModAPI.IMyGridProgram@Main)|Invokes this grid program with the given update source.<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|
|[Save()](Sandbox.ModAPI.IMyGridProgram@Save)|If this grid program has state saving capability, calling this method will invoke it.<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|
|[Main(string)](Sandbox.ModAPI.IMyGridProgram@Main)|_**Obsolete:** Use overload Main(String, UpdateType)_<br /><br />Invokes this grid program.<br /><br />_Inherited from [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)_|

**Implements:**  
* [IMyGridProgram](Sandbox.ModAPI.IMyGridProgram)

