using UseCase7.Analyzers;
using UseCase7.Models;

namespace TestProject1
{
    public class PlayerAnalyzerTests
    {
        private readonly PlayerAnalyzer _analyzer;

        public PlayerAnalyzerTests()
        {
            _analyzer = new PlayerAnalyzer();
        }

        [Fact]
        public void CalculateScore_SinglePlayer_Age25Experience5Skills222_Returns250()
        {
            var players = new List<Player>
            {
                new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } }
            };

            var result = _analyzer.CalculateScore(players);

            Assert.Equal(250, result);
        }

        [Fact]
        public void CalculateScore_SinglePlayer_Age15Experience3Skills333_Returns67dot5()
        {
            var players = new List<Player>
            {
                new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } }
            };

            var result = _analyzer.CalculateScore(players);

            Assert.Equal(67.5, result);
        }

        [Fact]
        public void CalculateScore_SinglePlayer_Age35Experience15Skills444_Returns2520()
        {
            var players = new List<Player>
            {
                new Player { Age = 35, Experience = 15, Skills = new List<int> { 4, 4, 4 } }
            };

            var result = _analyzer.CalculateScore(players);

            Assert.Equal(2520, result);
        }

        [Fact]
        public void CalculateScore_MultiplePlayers_ReturnsSumOfScores()
        {
            var players = new List<Player>
            {
                new Player { Age = 25, Experience = 5, Skills = new List<int> { 2, 2, 2 } },
                new Player { Age = 15, Experience = 3, Skills = new List<int> { 3, 3, 3 } }
            };

            var result = _analyzer.CalculateScore(players);

            Assert.Equal(250 + 67.5, result);
        }

        [Fact]
        public void CalculateScore_PlayerSkillsIsNull_ThrowsException()
        {
            var players = new List<Player>
            {
                new Player { Age = 25, Experience = 5, Skills = null }
            };

            Assert.Throws<ArgumentNullException>(() => _analyzer.CalculateScore(players));
        }

        [Fact]
        public void CalculateScore_EmptyPlayers_Returns0()
        {
            var players = new List<Player>();

            var result = _analyzer.CalculateScore(players);

            Assert.Equal(0, result);
        }
    }
}