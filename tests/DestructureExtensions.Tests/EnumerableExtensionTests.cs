using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace DestructureExtensions.Tests
{
    public class EnumerableExtensionTests
    {
        [Fact]
        public void ShouldThrowOnNull()
        {
            // Arrange
            IEnumerable<object> nullEnumerable = null;

            // Act
            Action act = () =>
            {
                var (first, rest) = nullEnumerable;
            };

            // Assert
            act.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void ShouldNotIterateMoreThanNecessary()
        {
            // Arrange
            var enumerableForOneElementTest = new AssertableEnumerable<int>();
            var enumerableForTwoElementTest = new AssertableEnumerable<int>();
            var enumerableForThreeElementTest = new AssertableEnumerable<int>();
            var enumerableForFourElementTest = new AssertableEnumerable<int>();
            var enumerableForFiveElementTest = new AssertableEnumerable<int>();
            var enumerableForSixElementTest = new AssertableEnumerable<int>();
            var enumerableForSevenElementTest = new AssertableEnumerable<int>();
            var enumerableForEightElementTest = new AssertableEnumerable<int>();

            // Act
            var (_, _) = enumerableForOneElementTest;
            var (_, _, _) = enumerableForTwoElementTest;
            var (_, _, _, _) = enumerableForThreeElementTest;
            var (_, _, _, _, _) = enumerableForFourElementTest;
            var (_, _, _, _, _, _) = enumerableForFiveElementTest;
            var (_, _, _, _, _, _, _) = enumerableForSixElementTest;
            var (_, _, _, _, _, _, _, _) = enumerableForSevenElementTest;
            var (_, _, _, _, _, _, _, _, _) = enumerableForEightElementTest;

            // Assert
            enumerableForOneElementTest.Iterations.Should().Be(1);
            enumerableForTwoElementTest.Iterations.Should().Be(2);
            enumerableForThreeElementTest.Iterations.Should().Be(3);
            enumerableForFourElementTest.Iterations.Should().Be(4);
            enumerableForFiveElementTest.Iterations.Should().Be(5);
            enumerableForSixElementTest.Iterations.Should().Be(6);
            enumerableForSevenElementTest.Iterations.Should().Be(7);
            enumerableForEightElementTest.Iterations.Should().Be(8);
        }

        private class AssertableEnumerable<T> : IEnumerable<T>
        {
            private AssertableEnumerator _enumerator;
            public int Iterations => _enumerator.CallsToMoveNext;

            public IEnumerator<T> GetEnumerator()
            {
                _enumerator = new AssertableEnumerator();
                return _enumerator;
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();

            private class AssertableEnumerator : IEnumerator<T>
            {
                public T Current => default(T);

                object IEnumerator.Current => Current;

                public void Dispose() { }

                public int CallsToMoveNext { get; set; }
                public bool MoveNext()
                {
                    CallsToMoveNext++;
                    return true;
                }

                public void Reset() => throw new NotImplementedException();
            }
        }

        [Fact]
        public void ShouldGetNullWhenEnumerableContainsFewerReferenceElements()
        {
            // Arrange
            var enumerableForOneElementTest = Enumerable.Empty<string>();
            var enumerableForTwoElementTest = Enumerable.Repeat(String.Empty, 1);
            var enumerableForThreeElementTest = Enumerable.Repeat(String.Empty, 2);
            var enumerableForFourElementTest = Enumerable.Repeat(String.Empty, 3);
            var enumerableForFiveElementTest = Enumerable.Repeat(String.Empty, 4);
            var enumerableForSixElementTest = Enumerable.Repeat(String.Empty, 5);
            var enumerableForSevenElementTest = Enumerable.Repeat(String.Empty, 6);
            var enumerableForEightElementTest = Enumerable.Repeat(String.Empty, 7);

            // Act
            var (actualForOneElementTest, _) = enumerableForOneElementTest;
            var (_, actualForTwoElementTest, _) = enumerableForTwoElementTest;
            var (_, _, actualForThreeElementTest, _) = enumerableForThreeElementTest;
            var (_, _, _, actualForFourElementTest, _) = enumerableForFourElementTest;
            var (_, _, _, _, actualForFiveElementTest, _) = enumerableForFiveElementTest;
            var (_, _, _, _, _, actualForSixElementTest, _) = enumerableForSixElementTest;
            var (_, _, _, _, _, _, actualForSevenElementTest, _) = enumerableForSevenElementTest;
            var (_, _, _, _, _, _, _, actualForEightElementTest, _) = enumerableForEightElementTest;

            // Assert
            actualForOneElementTest.Should().BeNull();
            actualForTwoElementTest.Should().BeNull();
            actualForThreeElementTest.Should().BeNull();
            actualForFourElementTest.Should().BeNull();
            actualForFiveElementTest.Should().BeNull();
            actualForSixElementTest.Should().BeNull();
            actualForSevenElementTest.Should().BeNull();
            actualForEightElementTest.Should().BeNull();
        }

        [Fact]
        public void ShouldGetDefaultWhenEnumerableContainsFewerValueElements()
        {
            // Arrange
            var enumerableForOneElementTest = Enumerable.Empty<int>();
            var enumerableForTwoElementTest = Enumerable.Repeat(default(int), 1);
            var enumerableForThreeElementTest = Enumerable.Repeat(default(int), 2);
            var enumerableForFourElementTest = Enumerable.Repeat(default(int), 3);
            var enumerableForFiveElementTest = Enumerable.Repeat(default(int), 4);
            var enumerableForSixElementTest = Enumerable.Repeat(default(int), 5);
            var enumerableForSevenElementTest = Enumerable.Repeat(default(int), 6);
            var enumerableForEightElementTest = Enumerable.Repeat(default(int), 7);

            // Act
            var (actualForOneElementTest, _) = enumerableForOneElementTest;
            var (_, actualForTwoElementTest, _) = enumerableForTwoElementTest;
            var (_, _, actualForThreeElementTest, _) = enumerableForThreeElementTest;
            var (_, _, _, actualForFourElementTest, _) = enumerableForFourElementTest;
            var (_, _, _, _, actualForFiveElementTest, _) = enumerableForFiveElementTest;
            var (_, _, _, _, _, actualForSixElementTest, _) = enumerableForSixElementTest;
            var (_, _, _, _, _, _, actualForSevenElementTest, _) = enumerableForSevenElementTest;
            var (_, _, _, _, _, _, _, actualForEightElementTest, _) = enumerableForEightElementTest;

            // Assert
            actualForOneElementTest.Should().Be(0);
            actualForTwoElementTest.Should().Be(0);
            actualForThreeElementTest.Should().Be(0);
            actualForFourElementTest.Should().Be(0);
            actualForFiveElementTest.Should().Be(0);
            actualForSixElementTest.Should().Be(0);
            actualForSevenElementTest.Should().Be(0);
            actualForEightElementTest.Should().Be(0);
        }

        [Fact]
        public void ShouldGetExpectedRest()
        {
            // Arrange
            var enumerableForOneElementTest = Enumerable.Range(1, 3);
            var enumerableForTwoElementTest = Enumerable.Range(1, 4);
            var enumerableForThreeElementTest = Enumerable.Range(1, 5);
            var enumerableForFourElementTest = Enumerable.Range(1, 6);
            var enumerableForFiveElementTest = Enumerable.Range(1, 7);
            var enumerableForSixElementTest = Enumerable.Range(1, 8);
            var enumerableForSevenElementTest = Enumerable.Range(1, 9);
            var enumerableForEightElementTest = Enumerable.Range(1, 10);

            // Act
            var (_, actualForOneElementTest) = enumerableForOneElementTest;
            var (_, _, actualForTwoElementTest) = enumerableForTwoElementTest;
            var (_, _, _, actualForThreeElementTest) = enumerableForThreeElementTest;
            var (_, _, _, _, actualForFourElementTest) = enumerableForFourElementTest;
            var (_, _, _, _, _, actualForFiveElementTest) = enumerableForFiveElementTest;
            var (_, _, _, _, _, _, actualForSixElementTest) = enumerableForSixElementTest;
            var (_, _, _, _, _, _, _, actualForSevenElementTest) = enumerableForSevenElementTest;
            var (_, _, _, _, _, _, _, _, actualForEightElementTest) = enumerableForEightElementTest;

            // Assert
            actualForOneElementTest.Should().ContainInOrder(2, 3);
            actualForTwoElementTest.Should().ContainInOrder(3, 4);
            actualForThreeElementTest.Should().ContainInOrder(4, 5);
            actualForFourElementTest.Should().ContainInOrder(5, 6);
            actualForFiveElementTest.Should().ContainInOrder(6, 7);
            actualForSixElementTest.Should().ContainInOrder(7, 8);
            actualForSevenElementTest.Should().ContainInOrder(8, 9);
            actualForEightElementTest.Should().ContainInOrder(9, 10);
        }

        [Fact]
        public void ShouldGetExpectedElementsWhenDeconstructingOne()
        {
            // Act
            var (first, rest) = Enumerable.Range(1, 1);

            // Assert
            first.Should().Be(1);
            rest.Should().BeEmpty();
        }

        [Fact]
        public void ShouldGetExpectedElementsWhenDeconstructingTwo()
        {
            // Act
            var (first, second, rest) = Enumerable.Range(1, 2);

            // Assert
            first.Should().Be(1);
            second.Should().Be(2);
            rest.Should().BeEmpty();
        }

        [Fact]
        public void ShouldGetExpectedElementsWhenDeconstructingThree()
        {
            // Act
            var (first, second, third, rest) = Enumerable.Range(1, 3);

            // Assert
            first.Should().Be(1);
            second.Should().Be(2);
            third.Should().Be(3);
            rest.Should().BeEmpty();
        }

        [Fact]
        public void ShouldGetExpectedElementsWhenDeconstructingFour()
        {
            // Act
            var (first, second, third, fourth, rest) = Enumerable.Range(1, 4);

            // Assert
            first.Should().Be(1);
            second.Should().Be(2);
            third.Should().Be(3);
            fourth.Should().Be(4);
            rest.Should().BeEmpty();
        }

        [Fact]
        public void ShouldGetExpectedElementsWhenDeconstructingFive()
        {
            // Act
            var (first, second, third, fourth, fifth, rest) = Enumerable.Range(1, 5);

            // Assert
            first.Should().Be(1);
            second.Should().Be(2);
            third.Should().Be(3);
            fourth.Should().Be(4);
            fifth.Should().Be(5);
            rest.Should().BeEmpty();
        }

        [Fact]
        public void ShouldGetExpectedElementsWhenDeconstructingSix()
        {
            // Act
            var (first, second, third, fourth, fifth, sixth, rest) = Enumerable.Range(1, 6);

            // Assert
            first.Should().Be(1);
            second.Should().Be(2);
            third.Should().Be(3);
            fourth.Should().Be(4);
            fifth.Should().Be(5);
            sixth.Should().Be(6);
            rest.Should().BeEmpty();
        }

        [Fact]
        public void ShouldGetExpectedElementsWhenDeconstructingSeven()
        {
            // Act
            var (first, second, third, fourth, fifth, sixth, seventh, rest) = Enumerable.Range(1, 7);

            // Assert
            first.Should().Be(1);
            second.Should().Be(2);
            third.Should().Be(3);
            fourth.Should().Be(4);
            fifth.Should().Be(5);
            sixth.Should().Be(6);
            seventh.Should().Be(7);
            rest.Should().BeEmpty();
        }

        [Fact]
        public void ShouldGetExpectedElementsWhenDeconstructingEight()
        {
            // Act
            var (first, second, third, fourth, fifth, sixth, seventh, eighth, rest) = Enumerable.Range(1, 8);

            // Assert
            first.Should().Be(1);
            second.Should().Be(2);
            third.Should().Be(3);
            fourth.Should().Be(4);
            fifth.Should().Be(5);
            sixth.Should().Be(6);
            seventh.Should().Be(7);
            eighth.Should().Be(8);
            rest.Should().BeEmpty();
        }
    }
}
