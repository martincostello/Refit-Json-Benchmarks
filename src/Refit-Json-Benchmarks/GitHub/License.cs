// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RefitJsonBenchmarks.GitHub
{
    public class License
    {
        [JsonProperty("key")]
        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonProperty("name")]
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonProperty("spdx_id")]
        [JsonPropertyName("spdx_id")]
        public string SpdxId { get; set; }

        [JsonProperty("url")]
        [JsonPropertyName("url")]
        public string Url { get; set; }

        [JsonProperty("node_id")]
        [JsonPropertyName("node_id")]
        public string NodeId { get; set; }
    }
}
