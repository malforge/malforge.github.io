**Assembly:** VRage.dll

```csharp
public struct MyCubeInstanceData
```

## Fields

|Member|Description|
|---|---|
|[ColorMaskHSV](VRage.MyCubeInstanceData@ColorMaskHSV)||
|[m_translationAndRot](VRage.MyCubeInstanceData@m_translationAndRot)||

## Properties

|Member|Description|
|---|---|
|[BoneRange](VRage.MyCubeInstanceData@BoneRange)||
|[EnableSkinning](VRage.MyCubeInstanceData@EnableSkinning)||
|[Item](VRage.MyCubeInstanceData@Item)||
|[LocalMatrix](VRage.MyCubeInstanceData@LocalMatrix)||
|[PackedOrthoMatrix](VRage.MyCubeInstanceData@PackedOrthoMatrix)||
|[Translation](VRage.MyCubeInstanceData@Translation)|Gets translation, faster than getting local matrix|

## Methods

|Member|Description|
|---|---|
|[ComputeBoneOffset(ref Vector4UByte, ref Vector4)](VRage.MyCubeInstanceData@ComputeBoneOffset)||
|[ConstructDeformedCubeInstanceMatrix(ref Vector4UByte, ref Vector4, out Matrix)](VRage.MyCubeInstanceData@ConstructDeformedCubeInstanceMatrix)||
|[GetDenormalizedBone(int)](VRage.MyCubeInstanceData@GetDenormalizedBone)||
|[GetPackedBone(int)](VRage.MyCubeInstanceData@GetPackedBone)||
|[GetTextureOffset(int)](VRage.MyCubeInstanceData@GetTextureOffset)||
|[ResetBones()](VRage.MyCubeInstanceData@ResetBones)|Resets bones to zero and disables skinning|
|[RetrieveBones(*byte)](VRage.MyCubeInstanceData@RetrieveBones)||
|[SetColorMaskHSV(Vector4)](VRage.MyCubeInstanceData@SetColorMaskHSV)||
|[SetTextureOffset(Vector4UByte)](VRage.MyCubeInstanceData@SetTextureOffset)||

