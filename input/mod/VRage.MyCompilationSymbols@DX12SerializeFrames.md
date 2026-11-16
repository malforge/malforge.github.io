## Summary

```csharp
public static bool DX12SerializeFrames
```

Diagnostic: block in`Present`until the GPU has finished the whole frame, removing all CPU/GPU overlap while leaving parallel recording intact. Discriminates a cross-frame write-under-read (a buffer rewritten by frame N+1 while frame N's draws still read it) from a recording race — the former disappears here, the latter does not. Halves throughput; never ship it on.

## Returns

[bool](https://docs.microsoft.com/en-us/dotnet/api/System.Boolean?view=netframework-4.6)

