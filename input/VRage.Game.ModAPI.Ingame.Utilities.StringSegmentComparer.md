**Assembly:** VRage.Game.dll

```csharp
public class StringSegmentComparer: IEqualityComparer<StringSegment>
```

A comparer designed to compare [StringSegment](VRage.Game.ModAPI.Ingame.Utilities.StringSegment) instances in a case sensitive manner. Use [DEFAULT](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer@DEFAULT) for a default instance

## Fields

|Member|Description|
|---|---|
|[static DEFAULT](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer@DEFAULT)|A default instance of [StringSegmentComparer](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer) |

## Constructors

|Member|Description|
|---|---|
|[StringSegmentComparer()](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Equals(StringSegment, StringSegment)](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer@Equals)|Determines whether the specified objects are equal.|
|[GetHashCode(StringSegment)](VRage.Game.ModAPI.Ingame.Utilities.StringSegmentComparer@GetHashCode)|Returns a hash code for the specified object.|

**Implements:**  
* [IEqualityComparer<StringSegment>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEqualityComparer-1?view=netframework-4.6)

