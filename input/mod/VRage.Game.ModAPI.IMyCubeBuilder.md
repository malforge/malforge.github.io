**Assembly:** VRage.Game.dll

```csharp
public interface IMyCubeBuilder
```

Describes hand, than holding block (mods interface)

## Properties

|Member|Description|
|---|---|
|[BlockCreationIsActivated](VRage.Game.ModAPI.IMyCubeBuilder@BlockCreationIsActivated)|Returns state of building mode|
|[FreezeGizmo](VRage.Game.ModAPI.IMyCubeBuilder@FreezeGizmo)|Freezes the built object preview in current position|
|[IsActivated](VRage.Game.ModAPI.IMyCubeBuilder@IsActivated)|Gets whether there block creation is activated|
|[ShowRemoveGizmo](VRage.Game.ModAPI.IMyCubeBuilder@ShowRemoveGizmo)|Shows the delete area preview|
|[UseSymmetry](VRage.Game.ModAPI.IMyCubeBuilder@UseSymmetry)|Enables symmetry block placing|
|[UseTransparency](VRage.Game.ModAPI.IMyCubeBuilder@UseTransparency)|Gets or sets whether projected block should be 25% transparent|

## Methods

|Member|Description|
|---|---|
|[Activate(MyDefinitionId?)](VRage.Game.ModAPI.IMyCubeBuilder@Activate)|Activates the building mode|
|[Deactivate()](VRage.Game.ModAPI.IMyCubeBuilder@Deactivate)|Deactivates all modes|
|[DeactivateBlockCreation()](VRage.Game.ModAPI.IMyCubeBuilder@DeactivateBlockCreation)|Deactivates building mode|
|[FindClosestGrid()](VRage.Game.ModAPI.IMyCubeBuilder@FindClosestGrid)|Finds grid to build on|
|[StartNewGridPlacement(MyCubeSize, bool)](VRage.Game.ModAPI.IMyCubeBuilder@StartNewGridPlacement)|Calls [Activate(MyDefinitionId?)](VRage.Game.ModAPI.IMyCubeBuilder@Activate) with LargeBlockArmorBlock definition and forces local player stop using weapon or tool|
|[AddConstruction(IMyEntity)](VRage.Game.ModAPI.IMyCubeBuilder@AddConstruction)|_**Obsolete:** Not used. Always returns false_|

**Inheritors:**  
* [MyCubeBuilder](Sandbox.Game.Entities.MyCubeBuilder)

