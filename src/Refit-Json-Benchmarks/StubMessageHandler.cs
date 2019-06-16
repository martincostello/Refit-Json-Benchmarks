// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace RefitJsonBenchmarks
{
    internal sealed class StubMessageHandler : HttpMessageHandler
    {
        private static readonly byte[] DotNetOrgBytes = File.ReadAllBytes("dotnet.json");

        private static readonly byte[] DotNetReposBytes = File.ReadAllBytes("dotnet-repos.json");

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            byte[] content;

            if (request.Method == HttpMethod.Post)
            {
                content = Array.Empty<byte>();
            }
            else if (request.RequestUri.PathAndQuery.EndsWith("repos"))
            {
                content = DotNetReposBytes;
            }
            else
            {
                content = DotNetOrgBytes;
            }

            var response = new HttpResponseMessage(HttpStatusCode.OK)
            {
                Content = new ByteArrayContent(content),
            };

            return Task.FromResult(response);
        }
    }
}
