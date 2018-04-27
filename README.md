## Enumerator Utils

## Installation

```bash
dotnet add package wk.EnumeratorUtils
```

## Usage

```csharp
using EnumeratorUtils;

IEnumerator ints = ...
IEnumerable<int> e = ints.Cast<int>();
```