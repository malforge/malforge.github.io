**Assembly:** VRage.Game.dll

```csharp
public class MySessionComponentDescriptor: Attribute, _Attribute
```

## Fields

|Member|Description|
|---|---|
|[ComponentType](VRage.Game.Components.MySessionComponentDescriptor@ComponentType)||
|[ObjectBuilderType](VRage.Game.Components.MySessionComponentDescriptor@ObjectBuilderType)||
|[Priority](VRage.Game.Components.MySessionComponentDescriptor@Priority)|Lower Priority is loaded before higher Priority|
|[UpdateOrder](VRage.Game.Components.MySessionComponentDescriptor@UpdateOrder)||

## Properties

|Member|Description|
|---|---|
|[IsServerOnly](VRage.Game.Components.MySessionComponentDescriptor@IsServerOnly)|Is server only is used for client request of the world. if the component is server only, it's not sent to the client on world request.|

## Constructors

|Member|Description|
|---|---|
|[MySessionComponentDescriptor(MyUpdateOrder)](VRage.Game.Components.MySessionComponentDescriptor@.ctor)||
|[MySessionComponentDescriptor(MyUpdateOrder, int)](VRage.Game.Components.MySessionComponentDescriptor@.ctor)||
|[MySessionComponentDescriptor(MyUpdateOrder, int, Type, Type, bool)](VRage.Game.Components.MySessionComponentDescriptor@.ctor)||

**Inheritance:**   Attribute <sub>prohibited</sub>

**Implements:**  
* _Attribute <sub>prohibited</sub>

