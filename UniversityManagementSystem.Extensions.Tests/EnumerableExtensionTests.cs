using System;
using System.Collections.Generic;
using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Extensions.Tests
{
    public class EnumerableExtensionTests
    {
        [Fact]
        public void AsObservablePoints_Enumerable_ObservablePointsReturned()
        {
            var facts = new List<IFact>
            {
                new StudentFact
                {
                    YearDim = new YearDim {Year = 2015},
                    Count = 100
                },
                new StudentFact
                {
                    YearDim = new YearDim {Year = 2016},
                    Count = 200
                },
                new StudentFact
                {
                    YearDim = new YearDim {Year = 2017},
                    Count = 300
                }
            };

            var enumerablePoints = facts.AsObservablePoints().ToList();

            Equal(2015, enumerablePoints.First().X);
            Equal(100, enumerablePoints.First().Y);

            Equal(2017, enumerablePoints.Last().X);
            Equal(300, enumerablePoints.Last().Y);
        }

        [Fact]
        public void AsObservablePoints_NullEnumerable_ArgumentNullExceptionThrown()
        {
            IEnumerable<IFact> facts = null;

            Throws<ArgumentNullException>(() => facts.AsObservablePoints());
        }
    }
}