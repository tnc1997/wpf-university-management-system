using System;
using System.Collections.Generic;
using System.Linq;
using UniversityManagementSystem.Data.Entities;
using Xunit;
using static Xunit.Assert;

namespace UniversityManagementSystem.Extensions.Tests
{
    public class DictionaryExtensionTests
    {
        [Fact]
        public void AsObservablePoints_Dictionary_ObservablePointsReturned()
        {
            IDictionary<int, int> dictionary = new Dictionary<int, int>
            {
                {1, 2},
                {3, 4},
                {5, 6}
            };

            var observablePoints = dictionary.AsObservablePoints().ToList();

            Equal(1, observablePoints.First().X);
            Equal(2, observablePoints.First().Y);

            Equal(5, observablePoints.Last().X);
            Equal(6, observablePoints.Last().Y);
        }

        [Fact]
        public void AsObservablePoints_DictionaryGenericKey_ObservablePointsReturned()
        {
            IDictionary<YearDim, int> dictionary = new Dictionary<YearDim, int>
            {
                {new YearDim {Year = 2015}, 1},
                {new YearDim {Year = 2016}, 2},
                {new YearDim {Year = 2017}, 3}
            };

            var observablePoints = dictionary.AsObservablePoints(dim => dim.Year).ToList();

            Equal(2015, observablePoints.First().X);
            Equal(1, observablePoints.First().Y);

            Equal(2017, observablePoints.Last().X);
            Equal(3, observablePoints.Last().Y);
        }

        [Fact]
        public void AsObservablePoints_DictionaryGenericKeyValue_ObservablePointsReturned()
        {
            IDictionary<YearDim, IFact> dictionary = new Dictionary<YearDim, IFact>
            {
                {new YearDim {Year = 2015}, new StudentFact {Count = 100}},
                {new YearDim {Year = 2016}, new StudentFact {Count = 200}},
                {new YearDim {Year = 2017}, new StudentFact {Count = 300}}
            };

            var observablePoints = dictionary.AsObservablePoints(dim => dim.Year, fact => fact.Count).ToList();

            Equal(2015, observablePoints.First().X);
            Equal(100, observablePoints.First().Y);

            Equal(2017, observablePoints.Last().X);
            Equal(300, observablePoints.Last().Y);
        }

        [Fact]
        public void AsObservablePoints_DictionaryGenericValue_ObservablePointsReturned()
        {
            IDictionary<int, IFact> dictionary = new Dictionary<int, IFact>
            {
                {1, new StudentFact {Count = 100}},
                {2, new StudentFact {Count = 200}},
                {3, new StudentFact {Count = 300}}
            };

            var observablePoints = dictionary.AsObservablePoints(fact => fact.Count).ToList();

            Equal(1, observablePoints.First().X);
            Equal(100, observablePoints.First().Y);

            Equal(3, observablePoints.Last().X);
            Equal(300, observablePoints.Last().Y);
        }

        [Fact]
        public void AsObservablePoints_NullDictionary_ArgumentNullExceptionThrown()
        {
            IDictionary<int, int> dictionary = null;

            Throws<ArgumentNullException>(() => dictionary.AsObservablePoints());
        }
    }
}