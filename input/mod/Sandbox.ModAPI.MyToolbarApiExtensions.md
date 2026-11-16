**Assembly:** Sandbox.Game.dll

```csharp
public abstract sealed class MyToolbarApiExtensions
```

The parts of the toolbar API that need terminal types. They live here rather than on [IMyToolbar](VRage.Game.ModAPI.IMyToolbar) and its relatives because those interfaces are declared in VRage.Game, which cannot see the assembly terminal actions and their arguments live in.

## Methods

|Member|Description|
|---|---|
|[static BlockAction(this IMyToolbarChangeBuilder, int, IMyTerminalBlock, string, List<TerminalActionParameter>, string)](Sandbox.ModAPI.MyToolbarApiExtensions@BlockAction)|Places an item that runs one of a block's terminal actions.|
|[static Definition(this IMyToolbarChangeBuilder, int, MyDefinitionId)](Sandbox.ModAPI.MyToolbarApiExtensions@Definition)|Places an item that selects a definition: a block to build, a tool, a consumable. This is what character toolbars hold; terminal actions are not allowed on them.|
|[static GetActionParameterDefinitions(this IMyTerminalBlock, string, List<TypeCode>)](Sandbox.ModAPI.MyToolbarApiExtensions@GetActionParameterDefinitions)|Clearsoutputand fills it with the type of each argument an action takes, in the order it expects them. Empty for the great majority of actions, which take none. Build the arguments themselves with TerminalActionParameter.Get.<br /><br />Unlike [GetActionWithName(string)](Sandbox.ModAPI.Ingame.IMyTerminalBlock@GetActionWithName) this finds actions whatever toolbar they are meant for, so it answers for actions that lookup cannot return.|
|[static GetParameters(this IMyToolbarSlots, int, List<TerminalActionParameter>)](Sandbox.ModAPI.MyToolbarApiExtensions@GetParameters)|Clearsoutputand fills it with the arguments the slot's action was given, in the order the action declares them. Empty for a slot that holds no action or whose action takes none, which is most of them.|
|[static GroupAction(this IMyToolbarChangeBuilder, int, IMyTerminalBlock, string, string, List<TerminalActionParameter>, string)](Sandbox.ModAPI.MyToolbarApiExtensions@GroupAction)|Places an item that runs a terminal action on a block group.|
|[static Set(this IMyToolbarChangeBuilder, int, MyToolbarItemInfo, List<TerminalActionParameter>)](Sandbox.ModAPI.MyToolbarApiExtensions@Set)|Places an item in a slot along with the arguments its action takes.|

