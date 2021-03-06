# NetFabric.DoubleLinkedList

![GitHub last commit (master)](https://img.shields.io/github/last-commit/NetFabric/NetFabric.DoubleLinkedList/master.svg?logo=github&logoColor=lightgray&style=popout-square)
[![NuGet Version](https://img.shields.io/nuget/v/NetFabric.DoubleLinkedList.svg?style=popout-square&logoColor=lightgray&logo=nuget)](https://www.nuget.org/packages/NetFabric.DoubleLinkedList/)
[![NuGet Downloads](https://img.shields.io/nuget/dt/NetFabric.DoubleLinkedList.svg?style=popout-square&logoColor=lightgray&logo=nuget)](https://www.nuget.org/packages/NetFabric.DoubleLinkedList/)
[![Build](https://img.shields.io/azure-devops/build/aalmada/NetFabric.DoubleLinkedList/2/master.svg?style=popout-square&logo=data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxMiIgaGVpZ2h0PSIxMiI+PGcgZmlsbD0iIzlmOWY5ZiIgZmlsbC1ydWxlPSJldmVub2RkIiBjbGlwLXJ1bGU9ImV2ZW5vZGQiPjxwYXRoIGQ9Ik0wIDloMXYyaDJ2MUgwek0uNjY3IDRoMy4wNjhMNi4yMDMuNDQ0QzYuMzkuMTY3IDYuNzAxIDAgNy4wMzUgMEgxMS41YS41LjUgMCAwIDEgLjUuNXY0LjQ2NWExIDEgMCAwIDEtLjQ0NS44MzJMOCA4LjI2NXYzLjA2OGEuNjY3LjY2NyAwIDAgMS0uNjY3LjY2N0g1bC0xLTEgMS4yNS0xLjI1LTEtMUwzIDEwIDIgOWwxLjI1LTEuMjUtMS0xTDEgOCAwIDdWNC42NjdDMCA0LjI5OS4yOTggNCAuNjY3IDR6TTEwLjUgM2ExLjUgMS41IDAgMSAxLTMgMCAxLjUgMS41IDAgMCAxIDMgMHoiLz48L2c+PC9zdmc+)](https://dev.azure.com/aalmada/NetFabric.DoubleLinkedList)
[![Unit Tests](https://img.shields.io/azure-devops/tests/aalmada/NetFabric.DoubleLinkedList/2/master.svg?style=popout-square&logo=data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxMiIgaGVpZ2h0PSIxMiI+PGcgZmlsbD0iIzlmOWY5ZiIgZmlsbC1ydWxlPSJldmVub2RkIiBjbGlwLXJ1bGU9ImV2ZW5vZGQiPjxwYXRoIGQ9Ik0wIDloMXYyaDJ2MUgwek0uNjY3IDRoMy4wNjhMNi4yMDMuNDQ0QzYuMzkuMTY3IDYuNzAxIDAgNy4wMzUgMEgxMS41YS41LjUgMCAwIDEgLjUuNXY0LjQ2NWExIDEgMCAwIDEtLjQ0NS44MzJMOCA4LjI2NXYzLjA2OGEuNjY3LjY2NyAwIDAgMS0uNjY3LjY2N0g1bC0xLTEgMS4yNS0xLjI1LTEtMUwzIDEwIDIgOWwxLjI1LTEuMjUtMS0xTDEgOCAwIDdWNC42NjdDMCA0LjI5OS4yOTggNCAuNjY3IDR6TTEwLjUgM2ExLjUgMS41IDAgMSAxLTMgMCAxLjUgMS41IDAgMCAxIDMgMHoiLz48L2c+PC9zdmc+)](https://dev.azure.com/aalmada/NetFabric.DoubleLinkedList)
[![Coverage](https://img.shields.io/azure-devops/coverage/aalmada/NetFabric.DoubleLinkedList/2/master.svg?style=popout-square&logo=data:image/svg+xml;base64,PHN2ZyB4bWxucz0iaHR0cDovL3d3dy53My5vcmcvMjAwMC9zdmciIHdpZHRoPSIxMiIgaGVpZ2h0PSIxMiI+PGcgZmlsbD0iIzlmOWY5ZiIgZmlsbC1ydWxlPSJldmVub2RkIiBjbGlwLXJ1bGU9ImV2ZW5vZGQiPjxwYXRoIGQ9Ik0wIDloMXYyaDJ2MUgwek0uNjY3IDRoMy4wNjhMNi4yMDMuNDQ0QzYuMzkuMTY3IDYuNzAxIDAgNy4wMzUgMEgxMS41YS41LjUgMCAwIDEgLjUuNXY0LjQ2NWExIDEgMCAwIDEtLjQ0NS44MzJMOCA4LjI2NXYzLjA2OGEuNjY3LjY2NyAwIDAgMS0uNjY3LjY2N0g1bC0xLTEgMS4yNS0xLjI1LTEtMUwzIDEwIDIgOWwxLjI1LTEuMjUtMS0xTDEgOCAwIDdWNC42NjdDMCA0LjI5OS4yOTggNCAuNjY3IDR6TTEwLjUgM2ExLjUgMS41IDAgMSAxLTMgMCAxLjUgMS41IDAgMCAxIDMgMHoiLz48L2c+PC9zdmc+)](https://dev.azure.com/aalmada/NetFabric.DoubleLinkedList)

An alternative to the [`System.Collections.Generic.LinkedList<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1) with reverse operation and enumeration without allocation.

The public API is very similar but the internals are very different with a more efficient implementation. 

New overrides and methods were added to minimizing the memory allocations, number of loops, conditions and assignments required in multiple scenarios.

## Benchmarks

Performance comparison between [`System.Collections.Generic.LinkedList<T>`](https://docs.microsoft.com/en-us/dotnet/api/system.collections.generic.linkedlist-1) and `DoubleLinkedList<T>`. Shorter is better.

![constructor performance](https://user-images.githubusercontent.com/534533/49696258-7a98b480-fb9f-11e8-9a06-3585e4dc684b.png)

![forward enumeration performance](https://user-images.githubusercontent.com/534533/49405413-40b45200-f74a-11e8-9b63-4ac67efd144d.png)

![reverse enumeration performance](https://user-images.githubusercontent.com/534533/49405544-a43e7f80-f74a-11e8-9aba-544cb3141e33.png)

The benchmarks project is part of the repository. You can check the code and run it on your machine.

## Forward and reverse enumeration

`DoubleLinkedList<T>` does not implement `IEnumerable<T>`. Call the methods `EnumerateForward()` or `EnumerateReversed()` to get an enumerator that goes in the direction you require.

```csharp
var list = new DoubleLinkedList<int>(new[] {1, 2, 3, 4});
foreach (var item in list.EnumerateReversed())
	Console.Write(item);
```
outputs
```
4321
```

Although these enumerators are optimized for performance, they perform a bit more method calls and conditions than simply using a `while` loop to go throught the `Node` references. The performance penalty can be seen on the benchmarks above. The advantage is that these can be used with [LINQ](https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/concepts/linq/) or any third-party method that takes `IEnumerable`, `IEnumerable<T>` or `IReadOnlyCollection<T>` as parameter.

```csharp
var list = new DoubleLinkedList<int>(new[] {1, 2, 3, 4});
Console.Write(list.EnumerateReversed().First());
```
outputs
```
4
```

## `AddFirst()` and `AddLast()`

These methods now support the addition of collections of items. These can come from an `IEnumerable<T>`, `IReadOnlyList<T>` or another `DoubleLinkedList<T>`. 

When the parameter is `IReadOnlyList<T>` or `DoubleLinkedList<T>`, they can be added reversed.

```csharp
var list = new DoubleLinkedList<int>(new[] {1, 2, 3, 4});
var anotherList = new DoubleLinkedList<int>(new[] {5, 6, 7, 8});
list.AddFirst(anotherList, true);
foreach (var item in list.EnumerateForward())
	Console.Write(item);
```

outputs

```csharp
87651234
```

## `AddFirstFrom()` and `AddLastFrom()`

These methods perform the addition of a `DoubleLinkedList<T>` but moving the nodes into the other `DoubleLinkedList<T>`. No memory allocations and copies of values are performed.

The `DoubleLinkedList<T>` passed as parameter becomes empty.

## `Append()` 

A static method that returns a `DoubleLinkedList<T>` instance with the items of both lists appended. 

```csharp
var list = DoubleLinkedList.Append(
	new DoubleLinkedList<int>(new[] {1, 2, 3, 4}), 
	new DoubleLinkedList<int>(new[] {5, 6, 7, 8}));
foreach (var item in list.EnumerateForward())
	Console.Write(item);
```

outputs

```
12345678
```

## `Clone()` 

Returns a shallow clone of the a `DoubleLinkedList<T>`. 

```csharp
var list = new DoubleLinkedList<int>(new[] {1, 2, 3, 4});
var clone = list.Clone();
foreach (var item in list.EnumerateForward())
	Console.Write(item);
```

outputs

```
1234
```

## `Reverse()` 

Returns a shallow clone of the a `DoubleLinkedList<T>` with the items in reversed order.

```csharp
var list = new DoubleLinkedList<int>(new[] {1, 2, 3, 4});
var reversed = list.Reverse();
foreach (var item in reversed.EnumerateForward())
	Console.Write(item);
```

outputs

```
4321
```

## `ReverseInPlace()` 

`ReverseInPlace()` reverses the list items in-place. It flips the internal node references with no memory allocations.

```csharp
var list = new DoubleLinkedList<int>(new[] {1, 2, 3, 4});
list.ReverseInPlace();
foreach (var item in list.EnumerateForward())
	Console.Write(item);
```

also outputs

```
4321
```

## 