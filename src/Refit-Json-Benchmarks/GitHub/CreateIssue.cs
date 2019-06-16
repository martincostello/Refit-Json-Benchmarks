// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.


using System.Collections.Generic;
using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RefitJsonBenchmarks.GitHub
{
    public class CreateIssue
    {
        [JsonProperty("title")]
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonProperty("body")]
        [JsonPropertyName("body")]
        public string Body { get; set; }

        [JsonProperty("assignees")]
        [JsonPropertyName("assignees")]
        public IList<string> Assignees { get; set; }

        [JsonProperty("milestone")]
        [JsonPropertyName("milestone")]
        public long Milestone { get; set; }

        [JsonProperty("labels")]
        [JsonPropertyName("labels")]
        public IList<string> Labels { get; set; }
    }
}
