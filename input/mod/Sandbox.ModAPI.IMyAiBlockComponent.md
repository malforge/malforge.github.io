**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyAiBlockComponent
```

Describes AI block activator entity component. This entity component turns on/off AI Behavior.

## Events

|Member|Description|
|---|---|
|[OnActivatedChanged](Sandbox.ModAPI.IMyAiBlockComponent@OnActivatedChanged)|Triggers when Is Activated is changed|

## Properties

|Member|Description|
|---|---|
|[AiBlockType](Sandbox.ModAPI.IMyAiBlockComponent@AiBlockType)|Gets or sets the AI Block Type|
|[Entity](Sandbox.ModAPI.IMyAiBlockComponent@Entity)|Gets the entity of this entity component|
|[HudErrorStringGetter](Sandbox.ModAPI.IMyAiBlockComponent@HudErrorStringGetter)|Getter for errors on AI block. Used in detailed info.|
|[IsActivated](Sandbox.ModAPI.IMyAiBlockComponent@IsActivated)|Gets or sets if the component is activated. This activation turns on/off AI Behavior of the AI blocks.|

## Methods

|Member|Description|
|---|---|
|[Deactivate()](Sandbox.ModAPI.IMyAiBlockComponent@Deactivate)|Deactivates the component|

**Inheritors:**  
* [MyAiBlockComponent](Sandbox.Game.EntityComponents.MyAiBlockComponent)

