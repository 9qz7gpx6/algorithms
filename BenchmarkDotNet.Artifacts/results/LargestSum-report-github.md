```

BenchmarkDotNet v0.13.12, Windows 11 (10.0.22631.3296/23H2/2023Update/SunValley3)
Intel Core i7-10510U CPU 1.80GHz, 1 CPU, 8 logical and 4 physical cores
.NET SDK 8.0.101
  [Host]     : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.1 (8.0.123.58001), X64 RyuJIT AVX2


```
| Method                                   | Mean          | Error        | StdDev       |
|----------------------------------------- |--------------:|-------------:|-------------:|
| MaxDiagonalSumBruteForce                 | 207,728.29 μs | 1,611.352 μs | 2,310.953 μs |
| MaxDiagonal3Loops                        | 368,251.09 μs | 6,451.501 μs | 6,336.236 μs |
| MaxDiagonalConvertingMatrixToList        |   2,077.69 μs |    20.152 μs |    17.864 μs |
| MaxDiagonalConvertingMatrixToOrderedList |  17,119.16 μs |   165.829 μs |   155.117 μs |
| MaxDiagonalTwoLargestNumbers             |      38.40 μs |     0.273 μs |     0.242 μs |
