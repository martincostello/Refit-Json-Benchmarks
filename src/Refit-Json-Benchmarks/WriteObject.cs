// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;
using RefitJsonBenchmarks.GitHub;

namespace RefitJsonBenchmarks
{
    [MemoryDiagnoser]
    public class WriteObject : RefitBenchmark
    {
        private static readonly IGitHub NewtonsoftJsonClient = CreateClient(CreateNewtonsoftJsonContentSerializer());
        private static readonly IGitHub SystemTextJsonClient = CreateClient(CreateSystemTextJsonContentSerializer());

        private static readonly CreateIssue Issue = new CreateIssue()
        {
            Title = "Found a bug",
            Body = "I'm having a problem with this.",
            Assignees = new[] { "dotnet-bot" },
            Milestone = 1,
            Labels = new[] { "bug" },
        };

        [Benchmark(Baseline = true)]
        public async Task Write_Object_NewtonsoftJson()
            => await NewtonsoftJsonClient.CreateIssueAsync("dotnet", "corefx", Issue);

        [Benchmark]
        public async Task Write_Object_SystemTextJson()
            => await SystemTextJsonClient.CreateIssueAsync("dotnet", "corefx", Issue);
    }
}
