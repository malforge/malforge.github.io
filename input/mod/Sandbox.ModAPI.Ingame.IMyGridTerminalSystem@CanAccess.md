## Summary

```csharp
public bool CanAccess(IMyTerminalBlock block, MyTerminalAccessScope scope)
```

Checks if the grid terminal system can still access the given [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock) . A block is no longer accessible if it's destroyed, detached, it's ownership has changed or is otherwise disconnected from this grid terminal system.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)



## Parameters

* [IMyTerminalBlock](Sandbox.ModAPI.Ingame.IMyTerminalBlock) block
* [MyTerminalAccessScope](Sandbox.ModAPI.Ingame.MyTerminalAccessScope) scope
## Summary

```csharp
public bool CanAccess(IMyCubeGrid grid, MyTerminalAccessScope scope)
```

Checks if the grid terminal system can still access the given [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid) . A grid is no longer accessible if it's destroyed, detached, it's ownership has changed or is otherwise disconnected from this grid terminal system.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

False if grid is`null`, closed or you can't access that grid

## Parameters

* [IMyCubeGrid](VRage.Game.ModAPI.Ingame.IMyCubeGrid) grid
* [MyTerminalAccessScope](Sandbox.ModAPI.Ingame.MyTerminalAccessScope) scope
