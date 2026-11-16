## Summary

```csharp
public void Open()
```

Puts the screen on top of the screen stack, where it takes focus and input. Does nothing when the screen is already open, and logs and returns rather than throwing when a screen cannot be opened at all: on a dedicated server, off the update thread, with no running session, or once too many mod screens are open.

