# BenchmarkWithDependencyInjection

// * Summary *

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.7171)
Intel Core Ultra 9 185H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
  DefaultJob : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2


| Method              | Mean         | Error      | StdDev     | Gen0   | Gen1   | Allocated |
|-------------------- |-------------:|-----------:|-----------:|-------:|-------:|----------:|
| Eager               |  3,197.44 ns |  20.540 ns |  19.213 ns | 0.8163 | 0.0229 |   10272 B |
| Eager_access        |  3,250.08 ns |  63.279 ns |  92.753 ns | 0.8163 | 0.0229 |   10272 B |
| Eager_access_scoped |     24.20 ns |   0.125 ns |   0.098 ns |      - |      - |         - |
| Lazy                |    302.95 ns |   2.579 ns |   2.412 ns | 0.0973 |      - |    1224 B |
| Lazy_access         | 23,479.49 ns | 157.998 ns | 140.061 ns | 4.1809 | 0.2747 |   52815 B |
| Lazy_access_scoped  |     23.17 ns |   0.103 ns |   0.092 ns |      - |      - |         - |




# Benchmark

// * Summary *

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.7171)
Intel Core Ultra 9 185H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.100
  [Host]     : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2
  DefaultJob : .NET 10.0.0 (10.0.25.52411), X64 RyuJIT AVX2


| Method       | Mean        | Error     | StdDev      | Gen0   | Gen1   | Allocated |
|------------- |------------:|----------:|------------:|-------:|-------:|----------:|
| Eager        |  3,451.0 ns |  65.37 ns |    75.28 ns | 0.7858 | 0.0229 |    9872 B |
| Eager_access |  3,501.6 ns |  66.94 ns |    87.04 ns | 0.7858 | 0.0229 |    9872 B |
| Lazy         |    223.0 ns |   4.41 ns |    10.48 ns | 0.0656 |      - |     824 B |
| Lazy_access  | 29,493.7 ns | 584.51 ns | 1,053.99 ns | 4.1504 | 0.3052 |   52414 B |
