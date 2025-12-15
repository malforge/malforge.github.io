**Assembly:** VRage.Input.dll

```csharp
public interface IMyControl
```

## Properties

|Member|Description|
|---|---|
|[IsEnabled](VRage.ModAPI.IMyControl@IsEnabled)|if control is enabled or not|

## Methods

|Member|Description|
|---|---|
|[GetAnalogState()](VRage.ModAPI.IMyControl@GetAnalogState)|Return the analog state between 0 (not pressed at all) and 1 (fully pressed). If a digital button is mapped to an analog control, it can return only 0 or 1.|
|[GetControlButtonName(MyGuiInputDeviceEnum)](VRage.ModAPI.IMyControl@GetControlButtonName)||
|[GetControlDescription()](VRage.ModAPI.IMyControl@GetControlDescription)||
|[GetControlName()](VRage.ModAPI.IMyControl@GetControlName)||
|[GetControlTypeEnum()](VRage.ModAPI.IMyControl@GetControlTypeEnum)||
|[GetGameControlEnum()](VRage.ModAPI.IMyControl@GetGameControlEnum)||
|[GetKeyboardControl()](VRage.ModAPI.IMyControl@GetKeyboardControl)||
|[GetKeyboardModifier()](VRage.ModAPI.IMyControl@GetKeyboardModifier)|Gets keyboard modifiers for the primary key|
|[GetMouseControl()](VRage.ModAPI.IMyControl@GetMouseControl)||
|[GetSecondKeyboardControl()](VRage.ModAPI.IMyControl@GetSecondKeyboardControl)||
|[GetSecondKeyboardModifier()](VRage.ModAPI.IMyControl@GetSecondKeyboardModifier)|Gets keyboard modifiers for the secondary key|
|[IsControlAssigned()](VRage.ModAPI.IMyControl@IsControlAssigned)||
|[IsJoystickPressed()](VRage.ModAPI.IMyControl@IsJoystickPressed)||
|[IsNewJoystickPressed()](VRage.ModAPI.IMyControl@IsNewJoystickPressed)||
|[IsNewJoystickReleased()](VRage.ModAPI.IMyControl@IsNewJoystickReleased)||
|[IsNewPressed()](VRage.ModAPI.IMyControl@IsNewPressed)||
|[IsNewReleased()](VRage.ModAPI.IMyControl@IsNewReleased)||
|[IsPressed()](VRage.ModAPI.IMyControl@IsPressed)||

