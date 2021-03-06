﻿using System;
using System.Collections.Generic;
using System.Linq;
using FluentAssertions;
using Xunit;

namespace NetFabric.Tests
{
    public class FindTests
    {
        public static TheoryData<IReadOnlyList<int?>, int?, bool> Data =>
            new TheoryData<IReadOnlyList<int?>, int?, bool>
            {
                { new int?[] { },                   null,   false },
                { new int?[] { },                   1,      false },
                { new int?[] { null },              null,   true },
                { new int?[] { null },              1,      false },
                { new int?[] { 1 },                 null,   false },
                { new int?[] { 1 },                 2,      false },
                { new int?[] { 1 },                 1,      true },
                { new int?[] { 1, 2, null, 4, 5 },  null,   true},
                { new int?[] { 1, 2, null, 4, 5 },  1,      true},
                { new int?[] { 1, 2, null, 4, 5 },  4,      true},
                { new int?[] { 1, 2, null, 4, 5 },  5,      true},
                { new int?[] { 1, 2, null, 4, 5 },  6,      false},
            };

        [Theory]
        [MemberData(nameof(Data))]
        public void Find(IReadOnlyList<int?> collection, int? value, bool shouldFind)
        {
            // Arrange
            var list = new DoubleLinkedList<int?>(collection);

            // Act
            var result = list.Find(value);

            // Assert
            if(shouldFind)
            {
                result.Should().NotBeNull();
                result.Value.Should().Be(value);
            }
            else
            {
                result.Should().BeNull();
            }
        }

        public static TheoryData<IReadOnlyList<int?>, int?> HeadData =>
            new TheoryData<IReadOnlyList<int?>, int?>
            {
                { new int?[] { null, null, null },  null },
                { new int?[] { 1, 1, 1 },           1 },
            };

        [Theory]
        [MemberData(nameof(HeadData))]
        public void FindHead(IReadOnlyList<int?> collection, int? value)
        {
            // Arrange
            var list = new DoubleLinkedList<int?>(collection);

            // Act
            var result = list.Find(value);

            // Assert
            result.Should().BeSameAs(list.First);
        }
    }
}
