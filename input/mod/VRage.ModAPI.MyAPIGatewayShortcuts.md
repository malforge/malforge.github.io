**Assembly:** VRage.Game.dll

```csharp
public abstract sealed class MyAPIGatewayShortcuts
```

Links to modapi actions. Delegates are set inside MyAPIGateway. VRAGE TODO: This is probably a temporary class helping us to remove sandbox.

## Fields

|Member|Description|
|---|---|
|[static GetLocalPlayerPosition](VRage.ModAPI.MyAPIGatewayShortcuts@GetLocalPlayerPosition)||
|[static GetMainCamera](VRage.ModAPI.MyAPIGatewayShortcuts@GetMainCamera)||
|[static GetWorldBoundaries](VRage.ModAPI.MyAPIGatewayShortcuts@GetWorldBoundaries)||
|[static RegisterEntityUpdate](VRage.ModAPI.MyAPIGatewayShortcuts@RegisterEntityUpdate)|Registers entity in update loop. Parameters: IMyEntity entity (ref to entity to be registered)|
|[static UnregisterEntityUpdate](VRage.ModAPI.MyAPIGatewayShortcuts@UnregisterEntityUpdate)|Unregisters entity from update loop. Parameters: IMyEntity entity (ref to entity to be unregistered), bool immediate (default is false)|

