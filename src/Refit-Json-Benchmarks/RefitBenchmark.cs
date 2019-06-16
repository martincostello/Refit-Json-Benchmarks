// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using Refit;
using RefitJsonBenchmarks.GitHub;

namespace RefitJsonBenchmarks
{
    public abstract class RefitBenchmark
    {
        protected static IGitHub CreateClient(IContentSerializer contentSerializer)
        {
            var client = new HttpClient(new StubMessageHandler())
            {
                BaseAddress = new Uri("https://api.github.com")
            };

            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.UserAgent.Add(new ProductInfoHeaderValue("Refit-Json-Benchmarks", "1.0.0"));

            var settings = new RefitSettings()
            {
                ContentSerializer = contentSerializer,
            };

            return RestService.For<IGitHub>(client, settings);
        }

        protected static IContentSerializer CreateNewtonsoftJsonContentSerializer()
        {
            var settings = new JsonSerializerSettings()
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
                Formatting = Formatting.Indented,
            };

            return new JsonContentSerializer(settings);
        }

        protected static IContentSerializer CreateSystemTextJsonContentSerializer()
        {
            var options = new JsonSerializerOptions()
            {
                PropertyNameCaseInsensitive = false,
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true,
            };

            return new SystemTextJsonContentSerializer(options);
        }
    }
}
