## Summary

```csharp
public void Stop()
```

Brake and hold: keeps the AI thrust branch engaged with a zero command, which cancels velocity (5x slowdown envelope) and hovers. Full disengage only on death/removal. Cancels an in-flight order; an already-settled order keeps its recorded outcome.

