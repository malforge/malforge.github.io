**Assembly:** Sandbox.Game.dll

```csharp
public interface IMyCharacterAimAssistComponent: IMyCharacterAimAssistComponent, IMyCharacterAimAssistComponent
```

Internal interface for character aim assist component with full functionality. Extends the public ModAPI interface for component registration.

## Properties

|Member|Description|
|---|---|
|[AimAssistPhysics](Sandbox.Game.Entities.Character.Components.IMyCharacterAimAssistComponent@AimAssistPhysics)||
|[IsAimAssistSensitivityDecreased](Sandbox.Game.Entities.Character.Components.IMyCharacterAimAssistComponent@IsAimAssistSensitivityDecreased)||
|[IsAimAssistSnapAllowed](Sandbox.Game.Entities.Character.Components.IMyCharacterAimAssistComponent@IsAimAssistSnapAllowed)||

## Methods

|Member|Description|
|---|---|
|[ClearPhysics()](Sandbox.Game.Entities.Character.Components.IMyCharacterAimAssistComponent@ClearPhysics)||
|[CloseAimAssistPhysics()](Sandbox.Game.Entities.Character.Components.IMyCharacterAimAssistComponent@CloseAimAssistPhysics)||
|[GetSensitivityMultiplier()](Sandbox.Game.Entities.Character.Components.IMyCharacterAimAssistComponent@GetSensitivityMultiplier)||
|[SetPhysicsEnabled(bool)](Sandbox.Game.Entities.Character.Components.IMyCharacterAimAssistComponent@SetPhysicsEnabled)||
|[SetSnapTarget(long)](Sandbox.Game.Entities.Character.Components.IMyCharacterAimAssistComponent@SetSnapTarget)||

**Implements:**  
* [IMyCharacterAimAssistComponent](Sandbox.ModAPI.IMyCharacterAimAssistComponent)  
* [IMyCharacterAimAssistComponent](Sandbox.ModAPI.Ingame.IMyCharacterAimAssistComponent)

