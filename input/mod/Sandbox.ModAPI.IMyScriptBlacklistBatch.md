**Assembly:** Sandbox.Common.dll

```csharp
public interface IMyScriptBlacklistBatch: IDisposable
```

A handle which enables adding members to the blacklist in a batch. It is highly recommended that you try to group your changes into as few batches as possible.

## Methods

|Member|Description|
|---|---|
|[AddMembers(Type, String[])](Sandbox.ModAPI.IMyScriptBlacklistBatch@AddMembers)|Adds only the specified members to the blacklist.|
|[AddNamespaceOfTypes(Type[])](Sandbox.ModAPI.IMyScriptBlacklistBatch@AddNamespaceOfTypes)|Adds the entire namespace of one or more given types to the blacklist|
|[AddTypes(Type[])](Sandbox.ModAPI.IMyScriptBlacklistBatch@AddTypes)|Adds one or more specific types and all their members to the blacklist.|
|[RemoveMembers(Type, String[])](Sandbox.ModAPI.IMyScriptBlacklistBatch@RemoveMembers)|Removes types previously added with [AddMembers(Type, String[])](Sandbox.ModAPI.IMyScriptBlacklistBatch@AddMembers) to the blacklist.|
|[RemoveNamespaceOfTypes(Type[])](Sandbox.ModAPI.IMyScriptBlacklistBatch@RemoveNamespaceOfTypes)|Removes namespaces previously added with [AddNamespaceOfTypes(Type[])](Sandbox.ModAPI.IMyScriptBlacklistBatch@AddNamespaceOfTypes) from the blacklist.|
|[RemoveTypes(Type[])](Sandbox.ModAPI.IMyScriptBlacklistBatch@RemoveTypes)|Removes types previously added with [AddTypes(Type[])](Sandbox.ModAPI.IMyScriptBlacklistBatch@AddTypes) from the blacklist.|

**Implements:**  
* [IDisposable](https://docs.microsoft.com/en-us/dotnet/api/System.IDisposable?view=netframework-4.6)

