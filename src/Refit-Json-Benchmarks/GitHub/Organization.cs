// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RefitJsonBenchmarks.GitHub
{
    public class Organization
    {
        [JsonProperty("login")]
        [JsonPropertyName("login")]
        public string Login { get; set; }

        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        [JsonPropertyName("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonProperty("repos_url")]
        [JsonPropertyName("repos_url")]
        public string ReposUrl { get; set; }

        [JsonProperty("events_url")]
        [JsonPropertyName("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("hooks_url")]
        [JsonPropertyName("hooks_url")]
        public string HooksUrl { get; set; }

        [JsonProperty("issues_url")]
        [JsonPropertyName("issues_url")]
        public string IssuesUrl { get; set; }

        [JsonProperty("members_url")]
        [JsonPropertyName("members_url")]
        public string MembersUrl { get; set; }

        [JsonProperty("public_members_url")]
        [JsonPropertyName("public_members_url")]
        public string PublicMembersUrl { get; set; }

        [JsonProperty("avatar_url")]
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("company")]
        [JsonPropertyName("company")]
        public object Company { get; set; }

        [JsonProperty("blog")]
        [JsonPropertyName("blog")]
        public string Blog { get; set; }

        [JsonProperty("location")]
        [JsonPropertyName("location")]
        public object Location { get; set; }

        [JsonProperty("email")]
        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonProperty("is_verified")]
        [JsonPropertyName("is_verified")]
        public bool IsVerified { get; set; }

        [JsonProperty("has_organization_projects")]
        [JsonPropertyName("has_organization_projects")]
        public bool HasOrganizationProjects { get; set; }

        [JsonProperty("has_repository_projects")]
        [JsonPropertyName("has_repository_projects")]
        public bool HasRepositoryProjects { get; set; }

        [JsonProperty("public_repos")]
        [JsonPropertyName("public_repos")]
        public long PublicRepos { get; set; }

        [JsonProperty("public_gists")]
        [JsonPropertyName("public_gists")]
        public long PublicGists { get; set; }

        [JsonProperty("followers")]
        [JsonPropertyName("followers")]
        public long Followers { get; set; }

        [JsonProperty("following")]
        [JsonPropertyName("following")]
        public long Following { get; set; }

        [JsonProperty("html_url")]
        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
