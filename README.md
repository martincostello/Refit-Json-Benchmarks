# Refit JSON Benchmarks

This repository contains benchmarks for [Refit](https://github.com/reactiveui/refit) that compare using [Newtonsoft.Json](https://github.com/JamesNK/Newtonsoft.Json) with the new [System.Text.Json](https://devblogs.microsoft.com/dotnet/try-the-new-system-text-json-apis/) APIs in .NET Core 3.0.

To run the benchmarks yourself:

  1. Install [.NET Core 3.0 preview 6](https://dotnet.microsoft.com/download/dotnet-core/3.0).
  1. Clone [this repository](https://github.com/martincostello/Refit-Json-Benchmarks).
  1. Run `benchmark.ps1` or `benchmark.sh`.

## Results

Below are the benchmark results from my own laptop (your mileage may vary).

### Reading a collection

``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT


```
|                         Method |     Mean |     Error |    StdDev |   Median | Ratio | RatioSD |   Gen 0 |   Gen 1 | Gen 2 | Allocated |
|------------------------------- |---------:|----------:|----------:|---------:|------:|--------:|--------:|--------:|------:|----------:|
| Read_Collection_NewtonsoftJson | 2.366 ms | 0.1675 ms | 0.4911 ms | 2.504 ms |  1.00 |    0.00 |       - |       - |     - | 297.95 KB |
| Read_Collection_SystemTextJson | 1.404 ms | 0.0280 ms | 0.0693 ms | 1.385 ms |  0.55 |    0.09 | 46.8750 | 23.4375 |     - | 270.18 KB |

### Reading an object

``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT


```
|                     Method |      Mean |      Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|--------------------------- |----------:|-----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
| Read_Object_NewtonsoftJson | 219.60 us | 20.5281 us | 59.881 us |  1.00 |    0.00 |      - |     - |     - |  14.15 KB |
| Read_Object_SystemTextJson |  29.42 us |  0.6467 us |  1.116 us |  0.13 |    0.03 | 2.0752 |     - |     - |   6.49 KB |


### Writing an object

``` ini

BenchmarkDotNet=v0.11.5, OS=Windows 10.0.18362
Intel Core i7-6700HQ CPU 2.60GHz (Skylake), 1 CPU, 8 logical and 4 physical cores
.NET Core SDK=3.0.100-preview6-012264
  [Host]     : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT
  DefaultJob : .NET Core 3.0.0-preview6-27804-01 (CoreCLR 4.700.19.30373, CoreFX 4.700.19.30308), 64bit RyuJIT


```
|                      Method |     Mean |     Error |    StdDev | Ratio | RatioSD |  Gen 0 | Gen 1 | Gen 2 | Allocated |
|---------------------------- |---------:|----------:|----------:|------:|--------:|-------:|------:|------:|----------:|
| Write_Object_NewtonsoftJson | 22.79 us | 0.4491 us | 0.4201 us |  1.00 |    0.00 | 2.6245 |     - |     - |   8.09 KB |
| Write_Object_SystemTextJson | 16.23 us | 0.2553 us | 0.2263 us |  0.71 |    0.02 | 1.9531 |     - |     - |   6.13 KB |
