## Summary

```csharp
public Action<IUserCustomizableTerminalAction, Action<bool>> DoUserParameterRequestWithItem { get; set; }
```

Asks the player for the arguments when they put this action in a toolbar slot. Show your own screen from here, as the programmable block's Run does. Leave it null and the action is placed with the values its definitions carry.  
  
The item's Parameters are already sized to [ParameterDefinitions](Sandbox.ModAPI.Interfaces.Terminal.IMyTerminalAction@ParameterDefinitions) and hold those values, so assign by index. Call back true when they are set, or false if the player cancelled; a cancel is only honoured on some of the ways an item can be placed, so leave Parameters holding what the slot should get either way.

## Returns

[Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-2?view=netframework-4.6)&lt;[IUserCustomizableTerminalAction](Sandbox.ModAPI.Ingame.IUserCustomizableTerminalAction), [Action](https://docs.microsoft.com/en-us/dotnet/api/System.Action-1?view=netframework-4.6)&lt;[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)&gt;&gt;

