using System.Linq;
using System.Threading.Tasks;
using FluentAssertions;
using Xunit;

namespace DestructureExtensions.Tests
{
    public class TaskExtensionTests
    {
        [Fact]
        public async Task ShouldReturnEnumerableOfResults()
        {
            // Arrange
            var tasks = Enumerable.Range(1, 10).Select(Task.FromResult);

            // Act
            var results = await tasks.WhenAll();

            // Assert
            results.Should().ContainInOrder(Enumerable.Range(1, 10));
        }

        [Fact]
        public async Task ShouldDeconstructEnumerableOfResults()
        {
            // Arrange
            var tasks = Enumerable.Range(1, 10).Select(Task.FromResult);

            // Act
            var (a, b, c, d, e, f, g, h, rest) = await tasks.WhenAll();

            // Assert
            a.Should().Be(1);
            b.Should().Be(2);
            c.Should().Be(3);
            d.Should().Be(4);
            e.Should().Be(5);
            f.Should().Be(6);
            g.Should().Be(7);
            h.Should().Be(8);
            rest.Should().ContainInOrder(9, 10);
        }

        [Fact]
        public async Task ShouldGetTupleOfTwoResults()
        {
            // Act
            var (
                r1,
                r2
            ) = await (
                Task.FromResult(1),
                Task.FromResult(2)
            ).WhenAll();

            // Assert
            r1.Should().Be(1);
            r2.Should().Be(2);
        }

        [Fact]
        public async Task ShouldGetTupleOfThreeResults()
        {
            // Act
            var (
                r1,
                r2,
                r3
            ) = await (
                Task.FromResult(1),
                Task.FromResult(2),
                Task.FromResult(3)
            ).WhenAll();

            // Assert
            r1.Should().Be(1);
            r2.Should().Be(2);
            r3.Should().Be(3);
        }

        [Fact]
        public async Task ShouldGetTupleOfFourResults()
        {
            // Act
            var (
                r1,
                r2,
                r3,
                r4
            ) = await (
                Task.FromResult(1),
                Task.FromResult(2),
                Task.FromResult(3),
                Task.FromResult(4)
            ).WhenAll();

            // Assert
            r1.Should().Be(1);
            r2.Should().Be(2);
            r3.Should().Be(3);
            r4.Should().Be(4);
        }

        [Fact]
        public async Task ShouldGetTupleOfFiveResults()
        {
            // Act
            var (
                r1,
                r2,
                r3,
                r4,
                r5
            ) = await (
                Task.FromResult(1),
                Task.FromResult(2),
                Task.FromResult(3),
                Task.FromResult(4),
                Task.FromResult(5)
            ).WhenAll();

            // Assert
            r1.Should().Be(1);
            r2.Should().Be(2);
            r3.Should().Be(3);
            r4.Should().Be(4);
            r5.Should().Be(5);
        }

        [Fact]
        public async Task ShouldGetTupleOfSixResults()
        {
            // Act
            var (
                r1,
                r2,
                r3,
                r4,
                r5,
                r6
            ) = await (
                Task.FromResult(1),
                Task.FromResult(2),
                Task.FromResult(3),
                Task.FromResult(4),
                Task.FromResult(5),
                Task.FromResult(6)
            ).WhenAll();

            // Assert
            r1.Should().Be(1);
            r2.Should().Be(2);
            r3.Should().Be(3);
            r4.Should().Be(4);
            r5.Should().Be(5);
            r6.Should().Be(6);
        }

        [Fact]
        public async Task ShouldGetTupleOfSevenResults()
        {
            // Act
            var (
                r1,
                r2,
                r3,
                r4,
                r5,
                r6,
                r7
            ) = await (
                Task.FromResult(1),
                Task.FromResult(2),
                Task.FromResult(3),
                Task.FromResult(4),
                Task.FromResult(5),
                Task.FromResult(6),
                Task.FromResult(7)
            ).WhenAll();

            // Assert
            r1.Should().Be(1);
            r2.Should().Be(2);
            r3.Should().Be(3);
            r4.Should().Be(4);
            r5.Should().Be(5);
            r6.Should().Be(6);
            r7.Should().Be(7);
        }

        [Fact]
        public async Task ShouldGetTupleOfEightResults()
        {
            // Act
            var (
                r1,
                r2,
                r3,
                r4,
                r5,
                r6,
                r7,
                r8
            ) = await (
                Task.FromResult(1),
                Task.FromResult(2),
                Task.FromResult(3),
                Task.FromResult(4),
                Task.FromResult(5),
                Task.FromResult(6),
                Task.FromResult(7),
                Task.FromResult(8)
            ).WhenAll();

            // Assert
            r1.Should().Be(1);
            r2.Should().Be(2);
            r3.Should().Be(3);
            r4.Should().Be(4);
            r5.Should().Be(5);
            r6.Should().Be(6);
            r7.Should().Be(7);
            r8.Should().Be(8);
        }
    }
}
