// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RefitJsonBenchmarks.GitHub
{
    public class Repository
    {
        [JsonProperty("id")]
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonProperty("node_id")]
        [JsonPropertyName("node_id")]
        public string NodeId { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("full_name")]
        [JsonPropertyName("full_name")]
        public string FullName { get; set; }

        [JsonProperty("private")]
        [JsonPropertyName("private")]
        public bool Private { get; set; }

        [JsonProperty("owner")]
        [JsonPropertyName("owner")]
        public Owner Owner { get; set; }

        [JsonProperty("html_url")]
        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("description")]
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonProperty("fork")]
        [JsonPropertyName("fork")]
        public bool Fork { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonProperty("forks_url")]
        [JsonPropertyName("forks_url")]
        public string ForksUrl { get; set; }

        [JsonProperty("keys_url")]
        [JsonPropertyName("keys_url")]
        public string KeysUrl { get; set; }

        [JsonProperty("collaborators_url")]
        [JsonPropertyName("collaborators_url")]
        public string CollaboratorsUrl { get; set; }

        [JsonProperty("teams_url")]
        [JsonPropertyName("teams_url")]
        public string TeamsUrl { get; set; }

        [JsonProperty("hooks_url")]
        [JsonPropertyName("hooks_url")]
        public string HooksUrl { get; set; }

        [JsonProperty("issue_events_url")]
        [JsonPropertyName("issue_events_url")]
        public string IssueEventsUrl { get; set; }

        [JsonProperty("events_url")]
        [JsonPropertyName("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("assignees_url")]
        [JsonPropertyName("assignees_url")]
        public string AssigneesUrl { get; set; }

        [JsonProperty("branches_url")]
        [JsonPropertyName("branches_url")]
        public string BranchesUrl { get; set; }

        [JsonProperty("tags_url")]
        [JsonPropertyName("tags_url")]
        public string TagsUrl { get; set; }

        [JsonProperty("blobs_url")]
        [JsonPropertyName("blobs_url")]
        public string BlobsUrl { get; set; }

        [JsonProperty("git_tags_url")]
        [JsonPropertyName("git_tags_url")]
        public string GitTagsUrl { get; set; }

        [JsonProperty("git_refs_url")]
        [JsonPropertyName("git_refs_url")]
        public string GitRefsUrl { get; set; }

        [JsonProperty("trees_url")]
        [JsonPropertyName("trees_url")]
        public string TreesUrl { get; set; }

        [JsonProperty("statuses_url")]
        [JsonPropertyName("statuses_url")]
        public string StatusesUrl { get; set; }

        [JsonProperty("languages_url")]
        [JsonPropertyName("languages_url")]
        public string LanguagesUrl { get; set; }

        [JsonProperty("stargazers_url")]
        [JsonPropertyName("stargazers_url")]
        public string StargazersUrl { get; set; }

        [JsonProperty("contributors_url")]
        [JsonPropertyName("contributors_url")]
        public string ContributorsUrl { get; set; }

        [JsonProperty("subscribers_url")]
        [JsonPropertyName("subscribers_url")]
        public string SubscribersUrl { get; set; }

        [JsonProperty("subscription_url")]
        [JsonPropertyName("subscription_url")]
        public string SubscriptionUrl { get; set; }

        [JsonProperty("commits_url")]
        [JsonPropertyName("commits_url")]
        public string CommitsUrl { get; set; }

        [JsonProperty("git_commits_url")]
        [JsonPropertyName("git_commits_url")]
        public string GitCommitsUrl { get; set; }

        [JsonProperty("comments_url")]
        [JsonPropertyName("comments_url")]
        public string CommentsUrl { get; set; }

        [JsonProperty("issue_comment_url")]
        [JsonPropertyName("issue_comment_url")]
        public string IssueCommentUrl { get; set; }

        [JsonProperty("contents_url")]
        [JsonPropertyName("contents_url")]
        public string ContentsUrl { get; set; }

        [JsonProperty("compare_url")]
        [JsonPropertyName("compare_url")]
        public string CompareUrl { get; set; }

        [JsonProperty("merges_url")]
        [JsonPropertyName("merges_url")]
        public string MergesUrl { get; set; }

        [JsonProperty("archive_url")]
        [JsonPropertyName("archive_url")]
        public string ArchiveUrl { get; set; }

        [JsonProperty("downloads_url")]
        [JsonPropertyName("downloads_url")]
        public string DownloadsUrl { get; set; }

        [JsonProperty("issues_url")]
        [JsonPropertyName("issues_url")]
        public string IssuesUrl { get; set; }

        [JsonProperty("pulls_url")]
        [JsonPropertyName("pulls_url")]
        public string PullsUrl { get; set; }

        [JsonProperty("milestones_url")]
        [JsonPropertyName("milestones_url")]
        public string MilestonesUrl { get; set; }

        [JsonProperty("notifications_url")]
        [JsonPropertyName("notifications_url")]
        public string NotificationsUrl { get; set; }

        [JsonProperty("labels_url")]
        [JsonPropertyName("labels_url")]
        public string LabelsUrl { get; set; }

        [JsonProperty("releases_url")]
        [JsonPropertyName("releases_url")]
        public string ReleasesUrl { get; set; }

        [JsonProperty("deployments_url")]
        [JsonPropertyName("deployments_url")]
        public string DeploymentsUrl { get; set; }

        [JsonProperty("created_at")]
        [JsonPropertyName("created_at")]
        public DateTimeOffset CreatedAt { get; set; }

        [JsonProperty("updated_at")]
        [JsonPropertyName("updated_at")]
        public DateTimeOffset UpdatedAt { get; set; }

        [JsonProperty("pushed_at")]
        [JsonPropertyName("pushed_at")]
        public DateTimeOffset PushedAt { get; set; }

        [JsonProperty("git_url")]
        [JsonPropertyName("git_url")]
        public string GitUrl { get; set; }

        [JsonProperty("ssh_url")]
        [JsonPropertyName("ssh_url")]
        public string SshUrl { get; set; }

        [JsonProperty("clone_url")]
        [JsonPropertyName("clone_url")]
        public string CloneUrl { get; set; }

        [JsonProperty("svn_url")]
        [JsonPropertyName("svn_url")]
        public string SvnUrl { get; set; }

        [JsonProperty("homepage")]
        [JsonPropertyName("homepage")]
        public string Homepage { get; set; }

        [JsonProperty("size")]
        [JsonPropertyName("size")]
        public long Size { get; set; }

        [JsonProperty("stargazers_count")]
        [JsonPropertyName("stargazers_count")]
        public long StargazersCount { get; set; }

        [JsonProperty("watchers_count")]
        [JsonPropertyName("watchers_count")]
        public long WatchersCount { get; set; }

        [JsonProperty("language")]
        [JsonPropertyName("language")]
        public string Language { get; set; }

        [JsonProperty("has_issues")]
        [JsonPropertyName("has_issues")]
        public bool HasIssues { get; set; }

        [JsonProperty("has_projects")]
        [JsonPropertyName("has_projects")]
        public bool HasProjects { get; set; }

        [JsonProperty("has_downloads")]
        [JsonPropertyName("has_downloads")]
        public bool HasDownloads { get; set; }

        [JsonProperty("has_wiki")]
        [JsonPropertyName("has_wiki")]
        public bool HasWiki { get; set; }

        [JsonProperty("has_pages")]
        [JsonPropertyName("has_pages")]
        public bool HasPages { get; set; }

        [JsonProperty("forks_count")]
        [JsonPropertyName("forks_count")]
        public long ForksCount { get; set; }

        [JsonProperty("mirror_url")]
        [JsonPropertyName("mirror_url")]
        public object MirrorUrl { get; set; }

        [JsonProperty("archived")]
        [JsonPropertyName("archived")]
        public bool Archived { get; set; }

        [JsonProperty("disabled")]
        [JsonPropertyName("disabled")]
        public bool Disabled { get; set; }

        [JsonProperty("open_issues_count")]
        [JsonPropertyName("open_issues_count")]
        public long OpenIssuesCount { get; set; }

        [JsonProperty("license")]
        [JsonPropertyName("license")]
        public License License { get; set; }

        [JsonProperty("forks")]
        [JsonPropertyName("forks")]
        public long Forks { get; set; }

        [JsonProperty("open_issues")]
        [JsonPropertyName("open_issues")]
        public long OpenIssues { get; set; }

        [JsonProperty("watchers")]
        [JsonPropertyName("watchers")]
        public long Watchers { get; set; }

        [JsonProperty("default_branch")]
        [JsonPropertyName("default_branch")]
        public string DefaultBranch { get; set; }

        [JsonProperty("permissions")]
        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }
    }
}
