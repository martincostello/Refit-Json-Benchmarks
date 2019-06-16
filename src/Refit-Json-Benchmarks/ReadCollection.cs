// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using RefitJsonBenchmarks.GitHub;

namespace RefitJsonBenchmarks
{
    [MemoryDiagnoser]
    public class ReadCollection : RefitBenchmark
    {
        private static readonly IGitHub NewtonsoftJsonClient = CreateClient(CreateNewtonsoftJsonContentSerializer());
        private static readonly IGitHub SystemTextJsonClient = CreateClient(CreateSystemTextJsonContentSerializer());

        [Benchmark(Baseline = true)]
        public async Task<ICollection<Repository>> Read_Collection_NewtonsoftJson()
            => await NewtonsoftJsonClient.GetRepositoriesAsync("dotnet");

        [Benchmark]
        public async Task<ICollection<Repository>> Read_Collection_SystemTextJson()
            => await SystemTextJsonClient.GetRepositoriesAsync("dotnet");
    }
}
