using System.Collections.Generic;
using System.Linq;

namespace Greed
{
    public class GreedScorer
    {
        private List<int> _dice;
        private int _score = 0;

        public int Score(List<int> dice)
        {
            _dice = dice;

            ScoreTriples();
            ScoreSingles();

            return _score;
        }

        public void ScoreTriples()
        {
            for (int i = 1; i <= 6; i++)
            {
                if (DiceContainsThreeOfI(i))
                {
                    IncrementScoreForI(i);
                    RemoveThreeInstancesOfIFromDice(i);
                }
            }
        }

        public void ScoreSingles()
        {
            _score += _dice.Sum(x => x == 1 ? 100 : 0);
            _score += _dice.Sum(x => x == 5 ? 50 : 0);
        }

        private bool DiceContainsThreeOfI(int i)
        {
            return _dice.Count(x => x == i) >= 3;
        }

        private void IncrementScoreForI(int i)
        {
            _score += i == 1 ? 1000 : i * 100;
        }

        private void RemoveThreeInstancesOfIFromDice(int i)
        {
            _dice.Remove(i);
            _dice.Remove(i);
            _dice.Remove(i);
        }
    }
}
