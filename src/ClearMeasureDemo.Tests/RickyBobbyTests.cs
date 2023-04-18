using ClearMeasureDemo.Library;
using ClearMeasureDemo.Library.Models;

namespace ClearMeasureDemo.Tests
{
    public class RickyBobbyTests
    {
        private IEnumerable<RuleModel> rules => new List<RuleModel>
        {
            new RuleModel { Input = 3, Output = "Three" },
            new RuleModel { Input = 5, Output = "Five" },
            new RuleModel { Input = 8, Output = "Eight" },
            new RuleModel { Input = 9, Output = "Nine" }
        };

        [Theory]
        [InlineData(3, new[] { "1", "2", "Three" })]
        [InlineData(5, new[] { "1", "2", "Three", "4", "Five" })]
        [InlineData(10, new[] { "1", "2", "Three", "4", "Five", "Three", "7", "Eight", "ThreeNine", "Five" })]
        [InlineData(15, new[] { "1", "2", "Three", "4", "Five", "Three", "7", "Eight", "ThreeNine", "Five", "11", "Three", "13", "14", "ThreeFive" })]
        public void ExecuteRules_ShouldEqual(int upperBound, string[] expectedValues)
        {
            var rickyBobby = new RickyBobby(rules);
            var result = rickyBobby.Execute(upperBound);

            Assert.Equal(expectedValues, result);
        }

        [Theory]
        [InlineData(3, new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" })]
        [InlineData(5, new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" })]
        [InlineData(10, new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" })]
        [InlineData(15, new[] { "1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12", "13", "14", "15" })]
        public void ExecuteRules_ShouldNotEqual(int upperBound, string[] expectedValues)
        {
            var rickyBobby = new RickyBobby(rules);
            var result = rickyBobby.Execute(upperBound);

            Assert.NotEqual(expectedValues, result);
        }

        [Theory]
        [InlineData(3, new[] { "1", "2", "Three" })]
        [InlineData(5, new[] { "1", "2", "Three", "4", "Five" })]
        [InlineData(10, new[] { "1", "2", "Three", "4", "Five", "Three", "7", "Eight", "ThreeNine", "Five" })]
        [InlineData(15, new[] { "1", "2", "Three", "4", "Five", "Three", "7", "Eight", "ThreeNine", "Five", "11", "Three", "13", "14", "ThreeFive" })]
        public void ExecuteRules_ShouldNotEqualWithNullRules(int upperBound, string[] expectedValues)
        {
            var rickyBobby = new RickyBobby(null);
            var result = rickyBobby.Execute(upperBound);

            Assert.NotEqual(expectedValues, result);
        }
    }
}
