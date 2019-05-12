using System;
using System.Collections.Generic;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Extensions.Tests
{
    public class CollectionExtensionTests
    {
        public CollectionExtensionTests()
        {
            Collection = new List<int> {1, 2, 3};
        }

        private ICollection<int> Collection { get; set; }

        [Fact]
        public void AddRange_Collection_ListAdded()
        {
            var list = new List<int> {4, 5, 6};

            Collection.AddRange(list);

            Collection(
                Collection,
                i => Equal(1, i),
                i => Equal(2, i),
                i => Equal(3, i),
                i => Equal(4, i),
                i => Equal(5, i),
                i => Equal(6, i)
            );
        }

        [Fact]
        public void AddRange_NullCollection_ArgumentNullExceptionThrown()
        {
            var list = new List<int> {4, 5, 6};

            Collection = null;

            Throws<ArgumentNullException>(() => Collection.AddRange(list));
        }

        [Fact]
        public void AddRange_NullList_ArgumentNullExceptionThrown()
        {
            List<int> list = null;

            // ReSharper disable once ExpressionIsAlwaysNull
            Throws<ArgumentNullException>(() => Collection.AddRange(list));
        }
    }
}