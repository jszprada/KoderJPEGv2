``` ini

BenchmarkDotNet=v0.13.3, OS=Windows 10 (10.0.19045.2486)
AMD Ryzen 5 1500X, 1 CPU, 8 logical and 4 physical cores
.NET SDK=7.0.100-rc.2.22477.23
  [Host] : .NET 7.0.0 (7.0.22.47203), X64 RyuJIT AVX2

Job=InProcess  Toolchain=InProcessEmitToolchain  

```
|                         Method | Quality |    Mean |    Error |   StdDev |  Median |     Min |     Max | Completed Work Items | Lock Contentions |      Gen0 |      Gen1 |      Gen2 | Allocated |
|------------------------------- |-------- |--------:|---------:|---------:|--------:|--------:|--------:|---------------------:|-----------------:|----------:|----------:|----------:|----------:|
|      **ConvertWithLowestPriority** |      **20** | **1.663 s** | **0.0236 s** | **0.0221 s** | **1.668 s** | **1.607 s** | **1.700 s** |             **100.0000** |                **-** |         **-** |         **-** |         **-** |   **2.02 MB** |
| ConvertWithBelowNormalPriority |      20 | 1.652 s | 0.0166 s | 0.0147 s | 1.652 s | 1.625 s | 1.685 s |             100.0000 |                - |         - |         - |         - |   2.02 MB |
|      ConvertWithNormalPriority |      20 | 1.643 s | 0.0214 s | 0.0200 s | 1.643 s | 1.608 s | 1.678 s |             100.0000 |                - |         - |         - |         - |   2.02 MB |
| ConvertWithAboveNormalPriority |      20 | 1.649 s | 0.0218 s | 0.0193 s | 1.648 s | 1.618 s | 1.684 s |             100.0000 |                - |         - |         - |         - |   2.02 MB |
|     ConvertWithHighestPriority |      20 | 1.657 s | 0.0189 s | 0.0177 s | 1.655 s | 1.630 s | 1.698 s |             100.0000 |                - |         - |         - |         - |   2.02 MB |
|      **ConvertWithLowestPriority** |      **40** | **1.685 s** | **0.0258 s** | **0.0215 s** | **1.686 s** | **1.653 s** | **1.717 s** |             **100.0000** |                **-** |         **-** |         **-** |         **-** |   **2.02 MB** |
| ConvertWithBelowNormalPriority |      40 | 1.684 s | 0.0330 s | 0.0309 s | 1.682 s | 1.611 s | 1.735 s |             101.0000 |                - |         - |         - |         - |   2.02 MB |
|      ConvertWithNormalPriority |      40 | 1.695 s | 0.0310 s | 0.0290 s | 1.692 s | 1.650 s | 1.759 s |             101.0000 |                - |         - |         - |         - |   2.03 MB |
| ConvertWithAboveNormalPriority |      40 | 1.684 s | 0.0244 s | 0.0216 s | 1.685 s | 1.635 s | 1.710 s |             100.0000 |                - |         - |         - |         - |   2.02 MB |
|     ConvertWithHighestPriority |      40 | 1.696 s | 0.0194 s | 0.0181 s | 1.696 s | 1.669 s | 1.749 s |             101.0000 |                - |         - |         - |         - |   2.02 MB |
|      **ConvertWithLowestPriority** |      **60** | **1.952 s** | **0.0611 s** | **0.1801 s** | **2.035 s** | **1.672 s** | **2.198 s** |             **100.0000** |                **-** |         **-** |         **-** |         **-** |   **2.02 MB** |
| ConvertWithBelowNormalPriority |      60 | 1.704 s | 0.0166 s | 0.0155 s | 1.704 s | 1.679 s | 1.730 s |             100.0000 |                - |         - |         - |         - |   2.03 MB |
|      ConvertWithNormalPriority |      60 | 1.705 s | 0.0288 s | 0.0269 s | 1.696 s | 1.676 s | 1.760 s |             101.0000 |                - |         - |         - |         - |   2.02 MB |
| ConvertWithAboveNormalPriority |      60 | 1.709 s | 0.0263 s | 0.0246 s | 1.702 s | 1.670 s | 1.766 s |             100.0000 |                - |         - |         - |         - |   2.02 MB |
|     ConvertWithHighestPriority |      60 | 1.708 s | 0.0253 s | 0.0211 s | 1.710 s | 1.673 s | 1.741 s |             100.0000 |                - |         - |         - |         - |   2.02 MB |
|      **ConvertWithLowestPriority** |      **80** | **1.737 s** | **0.0128 s** | **0.0100 s** | **1.737 s** | **1.718 s** | **1.752 s** |             **100.0000** |                **-** |         **-** |         **-** |         **-** |   **2.27 MB** |
| ConvertWithBelowNormalPriority |      80 | 1.737 s | 0.0212 s | 0.0198 s | 1.739 s | 1.693 s | 1.772 s |             100.0000 |                - |         - |         - |         - |   2.02 MB |
|      ConvertWithNormalPriority |      80 | 1.770 s | 0.0342 s | 0.0336 s | 1.779 s | 1.719 s | 1.829 s |             100.0000 |                - |         - |         - |         - |   2.02 MB |
| ConvertWithAboveNormalPriority |      80 | 1.746 s | 0.0290 s | 0.0271 s | 1.753 s | 1.685 s | 1.801 s |             100.0000 |                - |         - |         - |         - |   2.03 MB |
|     ConvertWithHighestPriority |      80 | 1.750 s | 0.0277 s | 0.0246 s | 1.753 s | 1.711 s | 1.802 s |             100.0000 |                - |         - |         - |         - |   2.02 MB |
|      **ConvertWithLowestPriority** |     **100** | **2.365 s** | **0.0279 s** | **0.0248 s** | **2.362 s** | **2.329 s** | **2.406 s** |             **101.0000** |                **-** |         **-** |         **-** |         **-** |   **1.63 MB** |
| ConvertWithBelowNormalPriority |     100 | 2.354 s | 0.0207 s | 0.0184 s | 2.355 s | 2.303 s | 2.382 s |             100.0000 |                - |         - |         - |         - |   1.62 MB |
|      ConvertWithNormalPriority |     100 | 2.357 s | 0.0408 s | 0.0341 s | 2.366 s | 2.285 s | 2.406 s |             100.0000 |                - |         - |         - |         - |   1.62 MB |
| ConvertWithAboveNormalPriority |     100 | 2.353 s | 0.0217 s | 0.0182 s | 2.354 s | 2.307 s | 2.373 s |             100.0000 |                - | 1000.0000 | 1000.0000 | 1000.0000 |   1.64 MB |
|     ConvertWithHighestPriority |     100 | 2.360 s | 0.0239 s | 0.0235 s | 2.351 s | 2.333 s | 2.410 s |             100.0000 |                - |         - |         - |         - |   1.87 MB |
