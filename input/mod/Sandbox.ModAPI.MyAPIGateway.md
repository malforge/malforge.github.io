**Assembly:** Sandbox.Common.dll

```csharp
public abstract sealed class MyAPIGateway
```

This is entry point for entire scripting possibilities in game

## Fields

|Member|Description|
|---|---|
|[static ContractSystem](Sandbox.ModAPI.MyAPIGateway@ContractSystem)|IMyContractSystem allows you add or edit contracts|
|[static CubeBuilder](Sandbox.ModAPI.MyAPIGateway@CubeBuilder)|IMyCubeBuilder represents building hand|
|[static DLC](Sandbox.ModAPI.MyAPIGateway@DLC)|Provides access for checking installation state of DLCs, and if DLC required by a definition is present.|
|[static GravityProviderSystem](Sandbox.ModAPI.MyAPIGateway@GravityProviderSystem)|Provides access to gravity control|
|[static GridGroups](Sandbox.ModAPI.MyAPIGateway@GridGroups)|Provides access to the Grid Group system|
|[static Gui](Sandbox.ModAPI.MyAPIGateway@Gui)|IMyGui exposes some useful values from the GUI systems|
|[static IngameScripting](Sandbox.ModAPI.MyAPIGateway@IngameScripting)|Provides mod access to control compilation of ingame scripts|
|[static Input](Sandbox.ModAPI.MyAPIGateway@Input)|IMyInput allows accessing direct input device states|
|[static Missiles](Sandbox.ModAPI.MyAPIGateway@Missiles)|Interface for controlling missiles|
|[static Multiplayer](Sandbox.ModAPI.MyAPIGateway@Multiplayer)|IMyMultiplayer contains multiplayer related things|
|[static Parallel](Sandbox.ModAPI.MyAPIGateway@Parallel)|IMyParallelTask allows to run tasks on background threads|
|[static Physics](Sandbox.ModAPI.MyAPIGateway@Physics)|IMyPhysics contains physics related things (CastRay, etc.)|
|[static Players](Sandbox.ModAPI.MyAPIGateway@Players)|IMyPlayerCollection contains all players that are in world|
|[static PrefabManager](Sandbox.ModAPI.MyAPIGateway@PrefabManager)|Allows you spawn prefabs|
|[static Projectiles](Sandbox.ModAPI.MyAPIGateway@Projectiles)|Interface for controlling projectile behavior|
|[static Reflection](Sandbox.ModAPI.MyAPIGateway@Reflection)|Allows you to use some reflection tools|
|[static SpectatorTools](Sandbox.ModAPI.MyAPIGateway@SpectatorTools)|Gives you access to spectator tools.|
|[static TerminalActionsHelper](Sandbox.ModAPI.MyAPIGateway@TerminalActionsHelper)|IMyTerminalActionsHelper is helper for terminal actions and allows to access terminal|
|[static TerminalControls](Sandbox.ModAPI.MyAPIGateway@TerminalControls)|IMyTerminalControls allows access to adding and removing controls from a block's terminal screen|
|[static Utilities](Sandbox.ModAPI.MyAPIGateway@Utilities)|IMyUtilities contains mainly I/O, serialization, mod interaction functions|
|[static GuiControlCreated](Sandbox.ModAPI.MyAPIGateway@GuiControlCreated)|_**Obsolete:** Use IMyGui.GuiControlCreated_<br /><br />Obsolete|

## Properties

|Member|Description|
|---|---|
|[static Entities](Sandbox.ModAPI.MyAPIGateway@Entities)|IMyEntities represents all objects that currently in world|
|[static Session](Sandbox.ModAPI.MyAPIGateway@Session)|IMySession represents session object e.g. current world and its settings|

## Methods

|Member|Description|
|---|---|
|[static Clean()](Sandbox.ModAPI.MyAPIGateway@Clean)|_**Obsolete**_<br /><br />Obsolete|
|[static DoorBase(string)](Sandbox.ModAPI.MyAPIGateway@DoorBase)|_**Obsolete**_<br /><br />Obsolete|
|[static GetMessageBoxPointer(ref IntPtr)](Sandbox.ModAPI.MyAPIGateway@GetMessageBoxPointer)|_**Obsolete**_<br /><br />Obsolete|

