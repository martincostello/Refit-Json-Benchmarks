// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RefitJsonBenchmarks.GitHub
{
    public class Owner
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

        [JsonProperty("avatar_url")]
        [JsonPropertyName("avatar_url")]
        public string AvatarUrl { get; set; }

        [JsonProperty("gravatar_id")]
        [JsonPropertyName("gravatar_id")]
        public string GravatarId { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonProperty("html_url")]
        [JsonPropertyName("html_url")]
        public string HtmlUrl { get; set; }

        [JsonProperty("followers_url")]
        [JsonPropertyName("followers_url")]
        public string FollowersUrl { get; set; }

        [JsonProperty("following_url")]
        [JsonPropertyName("following_url")]
        public string FollowingUrl { get; set; }

        [JsonProperty("gists_url")]
        [JsonPropertyName("gists_url")]
        public string GistsUrl { get; set; }

        [JsonProperty("starred_url")]
        [JsonPropertyName("starred_url")]
        public string StarredUrl { get; set; }

        [JsonProperty("subscriptions_url")]
        [JsonPropertyName("subscriptions_url")]
        public string SubscriptionsUrl { get; set; }

        [JsonProperty("organizations_url")]
        [JsonPropertyName("organizations_url")]
        public string OrganizationsUrl { get; set; }

        [JsonProperty("repos_url")]
        [JsonPropertyName("repos_url")]
        public string ReposUrl { get; set; }

        [JsonProperty("events_url")]
        [JsonPropertyName("events_url")]
        public string EventsUrl { get; set; }

        [JsonProperty("received_events_url")]
        [JsonPropertyName("received_events_url")]
        public string ReceivedEventsUrl { get; set; }

        [JsonProperty("type")]
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonProperty("site_admin")]
        [JsonPropertyName("site_admin")]
        public bool SiteAdmin { get; set; }
    }
}
