**Assembly:** VRage.Game.dll

```csharp
public interface IMyRemapHelper
```

ModAPI interface giving access to changing id and names of entities

## Methods

|Member|Description|
|---|---|
|[Clear()](VRage.ModAPI.IMyRemapHelper@Clear)|Clears all the saved mappings from the remap helper and gets it ready for the next remapping operation.|
|[GetRemapInfo()](VRage.ModAPI.IMyRemapHelper@GetRemapInfo)|Key - old, value - new id Used to track if id is still existing|
|[RemapEntityId(long)](VRage.ModAPI.IMyRemapHelper@RemapEntityId)|Returns a new entity ID for the entity with the given old entity ID. The function will return the same new entityId only if the saveMapping argument is set to true.|
|[RemapEntityName(long)](VRage.ModAPI.IMyRemapHelper@RemapEntityName)|Returns a new entity name for the entity with the given new entity name. The function will return the same new name only if the saveMapping argument is set to true.|
|[RemapGroupId(string, int)](VRage.ModAPI.IMyRemapHelper@RemapGroupId)|Returns a new ID for the given old ID for specific group (multiblockIDs, ...).|

