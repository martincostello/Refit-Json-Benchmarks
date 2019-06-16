// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System.Text.Json.Serialization;
using Newtonsoft.Json;

namespace RefitJsonBenchmarks.GitHub
{
    public class Permissions
    {
        [JsonProperty("admin")]
        [JsonPropertyName("admin")]
        public bool Admin { get; set; }

        [JsonProperty("push")]
        [JsonPropertyName("push")]
        public bool Push { get; set; }

        [JsonProperty("pull")]
        [JsonPropertyName("pull")]
        public bool Pull { get; set; }
    }
}
