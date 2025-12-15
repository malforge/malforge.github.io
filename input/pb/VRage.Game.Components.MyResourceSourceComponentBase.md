**Assembly:** VRage.Game.dll

```csharp
public abstract class MyResourceSourceComponentBase: MyEntityComponentBase, IMyComponentBase, IMyEntityComponentBase
```

## Methods

|Member|Description|
|---|---|
|[CurrentOutputByType(MyDefinitionId)](VRage.Game.Components.MyResourceSourceComponentBase@CurrentOutputByType)|Currently used power output of the producer in MW or litres/h.|
|[DefinedOutputByType(MyDefinitionId)](VRage.Game.Components.MyResourceSourceComponentBase@DefinedOutputByType)|Max resource output defined in definition in MW or litres/h.|
|[MaxOutputByType(MyDefinitionId)](VRage.Game.Components.MyResourceSourceComponentBase@MaxOutputByType)|Maximum power output of the producer in MW or litres/h.|
|[ProductionEnabledByType(MyDefinitionId)](VRage.Game.Components.MyResourceSourceComponentBase@ProductionEnabledByType)|Resource production is enabled|

**Inheritance:**   MyEntityComponentBase <sub>prohibited</sub>

**Implements:**  
* IMyComponentBase <sub>prohibited</sub>  
* IMyEntityComponentBase <sub>prohibited</sub>

**Inheritors:**  
* [MyResourceSourceComponent](Sandbox.Game.EntityComponents.MyResourceSourceComponent)

