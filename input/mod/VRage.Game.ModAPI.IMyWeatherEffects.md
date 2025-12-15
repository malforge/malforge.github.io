**Assembly:** VRage.Game.dll

```csharp
public interface IMyWeatherEffects
```



## Properties

|Member|Description|
|---|---|
|[FogAtmoOverride](VRage.Game.ModAPI.IMyWeatherEffects@FogAtmoOverride)|Gets or sets sector's FogAtmo. When value is null, used default sector value|
|[FogColorOverride](VRage.Game.ModAPI.IMyWeatherEffects@FogColorOverride)|Gets or sets sector's FogColor. When value is null, used default sector value|
|[FogDensityOverride](VRage.Game.ModAPI.IMyWeatherEffects@FogDensityOverride)|Gets or sets sector's FogDensity. When value is null, used default sector value|
|[FogMultiplierOverride](VRage.Game.ModAPI.IMyWeatherEffects@FogMultiplierOverride)|Gets or sets sector's FogMultiplier. When value is null, used default sector value|
|[FogSkyboxOverride](VRage.Game.ModAPI.IMyWeatherEffects@FogSkyboxOverride)|Gets or sets sector's FogSkybox. When value is null, used default sector value|
|[ParticleDirectionOverride](VRage.Game.ModAPI.IMyWeatherEffects@ParticleDirectionOverride)|Gets or sets sector's ParticleDirection. When value is null, used default sector value|
|[ParticleVelocityOverride](VRage.Game.ModAPI.IMyWeatherEffects@ParticleVelocityOverride)|Gets or sets sector's ParticleVelocity. When value is null, used default sector value|
|[SunIntensityOverride](VRage.Game.ModAPI.IMyWeatherEffects@SunIntensityOverride)|Gets or sets sector's SunIntensity. When value is null, used default sector value|

## Methods

|Member|Description|
|---|---|
|[CreateLightning(Vector3D, MyObjectBuilder_WeatherLightning, bool)](VRage.Game.ModAPI.IMyWeatherEffects@CreateLightning)|Creates lightning|
|[GetOxygenMultiplier(Vector3D)](VRage.Game.ModAPI.IMyWeatherEffects@GetOxygenMultiplier)|Gets weather oxygen multiplier at world coordinates|
|[GetOxygenMultiplier(Vector3D, MyObjectBuilder_WeatherEffect)](VRage.Game.ModAPI.IMyWeatherEffects@GetOxygenMultiplier)|Gets weather oxygen multiplier in point for provided weather|
|[GetSolarMultiplier(Vector3D)](VRage.Game.ModAPI.IMyWeatherEffects@GetSolarMultiplier)|Gets solar multiplier at world coordinates|
|[GetSolarMultiplier(Vector3D, MyObjectBuilder_WeatherEffect)](VRage.Game.ModAPI.IMyWeatherEffects@GetSolarMultiplier)|Gets weather solar multiplier in point for provided weather|
|[GetTemperatureMultiplier(Vector3D)](VRage.Game.ModAPI.IMyWeatherEffects@GetTemperatureMultiplier)|Gets weather temperature multiplier in point for provided weather|
|[GetTemperatureMultiplier(Vector3D, MyObjectBuilder_WeatherEffect)](VRage.Game.ModAPI.IMyWeatherEffects@GetTemperatureMultiplier)|Gets weather temperature multiplier in point for provided weather|
|[GetWeather(Vector3D)](VRage.Game.ModAPI.IMyWeatherEffects@GetWeather)|Gets weather name at provided position|
|[GetWeather(Vector3D, out MyObjectBuilder_WeatherEffect)](VRage.Game.ModAPI.IMyWeatherEffects@GetWeather)|Gets object builder of weather at provided position|
|[GetWeatherIntensity(Vector3D)](VRage.Game.ModAPI.IMyWeatherEffects@GetWeatherIntensity)|Gets weather intensity at world coordinates|
|[GetWeatherIntensity(Vector3D, MyObjectBuilder_WeatherEffect)](VRage.Game.ModAPI.IMyWeatherEffects@GetWeatherIntensity)|Gets weather intensity in point for provided weather|
|[GetWeatherPlanetData()](VRage.Game.ModAPI.IMyWeatherEffects@GetWeatherPlanetData)|Gets list (not a copy) of all weathers that are currently running|
|[GetWindMultiplier(Vector3D)](VRage.Game.ModAPI.IMyWeatherEffects@GetWindMultiplier)|Gets weather temperature multiplier in point for provided weather|
|[GetWindMultiplier(Vector3D, MyObjectBuilder_WeatherEffect)](VRage.Game.ModAPI.IMyWeatherEffects@GetWindMultiplier)|Gets weather solar multiplier in point for provided weather|
|[RemoveWeather(Vector3D)](VRage.Game.ModAPI.IMyWeatherEffects@RemoveWeather)|Removes weather at specific location|
|[RemoveWeather(MyObjectBuilder_WeatherEffect)](VRage.Game.ModAPI.IMyWeatherEffects@RemoveWeather)|Removes weather by its object builder|
|[SetWeather(string, float, Vector3D?, bool, Vector3D, int, float)](VRage.Game.ModAPI.IMyWeatherEffects@SetWeather)|Sets weather|

