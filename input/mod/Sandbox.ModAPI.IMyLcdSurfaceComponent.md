**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyLcdSurfaceComponent
```

Describes LCD surface entity component.

## Properties

|Member|Description|
|---|---|
|[InitializedWithBuilder](Sandbox.ModAPI.IMyLcdSurfaceComponent@InitializedWithBuilder)|Gets whether the component got deserialized state from object builder|
|[SelectedRotationIndex](Sandbox.ModAPI.IMyLcdSurfaceComponent@SelectedRotationIndex)|Gets LCD content rotation|

## Methods

|Member|Description|
|---|---|
|[OnRemovedFromScene(object)](Sandbox.ModAPI.IMyLcdSurfaceComponent@OnRemovedFromScene)|Notifies the component of containers' OnRemovedFromScene event|
|[SetRenderForAllAreas()](Sandbox.ModAPI.IMyLcdSurfaceComponent@SetRenderForAllAreas)|Assigns container block render object to all screen areas|
|[SetSelectedRotationIndex(int)](Sandbox.ModAPI.IMyLcdSurfaceComponent@SetSelectedRotationIndex)|Sets LCD content rotation|
|[UpdateVisibility()](Sandbox.ModAPI.IMyLcdSurfaceComponent@UpdateVisibility)|Updates textures based on whether a screen is active or not|

