**Assembly:** VRage.Library.dll

```csharp
public class ConcurrentCachingLinkedList<T>: IEnumerable<T>, IEnumerable
```

## Properties

|Member|Description|
|---|---|
|[Count](VRage.Collections.ConcurrentCachingLinkedList{T}@Count)||
|[IsEmpty](VRage.Collections.ConcurrentCachingLinkedList{T}@IsEmpty)||

## Constructors

|Member|Description|
|---|---|
|[ConcurrentCachingLinkedList(Action<T, LinkedListNode<T>>, Func<T, LinkedListNode<T>>)](VRage.Collections.ConcurrentCachingLinkedList{T}@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Add(T)](VRage.Collections.ConcurrentCachingLinkedList{T}@Add)||
|[ApplyAdditions()](VRage.Collections.ConcurrentCachingLinkedList{T}@ApplyAdditions)||
|[ApplyChanges()](VRage.Collections.ConcurrentCachingLinkedList{T}@ApplyChanges)||
|[ApplyRemovals()](VRage.Collections.ConcurrentCachingLinkedList{T}@ApplyRemovals)||
|[ClearImmediate()](VRage.Collections.ConcurrentCachingLinkedList{T}@ClearImmediate)||
|[ClearList()](VRage.Collections.ConcurrentCachingLinkedList{T}@ClearList)||
|[DebugCheckEmpty()](VRage.Collections.ConcurrentCachingLinkedList{T}@DebugCheckEmpty)||
|[GetEnumerator()](VRage.Collections.ConcurrentCachingLinkedList{T}@GetEnumerator)||
|[Invoke(Action)](VRage.Collections.ConcurrentCachingLinkedList{T}@Invoke)||
|[Remove(T, bool)](VRage.Collections.ConcurrentCachingLinkedList{T}@Remove)||
|[ToString()](VRage.Collections.ConcurrentCachingLinkedList{T}@ToString)||

**Implements:**  
* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=netframework-4.6)  
* [IEnumerable<T>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)

