**Assembly:** VRage.Input.dll

```csharp
public interface IMyInput
```

## Events

|Member|Description|
|---|---|
|[JoystickConnected](VRage.ModAPI.IMyInput@JoystickConnected)||

## Properties

|Member|Description|
|---|---|
|[IsJoystickLastUsed](VRage.ModAPI.IMyInput@IsJoystickLastUsed)||
|[JoystickAsMouse](VRage.ModAPI.IMyInput@JoystickAsMouse)||
|[JoystickInstanceName](VRage.ModAPI.IMyInput@JoystickInstanceName)||
|[TextInput](VRage.ModAPI.IMyInput@TextInput)||

## Methods

|Member|Description|
|---|---|
|[DeltaMouseScrollWheelValue()](VRage.ModAPI.IMyInput@DeltaMouseScrollWheelValue)||
|[EnumerateJoystickNames()](VRage.ModAPI.IMyInput@EnumerateJoystickNames)||
|[GetCodeForControl(MyStringId, MyStringId)](VRage.ModAPI.IMyInput@GetCodeForControl)||
|[GetControl(MyKeys)](VRage.ModAPI.IMyInput@GetControl)||
|[GetControl(MyKeys, MyKeyboardModifiers)](VRage.ModAPI.IMyInput@GetControl)|Gets control for combination of key + modifiers|
|[GetControl(MyMouseButtonsEnum)](VRage.ModAPI.IMyInput@GetControl)||
|[GetControl(MyStringId, MyStringId)](VRage.ModAPI.IMyInput@GetControl)||
|[GetGameControl(MyStringId)](VRage.ModAPI.IMyInput@GetGameControl)||
|[GetGameControlAnalogState(MyStringId)](VRage.ModAPI.IMyInput@GetGameControlAnalogState)||
|[GetJoystickAxisStateForGameplay(MyJoystickAxesEnum)](VRage.ModAPI.IMyInput@GetJoystickAxisStateForGameplay)||
|[GetKeyName(MyKeys)](VRage.ModAPI.IMyInput@GetKeyName)||
|[GetListOfPressedKeys(List<MyKeys>)](VRage.ModAPI.IMyInput@GetListOfPressedKeys)||
|[GetListOfPressedMouseButtons(List<MyMouseButtonsEnum>)](VRage.ModAPI.IMyInput@GetListOfPressedMouseButtons)||
|[GetMouseAreaSize()](VRage.ModAPI.IMyInput@GetMouseAreaSize)||
|[GetMousePosition()](VRage.ModAPI.IMyInput@GetMousePosition)||
|[GetMouseSensitivity()](VRage.ModAPI.IMyInput@GetMouseSensitivity)||
|[GetMouseX()](VRage.ModAPI.IMyInput@GetMouseX)||
|[GetMouseXForGamePlay()](VRage.ModAPI.IMyInput@GetMouseXForGamePlay)||
|[GetMouseXInversion()](VRage.ModAPI.IMyInput@GetMouseXInversion)||
|[GetMouseY()](VRage.ModAPI.IMyInput@GetMouseY)||
|[GetMouseYForGamePlay()](VRage.ModAPI.IMyInput@GetMouseYForGamePlay)||
|[GetMouseYInversion()](VRage.ModAPI.IMyInput@GetMouseYInversion)||
|[GetName(MyMouseButtonsEnum)](VRage.ModAPI.IMyInput@GetName)||
|[GetName(MyJoystickButtonsEnum)](VRage.ModAPI.IMyInput@GetName)||
|[GetName(MyJoystickAxesEnum)](VRage.ModAPI.IMyInput@GetName)||
|[GetPressedKeys(List<MyKeys>)](VRage.ModAPI.IMyInput@GetPressedKeys)||
|[GetUnassignedName()](VRage.ModAPI.IMyInput@GetUnassignedName)||
|[IsAnyAltKeyPressed()](VRage.ModAPI.IMyInput@IsAnyAltKeyPressed)||
|[IsAnyCtrlKeyPressed()](VRage.ModAPI.IMyInput@IsAnyCtrlKeyPressed)||
|[IsAnyKeyPress()](VRage.ModAPI.IMyInput@IsAnyKeyPress)||
|[IsAnyMouseOrJoystickPressed()](VRage.ModAPI.IMyInput@IsAnyMouseOrJoystickPressed)||
|[IsAnyMousePressed()](VRage.ModAPI.IMyInput@IsAnyMousePressed)||
|[IsAnyNewMouseOrJoystickPressed()](VRage.ModAPI.IMyInput@IsAnyNewMouseOrJoystickPressed)||
|[IsAnyNewMousePressed()](VRage.ModAPI.IMyInput@IsAnyNewMousePressed)||
|[IsAnyShiftKeyPressed()](VRage.ModAPI.IMyInput@IsAnyShiftKeyPressed)||
|[IsButtonPressed(MySharedButtonsEnum)](VRage.ModAPI.IMyInput@IsButtonPressed)||
|[IsButtonReleased(MySharedButtonsEnum)](VRage.ModAPI.IMyInput@IsButtonReleased)||
|[IsControl(MyStringId, MyStringId, MyControlStateType, bool, bool)](VRage.ModAPI.IMyInput@IsControl)||
|[IsControlAnalog(MyStringId, MyStringId, bool)](VRage.ModAPI.IMyInput@IsControlAnalog)||
|[IsDefined(MyStringId, MyStringId)](VRage.ModAPI.IMyInput@IsDefined)||
|[IsGameControlPressed(MyStringId)](VRage.ModAPI.IMyInput@IsGameControlPressed)||
|[IsGameControlReleased(MyStringId)](VRage.ModAPI.IMyInput@IsGameControlReleased)||
|[IsJoystickAxisNewPressed(MyJoystickAxesEnum)](VRage.ModAPI.IMyInput@IsJoystickAxisNewPressed)||
|[IsJoystickAxisPressed(MyJoystickAxesEnum)](VRage.ModAPI.IMyInput@IsJoystickAxisPressed)||
|[IsJoystickAxisValid(MyJoystickAxesEnum)](VRage.ModAPI.IMyInput@IsJoystickAxisValid)||
|[IsJoystickButtonNewPressed(MyJoystickButtonsEnum)](VRage.ModAPI.IMyInput@IsJoystickButtonNewPressed)||
|[IsJoystickButtonPressed(MyJoystickButtonsEnum)](VRage.ModAPI.IMyInput@IsJoystickButtonPressed)||
|[IsJoystickButtonValid(MyJoystickButtonsEnum)](VRage.ModAPI.IMyInput@IsJoystickButtonValid)||
|[IsJoystickConnected()](VRage.ModAPI.IMyInput@IsJoystickConnected)||
|[IsKeyDigit(MyKeys)](VRage.ModAPI.IMyInput@IsKeyDigit)||
|[IsKeyPress(MyKeys)](VRage.ModAPI.IMyInput@IsKeyPress)||
|[IsKeyValid(MyKeys)](VRage.ModAPI.IMyInput@IsKeyValid)||
|[IsLeftMousePressed()](VRage.ModAPI.IMyInput@IsLeftMousePressed)||
|[IsLeftMouseReleased()](VRage.ModAPI.IMyInput@IsLeftMouseReleased)||
|[IsMiddleMousePressed()](VRage.ModAPI.IMyInput@IsMiddleMousePressed)||
|[IsMouseButtonValid(MyMouseButtonsEnum)](VRage.ModAPI.IMyInput@IsMouseButtonValid)||
|[IsMousePressed(MyMouseButtonsEnum)](VRage.ModAPI.IMyInput@IsMousePressed)||
|[IsMouseReleased(MyMouseButtonsEnum)](VRage.ModAPI.IMyInput@IsMouseReleased)||
|[IsNewButtonPressed(MySharedButtonsEnum)](VRage.ModAPI.IMyInput@IsNewButtonPressed)||
|[IsNewButtonReleased(MySharedButtonsEnum)](VRage.ModAPI.IMyInput@IsNewButtonReleased)||
|[IsNewGameControlPressed(MyStringId)](VRage.ModAPI.IMyInput@IsNewGameControlPressed)||
|[IsNewGameControlReleased(MyStringId)](VRage.ModAPI.IMyInput@IsNewGameControlReleased)||
|[IsNewJoystickAxisReleased(MyJoystickAxesEnum)](VRage.ModAPI.IMyInput@IsNewJoystickAxisReleased)||
|[IsNewJoystickButtonReleased(MyJoystickButtonsEnum)](VRage.ModAPI.IMyInput@IsNewJoystickButtonReleased)||
|[IsNewKeyPressed(MyKeys)](VRage.ModAPI.IMyInput@IsNewKeyPressed)||
|[IsNewKeyReleased(MyKeys)](VRage.ModAPI.IMyInput@IsNewKeyReleased)||
|[IsNewLeftMousePressed()](VRage.ModAPI.IMyInput@IsNewLeftMousePressed)||
|[IsNewLeftMouseReleased()](VRage.ModAPI.IMyInput@IsNewLeftMouseReleased)||
|[IsNewMiddleMousePressed()](VRage.ModAPI.IMyInput@IsNewMiddleMousePressed)||
|[IsNewMiddleMouseReleased()](VRage.ModAPI.IMyInput@IsNewMiddleMouseReleased)||
|[IsNewMousePressed(MyMouseButtonsEnum)](VRage.ModAPI.IMyInput@IsNewMousePressed)||
|[IsNewPrimaryButtonPressed()](VRage.ModAPI.IMyInput@IsNewPrimaryButtonPressed)||
|[IsNewPrimaryButtonReleased()](VRage.ModAPI.IMyInput@IsNewPrimaryButtonReleased)||
|[IsNewRightMousePressed()](VRage.ModAPI.IMyInput@IsNewRightMousePressed)||
|[IsNewRightMouseReleased()](VRage.ModAPI.IMyInput@IsNewRightMouseReleased)||
|[IsNewSecondaryButtonPressed()](VRage.ModAPI.IMyInput@IsNewSecondaryButtonPressed)||
|[IsNewSecondaryButtonReleased()](VRage.ModAPI.IMyInput@IsNewSecondaryButtonReleased)||
|[IsNewXButton1MousePressed()](VRage.ModAPI.IMyInput@IsNewXButton1MousePressed)||
|[IsNewXButton1MouseReleased()](VRage.ModAPI.IMyInput@IsNewXButton1MouseReleased)||
|[IsNewXButton2MousePressed()](VRage.ModAPI.IMyInput@IsNewXButton2MousePressed)||
|[IsNewXButton2MouseReleased()](VRage.ModAPI.IMyInput@IsNewXButton2MouseReleased)||
|[IsPrimaryButtonPressed()](VRage.ModAPI.IMyInput@IsPrimaryButtonPressed)||
|[IsPrimaryButtonReleased()](VRage.ModAPI.IMyInput@IsPrimaryButtonReleased)||
|[IsRightMousePressed()](VRage.ModAPI.IMyInput@IsRightMousePressed)||
|[IsSecondaryButtonPressed()](VRage.ModAPI.IMyInput@IsSecondaryButtonPressed)||
|[IsSecondaryButtonReleased()](VRage.ModAPI.IMyInput@IsSecondaryButtonReleased)||
|[IsXButton1MousePressed()](VRage.ModAPI.IMyInput@IsXButton1MousePressed)||
|[IsXButton2MousePressed()](VRage.ModAPI.IMyInput@IsXButton2MousePressed)||
|[MouseScrollWheelValue()](VRage.ModAPI.IMyInput@MouseScrollWheelValue)||
|[PreviousMouseScrollWheelValue()](VRage.ModAPI.IMyInput@PreviousMouseScrollWheelValue)||
|[TryGetControl(MyStringId, MyStringId)](VRage.ModAPI.IMyInput@TryGetControl)||
|[WasKeyPress(MyKeys)](VRage.ModAPI.IMyInput@WasKeyPress)||
|[WasMiddleMousePressed()](VRage.ModAPI.IMyInput@WasMiddleMousePressed)||
|[WasMiddleMouseReleased()](VRage.ModAPI.IMyInput@WasMiddleMouseReleased)||
|[WasRightMousePressed()](VRage.ModAPI.IMyInput@WasRightMousePressed)||
|[WasRightMouseReleased()](VRage.ModAPI.IMyInput@WasRightMouseReleased)||
|[WasXButton1MousePressed()](VRage.ModAPI.IMyInput@WasXButton1MousePressed)||
|[WasXButton1MouseReleased()](VRage.ModAPI.IMyInput@WasXButton1MouseReleased)||
|[WasXButton2MousePressed()](VRage.ModAPI.IMyInput@WasXButton2MousePressed)||
|[WasXButton2MouseReleased()](VRage.ModAPI.IMyInput@WasXButton2MouseReleased)||

