**Assembly:** VRage.Game.dll

```csharp
public interface IMyToolbarProvider
```

An entity's player-configurable toolbars: a timer block's, a sensor's, a button panel's, an event controller's, a cockpit's. Carried by a component, so it is reached from the entity rather than cast from it:```csharp  
block.Components.TryGet(out IMyToolbarProvider toolbars)  
  
```

## Properties

|Member|Description|
|---|---|
|[ToolbarCount](VRage.Game.ModAPI.IMyToolbarProvider@ToolbarCount)|Number of toolbars this entity exposes. Indices are stable for a given block type, but prefer the named accessors on the block's own interface over an index.|

## Methods

|Member|Description|
|---|---|
|[GetToolbar(int)](VRage.Game.ModAPI.IMyToolbarProvider@GetToolbar)|Gets one of this entity's toolbars by index. Index 0 is always the primary toolbar: the one a player drives directly where there is one, otherwise the toolbar the block triggers itself. Use this to enumerate every toolbar; to reach a specific one where there are several, prefer the named accessors on the block's own interface.|

**Inheritors:**  
* [MyToolbarProviderComponent](Sandbox.Game.EntityComponents.MyToolbarProviderComponent)

