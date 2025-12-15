**Assembly:** VRage.Game.dll

```csharp
public class MyCommandLine
```

A utility class to parse arguments from a command line string. Switches are defined with hyphen (-switch). Quotes can be placed around an argument to parse verbatim, but inner quotes will be copied verbatim. For example, "one"two" will result in the string one"two.

## Properties

|Member|Description|
|---|---|
|[ArgumentCount](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine@ArgumentCount)|Returns the number of non-switch arguments|
|[Items](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine@Items)|Contains all items, both arguments and switches|
|[Switches](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine@Switches)|Contains a list of all detected switches|

## Constructors

|Member|Description|
|---|---|
|[MyCommandLine()](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Argument(int)](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine@Argument)|Returns the argument at the given index. Switches are not counted.|
|[Clear()](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine@Clear)|Clears all arguments|
|[Switch(string)](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine@Switch)|Determines whether the given switch is set. Switches are specified without their prefixed hyphen.|
|[Switch(string, int)](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine@Switch)|Gets an argument of a switch. For example, using`Switch("key", 0)`on the command line`someOtherArgument -key value`will return`value`.|
|[TryParse(string)](VRage.Game.ModAPI.Ingame.Utilities.MyCommandLine@TryParse)|Attempts to parse the given string as a command line|

