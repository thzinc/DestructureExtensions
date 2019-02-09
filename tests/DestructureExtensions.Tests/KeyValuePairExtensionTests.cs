using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace DestructureExtensions.Tests
{
    public class KeyValuePairExtensionTests
    {
        [Fact]
        public void ShouldDestructureKeyValuePair()
        {
            // Arrange
            var pair = new KeyValuePair<string, int>("foo", 1);

            // Act
            var (key, value) = pair;

            // Assert
            key.Should().Be("foo");
            value.Should().Be(1);
        }
    }
}
