// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.Threading.Tasks;
using Refit;

namespace RefitJsonBenchmarks.GitHub
{
    [Headers("Accept: application/vnd.github.v3+json", "User-Agent: Refit-Json-Benchmarks/1.0.0")]
    public interface IGitHub
    {
        [Get("/repos/{owner}/{repo}/issues")]
        Task CreateIssueAsync(string owner, string repo, [Body] CreateIssue issue);

        [Get("/orgs/{organization}")]
        Task<Organization> GetOrganizationAsync(string organization);

        [Get("/orgs/{organization}/repos")]
        Task<ICollection<Repository>> GetRepositoriesAsync(string organization);
    }
}
