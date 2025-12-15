**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyGridProgram
```

The interface for the grid program provides extra access for the game and for mods. See [MyGridProgram](Sandbox.ModAPI.Ingame.MyGridProgram) for the class the scripts actually derive from.

## Properties

|Member|Description|
|---|---|
|[Echo](Sandbox.ModAPI.IMyGridProgram@Echo)|Gets or sets the action which prints out text onto the currently running programmable block's detail info area.|
|[GridTerminalSystem](Sandbox.ModAPI.IMyGridProgram@GridTerminalSystem)|Gets or sets the GridTerminalSystem available for the grid programs.|
|[HasMainMethod](Sandbox.ModAPI.IMyGridProgram@HasMainMethod)|Determines whether this grid program has a valid Main method.|
|[HasSaveMethod](Sandbox.ModAPI.IMyGridProgram@HasSaveMethod)|Determines whether this grid program has a valid Save method.|
|[IGC_ContextGetter](Sandbox.ModAPI.IMyGridProgram@IGC_ContextGetter)|Sets provider for [IMyIntergridCommunicationSystem](Sandbox.ModAPI.Ingame.IMyIntergridCommunicationSystem) |
|[Me](Sandbox.ModAPI.IMyGridProgram@Me)|Gets or sets the programmable block which is currently running this grid program.|
|[Runtime](Sandbox.ModAPI.IMyGridProgram@Runtime)|Gets or sets the object used to provide runtime information for the running grid program.|
|[Storage](Sandbox.ModAPI.IMyGridProgram@Storage)|Gets or sets the storage string for this grid program.|
|[World](Sandbox.ModAPI.IMyGridProgram@World)|Gets or sets the object used to provide world information for the running grid progrma.|

## Methods

|Member|Description|
|---|---|
|[Main(string, UpdateType)](Sandbox.ModAPI.IMyGridProgram@Main)|Invokes this grid program with the given update source.|
|[Save()](Sandbox.ModAPI.IMyGridProgram@Save)|If this grid program has state saving capability, calling this method will invoke it.|
|[Main(string)](Sandbox.ModAPI.IMyGridProgram@Main)|_**Obsolete:** Use overload Main(String, UpdateType)_<br /><br />Invokes this grid program.|

**Inheritors:**  
* [MyGridProgram](Sandbox.ModAPI.Ingame.MyGridProgram)

