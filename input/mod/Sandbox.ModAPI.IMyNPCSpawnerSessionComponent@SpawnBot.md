## Summary

```csharp
public long SpawnBot(MyDefinitionId botDefinitionId, Vector3D position, Vector3D direction, Vector3D up, string name, string factionTag, string weaponsContainerSubtype, string lootContainerSubtype, string chatMessageSetSubtype, long squadGridEntityId)
```

Spawns a bot of any type (HumanoidBot or AnimalBot) at a position. Call it on the server, from the update thread. The bot persists until it dies or is removed; it never despawns by distance. A lone combat bot reacts only to hits on itself. A humanoid bot given a squad grid joins that grid's squad: alerts from grid damage, hits on squad members and gunshots near the grid, cover from hostile turrets while a player is near, a leash to the grid and squad chat. The squad is created with its first bot and saved with the world; all its bots share that bot's faction, and it speaks from that bot's chat message set. A squad with no living bots takes the faction of the next bot. When the grid is closed or its NPC claim countdown expires, its bots stay as lone bots. Placement, seating and despawning are up to the caller. Overrides apply to this character only; a definition with RemoveAfterDeath false respawns without them. Spawns nothing and returns 0 on a client, off the update thread, for an unknown bot definition, faction tag or subtype, for any override or squad on a non-humanoid bot, for a squad grid that does not exist or has an encounter crew, for a faction other than the squad's, and when the bot limit refuses the spawn; every case but the client one is logged.

## Returns

[long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6)

Entity id of the bot's character, or 0 when nothing was spawned.

## Parameters

* [MyDefinitionId](VRage.Game.MyDefinitionId) botDefinitionId
* [Vector3D](VRageMath.Vector3D) position
* [Vector3D](VRageMath.Vector3D) direction
* [Vector3D](VRageMath.Vector3D) up
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) name
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) factionTag
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) weaponsContainerSubtype
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) lootContainerSubtype
* [string](https://docs.microsoft.com/en-us/dotnet/api/System.String?view=netframework-4.6) chatMessageSetSubtype
* [long](https://docs.microsoft.com/en-us/dotnet/api/System.Int64?view=netframework-4.6) squadGridEntityId
