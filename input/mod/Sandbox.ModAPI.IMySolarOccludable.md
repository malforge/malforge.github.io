**Assembly:** Sandbox.Common.dll

```csharp
public interface IMySolarOccludable: IMySolarOccludable
```

Describes an entity that registers when it is in a planetary shadow (mods interface).

## Properties

|Member|Description|
|---|---|
|[IsSolarOccluded](Sandbox.ModAPI.Ingame.IMySolarOccludable@IsSolarOccluded)|Whether the entity is in a planetary shadow.<br /><br />_Inherited from [IMySolarOccludable](Sandbox.ModAPI.Ingame.IMySolarOccludable)_|

## Methods

|Member|Description|
|---|---|
|[GetEntityId()](Sandbox.ModAPI.Ingame.IMySolarOccludable@GetEntityId)|Obtains the entity ID either directly from itself or from its containing entity if the interface is used on a component.<br /><br />_Inherited from [IMySolarOccludable](Sandbox.ModAPI.Ingame.IMySolarOccludable)_|

**Implements:**  
* [IMySolarOccludable](Sandbox.ModAPI.Ingame.IMySolarOccludable)

**Inheritors:**  
* [IMyOxygenFarm](SpaceEngineers.Game.ModAPI.IMyOxygenFarm)

