**Assembly:** VRage.Library.dll

```csharp
public abstract sealed class MyStringUtils
```

## Fields

|Member|Description|
|---|---|
|[static CLOSED_SQUARE_BRACKET](VRage.Utils.MyStringUtils@CLOSED_SQUARE_BRACKET)||
|[static OPEN_SQUARE_BRACKET](VRage.Utils.MyStringUtils@OPEN_SQUARE_BRACKET)||

## Methods

|Member|Description|
|---|---|
|[static GetUniversalHashCode(this string)](VRage.Utils.MyStringUtils@GetUniversalHashCode)|Platform agnostic hash code (same as x64 .NET Framework)|
|[static Replace(this string, string, string, StringComparison)](VRage.Utils.MyStringUtils@Replace)|Same as string.Replace with string comparision support.|
|[static UpdateControlsFromNotificationFriendly(this string)](VRage.Utils.MyStringUtils@UpdateControlsFromNotificationFriendly)|Converts '[' and ']' UTF form to the regular characters.|
|[static UpdateControlsFromNotificationFriendly(this StringBuilder)](VRage.Utils.MyStringUtils@UpdateControlsFromNotificationFriendly)|Converts '[' and ']' UTF form to the regular characters.|
|[static UpdateControlsToNotificationFriendly(this string)](VRage.Utils.MyStringUtils@UpdateControlsToNotificationFriendly)|Converts '[' and ']' into their UTF form to avoid being removed by notification processing system.|

