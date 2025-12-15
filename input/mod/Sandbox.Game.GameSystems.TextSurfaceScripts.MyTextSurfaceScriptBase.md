**Assembly:** Sandbox.Game.dll

```csharp
public abstract class MyTextSurfaceScriptBase: IMyTextSurfaceScript, IDisposable
```

## Fields

|Member|Description|
|---|---|
|[static DEFAULT_BACKGROUND_COLOR](Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptBase@DEFAULT_BACKGROUND_COLOR)||
|[static DEFAULT_FONT_COLOR](Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptBase@DEFAULT_FONT_COLOR)||

## Properties

|Member|Description|
|---|---|
|[BackgroundColor](Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptBase@BackgroundColor)||
|[Block](Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptBase@Block)||
|[ForegroundColor](Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptBase@ForegroundColor)||
|[NeedsUpdate](Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptBase@NeedsUpdate)||
|[Surface](Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptBase@Surface)||
|[BackgroundColor](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript@BackgroundColor)|_Inherited from [IMyTextSurfaceScript](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript)_|
|[Block](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript@Block)|_Inherited from [IMyTextSurfaceScript](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript)_|
|[ForegroundColor](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript@ForegroundColor)|_Inherited from [IMyTextSurfaceScript](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript)_|
|[NeedsUpdate](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript@NeedsUpdate)|_Inherited from [IMyTextSurfaceScript](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript)_|
|[Surface](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript@Surface)|_Inherited from [IMyTextSurfaceScript](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript)_|

## Methods

|Member|Description|
|---|---|
|[static FitRect(Vector2, ref Vector2)](Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptBase@FitRect)|Rescales rectangle to fit within desired texture space.|
|[Dispose()](Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptBase@Dispose)||
|[Run()](Sandbox.Game.GameSystems.TextSurfaceScripts.MyTextSurfaceScriptBase@Run)||
|[Run()](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript@Run)|_Inherited from [IMyTextSurfaceScript](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript)_|

**Implements:**  
* [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable?view=netframework-4.6)  
* [IMyTextSurfaceScript](Sandbox.Game.GameSystems.TextSurfaceScripts.IMyTextSurfaceScript)

**Inheritors:**  
* [MyTSSCommon](Sandbox.Game.GameSystems.TextSurfaceScripts.MyTSSCommon)

