using System;

namespace HelloManchego
{
    public class Score
    {
        private int points = 0;
        private const int RIGHT_ANSWER_POINTS = 10;
        private const int WRONG_ANSWER_PENALTY = 2;

        public Score(int points, int RIGHT_ANSWER_POINTS, int WRONG_ANSWER_PENALTY)
        {
            this.points = points;
            this.RIGHT_ANSWER_POINTS = RIGHT_ANSWER_POINTS;
            this.WRONG_ANSWER_PENALTY = WRONG_ANSWER_PENALTY;
        }

        // TODO Add getters & setters

        /* TODO Refactor as one with a boolean parameter representing a correct answer,
        then adding or subtracting points basedon the input value (true/false) */
        int addPoints()
        {
            points += RIGHT_ANSWER_POINTS;
            return points;
        }

        int subtractPoints()
        {
            points -= WRONG_ANSWER_PENALTY;
            return points;
        }

    }
}