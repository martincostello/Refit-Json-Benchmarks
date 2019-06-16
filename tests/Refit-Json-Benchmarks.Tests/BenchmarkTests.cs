// Copyright (c) Martin Costello, 2019. All rights reserved.
// Licensed under the Apache 2.0 license. See the LICENSE file in the project root for full license information.

using System.Threading.Tasks;
using Xunit;

namespace RefitJsonBenchmarks
{
    public static class BenchmarkTests
    {
        [Fact]
        public static async Task Read_Collection_NewtonsoftJson()
        {
            // Arrange
            var benchmark = new ReadCollection();

            // Act
            var repos = await benchmark.Read_Collection_NewtonsoftJson();

            // Assert
            Assert.NotNull(repos);
            Assert.NotEmpty(repos);
        }

        [Fact]
        public static async Task Read_Collection_SystemTextJson()
        {
            // Arrange
            var benchmark = new ReadCollection();

            // Act
            var repos = await benchmark.Read_Collection_SystemTextJson();

            // Assert
            Assert.NotNull(repos);
            Assert.NotEmpty(repos);
        }

        [Fact]
        public static async Task Read_Object_NewtonsoftJson()
        {
            // Arrange
            var benchmark = new ReadObject();

            // Act
            var org = await benchmark.Read_Object_NewtonsoftJson();

            // Assert
            Assert.NotNull(org);
            Assert.Equal("dotnet", org.Login);
        }

        [Fact]
        public static async Task Read_Object_SystemTextJson()
        {
            // Arrange
            var benchmark = new ReadObject();

            // Act
            var org = await benchmark.Read_Object_SystemTextJson();

            // Assert
            Assert.NotNull(org);
            Assert.Equal("dotnet", org.Login);
        }

        [Fact]
        public static async Task Write_Object_NewtonsoftJson()
        {
            // Arrange
            var benchmark = new WriteObject();

            // Act (no Assert)
            await benchmark.Write_Object_NewtonsoftJson();
        }

        [Fact]
        public static async Task Write_Object_SystemTextJson()
        {
            // Arrange
            var benchmark = new WriteObject();

            // Act (no Assert)
            await benchmark.Write_Object_SystemTextJson();
        }
    }
}
