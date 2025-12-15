**Assembly:** VRage.Library.dll

```csharp
public class MyConcurrentList<T>: IMyQueue<T>, IList<T>, ICollection<T>, IEnumerable<T>, IEnumerable
```

## Properties

|Member|Description|
|---|---|
|[Count](VRage.Collections.MyConcurrentList{T}@Count)||
|[Empty](VRage.Collections.MyConcurrentList{T}@Empty)||
|[IsReadOnly](VRage.Collections.MyConcurrentList{T}@IsReadOnly)||
|[Item](VRage.Collections.MyConcurrentList{T}@Item)||
|[List](VRage.Collections.MyConcurrentList{T}@List)||
|[ListUnsafe](VRage.Collections.MyConcurrentList{T}@ListUnsafe)||

## Constructors

|Member|Description|
|---|---|
|[MyConcurrentList(int)](VRage.Collections.MyConcurrentList{T}@.ctor)||
|[MyConcurrentList()](VRage.Collections.MyConcurrentList{T}@.ctor)||

## Methods

|Member|Description|
|---|---|
|[Add(T)](VRage.Collections.MyConcurrentList{T}@Add)||
|[AddRange(IEnumerable<T>)](VRage.Collections.MyConcurrentList{T}@AddRange)||
|[Clear()](VRage.Collections.MyConcurrentList{T}@Clear)||
|[Contains(T)](VRage.Collections.MyConcurrentList{T}@Contains)||
|[CopyTo(T[], int)](VRage.Collections.MyConcurrentList{T}@CopyTo)||
|[GetEnumerator()](VRage.Collections.MyConcurrentList{T}@GetEnumerator)||
|[IndexOf(T)](VRage.Collections.MyConcurrentList{T}@IndexOf)||
|[Insert(int, T)](VRage.Collections.MyConcurrentList{T}@Insert)||
|[Pop()](VRage.Collections.MyConcurrentList{T}@Pop)||
|[Remove(T)](VRage.Collections.MyConcurrentList{T}@Remove)||
|[RemoveAll(Predicate<T>)](VRage.Collections.MyConcurrentList{T}@RemoveAll)||
|[RemoveAt(int)](VRage.Collections.MyConcurrentList{T}@RemoveAt)||
|[Sort(IComparer<T>)](VRage.Collections.MyConcurrentList{T}@Sort)||
|[TryDequeueBack(out T)](VRage.Collections.MyConcurrentList{T}@TryDequeueBack)||
|[TryDequeueFront(out T)](VRage.Collections.MyConcurrentList{T}@TryDequeueFront)||

**Implements:**  
* [ICollection<T>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.ICollection-1?view=netframework-4.6)  
* [IEnumerable](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.IEnumerable?view=netframework-4.6)  
* [IEnumerable<T>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IEnumerable-1?view=netframework-4.6)  
* [IList<T>](https://docs.microsoft.com/en-us/dotnet/api/System.Collections.Generic.IList-1?view=netframework-4.6)  
* IMyQueue<T> <sub>prohibited</sub>

