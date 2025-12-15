**Assembly:** VRage.Library.dll

```csharp
public abstract sealed class PathUtils
```

## Methods

|Member|Description|
|---|---|
|[static EnsureSafePath(string)](VRage.Library.Utils.PathUtils@EnsureSafePath)|Should be called in each function that is accessible to modders and working with files: opening, deleting, moving|
|[static GetFilesRecursively(string, string)](VRage.Library.Utils.PathUtils@GetFilesRecursively)|Gets Files Recursively from specified path with specified search pattern. Method gives access only to sub-folders of User Data Path or Mods Path.|
|[static Normalize(string)](VRage.Library.Utils.PathUtils@Normalize)|This fixes paths for the current platform.|

