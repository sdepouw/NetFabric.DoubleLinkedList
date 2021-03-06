using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace NetFabric.Tests
{
    public class AddBeforeTests
    {
        [Fact]
        void NullNode()
        {
            // Arrange
            var list = new DoubleLinkedList<int>();

            // Act
            Action action = () => list.AddBefore(null, 1);

            // Assert
            action.Should()
                .ThrowExactly<ArgumentNullException>()
                .And
                .ParamName.Should()
                .Be("node");
        }

        [Fact]
        void InvalidNode()
        {
            // Arrange
            var list = new DoubleLinkedList<int>();
            var anotherList = new DoubleLinkedList<int>(new int[] { 1 });
            var node = anotherList.Find(1);

            // Act
            Action action = () => list.AddBefore(node, 1);

            // Assert
            action.Should().ThrowExactly<InvalidOperationException>();
        }

        public static TheoryData<IReadOnlyList<int>, int, int, IReadOnlyList<int>> ItemData =>
            new TheoryData<IReadOnlyList<int>, int, int, IReadOnlyList<int>>
            {
                { new int[] { 2 },      2, 1, new int[] { 1, 2 } },
                { new int[] { 1, 3 },   3, 2, new int[] { 1, 2, 3 } },
            };

        [Theory]
        [MemberData(nameof(ItemData))]
        void AddItem(IReadOnlyList<int> collection, int after, int item, IReadOnlyList<int> expected)
        {
            // Arrange
            var list = new DoubleLinkedList<int>(collection);
            var version = list.Version;
            var node = list.Find(after);

            // Act
            list.AddBefore(node, item);

            // Assert
            list.Count.Should().Be(expected.Count);
            list.Version.Should().NotBe(version);
            list.EnumerateForward().Should().Equal(expected);
            list.EnumerateReversed().Should().Equal(expected.Reverse());
        }
    }
}
