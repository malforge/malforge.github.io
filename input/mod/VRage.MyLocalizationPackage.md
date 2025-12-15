**Assembly:** VRage.dll

```csharp
public sealed class MyLocalizationPackage
```

Lowest level storage for localization key-value pairs with support for message variants.

## Fields

|Member|Description|
|---|---|
|[static ValidateVariantName](VRage.MyLocalizationPackage@ValidateVariantName)|Callback that can be set to control the validation of variant names when registering messages.|

## Properties

|Member|Description|
|---|---|
|[Keys](VRage.MyLocalizationPackage@Keys)|Set of all localization keys in this package.|

## Constructors

|Member|Description|
|---|---|
|[MyLocalizationPackage()](VRage.MyLocalizationPackage@.ctor)||

## Methods

|Member|Description|
|---|---|
|[AddMessage(string, string, bool)](VRage.MyLocalizationPackage@AddMessage)|Add a message to the package.|
|[Clear()](VRage.MyLocalizationPackage@Clear)|Clear the contents of this package.|
|[ContainsKey(MyStringId)](VRage.MyLocalizationPackage@ContainsKey)|Whether this package contains a message with the provided key.|
|[TryGet(MyStringId, MyStringId, out string)](VRage.MyLocalizationPackage@TryGet)|Try to get a localized message.|
|[TryGetStringBuilder(MyStringId, MyStringId, out StringBuilder)](VRage.MyLocalizationPackage@TryGetStringBuilder)|Try to get a localized message as a string builder.|

