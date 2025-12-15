**Assembly:** Sandbox.Game.dll

```csharp
public class MyCampaignManager
```

## Fields

|Member|Description|
|---|---|
|[static AfterCampaignLocalizationsLoaded](Sandbox.Game.MyCampaignManager@AfterCampaignLocalizationsLoaded)||
|[OnCampaignMissionFinished](Sandbox.Game.MyCampaignManager@OnCampaignMissionFinished)||

## Events

|Member|Description|
|---|---|
|[static OnActiveCampaignChanged](Sandbox.Game.MyCampaignManager@OnActiveCampaignChanged)||
|[OnCampaignFinished](Sandbox.Game.MyCampaignManager@OnCampaignFinished)||
|[OnCampaignFinishing](Sandbox.Game.MyCampaignManager@OnCampaignFinishing)||

## Properties

|Member|Description|
|---|---|
|[static Static](Sandbox.Game.MyCampaignManager@Static)||
|[ActiveCampaign](Sandbox.Game.MyCampaignManager@ActiveCampaign)||
|[ActiveCampaignLevels](Sandbox.Game.MyCampaignManager@ActiveCampaignLevels)||
|[ActiveCampaignName](Sandbox.Game.MyCampaignManager@ActiveCampaignName)||
|[CampaignNames](Sandbox.Game.MyCampaignManager@CampaignNames)||
|[Campaigns](Sandbox.Game.MyCampaignManager@Campaigns)||
|[CrossPlatform](Sandbox.Game.MyCampaignManager@CrossPlatform)||
|[IsCampaignRunning](Sandbox.Game.MyCampaignManager@IsCampaignRunning)||
|[IsNewCampaignLevelLoading](Sandbox.Game.MyCampaignManager@IsNewCampaignLevelLoading)||
|[IsScenarioRunning](Sandbox.Game.MyCampaignManager@IsScenarioRunning)||
|[LocalizationLanguages](Sandbox.Game.MyCampaignManager@LocalizationLanguages)||
|[RefreshSubscribedModDataResult](Sandbox.Game.MyCampaignManager@RefreshSubscribedModDataResult)||

## Constructors

|Member|Description|
|---|---|
|[MyCampaignManager()](Sandbox.Game.MyCampaignManager@.ctor)||

## Methods

|Member|Description|
|---|---|
|[FindStartingState(MyObjectBuilder_CampaignSM)](Sandbox.Game.MyCampaignManager@FindStartingState)|Finds starting state of the campaign SM. For purposes of first load.|
|[ForceRefreshModData()](Sandbox.Game.MyCampaignManager@ForceRefreshModData)||
|[GetCampaign(string)](Sandbox.Game.MyCampaignManager@GetCampaign)||
|[HasStartedAsCampaign(string)](Sandbox.Game.MyCampaignManager@HasStartedAsCampaign)||
|[Init()](Sandbox.Game.MyCampaignManager@Init)|Loads campaign data to storage.|
|[IsCampaign(MyObjectBuilder_CampaignSessionComponent)](Sandbox.Game.MyCampaignManager@IsCampaign)||
|[IsCampaign(string, bool, ulong)](Sandbox.Game.MyCampaignManager@IsCampaign)||
|[LoadCampaignLocalization()](Sandbox.Game.MyCampaignManager@LoadCampaignLocalization)||
|[NotifyCampaignFinishing()](Sandbox.Game.MyCampaignManager@NotifyCampaignFinishing)|Called from MyCampaignSessionComponent when campaign finishing. Do not use anywhere else.|
|[PublishActive(String[], String[])](Sandbox.Game.MyCampaignManager@PublishActive)|Runs publish process for active campaign.|
|[RefreshModData()](Sandbox.Game.MyCampaignManager@RefreshModData)||
|[ReloadMenuLocalization()](Sandbox.Game.MyCampaignManager@ReloadMenuLocalization)||
|[RunCampaign(string, bool, bool)](Sandbox.Game.MyCampaignManager@RunCampaign)||
|[RunNewCampaign(string, MyOnlineModeEnum, int, bool, bool)](Sandbox.Game.MyCampaignManager@RunNewCampaign)|starts new campaign|
|[SetExperimentalCampaign(MyObjectBuilder_Checkpoint)](Sandbox.Game.MyCampaignManager@SetExperimentalCampaign)||
|[SwitchCampaign(string, bool, ulong, string, string, bool)](Sandbox.Game.MyCampaignManager@SwitchCampaign)|Changes the manager state to given campaign.|

