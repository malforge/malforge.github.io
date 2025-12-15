**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyFarmPlotLogic: IMyFarmPlotLogic
```

Describes the exposed farm plot logic.

## Properties

|Member|Description|
|---|---|
|[AmountOfSeedsRequired](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic@AmountOfSeedsRequired)|The amount of seeds that are needed to start growing a plant at this farm plot.<br /><br />_Inherited from [IMyFarmPlotLogic](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic)_|
|[IsAlive](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic@IsAlive)|Whether the plant is alive.<br /><br />_Inherited from [IMyFarmPlotLogic](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic)_|
|[IsHarvestable](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic@IsHarvestable)|Whether the plant can be harvested. By default, the block is harvestable if it contains a plant that is fully grown or dead.<br /><br />_Inherited from [IMyFarmPlotLogic](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic)_|
|[IsPlantFullyGrown](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic@IsPlantFullyGrown)|Whether the plant is fully grown.<br /><br />_Inherited from [IMyFarmPlotLogic](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic)_|
|[IsPlantPlanted](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic@IsPlantPlanted)|Whether a plant is planted, dead or alive.<br /><br />_Inherited from [IMyFarmPlotLogic](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic)_|
|[OutputItem](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic@OutputItem)|The item that the currently planted seed will produce when fully grown.<br /><br />_Inherited from [IMyFarmPlotLogic](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic)_|
|[OutputItemAmount](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic@OutputItemAmount)|The amount of items that the currently planted seed will produce when fully grown. Returns 0 if the plant is not yet fully grown.<br /><br />_Inherited from [IMyFarmPlotLogic](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic)_|

## Methods

|Member|Description|
|---|---|
|[Harvest(IMyInventory, bool)](Sandbox.ModAPI.IMyFarmPlotLogic@Harvest)|Harvests the plant and puts the output items into the specified inventory. Only works when called from the server.|
|[PlantSeed(MyDefinitionId)](Sandbox.ModAPI.IMyFarmPlotLogic@PlantSeed)|Plants a given seed and starts growing the plant. It is the responsibility of the caller to handle inventory management. This method will just plant the seed from the definition with the necessary amount. Only works when called from the server.|
|[RemovePlant(bool)](Sandbox.ModAPI.IMyFarmPlotLogic@RemovePlant)|Removes the currently planted plant and its seed. Only works when called from the server.|
|[GetDetailedInfoWithoutRequiredInput()](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic@GetDetailedInfoWithoutRequiredInput)|Obtains detailed info that does not include the required power input. Used by the plant management screen.<br /><br />_Inherited from [IMyFarmPlotLogic](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic)_|

**Implements:**  
* [IMyFarmPlotLogic](Sandbox.ModAPI.Ingame.IMyFarmPlotLogic)

