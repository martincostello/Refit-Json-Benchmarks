// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

namespace RefitJsonBenchmarks
{
    using System;
    using System.IO;
    using System.Net.Http;
    using System.Net.Http.Headers;
    using System.Text;
    using System.Text.Json.Serialization;
    using System.Threading.Tasks;
    using Refit;

    public sealed class SystemTextJsonContentSerializer : IContentSerializer
    {
        private static readonly MediaTypeHeaderValue _jsonMediaType =
            new MediaTypeHeaderValue("application/json") { CharSet = Encoding.UTF8.WebName };

        public SystemTextJsonContentSerializer(JsonSerializerOptions serializerOptions)
        {
            SerializerOptions = serializerOptions;
        }

        private JsonSerializerOptions SerializerOptions { get; }

        public async Task<T> DeserializeAsync<T>(HttpContent content)
        {
            using var utf8Json = await content.ReadAsStreamAsync();
            return await JsonSerializer.ReadAsync<T>(utf8Json, SerializerOptions);
        }

        public async Task<HttpContent> SerializeAsync<T>(T item)
        {
            var stream = new MemoryStream();

            try
            {
                await JsonSerializer.WriteAsync(item, stream, SerializerOptions);
                await stream.FlushAsync();

                var content = new StreamContent(stream);

                content.Headers.ContentType = _jsonMediaType;

                return content;
            }
            catch (Exception)
            {
                await stream.DisposeAsync();
                throw;
            }
        }
    }
}
